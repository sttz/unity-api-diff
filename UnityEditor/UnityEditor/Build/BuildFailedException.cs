using System;
using UnityEngine;

namespace UnityEditor.Build
{

public class BuildFailedException : Exception
{
    public BuildFailedException(string message);
    public BuildFailedException(Exception innerException);

}

}
