CREATE TABLE IF NOT EXISTS __EFMigrationsHistory ( 
	MigrationId nvarchar(150) NOT NULL, 
	ProductVersion nvarchar(32) NOT NULL, 
	PRIMARY KEY (MigrationId) );