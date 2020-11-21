using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetBrains.Annotations
{

public enum CollectionAccessType
{
    None = 0,
    Read = 1,
    ModifyExistingContent = 2,
    UpdatedContent = 6,
}

}
