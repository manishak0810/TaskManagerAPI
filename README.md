
# Task Manager API

A simple RESTful Web API built using C# and ASP.NET Core.

## Features

- View all tasks
- View a task by ID
- Add new tasks
- Update existing tasks
- Delete tasks
- Basic input validation

## Technologies

- C#
- ASP.NET Core Web API
- .NET 8
- RESTful APIs

## API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | /api/tasks | Retrieve all tasks |
| GET | /api/tasks/{id} | Retrieve a task |
| POST | /api/tasks | Create a task |
| PUT | /api/tasks/{id} | Update a task |
| DELETE | /api/tasks/{id} | Delete a task |

## Getting Started

1. Clone the repository.
2. Open the project folder.
3. Run `dotnet restore`.
4. Run `dotnet run`.
5. Use the displayed localhost URL with `/api/tasks`.

## Notes

Tasks are stored in memory and reset when the application restarts.
