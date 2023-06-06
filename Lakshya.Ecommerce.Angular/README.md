Sure! Here's an updated version of the overview using markdown symbols:

## Project Overview

1. **Ecommerce Web Application**

   - Description: A web application for an ecommerce platform.
   - Technologies: ASP.NET Core, Angular, SQL Server.
   - Features: User authentication, product catalog, shopping cart, order management, payment integration, and user reviews.
   - Responsibilities: Developed backend API using ASP.NET Core, implemented frontend components using Angular, integrated with external payment gateway, and designed the database schema.

2. **FastReports Integration**

   - Description: Integration of FastReports reporting tool into the ecommerce application.
   - Technologies: FastReports, C#, .NET Core.
   - Features: Generating dynamic reports based on data retrieved from the API, exporting reports in various formats (PDF, Excel, etc.), and displaying reports to users.
   - Responsibilities: Integrated FastReports into the application, designed report templates, implemented report generation logic, and configured data binding with the API.

3. **Sales Data Management**

   - Description: Module for managing sales data within the ecommerce application.
   - Technologies: C#, .NET Core, Entity Framework Core, SQL Server.
   - Features: CRUD operations for sales data, data validation, filtering, sorting, and pagination.
   - Responsibilities: Designed and implemented the Sales entity and repository, created database seed data, implemented API endpoints for managing sales data, and ensured data integrity and security.

4. **CORS Configuration**

   - Description: Configuring Cross-Origin Resource Sharing (CORS) in the API.
   - Technologies: ASP.NET Core.
   - Features: Enabling CORS to allow cross-origin requests from specified domains.
   - Responsibilities: Configured CORS policies in the API to allow specific origins, HTTP methods, and headers, ensuring secure communication between the frontend and backend.

## Additional Information

- If running the Angular application on a port other than 4200, configure the CORS policy using the following code:
  
  ```csharp
  app.UseCors(x => x.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader().AllowCredentials());
  ```

This provides a brief overview of the projects I worked on, including their descriptions, technologies used, features implemented, and my responsibilities within each project.
