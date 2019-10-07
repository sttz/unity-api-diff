using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class UxmlEnumeration : UIElements.UxmlTypeRestriction
{
    public System.Collections.Generic.IEnumerable<string> values { get; set; }

    public UxmlEnumeration();

    public bool Equals(UIElements.UxmlTypeRestriction other);

}

}
