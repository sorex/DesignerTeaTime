CREATE TABLE `Users` (
`GUID` varchar(255) NOT NULL,
`LoginName` varchar(255) NOT NULL,
`Email` varchar(255) NOT NULL,
`Password` varchar(255) NOT NULL,
`Alipay` varchar(255) NOT NULL,
PRIMARY KEY (`GUID`) ,
UNIQUE INDEX (`GUID`)
);

CREATE TABLE `Addresses` (
`GUID` varchar(255) NOT NULL,
`UserID` varchar(255) NOT NULL,
`Consignee` varchar(255) NOT NULL,
`Province` varchar(255) NOT NULL,
`City` varchar(255) NOT NULL,
`County` varchar(255) NOT NULL,
`StreetAddress` varchar(255) NOT NULL,
`ZipCode` varchar(50) NOT NULL,
`PhoneNumber` varchar(255) NULL,
`TelephoneNumber` varchar(255) NULL,
`IsDefault` bit(1) NOT NULL DEFAULT b'0',
PRIMARY KEY (`GUID`) 
);

CREATE TABLE `UserExtensions` (
`GUID` varchar(255) NOT NULL,
`DefaultAddressID` varchar(255) NULL,
PRIMARY KEY (`GUID`) 
);

CREATE TABLE `Orders` (
`GUID` varchar(255) NOT NULL,
`UserID` varchar(255) NULL,
PRIMARY KEY (`GUID`) 
);


ALTER TABLE `Addresses` ADD FOREIGN KEY (`UserID`) REFERENCES `Users` (`GUID`);
ALTER TABLE `UserExtensions` ADD FOREIGN KEY (`GUID`) REFERENCES `Users` (`GUID`);
ALTER TABLE `UserExtensions` ADD FOREIGN KEY (`DefaultAddressID`) REFERENCES `Addresses` (`GUID`);
ALTER TABLE `Orders` ADD FOREIGN KEY (`UserID`) REFERENCES `Users` (`GUID`);

