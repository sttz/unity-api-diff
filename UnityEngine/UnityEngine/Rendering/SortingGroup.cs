using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public sealed class SortingGroup : Behaviour
{
    public int sortingLayerID { get; set; }
    public string sortingLayerName { get; set; }
    public int sortingOrder { get; set; }

    public SortingGroup();

}

}
