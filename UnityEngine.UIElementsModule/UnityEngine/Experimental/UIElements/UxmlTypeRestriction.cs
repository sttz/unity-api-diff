using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public abstract class UxmlTypeRestriction : IEquatable<Experimental.UIElements.UxmlTypeRestriction>
{
    protected UxmlTypeRestriction();

    public bool Equals(Experimental.UIElements.UxmlTypeRestriction other);

}

}
