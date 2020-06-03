CREATE TABLE figures2d
( id int Primary Key Identity(1,1),
  name varchar(30),
  type varchar(30)
);

CREATE TABLE figures3d
( id int Primary Key Identity(1,1),
  name varchar(30),
  type varchar(30),
  base int foreign key references figures2d(id) on delete cascade,
  height int
);

CREATE TABLE parameters2d
( id int Primary Key Identity(1,1),
name varchar(10),
size float,
type varchar(10),
 figure_id int foreign key references figures2d(id) on delete cascade
)


