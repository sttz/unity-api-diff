using System;
using UnityEngine;

namespace UnityEditor.Experimental
{

public enum OnDemandState
{
    Unavailable = 0,
    Processing = 1,
    Downloading = 2,
    Available = 3,
    Failed = 4,
}

}
