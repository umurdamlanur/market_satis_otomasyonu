create database guvenlik
use guvenlik
create table tbl_parola(
id int,
ad nchar(50),
sıfree nchar(10)
)

insert into tbl_parola(id, ad, sıfree)
values(1, 'damla', '1111')

select * from tbl_parola

/*çalışmıyor

insert into parola(id, ad, sıfre)
values(1, 'admin', '12345')

insert into parola(id, ad, sıfre)
values(1, 'damla', '1111')

select * from parola

use guvenlik 
create table parola(
id int,
ad nchar(50),
sıfre nchar(10)
)*/