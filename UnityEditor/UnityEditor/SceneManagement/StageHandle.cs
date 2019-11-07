using System;
using UnityEngine;

namespace UnityEditor.SceneManagement
{

public struct StageHandle : IEquatable<UnityEditor.SceneManagement.StageHandle>
{
    public bool Contains(GameObject gameObject);
    public bool Equals(object other);
    public bool Equals(UnityEditor.SceneManagement.StageHandle other);
    public T FindComponentOfType();
    public T[] FindComponentsOfType();
    public int GetHashCode();
    public bool IsValid();

}

}
