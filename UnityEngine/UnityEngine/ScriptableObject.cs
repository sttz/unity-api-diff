using System;
using UnityEngine;

namespace UnityEngine
{

public class ScriptableObject : Object
{
    static public ScriptableObject CreateInstance(string className);
    static public ScriptableObject CreateInstance(Type type);
    static public T CreateInstance();

    public ScriptableObject();

    public void SetDirty();

}

}
