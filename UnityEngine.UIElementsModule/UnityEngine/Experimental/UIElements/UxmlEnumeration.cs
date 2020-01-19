using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class UxmlEnumeration : Experimental.UIElements.UxmlTypeRestriction
{
    public List<string> values;

    public UxmlEnumeration();

    public bool Equals(Experimental.UIElements.UxmlTypeRestriction other);

}

}
