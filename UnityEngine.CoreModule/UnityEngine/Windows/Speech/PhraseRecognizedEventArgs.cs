using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Windows.Speech
{

public struct PhraseRecognizedEventArgs
{
    public Windows.Speech.ConfidenceLevel confidence;
    public TimeSpan phraseDuration;
    public DateTime phraseStartTime;
    public Windows.Speech.SemanticMeaning[] semanticMeanings;
    public string text;

}

}
