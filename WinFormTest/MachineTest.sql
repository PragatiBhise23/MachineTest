Create database MachineTest
create table Employee(eid int primary key,ename varchar(50))
insert into Employee(eid,ename)values
(1,'Pragati'),(2,'Satyam');
drop table Employee
create table Employee(eid int primary key,ename varchar(50),designation varchar(50),address varchar(100))
insert into Employee(eid,ename,designation,address)values
(1,'Pragati','Junior Developer','Pune'),(2,'Satyam','Senior Developer','Mumbai');