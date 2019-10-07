using System;
using UnityEngine;

namespace UnityEngine.Windows.Speech
{

public sealed class GrammarRecognizer : Windows.Speech.PhraseRecognizer
{
    public string GrammarFilePath { get; private set; }

    public GrammarRecognizer(string grammarFilePath);
    public GrammarRecognizer(string grammarFilePath, Windows.Speech.ConfidenceLevel minimumConfidence);

}

}
