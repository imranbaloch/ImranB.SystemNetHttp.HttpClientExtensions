<b> ImranB.SystemNetHttp.HttpClientExtensions</b>

## Overview

This library will add an overload for almost each existing helper method of HttpClient class. You can use this class to mimic the browser request 
sending behavior for testing your REST API.


## Example
First of all add this namespace, 

        using ImranB.SystemNetHttp;


and then use these lines to test your REST API with default Chrome request headers.

        var client = new HttpClient(myserver);
	var task = client.GetAsync("http://domain/myapi", Browser.Chrome);
	task.Wait();
	var response = task.Result;


