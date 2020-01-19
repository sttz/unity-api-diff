using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class Foldout : Experimental.UIElements.BindableElement, Experimental.UIElements.INotifyValueChanged<bool>
{
    public Experimental.UIElements.VisualElement contentContainer { get; }
    public string text { get; set; }
    public bool value { get; set; }

    public Foldout();

    public void OnValueChanged(Experimental.UIElements.EventCallback<Experimental.UIElements.ChangeEvent<bool>> callback);
    public void RemoveOnValueChanged(Experimental.UIElements.EventCallback<Experimental.UIElements.ChangeEvent<bool>> callback);
    public void SetValueAndNotify(bool newValue);
    public void SetValueWithoutNotify(bool newValue);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<Experimental.UIElements.Foldout, UxmlTraits>
    {
        public UxmlFactory();

    }

}

}
