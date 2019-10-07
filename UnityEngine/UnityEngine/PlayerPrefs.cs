using System;
using UnityEngine;

namespace UnityEngine
{

public class PlayerPrefs
{
    static public void DeleteAll();
    static public void DeleteKey(string key);
    static public float GetFloat(string key, float defaultValue);
    static public float GetFloat(string key);
    static public int GetInt(string key, int defaultValue);
    static public int GetInt(string key);
    static public string GetString(string key, string defaultValue);
    static public string GetString(string key);
    static public bool HasKey(string key);
    static public void Save();
    static public void SetFloat(string key, float value);
    static public void SetInt(string key, int value);
    static public void SetString(string key, string value);

    public PlayerPrefs();

}

}
