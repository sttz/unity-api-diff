using System;
using System.Collections;
using System.Collections.Generic;
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
