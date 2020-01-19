using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public static class ObjectFactory
{
    static public event Action<Component> componentWasAdded;

    static public Component AddComponent(GameObject gameObject, Type type);
    static public T AddComponent<T>(GameObject gameObject);
    static public GameObject CreateGameObject(string name, Type[] types);
    static public Object CreateInstance(Type type);
    static public T CreateInstance<T>();
    static public GameObject CreatePrimitive(PrimitiveType type);

}

}
