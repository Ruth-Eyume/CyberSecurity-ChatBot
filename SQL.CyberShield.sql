CREATE DATABASE CyberShieldDB;
GO

Use CyberShieldDB;

Create table Tasks
(
    Id Int identity(1,1) primary key,
    Title varchar(100) NOT NULL,
    Description varchar(255),
    ReminderDate DATE NULL,
    IsCompleted BIT DEFAULT 0
);
select * from Tasks;
