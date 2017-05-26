use master 
if db_id('library') is not null
   drop database library 
go
create database library 
use library 

if exists (select 1
            from  sysobjects
           where  id = object_id('logintable')
            and   type = 'U')
   drop table logintable
go

if exists (select 1
            from  sysobjects
           where  id = object_id('borinfotable')
            and   type = 'U')
   drop table borinfotable
go

if exists (select 1
            from  sysobjects
           where  id = object_id('booktable')
            and   type = 'U')
   drop table booktable
go

if exists (select 1
            from  sysobjects
           where  id = object_id('readertable')
            and   type = 'U')
   drop table readertable
go

/*==============================================================*/
/* Table: readertable 
   sex ��ʾ�Ա� 1 
*/
/*==============================================================*/
go
create table readertable (
   rrid                 char(20)             not null,
   rname                char(30)             ,
   rsex                 char(2)              default('m'),
   rbcnum               int                  default(16),
   rbhnum               int                  default(0),
   rwdep                char(30)             ,
   rtel                 char(30)             ,
   constraint PK_READERTABLE primary key nonclustered (rrid)
)
go


/*==============================================================*/
/* Table: logintable    
   authority Ȩ�ޣ�1��ʾ����Ա 2��ʾ���� ��Ϊ2ʱ��rid����Ч
	

*/
/*==============================================================*/
create table logintable (
   account              char(20)             not null,
   psw                  char(20)             not null,
   authority            int                  not null,
   rid                  char(20)             null,
   constraint PK_LOGINTABLE primary key nonclustered (account),
   constraint PK_LOGIN_FOREIGN_TABLE foreign key(rid) references readertable(rrid)
)
go


/*==============================================================*/
/* Table: booktable  
   �Ƿ�ɽ� 1 ��ʾ�ɽ� 0��ʾ���ɽ� 
    
*/ 
/*==============================================================*/
create table booktable (
   bid                  char(30)             not null,
   bname                char(30)             not null,
   bpress               char(30)             null,
   author               char(30)             null,
   bnum                 int                  null default(5),
   bhbnum               int                  null default(0),
   bborrow              int                  null default(1),
   constraint PK_BOOKTABLE primary key nonclustered (bid)
)
go

/*==============================================================*/
/* Table: borinfotable                                          */
/*==============================================================*/
create table borinfotable (
   id                   int    identity(1,1)  primary key, --�Զ��������� 
   rrrid                char(20)             not null,
   brid                 char(30)             not null,
   bdate                date             null,
   bterminaldate        date             null,
   returndate           date             null,
   fine                 float            null,
   constraint PK_BORINFO_TO_READER foreign key(rrrid) references readertable(rrid), 
   constraint PK_BORINFO_TO_BOOOK foreign key(brid) references booktable(bid), 
)
go

/*
 ������ص�����
*/

-- ���߱�


insert into  readertable 
values('1201','one','m',16,0,'cs','1300000000')

insert into  readertable 
values('1202','two','f',16,0,'cs','1300000001')

insert into  readertable 
values('1203','third','m',16,0,'cs','1300000003')

insert into  readertable 
values('1204','forth','f',16,0,'cs','1300000002') 



-- ��¼��

--login table
insert into logintable
--����Ա
values('sch','123456',1,null)

insert into logintable 
values('hwk','123456',1,null)

insert into logintable 
values('sjj','123456',1,null)

-- ����
insert into logintable
values('aaa','123456',2,'1201')

insert into logintable
values('bbb','123456',2,'1203')



-- ���
insert into booktable
values('9622150012','c����','�廪������','̷��ǿ',4,2,1)
 
insert into booktable
values('9622150022','������ǹ��','������','������',4,2,1)

insert into booktable
values('9622150032','����������','�»���','������',4,2,1)

insert into booktable
values('9622150042','����','�ô������','�໪',4,2,1)

insert into booktable
values('9622150052','��ѧ����','�ô������','ʷ��',2,1,1)

-- ���ı� �����Զ�����

insert into borinfotable(rrrid,brid,bdate,bterminaldate,returndate,fine) 
values('1201','9622150012','2016-1-1','2016-2-1','2016-1-15',0)

insert into borinfotable(rrrid,brid,bdate,bterminaldate,returndate,fine) 
values('1202','9622150022','2016-2-1','2016-3-1',null,0)

insert into borinfotable(rrrid,brid,bdate,bterminaldate,returndate,fine) 
values('1201','9622150032','2016-3-1','2016-4-1',null,0)

insert into borinfotable(rrrid,brid,bdate,bterminaldate,returndate,fine) 
values('1201','9622150042','2016-4-1','2016-5-1',null,0)

insert into borinfotable(rrrid,brid,bdate,bterminaldate,returndate,fine) 
values('1201','9622150052','2016-4-1','2016-5-1',null,0)


select * from logintable
select * from booktable
select * from readertable
select * from borinfotable

go
create trigger T1
on borinfotable
for update
as
if update(returndate)
begin

update booktable set bhbnum=bhbnum-1
from booktable,inserted i,deleted d
where booktable.bid=d.brid

update borinfotable set fine=datediff(day,d.bterminaldate,i.returndate)
from borinfotable,inserted i,deleted d
where borinfotable.brid=d.brid and borinfotable.returndate>d.bterminaldate

end
go


create trigger T2
on borinfotable
for insert
as
update booktable set bhbnum=bhbnum+1
from booktable,inserted i
where booktable.bid=i.brid
go
