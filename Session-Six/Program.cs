/*
    1. Client → HTTP Request → API → HTTP Response → Client
    2. Restful API (Application Programming Interface): Representational State Transfer (REST)
       is an architectural style for designing networked applications.
       It relies on a stateless, client-server,
       RESTful applications use HTTP requests to perform CRUD operations
       (Create, Read, Update, Delete) on resources, which are identified by URLs.
       The responses are typically in JSON or XML format.
    3. Structure of a Project folder and files:
           - Controllers/
           - Models/
           - Services/
           - DTOs/
    4. Controller & Routing :
       - Controller: A controller is a class that handles HTTP requests and returns HTTP responses.
       - Routing: Routing is the process of mapping incoming HTTP requests to the appropriate controller action method.
    5. Endpoints : 
       - An endpoint is a URL that represents a resource or a collection of resources in a RESTful API.
       - Endpoints are defined in the controller classes using attributes such as [HttpGet], [HttpPost], [HttpPut], and [HttpDelete].
    6. Method: GET, POST, PUT, DELETE
    7. Status Codes: 200 => OK,
                     201 => Created,
                     400 => Bad Request,
                     404 => Not Found, 
                     500 => Internal Server Error
    8. Request Format:
       GET    /api/products
       GET    /api/products/5
       GET    /api/products?category=electronics
       POST   /api/products
       PUT    /api/products/5
       DELETE /api/products/5
    9. Body Format: JSON, XML, Form Data
    10. Parameters: 
       - Parameters are values that are passed to the controller action methods to perform operations on resources.
       - Parameters Types :
            - Route Parameters: These are parameters that are part of the URL path and are defined in the route template. 
            For example, in the URL /api/products/5, the value 5 is a route parameter that represents the ID of a product.
            - Query Parameters: These are parameters that are passed in the query string of the URL. 
            For example, in the URL /api/products?category=electronics, the value electronics is a query parameter that represents the category of products to retrieve.
            - Body Parameters: These are parameters that are passed in the body of the HTTP request. 
            For example, in a POST request to /api/products, the body may contain a JSON object representing a new product to create.
    11. Dependency Injection (DI) :
        - Dependency Injection is a design pattern that allows you to inject dependencies into a class rather than creating them within the class.
        - In ASP.NET Core, DI is built-in and can be configured in the Startup.cs file or Program.cs file.
        - Services can be registered with different lifetimes: Singleton, Scoped, and Transient.
        EXAMPLE:
            public class OrderService
            {
                private readonly EmailService _emailService;

                public OrderService()
                {
                    _emailService = new EmailService(); 
                    --> This is not DI, because the OrderService class is creating an instance of EmailService within its constructor.        
                }
            } 

            public class OrderService
            {
                private readonly EmailService _emailService;
                public OrderService(EmailService emailService)
                {
                    _emailService = emailService; 
                    --> This is DI, because the OrderService class is receiving an instance of EmailService through its constructor.
                        it is sent to it from the outside, and it is not creating it within the class.
                        DI Container is responsible for creating the instance of EmailService and injecting it into the OrderService class.
                        Ex: builder.Services.AddScoped<EmailService>();
                }
            } 

            DI With Interface:
            public class OrderService
            {
                private readonly ISenderService _emailService;
                public OrderService(ISenderService emailService)
                {
                    _emailService = emailService; 
                    --> This is DI, because the OrderService class is receiving an instance of IEmailService through its constructor.
                        it is sent to it from the outside, and it is not creating it within the class.
                        DI Container is responsible for creating the instance of IEmailService and injecting it into the OrderService class.
                        Ex: builder.Services.AddScoped<ISenderService, EmailService>();
                }
            }

    12. Model Validation:
        - Model validation is the process of validating the data received in the request body against the model's data annotations.
        - Data annotations are attributes that can be applied to model properties to specify validation rules.
        - The [ApiController] attribute automatically performs model validation and returns a 400 Bad Request response if the model state is invalid.
 */




using Microsoft.EntityFrameworkCore;
using Session_Six;
using Session_Six.Infrastructure;
using Session_Six.IServices;
using Session_Six.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetSection("DefaultConnection").Value));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
