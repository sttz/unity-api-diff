using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetBrains.Annotations
{

public sealed class BaseTypeRequiredAttribute : Attribute
{
    public Type BaseType { get; private set; }

    public BaseTypeRequiredAttribute(Type baseType);

}

}
