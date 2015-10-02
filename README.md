# QlikViewNavigationLogGenerator

## Description
a simple document extension and web service for Logging text object click events throughout the document into daily txt files

## Introduction
Standard QlikView Audit Logs for user interaction does not include Textobject trigger events. 
So, we can not track user behaviour if you have built a document in which lots of conditional objects 
and layouts which are triggered to show/hide by clicking text objects.
This code gives you the opportunity to track all Text object trigger events and log these actions into daily seperated txt files.

## Files
It includes two seperate projects:
1. Visual Studio source code & binaries.
2. NavigationLog: A QlikView document extension to track which text objects are clicked by which user.

## Requirements
* QlikView Server 11.2+ running on IIS
* IIS 6.0 +

## Installation:

* Open the VS project and build it.
* In project bin directory,  a new file called AuditLog.dll is generated.
put this file in 
C:\Program Files\QlikView\Server\QlikViewClients\QlikViewAjax\bin
and put Log.aspx into QlikViewAjax folder

* Edit web.config file in your QlikViewAjax folder and add the following lines between appSettings tags:

```xml
<add key="logfilelocation" value="C:\\NavigationLog" />
```

* Install document extension to your environment and make sure you deploy iy in the server side by copying the extension into
C:\ProgramData\QlikTech\QlikViewServer\Extensions\Document

Also make sure you have enabled the extension in your document (In Document Settings / Extension tab)

* Create a text object and give its id as "txtUserId" and add =OSUser() expression into it.
This is for obtaining current username.

* Restart IIS and QlikView Settings Services, oh yes you need to run Qlikview under IIS!

* Start browsing your document, clicking text objects and check if you see the generated files in the folder you have specified in 2nd step.

A typical log file looks like this:

Time  | User | ObjectId
------------- | ------------- | -------------
2015-10-01 12:34  | QVTR\user1 | QvFrame Document_TX1999 
2015-10-01 12:35  | QVTR\user1 | QvFrame Document_TX1899
2015-10-01 12:36  | QVTR\user1 | QvFrame Document_TX1799

You can now map this objectids to meaningful data to prepare a QlikView Audit document.

Good luck!

Ismail





