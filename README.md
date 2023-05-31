# BankFileParsers
Need something in .Net to parse BAI and SWIFT files

We're not sure what we need, so I plan on doing ~~both~~, looks like just the BAI file for now:
 - [BAI](https://www.bai.org/libraries/site-general-downloads/cash_management_2005.sflb.ashx)
 - ~~[SWIFT](https://deutschebank.nl/nl/docs/MT94042_EN.pdf)~~

## TODO
 - [x] Start the project
 - [x] Parse the files
 - [x] Write parsed output to exact input
 - [ ] override ToString() to clean up the Write Method
 - [x] Create a Translation class to take the parsed files into detail
 - [x] Handle the fund type "D"
 - [x] Use the new Transaction Detail object (more informative than the 010 code)
 - [x] Use the Currency Code to figure out the correct currency amount
 - [x] Create a method so the user can convert the amount
 - [x] ~~Take the translation and write the input file~~ Don't have time to do this right now
 - [x] Output Summary and Detail to CSV files

## SUMMARY/HEADER TABLE
I'm borrowing heavily from the [Field Mapping for Automatic Bank Statement Processing](https://docs.oracle.com/cd/E16582_01/doc.91/e15112/mapfieldsautobankstate.htm#EOAGA01054), but I will only be using fields that are used in the BAI file

Table definition can be found [here](http://www.jdetables.com/?schema=812&table=F09610)

See [SummaryHeader](BankFileParsers/Classes/SummaryHeader.cs) for output

## DETAIL TABLE
Table definition can be found [here](http://www.jdetables.com/?schema=812&table=F09611)

See [DetailSummary](BankFileParsers/Classes/DetailSummary.cs) for output

## USAGE
```
Install-Package BankFileParsers
```

The first class that you will need to use is the ```BaiParser```. It's actually pretty basic; it takes an existing BAI file and creates an object tree/graph

```csharp
var parser = new BaiParser();
var bai = parser.Parse("--path to file--");
```

The ```bai``` object created above will contain a _thin_ object graph that follows this format

```
BaiFile
|-- List<BaiGroup>
  |-- List<BaiAccount>
    |-- List<BaiDetail>
```
So, a BaiFile contains a List of Groups, Each Group has a list of accounts; each account has a list of details - whew!

This actually follows the spec defined in the BAI document listed above.

You can in turn ask the parser to write the parsed data back out like so

```csharp
parser.Write("--new filename--", bai);
```

This **should** create a file that is an exact match as the original file (100% matches on the four files I use in testing).

The parsed data may or may not be of any use to you. If you need more *translation* there is the ```BaiTranslator```
This object is responsible for Translating the parsed data to something that could be more usable and the object graph is very similar to the one the parser creates.

```csharp
var trans = BaiTranslator.Translate(bai);
```

This then returns a TranslatedBaiFile with ```List<Group>```, ```List<Account>``` with ```List<Fund>``` and ```List<Detail>``` with the only object added is the List of Fund

### Additions

The document states that the Detail can contain a Text field and those can have continuation records. This seems more like a free form text field and it's up to the financial institution to define what they put in there. Since this could mean anything I've added a TextList object that tries to parse each individual section in the text file into individual lines. For example you could have a text filed that looks like this (sensitive information redacted):

```
PREAUTHORIZED ACH CREDIT/PREAUTHORIZED ACH FROM:SOME BANK I                     100115/ORIGINATOR ID:XXXXXXXXXX4108/ENTRY DESCRIPTION:DESCRIPTION HERE/PAYMENT ID:105XXXXXX/RECEIVER INFORMATION:YOUR BANK ACCOUNT/TRACER ID NUMBER:XXX27400XXXXXXX/ADDENDA INFORMATION:/TRN*1*XXXXXXXXXXXXXXX*XXXXXXXXXX/,XXXXXXXXXXXX/
```

This could be something else that needs to be parsed - and TextList does just that - detail.TextList would look like this for the previous line

```
[0] = PREAUTHORIZED ACH CREDIT
[1] = PREAUTHORIZED ACH FROM:SOME BANK I                     100115
[2] = ORIGINATOR ID:XXXXXXXXXX4108
[3] = ENTRY DESCRIPTION:DESCRIPTION HERE
[4] = PAYMENT ID:105XXXXXX
[5] = RECEIVER INFORMATION:YOUR BANK ACCOUNT NAME
[6] = TRACER ID NUMBER:XXX27400XXXXXXX
[7] = ADDENDA INFORMATION:TRN*1*XXXXXXXXXXXXXXX*XXXXXXXXXX
[8] = XXXXXXXXXXXX
```

I then noticed that several TextLists had similar names or a key:value so I added TextDictionary to the detail object and that would look like this (JSONified)

```json
{
    "PREAUTHORIZED ACH FROM": "SOME BANK I                     100115",
    "ORIGINATOR ID": "XXXXXXXXXX4108",
    "ENTRY DESCRIPTION": "DESCRIPTION HERE",
    "PAYMENT ID": "105XXXXXX",
    "RECEIVER INFORMATION": "YOUR BANK ACCOUNT NAME",
    "TRACER ID NUMBER": "XXX27400XXXXXXX",
    "ADDENDA INFORMATION": "TRN*1*XXXXXXXXXXXXXXX*XXXXXXXXXX XXXXXXXXXXXX"
}
```

Since the TextList and TextDictionary are additions to the spec I would not count on them containing any data (they will not be null however).

While browsing options that were out there for the BAI file I ran into a utility that would translate the BAI file into two CSV files. I've replicated those in the
```BaiTranslator.GetSummaryInformation``` and ```BaiTranslator.GetDetailInformation``` helpers and they are used like to

```csharp
var summary = BaiTranslator.GetSummaryInformation(trans);
```
This returns a ```List<SummaryHeader>``` and each of the fields are marked with a Usage attribute that specifies if they were from 
Oracle, TreasurySoftware, or Both, the attribute isn't necessary, but you could use it to figure out why it's there.

```csharp
var dictionaryKeys = new List<string> { "PAYMENT ID", "ADDENDA INFORMATION" };
var detail = BaiTranslator.GetDetailInformation(trans, dictionaryKeys); // dictionaryKeys can be null
```

This returns a ```List<DetailSummary>``` again, each of the fields are marked with a Usage attribute

Note: The dictionaryKeys are a list of Key names that _could_ be in the TextDictionary object that you would like returned.
If it's found in the detail object, it's returned in the DetailSummary - think of it like a filter. 
This could be handy if the detail TextDictionary finds 18 key/value pairs and you're only concerned with one or two of them

You can use the two lists above as is, or you can use a helper extension method to generate CSV data, and you would use it like this

```csharp
var csv = detail.ExportToCsv();
File.WriteAllText(@"BAI-sample.csv", csv);
```

This will put all fields in the detail object in a list of CSV (with a header). 
You can use the two optional parameters to specify which fields you would like to export as well as which dictionary keys you would like to export.
You can use it as so:

```csharp
var csv = detail.ExportToCsv(dictionaryKeys, new List<string> {"Date", "Amount"});
File.WriteAllText(@"BAI-sample.csv", csv);
```
Dictionary keys are appended to the normal csv output.
A clever person could see that using reflection they can get a list of the field names with a usage type of Oracle and Both to just export the fields defined/used there.

So the above code would create a csv file that would look like so:

|Date|Amount|PAYMENT ID|ADDENDA INFORMATION|
|----|------|----------|-------------------|
|10/12/2015|100.00|xxxxx|TRN*1*XXXXXXXXXXXXXXX*XXXXXXXXXX XXXXXXXXXXXX|
|10/12/2015|200.00|yyyyy|TRN*2*XXXXXXXXXXXXXXX*XXXXXXXXXX XXXXXXXXXXXX|

etc...

This is all it was intended to do - add an issue or pull request and we can make some changes


## CHANGE LOG
### [0.2.0] - 2023-05-31
#### Changed - possible breaking change
- Added net7.0 TFM (Target framework moniker)
- I have a new bank, the format is quite a bit different. This version 'should not' break existing functionality, but I don't have your files, so I can't guarantee it. The change is how the BaiTranslator handles continuation records (88's). The old way (which is the default) just did a string += otherString. The new option does a TrimEnd('/') + Environment.NewLine. This made it WAY easier for me to handle that data. I also didn't want to pass values to several objects, so it's a static property (not really a fan, but easy).
  - Setting `BaiTranslator.BaiTranslator88LineHandler = BaiTranslator88LineHandler.TrimSlashNewLine` before calling BaiTranslator.Translate will get you the new functionality.
  - Leaving it alone, or setting it to `BaiTranslator.BaiTranslator88LineHandler = BaiTranslator88LineHandler.OldWay` works the old way. I tested this with several files and it still worked (woot).
- The new Translator returns the full dictionary of items if it finds any, so you might not need to use keys. Keys still work however.
- Sorry for the lack of imagination on my end.

### [0.1.10] - 2022-09-21
#### Changed
- Via PR #23 - added two methods:
    - ParseText() - takes BAI file contents as a string, instead of BAI file name
    - GetFileText() - returns parsed BAI file contents as a string array, instead of writing to a file.

### [0.1.9] - 2022-08-22
#### Changed
- Via PR #19 - added the ability to overwrite the Transaction Detail Line

### [0.1.8] - 2022-07-01
#### Changed
- Added license to nuget package to remove pack warning

### [0.1.7] - 2022-07-01
#### Changed
- Added .net standard, core and .net 6 support
  TargetFrameworks: net4.5;netstandard2.0;netstandard2.1;net5.0;net6.0