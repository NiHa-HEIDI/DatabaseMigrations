use heidi_local;
GO
CREATE TABLE IF NOT EXISTS roles(
					Id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
					name varchar(255) NOT NULL
				);
insert into roles(name) values ('Administrator');
select * from roles;

CREATE TABLE IF NOT EXISTS cities(
					Id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
					Name varchar(255) NOT NULL,
					ConnectionString varchar(255) NOT NULL
				);
select * from cities;

CREATE TABLE IF NOT EXISTS users(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
					username varchar(255) NOT NULL,
					firstname varchar(255) NOT NULL,
					lastname varchar(255) NOT NULL,
					email varchar(255) NOT NULL,
					phoneNumber varchar(255),
					image varchar(255),
					description varchar(255),
					website varchar(255),
					roleId int
                );
insert into tester (name) values ('tester1');
select * from users;

CREATE TABLE IF NOT EXISTS userCityUserMapping(
					Id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
					UserId int NOT NULL,
					CityId int NOT NULL,
					CityUserId int NOT NULL				
				);
select * from userCityUserMapping;


CREATE TABLE IF NOT EXISTS userListingMapping(
					Id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
					UserId int NOT NULL,
					CityId int NOT NULL,
					ListingId int NOT NULL				
				);
select * from userListingMapping;

