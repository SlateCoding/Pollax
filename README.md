# Pollax
## A simple server for Windows.
---

This project was created just for fun and educational purposes; please do not take it seriously...
There is, unfortunately, no installer!
This project could use quite some work; there are many bugs.


After you download the EXE, you WILL have to create quite a few files for Pollax:

1. C:/Pollax/
2. C:/pollaxdata/
3. C:/pollaxdata/server/
4. C:/pollaxdata/logs/
5. C:/pollaxdata/logs/ServerLog.log
6. C:/pollaxdata/server/data/
7. C:/pollaxdata/server/pref/
8. C:/pollaxdata/server/Default.Dat
* Inside the above mentioned file, it should contain the default files.
9. C:/pollaxdata/server/data/mime.dat
* The above file should contain the data:
> .htm; text/html
> .html; text/html
> .asp; text/html
> .bmp; image/bmp
> .gif; image/gif

10. C:/pollaxdata/server/data/vdirs.dat
* The above file should contain the data:
> /;C:\Pollax\
> /files/;C:\Pollax\files\
> /img/;C:\Pollax\img\
> /js/;C:\Pollax\js\
> /css/;C:\Pollax\css\

11. C:/pollaxdata/server/pref/report_err.dat
* The above file should contain a bollean value dictating whther to report error to Sentry or not.

12. C:/pollaxdata/server/pref/port.dat
* The above file should contain the port number to use in the server as Int32 value.

13. C:/pollaxdata/server/pref/webserver_dir.dat
* The above file should contain the following data:
> C:\Pollax\










        
