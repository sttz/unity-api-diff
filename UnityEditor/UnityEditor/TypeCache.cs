using System;
using UnityEngine;

namespace UnityEditor
{

public static class TypeCache
{
    static public MethodCollection GetMethodsWithAttribute(Type attrType);
    static public MethodCollection GetMethodsWithAttribute();
    static public TypeCollection GetTypesDerivedFrom();
    static public TypeCollection GetTypesDerivedFrom(Type parentType);
    static public TypeCollection GetTypesWithAttribute(Type attrType);
    static public TypeCollection GetTypesWithAttribute();

    public struct TypeCollection : System.Collections.Generic.IList<Type>, System.Collections.Generic.ICollection<Type>, System.Collections.Generic.IEnumerable<Type>, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection
    {
        public int Count { get; }
        public bool IsFixedSize { get; }
        public bool IsReadOnly { get; }
        public bool IsSynchronized { get; }
        public Type this[int index] { get; set; }

        public bool Contains(Type item);
        public bool Contains(object item);
        public void CopyTo(Type[] array, int arrayIndex);
        public void CopyTo(Array array, int arrayIndex);
        public Enumerator GetEnumerator();
        public int IndexOf(Type item);
        public int IndexOf(object item);

        public struct Enumerator : System.Collections.Generic.IEnumerator<Type>, System.Collections.IEnumerator, IDisposable
        {
            public Type Current { get; }

            public void Dispose();
            public bool MoveNext();

        }

    }

    public struct MethodCollection : System.Collections.Generic.IList<System.Reflection.MethodInfo>, System.Collections.Generic.ICollection<System.Reflection.MethodInfo>, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection
    {
        public int Count { get; }
        public bool IsFixedSize { get; }
        public bool IsReadOnly { get; }
        public bool IsSynchronized { get; }
        public System.Reflection.MethodInfo this[int index] { get; set; }

        public bool Contains(System.Reflection.MethodInfo item);
        public bool Contains(object item);
        public void CopyTo(System.Reflection.MethodInfo[] array, int arrayIndex);
        public void CopyTo(Array array, int arrayIndex);
        public Enumerator GetEnumerator();
        public int IndexOf(System.Reflection.MethodInfo item);
        public int IndexOf(object item);

        public struct Enumerator : System.Collections.Generic.IEnumerator<System.Reflection.MethodInfo>, System.Collections.IEnumerator, IDisposable
        {
            public System.Reflection.MethodInfo Current { get; }

            public void Dispose();
            public bool MoveNext();

        }

    }

}

}
