CREATE TABLE users (
user_id INTEGER PRIMARY KEY AUTOINCREMENT,
user_name text,
position text
);

INSERT INTO users (name, position)
values (
"Admin",
"admin"
);
 

CREATE TABLE passwords (
pssw_id INTEGER PRIMARY KEY AUTOINCREMENT,
pssw text,
user_id INTEGER,
FOREIGN KEY(user_id) REFERENCES users(user_id)
);

INSERT INTO passwords (pssw, user_id)
values (
"Test01",
1
);

CREATE TABLE categories (
category_id INTEGER PRIMARY KEY AUTOINCREMENT,
category_type text
);

INSERT INTO categories (category_name, category_type)
values ( "drink"),
("vegan_food"),
("food"),
("gurmet"),
("snack")
;


CREATE TABLE inputs (
input_id INTEGER PRIMARY KEY AUTOINCREMENT,
input_name text,
qty INTEGER,
meassure text,
min INTEGER,
);

CREATE TABLE menu (
dish_id INTEGER PRIMARY KEY AUTOINCREMENT,
dish_name text,
availability INTEGER
category_id INTEGER,
FOREIGN KEY(category_id) REFERENCES categories(category_id)
);

CREATE TABLE menuinputs (
dish_id INTEGER,
input_id INTEGER,
PRIMARY KEY (dish_id, input_id),
FOREIGN KEY(dish_id) REFERENCES menu(dish_id)
FOREIGN KEY(input_id) REFERENCES inputs(input_id)
);

CREATE TABLE orders (
order_id INTEGER PRIMARY KEY AUTOINCREMENT,
order_date text,
order_status,
dish_id INTEGER
FOREIGN KEY(dish_id) REFERENCES menu(dish_id)
);


Create TRIGGER reduce_inventory_after_order
AFTER UPDATE ON 