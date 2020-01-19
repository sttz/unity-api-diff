using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public static class JsonUtility
{
    static public object FromJson(string json, Type type);
    static public T FromJson<T>(string json);
    static public void FromJsonOverwrite(string json, object objectToOverwrite);
    static public string ToJson(object obj);
    static public string ToJson(object obj, bool prettyPrint);

}

}
