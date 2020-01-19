using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class EditorPrefs
{
    static public void DeleteAll();
    static public void DeleteKey(string key);
    static public bool GetBool(string key);
    static public bool GetBool(string key, bool defaultValue);
    static public float GetFloat(string key);
    static public float GetFloat(string key, float defaultValue);
    static public int GetInt(string key);
    static public int GetInt(string key, int defaultValue);
    static public string GetString(string key);
    static public string GetString(string key, string defaultValue);
    static public bool HasKey(string key);
    static public void SetBool(string key, bool value);
    static public void SetFloat(string key, float value);
    static public void SetInt(string key, int value);
    static public void SetString(string key, string value);

    public EditorPrefs();

}

}
