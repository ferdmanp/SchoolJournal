declare @startYear int, @endYear int
declare @curYear int

set @startYear	=	2015
set @endYear	=	2050

set @curYear=@startYear

while @curYear<=@endYear
begin
	
	insert into StudyYearsList
	select @curYear, @curYear+1;

	set @curYear+=1;
end
