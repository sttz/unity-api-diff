using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetBrains.Annotations
{

public sealed class ValueProviderAttribute : Attribute
{
    public string Name { get; }

    public ValueProviderAttribute(string name);

}

}
