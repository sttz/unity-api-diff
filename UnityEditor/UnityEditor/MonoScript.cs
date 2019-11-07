using System;
using UnityEngine;

namespace UnityEditor
{

public class MonoScript : TextAsset
{
    static public UnityEditor.MonoScript FromMonoBehaviour(MonoBehaviour behaviour);
    static public UnityEditor.MonoScript FromScriptableObject(ScriptableObject scriptableObject);

    public MonoScript();

    public Type GetClass();

}

}
