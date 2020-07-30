using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.VFX
{

public struct VFXOutputEventArgs
{
    public VFX.VFXEventAttribute eventAttribute { get; }
    public int nameId { get; }

    public VFXOutputEventArgs(int nameId, VFX.VFXEventAttribute eventAttribute);

}

}
