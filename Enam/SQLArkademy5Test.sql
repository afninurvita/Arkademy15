--CREATE DATABASE Arka5;

--USE Arka5;

/*
CREATE TABLE Name (
id INT, 
name VARCHAR(255), 
id_work INT, 
id_salary INT
);

CREATE TABLE Work (
id INT,
name VARCHAR(255),
id_salary INT
);

CREATE TABLE Salary (
id INT,
salary INT
);
*/

/*
INSERT INTO Name VALUES (1, 'Rebecca', 1, 1), (2, 'Vita', 2, 2);

INSERT INTO Work VALUES (1, 'Frontend Dev', 1), (2, 'Backend Dev', 2);

INSERT INTO Salary VALUES (1, 10000000), (2, 12000000);
*/

SELECT N.name, W.name, S.salary FROM Name N
INNER JOIN Work W ON W.id = N.id_work
INNER JOIN Salary S ON S.id = N.id_salary;