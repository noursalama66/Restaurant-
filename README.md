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

## 🌿 Branches

This project uses **two main branches**:

### `main` (Backend)
- Contains the **.NET backend template**.  
- Exposes **API endpoints** for users, products, and orders.  
- Used to serve data to frontend templates or other clients.  

### `front` (Frontend)
- Contains the **frontend template**.  
- Reads data from the backend API (main branch).  
- Provides a **UI for users and admins** to interact with the system.  
- Displays product data, order forms, and dashboards.  

> The `frint` branch depends on the `main` API branch for data, so make sure the backend is running before using the frontend.

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

> Frontend (`frint`) reads this data from the API (`main`) and displays it in the UI.

---

## 🛠️ Technologies Used

- **.NET 7** – API development  
- **Entity Framework** – ORM for database access  
- **SQL Server** – Database storage  
- **Swagger / Postman** – API testing  
- **Frontend Template** – HTML/CSS/JS or your preferred frontend framework  

---

## 💡 Future Improvements

- Real-time notifications for order status.  
- Role-specific dashboards for staff and customers.  
- Mobile app integration for online ordering.  
- Advanced analytics and reporting.  

---
## 🎬 Demo Video
[![Demo Video](https://img.icons8.com/color/48/000000/video.png)](https://drive.google.com/file/d/1ROn6ftHTG9Kg5KSPoRm1Y0HMOQ4unG7n/view?usp=sharing)

---

## 🚀 Usage

1. Clone the repository:  
```bash
git clone https://github.com/YourUsername/YourRepo.git
cd YourRepo

