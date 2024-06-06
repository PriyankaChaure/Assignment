--inner join
select empname,deptname,salary from emp inner join depttable on emp.deptid=depttable.deptid
select * from emp
create table city(cityid bigint identity(1,1),cityname varchar(20) not null)
select * from city
insert into city values('pune')
insert into city values('mumbai')
insert into city values('delhi')
insert into city values('nashik')
insert into city values('goa')
insert into city values('chennai')
insert into city values('goa')
--inner join
select  empname,deptname,cityname from emp inner join depttable on emp.deptid=depttable.deptid inner join city on depttable.deptid=city.cityid
--outer joins
create table atab(aid bigint , value varchar(20))
create table btab(bid bigint , value varchar(20),aid bigint)

insert into atab values(1,'value-1')
insert into atab values(2,'value-2')
insert into atab values(3,'value-3')
insert into atab values(4,'value-4')
insert into atab values(5,'value-5')
insert into atab values(6,'value-6')
insert into atab values(7,'value-7')
insert into atab values(8,'value-8')
insert into atab values(9,'value-9')
insert into atab values(10,'value-10')
select * from atab
select * from btab
insert into btab values(1,'value-1',1)
insert into btab values(2,'value-2',2)
insert into btab values(3,'value-3',3)
insert into btab values(4,'value-4',4)
insert into btab values(5,'value-5',5)
insert into btab values(15,'value-15',6)
insert into btab values(16,'value-16',7)
insert into btab values(17,'value-17',8)
insert into btab values(18,'value-18',9)
insert into btab values(19,'value-19',10)
--inner join
select atab.*,btab.* from atab inner join btab on atab.aid=btab.bid
--left outer join
select atab.*,btab.* from atab left outer join btab on atab.aid=btab.bid
--right outer join
select atab.*,btab.* from atab right outer join btab on atab.aid=btab.bid
--full outer join
select atab.*,btab.* from atab full outer join btab on atab.aid=btab.bid
--cross join
select atab.*,btab.* from atab cross join btab 
select atab.*,btab.* from btab cross join atab
--straight join
select empname,deptname,cityname from emp,depttable,city where emp.deptid=depttable.deptid and depttable.deptid=city.cityid
--self join
select a.*,b.*from atab as a inner join atab as b on a.aid=b.aid


