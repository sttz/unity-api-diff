using System;
using UnityEngine;

namespace UnityEngine.Windows.Speech
{

public enum SpeechError
{
    NoError = 0,
    TopicLanguageNotSupported = 1,
    GrammarLanguageMismatch = 2,
    GrammarCompilationFailure = 3,
    AudioQualityFailure = 4,
    PauseLimitExceeded = 5,
    TimeoutExceeded = 6,
    NetworkFailure = 7,
    MicrophoneUnavailable = 8,
    UnknownError = 9,
}

}
