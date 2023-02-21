use heidi_local;
GO

CREATE TABLE IF NOT EXISTS tester(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                name varchar(255)
                );
insert into tester (name) values ('tester1');
insert into tester (name) values ('tester2');
insert into tester (name) values ('tester3');
select * from tester;