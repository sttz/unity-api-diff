using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class Button : Experimental.UIElements.TextElement
{
    public Experimental.UIElements.Clickable clickable;

    public Button();
    public Button(Action clickEvent);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<Experimental.UIElements.Button, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public UxmlTraits();

    }

}

}
