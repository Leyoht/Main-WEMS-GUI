RESTORE FILELISTONLY
FROM DISK = 'C:\Users\Alex\Documents\GitHub\WEMS\Main WEMS GUI\UC1 Form\Database1.bak'
GO

RESTORE DATABASE Database1
FROM DISK = 'C:\Users\Alex\Documents\GitHub\WEMS\Main WEMS GUI\UC1 Form\Database1.bak'
WITH MOVE 'Database1' TO 'C:\Users\Alex\Documents\GitHub\WEMS\Main WEMS GUI\UC1 Form\Database1.mdf',
MOVE 'Database1_log' TO 'C:\Users\Alex\Documents\GitHub\WEMS\Main WEMS GUI\UC1 Form\Database1_log.ldf'