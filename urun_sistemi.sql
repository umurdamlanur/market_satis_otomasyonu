create database ürün_sistemi
use ürün_sistemi
create table ürün(
urunkodu int not null,
urunadi varchar(50),
urunfiyati decimal(18,2),
urunmiktari int 
)

select * from ürün

alter table ürün
alter column urunfiyati decimal(18,2)