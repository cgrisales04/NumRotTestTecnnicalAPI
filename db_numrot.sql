USE db_numrot;

CREATE TABLE tbl_type_users(
	type_user_id INTEGER PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(50) NOT NULL
);

CREATE TABLE tbl_genders(
	gender_id INTEGER PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(50) NOT NULL
);

CREATE TABLE tbl_info_users(
	info_user_id INTEGER PRIMARY KEY AUTO_INCREMENT,
    identification VARCHAR(12) NOT NULL,
	password VARCHAR(255) NOT NULL,
    name VARCHAR(40) NOT NULL,
    second_name VARCHAR(40),
    last_name VARCHAR(80) NOT NULL,
    second_last_name VARCHAR(80),
    phone VARCHAR(12),
    email VARCHAR(120),
    address VARCHAR(100) NOT NULL,
    age VARCHAR(3) NOT NULL,
    type_user_id_fk INTEGER NOT NULL,
    FOREIGN KEY (type_user_id_fk) REFERENCES tbl_type_users(type_user_id),
    gender_id_fk INTEGER NOT NULL,
    FOREIGN KEY (gender_id_fk) REFERENCES tbl_genders(gender_id)
); 

CREATE TABLE tbl_invoices(
	invoice_id INTEGER PRIMARY KEY AUTO_INCREMENT, 
    date_issue TIMESTAMP DEFAULT CURRENT_TIMESTAMP NOT NULL ,
    value_totally INTEGER NOT NULL,
    info_user_id_fk INTEGER NOT NULL, 
    FOREIGN KEY (info_user_id_fk) REFERENCES tbl_info_users(info_user_id)
);