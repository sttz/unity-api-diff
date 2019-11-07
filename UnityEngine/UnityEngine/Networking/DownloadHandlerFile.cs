using System;
using UnityEngine;

namespace UnityEngine.Networking
{

public sealed class DownloadHandlerFile : Networking.DownloadHandler
{
    public bool removeFileOnAbort { get; set; }

    public DownloadHandlerFile(string path);
    public DownloadHandlerFile(string path, bool append);

    protected byte[] GetData();
    protected string GetText();

}

}