using System;
using UnityEngine;

namespace UnityEngine
{

public static class JsonUtility
{
    static public T FromJson(string json);
    static public object FromJson(string json, Type type);
    static public void FromJsonOverwrite(string json, object objectToOverwrite);
    static public string ToJson(object obj);
    static public string ToJson(object obj, bool prettyPrint);

}

}
