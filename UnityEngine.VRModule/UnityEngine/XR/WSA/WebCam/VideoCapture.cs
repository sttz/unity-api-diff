using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR.WSA.WebCam
{

public class VideoCapture : IDisposable
{
    static public IEnumerable<Resolution> SupportedResolutions { get; }

    static public void CreateAsync(bool showHolograms, OnVideoCaptureResourceCreatedCallback onCreatedCallback);
    static public IEnumerable<float> GetSupportedFrameRatesForResolution(Resolution resolution);

    public bool IsRecording { get; }

    public void Dispose();
    public IntPtr GetUnsafePointerToVideoDeviceController();
    public void StartRecordingAsync(string filename, OnStartedRecordingVideoCallback onStartedRecordingVideoCallback);
    public void StartVideoModeAsync(XR.WSA.WebCam.CameraParameters setupParams, AudioState audioState, OnVideoModeStartedCallback onVideoModeStartedCallback);
    public void StopRecordingAsync(OnStoppedRecordingVideoCallback onStoppedRecordingVideoCallback);
    public void StopVideoModeAsync(OnVideoModeStoppedCallback onVideoModeStoppedCallback);

    public enum AudioState
    {
        MicAudio = 0,
        ApplicationAudio = 1,
        ApplicationAndMicAudio = 2,
        None = 3,
    }

    public enum CaptureResultType
    {
        Success = 0,
        UnknownError = 1,
    }

    public delegate void OnStartedRecordingVideoCallback(VideoCaptureResult result);

    public delegate void OnStoppedRecordingVideoCallback(VideoCaptureResult result);

    public delegate void OnVideoCaptureResourceCreatedCallback(XR.WSA.WebCam.VideoCapture captureObject);

    public delegate void OnVideoModeStartedCallback(VideoCaptureResult result);

    public delegate void OnVideoModeStoppedCallback(VideoCaptureResult result);

    public struct VideoCaptureResult
    {
        public long hResult;
        public CaptureResultType resultType;

        public bool success { get; }

    }

}

}
