DBCC CHECKIDENT ('Location', RESEED, 0);
DBCC CHECKIDENT ('Conference', RESEED, 0);

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
SELECT * FROM ConferenceParticipant CP
JOIN DictionaryParticipantState D ON D.DictionaryParticipantStateId = CP.DictionaryParticipantStateId;


-- populare grid organizator

select DISTINCT c.ConferenceId, c.ConferenceName, c.OrganizerName, c.StartDate, c.EndDate, dct.DictionaryConferenceTypeName, 
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