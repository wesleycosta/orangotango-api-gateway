Certainly! Here's the standardized README file for your `pixel-hotel-api-gateway` repository, structured similarly to your `pixel-hotel-core` README:

---

# pixel-hotel-api-gateway

[![CodeFactor](https://www.codefactor.io/repository/github/wesleycosta/pixel-hotel-api-gateway/badge)](https://www.codefactor.io/repository/github/wesleycosta/pixel-hotel-api-gateway)
[![.NET](https://github.com/wesleycosta/pixel-hotel-api-gateway/actions/workflows/dotnet.yml/badge.svg)](https://github.com/wesleycosta/pixel-hotel-api-gateway/actions/workflows/dotnet.yml)

The API Gateway serves as the single entry point for all client requests, acting as an intermediary that directs these requests to the appropriate microservices.

In this architecture, the front-end is a Single Page Application (SPA) built with Angular, which interacts with various backend services through the API Gateway.

### Microservices Routed by API Gateway:

- [**Rooms**](https://github.com/wesleycosta/pixel-hotel-rooms): Manages rooms and categories.
- [**Reservations**](https://github.com/wesleycosta/pixel-hotel-reservations): Handles the management of reservations.

### Purpose:

The API Gateway abstracts the complexity of the microservices architecture, providing a simplified and unified interface for the client application to interact with. By centralizing access through the API Gateway, we ensure that the client application does not need to know the details of the underlying microservices, allowing for a more secure and manageable architecture.

### Execution:

To run the API Gateway in your local environment, follow these steps:

1. Clone the repository:

   ```bash
   git clone https://github.com/wesleycosta/pixel-hotel-api-gateway.git
   ```

2. Open the solution file `PixelHotelApiGateway.sln` in your preferred IDE.

3. Select the main API Gateway project (`PixelHotel.ApiGateway`) and run it. This will start the local server for the API Gateway.

4. Make sure to properly configure the backend services that the Gateway will be routing to, such as **Rooms** and **Reservations** services.

---

These adjusted instructions provide a clear and precise sequence for cloning the repository, opening the solution in an IDE, and running the API Gateway project locally.

### Contributing:

Contributions are welcome! If you have ideas for improvements or new features, feel free to submit issues and pull requests.

### License:

This project is licensed under the [MIT License](LICENSE).

---

Feel free to adjust the content based on specific details or additional sections relevant to your API Gateway project. This template maintains consistency with your `pixel-hotel-core` README structure while adapting to the specifics of your API Gateway project.
