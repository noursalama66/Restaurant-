# 🍽️ Restaurant Management System API

A **robust RESTful API** built with **.NET**, designed to streamline restaurant operations, manage orders, track sales, and provide analytics.  

---

## 📌 Project Overview

This system allows restaurants to:  

- Manage **users**: Admins, cashiers, and customers.  
- Handle **products** and categories.  
- Process **orders** efficiently from cashier to kitchen.  
- Provide **real-time analytics** for admins.  

The architecture is cleanly divided into:  

- **Controllers:** Handle API requests.  
- **Models:** Represent database entities.  
- **Services:** Contain business logic.  
- **DAL (Data Access Layer):** Manage database operations.  

---


## ✨ Features

### User Management
- Role-based authentication: Admin, Cashier, Customer.  
- Secure login and access control per role.  

### Product Management
- Add, edit, delete, and view products.  
- Organize products into categories for easy navigation.  

### Order Flow
- Customers place orders → Cashier confirms.  
- Orders automatically sent to the kitchen.  
- Order statuses: **Pending → In Progress → Done → Cancelled**.  
- Automatic notifications to cashier and admin.  

### Admin Analytics
- Track total sales and revenue.  
- Identify popular products.  
- Monitor order history and performance.  

---

## ⚡ How It Works

1. Customer places an order → Cashier confirms.  
2. Order automatically sent to kitchen.  
3. Kitchen updates status → System updates cashier and admin dashboards.  
4. Admin monitors analytics and generates reports.  

---

## 🛠️ Technologies Used

- **.NET 7** – API development  
- **Entity Framework** – ORM for database access  
- **SQL Server** – Database storage  
- **Swagger / Postman** – API testing  

---

## 💡 Future Improvements

- Real-time notifications for order status.  
- Role-specific dashboards for staff and customers.  
- Mobile app integration for online ordering.  
- Advanced analytics and reporting.  

---

## 🚀 Usage

1. Clone the repository:  
```bash
git clone https://github.com/YourUsername/YourRepo.git
