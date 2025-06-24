Task Breakdown for Initial Engineering Setup
1. Create Two .NET Web Applications with Blazor UI and API
1.1 Scaffold Solution
Create a new .NET solution with two projects:
Accountant (Blazor WebAssembly or Server + API backend)
Customer (Blazor WebAssembly or Server + API backend)
1.2 UI/API Separation
Ensure each app has a Blazor UI frontend and a separate API backend (either as a single Blazor Server project or as Blazor WASM + ASP.NET Core API).
2. Add OpenTelemetry Middleware
2.1 Integrate OpenTelemetry
Add OpenTelemetry tracing to both frontend and backend for each application.
2.2 Jaeger Exporter
Configure OpenTelemetry to export traces to Jaeger.
3. Leverage DevContainers
3.1 DevContainer Setup
Create a .devcontainer configuration that:
Installs all required .NET SDKs and tools.
Runs Jaeger as a service/container.
Sets up environment variables for both apps to send traces to Jaeger.
4. Testing Setup
4.1 Unit Tests
Add unit test projects for both Accountant and Customer apps.
4.2 Integration Tests
Add integration test projects for both apps.
4.3 Local & CI Testability
Ensure all tests can be run both locally and in CI.
5. GitHub Actions CI
5.1 Build & Test Workflow
Create a GitHub Actions workflow that:
Builds both applications.
Runs all unit and integration tests.
Reports status (deployment will be handled later).
6. Local Development Experience
6.1 Documentation & Scripts
Provide clear documentation and scripts to:
Start both apps and Jaeger locally (preferably via docker-compose or devcontainer).
Run all tests locally.
Summary Table
Task ID	Description
1.1	Scaffold Accountant and Customer Blazor+API projects
1.2	Ensure Blazor UI and API separation
2.1	Integrate OpenTelemetry tracing
2.2	Configure Jaeger exporter
3.1	Create devcontainer with Jaeger and .NET SDKs
4.1	Add unit test projects
4.2	Add integration test projects
4.3	Ensure local and CI testability
5.1	Create GitHub Actions for build and test
6.1	Document and script local run/test experience
You can now create individual GitHub issues or tasks for each item above. Let me know if you want this as a markdown checklist or in another format!