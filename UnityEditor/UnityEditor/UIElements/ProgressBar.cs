using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class ProgressBar : UIElements.BindableElement, UIElements.INotifyValueChanged<float>
{
    static public string backgroundUssClassName;
    static public string containerUssClassName;
    static public string progressUssClassName;
    static public string titleContainerUssClassName;
    static public string titleUssClassName;
    static public string ussClassName;

    public string title { get; set; }
    public float value { get; set; }

    public ProgressBar();

    public void SetValueWithoutNotify(float newValue);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.ProgressBar, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
