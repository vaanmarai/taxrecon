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

## Observability & Tracing
- Both API projects are instrumented with OpenTelemetry and export traces to Jaeger.
- Jaeger is available locally via devcontainer/docker-compose for easy trace visualization.
- Service names are unique per API for clear trace separation.

## Testing & CI
- Each project has unit and integration test projects (xUnit, bUnit, etc.).
- GitHub Actions CI builds and tests all projects on push/PR.

## Local Development
- Devcontainer includes .NET SDKs and Jaeger.
- Environment variables for Jaeger agent are pre-configured.
- See README for local run/test instructions.

---

For more details, see the README and Project-Kickoff-Plan.md.
