using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Windows.Speech
{

public abstract class PhraseRecognizer : IDisposable
{
    static protected IntPtr CreateFromGrammarFile(object self, string grammarFilePath, Windows.Speech.ConfidenceLevel minimumConfidence);
    static protected IntPtr CreateFromKeywords(object self, string[] keywords, Windows.Speech.ConfidenceLevel minimumConfidence);

    protected IntPtr m_Recognizer;

    public bool IsRunning { get; }

    public event PhraseRecognizedDelegate OnPhraseRecognized;

    public void Dispose();
    public void Start();
    public void Stop();

    public delegate void PhraseRecognizedDelegate(Windows.Speech.PhraseRecognizedEventArgs args);

}

}
