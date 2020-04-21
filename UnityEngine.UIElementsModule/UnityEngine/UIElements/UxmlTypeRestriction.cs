using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class UxmlTypeRestriction : IEquatable<UIElements.UxmlTypeRestriction>
{
    protected UxmlTypeRestriction();

    public bool Equals(UIElements.UxmlTypeRestriction other);

}

}
