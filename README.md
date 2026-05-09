# ContosoPizza API
A RESTful Web API built with ASP.NET Core for managing a pizza store's menu and orders.

## Tech Stack
Framework: ASP.NET Core (.NET 8)
Language: C#
API Style: REST
API Docs: OpenAPI / Swagger
Tools: HttpRepl, dotnet CLI


## Getting Started
Prerequisites

.NET 8 SDK
HttpRepl (optional, for testing)

bashdotnet tool install -g Microsoft.dotnet-httprepl
Run the API
bashgit clone https://github.com/your-username/ContosoPizza.git
cd ContosoPizza
dotnet run
The API will start on:
http://localhost:5157

## API Endpoints
MethodEndpointDescriptionGET/PizzaGet all pizzasGET/Pizza/{id}Get a pizza by IDPOST/PizzaCreate a new pizzaPUT/Pizza/{id}Update an existing pizzaDELETE/Pizza/{id}Delete a pizza

##Testing with HttpRepl
bashhttprepl http://localhost:5098
connect http://localhost:5098 --openapi http://localhost:5098/openapi/v1.json
ls
cd Pizza
get

## Project Structure
ContosoPizza/
├── Controllers/
│   └── PizzaController.cs      # API route handlers
├── Models/
│   └── Pizza.cs                # Pizza data model
├── Services/
│   └── PizzaService.cs         # Business logic layer
├── Properties/
│   └── launchSettings.json     # Dev environment config
├── Program.cs                  # App entry point & middleware
└── ContosoPizza.csproj         # Project dependencies

## Example Request & Response
POST /Pizza
json{
  "name": "Margherita",
  "isGlutenFree": false
}
Response 201 Created
json{
  "id": 1,
  "name": "Margherita",
  "isGlutenFree": false
}

## Development
HTTPS Certificate (first time setup)
bashdotnet dev-certs https --trust
OpenAPI Docs
Once running, view the OpenAPI spec at:
http://localhost:5157/openapi/v1.json

## Author
Bathandwa L Maphumulo

## License
This project is for educational purposes as part of a Microsoft Learn ASP.NET Core tutorial.
