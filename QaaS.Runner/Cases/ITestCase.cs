using Microsoft.Extensions.Configuration;

namespace QaaS.Runner.Cases;

/// <summary>
/// Defines a contract for custom test cases that modify an execution builder using profile variables.
/// </summary>
public interface ITestCase
{
    /// <summary>
    /// Modifies the execution builder specifically for this test case using optional profile variables.
    /// </summary>
    /// <param name="baseBuilder">The cloned execution builder for this case.</param>
    /// <param name="variables">The optional profile variables configuration.</param>
    void ModifyCaseExecutionBuilder(ExecutionBuilder baseBuilder, IConfiguration? variables = null);
}
