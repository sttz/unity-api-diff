using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public sealed class SerializedPropertyChangeEvent : UIElements.EventBase<UnityEditor.UIElements.SerializedPropertyChangeEvent>
{
    static public UnityEditor.UIElements.SerializedPropertyChangeEvent GetPooled(UnityEditor.SerializedProperty value);

    public UnityEditor.SerializedProperty changedProperty { get; set; }

    public SerializedPropertyChangeEvent();

    protected void Init();

}

}
