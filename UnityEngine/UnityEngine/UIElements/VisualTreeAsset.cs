using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class VisualTreeAsset : ScriptableObject
{
    public VisualTreeAsset();

    public UIElements.TemplateContainer CloneTree();
    public UIElements.TemplateContainer CloneTree(string bindingPath);
    public void CloneTree(UIElements.VisualElement target);
    public int GetHashCode();

}

}
