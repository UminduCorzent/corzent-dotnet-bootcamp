## Day 3: Models & Data

### What I Did:
	- Created `Product` model with valitaion attributes
	- Created `ProductDto` for incoming API data
	- Used `[ApiController]` to auto-enable model validation

### Key Concepts:
	- **Model**: Class that represents data/entities
	- **Model Binding**: ASP.NET auto-converts incoming JSON to C# objects
	- **DTO (Data Transfer Object)**: Clean object used to transfer data between client and server
	- **Data Annotations**: Attributes like `[Required]`, `[Range]` to validate input

### Reflections:
Defining models and DTOs helped me separate internal logic from client input/output. ASP.NET takes care of a lot of the boilerplate when implemented properly.