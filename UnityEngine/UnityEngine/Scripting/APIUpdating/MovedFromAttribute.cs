using System;
using UnityEngine;

namespace UnityEngine.Scripting.APIUpdating
{

public class MovedFromAttribute : Attribute
{
    public bool IsInDifferentAssembly { get; }

    public MovedFromAttribute(bool autoUpdateAPI, string sourceNamespace = null, string sourceAssembly = null, string sourceClassName = null);
    public MovedFromAttribute(string sourceNamespace);

}

}
