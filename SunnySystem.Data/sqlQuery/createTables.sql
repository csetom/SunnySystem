CREATE TABLE Customer (
  customer_id SERIAL PRIMARY KEY,
  name VARCHAR(255),
  address VARCHAR(255),
  phone VARCHAR(20),
  email VARCHAR(255)
);

CREATE TABLE ComponentsMain (
    componentid SERIAL PRIMARY KEY,
    name VARCHAR(255),
    cost integer,
    max integer
);



CREATE TABLE Warehouse (
    binId SERIAL PRIMARY KEY,
    row INTEGER,
    column INTEGER,
    stash INTEGER,
    ComponentId INTEGER,
    Piece INTEGER,
);

ALTER TABLE Warehouse
ADD CONSTRAINT FK_Warehouse_ComponentId
FOREIGN KEY (ComponentId)
REFERENCES ComponentsMain (id)
ON UPDATE CASCADE
ON DELETE CASCADE;

INSERT INTO ComponentsMain (Name, Cost, Max) 
VALUES ('Widget', 10, 100);