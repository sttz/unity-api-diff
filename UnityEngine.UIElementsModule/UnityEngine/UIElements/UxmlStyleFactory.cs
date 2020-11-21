using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class UxmlStyleFactory : UIElements.UxmlFactory<UIElements.VisualElement, UIElements.UxmlStyleTraits>
{
    public string substituteForTypeName { get; }
    public string substituteForTypeNamespace { get; }
    public string substituteForTypeQualifiedName { get; }
    public string uxmlName { get; }
    public string uxmlQualifiedName { get; }

    public UxmlStyleFactory();

    public UIElements.VisualElement Create(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

}

}
