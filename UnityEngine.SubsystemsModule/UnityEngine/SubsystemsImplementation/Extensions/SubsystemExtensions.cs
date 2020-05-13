using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.SubsystemsImplementation.Extensions
{

public static class SubsystemExtensions
{
    static public TProvider GetProvider<TSubsystem, TDescriptor, TProvider, TProviderToSubsystem>(SubsystemsImplementation.SubsystemWithProvider<TSubsystem, TDescriptor, TProvider, TProviderToSubsystem> subsystem);

}

}
