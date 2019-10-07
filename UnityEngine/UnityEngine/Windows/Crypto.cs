using System;
using UnityEngine;

namespace UnityEngine.Windows
{

public static class Crypto
{
    static public byte[] ComputeMD5Hash(byte[] buffer);
    static public byte[] ComputeSHA1Hash(byte[] buffer);

}

}
