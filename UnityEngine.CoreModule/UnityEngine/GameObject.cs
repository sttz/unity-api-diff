using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class GameObject : Object
{
    static public GameObject CreatePrimitive(PrimitiveType type);
    static public GameObject Find(string name);
    static public GameObject[] FindGameObjectsWithTag(string tag);
    static public GameObject FindGameObjectWithTag(string tag);
    static public GameObject FindWithTag(string tag);

    public bool active { get; set; }
    public bool activeInHierarchy { get; }
    public bool activeSelf { get; }
    public Component animation { get; }
    public Component audio { get; }
    public Component camera { get; }
    public Component collider { get; }
    public Component collider2D { get; }
    public Component constantForce { get; }
    public GameObject gameObject { get; }
    public Component hingeJoint { get; }
    public bool isStatic { get; set; }
    public int layer { get; set; }
    public Component light { get; }
    public Component networkView { get; }
    public Component particleSystem { get; }
    public Component renderer { get; }
    public Component rigidbody { get; }
    public Component rigidbody2D { get; }
    public SceneManagement.Scene scene { get; }
    public ulong sceneCullingMask { get; }
    public string tag { get; set; }
    public Transform transform { get; }

    public GameObject();
    public GameObject(string name);
    public GameObject(string name, Type[] components);

    public Component AddComponent(string className);
    public Component AddComponent(Type componentType);
    public T AddComponent<T>();
    public void BroadcastMessage(string methodName);
    public void BroadcastMessage(string methodName, SendMessageOptions options);
    public void BroadcastMessage(string methodName, object parameter);
    public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options);
    public bool CompareTag(string tag);
    public Component GetComponent(string type);
    public Component GetComponent(Type type);
    public T GetComponent<T>();
    public Component GetComponentInChildren(Type type);
    public Component GetComponentInChildren(Type type, bool includeInactive);
    public T GetComponentInChildren<T>();
    public T GetComponentInChildren<T>(bool includeInactive);
    public Component GetComponentInParent(Type type);
    public Component GetComponentInParent(Type type, bool includeInactive);
    public T GetComponentInParent<T>();
    public T GetComponentInParent<T>(bool includeInactive);
    public Component[] GetComponents(Type type);
    public void GetComponents(Type type, List<Component> results);
    public T[] GetComponents<T>();
    public void GetComponents<T>(List<T> results);
    public Component[] GetComponentsInChildren(Type type);
    public Component[] GetComponentsInChildren(Type type, bool includeInactive);
    public T[] GetComponentsInChildren<T>();
    public T[] GetComponentsInChildren<T>(bool includeInactive);
    public void GetComponentsInChildren<T>(List<T> results);
    public void GetComponentsInChildren<T>(bool includeInactive, List<T> results);
    public Component[] GetComponentsInParent(Type type);
    public Component[] GetComponentsInParent(Type type, bool includeInactive);
    public T[] GetComponentsInParent<T>();
    public T[] GetComponentsInParent<T>(bool includeInactive);
    public void GetComponentsInParent<T>(bool includeInactive, List<T> results);
    public void PlayAnimation(Object animation);
    public void SampleAnimation(Object clip, float time);
    public void SendMessage(string methodName);
    public void SendMessage(string methodName, SendMessageOptions options);
    public void SendMessage(string methodName, object value);
    public void SendMessage(string methodName, object value, SendMessageOptions options);
    public void SendMessageUpwards(string methodName);
    public void SendMessageUpwards(string methodName, SendMessageOptions options);
    public void SendMessageUpwards(string methodName, object value);
    public void SendMessageUpwards(string methodName, object value, SendMessageOptions options);
    public void SetActive(bool value);
    public void SetActiveRecursively(bool state);
    public void StopAnimation();
    public bool TryGetComponent(Type type, out Component component);
    public bool TryGetComponent<T>(out T component);

}

}
