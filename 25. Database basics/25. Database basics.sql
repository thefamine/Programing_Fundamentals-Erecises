create database employees;
use employees;
CREATE TABLE people (
   id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
   email VARCHAR(40) NOT NULL,
   first_name VARCHAR(40) NOT NULL,
   last_name VARCHAR(40) NOT NULL
);
INSERT INTO `people`(`email`,`first_name`,`last_name`)
VALUES('example@abv.bg','George','Smith'),
('pesho@gmail.com','Pesho','Peshev') ;

SELECT *FROM `people`;
SELECT `first_name`,`last_name` FROM `people`;
SELECT `first_name`,`last_name` FROM `people` LIMIT 1 ;

update `people`
set `last_name` = 'Gyz'
where `id`=1;

truncate table `people`;

Create database softuni;
use softuni;
CREATE TABLE students (
   id INT PRIMARY KEY AUTO_INCREMENT,
   first_name VARCHAR(50) NULL,
   last_name VARCHAR(50) NULL,
   age INT NULL,
   grade DOUBLE Null
);
INSERT INTO `students`(`first_name`,`last_name`,`age`,`grade`)
VALUES('Guy',	'Gilbert',	'15',	'4.5'),
('Kevin',	'Brown',	'17',	'5.4'),
('Roberto',	'Tamburello',	'19',	'6'),
('Linda',	'Smith',	'18',	'5'),
('John',	'Stones',	'16',	'4.25'),
('Nicole',	'Nelson',	'17',	'5.50');
SELECT *FROM `students`;
SELECT `last_name`,`age`,`grade` FROM `students`;
SELECT *FROM `students` LIMIT 5 ;
SELECT `last_name`,`grade` FROM `students` limit 5;
truncate table `students`;
drop table `students`;
