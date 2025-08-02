## Day 5: Data Persistence & Entity Framework

### What I Did:
	- Installed EF Core packages
	- Created `AppDbContext` and registered it in `Program.cs`
	- Used `DbSet<Product>` to represent the Products table
	- Created and applied migrations
	- Integrated EF with `ProductService` to perform real CRUD operations

### Key Concepts:
	- **EF Core**: ORM for interacting with databases via C# classes
	- **DbContext**: Represents the database session, holds `DbSet`s
	- **Migrations**: Tracks and applies schema changes

### Reflections:
Connecting models to an actual database and performing real CRUD operations was so interesting and the EF Core made it so intuitive.