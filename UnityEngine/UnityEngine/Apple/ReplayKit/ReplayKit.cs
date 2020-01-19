using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Apple.ReplayKit
{

public static class ReplayKit
{
    static public bool APIAvailable { get; }
    static public bool broadcastingAPIAvailable { get; }
    static public string broadcastURL { get; }
    static public bool cameraEnabled { get; set; }
    static public bool isBroadcasting { get; }
    static public bool isRecording { get; }
    static public string lastError { get; }
    static public bool microphoneEnabled { get; set; }
    static public bool recordingAvailable { get; }

    static public bool Discard();
    static public void HideCameraPreview();
    static public bool Preview();
    static public bool ShowCameraPreviewAt(float posX, float posY);
    static public void StartBroadcasting(BroadcastStatusCallback callback);
    static public void StartBroadcasting(BroadcastStatusCallback callback, bool enableMicrophone);
    static public void StartBroadcasting(BroadcastStatusCallback callback, bool enableMicrophone, bool enableCamera);
    static public bool StartRecording();
    static public bool StartRecording(bool enableMicrophone);
    static public bool StartRecording(bool enableMicrophone, bool enableCamera);
    static public void StopBroadcasting();
    static public bool StopRecording();

    public delegate void BroadcastStatusCallback(bool hasStarted, string errorMessage);

}

}
