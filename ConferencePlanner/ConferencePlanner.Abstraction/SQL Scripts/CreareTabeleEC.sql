
CREATE TABLE DictionaryConferenceCategory( -- IT/medical/etc.
	
	DictionaryConferenceCategoryId INT,
	DictionaryConferenceCategoryName NVARCHAR(255) NOT NULL,
	ConferenceCategoryCode NVARCHAR(10) UNIQUE,
	PRIMARY KEY(DictionaryConferenceCategoryId)
);

CREATE TABLE DictionaryConferenceType( --remote/fizic
	
	DictionaryConferenceTypeId INT,
	DictionaryConferenceTypeName NVARCHAR(255) NOT NULL,
	ConferenceTypeCode NVARCHAR(10) UNIQUE,
	PRIMARY KEY(DictionaryConferenceTypeId)
);

CREATE TABLE DictionaryCountry (
	DictionaryCountryId INT,
	CountryCode NVARCHAR(10) UNIQUE,
	DictionaryCountryName NVARCHAR(255) NOT NULL,
	PRIMARY KEY (DictionaryCountryId)
);

CREATE TABLE DictionaryDistrict (
	DictionaryDistrictId INT,
	DistrictCode NVARCHAR(10) UNIQUE,
	DictionaryDistrictName NVARCHAR(255) NOT NULL,
	DictionaryCountryId INT,
	PRIMARY KEY (DictionaryDistrictId),
	FOREIGN KEY (DictionaryCountryId) REFERENCES DictionaryCountry(DictionaryCountryId)
);

CREATE TABLE DictionaryCity (
	DictionaryCityId INT,
	CityCode NVARCHAR(10) UNIQUE,
	DictionaryCityName NVARCHAR(255) NOT NULL,
	DictionaryDistrictId INT,
	PRIMARY KEY (DictionaryCityId),
	FOREIGN KEY (DictionaryDistrictId) REFERENCES DictionaryDistrict(DictionaryDistrictId)
);

CREATE TABLE Location (
	LocationId INT IDENTITY(1, 1),
	DictionaryCityId INT,
	Longitude NVARCHAR(255),
	Latitude NVARCHAR(255),
	PRIMARY KEY (LocationId),
	FOREIGN KEY (DictionaryCityId) REFERENCES DictionaryCity(DictionaryCityId)
);

CREATE TABLE Conference(

	ConferenceId INT IDENTITY(1,1),
	ConferenceName NVARCHAR(255) NOT NULL,
	OrganizerEmail NVARCHAR(255) NOT NULL,
	OrganizerName NVARCHAR(255) NOT NULL,
	StartDate DATETIME NOT NULL,
	EndDate DATETIME NOT NULL,
	DictionaryConferenceCategoryId INT,
	DictionaryConferenceTypeId INT,
	LocationId INT NOT NULL,
	PRIMARY KEY (ConferenceId),
	FOREIGN KEY (DictionaryConferenceCategoryId) REFERENCES DictionaryConferenceCategory(DictionaryConferenceCategoryId),
	FOREIGN KEY (DictionaryConferenceTypeId) REFERENCES DictionaryConferenceType(DictionaryConferenceTypeId),
	FOREIGN KEY (LocationId) REFERENCES Location(LocationId),
	CONSTRAINT CK_Conference_StartDate CHECK (StartDate >= GETDATE()),
	CONSTRAINT CK_Conference_EndDate CHECK (EndDate >= StartDate)

);

CREATE TABLE DictionaryParticipantState( --Withdrawn, Joined, Attended

	DictionaryParticipantStateId INT,
	DictionaryParticipantStateName NVARCHAR(255) NOT NULL,
	ParticipantStateCode NVARCHAR(10) UNIQUE,
	PRIMARY KEY(DictionaryParticipantStateId)
);

CREATE TABLE ConferenceParticipant(

	ConferenceId INT,
	ParticipantEmail NVARCHAR(255) NOT NULL,
	DictionaryParticipantStateId INT,
	PRIMARY KEY (ConferenceId, ParticipantEmail),
	FOREIGN KEY (ConferenceId) REFERENCES Conference(ConferenceId),
	FOREIGN KEY (DictionaryParticipantStateId) REFERENCES DictionaryParticipantState(DictionaryParticipantStateId)
);


CREATE TABLE DictionarySpeaker(
	
	DictionarySpeakerId INT,
	SpeakerCode NVARCHAR(10) UNIQUE,
	DictionarySpeakerName NVARCHAR(255) NOT NULL,
	Rating NUMERIC(30,2),
	Nationality NVARCHAR(255),
	Picture NVARCHAR(255),
	PRIMARY KEY(DictionarySpeakerId)

);

CREATE TABLE ConferenceXDictionarySpeaker(

	DictionarySpeakerId INT,
	ConferenceId INT,
	IsMainSpeaker BIT NOT NULL,
	PRIMARY KEY (DictionarySpeakerId, ConferenceId),
	FOREIGN KEY (DictionarySpeakerId) REFERENCES DictionarySpeaker(DictionarySpeakerId),
	FOREIGN KEY (ConferenceId) REFERENCES Conference(ConferenceId)
);