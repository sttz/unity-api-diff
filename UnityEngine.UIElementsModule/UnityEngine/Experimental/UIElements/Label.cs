using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class Label : Experimental.UIElements.TextElement
{
    public Label();
    public Label(string text);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<Experimental.UIElements.Label, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public UxmlTraits();

    }

}

}
