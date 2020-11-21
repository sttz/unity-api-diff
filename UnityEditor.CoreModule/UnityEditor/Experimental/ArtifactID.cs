using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental
{

public struct ArtifactID
{
    public Hash128 value;

    public bool isValid { get; }

}

}
