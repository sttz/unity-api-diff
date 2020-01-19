using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class BindableElement : UIElements.VisualElement, UIElements.IBindable
{
    public UIElements.IBinding binding { get; set; }
    public string bindingPath { get; set; }

    public BindableElement();

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.BindableElement, UxmlTraits>
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
