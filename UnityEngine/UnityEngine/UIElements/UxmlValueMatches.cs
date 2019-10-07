using System;
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
