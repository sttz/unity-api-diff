using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.VersionControl
{

public enum SubmitResult
{
    OK = 1,
    Error = 2,
    ConflictingFiles = 4,
    UnaddedFiles = 8,
}

}
