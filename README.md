# SampleAPI
Basic Entity Framework REST api and a vb client using the api. 

## Trusting ASP NET Core dev certs
https://www.hanselman.com/blog/DevelopingLocallyWithASPNETCoreUnderHTTPSSSLAndSelfSignedCerts.aspx

## Running
1. Press <bbd>F5</kbd>
2. 2 projects will run.  The api project and the client project.  The swagger page is the documentation of the api and you can interact with the API on teh swagger page. The client application will generate sample movie records if none exist.

## Notes
- I did not implement update, delete, add functionality.  I leave that to you to try to figure out.  You could handle grid events and call the right API to get it to handle the right actions. PUT=Update, POST=create.  
