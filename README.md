# REST-API-Placeholder
Use as Tempory REST Endpoints in your Application 

Send any request to - https://rest-api-placeholder.azurewebsites.net/  and it will return a GUID

You can use that GUID to get details of the request here  <br /> 
HTTP GET <br /> 
https://rest-api-placeholder.azurewebsites.net/api/calls/{{YOUR_GUID_GOES_HERE}} <br /> <br /> 

The info is stored in memory and can be removed here <br /> 
HTTP DELETE <br /> 
https://rest-api-placeholder.azurewebsites.net/api/calls/{{YOUR_GUID_GOES_HERE}}
