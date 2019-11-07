using System;
using UnityEngine;

namespace UnityEngine.Networking
{

public class DownloadHandler : IDisposable
{
    static protected T GetCheckedDownloader(Networking.UnityWebRequest www);

    public byte[] data { get; }
    public string error { get; }
    public bool isDone { get; }
    public string text { get; }

    protected void CompleteContent();
    public void Dispose();
    protected byte[] GetData();
    protected float GetProgress();
    protected string GetText();
    protected void ReceiveContentLength(int contentLength);
    protected void ReceiveContentLengthHeader(ulong contentLength);
    protected bool ReceiveData(byte[] data, int dataLength);

}

}
