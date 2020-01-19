using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Scripting.APIUpdating
{

public class MovedFromAttribute : Attribute
{
    public bool IsInDifferentAssembly { get; }

    public MovedFromAttribute(string sourceNamespace);
    public MovedFromAttribute(bool autoUpdateAPI, string sourceNamespace = null, string sourceAssembly = null, string sourceClassName = null);

}

}
