using System;
using UnityEngine;

namespace UnityEditor
{

public class ScriptableSingleton<T> : ScriptableObject
{
    static public T instance { get; }

    static protected string GetFilePath();

    protected ScriptableSingleton();

    protected void Save(bool saveAsText);

}

}
