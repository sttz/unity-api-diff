using System;
using UnityEngine;

namespace UnityEngine
{

public class UnityAPICompatibilityVersionAttribute : Attribute
{
    public string version { get; }

    public UnityAPICompatibilityVersionAttribute(string version);

}

}
