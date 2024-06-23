# blue-whale-api-gateway

[![CodeFactor](https://www.codefactor.io/repository/github/wesleycosta/blue-whale-api-gateway/badge)](https://www.codefactor.io/repository/github/wesleycosta/blue-whale-api-gateway)
[![.NET](https://github.com/wesleycosta/blue-whale-api-gateway/actions/workflows/dotnet.yml/badge.svg)](https://github.com/wesleycosta/blue-whale-api-gateway/actions/workflows/dotnet.yml)

The API Gateway serves as the single entry point for all client requests, acting as an intermediary that directs these requests to the appropriate microservices.

In this architecture, the front-end is a Single Page Application (SPA) built with Angular, which interacts with various backend services through the API Gateway.

### Microservices Routed by API Gateway:

- [**Rooms**](https://github.com/wesleycosta/blue-whale-rooms): Manages rooms and categories.
- [**Reservations**](https://github.com/wesleycosta/blue-whale-reservations): Handles the management of reservations.

### Purpose:

The API Gateway abstracts the complexity of the microservices architecture, providing a simplified and unified interface for the client application to interact with. By centralizing access through the API Gateway, we ensure that the client application does not need to know the details of the underlying microservices, allowing for a more secure and manageable architecture.

### Execution:

To run the API Gateway in your local environment, follow these steps:

1. Clone the repository:

   ```bash
   git clone https://github.com/wesleycosta/blue-whale-api-gateway.git
   ```

2. Open the solution file `BlueWhaleApiGateway.sln` in your preferred IDE.

3. Select the main API Gateway project (`BlueWhale.ApiGateway`) and run it. This will start the local server for the API Gateway.

4. Make sure to properly configure the backend services that the Gateway will be routing to, such as **Rooms** and **Reservations** services.

### Contributing:

Contributions are welcome! If you have ideas for improvements or new features, feel free to submit issues and pull requests.

### License:

This project is licensed under the [MIT License](LICENSE).
