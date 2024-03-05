﻿CREATE TABLE AccessoriesTable (
	ID int IDENTITY(8000,1) PRIMARY KEY,
	accsID AS ('AC'+CONVERT(VARCHAR(16),ID)),
	accsType VARCHAR (250) NOT NULL,
	date_add DATE NOT NULL DEFAULT (GETDATE()),
	status VARCHAR(250) NOT NULL,
	);

INSERT INTO AccessoriesTable (accsType, status)
VALUES ('HDMI CABLE','AVAILABLE'),('EXTENSION','AVAILABLE'),('VGA CABLE','AVAILABLE');