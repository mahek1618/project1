/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [StateId]
      ,[Statecountry]
      ,[StateName]
      ,[No_of_matches_allowed]
      ,[StateCoId]
  FROM [Cricket].[dbo].[Stadium]