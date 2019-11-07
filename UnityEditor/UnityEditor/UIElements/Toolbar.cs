using System;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class Toolbar : UIElements.VisualElement
{
    static public string ussClassName;

    public Toolbar();

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.Toolbar>
    {
        public UxmlFactory();

    }

}

}
