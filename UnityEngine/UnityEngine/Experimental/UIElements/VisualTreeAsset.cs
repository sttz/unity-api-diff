using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class VisualTreeAsset : ScriptableObject
{
    public VisualTreeAsset();

    public Experimental.UIElements.VisualElement CloneTree(System.Collections.Generic.Dictionary<string, Experimental.UIElements.VisualElement> slotInsertionPoints);
    public Experimental.UIElements.VisualElement CloneTree(System.Collections.Generic.Dictionary<string, Experimental.UIElements.VisualElement> slotInsertionPoints, string bindingPath);
    public void CloneTree(Experimental.UIElements.VisualElement target, System.Collections.Generic.Dictionary<string, Experimental.UIElements.VisualElement> slotInsertionPoints);

}

}
