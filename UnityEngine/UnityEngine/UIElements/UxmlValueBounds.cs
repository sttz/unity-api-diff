using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class UxmlValueBounds : UIElements.UxmlTypeRestriction
{
    public bool excludeMax { get; set; }
    public bool excludeMin { get; set; }
    public string max { get; set; }
    public string min { get; set; }

    public UxmlValueBounds();

    public bool Equals(UIElements.UxmlTypeRestriction other);

}

}
