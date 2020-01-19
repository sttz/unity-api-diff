using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public sealed class ObjectMemoryStackInfo
{
    public int allocated;
    public UnityEditorInternal.ObjectMemoryStackInfo[] callerSites;
    public bool expanded;
    public string name;
    public int ownedAllocated;
    public bool sorted;

    public ObjectMemoryStackInfo();

}

}
