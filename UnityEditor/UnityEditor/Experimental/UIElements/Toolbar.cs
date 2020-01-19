using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class Toolbar : Experimental.UIElements.VisualElement
{
    public Toolbar();

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.Toolbar>
    {
        public UxmlFactory();

    }

}

}
