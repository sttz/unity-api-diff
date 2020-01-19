using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class RemoteConfigSettings : IDisposable
{
    static public void AddSessionTag(string tag);
    static public bool QueueConfig(string name, object param, int ver = 1, string prefix = "");
    static public bool SendDeviceInfoInConfigRequest();

    public event Action<bool> Updated;

    public RemoteConfigSettings(string configKey);

    public void Dispose();
    public void ForceUpdate();
    public bool GetBool(string key);
    public bool GetBool(string key, bool defaultValue);
    public int GetCount();
    public float GetFloat(string key);
    public float GetFloat(string key, float defaultValue);
    public int GetInt(string key);
    public int GetInt(string key, int defaultValue);
    public string[] GetKeys();
    public long GetLong(string key);
    public long GetLong(string key, long defaultValue);
    public string GetString(string key);
    public string GetString(string key, string defaultValue);
    public bool HasKey(string key);
    public bool WasLastUpdatedFromServer();

}

}
