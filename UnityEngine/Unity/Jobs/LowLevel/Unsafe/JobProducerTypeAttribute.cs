using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Jobs.LowLevel.Unsafe
{

public sealed class JobProducerTypeAttribute : Attribute
{
    public Type ProducerType { get; }

    public JobProducerTypeAttribute(Type producerType);

}

}
