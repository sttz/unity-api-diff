using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.SubsystemsImplementation
{

public class SubsystemProxy<TSubsystem, TProvider>
{
    public TProvider provider { get; private set; }
    public bool running { get; set; }

}

}
