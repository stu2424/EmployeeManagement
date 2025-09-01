Installation


1. Clone this repo  
  
2.Open the solution in Visual Studio

3.Restore NuGet packages (if any)

4.Update app.config with your PostgreSQL connection string

5.Run the project 🎉



Database Setup 
  
CREATE DATABASE EmployeeDB;

-- Users Table
CREATE TABLE hr_users (
    user_id SERIAL PRIMARY KEY,
    username VARCHAR(50) UNIQUE NOT NULL,
    password VARCHAR(255) NOT NULL,
    role VARCHAR(20) DEFAULT 'HR'
);

-- Employees Table
CREATE TABLE employees (
    emp_id SERIAL PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    position VARCHAR(50),
    salary NUMERIC(10,2)
);
