using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class TemplateContainer : Experimental.UIElements.BindableElement
{
    public Experimental.UIElements.VisualElement contentContainer { get; }
    public string templateId { get; private set; }

    public TemplateContainer();
    public TemplateContainer(string templateId);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<Experimental.UIElements.TemplateContainer, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public System.Collections.Generic.IEnumerable<Experimental.UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
