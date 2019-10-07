using System;
using UnityEngine;

namespace Unity.Jobs.LowLevel.Unsafe
{

public sealed class JobProducerTypeAttribute : Attribute
{
    public Type ProducerType { get; }

    public JobProducerTypeAttribute(Type producerType);

}

}
