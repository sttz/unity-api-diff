using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.AssetImporters
{

public class CollectImportedDependenciesAttribute : Attribute
{
    public Type importerType { get; }
    public uint version { get; }

    public CollectImportedDependenciesAttribute(Type importerType, uint version);

}

}
