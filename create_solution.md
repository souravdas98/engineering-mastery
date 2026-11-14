# Step 1.1 — Create the backend solution

Run these commands one by one:

```csharp
# Create solution
dotnet new sln -n EngineeringMastery --format sln

# Create directories
mkdir -p src/Backend
mkdir -p src/Frontend
mkdir -p src/Examples
mkdir -p tests
mkdir -p docs
mkdir -p exercises
mkdir -p infrastructure/docker

```

## Step 1.2 — Create backend projects

```csharp

# API
dotnet new webapi --use-controllers \
  -n EngineeringMastery.Api \
  -o src/Backend/EngineeringMastery.Api

# Domain
dotnet new classlib \
  -n EngineeringMastery.Domain \
  -o src/Backend/EngineeringMastery.Domain

# Application
dotnet new classlib \
  -n EngineeringMastery.Application \
  -o src/Backend/EngineeringMastery.Application

# Infrastructure
dotnet new classlib \
  -n EngineeringMastery.Infrastructure \
  -o src/Backend/EngineeringMastery.Infrastructure

# Learning examples
dotnet new classlib \
  -n EngineeringMastery.Examples \
  -o src/Examples/EngineeringMastery.Examples

```

## Step 1.3 — Create test projects

```csharp

dotnet new xunit \
  -n EngineeringMastery.UnitTests \
  -o tests/EngineeringMastery.UnitTests

dotnet new xunit \
  -n EngineeringMastery.IntegrationTests \
  -o tests/EngineeringMastery.IntegrationTests

```

## Step 1.4 — Add projects to the solution

```csharp
dotnet sln add src/Backend/EngineeringMastery.Api

dotnet sln add src/Backend/EngineeringMastery.Domain

dotnet sln add src/Backend/EngineeringMastery.Application

dotnet sln add src/Backend/EngineeringMastery.Infrastructure

dotnet sln add src/Examples/EngineeringMastery.Examples

dotnet sln add tests/EngineeringMastery.UnitTests

dotnet sln add tests/EngineeringMastery.IntegrationTests

```

## Step 1.5 — Configure project references

This is important because it establishes our architecture.

```csharp
# Application -> Domain
dotnet add src/Backend/EngineeringMastery.Application reference \
  src/Backend/EngineeringMastery.Domain

# Infrastructure -> Application + Domain
dotnet add src/Backend/EngineeringMastery.Infrastructure reference \
  src/Backend/EngineeringMastery.Application \
  src/Backend/EngineeringMastery.Domain

# API -> Application + Infrastructure
dotnet add src/Backend/EngineeringMastery.Api reference \
  src/Backend/EngineeringMastery.Application \
  src/Backend/EngineeringMastery.Infrastructure

# Unit tests
dotnet add tests/EngineeringMastery.UnitTests reference \
  src/Backend/EngineeringMastery.Domain \
  src/Backend/EngineeringMastery.Application

# Integration tests -> API
dotnet add tests/EngineeringMastery.IntegrationTests reference \
  src/Backend/EngineeringMastery.Api

```

## Step 1.6 — Create frontend

```csharp

cd src/Frontend

npm create vite@latest engineering-mastery-web -- --template react-ts

cd engineering-mastery-web

npm install

cd ../../..

```

## Step 1.7 — Create root Git configuration

```sql
dotnet new gitignore
```

## Step 1.8 — Verify the solution

```csharp
dotnet sln EngineeringMastery.sln list

dotnet restore

dotnet build

dotnet test

```
