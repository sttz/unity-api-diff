using System;
using UnityEngine;

namespace UnityEngine
{

public class UnityAPICompatibilityVersionAttribute : Attribute
{
    public string version { get; }

    public UnityAPICompatibilityVersionAttribute(string version);
    public UnityAPICompatibilityVersionAttribute(string version, bool checkOnlyUnityVersion);
    public UnityAPICompatibilityVersionAttribute(string version, string[] configurationAssembliesHashes);

}

}
