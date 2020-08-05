# A Simple To-Do Application
### Written using .NET Core 3.1
A simple To-Do API application using .NET Core 3.1. The purpose of this repository is to act as a baseline
when demonstrating .NET Core 3.1 features.

## Prerequisites
The following tools are required to run this application:
 * [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download/dotnet/current)
 * A text editor or IDE (Integrated Development Environment) such as [Visual Studio or VS Code](https://visualstudio.microsoft.com/downloads/)
 * [cURL](https://curl.haxx.se/download.html) *Optional - allows execution of the scripts for testing the endpoints*

## Build and Run
To build and run the application, run the following commands from the terminal when in the root project folder:

```bash
dotnet build
dotnet run
```

## Endpoints
Once running, the application should be listening on the following ports:
 * 5000 - the insecure HTTP port. Since the application uses [HSTS](https://en.wikipedia.org/wiki/HTTP_Strict_Transport_Security), all requests will be redirected to the secure port
 * 5001 - the secure HTTPS port

The following endpoints are then available:
| HTTP Verb | Route |
|-----------|-------|
| GET       | `/api/todo/{fail}` |
| PUT       | `/api/todo/{fail}` |
| PATCH     | `/api/todo/{id}/{fail}` |
| DELETE    | `/api/todo/{id}/{fail}` |

Route parameters:
 * `fail` - optional boolean (true or false) value
   * Defaults to `false`
   * When `true`, simulates an error in the endpoint
 * `id` - required integer value that specifies the unique identifier of the record to be updated or deleted

## Author
Samuel Slade<br />
Independent Consultant<br />
Director | [Slade Software Ltd](https://www.sladesoftware.co.uk)<br />
[samuel.slade@sladesoftware.co.uk](mailto:samuel.slade@sladesoftware.co.uk)

