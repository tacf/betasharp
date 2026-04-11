namespace BetaSharp.Client.Rendering.Backends;

internal sealed class NoOpSceneRenderBackend : ISceneRenderBackend
{
    public void Enable(SceneRenderCapability capability)
    {
    }

    public void Disable(SceneRenderCapability capability)
    {
    }

    public void SetMatrixMode(SceneMatrixMode matrixMode)
    {
    }

    public void LoadIdentity()
    {
    }

    public void PushMatrix()
    {
    }

    public void PopMatrix()
    {
    }

    public void Translate(float x, float y, float z)
    {
    }

    public void Scale(float x, float y, float z)
    {
    }

    public void Rotate(float angle, float x, float y, float z)
    {
    }

    public void Perspective(float fieldOfView, float aspectRatio, float zNear, float zFar)
    {
    }

    public void Ortho(double left, double right, double bottom, double top, double zNear, double zFar)
    {
    }

    public void SetViewport(int x, int y, uint width, uint height)
    {
    }

    public void Clear(SceneClearBufferMask clearMask)
    {
    }

    public void ClearColor(float red, float green, float blue, float alpha)
    {
    }

    public void SetDepthMask(bool enabled)
    {
    }

    public void SetBlendFunction(SceneBlendFactor source, SceneBlendFactor destination)
    {
    }

    public void SetAlphaFunction(SceneAlphaFunction function, float threshold)
    {
    }

    public void SetShadeModel(SceneShadeModel shadeModel)
    {
    }

    public void SetNormal(float x, float y, float z)
    {
    }

    public void SetColor(float red, float green, float blue, float alpha)
    {
    }

    public void SetColorMaterial(SceneColorMaterialFace face, SceneColorMaterialParameter parameter)
    {
    }

    public void SetFogColor(float red, float green, float blue, float alpha)
    {
    }

    public void SetFogMode(SceneFogMode fogMode)
    {
    }

    public void SetFogDensity(float density)
    {
    }

    public void SetFogStart(float start)
    {
    }

    public void SetFogEnd(float end)
    {
    }
}
