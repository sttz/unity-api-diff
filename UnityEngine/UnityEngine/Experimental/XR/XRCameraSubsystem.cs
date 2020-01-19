using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public class XRCameraSubsystem : Experimental.IntegratedSubsystem<Experimental.XR.XRCameraSubsystemDescriptor>
{
    public Camera Camera { get; set; }
    public int LastUpdatedFrame { get; }
    public bool LightEstimationRequested { get; set; }
    public Material Material { get; set; }

    public event Action<Experimental.XR.FrameReceivedEventArgs> FrameReceived;

    public XRCameraSubsystem();

    public void GetTextures(List<Texture2D> texturesOut);
    public bool TryGetAverageBrightness(float averageBrightness);
    public bool TryGetAverageColorTemperature(float averageColorTemperature);
    public bool TryGetDisplayMatrix(Matrix4x4 displayMatrix);
    public bool TryGetProjectionMatrix(Matrix4x4 projectionMatrix);
    public bool TryGetShaderName(string shaderName);
    public bool TryGetTimestamp(long timestampNs);

}

}
