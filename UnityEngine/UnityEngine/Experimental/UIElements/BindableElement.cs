using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class BindableElement : Experimental.UIElements.VisualElement, Experimental.UIElements.IBindable
{
    public Experimental.UIElements.IBinding binding { get; set; }
    public string bindingPath { get; set; }

    public BindableElement();

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<Experimental.UIElements.BindableElement, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
