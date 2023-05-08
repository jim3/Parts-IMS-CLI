## Inventory Management System CLI App (C#)

### Description

This is a CLI app for an inventory management system (for parts). It allows the user to `Create`, `Read`, `Update`, and `Delete` parts in an inventory.
The app is written in C# and uses a SQLite3 database to store the inventory data.

_The app supports the following actions:_

### Create

The `createPart()` function creates a part in the inventory. The create command has the following parameters:

### Read

The `readPart()` function reads all of the parts from the inventory.

### Update

The `updatePart` updates the quantity present in the inventory.

### Delete

The `deletePart()` function deletes a part from the inventory.

### Exit

The `exit()` function exits the app.

---

### Installation

Install the NuGet package via `dotnet add package System.Data.SQLite --version 1.0.117` to use SQLite3 with C#.

To install the app, clone the repo and run the app with `dotnet watch run` or `dotnet run`.

`git clone https://github.com/jim3/Parts-IMS-CLI.git`

`cd Parts-IMS-CLI`

`dotnet watch run` or `dotnet run`

**Usage**

// TODO

---
