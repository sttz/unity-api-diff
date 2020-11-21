using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Networking
{

public sealed class DownloadHandlerBuffer : Networking.DownloadHandler
{
    static public string GetContent(Networking.UnityWebRequest www);

    public DownloadHandlerBuffer();

    public void Dispose();
    protected Unity.Collections.NativeArray<byte> GetNativeData();

}

}
