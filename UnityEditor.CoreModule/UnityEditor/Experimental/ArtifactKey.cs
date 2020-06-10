using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental
{

public struct ArtifactKey
{
    public UnityEditor.GUID guid;
    public Type importerType;

    public ArtifactKey(UnityEditor.GUID g);
    public ArtifactKey(UnityEditor.GUID guid, Type importerType);

}

}
