using System;
using UnityEngine;

namespace UnityEngine.Windows.Speech
{

public static class PhraseRecognitionSystem
{
    static public bool isSupported { get; }
    static public Windows.Speech.SpeechSystemStatus Status { get; }

    static public event ErrorDelegate OnError;
    static public event StatusDelegate OnStatusChanged;

    static public void Restart();
    static public void Shutdown();

    public delegate void ErrorDelegate(Windows.Speech.SpeechError errorCode);

    public delegate void StatusDelegate(Windows.Speech.SpeechSystemStatus status);

}

}
