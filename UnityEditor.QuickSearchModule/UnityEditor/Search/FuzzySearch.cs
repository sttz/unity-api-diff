using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public static class FuzzySearch
{
    static public bool FuzzyMatch(string pattern, string origin, long outScore, List<int> matches = null);

}

}
