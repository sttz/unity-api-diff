using System;
using UnityEngine;

namespace UnityEngineInternal.Input
{

public class NativeInputSystem
{
    static public Action<UnityEngineInternal.Input.NativeInputUpdateType> onBeforeUpdate;
    static public UnityEngineInternal.Input.NativeUpdateCallback onUpdate;

    static public double currentTime { get; }
    static public double currentTimeOffsetToRealtimeSinceStartup { get; }
    static public Action<int, string> onDeviceDiscovered { get; set; }

    static public int AllocateDeviceId();
    static public long IOCTL(int deviceId, int code, IntPtr data, int sizeInBytes);
    static public void QueueInputEvent(TInputEvent& inputEvent);
    static public void QueueInputEvent(IntPtr inputEvent);
    static public void SetPollingFrequency(float hertz);
    static public void SetUpdateMask(UnityEngineInternal.Input.NativeInputUpdateType mask);
    static public void Update(UnityEngineInternal.Input.NativeInputUpdateType updateType);

    public NativeInputSystem();

}

}
