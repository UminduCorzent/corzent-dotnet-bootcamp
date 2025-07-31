## Day 4: Dependency Injection & Services

### What I Did:
	- Created `ProductService` and interface `IProductService`
	- Registered the service using `AddScoped<>` in Program.cs
	- Injected the service into `ProductController`
	- Moved business logic (like GetById, Create) into the service layer

### Key Concepts:
	- **Service Layer**: A class that contains the app's business logic
	- **Dependency Injection**: A design pattern where dependencies are provided by the framework
	- **AddScoped**: Creates one service instance per request

### Reflections:
Using DI and services made my controller simpler and more readable.