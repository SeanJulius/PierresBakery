# PierresBakery

by Sean Julius

This webpage is designed to give an introduction to Sean Julius's beginnings in coding.
Technologies Used
* _C#_
* _MSTest_
* _.NET_
* _REPL_
* _VS Code_


## Description:

A bakery program using C# that a user can decide how pieces of loaves/pastry they want. Conditions: Bread: Buy 2, get 1 free (every 3rd loaf of bread is free.). A single loaf costs $5, two loaves costs $10, and three loaves cost $10. Pastry: Buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10.

## Application Setup Instructions

* _Clone this repository to your desktop._
* _Navigate the directory: (cd top name directory)_
* _Open in Vs code: code ._
* _Navigate to the "bakery.tests" within the terminal_
* _Run: dotnet restore_
* _Navigate to "bakery"_
* _In this directory type "dotnet run" to run the program._

## Known Bugs

No known bugs

## Tests:

* _Test for the cost of 1 loaf of bread. The loaf price is $5._
* _Test for the cost of 3 loaf of bread. The loaf price was changed to $18, but it's supposed to be $10 to get a failed result._
* _Test for the cost of 5 loaf of bread. The loaf price was changed to $38, but it's supposed to be $20 to get a failed result._
* _Test Fail: make 3 pastries for $1200 instad of $5.Very pricy for an error!_
* _Test pastry logic by adding regQuant in order for succesful fail._
* _Test Pastry Restored to updatedQuant_


## Licensing

Copyright (c) 2022 Sean Julius
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

## Description

This project allows the user to add a number representing the United States currency. Then from a drop down field select the country that the user would like to see the US currency converted to. Then the user just has to press "Get Rate" and the currency will be converted.


