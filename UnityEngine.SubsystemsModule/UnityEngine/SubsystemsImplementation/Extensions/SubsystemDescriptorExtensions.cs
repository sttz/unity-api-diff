using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.SubsystemsImplementation.Extensions
{

public static class SubsystemDescriptorExtensions
{
    static public SubsystemsImplementation.SubsystemProxy<TSubsystem, TProvider> CreateProxy<TSubsystem, TProvider>(SubsystemsImplementation.SubsystemDescriptorWithProvider<TSubsystem, TProvider> descriptor);

}

}
