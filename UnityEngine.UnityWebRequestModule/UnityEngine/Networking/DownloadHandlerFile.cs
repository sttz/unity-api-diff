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

    protected byte[] GetData();
    protected string GetText();

}

}