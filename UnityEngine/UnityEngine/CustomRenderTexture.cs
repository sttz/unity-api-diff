using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class CustomRenderTexture : RenderTexture
{
    public uint cubemapFaceMask { get; set; }
    public bool doubleBuffered { get; set; }
    public Color initializationColor { get; set; }
    public Material initializationMaterial { get; set; }
    public CustomRenderTextureUpdateMode initializationMode { get; set; }
    public CustomRenderTextureInitializationSource initializationSource { get; set; }
    public Texture initializationTexture { get; set; }
    public Material material { get; set; }
    public int shaderPass { get; set; }
    public CustomRenderTextureUpdateMode updateMode { get; set; }
    public CustomRenderTextureUpdateZoneSpace updateZoneSpace { get; set; }
    public bool wrapUpdateZones { get; set; }

    public CustomRenderTexture(int width, int height, RenderTextureFormat format, RenderTextureReadWrite readWrite);
    public CustomRenderTexture(int width, int height, RenderTextureFormat format);
    public CustomRenderTexture(int width, int height);
    public CustomRenderTexture(int width, int height, Experimental.Rendering.DefaultFormat defaultFormat);
    public CustomRenderTexture(int width, int height, Experimental.Rendering.GraphicsFormat format);

    public void ClearUpdateZones();
    public void GetUpdateZones(System.Collections.Generic.List<CustomRenderTextureUpdateZone> updateZones);
    public void Initialize();
    public void SetUpdateZones(CustomRenderTextureUpdateZone[] updateZones);
    public void Update(int count);
    public void Update();

}

}
