# Engineering Mastery

**Master software engineering. Build better systems. Think like an engineer.**

Engineering Mastery is an open-source learning platform designed to help developers strengthen their software engineering fundamentals, understand architectural principles, explore design patterns, practice system design, and prepare for real-world engineering challenges.

The goal is to go beyond memorizing concepts and focus on understanding **why things work, how they work, and when to use them**.

---

## Table of Contents

- [Vision](#vision)
- [What You'll Learn](#what-youll-learn)
- [Key Features](#key-features)
- [Technology Stack](#technology-stack)
- [Architecture](#architecture)
- [Repository Structure](#repository-structure)
- [Getting Started](#getting-started)
- [Development Guidelines](#development-guidelines)
- [Engineering Standards](#engineering-standards)
- [CI/CD and Quality Gates](#cicd-and-quality-gates)
- [Roadmap](#roadmap)
- [Contributing](#contributing)
- [License](#license)

---

## Vision

Software engineering is much more than writing code.

It involves understanding trade-offs, designing maintainable systems, making architectural decisions, solving complex problems, and building software that can evolve over time.

Engineering Mastery aims to bring these concepts together in one structured learning environment.

The platform focuses on:

- Understanding fundamental computer science and software engineering concepts.
- Learning design patterns through practical implementations.
- Applying SOLID principles and clean architecture.
- Designing scalable and maintainable applications.
- Understanding databases, APIs, distributed systems, and performance.
- Practicing technical interview questions and coding exercises.
- Building confidence through hands-on implementation.

## What You'll Learn

### 1. Programming Fundamentals

- Object-oriented programming
- SOLID principles
- Data structures and algorithms
- Exception handling
- Memory management
- Asynchronous programming
- Multithreading and concurrency
- Generics and collections

### 2. Design Patterns

Explore design patterns with practical examples, implementation details, and real-world use cases.

**Creational Patterns**
- Singleton
- Factory Method
- Abstract Factory
- Builder
- Prototype

**Structural Patterns**
- Adapter
- Decorator
- Facade
- Composite
- Proxy
- Bridge

**Behavioral Patterns**
- Strategy
- Observer
- Command
- State
- Template Method
- Mediator
- Chain of Responsibility

### 3. Software Architecture

- Clean Architecture
- Layered Architecture
- Modular Monolith
- Microservices Architecture
- Domain-Driven Design
- CQRS
- Event-Driven Architecture
- Dependency Injection
- Repository Pattern
- Unit of Work

### 4. System Design

- Scalability and availability
- Load balancing
- Caching strategies
- Database sharding
- Replication
- Message queues
- Distributed transactions
- Rate limiting
- API Gateway
- Eventual consistency
- CAP theorem
- High-level and low-level design

### 5. Backend Engineering

- C# and .NET
- ASP.NET Core
- REST API design
- Authentication and authorization
- Entity Framework Core
- SQL and PostgreSQL
- Redis and caching
- Background processing
- Logging and observability
- Performance optimization

### 6. Frontend Engineering

- JavaScript and TypeScript
- React
- Component architecture
- State management
- API integration
- Frontend performance
- Accessibility
- Testing strategies

### 7. Databases and Data Engineering

- Relational database concepts
- Database normalization
- Indexing and query optimization
- Transactions and isolation levels
- SQL performance
- NoSQL fundamentals
- Data modeling

### 8. Cloud, DevOps and Security

- Docker and containerization
- CI/CD pipelines
- GitHub Actions
- Cloud fundamentals
- Application security
- OWASP Top 10
- Secure authentication
- Secrets management
- Monitoring and observability

### 9. AI and Modern Engineering

- Large Language Models
- OpenAI APIs
- Retrieval-Augmented Generation (RAG)
- Vector databases
- AI integration patterns
- AI-assisted development
- Building AI-powered applications

---

## Key Features

The platform is being developed with the following capabilities:

| Feature | Description |
|---|---|
| Structured Learning | Organized topics and learning paths |
| Practical Examples | Real implementations instead of theory alone |
| Code Exercises | Hands-on programming challenges |
| Design Pattern Library | Patterns with explanations and examples |
| System Design | Architecture problems and solutions |
| Assessments | Knowledge evaluation and practice |
| Progress Tracking | Track learning activities and progress |
| Interview Preparation | Technical questions and interview practice |
| Personal Notes | Maintain individual learning notes |

*Features will be introduced incrementally as development progresses.*

---

## Technology Stack

### Backend

- C#
- .NET 10
- ASP.NET Core Web API
- Entity Framework Core
- PostgreSQL

### Frontend

- React
- TypeScript
- Vite
- Tailwind CSS
- TanStack Query

### Testing

- xUnit
- Integration Testing
- Architecture Testing
- Frontend Testing

### Development and Infrastructure

- Git
- GitHub Actions
- Docker
- CodeQL
- Dependabot

---

## Architecture

Engineering Mastery follows a **Modular Monolith with Clean Architecture principles**.

The architecture separates business rules, application workflows, infrastructure concerns, and API delivery.

```text
                 ┌──────────────────────┐
                 │       Frontend       │
                 │   React + TypeScript │
                 └──────────┬───────────┘
                            │
                            ▼
                 ┌──────────────────────┐
                 │      API Layer       │
                 │    ASP.NET Core      │
                 └──────────┬───────────┘
                            │
                            ▼
                 ┌──────────────────────┐
                 │   Application Layer  │
                 │ Use Cases / Services │
                 └──────────┬───────────┘
                            │
                            ▼
                 ┌──────────────────────┐
                 │     Domain Layer     │
                 │ Business Rules       │
                 └──────────────────────┘
                            ▲
                            │
                 ┌──────────────────────┐
                 │ Infrastructure Layer │
                 │ EF Core / PostgreSQL │
                 └──────────────────────┘
```

### Architectural Principles

- Separation of concerns
- Dependency inversion
- Explicit business boundaries
- Maintainable and testable components
- Modular feature organization
- Minimal coupling between modules

---

## Repository Structure

```text
engineering-mastery/
│
├── src/
│   ├── Backend/
│   │   ├── EngineeringMastery.Api/
│   │   ├── EngineeringMastery.Domain/
│   │   ├── EngineeringMastery.Application/
│   │   └── EngineeringMastery.Infrastructure/
│   │
│   ├── Frontend/
│   │   └── engineering-mastery-web/
│   │
│   └── Examples/
│       └── EngineeringMastery.Examples/
│
├── tests/
│   ├── EngineeringMastery.UnitTests/
│   ├── EngineeringMastery.IntegrationTests/
│   └── EngineeringMastery.ArchitectureTests/
│
├── docs/
├── exercises/
│
├── infrastructure/
│   └── docker/
│
├── .github/
│   └── workflows/
│
├── Directory.Build.props
├── Directory.Packages.props
├── .editorconfig
├── .gitignore
└── EngineeringMastery.slnx
```

---

## Getting Started

### Prerequisites

Install the following tools:

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- [Node.js 22](https://nodejs.org/)
- npm
- Git
- PostgreSQL

### Clone the Repository

```bash
git clone https://github.com/souravdas98/engineering-mastery.git

cd engineering-mastery
```

### Backend Setup

Restore dependencies:

```bash
dotnet restore EngineeringMastery.slnx
```

Build the solution:

```bash
dotnet build EngineeringMastery.slnx
```

Run tests:

```bash
dotnet test EngineeringMastery.slnx
```

Run the API:

```bash
dotnet run --project src/Backend/EngineeringMastery.Api
```

### Frontend Setup

Navigate to the frontend:

```bash
cd src/Frontend/engineering-mastery-web
```

Install dependencies:

```bash
npm ci
```

Run the development server:

```bash
npm run dev
```

Run linting:

```bash
npm run lint
```

Build the frontend:

```bash
npm run build
```

*Database configuration and environment variables must be configured before running backend features that require PostgreSQL.*

---

## Development Guidelines

This repository follows consistent development practices.

### Branching Strategy

- `main` — stable and protected branch.
- `feature/*` — new features.
- `fix/*` — bug fixes.
- `refactor/*` — code restructuring.
- `docs/*` — documentation changes.
- `chore/*` — maintenance tasks.

### Commit Convention

Commit messages follow Conventional Commits.

```text
feat: add design pattern learning module
fix: resolve authentication validation issue
refactor: simplify application services
docs: update architecture documentation
test: add dependency architecture tests
ci: improve GitHub Actions pipeline
chore: update project dependencies
```

### Pull Request Guidelines

1. Create a dedicated branch.
2. Keep changes focused and small.
3. Add or update relevant tests.
4. Ensure formatting and linting pass.
5. Update documentation when necessary.
6. Submit a pull request against `main`.
7. Merge only after required checks pass.

---

## Engineering Standards

Quality is a core part of this project.

The repository aims to enforce:

- Nullable reference types.
- Compiler warnings as errors.
- Central Package Management.
- Consistent formatting.
- Automated unit and integration tests.
- Architecture dependency validation.
- Secure dependency management.
- Code scanning.
- Documentation validation.
- Protected main branch.

### CI/CD and Quality Gates

GitHub Actions is used to automate validation.

| Workflow | Responsibility |
|---|---|
| CI | Backend and frontend build validation |
| Documentation | Markdown and link validation |
| CodeQL | Static security analysis |
| Security Audit | Dependency vulnerability checks |
| Release | Release build and artifact validation |

Changes should pass the required repository checks before being merged.

---

## Roadmap

Engineering Mastery is an evolving project.

### Foundation

- [x] Repository structure
- [x] .NET solution setup
- [x] Frontend project setup
- [x] Central Package Management
- [x] Initial CI/CD workflows
- [ ] Backend architecture foundation
- [ ] Frontend application foundation

### Learning Modules

- [ ] Programming fundamentals
- [ ] SOLID principles
- [ ] Design patterns
- [ ] Clean Architecture
- [ ] Database engineering
- [ ] System design
- [ ] Distributed systems
- [ ] Cloud and DevOps
- [ ] Application security
- [ ] AI engineering

### Platform Capabilities

- [ ] Authentication and authorization
- [ ] Learning paths
- [ ] Content management
- [ ] Coding exercises
- [ ] Assessments
- [ ] Progress tracking
- [ ] Interview preparation

---

## Contributing

Contributions, suggestions, bug reports, and improvements are welcome.

Whether you're improving documentation, adding practical examples, fixing bugs, or introducing new engineering concepts, your contributions can help make this resource more valuable to the developer community.

### How to Contribute

1. Fork the repository.
2. Create a feature branch.
3. Make your changes.
4. Add appropriate tests.
5. Ensure all quality checks pass.
6. Submit a pull request.

Please keep contributions practical, well-documented, and aligned with the project's engineering principles.

---

## License

This project is licensed under the [MIT License](LICENSE).

---

## Maintainer

Created and maintained by [Sourav Das](https://github.com/souravdas98).

If you find this project useful, consider giving it a ⭐ on GitHub.

**Learn continuously. Build deliberately. Engineer better.**
