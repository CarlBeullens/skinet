using API.Errors;
using System;
using System.Security.Cryptography.X509Certificates;

public class ApiException : ApiResponse
{
	public ApiException(int statusCode, string message = null, string details = null) : base(statusCode, message)
	{
		Details = details;
	}

	public string Details { get; set; }
}
