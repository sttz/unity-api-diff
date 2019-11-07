using System;
using UnityEngine;

namespace UnityEditor
{

public class PlatformIcon
{
    public int height { get; private set; }
    public UnityEditor.PlatformIconKind kind { get; private set; }
    public int layerCount { get; set; }
    public int maxLayerCount { get; private set; }
    public int minLayerCount { get; private set; }
    public int width { get; private set; }

    public Texture2D GetTexture(int layer = 0);
    public Texture2D[] GetTextures();
    public void SetTexture(Texture2D texture, int layer = 0);
    public void SetTextures(Texture2D[] textures);
    public string ToString();

}

}
