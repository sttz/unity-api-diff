using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public enum LightEvent
{
    BeforeShadowMap = 0,
    AfterShadowMap = 1,
    BeforeScreenspaceMask = 2,
    AfterScreenspaceMask = 3,
    BeforeShadowMapPass = 4,
    AfterShadowMapPass = 5,
}

}
