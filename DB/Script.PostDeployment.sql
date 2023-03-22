if not exists (select 1 from dbo.[Users])
begin
	insert into dbo.[Users] (FirstName, LastName, BirthDate, IdNumber, Roles, Username, [Password])
	values ('Temo', 'Baindurashvili', '1998-12-14', '01017053703', 'Operator', 'temo14', HASHBYTES('SHA2_256', '123456')),
	('Joe', 'Rogan', '1978-12-14', '01017053704', 'User', 'temo15', HASHBYTES('SHA2_256', '123456')),
	('John', 'Jones','1988-12-14' ,  '01017053705', 'User', 'temo16', HASHBYTES('SHA2_256', '123456')),
	('Mary', 'Christmas', '1990-12-14' , '01017053706', 'User', 'temo17', HASHBYTES('SHA2_256', '123456'));
end

if not exists (select 1 from dbo.Accounts)
begin
	insert into dbo.Accounts(UserID, Amount, Iban, Currency)
	values ('2', '10000', 'GE41176282229886345336', 'GEL'),
	('2', '20000', 'GE02135379818346778452', 'USD'),
	('3', '30000', 'GE62121766486213655773','EUR'),
	('4', '40000', 'GE56331283261641639418', 'GBP');
end