using System;
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
    public Component guiElement { get; }
    public Component guiText { get; }
    public Component guiTexture { get; }
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
    public string tag { get; set; }
    public Transform transform { get; }

    public GameObject(string name);
    public GameObject();
    public GameObject(string name, Type[] components);

    public Component AddComponent(Type componentType);
    public T AddComponent();
    public Component AddComponent(string className);
    public void BroadcastMessage(string methodName, SendMessageOptions options);
    public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options);
    public void BroadcastMessage(string methodName, object parameter);
    public void BroadcastMessage(string methodName);
    public bool CompareTag(string tag);
    public T GetComponent();
    public Component GetComponent(Type type);
    public Component GetComponent(string type);
    public Component GetComponentInChildren(Type type, bool includeInactive);
    public Component GetComponentInChildren(Type type);
    public T GetComponentInChildren();
    public T GetComponentInChildren(bool includeInactive);
    public Component GetComponentInParent(Type type);
    public T GetComponentInParent();
    public Component[] GetComponents(Type type);
    public T[] GetComponents();
    public void GetComponents(Type type, System.Collections.Generic.List<Component> results);
    public void GetComponents(System.Collections.Generic.List<T> results);
    public Component[] GetComponentsInChildren(Type type);
    public Component[] GetComponentsInChildren(Type type, bool includeInactive);
    public T[] GetComponentsInChildren(bool includeInactive);
    public void GetComponentsInChildren(bool includeInactive, System.Collections.Generic.List<T> results);
    public T[] GetComponentsInChildren();
    public void GetComponentsInChildren(System.Collections.Generic.List<T> results);
    public Component[] GetComponentsInParent(Type type);
    public Component[] GetComponentsInParent(Type type, bool includeInactive);
    public void GetComponentsInParent(bool includeInactive, System.Collections.Generic.List<T> results);
    public T[] GetComponentsInParent(bool includeInactive);
    public T[] GetComponentsInParent();
    public void PlayAnimation(Object animation);
    public void SampleAnimation(Object clip, float time);
    public void SendMessage(string methodName, SendMessageOptions options);
    public void SendMessage(string methodName, object value, SendMessageOptions options);
    public void SendMessage(string methodName, object value);
    public void SendMessage(string methodName);
    public void SendMessageUpwards(string methodName, SendMessageOptions options);
    public void SendMessageUpwards(string methodName, object value, SendMessageOptions options);
    public void SendMessageUpwards(string methodName, object value);
    public void SendMessageUpwards(string methodName);
    public void SetActive(bool value);
    public void SetActiveRecursively(bool state);
    public void StopAnimation();
    public bool TryGetComponent(out T& component);
    public bool TryGetComponent(Type type, out Component component);

}

}
