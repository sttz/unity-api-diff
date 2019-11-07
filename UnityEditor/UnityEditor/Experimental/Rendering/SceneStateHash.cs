using System;
using UnityEngine;

namespace UnityEditor.Experimental.Rendering
{

public struct SceneStateHash : IEquatable<UnityEditor.Experimental.Rendering.SceneStateHash>
{
    public Hash128 ambientProbeHash { get; }
    public Hash128 sceneObjectsHash { get; }
    public Hash128 skySettingsHash { get; }

    public SceneStateHash(Hash128 sceneObjectsHash, Hash128 skySettingsHash, Hash128 ambientProbeHash);

    public bool Equals(UnityEditor.Experimental.Rendering.SceneStateHash other);
    public bool Equals(object obj);
    public int GetHashCode();

}

}
