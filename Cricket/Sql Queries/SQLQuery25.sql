use[Cricket]
GO
create table country
(
CountryId int not null primary key identity(1,1),
CountryName varchar(50) not null,
 Continent varchar(50) not null,
 CountryCode varchar(30) not null Unique
 )
 go
 create table player
(
PlayerId int not null primary key identity(1,1),
PlayerName varchar(50) not null,
 PlayerAge int not null,
 PlayerCoId int not null
 )
  create table stadium
(
StateId int not null primary key identity(1,1),
Statecountry varchar(50) not null,
 StateName int not null,
 No_of_matches_allowed int not null
 )
 alter table state 
 add StateCoId int;

 create table Matches
 (
 MatchId int not null primary key identity(1,1),
MatchStId int not null,
TeamA varchar(50) not null,TeamB varchar(50) not null,Result varchar(30) default 'null' not null,Date_Time datetime not null, Was_match_played int 
)
alter table stadium 
alter column StateName varchar(50) not null