using System;
using UnityEngine;

namespace UnityEngine.Diagnostics
{

public static class PlayerConnection
{
    static public bool connected { get; }

    static public void SendFile(string remoteFilePath, byte[] data);

}

}
