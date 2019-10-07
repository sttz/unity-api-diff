using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class UxmlRootElementFactory : Experimental.UIElements.UxmlFactory<Experimental.UIElements.VisualElement, Experimental.UIElements.UxmlRootElementTraits>
{
    public string substituteForTypeName { get; }
    public string substituteForTypeNamespace { get; }
    public string substituteForTypeQualifiedName { get; }
    public string uxmlName { get; }
    public string uxmlQualifiedName { get; }

    public UxmlRootElementFactory();

    public Experimental.UIElements.VisualElement Create(Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

}

}
