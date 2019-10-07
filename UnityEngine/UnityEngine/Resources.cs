using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class Resources
{
    static public Object[] FindObjectsOfTypeAll(Type type);
    static public T[] FindObjectsOfTypeAll();
    static public Object GetBuiltinResource(Type type, string path);
    static public T GetBuiltinResource(string path);
    static public Object Load(string path);
    static public T Load(string path);
    static public Object Load(string path, Type systemTypeInstance);
    static public Object[] LoadAll(string path, Type systemTypeInstance);
    static public Object[] LoadAll(string path);
    static public T[] LoadAll(string path);
    static public Object LoadAssetAtPath(string assetPath, Type type);
    static public T LoadAssetAtPath(string assetPath);
    static public ResourceRequest LoadAsync(string path);
    static public ResourceRequest LoadAsync(string path);
    static public ResourceRequest LoadAsync(string path, Type type);
    static public void UnloadAsset(Object assetToUnload);
    static public AsyncOperation UnloadUnusedAssets();

    public Resources();

}

}
