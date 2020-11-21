using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Networking
{

public sealed class UploadHandlerRaw : Networking.UploadHandler
{
    public UploadHandlerRaw(byte[] data);
    public UploadHandlerRaw(ReadOnly<byte> data);
    public UploadHandlerRaw(Unity.Collections.NativeArray<byte> data, bool transferOwnership);

    public void Dispose();

}

}
