---

# My ASP.NET Core Web API

## Description

This Web API serves as a backend solution for Register, Login, Logout, Update user, Update password user, Delete user, Get list user with filter email. Built with ASP.NET Core, it offers scalable, robust, and secure features tailored for my project test.

The core functionality focuses on CRUD operations for user data, authentication mechanisms, and real-time analytics. With a simple design and straightforward endpoints, this API can be easily integrated into various frontend systems.

## Requirements

- .NET Core SDK 7.0
- VSCode

## Setup

1. Clone this repo:
   ```sh
   git clone https://github.com/fatah-illah/project-test.git
   ```

2. Navigate and run:
   ```sh
   cd UserApi
   dotnet run
   ```
3. The output shows messages similar to the following, indicating that the app is running and awaiting requests:
   .NET CLI
   Output :
   ...
   info: Microsoft.Hosting.Lifetime[14]
         Now listening on: http://localhost:{port}
   ...
   Ctrl+click the HTTP URL in the output to test the web app in a browser.
4. The default browser is launched to http://localhost:<port>, where <port> is the randomly chosen port number displayed in the output. There is no endpoint at http://localhost:<port>,
   so the browser returns HTTP 404 Not Found. Append /swagger to the URL, http://localhost:<port>/swagger.

## ASCII Diagram

```plaintext
+----------------+     +--------------+     +-----------------+
|                |     |              |     |                 |
|   Frontend     +----->   Web API    +----->   Database      |
| (e.g., React)  |     | (ASP.NET)    |     |  (e.g., SQL)    |
|                |     |              |     |                 |
+----------------+     +--------------+     +-----------------+
```

## Endpoints

- POST `/api/users/register`.
- POST `/api/users/login`.
- POST `/api/users/logout`.
- PUT `/api/users/{id}`.
- PUT `/api/users/update-password/{id}`.
- DELETE `/api/users/{id}`.
- GET `/api/users` = Get list user with filter email.

## Contributing

For contributions, please create a pull request.

## License

[MIT](https://choosealicense.com/licenses/mit/)

---
