using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Windows.Speech
{

public sealed class DictationRecognizer : IDisposable
{
    public float AutoSilenceTimeoutSeconds { get; set; }
    public float InitialSilenceTimeoutSeconds { get; set; }
    public Windows.Speech.SpeechSystemStatus Status { get; }

    public event DictationCompletedDelegate DictationComplete;
    public event DictationErrorHandler DictationError;
    public event DictationHypothesisDelegate DictationHypothesis;
    public event DictationResultDelegate DictationResult;

    public DictationRecognizer();
    public DictationRecognizer(Windows.Speech.ConfidenceLevel confidenceLevel);
    public DictationRecognizer(Windows.Speech.DictationTopicConstraint topic);
    public DictationRecognizer(Windows.Speech.ConfidenceLevel minimumConfidence, Windows.Speech.DictationTopicConstraint topic);

    public void Dispose();
    public void Start();
    public void Stop();

    public delegate void DictationCompletedDelegate(Windows.Speech.DictationCompletionCause cause);

    public delegate void DictationErrorHandler(string error, int hresult);

    public delegate void DictationHypothesisDelegate(string text);

    public delegate void DictationResultDelegate(string text, Windows.Speech.ConfidenceLevel confidence);

}

}
