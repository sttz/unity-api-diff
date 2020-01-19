using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public static class TypeCache
{
    static public MethodCollection GetMethodsWithAttribute(Type attrType);
    static public MethodCollection GetMethodsWithAttribute<T>();
    static public TypeCollection GetTypesDerivedFrom(Type parentType);
    static public TypeCollection GetTypesDerivedFrom<T>();
    static public TypeCollection GetTypesWithAttribute(Type attrType);
    static public TypeCollection GetTypesWithAttribute<T>();

    public struct MethodCollection : IList<System.Reflection.MethodInfo>, IList, ICollection<System.Reflection.MethodInfo>, IEnumerable<System.Reflection.MethodInfo>, IEnumerable, ICollection
    {
        public int Count { get; }
        public bool IsFixedSize { get; }
        public bool IsReadOnly { get; }
        public bool IsSynchronized { get; }
        public System.Reflection.MethodInfo this[int index] { get; set; }

        public bool Contains(object item);
        public bool Contains(System.Reflection.MethodInfo item);
        public void CopyTo(Array array, int arrayIndex);
        public void CopyTo(System.Reflection.MethodInfo[] array, int arrayIndex);
        public Enumerator GetEnumerator();
        public int IndexOf(object item);
        public int IndexOf(System.Reflection.MethodInfo item);

        public struct Enumerator : IEnumerator<System.Reflection.MethodInfo>, IEnumerator, IDisposable
        {
            public System.Reflection.MethodInfo Current { get; }

            public void Dispose();
            public bool MoveNext();

        }

    }

    public struct TypeCollection : IList<Type>, IList, ICollection<Type>, IEnumerable<Type>, IEnumerable, ICollection
    {
        public int Count { get; }
        public bool IsFixedSize { get; }
        public bool IsReadOnly { get; }
        public bool IsSynchronized { get; }
        public Type this[int index] { get; set; }

        public bool Contains(object item);
        public bool Contains(Type item);
        public void CopyTo(Array array, int arrayIndex);
        public void CopyTo(Type[] array, int arrayIndex);
        public Enumerator GetEnumerator();
        public int IndexOf(object item);
        public int IndexOf(Type item);

        public struct Enumerator : IEnumerator<Type>, IEnumerator, IDisposable
        {
            public Type Current { get; }

            public void Dispose();
            public bool MoveNext();

        }

    }

}

}
