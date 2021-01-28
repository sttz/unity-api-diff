using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public class SearchIndexer
{
    public int documentCount { get; }
    public int keywordCount { get; }
    public int minWordIndexationLength { get; set; }
    public string name { get; set; }
    public Func<string, string> resolveDocumentHandler { get; set; }
    public Func<string, bool> skipEntryHandler { get; set; }

    public SearchIndexer();
    public SearchIndexer(string name);

    public int AddDocument(string document, bool checkIfExists = true);
    public void AddExactWord(string word, int score, int documentIndex);
    public void AddNumber(string key, double value, int score, int documentIndex);
    public void AddProperty(string key, string value, int documentIndex, bool saveKeyword = false, bool exact = true);
    public void AddProperty(string key, string value, int score, int documentIndex, bool saveKeyword = false, bool exact = true);
    public void AddProperty(string name, string value, int minVariations, int maxVariations, int score, int documentIndex, bool saveKeyword = false, bool exact = true);
    public void AddWord(string word, int score, int documentIndex);
    public void AddWord(string word, int size, int score, int documentIndex);
    public void AddWord(string word, int minVariations, int maxVariations, int score, int documentIndex);
    public void Finish();
    public void Finish(Action threadCompletedCallback);
    public void Finish(Action<byte[]> threadCompletedCallback, string[] removedDocuments);
    public UnityEditor.Search.SearchDocument GetDocument(int index);
    public string GetMetaInfo(string documentId);
    public void IndexDocument(string document, bool checkIfDocumentExists);
    public bool IsReady();
    public bool LoadBytes(byte[] bytes, Action<bool> finished);
    public bool Read(System.IO.Stream stream, bool checkVersionOnly);
    public byte[] SaveBytes();
    public IEnumerable<UnityEditor.Search.SearchResult> Search(string query, int maxScore = 2147483647, int patternMatchLimit = 2999);
    public IEnumerable<UnityEditor.Search.SearchResult> Search(UnityEditor.Search.SearchContext context, UnityEditor.Search.SearchProvider provider, int maxScore = 2147483647, int patternMatchLimit = 2999);
    public IEnumerable<UnityEditor.Search.SearchResult> Search(string query, UnityEditor.Search.SearchContext context, UnityEditor.Search.SearchProvider provider, int maxScore = 2147483647, int patternMatchLimit = 2999);
    public void SetMetaInfo(string documentId, string metadata);
    public bool SkipEntry(string document, bool checkRoots = false);
    public void Start(bool clear = false);
    public void Write(System.IO.Stream stream);

}

}
