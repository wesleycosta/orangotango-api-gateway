# pixel-hotel-api-gateway

[![CodeFactor](https://www.codefactor.io/repository/github/wesleycosta/pixel-hotel-api-gateway/badge)](https://www.codefactor.io/repository/github/wesleycosta/pixel-hotel-api-gateway)
[![.NET](https://github.com/wesleycosta/pixel-hotel-api-gateway/actions/workflows/dotnet.yml/badge.svg)](https://github.com/wesleycosta/pixel-hotel-api-gateway/actions/workflows/dotnet.yml)

The API Gateway serves as the single entry point for all client requests, acting as an intermediary that directs these requests to the appropriate microservices. 

In this architecture, the front-end is a Single Page Application (SPA) built with Angular, which interacts with various backend services through the API Gateway.

The API Gateway utilizes [Ocelot](https://github.com/ThreeMammals/Ocelot) to manage and route requests to the following microservices:

- [**Rooms**](https://github.com/wesleycosta/pixel-hotel-rooms): Manages rooms and categories.
- [**Reservations**](https://github.com/wesleycosta/pixel-hotel-reservations): Handles the management of reservations.

When a request is made from the Angular SPA, the API Gateway processes and routes it to the appropriate microservice, either Reservations or Rooms, depending on the nature of the request. 

By centralizing access through the API Gateway, we ensure that the client application does not need to know the details of the underlying microservices, allowing for a more secure and manageable architecture.

The API Gateway, therefore, abstracts the complexity of the microservices architecture, providing a simplified and unified interface for the client application to interact with.
