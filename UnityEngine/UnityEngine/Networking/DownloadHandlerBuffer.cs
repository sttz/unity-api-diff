using System;
using UnityEngine;

namespace UnityEngine.Networking
{

public sealed class DownloadHandlerBuffer : Networking.DownloadHandler
{
    static public string GetContent(Networking.UnityWebRequest www);

    public DownloadHandlerBuffer();

    protected byte[] GetData();

}

}
