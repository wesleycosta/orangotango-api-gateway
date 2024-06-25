# orangotango-api-gateway
![Logo](https://github.com/wesleycosta/orangotango/raw/main/images/logos/logo_full.png)


An API gateway using Ocelot that manages communication between external services and internal microservices.

[![CodeFactor](https://www.codefactor.io/repository/github/wesleycosta/orangotango-api-gateway/badge)](https://www.codefactor.io/repository/github/wesleycosta/orangotango-api-gateway)
[![.NET](https://github.com/wesleycosta/orangotango-api-gateway/actions/workflows/dotnet.yml/badge.svg)](https://github.com/wesleycosta/orangotango-api-gateway/actions/workflows/dotnet.yml)


### Microservices Routed by API Gateway:

- [**Rooms**](https://github.com/wesleycosta/orangotango-rooms): Manages rooms and categories.
- [**Reservations**](https://github.com/wesleycosta/orangotango-reservations): Handles the management of reservations.

### Purpose:

The API Gateway abstracts the complexity of the microservices architecture, providing a simplified and unified interface for the client application to interact with. By centralizing access through the API Gateway, we ensure that the client application does not need to know the details of the underlying microservices, allowing for a more secure and manageable architecture.

### Execution:

To run the API Gateway in your local environment, follow these steps:

1. Clone the repository:

   ```bash
   git clone https://github.com/wesleycosta/orangotango-api-gateway.git
   ```

2. Open the solution file `Orangotango.Api.Gateway.sln` in your preferred IDE.

3. Select the main API Gateway project (`Orangotango.Api.Gateway`) and run it. This will start the local server for the API Gateway.

4. Make sure to properly configure the backend services that the Gateway will be routing to, such as **Rooms** and **Reservations** services.

### Contributing:

Contributions are welcome! If you have ideas for improvements or new features, feel free to submit issues and pull requests.

### License:

This project is licensed under the [MIT License](LICENSE).
