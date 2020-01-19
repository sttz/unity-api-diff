using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Media
{

public class MediaEncoder : IDisposable
{
    public IntPtr m_Ptr;

    public MediaEncoder(string filePath, UnityEditor.Media.AudioTrackAttributes audioAttrs);
    public MediaEncoder(string filePath, UnityEditor.Media.AudioTrackAttributes[] audioAttrs);
    public MediaEncoder(string filePath, UnityEditor.Media.VideoTrackAttributes videoAttrs);
    public MediaEncoder(string filePath, UnityEditor.Media.VideoTrackAttributes videoAttrs, UnityEditor.Media.AudioTrackAttributes audioAttrs);
    public MediaEncoder(string filePath, UnityEditor.Media.VideoTrackAttributes videoAttrs, UnityEditor.Media.AudioTrackAttributes[] audioAttrs);

    public bool AddFrame(Texture2D texture);
    public bool AddFrame(int width, int height, int rowBytes, TextureFormat format, Unity.Collections.NativeArray<byte> data);
    public bool AddSamples(Unity.Collections.NativeArray<float> interleavedSamples);
    public bool AddSamples(ushort trackIndex, Unity.Collections.NativeArray<float> interleavedSamples);
    public void Dispose();

}

}
