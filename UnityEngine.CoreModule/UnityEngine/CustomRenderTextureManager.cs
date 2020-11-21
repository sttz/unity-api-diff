using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public static class CustomRenderTextureManager
{
    static public event Action<CustomRenderTexture> initializeTriggered;
    static public event Action<CustomRenderTexture> textureLoaded;
    static public event Action<CustomRenderTexture> textureUnloaded;
    static public event Action<CustomRenderTexture, int> updateTriggered;

    static public void GetAllCustomRenderTextures(List<CustomRenderTexture> currentCustomRenderTextures);

}

}
