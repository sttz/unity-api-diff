using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class TemplateContainer : UIElements.BindableElement
{
    public UIElements.VisualElement contentContainer { get; }
    public string templateId { get; private set; }

    public TemplateContainer();
    public TemplateContainer(string templateId);

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.TemplateContainer, UxmlTraits>
    {
        public string uxmlName { get; }
        public string uxmlQualifiedName { get; }

        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public IEnumerable<UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
