using System;
using UnityEngine;

namespace UnityEditor
{

public static class EditorJsonUtility
{
    static public void FromJsonOverwrite(string json, object objectToOverwrite);
    static public string ToJson(object obj);
    static public string ToJson(object obj, bool prettyPrint);

}

}
