using System;
using UnityEngine;

namespace UnityEditor
{

public class MonoImporter : UnityEditor.AssetImporter
{
    static public UnityEditor.MonoScript[] GetAllRuntimeMonoScripts();
    static public int GetExecutionOrder(UnityEditor.MonoScript script);
    static public void SetExecutionOrder(UnityEditor.MonoScript script, int order);

    public MonoImporter();

    public Object GetDefaultReference(string name);
    public UnityEditor.MonoScript GetScript();
    public void SetDefaultReferences(string[] name, Object[] target);

}

}
