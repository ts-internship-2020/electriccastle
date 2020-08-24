BEGIN TRAN

INSERT INTO DictionaryConferenceType(DictionaryConferenceTypeId, DictionaryConferenceTypeName, ConferenceTypeCode)
VALUES (1, 'Remote', 'RMT'),
	   (2, 'On Site', 'OST');

INSERT INTO DictionaryConferenceCategory 
VALUES (1,'Medical', 'MED'),
	   (2,'IT Hardware', 'ITH'),
	   (3,'IT Software', 'ITS'),
	   (4,'Business', 'BUS'),
	   (5,'Education', 'ED'),
	   (6,'Real Estate','RLE'),
	   (7,'Nutrition', 'NTR'),
	   (8,'Sport', 'SPT'),
	   (9,'Beauty', 'BTY'),
	   (10,'History', 'HIT');

INSERT INTO DictionaryCountry(DictionaryCountryId, CountryCode, DictionaryCountryName)
VALUES (1, 'ROM', 'ROMANIA'),
	   (2, 'FR', 'FRANCE'),
	   (3, 'GER', 'GERMANY'),
	   (4, 'ENG', 'ENGLAND');

INSERT INTO DictionaryDistrict(DictionaryDistrictId, DistrictCode, DictionaryDistrictName, DictionaryCountryId)
VALUES (1, 'B', 'BUCHAREST', 1),
	   (2, 'AG', 'ARGES', 1),
	   (3, 'CN', 'CANTAL', 2),
	   (4, 'GR', 'GARD', 2),
	   (5, 'BV', 'BAVARIA', 3),
	   (6, 'HB', 'HAMBURG', 3),
	   (7, 'CW', 'CORNWALL', 4),
	   (8, 'HS', 'HAMPSHIRE', 4);

INSERT INTO DictionaryCity(DictionaryCityId, CityCode, DictionaryCityName, DictionaryDistrictId)
VALUES (1, 'BUC', 'BUCHAREST', 1),
	   (2, 'PT', 'PITESTI', 2),
	   (3, 'AL', 'AURILLAC', 3),
	   (4, 'NM', 'NIMES', 4),
	   (5, 'MHCH', 'MUNCHEN', 5),
	   (6, 'HMB', 'HAMBURG', 6),
	   (7, 'TR', 'TRURO', 7),
	   (8, 'WCH', 'WINCHESTER', 8);

INSERT INTO Location(DictionaryCityId) 
VALUES (1),
	   (2),
	   (3),
	   (4),
	   (5),
	   (6),
	   (7)

INSERT INTO Conference 
VALUES ('totalevents@yahoo.com', 'TotalMed', 'Paul Petrache', '2020-09-12 09:00:00','2020-09-12 12:00:00',1,1,4 ),
	   ('globalevents@yahoo.com', 'An introduction to hardware', 'Vlad Ursache', '2020-10-12 16:00:00','2020-10-12 18:30:00',2,2,3 ),
	   ('goldmoments@gmail.com', 'The power of BI', 'Ionut Mitrache', '2020-08-22 10:00:00','2020-08-22 12:00:00',3,1,2 ),
	   ('unforghetable@gmail.com', 'Today''s businessman', 'Ilinca Vandici', '2020-11-03 14:30:00','2020-11-03 16:00:00',4,2,1 ),
	   ('bestmoments@yahoo.com', 'The underevaluation of a good education', 'Teodor Paladi', '2021-01-12 09:00:00','2021-01-12 12:00:00',5,1,4 ),
	   ('megamoments@yahoo.com', 'The current state of real estate', 'Maria Ghencea', '2020-12-19 09:00:00','2020-12-19 12:00:00',6,1,5 ),
	   ('joyevents@gmail.com', 'Shapeaton', 'Nicolae Cicu', '2021-01-22 09:00:00','2021-01-22 12:00:00',7,2,3 ),
	   ('megamagic@yahoo.com', 'Why do all the sports imply balls', 'Mihai Andone', '2020-10-23 08:30:00','2020-10-23 12:00:00',8,1,2 ),
	   ('marveiouse@yahoo.com', 'The ugly face of makeup', 'Brighite Bardouth', '2020-09-12 09:00:00','2020-09-12 12:00:00',9,1,4 ),
	   ('eventskill@gmail.com', 'The world''s retrospective', 'Mircea Dumitru', '2020-09-12 12:00:00','2020-09-12 14:00:00',10,1,4 );

INSERT INTO DictionaryParticipantState 
VALUES(1, 'Joined', 'JOD'),
	  (2, 'Withdrawn', 'WDN'),
	  (3, 'Attended', 'ATD');


INSERT INTO ConferenceParticipant 
VALUES (1,'ileanazina@yahoo.com', 1),
	   (2,'zinaileana@gmail.com', 2),
	   (3,'oanaemilia@yahoo.com', 3),
	   (4,'emiliaoana@gmail.com', 1),
	   (5,'teobanica@yahoo.com', 2),
	   (6,'banicateo@gmail.com', 3),
	   (7,'dragosandrei@yahoo.com', 1),
	   (8,'andreidragos@gmail.com', 2),
	   (9,'adelaanghel@yahoo.com', 3),
	   (10,'alexpopescu@yahoo.com', 1),
	   (1,'dumitrub@yahoo.com', 1),
	   (2,'biancaade@gmail.com', 2),
	   (3,'robert@yahoo.com', 3),
	   (4,'cici@gmail.com', 1),
	   (5,'miruna@yahoo.com', 2),
	   (6,'dragos@gmail.com', 3),
	   (7,'morse@yahoo.com', 1),
	   (8,'andrei@gmail.com', 2),
	   (9,'denisa@yahoo.com', 3),
	   (10,'ionel@yahoo.com', 1),
	   (9,'zavoianu@yahoo.com', 3),
	   (10,'ciuca@yahoo.com', 1);


INSERT INTO DictionarySpeaker(DictionarySpeakerId, SpeakerCode, DictionarySpeakerName, Rating, Nationality) 
VALUES (1, 'HRM', 'Harper-Rose Mcconnell', 4, 'Italian'),
	   (2, 'AGA', 'Ava-Grace Ayersl', 5, 'German'),
	   (3, 'SV', 'Saffa Vazquez', 3, 'German'),
	   (4, 'EG', 'Ellouise Galvan', 2, 'Dominican'),
	   (5, 'SK', 'Sky Michael', 5, 'Dominican'),
	   (6, 'EA', 'Eira Anderson', 4, 'Italian'),
	   (7, 'HF', 'Hira Franco', 4, 'Bulgarian'),
	   (8, 'VS', 'Viktor Sampson', 3, 'Ukrainian'),
	   (9, 'LL', 'Lemar Leblanc', 5, 'Irishman'),
	   (10, 'EM', 'Emily Garcia', 2, 'Norwegian');

INSERT INTO  ConferenceXDictionarySpeaker(DictionarySpeakerId, ConferenceId, IsMainSpeaker) 
VALUES  (1, 1, 0),
		(2, 1, 1),
		(3, 2, 1),
		(4, 2, 0),
		(2, 2, 0),
		(5, 3, 1),
		(6, 3, 0),
		(7, 3, 0),
		(7, 4, 1),
		(8, 5, 1),
		(9, 5, 0),
		(9, 6, 1),
		(10, 7, 1),
		(9, 8, 1),
		(1, 8, 0),
		(2, 8, 0),
		(3, 8, 0),
		(10, 9, 1),
		(6, 9, 0),
		(7, 10, 1),
		(5, 10, 0);
		
--BEGIN TRAN

--ROLLBACK

--COMMIT
