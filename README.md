# Library Management System
This is a simple Library Management System web application built with ASP.NET Core 8 MVC and MySQL using Entity Framework Core. It enables basic management of books, members, and borrowing operations in a library.

## Features
- **Book Management**: Add, list, edit, and delete books with validation.
- **Member Management**: Register, list, edit, and delete members.
- **Borrowing**: Borrow and return books while tracking availability.
- **Database**: Persistent storage using MySQL via Entity Framework Core.
- **Responsive UI**: Clean Bootstrap-based interface for easy use.
- **Validation**: Client-side and server-side validation for all inputs.
- 
## Technologies Used
- ASP.NET Core 8 MVC
- Entity Framework Core (EF Core) with MySQL Provider (Pomelo)
- MySQL Database
- Bootstrap 5 for UI styling

## Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- MySQL Server (version 8.0+ recommended)
- MySQL Workbench or any MySQL client (optional, for database management)
- Visual Studio 2022 or Visual Studio Code

## Getting Started
1. **Clone or download the project source code.**
2. **Configure the MySQL database**  
   Create a MySQL database named `librarydb` (or change the name in `appsettings.json`).
3. **Update the connection string**  
   Open `appsettings.json` and change the `DefaultConnection` string with your MySQL credentials:
   ```
   "ConnectionStrings": {
     "DefaultConnection": "server=localhost;port=3306;database=librarydb;user=root;password=YOURPASSWORD"
   }
   ```
4. **Apply EF Core migrations**  
   Open terminal in the project folder and run:
   ```
   dotnet ef database update
   ```
5. **Run the application**  
   ```
   dotnet run
   ```
   The app will be available at `https://localhost:5001` or `http://localhost:5000`.
   
## Project Structure
- `Models/` - Entity classes for Books, Members, Borrowings
- `Data/LibraryContext.cs` - EF Core DbContext configuration
- `Controllers/` - MVC controllers for managing entities
- `Views/` - Razor views for UI pages
- `appsettings.json` - Contains database connection string
- `Program.cs` - Application startup and services configuration

## Usage
- Navigate to `/Book` to manage books.
- Navigate to `/Member` to manage members.
- Navigate to `/Borrowing` to borrow and return books.
  
## Notes
- This is a beginner-friendly project focusing on clarity and simplicity.
- The application uses EF Core Code-First approach for database management.
- Proper validation and error handling is implemented for better user experience.

## Outputs

<img width="953" height="358" alt="Screenshot 2025-09-20 135054" src="https://github.com/user-attachments/assets/b30403fa-004a-44d4-a2ee-02f73ae58277" />
<img width="960" height="386" alt="Screenshot 2025-09-20 135447" src="https://github.com/user-attachments/assets/83e85acd-5dfc-42e5-96c0-bf2fb05f3877" />
<img width="960" height="359" alt="Screenshot 2025-09-20 135436" src="https://github.com/user-attachments/assets/d3bf148f-359b-4d0b-85bc-1f6b7dd01c65" />
<img width="960" height="327" alt="Screenshot 2025-09-20 135642" src="https://github.com/user-attachments/assets/5ca4ff44-43fa-4857-9809-cd6dfb4a9875" />
<img width="959" height="379" alt="Screenshot 2025-09-20 135329" src="https://github.com/user-attachments/assets/a5aec736-6972-4304-8503-5482991b3d15" />

Thank you for reviewing the project. Feel free to reach out if you have any questions.

*Developed by Kulan Tarei*  
*Date: September 2025*

```
