using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class UxmlValueBounds : Experimental.UIElements.UxmlTypeRestriction
{
    public bool excludeMax;
    public bool excludeMin;
    public string max;
    public string min;

    public UxmlValueBounds();

    public bool Equals(Experimental.UIElements.UxmlTypeRestriction other);

}

}
