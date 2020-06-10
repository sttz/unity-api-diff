using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class InspectorElement : UIElements.BindableElement
{
    static public string customInspectorUssClassName;
    static public string debugInternalVariantUssClassName;
    static public string debugVariantUssClassName;
    static public string iMGUIContainerUssClassName;
    static public string iMGUICustomVariantUssClassName;
    static public string iMGUIDefaultVariantUssClassName;
    static public string iMGUIInspectorVariantUssClassName;
    static public string noInspectorFoundVariantUssClassName;
    static public string uIECustomVariantUssClassName;
    static public string uIEDefaultVariantUssClassName;
    static public string uIEInspectorVariantUssClassName;
    static public string ussClassName;

    public InspectorElement();
    public InspectorElement(UnityEditor.Editor editor);
    public InspectorElement(UnityEditor.SerializedObject obj);
    public InspectorElement(Object obj);

    protected void ExecuteDefaultActionAtTarget(UIElements.EventBase evt);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.InspectorElement, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public UxmlTraits();

    }

}

}
