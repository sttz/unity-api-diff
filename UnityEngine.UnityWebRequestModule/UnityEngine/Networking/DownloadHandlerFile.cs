using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Networking
{

public sealed class DownloadHandlerFile : Networking.DownloadHandler
{
    public bool removeFileOnAbort { get; set; }

    public DownloadHandlerFile(string path);
    public DownloadHandlerFile(string path, bool append);

    protected byte[] GetData();
    protected Unity.Collections.NativeArray<byte> GetNativeData();
    protected string GetText();

}

}
