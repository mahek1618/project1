/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [CountryId]
      ,[CountryName]
      ,[Continent]
      ,[CountryCode]
  FROM [Cricket].[dbo].[country]