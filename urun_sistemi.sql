create database �r�n_sistemi
use �r�n_sistemi
create table �r�n(
urunkodu int not null,
urunadi varchar(50),
urunfiyati decimal(18,2),
urunmiktari int 
)

select * from �r�n

alter table �r�n
alter column urunfiyati decimal(18,2)