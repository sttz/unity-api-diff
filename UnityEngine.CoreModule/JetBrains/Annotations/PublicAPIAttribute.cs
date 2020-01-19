using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetBrains.Annotations
{

public sealed class PublicAPIAttribute : Attribute
{
    public string Comment { get; private set; }

    public PublicAPIAttribute();
    public PublicAPIAttribute(string comment);

}

}
