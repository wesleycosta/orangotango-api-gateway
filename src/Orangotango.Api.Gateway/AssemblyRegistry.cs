using System.Reflection;

namespace Orangotango.Api.Gateway;

public static class AssemblyRegistry
{
    public static IEnumerable<Assembly> GetAssemblies()
    {
        yield return typeof(Program).Assembly;
    }
}
