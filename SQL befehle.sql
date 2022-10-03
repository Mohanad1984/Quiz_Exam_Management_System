Data Source=HAUPT-PC;Initial Catalog=QuizDb;Integrated Security=True
CREATE DATABASE IF NOT EXISTS `QuizDb`;

CREATE TABLE AdmiTbl 
     (
	  AdmiId INT NOT NULL IDENTITY (1, 1)  PRIMARY KEY,
      AdmiVorname NVARCHAR(100) NOT NULL, 
      AdmiNachname NVARCHAR(100) NOT NULL, 
      AdmiBenutzername NVARCHAR(100) NOT NULL, 
      AdmiPasswort NVARCHAR(100) NOT NULL, 
      AdmiTelefonnummer NVARCHAR(30) NOT NULL, 
	  AdmiE_mail NVARCHAR(50) NOT NULL, 
	  AdmiStrasse NVARCHAR(100) NOT NULL, 
	  AdmiHausNr NVARCHAR(10) NOT NULL, 
	  AdmiPlz NVARCHAR(7) NOT NULL, 
	  AdmiOrt NVARCHAR(30) NOT NULL,
      AdmiHinweise NVARCHAR(500), 
      AdmiGeburtsdatum DATE NOT NULL )  
	  
CREATE TABLE KandidatTbl
     (kandidatId INT NOT NULL IDENTITY (1, 1) PRIMARY KEY , 
      kandidatVorname VARCHAR(100) NOT NULL, 
      kandidatNachname VARCHAR(100) NOT NULL, 
      kandidatBenutzername VARCHAR(100) NOT NULL, 
      kandidatPasswort VARCHAR(100) NOT NULL, 
      kandidatTelefonnummer VARCHAR(30) NOT NULL, 
	  kandidatE_mail VARCHAR(50) NOT NULL, 
	  kandidatStrasse VARCHAR(100) NOT NULL, 
	  kandidatHausNr VARCHAR(10) NOT NULL, 
	  kandidatPlz VARCHAR(7) NOT NULL, 
	  kandidatOrt VARCHAR(30) NOT NULL, 
	  --NoteId INT, 
	  --ergebnisId
      kandidatHinweise VARCHAR(500), 
      kandidatGeburtsdatum DATE NOT NULL ) ENGINE = INNODB DEFAULT CHARSET = latin1;

CREATE TABLE FachTbl 
     (fachId INT(10) AUTO_INCREMENT PRIMARY KEY, 
      fachName VARCHAR(100) NOT NULL, 
      fachHinweise VARCHAR(500)
	  fEintragenAdmiId INT NOT NULL,
	  fBearbeitenAdmiId INT NULL,
	  fBearbeitendatum DATE NOT NULL
     );
	 
CREATE TABLE FrageTbl
     (frageId INT NOT NULL IDENTITY (1, 1)  PRIMARY KEY, 
      frageBeschreibung NVARCHAR(100) NOT NULL, 
      frageWahl_1 NVARCHAR(100) NOT NULL, 
      frageWahl_2 NVARCHAR(100) NOT NULL,
      frageWahl_3 NVARCHAR(100) NOT NULL, 
      frageWahl_4 NVARCHAR(100) NOT NULL, 
	  frageWahl_5 NVARCHAR(100) NULL,
      frageAntwort  NVARCHAR(100) NOT NULL,
      fachId  INT NOT NULL,
	  admiId  INT NOT NULL,
	  EintragungsDatum INT NOT NULL,
	  FOREIGN KEY (admiId) REFERENCES AdmiTbl (admiId),
      FOREIGN KEY (fachId) REFERENCES FachTbl (fachId)  
     )
 
CREATE TABLE ErgebnisTbl --Noten
     (ergebnisId INT NOT NULL IDENTITY (1, 1) PRIMARY KEY, 
      fachId INT(10) NOT NULL, 
	  kandidatId INT(10) NOT NULL, 
      ergebnisDatum DATE NOT NULL, 
      ergebnisZeit TIME NOT NULL,
      ergebnisNoten INT NOT NULL, 
      ergebnisHinweise VARCHAR(500) NULL,
      FOREIGN KEY (fachId) REFERENCES FachTbl (fachId),
      FOREIGN KEY (kandidatId) REFERENCES KandidatTbl (kandidatId) 
     ) ;
DECLARE @FachId INT;DECLARE @kandidatId INT;DECLARE @ergebnisDatum  Date ;DECLARE @ergebnisZeit Time ;DECLARE @ergebnisNoten INT;DECLARE @ergebnisHinweise nvarchar;
SET @FachId = 1;
SET @kandidatId = 4;
SET @ergebnisDatum = '2021-08-21';
SET @ergebnisZeit = '05:11:30';
SET @ergebnisNoten = 1;
SET @ergebnisHinweise = 'fdgd';


Insert Into ErgebnisTbl (FachId, kandidatId, ergebnisDatum, ergebnisZeit, ergebnisNoten, ergebnisHinweise ) 
Values (@FachId, @kandidatId, @ergebnisDatum, @ergebnisZeit, @ergebnisNoten, @ergebnisHinweise )	 
	-- utf8_general_ci;

--DROP TABLE IF EXISTS Thema;
--DROP TABLE IF EXISTS Ergebnis;
--DROP TABLE IF EXISTS Frage;
--DROP TABLE IF EXISTS Kandidat;
--DROP DATABASE IF EXISTS Eignungstest;