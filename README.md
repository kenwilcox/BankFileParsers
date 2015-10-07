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