🚀 Project Overview

This system allows restaurants to:

Handle users: Admins, cashiers, and customers.

Manage products and categories.

Process orders efficiently from cashier to kitchen.

Provide real-time analytics for admins.

The architecture is cleanly divided into:

Controllers: Handle API requests.

Models: Represent database entities.

Services: Contain business logic.

DAL (Data Access Layer): Manage database operations.

Features
User Management

Role-based authentication: Admin, Cashier, Customer.

Secure login and access control per role.

Product Management

Add, edit, delete, and view products.

Organize products into categories for easy navigation.

Order Flow

Customers place orders via cashier.

Orders are automatically sent to the kitchen.

Order statuses: Pending → In Progress → Done → Cancelled.

Automatic updates notify the cashier and admin.

Admin Analytics

Track total sales and revenue.

Identify popular products.

Monitor order history and performance statistics.

⚡ How It Works

Customer places an order → Cashier confirms.

Order automatically sent to kitchen.

Kitchen updates status → System updates cashier and admin dashboards.

Admin can monitor analytics and generate reports.

🛠️ Technologies Used

.NET 7 – API development

Entity Framework – ORM for database access

SQL Server – Database storage

Swagger / Postman – API testing

💡 Future Improvements

Real-time notifications for order status.

Role-specific dashboards for staff and customers.

Mobile app integration for online ordering.

Advanced analytics and reports.

📌 Usage

Clone the repository:

git clone https://github.com/YourUsername/YourRepo.git


Navigate to project folder and restore dependencies:

cd RestaurantAPI
dotnet restore


Run the API:

dotnet run


Test endpoints using Postman or Swagger UI.

🎯 Goal

Make restaurant operations fast, efficient, and automated, giving admins full control while improving customer experience.
