using System;
using UnityEngine;

namespace JetBrains.Annotations
{

public sealed class BaseTypeRequiredAttribute : Attribute
{
    public Type BaseType { get; private set; }

    public BaseTypeRequiredAttribute(Type baseType);

}

}
