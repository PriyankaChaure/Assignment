select * from employee
select * from depttable2
select * from emp2
select * from city
create table depttable2(deptid bigint identity(10,2) primary key,deptname varchar(20) not null unique,cityid bigint references city)
insert into depttable2 values('computer',1)
insert into depttable2 values('sales',2)
insert into depttable2 values('purchase',3)
insert into depttable2 values('mechanical',4)
insert into depttable2 values('civil',5)
create table emp2(empid bigint identity(1,1) primary key,empname varchar(20) not null,address varchar(max),emailid varchar(40) default('admin@gmail.com'),mobileno varchar(20) unique, salary decimal(10,2) check(salary>1000),deptid bigint references depttable2)
insert into emp2 values('priyanka','pune','priya@gmail.com','9874563210','15000',10)
insert into emp2 values('prachi','kamshet','prachi@gmail.com','9874565641','12000',12)
insert into emp2 values('pooja','nigdi','pooja@gmail.com','9846565641','11000',14)
insert into emp2 values('pranjal','mumbai','pranjal@gmail.com','9736565641','9000',16)
insert into emp2 values('sweety','goa','sweety@gmail.com','9736123441','9000',18)
insert into emp2(empname,address,mobileno,salary,deptid) values('guddi','goa','9326123441','15000',12)
insert into emp2 values('vishakha','mumbai','vishakha@gmail.com','9736523641','9000',14)
insert into emp2 values('shital','goa','shital@gmail.com','9736110441','9000',16)