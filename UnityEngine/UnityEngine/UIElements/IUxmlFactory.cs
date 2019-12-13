using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public interface IUxmlFactory
{
    public bool canHaveAnyAttribute { get; }
    public string substituteForTypeName { get; }
    public string substituteForTypeNamespace { get; }
    public string substituteForTypeQualifiedName { get; }
    public System.Collections.Generic.IEnumerable<UIElements.UxmlAttributeDescription> uxmlAttributesDescription { get; }
    public System.Collections.Generic.IEnumerable<UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }
    public string uxmlName { get; }
    public string uxmlNamespace { get; }
    public string uxmlQualifiedName { get; }

    public bool AcceptsAttributeBag(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);
    public UIElements.VisualElement Create(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

}

}