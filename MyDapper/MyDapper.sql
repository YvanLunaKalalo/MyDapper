SELECT * FROM Course
SELECT * FROM Enrollment
SELECT * FROM Instructor
SELECT * FROM Student
SELECT * FROM Subject

Create Table Course(
CourseId INT PRIMARY KEY IDENTITY(1,1),
Course_Name NVARCHAR(50),
Desciption NVARCHAR(50),
)

Create Table Student(
StudentId INT PRIMARY KEY IDENTITY(1,1),
First_Name NVARCHAR(50),
Last_Name NVARCHAR(50),
)

Create Table Instructor(
InstructorId INT PRIMARY KEY IDENTITY(1,1),
First_Name NVARCHAR(50),
Last_Name NVARCHAR(50),
)

Create Table Subject(
SubjectId INT PRIMARY KEY IDENTITY(1,1),
Subject_Name NVARCHAR(50),
Description NVARCHAR(50),
)

INSERT INTO Student(First_Name,Last_Name)
VALUES('Yvan', 'Kalalo')

