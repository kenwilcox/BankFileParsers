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
 - [ ] Handle the fund type "D"
 - [x] Use the new Transaction Detail object (more informative than the 010 code)
 - [x] ~~Use the Currency Code to figure out the correct currency amount (right now it's still a raw string)~~
 - [x] Create a method so the user can convert the amount
 - [x] ~~Take the translation and write the input file~~ Don't have time to do this right now

## SUMMARY/HEADER TABLE
I'm borrowing heavily from the [Field Mapping for Automatic Bank Statement Processing](https://docs.oracle.com/cd/E16582_01/doc.91/e15112/mapfieldsautobankstate.htm#EOAGA01054), but I will only be using fields that are used in the BAI file

Table definition can be found [here](http://www.jdetables.com/?schema=812&table=F09610)

Column|Field|Description|Data Type|Edit Type|Length|Decimals
------|-----|-----------|---------|---------|------|--------
1|SGBSTN|Auto Bank Statement Number|Numeric|Generic Edit|15|0
2|SGSTMD|Statement Date|Date|Generic Edit|6|0
3|SGBAN|Electronic Bank Account Number|String|Generic Edit|29|0
4|SGBSSEQ|Bank Statement Sequence|Numeric|Generic Edit|5|0
5|SGBKSTID|Bank Statement ID|Numeric|Generic Edit|15|0
6|SGMESST|Electronic Message Type|String|Generic Edit|5|0
7|SGDESC04|Description 4|String|Generic Edit|45|0
8|SGOBDBCR|Opening Balance Debit/Credit Indicator|Character|UDC|1|0
9|SGOLVDT|Opening Booking Date|Date|Generic Edit|6|0
10|SGOCRCD|Opening Currency Code|String|Generic Edit|3|0
11|SGTCRCD|Transaction Currency Code|String|Generic Edit|3|0
12|SGOPBAA|Opening Balance Amount|Numeric|Generic Edit|15|2
13|SGCBDBCR|Closing Balance Debit/Credit Indicator|Character|UDC|1|0
14|SGCBVLDT|Closing Booking Date|Date|Generic Edit|6|0
15|SGCCRCD|Closing Currency Code|String|Generic Edit|3|0
16|SGCLBAA|Closing Balance Amount|Numeric|Generic Edit|15|2
17|SGCADBCR|Closing Available Balance D/C Indicator|Character|UDC|1|0
18|SGCAVLDT|Closing Available Value Date|Date|Generic Edit|6|0
19|SGCACRCD|Closing Available Currency Code|String|Generic Edit|3|0
20|SGCAVAA|Closing Available Balance|Numeric|Generic Edit|15|2
21|SGFADBCR|Forward Available Balance D/C Indicator|Character|UDC|1|0
22|SGFVLDT|Forward Value Date|Date|Generic Edit|6|0
23|SGFACRCD|Forward Available Currency Code|String|Generic Edit|3|0
24|SGFAVAA|Forward Available Balance|Numeric|Generic Edit|15|2
25|SGFIO|File Input/Output|Character|Generic Edit|1|0
26|SGEFI|Electronic Format Indicator|String|UDC|6|0
27|SGRECCODE|Reconciliation Code|Character|UDC|1|0
28|SGETRN|Electronic Trans Ref Number|String|Generic Edit|16|0
29|SGBSSID|Sender Identification|String|Generic Edit|9|0
30|SGBSRID|Receiver Identification|String|Generic Edit|9|0
31|SGBSODF|One Day Float|Numeric|Generic Edit|15|2
32|SGBSTDF|Two Or More Days Float|Numeric|Generic Edit|15|2
33|SGOKPURGE|Ok Purge|Character|Generic Edit|1|0
34|SGUSER|User ID|String|Generic Edit|10|0
35|SGPID|Program ID|String|Generic Edit|10|0
36|SGJOBN|Work Station ID|String|Generic Edit|10|0
37|SGUPMT|Time - Last Updated|Numeric|Generic Edit|6|0
38|SGUPMJ|Date - Updated|Date|Generic Edit|6|0

## DETAIL TABLE
Table definition can be found [here](http://www.jdetables.com/?schema=812&table=F09611)

Column|Field|Description|Data Type|Edit Type|Length|Decimals
------|-----|-----------|---------|---------|------|--------
1|BGBSTN|Auto Bank Statement Number|Numeric|Generic Edit|15|0
2|BGSTMD|Statement Date|Date|Generic Edit|6|0
3|BGBAN|Electronic Bank Account Number|String|Generic Edit|29|0
4|BGBKSTID|Bank Statement ID|Numeric|Generic Edit|15|0
5|BGSTLIN|Staging Line Number|Numeric|Generic Edit|7|2
6|BGBSSEQ|Bank Statement Sequence|Numeric|Generic Edit|5|0
7|BGRECCODE|Reconciliation Code|Character|UDC|1|0
8|BGVLDT|Date - Cleared/Value|Date|Generic Edit|6|0
9|BGBVLDT|Transaction Booking Date|String|Generic Edit|5|0
10|BGDDBCR|Transaction Debit/Credit Indicator|String|UDC|2|0
11|BGTCRCD|Transaction Currency Code|String|Generic Edit|3|0
12|BGCURRT|Transaction Currency Type|Character|Generic Edit|1|0
13|BGAA|Amount|Numeric|Generic Edit|15|2
14|BGTRANT|External Transaction Type|String|Generic Edit|4|0
15|BGCUSTREF|Customer Reference|String|Generic Edit|16|0
16|BGBANKREF|Bank Reference|String|Generic Edit|16|0
17|BGEFI|Electronic Format Indicator|String|UDC|6|0
18|BGSUBF9|Subfield 9|String|Generic Edit|34|0
19|BGBSTEXT|Bank Statement Text|String|Generic Edit|40|0
20|BGINFO1|Misc Information|String|Generic Edit|390|0
21|BGUSER|User ID|String|Generic Edit|10|0
22|BGPID|Program ID|String|Generic Edit|10|0
23|BGJOBN|Work Station ID|String|Generic Edit|10|0
24|BGUPMT|Time - Last Updated|Numeric|Generic Edit|6|0
25|BGUPMJ|Date - Updated|Date|Generic Edit|6|0

