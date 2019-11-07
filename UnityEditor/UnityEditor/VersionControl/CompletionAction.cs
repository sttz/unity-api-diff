using System;
using UnityEngine;

namespace UnityEditor.VersionControl
{

public enum CompletionAction
{
    UpdatePendingWindow = 1,
    OnChangeContentsPendingWindow = 2,
    OnIncomingPendingWindow = 3,
    OnChangeSetsPendingWindow = 4,
    OnGotLatestPendingWindow = 5,
    OnSubmittedChangeWindow = 6,
    OnAddedChangeWindow = 7,
    OnCheckoutCompleted = 8,
}

}
