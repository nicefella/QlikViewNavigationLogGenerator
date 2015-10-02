# QlikViewNavigationLogGenerator
Logging text object click events throughout the document into daily txt files

Standard QlikView Audit Logs for user interaction does not include Textobject trigger events. 
So, we can not track user behaviour if you have built a document in which lots of conditional objects 
and layouts which are triggered to show/hide by clicking text objects.

This code gives you the opportunity to track all Text object trigger events and log these actions into daily seperated txt files.

It includes two seperate projects:
1. Visual Studio source code & binaries.
2. NavigationLog: A QlikView document extension to track which text objects are clicked by which user.

## Installation:

1. In bin directory, there is a file called : AuditLog.dll
put this file in 
C:\Program Files\QlikView\Server\QlikViewClients\QlikViewAjax\bin
And put Log.aspx into QlikViewAjax folder

2. Edit web.config file in your QlikViewAjax folder and add the following lines between appSettings tags:

```xml
<add key="logfilelocation" value="C:\\NavigationLog" />
```

3. Install document extension to your environment and make sure you deploy iy in the server side by copying the extension into
C:\ProgramData\QlikTech\QlikViewServer\Extensions\Document
Also make sure you have enabled the extension in your document (In Document Settings / Extension tab)

4. Create a text object and give its id as "txtUserId" and add =OSUser() expression into it.
This is for obtaining current username.

5. Restart IIS and QlikView Settings Services, oh yes you need to run Qlikview under IIS!

6. Start browsing your document, clicking text objects and see the generated files in the folder you have specified in 2nd step.

A typical log file looks like this:

Time  | User | ObjectId
------------- | ------------- | -------------
2015-10-01 12:34  | QVTR\user1 | QvFrame Document_TX1999 
2015-10-01 12:35  | QVTR\user1 | QvFrame Document_TX1899
2015-10-01 12:36  | QVTR\user1 | QvFrame Document_TX1799

You can now map this objectids to meaningful data to prepare a QlikView Audit document.

Good luck!

Ismail





