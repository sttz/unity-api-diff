using System;
using UnityEngine;

namespace UnityEditor.VisualStudioIntegration
{

public static class SolutionGuidGenerator
{
    static public string GuidForProject(string projectName);
    static public string GuidForSolution(string projectName, string sourceFileExtension);

}

}
