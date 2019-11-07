using System;
using UnityEngine;

namespace UnityEditor
{

public static class ObjectFactory
{
    static public event Action<Component> componentWasAdded;

    static public T AddComponent(GameObject gameObject);
    static public Component AddComponent(GameObject gameObject, Type type);
    static public GameObject CreateGameObject(SceneManagement.Scene scene, HideFlags hideFlags, string name, Type[] types);
    static public GameObject CreateGameObject(string name, Type[] types);
    static public T CreateInstance();
    static public Object CreateInstance(Type type);
    static public GameObject CreatePrimitive(PrimitiveType type);

}

}
