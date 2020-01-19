using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Scripting.APIUpdating
{

public class MovedFromAttribute : Attribute
{
    public bool IsInDifferentAssembly { get; private set; }
    public string Namespace { get; private set; }

    public MovedFromAttribute(string sourceNamespace);
    public MovedFromAttribute(string sourceNamespace, bool isInDifferentAssembly);

}

}
