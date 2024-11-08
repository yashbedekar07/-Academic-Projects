Rakes Module - Overseas Transport Management System
The Rakes Module is an integral part of the Overseas Transport Management System, designed to streamline and manage rake movements and transportation logistics efficiently. Developed using C# and Web API, this module plays a vital role in handling rake data, scheduling, and integration with other modules of the system.

Features
Rake Scheduling: Manage rake schedules for various transport routes.
API Integration: Seamless integration of APIs to communicate with other modules.
Database Management: Efficient handling of rake-related data using SQL.
Frontend Integration: Fully functional UI to visualize and manage rake operations.
Testing: Comprehensive testing of APIs to ensure smooth operation and integration.
Deployment Ready: Capable of deployment on IIS servers.
Technologies Used
Backend: C#, .NET Core, Web API
Frontend: HTML, CSS, JavaScript, Bootstrap
Database: SQL Server
Version Control: Git & GitHub
Deployment: IIS Server
Installation
Clone the repository:

bash
Copy code
git clone https://github.com/yashbedekar07/rakes-module.git
Database Setup:

Import the SQL scripts located in the /database folder to set up the necessary tables and data in SQL Server.
Configure API:

Update the database connection string in the appsettings.json file.
Ensure all required environment variables are set up for API configurations.
Frontend Setup:

Frontend files are available in the /UI directory. You can run them directly on a web server or integrate them with the Web API.
Deploy on IIS (optional):

Follow the standard deployment process for .NET Core applications on IIS servers. Refer to Microsoft's official IIS deployment guide for more details.
Usage
API Endpoints:

GET /api/rakes - Retrieve rake data.
POST /api/rakes - Add new rake information.
PUT /api/rakes/{id} - Update existing rake data.
DELETE /api/rakes/{id} - Delete rake data.
Frontend:

The frontend dashboard allows users to view rake schedules, add new entries, and manage existing data.
Testing
Unit tests are provided for all API endpoints. Run the tests using the following command:
bash
Copy code
dotnet test
Contribution
Feel free to fork this repository and submit pull requests. Any contributions towards improving the module or fixing issues are welcome.

License
This project is licensed under the MIT License - see the LICENSE file for details.

Author
Developed by Yash Bedekar.

LinkedIn: Yash Bedekar
GitHub: yashbedekar07
