create table employee(empid bigint,empname varchar(100),deptname varchar(50),empcity varchar(20),empsalary varchar(200))

insert into employee values(1,'priyanka','computer','pune',40000)

insert into employee(empid,empname,deptname,empcity,empsalary)values(2,'prachi','IT','kamshet',50000)
insert into employee(empid,empname,deptname,empcity,empsalary)values(3,'sweety','sales','nigadi',60000)
insert into employee(empid,empname,deptname,empcity,empsalary)values(4,'guddi','HR','shirgaon',70000)
insert into employee(empid,empname,deptname,empcity,empsalary)values(5,'vishakha','computer','mumbai',80000)

insert into employee values(6,'vedanshi','computer','pune',30000)
insert into employee values(7,'pari','IT','noida',20000)
insert into employee values(8,'sanu','sales','chennai',10000)
insert into employee values(9,'chhakuli','HR','banglore',45000)
insert into employee values(10,'pallavi','computer','pune',35000)

select * from employee

--projection
select empname, empsalary from employee
select empid,empname,empcity from employee

--field filteration
select * from employee where deptname='computer' 
select * from employee where empcity='kamshet'

--relational operator->,<,>=,<=
select * from employee where empsalary>35000
select * from employee where empsalary>=40000 and deptname='computer'
select * from employee where empsalary>=40000 and deptname!='computer'

--relational operator-like
select * from employee where empname like'p%'
select * from employee where empname like'%dd_'
select * from employee where empname like'_r%k_'
--relational operator-in and not in
select * from employee where empcity in('pune','mumbai','delhi')
select * from employee where empcity='kamshet' or empcity='nigadi'
select * from employee where empcity not in('pune','mumbai','delhi')
--relational operator-between and  ----    >=,<=
select * from employee where empsalary between 50000 and 80000
select * from employee where empsalary>=50000 and empsalary<=80000

--ordering
select * from employee order by empname asc
select * from employee order by empname desc

select * from employee order by empsalary asc
select * from employee order by empsalary desc

select * from employee order by empsalary desc, empname asc

--grouping
select deptname from employee group by deptname

select deptname , count(*)as counts from employee group by deptname

select deptname , count(*)as counts, Sum(empsalary)as TotalSalary,Min(empsalary)as MinSalary,Max(empsalary)as MaxSalary,Avg(empsalary)as AvgSalary  from employee group by deptname

select sum(empsalary) as totalsalary,count(*)as totalname from employee group by deptname having deptname in('computer', 'HR') 


select * from customer
select customerAddress ,min(creditLimit)as minimum,max(creditLimit)as maximum,sum(creditLimit)as totalcredit,count(*)as countofcustomer from customer group by customerAddress

ALTER TABLE [dbo].[employee]
ALTER column empsalary BIGINT
GO

--top clause
select top 3 * from employee order by empsalary asc
select top 3 * from employee order by empsalary desc

--update query
update customer set customerAddress='pune' where customerId=7
update customer set emailId='nishu@gmail.com' where customerId=7
update customer set mobileNo='5465765876' where customerId=7
update customer set creditLimit=30000 where customerId=7

--delete query
delete from customer where customerAddress='jaipur' 
