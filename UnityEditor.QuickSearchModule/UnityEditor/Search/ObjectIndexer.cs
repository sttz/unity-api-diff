using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public abstract class ObjectIndexer : UnityEditor.Search.SearchIndexer
{
    public IEnumerable<string> GetEntryComponents(string entry, int documentIndex);
    public void IndexDocument(string id, bool checkIfDocumentExists);
    public void IndexNumber(int documentIndex, string name, double number);
    protected void IndexObject(int documentIndex, Object obj, bool dependencies = false);
    public void IndexProperty(int documentIndex, string name, string value, bool saveKeyword, bool exact = false);
    public void IndexPropertyComponents(int documentIndex, string name, string value);
    public void IndexWord(int documentIndex, string word, bool exact = false, int scoreModifier = 0);
    public void IndexWord(int documentIndex, string word, int maxVariations, bool exact, int scoreModifier = 0);
    public void IndexWordComponents(int documentIndex, string word);
    public IEnumerable<UnityEditor.Search.SearchResult> Search(string searchQuery, UnityEditor.Search.SearchContext context, UnityEditor.Search.SearchProvider provider, int maxScore = 2147483647, int patternMatchLimit = 2999);
    public bool SkipEntry(string path, bool checkRoots = false);

}

}
