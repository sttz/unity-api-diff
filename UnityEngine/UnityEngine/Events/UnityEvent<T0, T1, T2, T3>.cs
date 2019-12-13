using System;
using UnityEngine;

namespace UnityEngine.Events
{

public class UnityEvent<T0, T1, T2, T3> : Events.UnityEventBase
{
    public UnityEvent();

    public void AddListener(Events.UnityAction<T0, T1, T2, T3> call);
    protected System.Reflection.MethodInfo FindMethod_Impl(string name, Type targetObjType);
    public void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3);
    public void RemoveListener(Events.UnityAction<T0, T1, T2, T3> call);

}

}
