create table custtable(custid bigint primary key,custname varchar(20),address varchar(max),emailid varchar(50),mobileno varchar(20) )
create table bill(billid bigint primary key,billdate datetime,billamt decimal(10,2),custid bigint references custtable)
create table payment(payid bigint primary key,paydate datetime, payamout decimal(10,2),billid bigint references bill)
select * from bill
select * from payment 
select * from custtable
insert into custtable values(1,'priyanka','pune','priya@gmail.com','987456321')
insert into custtable values(2,'sweety','mumbai','sweety@gmail.com','981236321')
insert into custtable values(3,'guddi','nashik','guddi@gmail.com','987475321')
insert into custtable values(4,'vishakha','nagpur','vishakha@gmail.com','989156321')
insert into custtable values(5,'pushpa','delhi','pushpa@gmail.com','991156321')
insert into custtable values(6,'prachi','chennai','prachi@gmail.com','994656321')
insert into custtable values(7,'sonali','hydrabad','sonali@gmail.com','956333321')
insert into custtable values(8,'neha','satara','neha@gmail.com','987411121')

insert into bill values(1,19-01-24,15000,1)
insert into bill values(2,23-05-22,20000,1)
insert into bill values(3,05-01-20,900,1)
insert into bill values(4,01-04-21,11000,2)
insert into bill values(5,05-04-21,800,2)
insert into bill(billid,billdate,custid)values(6,12-07-23,3)
insert into bill(billid,billdate,custid)values(7,13-06-23,4)
insert into bill(billid,billdate,custid)values(8,17-02-23,5)
insert into bill values(9,01-04-21,500,6)
insert into bill values(10,02-05-22,700,6)
insert into bill values(11,03-11-23,1000,7)
insert into bill values(12,04-12-24,700,7)

insert into payment values(1,20-03-23,120000,1)
insert into payment values(2,21-04-22,1000,1)
insert into payment values(3,22-05-21,15000,1)
insert into payment values(4,12-03-21,170000,2)
insert into payment values(5,13-04-20,180000,2)
insert into payment values(6,22-07-21,100,3)
insert into payment values(7,23-08-22,200,4)
insert into payment values(8,24-09-23,7000,3)
insert into payment(payid,paydate,billid) values(11,10-03-23,4)
insert into payment(payid,paydate,billid) values(9,9-04-20,2)
insert into payment(payid,paydate,billid) values(10,8-05-21,7)

--select * from custtable where custid in (select custid from bill where billamt>10000 )
--select * from custtable where custid in (select custid from bill where billid in (select billid from payment where payamout>100000))
--select * from custtable where custid in(select custid from bill where billid in(select billid from payment where payamout IS NULL and billamt IS NOT NULL ))
--select * from custtable where custid in (select custid from bill where billamt IS NULL )

select custtable.*,bill.* ,payment.* from custtable join bill  on custtable.custid=bill.billid join payment on bill.billid=payment.billid where payamout>100000
select custtable.*,bill.* ,payment.* from custtable join bill  on custtable.custid=bill.billid join payment on bill.billid=payment.billid where payamout IS NULL and billamt IS NOT NULL
select custtable.*,bill.* from custtable join bill on custtable.custid=bill.billid where billamt>10000
select custtable.*,bill.*  from custtable join bill  on custtable.custid=bill.billid where billamt IS NULL
