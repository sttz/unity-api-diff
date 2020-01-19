using System;
using System.Collections;
using System.Collections.Generic;
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

    public void BroadcastMessage(string methodName);
    public void BroadcastMessage(string methodName, SendMessageOptions options);
    public void BroadcastMessage(string methodName, object parameter);
    public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options);
    public bool CompareTag(string tag);
    public Component GetComponent(string type);
    public Component GetComponent(Type type);
    public T GetComponent<T>();
    public Component GetComponentInChildren(Type t);
    public Component GetComponentInChildren(Type t, bool includeInactive);
    public T GetComponentInChildren<T>();
    public T GetComponentInChildren<T>(bool includeInactive);
    public Component GetComponentInParent(Type t);
    public T GetComponentInParent<T>();
    public Component[] GetComponents(Type type);
    public void GetComponents(Type type, List<Component> results);
    public T[] GetComponents<T>();
    public void GetComponents<T>(List<T> results);
    public Component[] GetComponentsInChildren(Type t);
    public Component[] GetComponentsInChildren(Type t, bool includeInactive);
    public T[] GetComponentsInChildren<T>();
    public T[] GetComponentsInChildren<T>(bool includeInactive);
    public void GetComponentsInChildren<T>(List<T> results);
    public void GetComponentsInChildren<T>(bool includeInactive, List<T> result);
    public Component[] GetComponentsInParent(Type t);
    public Component[] GetComponentsInParent(Type t, bool includeInactive);
    public T[] GetComponentsInParent<T>();
    public T[] GetComponentsInParent<T>(bool includeInactive);
    public void GetComponentsInParent<T>(bool includeInactive, List<T> results);
    public void SendMessage(string methodName);
    public void SendMessage(string methodName, SendMessageOptions options);
    public void SendMessage(string methodName, object value);
    public void SendMessage(string methodName, object value, SendMessageOptions options);
    public void SendMessageUpwards(string methodName);
    public void SendMessageUpwards(string methodName, SendMessageOptions options);
    public void SendMessageUpwards(string methodName, object value);
    public void SendMessageUpwards(string methodName, object value, SendMessageOptions options);
    public bool TryGetComponent(Type type, out Component component);
    public bool TryGetComponent<T>(out T component);

}

}
