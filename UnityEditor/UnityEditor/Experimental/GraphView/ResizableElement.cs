using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class ResizableElement : UIElements.VisualElement
{
    public ResizableElement();
    public ResizableElement(string uiFile);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.Experimental.GraphView.ResizableElement>
    {
        public UxmlFactory();

    }

}

}