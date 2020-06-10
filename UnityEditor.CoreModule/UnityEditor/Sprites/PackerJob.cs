using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Sprites
{

public sealed class PackerJob
{
    public void AddAtlas(string atlasName, UnityEditor.Sprites.AtlasSettings settings);
    public void AssignToAtlas(string atlasName, Sprite sprite, SpritePackingMode packingMode, SpritePackingRotation packingRotation);

}

}
