using System;
using UnityEngine;

namespace UnityEditor.SceneManagement
{

public class SceneSetup
{
    public bool isActive { get; set; }
    public bool isLoaded { get; set; }
    public bool isSubScene { get; set; }
    public string path { get; set; }

    public SceneSetup();

}

}
