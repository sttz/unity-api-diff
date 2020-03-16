using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.MPE
{

public static class EventService
{
    static public string kEvent = "event";
    static public string kLog = "log";
    static public string kRequest = "request";
    static public string kRequestAcknowledge = "requestAck";
    static public long kRequestDefaultTimeout = 700;
    static public string kRequestExecute = "requestExecute";
    static public string kRequestResult = "requestResult";

    static public bool IsConnected { get; }

    static public bool CancelRequest(string eventType, string message = null);
    static public void Clear();
    static public void Close();
    static public void Emit(string eventType, object args = null, int targetId = -1, Unity.MPE.EventDataSerialization eventDataSerialization = 1);
    static public void Emit(string eventType, object[] args, int targetId = -1, Unity.MPE.EventDataSerialization eventDataSerialization = 1);
    static public bool IsRequestPending(string eventType);
    static public void Log(string msg);
    static public void Off(string eventType, Unity.MPE.OnHandler handler);
    static public Action On(string eventType, Unity.MPE.OnHandler handler);
    static public Action On(string eventType, Unity.MPE.OnVoidHandler handler);
    static public void Request(string eventType, Unity.MPE.PromiseHandler promiseHandler, object args = null, long timeoutInMs = 700, Unity.MPE.EventDataSerialization eventDataSerialization = 1);
    static public void Request(string eventType, Unity.MPE.PromiseHandler promiseHandler, object[] args, long timeoutInMs = 700, Unity.MPE.EventDataSerialization eventDataSerialization = 1);
    static public void Start();
    static public void Tick();

}

}
