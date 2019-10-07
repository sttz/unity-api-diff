using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class Box : UIElements.VisualElement
{
    static public string ussClassName;

    public Box();

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.Box>
    {
        public UxmlFactory();

    }

}

}
