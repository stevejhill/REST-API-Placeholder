# REST-API-Placeholder
Use as Tempory REST Endpoints in your Application 

Send any request to - http://rest-api-placeholder.azurewebsites.net/  and it will return a GUID

You can use that GUID to get details of the request here  <br /> 
HTTP GET <br /> 
http://rest-api-placeholder.azurewebsites.net/api/calls/{{YOUR_GUID_GOES_HERE}} <br /> <br /> 

The info is stored in memory and can be removed here <br /> 
HTTP DELETE <br /> 
http://rest-api-placeholder.azurewebsites.net/api/calls/{{YOUR_GUID_GOES_HERE}}