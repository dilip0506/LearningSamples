CREATE TABLE Persons (
    personid int,
	streetid int,
	houseid int,
    lastname varchar(255),
    city varchar(255)
);

Select * from Persons

Begin TRAN
update Persons set streetId = 55 where PersonID=1;
commit

drop table Persons;

INSERT INTO Persons VALUES (1, 45, 501, 'A', 'Norway');
INSERT INTO Persons VALUES (2, 45, 501, 'B', 'Norway');
INSERT INTO Persons VALUES (3, 45, 502, 'C', 'Norway');
INSERT INTO Persons VALUES (4, 45, 502, 'D', 'Norway');
INSERT INTO Persons VALUES (5, 46, 503, 'E', 'Norway');
INSERT INTO Persons VALUES (6, 46, 503, 'F', 'Norway');
INSERT INTO Persons VALUES (7, 46, 503, 'G', 'Norway');
INSERT INTO Persons VALUES (8, 46, 503, 'H', 'Norway');