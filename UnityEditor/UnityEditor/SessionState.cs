using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class SessionState
{
    static public void EraseBool(string key);
    static public void EraseFloat(string key);
    static public void EraseInt(string key);
    static public void EraseIntArray(string key);
    static public void EraseString(string key);
    static public void EraseVector3(string key);
    static public bool GetBool(string key, bool defaultValue);
    static public float GetFloat(string key, float defaultValue);
    static public int GetInt(string key, int defaultValue);
    static public int[] GetIntArray(string key, int[] defaultValue);
    static public string GetString(string key, string defaultValue);
    static public Vector3 GetVector3(string key, Vector3 defaultValue);
    static public void SetBool(string key, bool value);
    static public void SetFloat(string key, float value);
    static public void SetInt(string key, int value);
    static public void SetIntArray(string key, int[] value);
    static public void SetString(string key, string value);
    static public void SetVector3(string key, Vector3 value);

    public SessionState();

}

}
