using System;
using UnityEngine;

namespace UnityEngine
{

public class Component : Object
{
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
    public Component light { get; }
    public Component networkView { get; }
    public Component particleSystem { get; }
    public Component renderer { get; }
    public Component rigidbody { get; }
    public Component rigidbody2D { get; }
    public string tag { get; set; }
    public Transform transform { get; }

    public Component();

    public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options);
    public void BroadcastMessage(string methodName, object parameter);
    public void BroadcastMessage(string methodName);
    public void BroadcastMessage(string methodName, SendMessageOptions options);
    public bool CompareTag(string tag);
    public Component GetComponent(Type type);
    public T GetComponent();
    public Component GetComponent(string type);
    public Component GetComponentInChildren(Type t, bool includeInactive);
    public Component GetComponentInChildren(Type t);
    public T GetComponentInChildren(bool includeInactive);
    public T GetComponentInChildren();
    public Component GetComponentInParent(Type t);
    public T GetComponentInParent();
    public Component[] GetComponents(Type type);
    public void GetComponents(Type type, System.Collections.Generic.List<Component> results);
    public void GetComponents(System.Collections.Generic.List<T> results);
    public T[] GetComponents();
    public Component[] GetComponentsInChildren(Type t, bool includeInactive);
    public Component[] GetComponentsInChildren(Type t);
    public T[] GetComponentsInChildren(bool includeInactive);
    public void GetComponentsInChildren(bool includeInactive, System.Collections.Generic.List<T> result);
    public T[] GetComponentsInChildren();
    public void GetComponentsInChildren(System.Collections.Generic.List<T> results);
    public Component[] GetComponentsInParent(Type t, bool includeInactive);
    public Component[] GetComponentsInParent(Type t);
    public T[] GetComponentsInParent(bool includeInactive);
    public void GetComponentsInParent(bool includeInactive, System.Collections.Generic.List<T> results);
    public T[] GetComponentsInParent();
    public void SendMessage(string methodName, object value);
    public void SendMessage(string methodName);
    public void SendMessage(string methodName, object value, SendMessageOptions options);
    public void SendMessage(string methodName, SendMessageOptions options);
    public void SendMessageUpwards(string methodName, object value, SendMessageOptions options);
    public void SendMessageUpwards(string methodName, object value);
    public void SendMessageUpwards(string methodName);
    public void SendMessageUpwards(string methodName, SendMessageOptions options);
    public bool TryGetComponent(Type type, out Component component);
    public bool TryGetComponent(out T& component);

}

}
