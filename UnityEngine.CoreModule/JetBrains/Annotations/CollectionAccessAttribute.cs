using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetBrains.Annotations
{

public sealed class CollectionAccessAttribute : Attribute
{
    public JetBrains.Annotations.CollectionAccessType CollectionAccessType { get; }

    public CollectionAccessAttribute(JetBrains.Annotations.CollectionAccessType collectionAccessType);

}

}
