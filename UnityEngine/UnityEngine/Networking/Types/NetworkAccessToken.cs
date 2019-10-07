using System;
using UnityEngine;

namespace UnityEngine.Networking.Types
{

public class NetworkAccessToken
{
    public byte[] array;

    public NetworkAccessToken();
    public NetworkAccessToken(byte[] array);
    public NetworkAccessToken(string strArray);

    public string GetByteString();
    public bool IsValid();

}

}
