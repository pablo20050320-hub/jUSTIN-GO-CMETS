/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [attendance_id]
      ,[member_id]
      ,[full_name]
      ,[event_name]
      ,[event_date]
      ,[status]
      ,[time_in]
  FROM [memberInfo].[dbo].[Attendance]