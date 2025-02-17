🚀 CQRS API in Domain-Centric Design Architecture

This project showcases a CQRS API built with a domain-centric design architecture using .NET 8 and the Mediator pattern with a request pipeline.

✨ Features

✅ CQRS Implementation – Clearly separates read and write operations for better maintainability and scalability.
✅ Domain-Centric Design – Emphasizes the business domain and core logic, ensuring a clean and modular architecture.
✅ Mediator with Request Pipeline – Implements the Mediator pattern to manage requests and responses efficiently, allowing a structured request-handling pipeline.

- Why Use a Request Pipeline with Mediator?
 Simplified Request Handling
A structured request pipeline provides a unified entry point, streamlining how requests are processed.

- Centralized Middleware Dependencies
Mediator acts as a middleware, handling cross-cutting concerns such as:
🔹 Logging – Maintain a detailed request log effortlessly.

🔹 Validation – Ensure data integrity before execution.

🔹 Authorization – Control access with a centralized approach.

By centralizing these concerns, we reduce code duplication and enhance maintainability.
