using System;
using UnityEngine;

namespace UnityEngine.Events
{

public class UnityEvent<T0> : Events.UnityEventBase
{
    public UnityEvent();

    public void AddListener(Events.UnityAction<T0> call);
    protected System.Reflection.MethodInfo FindMethod_Impl(string name, Type targetObjType);
    public void Invoke(T0 arg0);
    public void RemoveListener(Events.UnityAction<T0> call);

}

}
