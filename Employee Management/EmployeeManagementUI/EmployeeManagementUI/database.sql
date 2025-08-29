
DROP DATABASE IF EXISTS EmployeeDB;
CREATE DATABASE EmployeeDB;

CREATE TABLE hr_users (
    userid SERIAL PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    fullname VARCHAR(100) NOT NULL,
    created_at TIMESTAMP DEFAULT NOW()
);

CREATE TABLE employees (
    employeeid SERIAL PRIMARY KEY,
    firstname VARCHAR(50) NOT NULL,
    lastname VARCHAR(50) NOT NULL,
    position VARCHAR(50),
    department VARCHAR(50),
    datehired DATE,
    salary NUMERIC(10,2),
    status VARCHAR(20) DEFAULT 'Active',
    contact VARCHAR(50)
);
