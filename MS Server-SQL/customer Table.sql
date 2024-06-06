create table customer(customerId bigint,customerName varchar(100),customerAddress varchar(max),emailId varchar(40),mobileNo varchar(20),creditLimit decimal(10,2))

insert into customer values(1,'priyanka','pune','priya@gmail.com','343546456',50000)
insert into customer values(2,'prachi','mumbai','prachi@gmail.com','6757868',60000)
insert into customer values(3,'Vishakha','delhi','vishakha@gmail.com','342556',70000)
insert into customer values(4,'sweety','noida','sweety@gmail.com','4565768',80000)
insert into customer values(5,'nishu','chennai','nishu@gmail.com','45363475',90000)
insert into customer values(6,'guddi','hydrabad','guddi@gmail.com','43546722',40000)
select * from customer

insert into customer (customerId,customerName)values(7,'nishu')
insert into customer (customerId,customerAddress)values(8,'jaipur')
insert into customer (customerId,emailId)values(9,'babli@gmail.com')
insert into customer (customerId,mobileNo)values(10,'53465476')