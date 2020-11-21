using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build
{

public class BuildFailedException : Exception
{
    public BuildFailedException(Exception innerException);
    public BuildFailedException(string message);

}

}
