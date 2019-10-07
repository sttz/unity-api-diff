using System;
using UnityEngine;

namespace UnityEngine
{

public class MonoBehaviour : Behaviour
{
    static public void print(object message);

    public bool runInEditMode { get; set; }
    public bool useGUILayout { get; set; }

    public MonoBehaviour();

    public void CancelInvoke();
    public void CancelInvoke(string methodName);
    public void Invoke(string methodName, float time);
    public void InvokeRepeating(string methodName, float time, float repeatRate);
    public bool IsInvoking();
    public bool IsInvoking(string methodName);
    public Coroutine StartCoroutine(string methodName);
    public Coroutine StartCoroutine(string methodName, object value);
    public Coroutine StartCoroutine(System.Collections.IEnumerator routine);
    public Coroutine StartCoroutine_Auto(System.Collections.IEnumerator routine);
    public void StopAllCoroutines();
    public void StopCoroutine(System.Collections.IEnumerator routine);
    public void StopCoroutine(Coroutine routine);
    public void StopCoroutine(string methodName);

}

}
