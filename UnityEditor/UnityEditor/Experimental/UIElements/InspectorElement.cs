using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class InspectorElement : Experimental.UIElements.BindableElement
{
    public Mode mode { get; private set; }

    public InspectorElement();
    public InspectorElement(Object obj);
    public InspectorElement(Object obj, Mode mode);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.InspectorElement, UxmlTraits>
    {
        public UxmlFactory();

    }

    public enum Mode
    {
        Normal = 0,
        Default = 1,
        Custom = 2,
        IMGUI = 3,
    }

}

}
