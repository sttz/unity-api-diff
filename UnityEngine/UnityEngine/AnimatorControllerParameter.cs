using System;
using UnityEngine;

namespace UnityEngine
{

public class AnimatorControllerParameter
{
    public bool defaultBool { get; set; }
    public float defaultFloat { get; set; }
    public int defaultInt { get; set; }
    public string name { get; set; }
    public int nameHash { get; }
    public AnimatorControllerParameterType type { get; set; }

    public AnimatorControllerParameter();

    public bool Equals(object o);
    public int GetHashCode();

}

}
