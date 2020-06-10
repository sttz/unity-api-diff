using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.SearchService
{

public struct ObjectSelectorTargetInfo
{
    public UnityEditor.GlobalObjectId globalObjectId { get; }
    public Object targetObject { get; }
    public Type type { get; }

    public ObjectSelectorTargetInfo(UnityEditor.GlobalObjectId globalObjectId, Object targetObject = null, Type type = null);

    public Object LoadObject();

}

}
