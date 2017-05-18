# webapi-http406
reproduce error where asp.net web api returns HTTP 406 when controller returns good result

The WebApi406 contains a webapi project that reproduces the problem.

WebApi406.WebSvcTester is a console program that POSTS the /api/example web service using the same signature as the application that calls my production web service.

I have no control over caller. I am writing the web service.

Web service is returning 406 even if Controller returns OK.

To run Test:
1. Open Solution in Visual Studio 2015 or higher.
1. Solution should already be configured to launch both projects, but if not make that setting change.
1. Build and Run Solution.
1. When Console app opens, it will ask you to wait until WebSite finishes launching. Then press any key to call web service.
1. Result should be displayed and if it is the same as when I tested it, then it will be 406 "Not Acceptable".