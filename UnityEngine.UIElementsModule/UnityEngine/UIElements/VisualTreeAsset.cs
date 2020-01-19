using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class VisualTreeAsset : ScriptableObject
{
    public int contentHash { get; set; }
    public IEnumerable<UIElements.StyleSheet> stylesheets { get; }
    public IEnumerable<UIElements.VisualTreeAsset> templateDependencies { get; }

    public VisualTreeAsset();

    public UIElements.TemplateContainer CloneTree();
    public UIElements.TemplateContainer CloneTree(string bindingPath);
    public void CloneTree(UIElements.VisualElement target);
    public void CloneTree(UIElements.VisualElement target, out int firstElementIndex, out int elementAddedCount);
    public UIElements.TemplateContainer Instantiate();
    public UIElements.TemplateContainer Instantiate(string bindingPath);

}

}
