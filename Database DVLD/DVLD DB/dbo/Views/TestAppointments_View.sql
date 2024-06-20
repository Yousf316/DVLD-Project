﻿CREATE VIEW dbo.TestAppointments_View
AS
SELECT dbo.TestAppointments.TestAppointmentID, dbo.TestAppointments.LocalDrivingLicenseApplicationID, dbo.TestTypes.TestTypeID, dbo.TestTypes.TestTypeTitle, dbo.LicenseClasses.ClassName, dbo.TestAppointments.AppointmentDate, 
                  dbo.TestAppointments.PaidFees, dbo.People.FirstName + ' ' + dbo.People.SecondName + ' ' + ISNULL(dbo.People.ThirdName, '') + ' ' + dbo.People.LastName AS FullName, dbo.TestAppointments.IsLocked
FROM     dbo.TestAppointments INNER JOIN
                  dbo.TestTypes ON dbo.TestAppointments.TestTypeID = dbo.TestTypes.TestTypeID INNER JOIN
                  dbo.LocalDrivingLicenseApplications ON dbo.TestAppointments.LocalDrivingLicenseApplicationID = dbo.LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID INNER JOIN
                  dbo.Applications ON dbo.LocalDrivingLicenseApplications.ApplicationID = dbo.Applications.ApplicationID INNER JOIN
                  dbo.People ON dbo.Applications.ApplicantPersonID = dbo.People.PersonID INNER JOIN
                  dbo.LicenseClasses ON dbo.LocalDrivingLicenseApplications.LicenseClassID = dbo.LicenseClasses.LicenseClassID
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'TestAppointments_View';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'= 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'TestAppointments_View';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TestAppointments"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 304
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "TestTypes"
            Begin Extent = 
               Top = 6
               Left = 342
               Bottom = 136
               Right = 537
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LocalDrivingLicenseApplications"
            Begin Extent = 
               Top = 6
               Left = 575
               Bottom = 119
               Right = 841
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Applications"
            Begin Extent = 
               Top = 6
               Left = 879
               Bottom = 136
               Right = 1066
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "People"
            Begin Extent = 
               Top = 6
               Left = 1104
               Bottom = 136
               Right = 1305
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LicenseClasses"
            Begin Extent = 
               Top = 6
               Left = 1343
               Bottom = 136
               Right = 1549
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'TestAppointments_View';

