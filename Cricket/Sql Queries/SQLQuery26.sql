/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [PlayerId]
      ,[PlayerName]
      ,[PlayerAge]
      ,[PlayerCoId]
  FROM [Cricket].[dbo].[player]