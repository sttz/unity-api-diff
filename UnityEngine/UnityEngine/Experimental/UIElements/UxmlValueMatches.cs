using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class UxmlValueMatches : Experimental.UIElements.UxmlTypeRestriction
{
    public string regex;

    public UxmlValueMatches();

    public bool Equals(Experimental.UIElements.UxmlTypeRestriction other);

}

}
