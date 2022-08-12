# Sweet and Savory Explorer

Author: _**Kyle Chinick**_

Marketing app that showcases the flavors and treats of Pierre's Sweet and Savory Treats business. This MVC app uses many-to-many relationships with login functionality to manage user access to editing features.

---

## Technologies Used

- _C#_
- _.NET 6.0_
- _HTML / CSHTML / RAZOR / LINQ_
- _Entity_

---

## Description

TBD

---

## Setup/Installation Requirements

1. Clone this repository to your desktop by executing `git clone https://github.com/kylechinick/sweet-and-savory-explorer.git` in your preferred terminal application.

2. In the terminal, cd into the `/SweetAndSavoryExplorer/` directory then execute the `dotnet restore` command to auto-populate the project with an `/obj/` directory and its required contents.

3. Ensure you have the following packages by running the following terminal commands for installing each:
   `dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0`
   `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0-alpha.2`
   `dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 6.0.0`

4. Create an 'appsettings.json' file in the project root and populate it with the following content, taking care to update with your unique database configurations:
   `{ "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=sase-db;uid=root;pwd=[YOUR PASSWORD];" } }`

   - NOTE: [password] should be replaced by your password. Do not include square brackets in final configuration.

5. Execute `dotnet build` in the terminal to automatically create the required `/bin/` folder for the project.

6. To build out a database with a code first approach ensure the following packages have been installed/updated on your machine via these terminal commands:
   `dotnet tool update --global dotnet-ef --version 6.0.0`
   `dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0`

7. To create a record, or snapshot, of the current database run the following command:
   `dotnet ef migrations add Initial`

   - NOTE: Repeat this command, after updating 'Initial' to whichever name best represents your new database snapshot, any time a change is made to the database.

8. Run the following command to update your database to reflect the recent migration data:
   `dotnet ef database update`

9. To start and run the app execute `dotnet run` from the `/SweetAndSavoryExplorer/` directory or, optionally, `dotnet watch run` to start the app and cause it to rebuild and run after each saved change to the codebase.

## Known Bugs

- N/A
