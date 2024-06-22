create table product
( id bigint primary key ,
  name varchar not null
);

create table category
(
    id bigint primary key ,
    name varchar not null
);

create table product_category
(
    id bigint primary key ,
    product_id bigint not null ,
    category_id bigint not null ,
    constraint fk_product_category_product_id foreign key (product_id) references product(id),
    constraint fk_product_category_category_id foreign key (category_id) references category(id)
);

insert into product (id, name) values
(1, 'Воппер'),
(2, 'Картофель-фри'),
(3, 'Кока-кола'),
(4, 'Чизкейк');

insert into category (id, name) values
(1, 'Бургеры из говядины'),
(2, 'Холодные напитки'),
(3, 'Закуски');

insert into product_category (id, product_id, category_id) values
(1,1,1),
(2,2,3),
(3,3,2);

select product.name as product_name, category.name as category_name from product 
left join product_category on product_category.product_id = product.id
left join category on category.id = product_category.category_id;