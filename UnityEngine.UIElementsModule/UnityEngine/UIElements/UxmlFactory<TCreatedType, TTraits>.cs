using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class UxmlFactory<TCreatedType, TTraits> : UIElements.IUxmlFactory
{
    public bool canHaveAnyAttribute { get; }
    public string substituteForTypeName { get; }
    public string substituteForTypeNamespace { get; }
    public string substituteForTypeQualifiedName { get; }
    public IEnumerable<UIElements.UxmlAttributeDescription> uxmlAttributesDescription { get; }
    public IEnumerable<UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }
    public string uxmlName { get; }
    public string uxmlNamespace { get; }
    public string uxmlQualifiedName { get; }

    protected UxmlFactory();

    public bool AcceptsAttributeBag(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);
    public UIElements.VisualElement Create(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

}

}
