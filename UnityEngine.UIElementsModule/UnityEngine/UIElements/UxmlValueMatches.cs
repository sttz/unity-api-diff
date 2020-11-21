using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class UxmlValueMatches : UIElements.UxmlTypeRestriction
{
    public string regex { get; set; }

    public UxmlValueMatches();

    public bool Equals(UIElements.UxmlTypeRestriction other);

}

}
