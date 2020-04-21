using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public static class SearchService
{
    public interface IFilterEngine<T> : ISearchEngineBase
    {
        public bool Filter(string query, T objectToFilter, ISearchContext context);

    }

    public interface ISearchContext
    {
        public Guid guid { get; }
        public IEnumerable<string> requiredTypeNames { get; }
        public IEnumerable<Type> requiredTypes { get; }
        public string searchType { get; }

    }

    public interface ISearchEngine<T> : ISearchEngineBase
    {
        public IEnumerable<T> Search(string query, ISearchContext context, Action<IEnumerable<T>> asyncItemsReceived);

    }

    public interface ISearchEngineBase
    {
        public string displayName { get; }
        public string id { get; }

        public void BeginSearch(string query, ISearchContext context);
        public void BeginSession(ISearchContext context);
        public void EndSearch(ISearchContext context);
        public void EndSession(ISearchContext context);

    }

    public interface ISelectorEngine : ISearchEngineBase
    {
        public bool SelectObject(ISearchContext context, Action<Object, bool> onObjectSelectorClosed, Action<Object> onObjectSelectedUpdated);

    }

    public static class ObjectSelector
    {
        static public string searchType = "object-selector";

        static public void RegisterEngine(IEngine engine);
        static public void UnregisterEngine(IEngine engine);

        public class EngineAttribute : Attribute
        {
            public EngineAttribute();

        }

        public interface IEngine : ISelectorEngine, ISearchEngineBase
        {
        }

        public class SearchContext : ISearchContext
        {
            public IEnumerable<int> allowedInstanceIds { get; set; }
            public Object currentObject { get; set; }
            public Object editedObject { get; set; }
            public Guid guid { get; }
            public IEnumerable<string> requiredTypeNames { get; set; }
            public IEnumerable<Type> requiredTypes { get; set; }
            public string searchType { get; protected set; }
            public ShowedTypes showedTypes { get; set; }

            public SearchContext();

        }

        public enum ShowedTypes
        {
            Assets = 1,
            Scene = 2,
            All = 3,
        }

    }

    public static class Project
    {
        static public string searchType = "project";

        static public void RegisterEngine(IEngine engine);
        static public void UnregisterEngine(IEngine engine);

        public class EngineAttribute : Attribute
        {
            public EngineAttribute();

        }

        public interface IEngine : ISearchEngine<string>, ISearchEngineBase
        {
        }

        public class SearchContext : ISearchContext
        {
            public Guid guid { get; }
            public IEnumerable<string> requiredTypeNames { get; set; }
            public IEnumerable<Type> requiredTypes { get; set; }
            public string searchType { get; protected set; }

            public SearchContext();

        }

    }

    public static class Scene
    {
        static public string searchType = "scene";

        static public void RegisterEngine(IEngine engine);
        static public void UnregisterEngine(IEngine engine);

        public class EngineAttribute : Attribute
        {
            public EngineAttribute();

        }

        public interface IEngine : IFilterEngine<UnityEditor.HierarchyProperty>, ISearchEngineBase
        {
        }

        public class SearchContext : ISearchContext
        {
            public Guid guid { get; }
            public IEnumerable<string> requiredTypeNames { get; set; }
            public IEnumerable<Type> requiredTypes { get; set; }
            public UnityEditor.HierarchyProperty rootProperty { get; set; }
            public string searchType { get; protected set; }

            public SearchContext();

        }

    }

}

}
