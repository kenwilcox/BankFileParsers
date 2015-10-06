# BankFileParsers
Need something in .Net to parse BAI and SWIFT files

We're not sure what we need, so I plan on doing both:
 - [BAI](https://www.bai.org/libraries/site-general-downloads/cash_management_2005.sflb.ashx)
 - [SWIFT](https://deutschebank.nl/nl/docs/MT94042_EN.pdf)
 
## TODO
 - [x] Start the project
 - [x] Parse the files
 - [x] Write parsed output to exact input
 - [ ] override ToString() to clean up the Write Method
 - [ ] Create a Translation class to take the parsed files into detail
 - [ ] Handle the fund type "D"
 - [ ] Use the new Transaction Detail object (more informative than the 010 code)
 - [ ] Use the Currency Code to figure out the correct currency amount (right now it's still a raw string)
 - [ ] Take the translation and write the input file