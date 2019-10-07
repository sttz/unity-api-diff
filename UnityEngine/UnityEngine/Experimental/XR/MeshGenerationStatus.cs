using System;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public enum MeshGenerationStatus
{
    Success = 0,
    InvalidMeshId = 1,
    GenerationAlreadyInProgress = 2,
    Canceled = 3,
    UnknownError = 4,
}

}
