using System;
using UnityEngine;

namespace UnityEditor.Sprites
{

public interface IPackerPolicy
{
    public bool AllowSequentialPacking { get; }

    public int GetVersion();
    public void OnGroupAtlases(UnityEditor.BuildTarget target, UnityEditor.Sprites.PackerJob job, int[] textureImporterInstanceIDs);

}

}
