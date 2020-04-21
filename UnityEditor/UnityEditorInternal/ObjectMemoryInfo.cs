using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public sealed class ObjectMemoryInfo
{
    public string className;
    public int count;
    public int instanceId;
    public long memorySize;
    public string name;
    public int reason;

    public ObjectMemoryInfo();

}

}
