# EcoMotion ⚙️⚡
**Management System for Electric Motor Repair & Sales**

This project was developed as a final capstone project (Software Engineering major). It is a comprehensive desktop application designed to manage a "Green Business" specializing in the refurbishment and repair of industrial electric motors, alongside sales of new units and spare parts.

## 📖 About the Project
**EcoMotion** was built to address the specific needs of a motor workshop. The core philosophy of the business is sustainability—focusing on "reviving" and refurbishing old motors to prevent waste and protect the environment.

The system replaces manual, paper-based tracking with a digital solution to synchronize inventory, repairs, and workforce management.

### Key Objectives:
* Streamlining workflow and workforce management.
* Documenting repair history and fault analysis to prevent recurring issues.
* Smart inventory management (New motors, Refurbished motors, Spare parts).
* Improving customer service and order tracking.

## 🚀 Key Features
The system is divided into several core modules:

* **Repair Management (Repairing):** Tracking the entire lifecycle of a motor repair (Status: In Progress/Delivered), documenting technical actions (Rewinding, Bearing replacement, etc.), and assigning specific workers to tasks.
* **Inventory Control:** Managing motor stock with detailed technical specifications (Supplier, HP, RPM, Voltage type, Production country).
* **Spare Parts Management:** Tracking spare parts inventory and automatically deducting stock when used in a repair job.
* **Sales & Invoicing:** Processing new orders, calculating costs, and linking sales to specific customers.
* **Customer & Worker Management:** A database for managing client relationships and tracking employee activity and permissions.
* **Reports:** Generating administrative reports (Income, Inventory levels, Worker lists, etc.).

## 🛠️ Tech Stack
* **Language:** C# (.NET Windows Forms)
* **IDE:** Visual Studio 2019
* **Database:** Microsoft Access

## 🔐 Login Credentials (For Testing)
The system includes an authentication mechanism with different permission levels. You can use the following hardcoded credentials to test the various interfaces as defined in the project documentation:

| Role | Username | Password | Access Level |
| :--- | :--- | :--- | :--- |
| **Manager** | `ronen` | `123` | Full access to all forms and reports |
| **Worker** | `ronen` | `1234` | Access to technical work and repair forms |
| **Seller** | `ronen` | `12345` | Access to sales and customer forms |

## 📸 Screenshots
<img width="1920" height="1015" alt="Screenshot 2025-12-06 104240" src="https://github.com/user-attachments/assets/08a27bec-9400-4cde-a63c-ebe3c78239be" />


---
**Developed by:** Ronen Shotlender
**Year:** 2024
