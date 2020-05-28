CREATE TABLE figures 
( id int Primary Key Identity(1,1),
  name varchar(30),
  type varchar(30)
);

CREATE TABLE coordinates 
( id int Primary Key Identity(1,1),
  x int,
  y int,
  z int,
  figure_id int Foreign Key REFERENCES figures(id)  on delete cascade
);
insert into coordinates(x, figure_id) values(3,1)
select * from coordinates
delete from figures
where id=1


