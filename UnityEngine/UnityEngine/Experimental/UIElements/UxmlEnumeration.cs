using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class UxmlEnumeration : Experimental.UIElements.UxmlTypeRestriction
{
    public System.Collections.Generic.List<string> values;

    public UxmlEnumeration();

    public bool Equals(Experimental.UIElements.UxmlTypeRestriction other);

}

}
