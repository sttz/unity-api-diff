using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class UxmlTypeRestriction : IEquatable<UIElements.UxmlTypeRestriction>
{
    protected UxmlTypeRestriction();

    public bool Equals(UIElements.UxmlTypeRestriction other);

}

}
