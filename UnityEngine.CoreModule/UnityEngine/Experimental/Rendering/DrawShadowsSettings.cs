using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public struct DrawShadowsSettings
{
    public int lightIndex;
    public Experimental.Rendering.ShadowSplitData splitData;

    public Experimental.Rendering.CullResults cullResults { set; }

    public DrawShadowsSettings(Experimental.Rendering.CullResults cullResults, int lightIndex);

}

}
