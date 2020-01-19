using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class Resources
{
    static public Object[] FindObjectsOfTypeAll(Type type);
    static public T[] FindObjectsOfTypeAll<T>();
    static public Object GetBuiltinResource(Type type, string path);
    static public T GetBuiltinResource<T>(string path);
    static public Object Load(string path);
    static public Object Load(string path, Type systemTypeInstance);
    static public T Load<T>(string path);
    static public Object[] LoadAll(string path);
    static public Object[] LoadAll(string path, Type systemTypeInstance);
    static public T[] LoadAll<T>(string path);
    static public Object LoadAssetAtPath(string assetPath, Type type);
    static public T LoadAssetAtPath<T>(string assetPath);
    static public ResourceRequest LoadAsync(string path);
    static public ResourceRequest LoadAsync(string path, Type type);
    static public ResourceRequest LoadAsync<T>(string path);
    static public void UnloadAsset(Object assetToUnload);
    static public AsyncOperation UnloadUnusedAssets();

    public Resources();

}

}
