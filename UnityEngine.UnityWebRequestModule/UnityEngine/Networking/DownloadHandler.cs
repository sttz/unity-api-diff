using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Networking
{

public class DownloadHandler : IDisposable
{
    static protected T GetCheckedDownloader<T>(Networking.UnityWebRequest www);

    public byte[] data { get; }
    public bool isDone { get; }
    public string text { get; }

    protected void CompleteContent();
    public void Dispose();
    protected byte[] GetData();
    protected float GetProgress();
    protected string GetText();
    protected void ReceiveContentLength(int contentLength);
    protected bool ReceiveData(byte[] data, int dataLength);

}

}
