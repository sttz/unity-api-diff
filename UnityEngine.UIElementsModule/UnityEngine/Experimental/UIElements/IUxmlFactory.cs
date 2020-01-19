using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public interface IUxmlFactory
{
    public bool canHaveAnyAttribute { get; }
    public Type CreatesType { get; }
    public string substituteForTypeName { get; }
    public string substituteForTypeNamespace { get; }
    public string substituteForTypeQualifiedName { get; }
    public IEnumerable<Experimental.UIElements.UxmlAttributeDescription> uxmlAttributesDescription { get; }
    public IEnumerable<Experimental.UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }
    public string uxmlName { get; }
    public string uxmlNamespace { get; }
    public string uxmlQualifiedName { get; }

    public bool AcceptsAttributeBag(Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);
    public Experimental.UIElements.VisualElement Create(Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

}

}
