using System;
using UnityEngine;

namespace UnityEngine
{

public enum ComputeBufferType
{
    Default = 0,
    Raw = 1,
    Append = 2,
    Counter = 4,
    Constant = 8,
    Structured = 16,
    DrawIndirect = 256,
    IndirectArguments = 256,
    GPUMemory = 512,
}

}
