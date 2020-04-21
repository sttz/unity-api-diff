using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Events
{

public static class UnityEventTools
{
    static public void AddBoolPersistentListener(Events.UnityEventBase unityEvent, Events.UnityAction<bool> call, bool argument);
    static public void AddFloatPersistentListener(Events.UnityEventBase unityEvent, Events.UnityAction<float> call, float argument);
    static public void AddIntPersistentListener(Events.UnityEventBase unityEvent, Events.UnityAction<int> call, int argument);
    static public void AddObjectPersistentListener<T>(Events.UnityEventBase unityEvent, Events.UnityAction<T> call, T argument);
    static public void AddPersistentListener(Events.UnityEventBase unityEvent);
    static public void AddPersistentListener(Events.UnityEvent unityEvent, Events.UnityAction call);
    static public void AddPersistentListener<T0>(Events.UnityEvent<T0> unityEvent, Events.UnityAction<T0> call);
    static public void AddPersistentListener<T0, T1>(Events.UnityEvent<T0, T1> unityEvent, Events.UnityAction<T0, T1> call);
    static public void AddPersistentListener<T0, T1, T2>(Events.UnityEvent<T0, T1, T2> unityEvent, Events.UnityAction<T0, T1, T2> call);
    static public void AddPersistentListener<T0, T1, T2, T3>(Events.UnityEvent<T0, T1, T2, T3> unityEvent, Events.UnityAction<T0, T1, T2, T3> call);
    static public void AddStringPersistentListener(Events.UnityEventBase unityEvent, Events.UnityAction<string> call, string argument);
    static public void AddVoidPersistentListener(Events.UnityEventBase unityEvent, Events.UnityAction call);
    static public void RegisterBoolPersistentListener(Events.UnityEventBase unityEvent, int index, Events.UnityAction<bool> call, bool argument);
    static public void RegisterFloatPersistentListener(Events.UnityEventBase unityEvent, int index, Events.UnityAction<float> call, float argument);
    static public void RegisterIntPersistentListener(Events.UnityEventBase unityEvent, int index, Events.UnityAction<int> call, int argument);
    static public void RegisterObjectPersistentListener<T>(Events.UnityEventBase unityEvent, int index, Events.UnityAction<T> call, T argument);
    static public void RegisterPersistentListener(Events.UnityEvent unityEvent, int index, Events.UnityAction call);
    static public void RegisterPersistentListener<T0>(Events.UnityEvent<T0> unityEvent, int index, Events.UnityAction<T0> call);
    static public void RegisterPersistentListener<T0, T1>(Events.UnityEvent<T0, T1> unityEvent, int index, Events.UnityAction<T0, T1> call);
    static public void RegisterPersistentListener<T0, T1, T2>(Events.UnityEvent<T0, T1, T2> unityEvent, int index, Events.UnityAction<T0, T1, T2> call);
    static public void RegisterPersistentListener<T0, T1, T2, T3>(Events.UnityEvent<T0, T1, T2, T3> unityEvent, int index, Events.UnityAction<T0, T1, T2, T3> call);
    static public void RegisterStringPersistentListener(Events.UnityEventBase unityEvent, int index, Events.UnityAction<string> call, string argument);
    static public void RegisterVoidPersistentListener(Events.UnityEventBase unityEvent, int index, Events.UnityAction call);
    static public void RemovePersistentListener(Events.UnityEventBase unityEvent, Events.UnityAction call);
    static public void RemovePersistentListener(Events.UnityEventBase unityEvent, int index);
    static public void RemovePersistentListener<T0>(Events.UnityEventBase unityEvent, Events.UnityAction<T0> call);
    static public void RemovePersistentListener<T0, T1>(Events.UnityEventBase unityEvent, Events.UnityAction<T0, T1> call);
    static public void RemovePersistentListener<T0, T1, T2>(Events.UnityEventBase unityEvent, Events.UnityAction<T0, T1, T2> call);
    static public void RemovePersistentListener<T0, T1, T2, T3>(Events.UnityEventBase unityEvent, Events.UnityAction<T0, T1, T2, T3> call);
    static public void UnregisterPersistentListener(Events.UnityEventBase unityEvent, int index);

}

}
