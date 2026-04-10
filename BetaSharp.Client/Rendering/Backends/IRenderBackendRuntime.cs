using BetaSharp.Client.Diagnostics.GuiBackends;
using BetaSharp.Client.Diagnostics;
using BetaSharp.Client.Options;
using BetaSharp.Client.Rendering;
using BetaSharp.Client.Rendering.Core.Textures;
using BetaSharp.Client.Rendering.Presentation;
using BetaSharp.Client.Resource.Pack;
using BetaSharp.Worlds.Core;
using Microsoft.Extensions.Logging;

namespace BetaSharp.Client.Rendering.Backends;

internal interface IRenderBackendRuntime
{
    RendererBackendKind Kind { get; }
    RendererBackendCapabilities Capabilities { get; }

    void InitializeGraphicsContext(DebugTelemetry telemetry);
    void ConfigureDefaultRenderState(GameOptions options, ILogger logger);
    void ConfigurePresentationMode(GameOptions options);
    void SetVSyncEnabled(bool enabled);
    void SetMainViewport(int width, int height);
    void PrepareFrameRenderState();
    void UpdateDynamicTextures(TextureManager textureManager, bool isGamePaused);
    void CheckBackendErrors(string location, ILogger logger);
    void UpdateWindow(bool processMessages);
    bool TryCaptureScreenshot(int framebufferWidth, int framebufferHeight, out byte[] rgbPixels);
    void RenderStartupScreen(
        GameOptions options,
        int displayWidth,
        int displayHeight,
        int framebufferWidth,
        int framebufferHeight,
        TextureHandle logoTexture);
    void CleanupRenderResources();
    void LogRenderResourceReport();
    /// <summary>
    /// Temporary migration bridge for legacy GL-bound asset service creation.
    /// Remove once texture/text/skin services are backend-neutral.
    /// </summary>
    TextureManager CreateLegacyTextureManager(BetaSharp client, TexturePacks texturePacks, GameOptions options);
    TextRenderer CreateLegacyTextRenderer(GameOptions options, TextureManager textureManager);
    SkinManager CreateLegacySkinManager(TextureManager textureManager);
    /// <summary>
    /// Temporary migration bridge for legacy entity dispatcher wiring.
    /// Remove once entity rendering is backend-neutral.
    /// </summary>
    void ConfigureLegacyEntityRenderDispatcher(BetaSharp client, SkinManager skinManager);
    /// <summary>
    /// Temporary migration bridge for GL-style dynamic texture registration.
    /// Remove once texture uploads are routed through backend-neutral update queues.
    /// </summary>
    void RegisterLegacyDynamicTextures(BetaSharp client, TextureManager textureManager);
    ILoadingScreenRenderer CreateLoadingScreenRenderer(BetaSharp client);
    ISceneRenderer CreateSceneRenderer(BetaSharp client);
    IWorldRenderer CreateWorldRenderer(BetaSharp client, TextureManager textureManager);
    IParticleManager CreateParticleManager(World? world, TextureManager textureManager);

    IRenderPresentation CreatePresentation(int width, int height, GameOptions options);
    IImGuiRendererBackend CreateImGuiRendererBackend();
}
