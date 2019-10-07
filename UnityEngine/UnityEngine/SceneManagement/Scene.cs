using System;
using UnityEngine;

namespace UnityEngine.SceneManagement
{

public struct Scene
{
    public int buildIndex { get; }
    public int handle { get; }
    public bool isDirty { get; }
    public bool isLoaded { get; }
    public string name { get; set; }
    public string path { get; }
    public int rootCount { get; }

    public bool Equals(object other);
    public int GetHashCode();
    public GameObject[] GetRootGameObjects();
    public void GetRootGameObjects(System.Collections.Generic.List<GameObject> rootGameObjects);
    public bool IsValid();

}

}
