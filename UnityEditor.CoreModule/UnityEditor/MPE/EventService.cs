using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.MPE
{

public static class EventService
{
    static public bool isConnected { get; }

    static public bool CancelRequest(string eventType, string message = null);
    static public void Clear();
    static public void Close();
    static public void Emit(string eventType, object args = null, int targetId = -1, UnityEditor.MPE.EventDataSerialization eventDataSerialization = 1);
    static public void Emit(string eventType, object[] args, int targetId = -1, UnityEditor.MPE.EventDataSerialization eventDataSerialization = 1);
    static public bool IsRequestPending(string eventType);
    static public void Log(string msg);
    static public Action RegisterEventHandler(string eventType, Action<string, object[]> handler);
    static public Action RegisterEventHandler(string eventType, Func<string, object[], object> handler);
    static public void Request(string eventType, Action<Exception, object[]> promiseHandler, object args = null, long timeoutInMs = 700, UnityEditor.MPE.EventDataSerialization eventDataSerialization = 1);
    static public void Request(string eventType, Action<Exception, object[]> promiseHandler, object[] args, long timeoutInMs = 700, UnityEditor.MPE.EventDataSerialization eventDataSerialization = 1);
    static public void Start();
    static public void Tick();
    static public void UnregisterEventHandler(string eventType, Func<string, object[], object> handler);

}

}
