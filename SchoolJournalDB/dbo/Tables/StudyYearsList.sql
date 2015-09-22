CREATE TABLE [dbo].[StudyYearsList]
(
	[Id] INT identity(1,1) NOT NULL PRIMARY KEY,
	YearStart	smallint,
	YearFinish	smallint,
	YearDesc as convert(char(4),YearStart)+'-'+convert(char(4),YearFinish)
)
