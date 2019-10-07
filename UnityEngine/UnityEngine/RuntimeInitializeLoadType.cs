using System;
using UnityEngine;

namespace UnityEngine
{

public enum RuntimeInitializeLoadType
{
    AfterSceneLoad = 0,
    BeforeSceneLoad = 1,
    AfterAssembliesLoaded = 2,
    BeforeSplashScreen = 3,
    SubsystemRegistration = 4,
}

}
