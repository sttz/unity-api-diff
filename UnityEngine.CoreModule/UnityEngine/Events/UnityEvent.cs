using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Events
{

public class UnityEvent : Events.UnityEventBase
{
    public UnityEvent();

    public void AddListener(Events.UnityAction call);
    protected System.Reflection.MethodInfo FindMethod_Impl(string name, Type targetObjType);
    public void Invoke();
    public void RemoveListener(Events.UnityAction call);

}

}
