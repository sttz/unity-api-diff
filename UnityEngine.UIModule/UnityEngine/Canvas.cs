using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class Canvas : Behaviour
{
    static public event WillRenderCanvases willRenderCanvases;

    static public void ForceUpdateCanvases();
    static public Material GetDefaultCanvasMaterial();
    static public Material GetDefaultCanvasTextMaterial();
    static public Material GetETC1SupportedCanvasMaterial();

    public AdditionalCanvasShaderChannels additionalShaderChannels { get; set; }
    public int cachedSortingLayerValue { get; }
    public bool isRootCanvas { get; }
    public float normalizedSortingGridSize { get; set; }
    public bool overridePixelPerfect { get; set; }
    public bool overrideSorting { get; set; }
    public bool pixelPerfect { get; set; }
    public Rect pixelRect { get; }
    public float planeDistance { get; set; }
    public float referencePixelsPerUnit { get; set; }
    public RenderMode renderMode { get; set; }
    public int renderOrder { get; }
    public Canvas rootCanvas { get; }
    public float scaleFactor { get; set; }
    public int sortingGridNormalizedSize { get; set; }
    public int sortingLayerID { get; set; }
    public string sortingLayerName { get; set; }
    public int sortingOrder { get; set; }
    public int targetDisplay { get; set; }
    public Camera worldCamera { get; set; }

    public Canvas();

    public delegate void WillRenderCanvases();

}

}
