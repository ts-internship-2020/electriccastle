DBCC CHECKIDENT ('Location', RESEED, 7);
DBCC CHECKIDENT ('Conference', RESEED, 14);

SELECT * FROM Conference;
SELECT * FROM Location;
SELECT * FROM DictionaryCity;
SELECT * FROM DictionaryDistrict;
SELECT * FROM DictionaryCountry;
SELECT * FROM DictionaryConferenceCategory;
SELECT * FROM DictionaryConferenceType;
SELECT * FROM DictionarySpeaker;
SELECT * FROM DictionaryParticipantState;
SELECT * FROM ConferenceXDictionarySpeaker ORDER BY ConferenceId;
SELECT * FROM ConferenceParticipant WHERE ConferenceId = 8  CP
JOIN DictionaryParticipantState D ON D.DictionaryParticipantStateId = CP.DictionaryParticipantStateId;


-- select speaker related data for conference
SELECT DictionarySpeakerId, ConferenceId, IsMainSpeaker 
FROM ConferenceXDictionarySpeaker
WHERE ConferenceId = 13;

BEGIN TRAN

INSERT INTO Conference(ConferenceName, OrganizerEmail, OrganizerName,
StartDate, EndDate, DictionaryConferenceCategoryId, DictionaryConferenceTypeId,
LocationId) 
VALUES ('Una noua', 'eventskill@gmail.com', 'Mircea Dumitru', '2021-03-08 9:00:00', '2021-03-10 15:00:00', 10, 1, 7) 

UPDATE Conference
SET ConferenceName = , 
	OrganizerEmail = , 
	OrganizerName = ,
	StartDate = , 
	EndDate = , 
	DictionaryConferenceCategoryId = , 
	DictionaryConferenceTypeId = ,
	LocationId = );



ROLLBACK

-- populare grid organizator

select c.ConferenceId, c.ConferenceName, c.OrganizerName, c.StartDate, c.EndDate, dct.DictionaryConferenceTypeName, 
dcc.DictionaryConferenceCategoryName , dc.DictionaryCityName + ', ' + dcn.CountryCode AS Address, ds.DictionarySpeakerName 
from Conference c  
join Location l on l.LocationId = c.LocationId 
join DictionaryCity dc on dc.DictionaryCityId = l.DictionaryCityId 
join DictionaryDistrict dd on dd.DictionaryDistrictId = dc.DictionaryDistrictId 
join DictionaryCountry dcn on dcn.DictionaryCountryId = dd.DictionaryCountryId 
join DictionaryConferenceType dct on dct.DictionaryConferenceTypeId = c.DictionaryConferenceTypeId 
join DictionaryConferenceCategory dcc on dcc.DictionaryConferenceCategoryId = c.DictionaryConferenceCategoryId 
join ConferenceXDictionarySpeaker cds on cds.ConferenceId = c.ConferenceId 
join DictionarySpeaker ds on ds.DictionarySpeakerId = cds.DictionarySpeakerId 
where cds.IsMainSpeaker = 1
and c.OrganizerEmail = 'eventskill@gmail.com';

-- select pentru conferinta

SELECT C.ConferenceId, C.ConferenceName, C.OrganizerEmail, C.OrganizerName,
C.StartDate, C.EndDate, C.DictionaryConferenceCategoryId, C.DictionaryConferenceTypeId,
C.LocationId, L.AdressDetails, DC.DictionaryCityId, DD.DictionaryDistrictId,
DCN.DictionaryCountryId FROM Conference C
JOIN Location L ON C.LocationId = L.LocationId
JOIN DictionaryCity DC ON DC.DictionaryCityId = L.DictionaryCityId 
JOIN DictionaryDistrict DD ON DD.DictionaryDistrictId = DC.DictionaryDistrictId 
JOIN DictionaryCountry DCN ON DCN.DictionaryCountryId = DD.DictionaryCountryId 
WHERE ConferenceId = 13;



SELECT DictionaryConferenceCategoryId, DictionaryConferenceCategoryName, ConferenceCategoryCode FROM DictionaryConferenceCategory;

-- next id pentru categorii
SELECT MAX(DictionaryConferenceCategoryId) AS maxId FROM DictionaryConferenceCategory;

-- select pentru GetCategory
SELECT DictionaryConferenceCategoryId, DictionaryConferenceCategoryName, ConferenceCategoryCode 
FROM DictionaryConferenceCategory
WHERE DictionaryConferenceCategoryId = 3;

BEGIN TRAN

-- C.U.D pentru categorii
INSERT INTO DictionaryConferenceCategory (DictionaryConferenceCategoryId, 
DictionaryConferenceCategoryName, ConferenceCategoryCode)
VALUES (11, 'Ciorba', 'CRB');

UPDATE DictionaryConferenceCategory
SET DictionaryConferenceCategoryName = 'Ciorbix',
	ConferenceCategoryCode = 'CiB'
WHERE DictionaryConferenceCategoryId = 11

DELETE FROM DictionaryConferenceCategory
WHERE DictionaryConferenceCategoryId = 11;

ROLLBACK

-- next id pentru districte
SELECT MAX(DictionaryDistrictId) AS maxId FROM DictionaryDistrict


-- select pentru GetDistrict
SELECT DictionaryDistrictId, DictionaryDistrictName, DistrictCode, DictionaryCountryId 
FROM DictionaryDistrict
WHERE DictionaryDistrictId = 3;

BEGIN TRAN

-- C.U.D pentru districte
INSERT INTO DictionaryDistrict (DictionaryDistrictId, 
DictionaryDistrictName, DistrictCode, DictionaryCountryId)
VALUES (9, 'Ciorba', 'CRB', 2);

UPDATE DictionaryDistrict
SET DictionaryDistrictName = 'Ciorbix',
	DistrictCode = 'CiB',
	DictionaryCountryId = 4
WHERE DictionaryDistrictId = 9;

DELETE FROM DictionaryDistrict
WHERE DictionaryDistrictId = 9;

ROLLBACK


SELECT * FROM DictionaryDistrict;


DELETE  FROM Conference;	
DELETE  FROM Location;
DELETE  FROM DictionaryCity;
DELETE  FROM DictionaryDistrict;
DELETE  FROM DictionaryCountry;
DELETE  FROM DictionaryConferenceCategory;
DELETE  FROM DictionaryConferenceType;
DELETE  FROM DictionarySpeaker;
DELETE  FROM DictionaryParticipantState;
DELETE  FROM ConferenceXDictionarySpeaker;
DELETE  FROM ConferenceParticipant;