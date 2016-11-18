# REST-API-Placeholder
Use as Tempory REST Endpoints in your Application 

Send any request to - http://rest-api-placeholder.azurewebsites.net/  and it will return a GUID

You can use that GUID to get details of the request here - 
HTTP GET
http://rest-api-placeholder.azurewebsites.net/api/calls/{{YOUR GUID GOES HERE}}

The info is stored in memory and can be removed here - 
HTTP DELETE
http://rest-api-placeholder.azurewebsites.net/api/calls/{{YOUR GUID GOES HERE}}
