using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class UxmlEnumeration : UIElements.UxmlTypeRestriction
{
    public IEnumerable<string> values { get; set; }

    public UxmlEnumeration();

    public bool Equals(UIElements.UxmlTypeRestriction other);

}

}
