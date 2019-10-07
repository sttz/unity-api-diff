using System;
using UnityEngine;

namespace UnityEngine.Windows.Speech
{

public sealed class KeywordRecognizer : Windows.Speech.PhraseRecognizer
{
    public System.Collections.Generic.IEnumerable<string> Keywords { get; private set; }

    public KeywordRecognizer(string[] keywords);
    public KeywordRecognizer(string[] keywords, Windows.Speech.ConfidenceLevel minimumConfidence);

}

}
