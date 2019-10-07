using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public enum GraphicsJobsSyncPoint
{
    EndOfFrame = 0,
    AfterScriptUpdate = 1,
    AfterScriptLateUpdate = 2,
    WaitForPresent = 3,
}

}
