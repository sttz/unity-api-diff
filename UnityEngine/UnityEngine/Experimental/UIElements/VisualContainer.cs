using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class VisualContainer : Experimental.UIElements.VisualElement
{
    public VisualContainer();

    public void AddChild(Experimental.UIElements.VisualElement child);
    public void ClearChildren();
    public Experimental.UIElements.VisualElement GetChildAt(int index);
    public void InsertChild(int index, Experimental.UIElements.VisualElement child);
    public void RemoveChild(Experimental.UIElements.VisualElement child);
    public void RemoveChildAt(int index);

    public class UxmlFactory : UxmlFactory
    {
        public string substituteForTypeName { get; }
        public string substituteForTypeNamespace { get; }
        public string substituteForTypeQualifiedName { get; }
        public string uxmlName { get; }
        public string uxmlNamespace { get; }
        public string uxmlQualifiedName { get; }

        public UxmlFactory();

    }

}

}
