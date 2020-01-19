using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class Foldout : UIElements.BindableElement, UIElements.INotifyValueChanged<bool>
{
    static public string contentUssClassName;
    static public string toggleUssClassName;
    static public string ussClassName;

    public UIElements.VisualElement contentContainer { get; }
    public string text { get; set; }
    public bool value { get; set; }

    public Foldout();

    public void SetValueWithoutNotify(bool newValue);

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.Foldout, UxmlTraits>
    {
        public UxmlFactory();

    }

}

}
