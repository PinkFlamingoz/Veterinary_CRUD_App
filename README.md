# Veterinary_CRUD_App
Application for creating, reading, updating and deleting data on a SQL server!

 ## How to run the app
   1. Either fork or download the app and open the folder in your preferred IDE.
 2. To actually start this program, you must change the `ConnectionStrings` in the `appsettings.json` file.
      - Navigate to `Dashboard-Store-App > appsettings.json`.
      - ``` c#
            {
              "ConnectionStrings": {
                "MyDatabase": "Enter server name; DataBase=My_Fancy_Store; Integrated Security=true; Encrypt=False;"
              }
            }
        ```
      - Next use the `vet_store_database.sql` file to create the database in your server.
        - For this I just run the `vet_store_database.sql` file in the [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?redirectedfrom=MSDN&view=sql-server-ver16)
   3. Enjoy
    
 ## Features
- Presentation of a detailed table of content.
- Searching feature for the database (search by Pet ID, Pet Name, Pet Type, Pet Color, Pet Age and Pet Owner).
- Adding feature for the database.
- Edit feature for the database.
- Delete feature for the database.
- Resize application window.

 ## How the app looks
![alt text](https://github.com/PinkFlamingoz/Veterinary_CRUD_App/blob/master/VCA1.png)
![alt text](https://github.com/PinkFlamingoz/Veterinary_CRUD_App/blob/master/VCA2.png)
![alt text](https://github.com/PinkFlamingoz/Veterinary_CRUD_App/blob/master/ezgif-1-d930d432f7.gif)
![alt text](https://github.com/PinkFlamingoz/Veterinary_CRUD_App/blob/master/ezgif-1-cdec02a9cf.gif)
![alt text](https://github.com/PinkFlamingoz/Veterinary_CRUD_App/blob/master/ezgif-1-3cdbf10484.gif)
![alt text](https://github.com/PinkFlamingoz/Veterinary_CRUD_App/blob/master/ezgif-1-2c84cd19f7.gif)
![alt text](https://github.com/PinkFlamingoz/Veterinary_CRUD_App/blob/master/ezgif-1-12e522ca58.gif)
