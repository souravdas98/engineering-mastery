# Contributing to Engineering Mastery

Thank you for your interest in contributing to Engineering Mastery!

Engineering Mastery is an open-source project focused on software engineering, practical learning, architecture, design patterns, system design, and modern development practices.

We welcome contributions that improve the codebase, documentation, learning resources, examples, and overall developer experience.

Our goal is to maintain a high-quality, practical, and reliable learning platform.

## Table of Contents

- [Contributing to Engineering Mastery](#contributing-to-engineering-mastery)
  - [Table of Contents](#table-of-contents)
  - [Ways to Contribute](#ways-to-contribute)
  - [Before You Start](#before-you-start)
  - [Development Setup](#development-setup)
    - [Prerequisites](#prerequisites)
    - [Clone the Repository](#clone-the-repository)
    - [Backend](#backend)
    - [Frontend](#frontend)
  - [Branching Strategy](#branching-strategy)
  - [Commit Message Convention](#commit-message-convention)
  - [Pull Request Guidelines](#pull-request-guidelines)
    - [Pull Request Description](#pull-request-description)
  - [Code Quality Standards](#code-quality-standards)
    - [Backend](#backend-1)
    - [Frontend](#frontend-1)
  - [Documentation Guidelines](#documentation-guidelines)
  - [Testing Requirements](#testing-requirements)
  - [Reporting Issues](#reporting-issues)
  - [Code of Conduct](#code-of-conduct)
  - [Final Note](#final-note)

## Ways to Contribute

There are several ways to contribute:

- Report bugs and unexpected behavior.
- Suggest new features and improvements.
- Improve existing documentation.
- Add practical code examples.
- Implement design patterns and architectural examples.
- Add coding exercises and assessments.
- Improve automated tests.
- Identify performance and security issues.

Contributions of all sizes are appreciated.

## Before You Start

Before submitting a contribution:

1. Check existing issues and pull requests.
2. Search for existing discussions about the proposed change.
3. Create an issue for significant features or architectural changes.
4. Keep changes focused on a single objective.

For small documentation fixes and straightforward bug fixes, an issue may not be necessary.

## Development Setup

### Prerequisites

- .NET 10 SDK
- Node.js 22
- npm
- Git
- PostgreSQL (for backend features requiring a database)

### Clone the Repository

```bash
git clone https://github.com/souravdas98/engineering-mastery.git

cd engineering-mastery
```

### Backend

```bash
dotnet restore EngineeringMastery.slnx

dotnet build EngineeringMastery.slnx

dotnet test EngineeringMastery.slnx
```

### Frontend

```bash
cd src/Frontend/engineering-mastery-web

npm ci

npm run lint

npm run build
```

## Branching Strategy

The `main` branch is protected. Contributions should be submitted through pull requests.

Use the following branch naming conventions:

| Branch | Purpose |
|---|---|
| `feature/*` | New features |
| `fix/*` | Bug fixes |
| `refactor/*` | Code restructuring |
| `docs/*` | Documentation changes |
| `test/*` | Test improvements |
| `chore/*` | Maintenance tasks |

Examples:

```text
feature/design-patterns-module
fix/authentication-validation
refactor/application-services
docs/update-architecture-guide
test/add-dependency-rules
chore/update-dependencies
```

## Commit Message Convention

We follow Conventional Commits.

Format:

```text
<type>: <description>
```

Common types:

| Type | Description |
|---|---|
| `feat` | Introduces a new feature |
| `fix` | Fixes a bug |
| `docs` | Documentation changes |
| `style` | Formatting or code style changes |
| `refactor` | Code restructuring |
| `test` | Adds or modifies tests |
| `perf` | Performance improvements |
| `build` | Build system or dependency changes |
| `ci` | CI/CD configuration changes |
| `chore` | Maintenance tasks |

Examples:

```bash
feat: add design pattern learning module

fix: resolve dependency injection issue

docs: improve system design documentation

test: add architecture dependency tests

ci: improve GitHub Actions validation

chore: update NuGet dependencies
```

Use clear, concise descriptions and avoid vague messages such as `updated code` or `fixed stuff`.

## Pull Request Guidelines

All changes should be submitted through a pull request.

Before opening a pull request:

1. Create a dedicated branch.
2. Keep the changes focused and reasonably small.
3. Follow the existing project structure and conventions.
4. Add or update tests where appropriate.
5. Update documentation when necessary.
6. Run the relevant quality checks locally.
7. Ensure the pull request description explains the change.

### Pull Request Description

Include the following information:

- **Summary:** What changed?
- **Motivation:** Why is this change needed?
- **Implementation:** How was it implemented?
- **Testing:** What validation was performed?
- **Related Issues:** Reference relevant issues, if applicable.

For UI changes, include screenshots when they help reviewers understand the change.

## Code Quality Standards

We aim to maintain consistent engineering standards across the repository.

### Backend

- Follow SOLID principles where appropriate.
- Maintain clear separation of concerns.
- Follow Clean Architecture dependency rules.
- Prefer meaningful names over abbreviations.
- Keep methods and classes focused.
- Avoid unnecessary abstractions.
- Handle errors explicitly.
- Use asynchronous APIs appropriately.
- Avoid hardcoded secrets and environment-specific configuration.
- Add tests for business-critical behavior.

### Frontend

- Use TypeScript with strict type checking.
- Prefer reusable and focused components.
- Keep business logic separate from presentation.
- Avoid unnecessary global state.
- Handle loading, error, and empty states.
- Follow accessibility best practices.
- Avoid introducing unnecessary dependencies.

## Documentation Guidelines

Documentation is an important part of this project.

When adding or modifying documentation:

- Use clear and technically accurate explanations.
- Include practical examples where useful.
- Explain the reasoning behind architectural decisions.
- Keep headings structured and consistent.
- Use fenced code blocks with appropriate language identifiers.
- Ensure links are valid.
- Avoid outdated instructions.

Markdown files must pass the repository's Markdown validation workflow.

## Testing Requirements

Contributors should add appropriate tests for their changes.

Depending on the change, this may include:

- Unit tests
- Integration tests
- Architecture tests
- Frontend tests
- Regression tests

Before submitting a pull request, run:

```bash
dotnet restore EngineeringMastery.slnx

dotnet format EngineeringMastery.slnx --verify-no-changes --no-restore

dotnet build EngineeringMastery.slnx --configuration Release

dotnet test EngineeringMastery.slnx --configuration Release
```

For frontend changes:

```bash
cd src/Frontend/engineering-mastery-web

npm ci

npm run lint

npm run build
```

All required CI checks must pass before merging.

## Reporting Issues

When reporting a bug, include:

- A clear and descriptive title.
- Steps to reproduce the issue.
- Expected behavior.
- Actual behavior.
- Relevant error messages or logs.
- Environment details, where applicable.

For feature requests, explain the problem the feature solves and its expected value.

## Code of Conduct

We expect all contributors to maintain a respectful and welcoming environment.

- Be respectful and constructive.
- Welcome different perspectives.
- Provide actionable feedback.
- Avoid personal attacks or discriminatory behavior.
- Focus discussions on technical merit and project goals.

## Final Note

Engineering Mastery is built around continuous learning and practical engineering.

Every contribution should aim to make the project more useful, understandable, maintainable, and reliable.

**Thank you for helping make Engineering Mastery better!**