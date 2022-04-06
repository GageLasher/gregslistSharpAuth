CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';
CREATE TABLE IF NOT EXISTS cars (
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  create_time DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Create Time',
  update_time DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Update Time',
  name TEXT,
  price DECIMAL(4, 2) NOT NULL,
  description VARCHAR(255) DEFAULT 'No description provided'
) DEFAULT CHARSET UTF8 COMMENT 'Cars for Gregslist';
INSERT INTO
  cars (name, price, description)
VALUES
  ('Honda', 21.95, 'Big Boy 3');
SELECT
  *
FROM
  cars
WHERE
  id = 3;
UPDATE
  cars
SET
  price = 42.32,
  name = "Toyota"
WHERE
  id = 3;
DELETE FROM
  cars
WHERE
  id = 5;
SELECT
  *
FROM
  cars