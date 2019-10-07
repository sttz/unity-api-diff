using System;
using UnityEngine;

namespace UnityEngine
{

public static class RemoteSettings
{
    static public event Action BeforeFetchFromServer;
    static public event Action<bool, bool, int> Completed;
    static public event UpdatedEventHandler Updated;

    static public void CallOnUpdate();
    static public void ForceUpdate();
    static public bool GetBool(string key);
    static public bool GetBool(string key, bool defaultValue);
    static public int GetCount();
    static public System.Collections.Generic.IDictionary<string, object> GetDictionary(string key = "");
    static public float GetFloat(string key);
    static public float GetFloat(string key, float defaultValue);
    static public int GetInt(string key);
    static public int GetInt(string key, int defaultValue);
    static public string[] GetKeys();
    static public long GetLong(string key);
    static public long GetLong(string key, long defaultValue);
    static public T GetObject(string key = "");
    static public object GetObject(Type type, string key = "");
    static public object GetObject(string key, object defaultValue);
    static public string GetString(string key);
    static public string GetString(string key, string defaultValue);
    static public bool HasKey(string key);
    static public bool WasLastUpdatedFromServer();

    public delegate void UpdatedEventHandler();

}

}
