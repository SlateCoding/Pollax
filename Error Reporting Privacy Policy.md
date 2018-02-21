# Error Reporting Privacy Policy
Last edited February 20, 2018 AD, on Planet Earth

### Why do we collect error reports?
We collect error reports when an exception occurrs (i.e. an error happens either because of a mistake in the code, or because of faulty usage of the code, et cetera) in the code. We collect error reports __solely for the purpose of finding bugs in the source code and fixing them.__ In short, we use bug reports to make Pollax a better application.

### How is information collected?
We collect error/crash data using [Sentry](https://sentry.io/), which is an online based service for collecting and tracking bugs in the source code. Info is collected via SharpRaven, the NuGet .NET Sentry client package.

### What types of information can be collected?
Here is a list of the information collected in the event of a exception/error/crash in Pollax:

  1. Error level (is it an error or a warning?)
  2. Logger ID (which logger inside Pollax made the report?)
  3. Server Name (the computer name where the error occurred)
  4. Transaction (which event, call, or function led to the error)
  5. Usename (the username of the user on the computer which was running Pollax when the error occurred)
  6. Error Message (EG attempted to divide by zero)
  7. Exception (the body and everything), which includes:
      * The File in whuch the error occurred
      * The line number on which the error occurred
  8. Packages and the version number
  9. The App Version No.
  10. SDK Name and Version no. (The version number of SharpRaven)
  11. Event ID (EG 51f0f06cf0db4e839a8a8a8e984b7210)
  12. Date of occurrence
  
These information is the only information collected.
To see a sample error report, [click here](https://sentry.io/share/issue/9a2f011a0b0f43b88fdd464cfc33a60f/).
  
### Who can use the information and how can it be used?
When an error occurrs, the error is submited to Sentry to our error dashboard, where is is seen by the devs first. Then we may choose to make the error semi-public by publishing the error report on Github. There, only the Exception BODY is seen in the public issue report, an also a link to the error report in Sentry. This link can only be viewed by those we choose, which is mostly only the devs. Occasionally we may choose to make an issue public to the person who, um, *suffered* the error. Otherwise, __under no circumstances,__ would we even *dream* of making an error public to the general public. However, we may sometimes disclose information, to __comply with the law or respond to lawful request(s) or legal process(es).__

### Information storage, processing, and release
Information stored in Sentry or Github is processed in their servers, wherever that may be.

### Changes to this privacy statement
We will occasionally revise or update this policy. When we do so we will update the "last edited date" at the top of this document. *Therefore, it is a __very__ good idea to occasionally check this document to be notified of any changes.*
