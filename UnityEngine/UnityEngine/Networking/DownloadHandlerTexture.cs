using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Networking
{

public sealed class DownloadHandlerTexture : Networking.DownloadHandler
{
    static public Texture2D GetContent(Networking.UnityWebRequest www);

    public Texture2D texture { get; }

    public DownloadHandlerTexture();
    public DownloadHandlerTexture(bool readable);

    protected byte[] GetData();

}

}
