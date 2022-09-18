CREATE TABLE public.categorys (
	id int4 NOT NULL GENERATED ALWAYS AS IDENTITY,
	"name" varchar NOT NULL,
	CONSTRAINT "Categorys_pkey" PRIMARY KEY (id)
);
insert into "categorys" ("name") values
('Продукты питания'),
('Лекарства'),
('Хозяйственные товары'),
('Одежда'),
('Мебель');

CREATE TABLE public.products (
	"Id" int4 NOT NULL GENERATED ALWAYS AS IDENTITY,
	"name" varchar NOT NULL,
	id_category int4 NULL,
	CONSTRAINT "Products_pkey" PRIMARY KEY ("Id")
);
ALTER TABLE public.products ADD CONSTRAINT idcategory FOREIGN KEY (id_category) REFERENCES public.categorys(id);

insert into "products" ("name","id_category") values
('Картофель',1),
('Жидкое мыло',3),
('Тапочки домашние',4),
('Помидоры',1),
('Стул кухонный',5),
('Таблетки от кашля',2),
('Корм для кошек',null);

select products.name as "Имя продукта", categorys.name as "Имя категории"
from products
left join categorys on
products.id_category =categorys.id
