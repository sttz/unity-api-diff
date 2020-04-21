using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Events
{

public class UnityEvent<T0, T1, T2> : Events.UnityEventBase
{
    public UnityEvent();

    public void AddListener(Events.UnityAction<T0, T1, T2> call);
    protected System.Reflection.MethodInfo FindMethod_Impl(string name, Type targetObjType);
    public void Invoke(T0 arg0, T1 arg1, T2 arg2);
    public void RemoveListener(Events.UnityAction<T0, T1, T2> call);

}

}
