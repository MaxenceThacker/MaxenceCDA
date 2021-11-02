@echo off
SetLocal EnableDelayedExpansion
cd C:\wamp64\bin\mysql\mysql5.7.31\data
MKDIR U:\59011-07-11\Sauvegardebdd\%DATE:~6,4%%DATE:~3,2%%DATE:~0,2%
for /d %%i in (*) do (
if /I %%i NEQ performance_schema if /I %%i NEQ mysql if /I %%i NEQ sys C:\wamp64\bin\mysql\mysql5.7.31\bin\mysqldump --user=root --databases %%i > U:\59011-07-11\CDA\Sauvegardebdd\Backup_Du_%DATE:~0,2%"-"%DATE:~3,2%"-"%DATE:~6,4%\____%%i____%DATE:~0,2%"-"%DATE:~3,2%"-"%DATE:~6,4%.sql  
)
EndLocal