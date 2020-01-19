using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class Object
{
    static public void Destroy(Object obj);
    static public void Destroy(Object obj, float t);
    static public void DestroyImmediate(Object obj);
    static public void DestroyImmediate(Object obj, bool allowDestroyingAssets);
    static public void DestroyObject(Object obj);
    static public void DestroyObject(Object obj, float t);
    static public void DontDestroyOnLoad(Object target);
    static public Object FindObjectOfType(Type type);
    static public T FindObjectOfType<T>();
    static public Object[] FindObjectsOfType(Type type);
    static public T[] FindObjectsOfType<T>();
    static public Object[] FindObjectsOfTypeAll(Type type);
    static public Object[] FindObjectsOfTypeIncludingAssets(Type type);
    static public Object[] FindSceneObjectsOfType(Type type);
    static public Object Instantiate(Object original);
    static public Object Instantiate(Object original, Transform parent);
    static public Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace);
    static public Object Instantiate(Object original, Vector3 position, Quaternion rotation);
    static public Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent);
    static public T Instantiate<T>(T original);
    static public T Instantiate<T>(T original, Transform parent);
    static public T Instantiate<T>(T original, Transform parent, bool worldPositionStays);
    static public T Instantiate<T>(T original, Vector3 position, Quaternion rotation);
    static public T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent);

    public HideFlags hideFlags { get; set; }
    public string name { get; set; }

    public Object();

    public bool Equals(object other);
    public int GetHashCode();
    public int GetInstanceID();
    public string ToString();

}

}
