using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Windows.Speech
{

public enum DictationCompletionCause
{
    Complete = 0,
    AudioQualityFailure = 1,
    Canceled = 2,
    TimeoutExceeded = 3,
    PauseLimitExceeded = 4,
    NetworkFailure = 5,
    MicrophoneUnavailable = 6,
    UnknownError = 7,
}

}
