using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Networking
{

public class UploadHandler : IDisposable
{
    public string contentType { get; set; }
    public byte[] data { get; }
    public float progress { get; }

    public void Dispose();

}

}
