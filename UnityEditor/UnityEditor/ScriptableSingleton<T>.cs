using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class ScriptableSingleton<T> : ScriptableObject
{
    static public T instance { get; }

    protected ScriptableSingleton();

    protected void Save(bool saveAsText);

}

}
