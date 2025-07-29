## Day 2: Controllers & Routing

### What I Did:
	- Created `ProductsController` and added endpoints like:
		- GET /api/products
		- GET /api/products/{id}
		- POST /api/products
	- Practiced attribute-routing
	- Learned about route constraints to validate inputs

### Key Concepts:
	- *Controller*: Class that processes API requests
	- *Action Method*: Handles a specific HTTP request (e.g., `GET`, `POST`)
	- *Attribute Routing*: Declarative route mapping using attributes
	- *Route Parameters*: Values passed via the URL (e.g., `/products/5`)
	- *Route Constraints*: Enforce rules like data types (`int`, `guid`) or min values

### Reflections:
Learned how clients reach specific endpoints in an API. Attribute routing makes routing clearer and more maintainable.