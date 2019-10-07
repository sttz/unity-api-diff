using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class UxmlTemplateFactory : UIElements.UxmlFactory<UIElements.VisualElement, UIElements.UxmlTemplateTraits>
{
    public string substituteForTypeName { get; }
    public string substituteForTypeNamespace { get; }
    public string substituteForTypeQualifiedName { get; }
    public string uxmlName { get; }
    public string uxmlQualifiedName { get; }

    public UxmlTemplateFactory();

    public UIElements.VisualElement Create(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

}

}
