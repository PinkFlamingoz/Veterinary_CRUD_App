--Create Database
create database Animal_Database
go
use Animal_Database
go
--Create Tables
CREATE TABLE Owners
(
  owner_id int identity (1,1) primary key,
  owner_name nvarchar(50) not null,
  owner_phone nvarchar(20) not null,
  owner_email nvarchar(100) not null
);
go
create table Pet
(
  pet_id int identity (1,1) primary key,
  owner_id int not null,
  pet_name nvarchar (50) not null,
  pet_type nvarchar (50) not null,
  pet_color nvarchar (50) not null,  
  pet_age int not null,
  pet_sex nvarchar(1) not null,
  pet_birthdate datetime not null,
  pet_picture nvarchar(255) null
  foreign key (owner_id) references Owners(owner_id)
);
go
create table Vet_Visit
(
  visit_id int identity (1,1) primary key,
  pet_id int not null,
  visit_type nvarchar(50) not null,
  visit_date datetime not null,
  visit_description nvarchar(1000) not null,
  foreign key (pet_id) references Pet(pet_id)
);
go
--Data Insertion
SET IDENTITY_INSERT Owners ON
insert into Owners (owner_id, owner_name, owner_phone, owner_email) values (1, 'Hubey', '997-157-2147', 'htolman0@apache.org');
insert into Owners (owner_id, owner_name, owner_phone, owner_email) values (2, 'Stesha', '499-732-3894', 'sgillogley1@economist.com');
insert into Owners (owner_id, owner_name, owner_phone, owner_email) values (3, 'Margarethe', '146-157-2153', 'mdomnick2@purevolume.com');
insert into Owners (owner_id, owner_name, owner_phone, owner_email) values (4, 'Stafford', '428-533-4292', 'sdampier3@smh.com.au');
insert into Owners (owner_id, owner_name, owner_phone, owner_email) values (5, 'Alyda', '874-952-4699', 'aclaussen4@ed.gov');
insert into Owners (owner_id, owner_name, owner_phone, owner_email) values (6, 'Joane', '745-657-2439', 'jgrebert5@apple.com');
insert into Owners (owner_id, owner_name, owner_phone, owner_email) values (7, 'Kelila', '906-636-4677', 'knegri6@cnn.com');
insert into Owners (owner_id, owner_name, owner_phone, owner_email) values (8, 'Aristotle', '678-454-1894', 'aabramamovh7@zdnet.com');
insert into Owners (owner_id, owner_name, owner_phone, owner_email) values (9, 'Jordana', '515-385-5279', 'jnowlan8@booking.com');
insert into Owners (owner_id, owner_name, owner_phone, owner_email) values (10, 'Halsy', '936-615-7894', 'hgibbetts9@dropbox.com');
SET IDENTITY_INSERT Owners OFF
SET IDENTITY_INSERT Pet ON
insert into Pet (pet_id, owner_id, pet_name, pet_type, pet_color, pet_age, pet_sex, pet_birthdate, pet_picture) values (1, 2, 'Neely', 'Ibex', 'Blue', 11, 'F', '2003-01-20 01:01:50', 'IdLobortisConvallis.avi');
insert into Pet (pet_id, owner_id, pet_name, pet_type, pet_color, pet_age, pet_sex, pet_birthdate, pet_picture) values (2, 8, 'Mara', 'Raccoon, common', 'Mauv', 15, 'F', '1993-04-03 13:24:55', 'SagittisDuiVel.mov');
insert into Pet (pet_id, owner_id, pet_name, pet_type, pet_color, pet_age, pet_sex, pet_birthdate, pet_picture) values (3, 10, 'Nial', 'Booby, blue-footed', 'Violet', 15, 'M', '2004-09-07 06:33:26', 'SedTincidunt.xls');
insert into Pet (pet_id, owner_id, pet_name, pet_type, pet_color, pet_age, pet_sex, pet_birthdate, pet_picture) values (4, 1, 'Devonne', 'Herring gull', 'Fuscia', 10, 'F', '2006-05-25 09:22:03', 'MaurisLaciniaSapien.txt');
insert into Pet (pet_id, owner_id, pet_name, pet_type, pet_color, pet_age, pet_sex, pet_birthdate, pet_picture) values (5, 9, 'Osbert', 'Swallow (unidentified)', 'Violet', 19, 'M', '2011-03-12 11:01:10', 'SedSagittis.png');
insert into Pet (pet_id, owner_id, pet_name, pet_type, pet_color, pet_age, pet_sex, pet_birthdate, pet_picture) values (6, 8, 'Sterne', 'Southern boubou', 'Khaki', 7, 'M', '2011-10-30 11:56:05', 'AugueVestibulum.xls');
insert into Pet (pet_id, owner_id, pet_name, pet_type, pet_color, pet_age, pet_sex, pet_birthdate, pet_picture) values (7, 9, 'Torry', 'White-faced tree rat', 'Blue', 13, 'M', '1994-06-08 13:11:12', 'AmetNunc.mp3');
insert into Pet (pet_id, owner_id, pet_name, pet_type, pet_color, pet_age, pet_sex, pet_birthdate, pet_picture) values (8, 4, 'Booth', 'Giant anteater', 'Pink', 17, 'M', '2004-12-11 15:02:10', 'EtCommodo.ppt');
insert into Pet (pet_id, owner_id, pet_name, pet_type, pet_color, pet_age, pet_sex, pet_birthdate, pet_picture) values (9, 6, 'Brigit', 'Bustard, denham''s', 'Blue', 17, 'F', '2020-09-12 04:22:12', 'ConsectetuerAdipiscing.ppt');
insert into Pet (pet_id, owner_id, pet_name, pet_type, pet_color, pet_age, pet_sex, pet_birthdate, pet_picture) values (10, 1, 'Bartholomew', 'Pheasant, common', 'Goldenrod', 18, 'M', '2015-08-04 02:08:57', 'Eleifend.jpeg');

SET IDENTITY_INSERT Pet OFF
SET IDENTITY_INSERT Vet_Visit ON
insert into Vet_Visit (visit_id, pet_id, visit_type, visit_date, visit_description) values (1, 7, 'surgery', '2023-06-29 04:18:07', 'urna ut tellus nulla ut erat id mauris vulputate elementum nullam varius nulla facilisi cras non velit nec nisi vulputate nonummy maecenas tincidunt lacus at velit vivamus vel nulla eget eros elementum pellentesque quisque porta volutpat erat quisque erat eros viverra eget congue eget semper rutrum nulla nunc purus phasellus in felis donec semper sapien a libero nam dui proin leo odio porttitor id consequat in consequat ut nulla');
insert into Vet_Visit (visit_id, pet_id, visit_type, visit_date, visit_description) values (2, 3, 'emergency', '2017-11-04 08:38:44', 'sem praesent id massa id nisl venenatis lacinia aenean sit amet justo morbi ut odio cras mi');
insert into Vet_Visit (visit_id, pet_id, visit_type, visit_date, visit_description) values (3, 7, 'checkup', '2001-12-18 06:20:04', 'mattis nibh ligula nec sem duis aliquam convallis nunc proin at turpis a pede posuere nonummy integer non');
insert into Vet_Visit (visit_id, pet_id, visit_type, visit_date, visit_description) values (4, 5, 'emergency', '2000-11-25 10:48:55', 'risus auctor sed tristique in tempus sit amet sem fusce consequat nulla nisl nunc nisl duis bibendum felis sed interdum venenatis turpis enim blandit mi in porttitor pede justo eu massa donec dapibus duis at velit eu est congue elementum in hac habitasse platea dictumst morbi vestibulum velit id pretium iaculis diam');
insert into Vet_Visit (visit_id, pet_id, visit_type, visit_date, visit_description) values (5, 2, 'emergency', '2018-08-12 21:43:55', 'in faucibus orci luctus et ultrices posuere cubilia curae mauris viverra diam vitae quam suspendisse potenti nullam porttitor lacus at turpis donec posuere metus vitae ipsum aliquam non mauris morbi non lectus aliquam sit amet diam in magna bibendum imperdiet nullam orci pede venenatis non sodales sed tincidunt eu felis fusce posuere felis sed lacus morbi sem mauris laoreet ut rhoncus aliquet pulvinar sed nisl nunc rhoncus dui vel sem sed sagittis nam congue');
insert into Vet_Visit (visit_id, pet_id, visit_type, visit_date, visit_description) values (6, 5, 'emergency', '2018-03-09 00:20:52', 'tempus vel pede morbi porttitor lorem id ligula suspendisse ornare consequat lectus in est risus auctor sed tristique in tempus sit amet sem fusce consequat nulla nisl nunc nisl duis bibendum felis sed interdum venenatis turpis enim blandit mi in porttitor pede justo eu massa donec dapibus duis at velit eu est congue elementum in hac habitasse platea dictumst morbi');
insert into Vet_Visit (visit_id, pet_id, visit_type, visit_date, visit_description) values (7, 6, 'vaccination', '2009-02-04 18:12:11', 'eu magna vulputate luctus cum sociis natoque penatibus et magnis dis parturient montes nascetur ridiculus mus vivamus vestibulum sagittis sapien cum sociis natoque penatibus et magnis dis parturient montes nascetur ridiculus mus etiam vel augue vestibulum rutrum rutrum neque aenean auctor gravida sem praesent id massa id nisl venenatis lacinia aenean sit amet justo morbi ut odio');
insert into Vet_Visit (visit_id, pet_id, visit_type, visit_date, visit_description) values (8, 1, 'emergency', '2022-09-28 20:13:16', 'vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae duis faucibus accumsan odio curabitur convallis duis consequat dui nec nisi volutpat eleifend donec ut dolor morbi vel lectus in quam fringilla rhoncus mauris enim leo rhoncus sed vestibulum sit amet cursus id turpis integer aliquet massa id lobortis convallis tortor risus dapibus augue vel accumsan tellus nisi eu orci mauris lacinia sapien quis libero nullam sit amet turpis elementum ligula vehicula consequat morbi a');
insert into Vet_Visit (visit_id, pet_id, visit_type, visit_date, visit_description) values (9, 6, 'checkup', '2008-12-19 08:44:56', 'aenean sit amet justo morbi ut odio cras mi pede malesuada in imperdiet et commodo vulputate justo in blandit ultrices enim lorem ipsum dolor sit amet consectetuer adipiscing elit proin interdum mauris non ligula pellentesque ultrices phasellus id sapien in sapien iaculis congue vivamus metus arcu adipiscing molestie hendrerit at vulputate vitae nisl aenean lectus pellentesque eget nunc donec quis orci eget orci vehicula condimentum curabitur in libero ut massa volutpat convallis morbi odio odio elementum eu interdum eu tincidunt in leo maecenas pulvinar lobortis est phasellus sit amet erat nulla tempus');
insert into Vet_Visit (visit_id, pet_id, visit_type, visit_date, visit_description) values (10, 4, 'checkup', '2012-06-26 09:44:09', 'luctus cum sociis natoque penatibus et magnis dis parturient montes nascetur ridiculus mus vivamus vestibulum sagittis sapien cum sociis natoque penatibus et magnis dis parturient montes nascetur ridiculus mus etiam vel augue vestibulum rutrum rutrum neque aenean auctor gravida sem praesent id massa id nisl venenatis lacinia aenean sit amet justo morbi ut odio cras mi pede malesuada in');

SET IDENTITY_INSERT Vet_Visit OFF