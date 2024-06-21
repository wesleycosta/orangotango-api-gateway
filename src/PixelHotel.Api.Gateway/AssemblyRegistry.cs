using System.Reflection;

namespace PixelHotel.Api.Gateway;

public static class AssemblyRegistry 
{
    public static IEnumerable<Assembly> GetAssemblies()
    {
        yield return typeof(Program).Assembly;
    }
}
