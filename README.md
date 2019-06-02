# AcmeCorporation
Umbraco Assignment

## Getting Started
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.
### 1. Updating The Database

Your first step after downloading, unzipping and loading the solution, should be to open up the `Package Manager Console` in Visual Studio and make sure that `AcmeCorporationAPI` is selected as the 'Default project', if not, you should select it.
<br>When you have made sure that the right project is chosen, you should write in *Update-Database* and let the seed create the products.
<br>**You should now be able to run the API.**

### 2. Installing package.json

Your second step is to open a command prompt and path your way into the AcmeCorporationWebClient foolder. After finding your way to the folder, you must install the dependencies lying within the package.json file by using the command:
```
npm install
```
This command installs a package, and any packages that it depends on.

### 3. Running the Angular app

If you wish to view the code, you can alway use you preferred IDE/Editor. Path your way to the `AcmeCorporationAPI` folder and open it up.
<br>If your IDE/Editor has a terminal of som sort, you can compile and run the app with the following command:
```
npm start
```
Thereafter you guide your way to your browser and go to http://localhost:4200, where your Angular application will show up.

### 4. The structure of the website

You have the top navigation bar guiding you through the page:
- **Home** is where you submit your information and serial number to enter the draw.
- **Draw** is where you can see the entered draws.
- **Products** is where you can see the products.
- **Profile** will lead you to my LinkedIn profile.

## Running Manual Tests
Here I will guide you through the process of manual testing what to look out for.

### Things to Test / Look out for
- **Front-End Validation** - E-mail and Product Serial Number should be required
- **Serial Number Limit** - There should be a limit of 2 submissions per serial number
- **10 Draws Per Page** - There shouldn't be more than 10 draws per page
- **Anoumt of Serial Numbers** - I was to generate 100 serial numbers. I achieved this in the 'DataContext' under 'Entities'

First you will need to get a `Product Serial Number` from the `Products` list.
<br>Then you want to go back to the `Home` page and enter the required information. In this case only the E-mail and Serial Number is required.

When you have done this once, you should recieve a confirmation message and can visit the `Draw` page to check if you have indeed entered the draw.

## Future Plans / Possibilities
There's obvious room for improvement here. Such things as:
- **Generation Method** - A method that generates at least 10 draws, as you currently have to do it manually to test the 10 draws per page
- **Copy To Clipboard** - A method to copy the serial number on click, so it's faster to complete the manual test
- **User Login** - An actual user login with Authentication
- **Home Page Products** - 5 to 10 products on the Home page, so you don't have to go to the Products page
