use Videomg

create table videomg
(
	vcode varchar(14) primary key NOT NULL,
	genre varchar(20),
	_subject varchar(100) NOT NULL,
	act varchar(50),
	direct varchar(50),
	company varchar(50),
	out_date varchar(20)
)
create table membermg
(
	mcode int primary key NOT NULL,
	iname varchar(20) NOT NULL,
	jumin varchar(20) NOT NULL,
	sinbun varchar(20),
	sex varchar(10),
	phone varchar(20) NOT NULL,
	pcs varchar(20),
	zip varchar(10),
	_address varchar(100)
)
create table lent
(
	lentcode int identity(1,1) primary key NOT NULL,
	mcode int NOT NULL,
	vcode varchar(14) NOT NULL,
	lent_date varchar(30) NOT NULL,
	return_date1 varchar(30),
	return_date2 varchar(30),
	lent_pay int,
	delay_pay1 int,
	delay_pay2 int,
	vsubject varchar(100)
)
create table lentoption
(
	vcode int primary key NOT NULL,
	vdate varchar(10) NOT NULL,
	lent_date varchar(10) NOT NULL,
	lent_pay varchar(10) NOT NULL,
	delay_pay varchar(10) NOT NULL
)

alter table lent add constraint FK_lent_videomg foreign key(vcode)
references videomg(vcode)
on delete cascade on update cascade