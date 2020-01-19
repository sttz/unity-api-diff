using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.SceneManagement
{

public struct Scene
{
    public int buildIndex { get; }
    public int handle { get; }
    public bool isDirty { get; }
    public bool isLoaded { get; }
    public bool isSubScene { get; set; }
    public string name { get; set; }
    public string path { get; }
    public int rootCount { get; }

    public bool Equals(object other);
    public int GetHashCode();
    public GameObject[] GetRootGameObjects();
    public void GetRootGameObjects(List<GameObject> rootGameObjects);
    public bool IsValid();

}

}
