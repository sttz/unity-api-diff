using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class ProceduralTexture : Texture
{
    public TextureFormat format { get; }
    public bool hasAlpha { get; }

    public Color32[] GetPixels32(int x, int y, int blockWidth, int blockHeight);
    public ProceduralOutputType GetProceduralOutputType();

}

}
