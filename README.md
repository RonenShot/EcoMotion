# EcoMotion ⚙️⚡
**Management System for Electric Motor Repair & Sales**

This project was developed as a final capstone project (Software Engineering major). It is a comprehensive desktop application designed to manage a "Green Business" specializing in the refurbishment and repair of industrial electric motors, alongside sales of new units and spare parts.

## 📖 About the Project
**EcoMotion** was built to address the specific needs of a motor workshop. [cite_start]The core philosophy of the business is sustainability—focusing on "reviving" and refurbishing old motors to prevent waste and protect the environment[cite: 16, 18].

[cite_start]The system replaces manual, paper-based tracking with a digital solution to synchronize inventory, repairs, and workforce management[cite: 15, 74].

### Key Objectives:
* [cite_start]Streamlining workflow and workforce management[cite: 66].
* [cite_start]Documenting repair history and fault analysis to prevent recurring issues[cite: 87, 91].
* [cite_start]Smart inventory management (New motors, Refurbished motors, Spare parts)[cite: 65, 98].
* [cite_start]Improving customer service and order tracking[cite: 65].

## 🚀 Key Features
The system is divided into several core modules:

* [cite_start]**Repair Management (Repairing):** Tracking the entire lifecycle of a motor repair (Status: In Progress/Delivered), documenting technical actions (Rewinding, Bearing replacement, etc.), and assigning specific workers to tasks[cite: 260, 261, 262].
* [cite_start]**Inventory Control:** Managing motor stock with detailed technical specifications (Supplier, HP, RPM, Voltage type, Production country)[cite: 292, 426].
* [cite_start]**Spare Parts Management:** Tracking spare parts inventory and automatically deducting stock when used in a repair job[cite: 301, 311].
* [cite_start]**Sales & Invoicing:** Processing new orders, calculating costs, and linking sales to specific customers[cite: 253, 318].
* [cite_start]**Customer & Worker Management:** A database for managing client relationships and tracking employee activity and permissions[cite: 271, 282].
* [cite_start]**Reports:** Generating administrative reports (Income, Inventory levels, Worker lists, etc.)[cite: 972].

## 🛠️ Tech Stack
* **Language:** C# (.NET Windows Forms)
* [cite_start]**IDE:** Visual Studio 2019 [cite: 133]
* [cite_start]**Database:** Microsoft Access [cite: 133]

## 🔐 Login Credentials (For Testing)
The system includes an authentication mechanism with different permission levels. You can use the following hardcoded credentials to test the various interfaces as defined in the project documentation:

| Role | Username | Password | Access Level |
| :--- | :--- | :--- | :--- |
| **Manager** | `ronen` | `123` | [cite_start]Full access to all forms and reports [cite: 959] |
| **Worker** | `ronen` | `1234` | [cite_start]Access to technical work and repair forms [cite: 960] |
| **Seller** | `ronen` | `12345` | [cite_start]Access to sales and customer forms [cite: 960] |

## 📸 Screenshots
<img width="1920" height="1015" alt="Screenshot 2025-12-06 104240" src="https://github.com/user-attachments/assets/4438d740-d718-4049-aa8d-af8033136591" />

---
[cite_start]**Developed by:** Ronen Shotlender [cite: 7]
[cite_start]**Year:** 2024 [cite: 10]
