using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngineInternal.Input
{

public struct NativeInputEvent
{
    public ushort deviceId;
    public int eventId;
    public ushort sizeInBytes;
    public double time;
    public UnityEngineInternal.Input.NativeInputEventType type;

    public NativeInputEvent(UnityEngineInternal.Input.NativeInputEventType type, int sizeInBytes, int deviceId, double time);

}

}
