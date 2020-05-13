using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetBrains.Annotations
{

public sealed class PathReferenceAttribute : Attribute
{
    public string BasePath { get; }

    public PathReferenceAttribute();
    public PathReferenceAttribute(string basePath);

}

}
