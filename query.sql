
-- create
CREATE TABLE Categories (
  id int not null,
  name varchar(100),
  PRIMARY KEY(id)
);

CREATE TABLE Products (
  id int not null,
  name varchar(100),
  PRIMARY KEY(id)
);

CREATE TABLE ProductsToCategories (
  productId int,
  categoryId int,
  FOREIGN KEY (categoryId) references Categories(id),
  FOREIGN KEY (productId) references Products(id)
  ON DELETE CASCADE
);

-- insert
INSERT INTO Categories(id,name) VALUES (1, 'Phones');
INSERT INTO Categories(id,name) VALUES (2, 'Clothes');
INSERT INTO Categories(id,name) VALUES (3, 'Books');
INSERT INTO Categories(id,name) VALUES (4, 'Electronic');
INSERT INTO Categories(id,name) VALUES (5, 'Fantastic');
INSERT INTO Categories(id,name) VALUES (6, 'Outerwear');

INSERT INTO Products(id,name) VALUES (1,'Dress');
INSERT INTO Products(id,name) VALUES (2,'Teapot');
INSERT INTO Products(id,name) VALUES (3,'Microphone');
INSERT INTO Products(id,name) VALUES (4,'Jacket');
INSERT INTO Products(id,name) VALUES (5,'Coat');
INSERT INTO Products(id,name) VALUES (6,'Iphone SE');
INSERT INTO Products(id,name) VALUES (7,'Iphone 15 Pro Max');
INSERT INTO Products(id,name) VALUES (8,'1984');
INSERT INTO Products(id,name) VALUES (9,'Harry Potter');
INSERT INTO Products(id,name) VALUES (10,'The Hobbit');
INSERT INTO Products(id,name) VALUES (11,'Pancake');

INSERT INTO ProductsToCategories(productId,categoryId) VALUES (1,2);
INSERT INTO ProductsToCategories(productId,categoryId) VALUES (3,4);
INSERT INTO ProductsToCategories(productId,categoryId) VALUES (4,6);
INSERT INTO ProductsToCategories(productId,categoryId) VALUES (4,2);
INSERT INTO ProductsToCategories(productId,categoryId) VALUES (5,6);
INSERT INTO ProductsToCategories(productId,categoryId) VALUES (5,2);
INSERT INTO ProductsToCategories(productId,categoryId) VALUES (6,4);
INSERT INTO ProductsToCategories(productId,categoryId) VALUES (6,1);
INSERT INTO ProductsToCategories(productId,categoryId) VALUES (7,1);
INSERT INTO ProductsToCategories(productId,categoryId) VALUES (7,4);
INSERT INTO ProductsToCategories(productId,categoryId) VALUES (8,3);
INSERT INTO ProductsToCategories(productId,categoryId) VALUES (9,3);
INSERT INTO ProductsToCategories(productId,categoryId) VALUES (9,5);
INSERT INTO ProductsToCategories(productId,categoryId) VALUES (10,5);
INSERT INTO ProductsToCategories(productId,categoryId) VALUES (10,3);

-- fetch 
select p.name as 'product_name', c.name as 'category_name' from Products p
left join ProductsToCategories pc 
on pc.productId = p.id
left join Categories c
on c.id = pc.categoryId