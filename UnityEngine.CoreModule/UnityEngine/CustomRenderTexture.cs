using System;
using System.Collections;
using System.Collections.Generic;
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
    public float updatePeriod { get; set; }
    public CustomRenderTextureUpdateZoneSpace updateZoneSpace { get; set; }
    public bool wrapUpdateZones { get; set; }

    public CustomRenderTexture(int width, int height);
    public CustomRenderTexture(int width, int height, Experimental.Rendering.DefaultFormat defaultFormat);
    public CustomRenderTexture(int width, int height, Experimental.Rendering.GraphicsFormat format);
    public CustomRenderTexture(int width, int height, RenderTextureFormat format);
    public CustomRenderTexture(int width, int height, RenderTextureFormat format, RenderTextureReadWrite readWrite);

    public void ClearUpdateZones();
    public void EnsureDoubleBufferConsistency();
    public RenderTexture GetDoubleBufferRenderTexture();
    public void GetUpdateZones(List<CustomRenderTextureUpdateZone> updateZones);
    public void Initialize();
    public void SetUpdateZones(CustomRenderTextureUpdateZone[] updateZones);
    public void Update();
    public void Update(int count);

}

}
