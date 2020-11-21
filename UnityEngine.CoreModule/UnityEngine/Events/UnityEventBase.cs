using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Events
{

public abstract class UnityEventBase : ISerializationCallbackReceiver
{
    static public System.Reflection.MethodInfo GetValidMethodInfo(object obj, string functionName, Type[] argumentTypes);
    static public System.Reflection.MethodInfo GetValidMethodInfo(Type objectType, string functionName, Type[] argumentTypes);

    protected UnityEventBase();

    protected void AddListener(object targetObj, System.Reflection.MethodInfo method);
    protected System.Reflection.MethodInfo FindMethod_Impl(string name, object targetObj);
    protected System.Reflection.MethodInfo FindMethod_Impl(string name, Type targetObjType);
    public int GetPersistentEventCount();
    public string GetPersistentMethodName(int index);
    public Object GetPersistentTarget(int index);
    protected void Invoke(object[] parameters);
    protected void RegisterPersistentListener(int index, object targetObj, System.Reflection.MethodInfo method);
    protected void RegisterPersistentListener(int index, object targetObj, Type targetObjType, System.Reflection.MethodInfo method);
    public void RemoveAllListeners();
    protected void RemoveListener(object targetObj, System.Reflection.MethodInfo method);
    public void SetPersistentListenerState(int index, Events.UnityEventCallState state);
    public string ToString();
    protected bool ValidateRegistration(System.Reflection.MethodInfo method, object targetObj, Events.PersistentListenerMode mode);
    protected bool ValidateRegistration(System.Reflection.MethodInfo method, object targetObj, Events.PersistentListenerMode mode, Type argumentType);

}

}
