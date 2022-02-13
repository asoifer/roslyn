// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Emit;
using Roslyn.Test.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
    public abstract class CompilingTestBase : CSharpTestBase
    {
        private const string
        DefaultTypeName = "C"
        ;

        private const string
        DefaultMethodName = "M"
        ;

        internal static BoundBlock ParseAndBindMethodBody(string program, string typeName = DefaultTypeName, string methodName = DefaultMethodName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21002, 861, 2026);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21002, 1025, 1070);

                var
                compilation = f_21002_1043_1069(program)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21002, 1084, 1205);

                var
                method = (MethodSymbol)f_21002_1111_1195(f_21002_1111_1163(f_21002_1111_1138(compilation), typeName).Single(), methodName).Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21002, 1300, 1673);

                var
                module = f_21002_1313_1672((SourceAssemblySymbol)f_21002_1375_1395(compilation), emitOptions: EmitOptions.Default, outputKind: OutputKind.ConsoleApplication, serializationProperties: f_21002_1550_1594(), manifestResources: f_21002_1632_1671())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21002, 1689, 1798);

                TypeCompilationState
                compilationState = f_21002_1729_1797(f_21002_1754_1775(method), compilation, module)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21002, 1814, 1860);

                var
                diagnostics = f_21002_1832_1859()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21002, 1874, 1955);

                var
                block = f_21002_1886_1954(method, compilationState, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21002, 1969, 1988);

                f_21002_1969_1987(diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21002, 2002, 2015);

                return block;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21002, 861, 2026);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21002, 861, 2026);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21002, 861, 2026);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string DumpDiagnostic(Diagnostic diagnostic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21002, 2038, 2400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21002, 2121, 2389);

                return f_21002_2128_2388("'{0}' {1}", f_21002_2172_2253(f_21002_2172_2212(f_21002_2172_2202(f_21002_2172_2191(diagnostic))), f_21002_2222_2252(f_21002_2222_2241(diagnostic))), f_21002_2272_2387(DiagnosticFormatter.Instance, f_21002_2308_2346(diagnostic, f_21002_2332_2345()), f_21002_2348_2386()));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21002, 2038, 2400);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21002, 2038, 2400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21002, 2038, 2400);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Obsolete("Use VerifyDiagnostics", true)]
        public static void TestDiagnostics(IEnumerable<Diagnostic> diagnostics, params string[] diagStrings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21002, 2412, 2666);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21002, 2588, 2655);

                f_21002_2588_2654(diagStrings, f_21002_2619_2653(diagnostics, DumpDiagnostic));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21002, 2412, 2666);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21002, 2412, 2666);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21002, 2412, 2666);
            }
        }

        [Obsolete("Use VerifyDiagnostics", true)]
        public void TestAllErrors(string code, params string[] errors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21002, 2738, 3066);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21002, 2876, 2918);

                var
                compilation = f_21002_2894_2917(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21002, 2932, 2979);

                var
                diagnostics = f_21002_2950_2978(compilation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21002, 2993, 3055);

                f_21002_2993_3054(errors, diagnostics.Select(DumpDiagnostic));
                DynAbs.Tracing.TraceSender.TraceExitMethod(21002, 2738, 3066);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21002, 2738, 3066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21002, 2738, 3066);
            }
        }

        public const string
        LINQ =
                 @"using System;
using System.Text;

public delegate R Func1<in T1, out R>(T1 arg1);
public delegate R Func1<in T1, in T2, out R>(T1 arg1, T2 arg2);

public class List1<T>
{
    internal T[] data;
    internal int length;

    public List1(params T[] args)
    {
        this.data = (T[])args.Clone();
        this.length = data.Length;
    }

    public List1()
    {
        this.data = new T[0];
        this.length = 0;
    }

    public int Length { get { return length; } }

    //public T this[int index] { get { return this.data[index]; } }
    public T Get(int index) { return this.data[index]; }

    public virtual void Add(T t)
    {
        if (data.Length == length) Array.Resize(ref data, data.Length * 2 + 1);
        data[length++] = t;
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append('[');
        for (int i = 0; i < Length; i++)
        {
            if (i != 0) builder.Append(',').Append(' ');
            builder.Append(data[i]);
        }
        builder.Append(']');
        return builder.ToString();
    }

    public List1<E> Cast<E>()
    {
        E[] data = new E[Length];
        for (int i = 0; i < Length; i++)
            data[i] = (E)(object)this.data[i];
        return new List1<E>(data);
    }

    public List1<T> Where(Func1<T, bool> predicate)
    {
        List1<T> result = new List1<T>();
        for (int i = 0; i < Length; i++)
        {
            T datum = this.data[i];
            if (predicate(datum)) result.Add(datum);
        }
        return result;
    }

    public List1<U> Select<U>(Func1<T, U> selector)
    {
        int length = this.Length;
        U[] data = new U[length];
        for (int i = 0; i < length; i++) data[i] = selector(this.data[i]);
        return new List1<U>(data);
    }

    public List1<V> SelectMany<U, V>(Func1<T, List1<U>> selector, Func1<T, U, V> resultSelector)
    {
        List1<V> result = new List1<V>();
        int length = this.Length;
        for (int i = 0; i < length; i++)
        {
            T t = this.data[i];
            List1<U> selected = selector(t);
            int ulength = selected.Length;
            for (int j = 0; j < ulength; j++)
            {
                U u = selected.data[j];
                V v = resultSelector(t, u);
                result.Add(v);
            }
        }

        return result;
    }

    public List1<V> Join<U, K, V>(List1<U> inner, Func1<T, K> outerKeyselector,
        Func1<U, K> innerKeyselector, Func1<T, U, V> resultSelector)
    {
        List1<Joined<K, T, U>> joined = new List1<Joined<K, T, U>>();
        for (int i = 0; i < Length; i++)
        {
            T t = this.Get(i);
            K k = outerKeyselector(t);
            Joined<K, T, U> row = null;
            for (int j = 0; j < joined.Length; j++)
            {
                if (joined.Get(j).k.Equals(k))
                {
                    row = joined.Get(j);
                    break;
                }
            }
            if (row == null) joined.Add(row = new Joined<K, T, U>(k));
            row.t.Add(t);
        }
        for (int i = 0; i < inner.Length; i++)
        {
            U u = inner.Get(i);
            K k = innerKeyselector(u);
            Joined<K, T, U> row = null;
            for (int j = 0; j < joined.Length; j++)
            {
                if (joined.Get(j).k.Equals(k))
                {
                    row = joined.Get(j);
                    break;
                }
            }
            if (row == null) joined.Add(row = new Joined<K, T, U>(k));
            row.u.Add(u);
        }
        List1<V> result = new List1<V>();
        for (int i = 0; i < joined.Length; i++)
        {
            Joined<K, T, U> row = joined.Get(i);
            for (int j = 0; j < row.t.Length; j++)
            {
                T t = row.t.Get(j);
                for (int k = 0; k < row.u.Length; k++)
                {
                    U u = row.u.Get(k);
                    V v = resultSelector(t, u);
                    result.Add(v);
                }
            }
        }
        return result;
    }

    class Joined<K, T2, U>
    {
        public Joined(K k)
        {
            this.k = k;
            this.t = new List1<T2>();
            this.u = new List1<U>();
        }
        public readonly K k;
        public readonly List1<T2> t;
        public readonly List1<U> u;
    }

    public List1<V> GroupJoin<U, K, V>(List1<U> inner, Func1<T, K> outerKeyselector,
        Func1<U, K> innerKeyselector, Func1<T, List1<U>, V> resultSelector)
    {
        List1<Joined<K, T, U>> joined = new List1<Joined<K, T, U>>();
        for (int i = 0; i < Length; i++)
        {
            T t = this.Get(i);
            K k = outerKeyselector(t);
            Joined<K, T, U> row = null;
            for (int j = 0; j < joined.Length; j++)
            {
                if (joined.Get(j).k.Equals(k))
                {
                    row = joined.Get(j);
                    break;
                }
            }
            if (row == null) joined.Add(row = new Joined<K, T, U>(k));
            row.t.Add(t);
        }
        for (int i = 0; i < inner.Length; i++)
        {
            U u = inner.Get(i);
            K k = innerKeyselector(u);
            Joined<K, T, U> row = null;
            for (int j = 0; j < joined.Length; j++)
            {
                if (joined.Get(j).k.Equals(k))
                {
                    row = joined.Get(j);
                    break;
                }
            }
            if (row == null) joined.Add(row = new Joined<K, T, U>(k));
            row.u.Add(u);
        }
        List1<V> result = new List1<V>();
        for (int i = 0; i < joined.Length; i++)
        {
            Joined<K, T, U> row = joined.Get(i);
            for (int j = 0; j < row.t.Length; j++)
            {
                T t = row.t.Get(j);
                V v = resultSelector(t, row.u);
                result.Add(v);
            }
        }
        return result;
    }

    public OrderedList1<T> OrderBy<K>(Func1<T, K> Keyselector)
    {
        OrderedList1<T> result = new OrderedList1<T>(this);
        result.ThenBy(Keyselector);
        return result;
    }

    public OrderedList1<T> OrderByDescending<K>(Func1<T, K> Keyselector)
    {
        OrderedList1<T> result = new OrderedList1<T>(this);
        result.ThenByDescending(Keyselector);
        return result;
    }

    public List1<Group1<K, T>> GroupBy<K>(Func1<T, K> Keyselector)
    {
        List1<Group1<K, T>> result = new List1<Group1<K, T>>();
        for (int i = 0; i < Length; i++)
        {
            T t = this.Get(i);
            K k = Keyselector(t);
            Group1<K, T> Group1 = null;
            for (int j = 0; j < result.Length; j++)
            {
                if (result.Get(j).Key.Equals(k))
                {
                    Group1 = result.Get(j);
                    break;
                }
            }
            if (Group1 == null)
            {
                result.Add(Group1 = new Group1<K, T>(k));
            }
            Group1.Add(t);
        }
        return result;
    }

    public List1<Group1<K, E>> GroupBy<K, E>(Func1<T, K> Keyselector,
        Func1<T, E> elementSelector)
    {
        List1<Group1<K, E>> result = new List1<Group1<K, E>>();
        for (int i = 0; i < Length; i++)
        {
            T t = this.Get(i);
            K k = Keyselector(t);
            Group1<K, E> Group1 = null;
            for (int j = 0; j < result.Length; j++)
            {
                if (result.Get(j).Key.Equals(k))
                {
                    Group1 = result.Get(j);
                    break;
                }
            }
            if (Group1 == null)
            {
                result.Add(Group1 = new Group1<K, E>(k));
            }
            Group1.Add(elementSelector(t));
        }
        return result;
    }
}

public class OrderedList1<T> : List1<T>
{
    private List1<Keys1> Keys1;

    public override void Add(T t)
    {
        throw new NotSupportedException();
    }

    internal OrderedList1(List1<T> list)
    {
        Keys1 = new List1<Keys1>();
        for (int i = 0; i < list.Length; i++)
        {
            base.Add(list.Get(i));
            Keys1.Add(new Keys1());
        }
    }

    public OrderedList1<T> ThenBy<K>(Func1<T, K> Keyselector)
    {
        for (int i = 0; i < Length; i++)
        {
            object o = Keyselector(this.Get(i)); // work around bug 8405
            Keys1.Get(i).Add((IComparable)o);
        }
        Sort();
        return this;
    }

    class ReverseOrder : IComparable
    {
        IComparable c;
        public ReverseOrder(IComparable c)
        {
            this.c = c;
        }
        public int CompareTo(object o)
        {
            ReverseOrder other = (ReverseOrder)o;
            return other.c.CompareTo(this.c);
        }
        public override string ToString()
        {
            return String.Empty + '-' + c;
        }
    }

    public OrderedList1<T> ThenByDescending<K>(Func1<T, K> Keyselector)
    {
        for (int i = 0; i < Length; i++)
        {
            object o = Keyselector(this.Get(i)); // work around bug 8405
            Keys1.Get(i).Add(new ReverseOrder((IComparable)o));
        }
        Sort();
        return this;
    }

    void Sort()
    {
        Array.Sort(this.Keys1.data, this.data, 0, Length);
    }
}

class Keys1 : List1<IComparable>, IComparable
{
    public int CompareTo(object o)
    {
        Keys1 other = (Keys1)o;
        for (int i = 0; i < Length; i++)
        {
            int c = this.Get(i).CompareTo(other.Get(i));
            if (c != 0) return c;
        }
        return 0;
    }
}

public class Group1<K, T> : List1<T>
{
    public Group1(K k, params T[] data)
        : base(data)
    {
        this.Key = k;
    }

    public K Key { get; private set; }

    public override string ToString()
    {
        return Key + String.Empty + ':' + base.ToString();
    }
}

//public delegate R Func2<in T1, out R>(T1 arg1);
//public delegate R Func2<in T1, in T2, out R>(T1 arg1, T2 arg2);
//
//public class List2<T>
//{
//    internal T[] data;
//    internal int length;
//
//    public List2(params T[] args)
//    {
//        this.data = (T[])args.Clone();
//        this.length = data.Length;
//    }
//
//    public List2()
//    {
//        this.data = new T[0];
//        this.length = 0;
//    }
//
//    public int Length { get { return length; } }
//
//    //public T this[int index] { get { return this.data[index]; } }
//    public T Get(int index) { return this.data[index]; }
//
//    public virtual void Add(T t)
//    {
//        if (data.Length == length) Array.Resize(ref data, data.Length * 2 + 1);
//        data[length++] = t;
//    }
//
//    public override string ToString()
//    {
//        StringBuilder builder = new StringBuilder();
//        builder.Append('[');
//        for (int i = 0; i < Length; i++)
//        {
//            if (i != 0) builder.Append(',').Append(' ');
//            builder.Append(data[i]);
//        }
//        builder.Append(']');
//        return builder.ToString();
//    }
//
//}
//
//public class OrderedList2<T> : List2<T>
//{
//    internal List2<Keys2> Keys2;
//
//    public override void Add(T t)
//    {
//        throw new NotSupportedException();
//    }
//
//    internal OrderedList2(List2<T> list)
//    {
//        Keys2 = new List2<Keys2>();
//        for (int i = 0; i < list.Length; i++)
//        {
//            base.Add(list.Get(i));
//            Keys2.Add(new Keys2());
//        }
//    }
//
//    internal void Sort()
//    {
//        Array.Sort(this.Keys2.data, this.data, 0, Length);
//    }
//}
//
//class Keys2 : List2<IComparable>, IComparable
//{
//    public int CompareTo(object o)
//    {
//        Keys2 other = (Keys2)o;
//        for (int i = 0; i < Length; i++)
//        {
//            int c = this.Get(i).CompareTo(other.Get(i));
//            if (c != 0) return c;
//        }
//        return 0;
//    }
//}
//
//public class Group2<K, T> : List2<T>
//{
//    public Group2(K k, params T[] data)
//        : base(data)
//    {
//        this.Key = k;
//    }
//
//    public K Key { get; private set; }
//
//    public override string ToString()
//    {
//        return Key + String.Empty + ':' + base.ToString();
//    }
//}
//
//public static class Extensions2
//{
//
//    public static List2<E> Cast<T, E>(this List2<T> _this)
//    {
//        E[] data = new E[_this.Length];
//        for (int i = 0; i < _this.Length; i++)
//            data[i] = (E)(object)_this.data[i];
//        return new List2<E>(data);
//    }
//
//    public static List2<T> Where<T>(this List2<T> _this, Func2<T, bool> predicate)
//    {
//        List2<T> result = new List2<T>();
//        for (int i = 0; i < _this.Length; i++)
//        {
//            T datum = _this.data[i];
//            if (predicate(datum)) result.Add(datum);
//        }
//        return result;
//    }
//
//    public static List2<U> Select<T,U>(this List2<T> _this, Func2<T, U> selector)
//    {
//        int length = _this.Length;
//        U[] data = new U[length];
//        for (int i = 0; i < length; i++) data[i] = selector(_this.data[i]);
//        return new List2<U>(data);
//    }
//
//    public static List2<V> SelectMany<T, U, V>(this List2<T> _this, Func2<T, List2<U>> selector, Func2<T, U, V> resultSelector)
//    {
//        List2<V> result = new List2<V>();
//        int length = _this.Length;
//        for (int i = 0; i < length; i++)
//        {
//            T t = _this.data[i];
//            List2<U> selected = selector(t);
//            int ulength = selected.Length;
//            for (int j = 0; j < ulength; j++)
//            {
//                U u = selected.data[j];
//                V v = resultSelector(t, u);
//                result.Add(v);
//            }
//        }
//
//        return result;
//    }
//
//    public static List2<V> Join<T, U, K, V>(this List2<T> _this, List2<U> inner, Func2<T, K> outerKeyselector,
//        Func2<U, K> innerKeyselector, Func2<T, U, V> resultSelector)
//    {
//        List2<Joined<K, T, U>> joined = new List2<Joined<K, T, U>>();
//        for (int i = 0; i < _this.Length; i++)
//        {
//            T t = _this.Get(i);
//            K k = outerKeyselector(t);
//            Joined<K, T, U> row = null;
//            for (int j = 0; j < joined.Length; j++)
//            {
//                if (joined.Get(j).k.Equals(k))
//                {
//                    row = joined.Get(j);
//                    break;
//                }
//            }
//            if (row == null) joined.Add(row = new Joined<K, T, U>(k));
//            row.t.Add(t);
//        }
//        for (int i = 0; i < inner.Length; i++)
//        {
//            U u = inner.Get(i);
//            K k = innerKeyselector(u);
//            Joined<K, T, U> row = null;
//            for (int j = 0; j < joined.Length; j++)
//            {
//                if (joined.Get(j).k.Equals(k))
//                {
//                    row = joined.Get(j);
//                    break;
//                }
//            }
//            if (row == null) joined.Add(row = new Joined<K, T, U>(k));
//            row.u.Add(u);
//        }
//        List2<V> result = new List2<V>();
//        for (int i = 0; i < joined.Length; i++)
//        {
//            Joined<K, T, U> row = joined.Get(i);
//            for (int j = 0; j < row.t.Length; j++)
//            {
//                T t = row.t.Get(j);
//                for (int k = 0; k < row.u.Length; k++)
//                {
//                    U u = row.u.Get(k);
//                    V v = resultSelector(t, u);
//                    result.Add(v);
//                }
//            }
//        }
//        return result;
//    }
//
//    class Joined<K, T2, U>
//    {
//        public Joined(K k)
//        {
//            this.k = k;
//            this.t = new List2<T2>();
//            this.u = new List2<U>();
//        }
//        public readonly K k;
//        public readonly List2<T2> t;
//        public readonly List2<U> u;
//    }
//
//    public static List2<V> GroupJoin<T, U, K, V>(this List2<T> _this, List2<U> inner, Func2<T, K> outerKeyselector,
//        Func2<U, K> innerKeyselector, Func2<T, List2<U>, V> resultSelector)
//    {
//        List2<Joined<K, T, U>> joined = new List2<Joined<K, T, U>>();
//        for (int i = 0; i < _this.Length; i++)
//        {
//            T t = _this.Get(i);
//            K k = outerKeyselector(t);
//            Joined<K, T, U> row = null;
//            for (int j = 0; j < joined.Length; j++)
//            {
//                if (joined.Get(j).k.Equals(k))
//                {
//                    row = joined.Get(j);
//                    break;
//                }
//            }
//            if (row == null) joined.Add(row = new Joined<K, T, U>(k));
//            row.t.Add(t);
//        }
//        for (int i = 0; i < inner.Length; i++)
//        {
//            U u = inner.Get(i);
//            K k = innerKeyselector(u);
//            Joined<K, T, U> row = null;
//            for (int j = 0; j < joined.Length; j++)
//            {
//                if (joined.Get(j).k.Equals(k))
//                {
//                    row = joined.Get(j);
//                    break;
//                }
//            }
//            if (row == null) joined.Add(row = new Joined<K, T, U>(k));
//            row.u.Add(u);
//        }
//        List2<V> result = new List2<V>();
//        for (int i = 0; i < joined.Length; i++)
//        {
//            Joined<K, T, U> row = joined.Get(i);
//            for (int j = 0; j < row.t.Length; j++)
//            {
//                T t = row.t.Get(j);
//                V v = resultSelector(t, row.u);
//                result.Add(v);
//            }
//        }
//        return result;
//    }
//
//    public static OrderedList2<T> OrderBy<T, K>(this List2<T> _this, Func2<T, K> Keyselector)
//    {
//        OrderedList2<T> result = new OrderedList2<T>(_this);
//        result.ThenBy(Keyselector);
//        return result;
//    }
//
//    public static OrderedList2<T> OrderByDescending<T, K>(this List2<T> _this, Func2<T, K> Keyselector)
//    {
//        OrderedList2<T> result = new OrderedList2<T>(_this);
//        result.ThenByDescending(Keyselector);
//        return result;
//    }
//
//    public static List2<Group2<K, T>> GroupBy<T, K>(this List2<T> _this, Func2<T, K> Keyselector)
//    {
//        List2<Group2<K, T>> result = new List2<Group2<K, T>>();
//        for (int i = 0; i < _this.Length; i++)
//        {
//            T t = _this.Get(i);
//            K k = Keyselector(t);
//            Group2<K, T> Group2 = null;
//            for (int j = 0; j < result.Length; j++)
//            {
//                if (result.Get(j).Key.Equals(k))
//                {
//                    Group2 = result.Get(j);
//                    break;
//                }
//            }
//            if (Group2 == null)
//            {
//                result.Add(Group2 = new Group2<K, T>(k));
//            }
//            Group2.Add(t);
//        }
//        return result;
//    }
//
//    public static List2<Group2<K, E>> GroupBy<T, K, E>(this List2<T> _this, Func2<T, K> Keyselector,
//        Func2<T, E> elementSelector)
//    {
//        List2<Group2<K, E>> result = new List2<Group2<K, E>>();
//        for (int i = 0; i < _this.Length; i++)
//        {
//            T t = _this.Get(i);
//            K k = Keyselector(t);
//            Group2<K, E> Group2 = null;
//            for (int j = 0; j < result.Length; j++)
//            {
//                if (result.Get(j).Key.Equals(k))
//                {
//                    Group2 = result.Get(j);
//                    break;
//                }
//            }
//            if (Group2 == null)
//            {
//                result.Add(Group2 = new Group2<K, E>(k));
//            }
//            Group2.Add(elementSelector(t));
//        }
//        return result;
//    }
//
//    public static OrderedList2<T> ThenBy<T, K>(this OrderedList2<T> _this, Func2<T, K> Keyselector)
//    {
//        for (int i = 0; i < _this.Length; i++)
//        {
//            object o = Keyselector(_this.Get(i)); // work around bug 8405
//            _this.Keys2.Get(i).Add((IComparable)o);
//        }
//        _this.Sort();
//        return _this;
//    }
//
//    class ReverseOrder : IComparable
//    {
//        IComparable c;
//        public ReverseOrder(IComparable c)
//        {
//            this.c = c;
//        }
//        public int CompareTo(object o)
//        {
//            ReverseOrder other = (ReverseOrder)o;
//            return other.c.CompareTo(this.c);
//        }
//        public override string ToString()
//        {
//            return String.Empty + '-' + c;
//        }
//    }
//
//    public static OrderedList2<T> ThenByDescending<T, K>(this OrderedList2<T> _this, Func2<T, K> Keyselector)
//    {
//        for (int i = 0; i < _this.Length; i++)
//        {
//            object o = Keyselector(_this.Get(i)); // work around bug 8405
//            _this.Keys2.Get(i).Add(new ReverseOrder((IComparable)o));
//        }
//        _this.Sort();
//        return _this;
//    }
//
//}
"
                ;

        public CompilingTestBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(21002, 678, 25421);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(21002, 678, 25421);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21002, 678, 25421);
        }


        static CompilingTestBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21002, 678, 25421);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21002, 772, 793);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21002, 825, 848);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21002, 3098, 25375);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21002, 678, 25421);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21002, 678, 25421);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(21002, 678, 25421);

        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21002_1043_1069(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21002, 1043, 1069);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        f_21002_1111_1138(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.GlobalNamespace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21002, 1111, 1138);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        f_21002_1111_1163(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        this_param, string
        name)
        {
            var return_v = this_param.GetTypeMembers(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21002, 1111, 1163);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_21002_1111_1195(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param, string
        name)
        {
            var return_v = this_param.GetMembers(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21002, 1111, 1195);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_21002_1375_1395(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.Assembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21002, 1375, 1395);
            return return_v;
        }


        static Microsoft.Cci.ModulePropertiesForSerialization
        f_21002_1550_1594()
        {
            var return_v = GetDefaultModulePropertiesForSerialization();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21002, 1550, 1594);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
        f_21002_1632_1671()
        {
            var return_v = Enumerable.Empty<ResourceDescription>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21002, 1632, 1671);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilder
        f_21002_1313_1672(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        sourceAssembly, Microsoft.CodeAnalysis.Emit.EmitOptions
        emitOptions, Microsoft.CodeAnalysis.OutputKind
        outputKind, Microsoft.Cci.ModulePropertiesForSerialization
        serializationProperties, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
        manifestResources)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilder((Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol)sourceAssembly, emitOptions: emitOptions, outputKind: outputKind, serializationProperties: serializationProperties, manifestResources: manifestResources);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21002, 1313, 1672);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_21002_1754_1775(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21002, 1754, 1775);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.TypeCompilationState
        f_21002_1729_1797(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        typeOpt, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilder
        moduleBuilderOpt)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.TypeCompilationState(typeOpt, compilation, (Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder)moduleBuilderOpt);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21002, 1729, 1797);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticBag
        f_21002_1832_1859()
        {
            var return_v = DiagnosticBag.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21002, 1832, 1859);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.BoundBlock
        f_21002_1886_1954(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        method, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
        compilationState, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            var return_v = MethodCompiler.BindMethodBody(method, compilationState, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21002, 1886, 1954);
            return return_v;
        }


        static int
        f_21002_1969_1987(Microsoft.CodeAnalysis.DiagnosticBag
        this_param)
        {
            this_param.Free();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21002, 1969, 1987);
            return 0;
        }


        static Microsoft.CodeAnalysis.Location
        f_21002_2172_2191(Microsoft.CodeAnalysis.Diagnostic
        this_param)
        {
            var return_v = this_param.Location;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21002, 2172, 2191);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree?
        f_21002_2172_2202(Microsoft.CodeAnalysis.Location
        this_param)
        {
            var return_v = this_param.SourceTree;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21002, 2172, 2202);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Text.SourceText
        f_21002_2172_2212(Microsoft.CodeAnalysis.SyntaxTree?
        this_param)
        {
            var return_v = this_param.GetText();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21002, 2172, 2212);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Location
        f_21002_2222_2241(Microsoft.CodeAnalysis.Diagnostic
        this_param)
        {
            var return_v = this_param.Location;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21002, 2222, 2241);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Text.TextSpan
        f_21002_2222_2252(Microsoft.CodeAnalysis.Location
        this_param)
        {
            var return_v = this_param.SourceSpan;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21002, 2222, 2252);
            return return_v;
        }


        static string
        f_21002_2172_2253(Microsoft.CodeAnalysis.Text.SourceText
        this_param, Microsoft.CodeAnalysis.Text.TextSpan
        span)
        {
            var return_v = this_param.ToString(span);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21002, 2172, 2253);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Location
        f_21002_2332_2345()
        {
            var return_v = Location.None;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21002, 2332, 2345);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Diagnostic
        f_21002_2308_2346(Microsoft.CodeAnalysis.Diagnostic
        this_param, Microsoft.CodeAnalysis.Location
        location)
        {
            var return_v = this_param.WithLocation(location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21002, 2308, 2346);
            return return_v;
        }


        static System.Globalization.CultureInfo
        f_21002_2348_2386()
        {
            var return_v = EnsureEnglishUICulture.PreferredOrNull;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21002, 2348, 2386);
            return return_v;
        }


        static string
        f_21002_2272_2387(Microsoft.CodeAnalysis.DiagnosticFormatter
        this_param, Microsoft.CodeAnalysis.Diagnostic
        diagnostic, System.Globalization.CultureInfo
        formatter)
        {
            var return_v = this_param.Format(diagnostic, (System.IFormatProvider)formatter);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21002, 2272, 2387);
            return return_v;
        }


        static string
        f_21002_2128_2388(string
        format, string
        arg0, string
        arg1)
        {
            var return_v = string.Format(format, (object)arg0, (object)arg1);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21002, 2128, 2388);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<string>
        f_21002_2619_2653(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
        source, System.Func<Microsoft.CodeAnalysis.Diagnostic, string>
        selector)
        {
            var return_v = source.Select<Microsoft.CodeAnalysis.Diagnostic, string>(selector);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21002, 2619, 2653);
            return return_v;
        }


        static int
        f_21002_2588_2654(string[]
        expected, System.Collections.Generic.IEnumerable<string>
        actual)
        {
            AssertEx.SetEqual((System.Collections.Generic.IEnumerable<string>)expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21002, 2588, 2654);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21002_2894_2917(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21002, 2894, 2917);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
        f_21002_2950_2978(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.GetDiagnostics();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21002, 2950, 2978);
            return return_v;
        }


        int
        f_21002_2993_3054(string[]
        expected, System.Collections.Generic.IEnumerable<string>
        actual)
        {
            AssertEx.SetEqual((System.Collections.Generic.IEnumerable<string>)expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21002, 2993, 3054);
            return 0;
        }

    }
}
