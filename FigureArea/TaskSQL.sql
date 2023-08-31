DROP  table if exists Product_Category;
Drop TABLE IF EXISTS Product;
drop table IF EXISTS Category;

create TABLE Product(
  ID int not null PRIMARY KEY,
  Name nvarchar(100) not null
);

CREATE TABLE Category(
 ID int not null PRIMARY KEY,
 Name nvarchar(100) not null
);


create table Product_Category(
  ProductID int not null FOREIGN key (ProductID) REFERENCES Product (ID)
  	on DELETE Cascade,
  CategoryID int not null FOREIGN Key (CategoryID) REFERENCES Category (ID)
  	on DELETE cascade
);

select p.Name, c.Name
from Product p 
left join Product_Category pc 
	on pc.ProductID = p.ID
left JOIN Category c
	on c.ID = pc.CategoryID