# Solution Architecture: UI & API Separation

## Overview
This solution contains two main application domains:
- **Accountant**
- **Customer**

Each domain is split into:
- A Blazor Web App (UI)
- An ASP.NET Core Web API (API backend)

## Project Structure
- `Accountant/` - Blazor Web App (UI for accountants)
- `Accountant.Api/` - ASP.NET Core Web API (backend for accountant features)
- `Customer/` - Blazor Web App (UI for customers)
- `Customer.Api/` - ASP.NET Core Web API (backend for customer features)

## Separation Principles
- **UI projects** contain only UI logic, components, and client-side code. They do not contain business logic or direct data access.
- **API projects** expose REST endpoints, handle business logic, and data access. They are the only projects that interact with databases or external services.
- Communication between UI and API is via HTTP calls (e.g., using `HttpClient`).

## Benefits
- Clear separation of concerns
- Easier to scale, test, and secure each layer
- Enables independent deployment and development

---

For more details, see the README and Project-Kickoff-Plan.md.
