using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class SpriteMask : Renderer
{
    public float alphaCutoff { get; set; }
    public int backSortingLayerID { get; set; }
    public int backSortingOrder { get; set; }
    public int frontSortingLayerID { get; set; }
    public int frontSortingOrder { get; set; }
    public bool isCustomRangeActive { get; set; }
    public Sprite sprite { get; set; }
    public SpriteSortPoint spriteSortPoint { get; set; }

    public SpriteMask();

}

}
