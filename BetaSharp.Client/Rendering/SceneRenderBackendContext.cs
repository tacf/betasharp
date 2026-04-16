using BetaSharp.Client.Rendering.Legacy;

namespace BetaSharp.Client.Rendering;

/// <summary>
/// Holds the active <see cref="ILegacyFixedFunctionApi"/> for model code that is not passed a backend explicitly.
/// </summary>
public static class SceneRenderBackendContext
{
    [ThreadStatic]
    private static ILegacyFixedFunctionApi? s_current;

    public static ILegacyFixedFunctionApi Current =>
        s_current ?? throw new InvalidOperationException("No scene render backend is active; expected EntityRenderDispatcher.RenderEntity to set the context.");

    internal static void Set(ILegacyFixedFunctionApi backend) => s_current = backend;

    internal static void Clear() => s_current = null;
}
