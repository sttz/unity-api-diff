using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class Security
{
    static public System.Reflection.Assembly LoadAndVerifyAssembly(byte[] assemblyData, string authorizationKey);
    static public System.Reflection.Assembly LoadAndVerifyAssembly(byte[] assemblyData);
    static public bool PrefetchSocketPolicy(string ip, int atPort);
    static public bool PrefetchSocketPolicy(string ip, int atPort, int timeout);

    public Security();

}

}
