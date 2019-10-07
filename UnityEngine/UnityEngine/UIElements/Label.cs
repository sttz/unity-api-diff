using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class Label : UIElements.TextElement
{
    static public string ussClassName;

    public Label();
    public Label(string text);

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.Label, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public UxmlTraits();

    }

}

}
