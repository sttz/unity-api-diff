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
    public void CloneTree(UIElements.VisualElement target, out int firstElementIndex, out int elementAddedCount);
    public int GetHashCode();
    public UIElements.TemplateContainer Instantiate();
    public UIElements.TemplateContainer Instantiate(string bindingPath);

}

}
