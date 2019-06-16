create Table Students 
(
StudentsID INT Primary Key,
EducationalLevel Varchar (20),
FirstName varchar (20),
LastName varchar (30),
County varchar (20),
City varchar (20),
Address1 varchar (30),
Address2 varchar (30),
Course varchar (30),
Email varchar (30),
ContactNumber varchar (20)
)

Insert Into Students values ('Postgraduate', 'Joe', 'Smith','Co. Dublin', 'Swords',  '4 Flower Ave.', 'Swords', 'Software Development', 'admeup@whish.ie', '0875632124' ) 
Insert Into Students values ('Undergraduate', 'Mery', 'Jones','Co. Galway', 'Galway',  '456 Tree Ave.', 'Galway', 'Arts', 'iAmNext@now.ie', '0867890966' )
Insert Into Students values ('Undergraduate', 'John', 'Doe','Co. Donegal', 'Donegal',  '90 Cresent Moon', 'Donegal', 'Business', 'pickMe@sad.ie', '0851249000' )

drop table  Students 
Select * From Students