-- Запрос написан из предположения, что таблицы в базе данных имеют следующую структуру:
-- CREATE TABLE product
-- (
--     id   int primary key,
--     name text
-- );
-- CREATE TABLE category
-- (
--     id   int primary key,
--     name text
-- );
-- CREATE TABLE product_to_category
-- (
--     product_id int REFERENCES product (id),
--     category_id int REFERENCES category (id),
--     primary key (product_id, category_id)
-- );

SELECT (product.name, category.name)
FROM product
JOIN product_to_category mapping ON product.id = mapping.product_id
JOIN category ON mapping.category_id = category.id;