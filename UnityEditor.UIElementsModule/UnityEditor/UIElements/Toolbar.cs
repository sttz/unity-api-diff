using System;
using System.Collections;
using System.Collections.Generic;
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
