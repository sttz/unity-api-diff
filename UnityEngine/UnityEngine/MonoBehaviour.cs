using System;
using System.Collections;
using System.Collections.Generic;
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
    public Coroutine StartCoroutine(IEnumerator routine);
    public Coroutine StartCoroutine(string methodName, object value);
    public Coroutine StartCoroutine_Auto(IEnumerator routine);
    public void StopAllCoroutines();
    public void StopCoroutine(string methodName);
    public void StopCoroutine(IEnumerator routine);
    public void StopCoroutine(Coroutine routine);

}

}
