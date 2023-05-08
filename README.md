## Inventory Management System CLI App (C#)

### Description

This is a CLI app for an inventory management system (for parts). It allows the user to `Create`, `Read`, `Update`, and `Delete` parts in an inventory.
The app is written in C# and will use a SQLite3 database to store the inventory data.

_The app supports the following actions:_

### Create

The `createPart()` function creates a part in the inventory. The create command has the following parameters:

-   part number - The part number of the part to create.
-   description (or part type) - The description of the part to create
-   quantity - How many of the part to create.
-   cost - The cost of each fastener.
-   TODO: add more info...

**Read**

The `readPart()` function reads all of the parts from the inventory.

**Update**

The `updatePart` updates the quantity present in the inventory.

**Delete**

The `deletePart()` function deletes a part from the inventory.

**Exit**

The `exit()` function exits the app.

**Usage**

1. To use the app, run `dotnet build`, then `dotnet run` in your VS Code integrated terminal.

2. The app will prompt the user to enter an option 1, 2, 3, 4, or 5.

3. The app will then perform the crud operation and return the results to the user.

