# Student Management System

A simple Windows Forms application built using **C# (.NET)** and **SQL Server** to perform basic **CRUD operations** (Create, Read, Update, Delete) for managing student data.

##  Features

- Add new student records
- View all students in a grid
- Edit and update student information
- Select a student by clicking a row in the grid
- Display students in a clean tabular format
- Connects to SQL Server using ADO.NET

##  Technologies Used

- C# (.NET Windows Forms)
- Microsoft SQL Server
- ADO.NET (using `SqlConnection`, `SqlCommand`, `SqlDataAdapter`)
- Visual Studio 2022
- Git for version control

##  Database Structure

**Table Name**: `StudentDataTable`

| Column Name | Data Type | Description         |
|-------------|-----------|---------------------|
| ID          | INT       | Primary Key (Auto)  |
| FULL_NAME   | NVARCHAR  | Student's full name |
| AGE         | INT       | Age of student      |
| GENDER      | NVARCHAR  | Gender              |
| COURSE      | NVARCHAR  | Course enrolled     |

## ⚙ How to Run

1. Clone this repository:
   git clone https://github.com/your-username/your-repo-name.git
