using System;
using UnityEngine;

namespace JetBrains.Annotations
{

public class PathReferenceAttribute : Attribute
{
    public string BasePath { get; private set; }

    public PathReferenceAttribute();
    public PathReferenceAttribute(string basePath);

}

}
