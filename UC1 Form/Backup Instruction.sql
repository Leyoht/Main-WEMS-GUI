﻿BACKUP DATABASE [C:\Users\Alex\Documents\GitHub\WEMS\Main WEMS GUI\UC1 Form\Database2.mdf] TO  DISK = N'C:\Users\dtdkn\Documents\GitHub\WEMS\Main-WEMS-GUI\UC1 Form\Database1.bak' WITH NOFORMAT, INIT,  NAME = N'WILCO_DB-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10
GO --Note that the space within the brackets NEEDS A REFERENCE to the Database2.mdf file in YOUR directory, not mine!
--The same goes for WHERE ON THE DISK you want to save the database backup