# Pierre's Vendors and Orders

## About

Pierre, the artisan baker, inquired about a new project for a web application tailored to revitalize his bakery's vendor and order management following the success of our first console application we designed for him. This new application welcomes him with a minimalistic yet stylish splash page, offering a user-friendly interface crafted with the MVC (Model, View, Controller) model and Razor syntax. Pierre can easily create new vendor lists, add orders to the relevant vendor, delete all vendors/orders, and or choose to delete vendors/orders individually to help keep track of Pierre's Bakery business.

![PierresPortal.jpg](https://github.com/jeremyjosol/sep292023_PierresVendorsAndOrders/blob/patch/PierresPortal.jpg?raw=true)

## Application Setup

1. Clone the repository `https://github.com/jeremyjosol/sep222023_PierresVendorsAndOrders`

2. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory `PierresVendorsAndOrders`.

3. In the command line, run the command `$ dotnet run` to compile and execute the console application. 
    > Since this is a console application, you'll interact with it through text commands in your terminal.

4. Optionally, you can run `$ dotnet build` to compile this console app without running it.
5. And or, within the project’s testing directory `PierresVendorsAndOrders.Tests` you can choose to run the command `$ dotnet test` to test and ensure quality code.

## Technologies Used

* _Github_
* _VSCode_
* _C#_
* _.NET_

## Available Routes

* localhost:5000/
* localhost:5000/vendors
* localhost:5000/vendors/new
* localhost:5000/vendors/{id}
* localhost:5000/vendors/{id}/orders
* localhost:5000/vendors/{id}/orders/new
* localhost:5000/vendors/{id}/orders/{id}

## Known Bugs

Currently no known bugs. If any issues are identified, please kindly address the issue to the owner of this repository.

## MIT License

Copyright (c) 2023 Jeremy Josol

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.