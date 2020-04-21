using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class ScriptableObject : Object
{
    static public ScriptableObject CreateInstance(string className);
    static public ScriptableObject CreateInstance(Type type);
    static public T CreateInstance<T>();

    public ScriptableObject();

    public void SetDirty();

}

}
