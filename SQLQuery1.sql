create database EMSdatabase

use EMSdatabase

create table DeptMaster (DeptCode int primary key, DeptName varchar(20))
create table EmpProfile (EmpCode int primary key,DateOfBirth DateTime,EmpName varchar(20),Email Varchar(20),DeptCode int, foreign key(DeptCode)  references DeptMaster(DeptCode) )

insert into DeptMaster values(1,'developing')
insert into EmpProfile values(1,20/07/2000,'pavan','vousbo@gmail.com',1)

Select * from DeptMaster
Select * from EmpProfile