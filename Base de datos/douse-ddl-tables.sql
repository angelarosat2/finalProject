USE douse;

CREATE TABLE recipients
(
  id INT NOT NULL IDENTITY,
  room VARCHAR(15) NOT NULL,
  type VARCHAR(10) NOT NULL,
  CONSTRAINT pk_recipients PRIMARY KEY (id),
  CONSTRAINT chk_type CHECK (type IN ('Socket','Switch'))
);

CREATE TABLE nodemcu
(
  id INT NOT NULL IDENTITY,
  mac_address VARCHAR(20) NOT NULL,
  purchase_date DATETIME NOT NULL,
  guarantee DATETIME NOT NULL,
  id_recipients INT NOT NULL,
  CONSTRAINT fk_nodemcu_recipients FOREIGN KEY (id_recipients) REFERENCES recipients(id),
  CONSTRAINT pk_nodemcu PRIMARY KEY (id)
);

CREATE TABLE clients
(
  document INT NOT NULL,
  name VARCHAR(20) NOT NULL,
  address VARCHAR(60),
  email VARCHAR(60) NOT NULL,
  CONSTRAINT pk_clients PRIMARY KEY (document)
);

CREATE TABLE clients_phone
(
  document_client INT NOT NULL,
  phone VARCHAR(20) NOT NULL,
  CONSTRAINT fk_clients_phone FOREIGN KEY (document_client) REFERENCES clients(document),
  CONSTRAINT pk_clients_phone PRIMARY KEY (document_client, phone)
);

CREATE TABLE subscriptions
(
  number INT NOT NULL IDENTITY,
  description VARCHAR(130) NOT NULL,
  price FLOAT NOT NULL,
  CONSTRAINT pk_subscriptions PRIMARY KEY (number)
);

CREATE TABLE employees
(
  document INT NOT NULL,
  name VARCHAR(25) NOT NULL,
  address VARCHAR(60) NOT NULL,
  email VARCHAR(60) NOT NULL,
  position VARCHAR(20) NOT NULL,
  CONSTRAINT pk_employees PRIMARY KEY (document)
);

CREATE TABLE employees_phone
(
  document_employee INT NOT NULL,
  phone VARCHAR(20) NOT NULL,
  CONSTRAINT fk_employees_phone FOREIGN KEY (document_employee) REFERENCES employees(document),
  CONSTRAINT pk_employees_phone PRIMARY KEY (document_employee, phone)
)

CREATE TABLE status
(
  id_recipients INT NOT NULL,
  date DATETIME NOT NULL,
  status VARCHAR(10) NOT NULL,
  consumption FLOAT NOT NULL,
  username VARCHAR(15) NOT NULL,
  CONSTRAINT chk_status CHECK (status IN ('On', 'Off')),
  CONSTRAINT fk_status_recipients FOREIGN KEY (id_recipients) REFERENCES recipients(id),
  CONSTRAINT pk_status PRIMARY KEY (id_recipients, date)
);

CREATE TABLE contract
(
  document INT NOT NULL,
  number_subscription INT NOT NULL,
  date DATETIME NOT NULL,
  number_credit_card VARCHAR(20) NOT NULL,
  CONSTRAINT fk_document_client_contract FOREIGN KEY (document) REFERENCES clients(document),
  CONSTRAINT fk_subscription_contract FOREIGN KEY (number_subscription) REFERENCES subscriptions(number),
  CONSTRAINT pk_contract PRIMARY KEY (document, number_subscription)
);

CREATE TABLE username
(
  username VARCHAR(15) NOT NULL UNIQUE,
  email VARCHAR(60) NOT NULL,
  password VARCHAR(20)NOT NULL,
  CONSTRAINT pk_user PRIMARY KEY (username)
)

CREATE TABLE user_clients
(
  document_clients INT NOT NULL,
  username VARCHAR(15) NOT NULL,
  email VARCHAR(60) NOT NULL,
  password VARCHAR(20) NOT NULL,
  CONSTRAINT fk_clients_users FOREIGN KEY (document_clients) REFERENCES clients(document),
  CONSTRAINT fk_username_user_clients FOREIGN KEY (username) REFERENCES username(username),
  CONSTRAINT pk_user_clients PRIMARY KEY (document_clients, username)
);

CREATE TABLE user_employees
(
  document_employees INT NOT NULL,
  username VARCHAR(15) NOT NULL,
  email VARCHAR(60) NOT NULL,
  password VARCHAR(20) NOT NULL,
  CONSTRAINT fk_employees_users FOREIGN KEY (document_employees) REFERENCES employees(document),
  CONSTRAINT fk_username_user_employees FOREIGN KEY (username) REFERENCES username(username),
  CONSTRAINT pk_user_employees PRIMARY KEY (document_employees, username)
);