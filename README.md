# ContosoPizza API
A RESTful Web API built with ASP.NET Core for managing a pizza store's menu and orders.

## Tech Stack
- Framework: ASP.NET Core (.NET 8)
- Language: C#
- API Style: REST
- API Docs: OpenAPI / Swagger
- Tools: HttpRepl, dotnet CLI


## Getting Started
Prerequisites

- .NET 8 SDK
- HttpRepl (optional, for testing)
bashdotnet tool install -g Microsoft.dotnet-httprepl

### Run the API
- bashgit clone https://github.com/BathandwaLet/ContosoPizza.git
- cd ContosoPizza
- dotnet run

### The API will start on:
- http://localhost:5098

## API Endpoints
MethodEndpointDescription:
- GET/PizzaGet all pizzasGET/Pizza/{id}Get a pizza by ID
- POST/PizzaCreate a new pizza
- PUT/Pizza/{id}Update an existing pizza
- DELETE/Pizza/{id}Delete a pizza

## Testing with HttpRepl
bash: httprepl http://localhost:5098
connect http://localhost:5098 --openapi http://localhost:5098/openapi/v1.json
ls
cd Pizza
get

## Project Structure
### ContosoPizza
####  ├── Controllers
##### │     └── PizzaController.cs (API route handlers)
####  ├── Models
##### │     └── Pizza.cs (Pizza data model)
####  ├── Services
##### │     └── PizzaService.cs (Business logic handler)
####  ├── Properties
##### │     └── launchSettings.json (Dev environment and configuration)
####  ├── Program.cs (App entry point)
####  └── ContosoPizza.csproj (Project dependency)

## Example Request & Response

POST /Pizza </br>
json{ </br>
  "name": "Margherita", </br>
  "isGlutenFree": false </br>
} </br>
Response 201 Created </br>
json{ </br>
  "id": 1, </br>
  "name": "Margherita", </br>
  "isGlutenFree": false </br>
} </br>

## License
This project is for educational purposes as part of a Microsoft Learn ASP.NET Core tutorial.
link: https://learn.microsoft.com/en-us/training/modules/build-web-api-aspnet-core/

## Screenshots
- Screenshot of Pizza class.
![ContosoPizza](ContosoPizza/Screenshots/ScreenshotOfContosoPizza.png)

- Screenshot of PizzaController.
![ContosoPizza](ContosoPizza/Screenshots/ScreenshotOfContosoPizzaContoller.png)

- Screenshot of HTTP API.
![ContosoPizza](ContosoPizza/Screenshots/ScreenshotOfContosoPizzaHTTPAPI.png)

- Screenshot of PizzaService.
![ContosoPizza](ContosoPizza/Screenshots/ScreenshotOfContosoPizzaService.png)

## Development
- HTTPS Certificate (first time setup)
bashdotnet dev-certs https --trust
- OpenAPI Docs
- Once running, view the OpenAPI spec at:
http://localhost:5098/openapi/v1.json

## Author
**Bathandwa L Maphumulo**  
Email: bmap750@gmail.com  
LinkedIn: [in/bathandwa-maphumulo-216177180](https://www.linkedin.com/in/bathandwa-maphumulo-216177180/)
