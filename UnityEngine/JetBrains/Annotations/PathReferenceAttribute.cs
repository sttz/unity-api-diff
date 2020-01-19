using System;
using System.Collections;
using System.Collections.Generic;
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
