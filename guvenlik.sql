create database guvenlik
use guvenlik
create table tbl_parola(
id int,
ad nchar(50),
s�free nchar(10)
)

insert into tbl_parola(id, ad, s�free)
values(1, 'damla', '1111')

select * from tbl_parola

/*�al��m�yor

insert into parola(id, ad, s�fre)
values(1, 'admin', '12345')

insert into parola(id, ad, s�fre)
values(1, 'damla', '1111')

select * from parola

use guvenlik 
create table parola(
id int,
ad nchar(50),
s�fre nchar(10)
)*/