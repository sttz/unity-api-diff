using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR
{

public class ARBackgroundRenderer
{
    protected Material m_BackgroundMaterial;
    protected Texture m_BackgroundTexture;
    protected Camera m_Camera;

    public Material backgroundMaterial { get; set; }
    public Texture backgroundTexture { get; set; }
    public Camera camera { get; set; }
    public XR.ARRenderMode mode { get; set; }

    public event Action backgroundRendererChanged;

    public ARBackgroundRenderer();

    protected void DisableARBackgroundRendering();
    protected bool EnableARBackgroundRendering();

}

}
