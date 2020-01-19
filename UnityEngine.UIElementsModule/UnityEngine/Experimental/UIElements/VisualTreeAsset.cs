using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class VisualTreeAsset : ScriptableObject
{
    public VisualTreeAsset();

    public Experimental.UIElements.VisualElement CloneTree(Dictionary<string, Experimental.UIElements.VisualElement> slotInsertionPoints);
    public Experimental.UIElements.VisualElement CloneTree(Dictionary<string, Experimental.UIElements.VisualElement> slotInsertionPoints, string bindingPath);
    public void CloneTree(Experimental.UIElements.VisualElement target, Dictionary<string, Experimental.UIElements.VisualElement> slotInsertionPoints);

}

}
