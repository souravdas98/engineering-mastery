
using System.Reflection;
using NetArchTest.Rules;

namespace EngineeringMastery.ArchitectureTests;

public class DependencyRulesTests
{
    [Fact]
    public void Domain_ShouldNotDependOnApplication()
    {
        TestResult result = Types
            .InAssembly(Assembly.Load("EngineeringMastery.Domain"))
            .ShouldNot()
            .HaveDependencyOn("EngineeringMastery.Application")
            .GetResult();

        Assert.True(result.IsSuccessful);
    }

    [Fact]
    public void Domain_ShouldNotDependOnInfrastructure()
    {
        TestResult result = Types
            .InAssembly(Assembly.Load("EngineeringMastery.Domain"))
            .ShouldNot()
            .HaveDependencyOn("EngineeringMastery.Infrastructure")
            .GetResult();

        Assert.True(result.IsSuccessful);
    }

    [Fact]
    public void Application_ShouldNotDependOnInfrastructure()
    {
        TestResult result = Types
            .InAssembly(Assembly.Load("EngineeringMastery.Application"))
            .ShouldNot()
            .HaveDependencyOn("EngineeringMastery.Infrastructure")
            .GetResult();

        Assert.True(result.IsSuccessful);
    }

    [Fact]
    public void Application_ShouldNotDependOnApi()
    {
        TestResult result = Types
            .InAssembly(Assembly.Load("EngineeringMastery.Application"))
            .ShouldNot()
            .HaveDependencyOn("EngineeringMastery.Api")
            .GetResult();

        Assert.True(result.IsSuccessful);
    }

    [Fact]
    public void Infrastructure_ShouldNotDependOnApi()
    {
        TestResult result = Types
            .InAssembly(Assembly.Load("EngineeringMastery.Infrastructure"))
            .ShouldNot()
            .HaveDependencyOn("EngineeringMastery.Api")
            .GetResult();

        Assert.True(result.IsSuccessful);
    }
}
