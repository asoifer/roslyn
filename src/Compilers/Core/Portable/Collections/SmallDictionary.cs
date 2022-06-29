// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal sealed class SmallDictionary<K, V> : IEnumerable<KeyValuePair<K, V>>
            where K : notnull
    {
        private AvlNode? _root;

        public readonly IEqualityComparer<K> Comparer;

        public static readonly SmallDictionary<K, V> Empty;

        public SmallDictionary() : this(f_113_2197_2224_C<K>(f_113_2197_2224<K>()))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(113, 2165, 2229);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(113, 2165, 2229);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 2165, 2229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 2165, 2229);
            }
        }

        public SmallDictionary(IEqualityComparer<K> comparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(113, 2241, 2350);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 1935, 1940);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 1988, 1996);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 2319, 2339);

                Comparer = comparer;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(113, 2241, 2350);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 2241, 2350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 2241, 2350);
            }
        }

        public SmallDictionary(SmallDictionary<K, V> other, IEqualityComparer<K> comparer)
        : this(f_113_2465_2473_C<K>(comparer))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(113, 2362, 2706);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 2595, 2695);
                    foreach (var kv in f_113_2614_2619_I(other))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 2595, 2695);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 2653, 2680);

                        f_113_2653_2679(this, kv.Key, kv.Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(113, 2595, 2695);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(113, 1, 101);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(113, 1, 101);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(113, 2362, 2706);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 2362, 2706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 2362, 2706);
            }
        }

        private bool CompareKeys(K k1, K k2)
        {
            return Comparer.Equals(k1, k2);
        }

        private int GetHashCode(K k)
        {
            return Comparer.GetHashCode(k);
        }

        public bool TryGetValue(K key, [MaybeNullWhen(returnValue: false)] out V value)
        {
            if (_root != null)
            {
                return TryGetValue(GetHashCode(key), key, out value!);
            }

            value = default!;
            return false;
        }

        public void Add(K key, V value)
        {
            Insert(GetHashCode(key), key, value, add: true);
        }

        public V this[K key]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 3419, 3683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 3455, 3463);

                    V
                    value
                    = default(V);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 3481, 3635) || true) && (!f_113_3486_3514(this, key, out value!))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 3481, 3635);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 3556, 3616);

                        throw f_113_3562_3615($"Could not find key {key}");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(113, 3481, 3635);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 3655, 3668);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(113, 3419, 3683);

                    bool
                    f_113_3486_3514(Microsoft.CodeAnalysis.SmallDictionary<K, V>
                    this_param, K
                    key, out V?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 3486, 3514);
                        return return_v;
                    }


                    System.Collections.Generic.KeyNotFoundException
                    f_113_3562_3615(string
                    message)
                    {
                        var return_v = new System.Collections.Generic.KeyNotFoundException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 3562, 3615);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 3419, 3683);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 3419, 3683);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 3699, 3804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 3735, 3789);

                    f_113_3735_3788(this, f_113_3747_3763(this, key), key, value, add: false);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(113, 3699, 3804);

                    int
                    f_113_3747_3763(Microsoft.CodeAnalysis.SmallDictionary<K, V>
                    this_param, K
                    k)
                    {
                        var return_v = this_param.GetHashCode(k);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 3747, 3763);
                        return return_v;
                    }


                    int
                    f_113_3735_3788(Microsoft.CodeAnalysis.SmallDictionary<K, V>
                    this_param, int
                    hashCode, K
                    key, V?
                    value, bool
                    add)
                    {
                        this_param.Insert(hashCode, key, value, add: add);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 3735, 3788);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 3699, 3804);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 3699, 3804);
                }
            }
        }

        public bool ContainsKey(K key)
        {
            V value;
            return TryGetValue(key, out value!);
        }

        [Conditional("DEBUG")]
        internal void AssertBalanced()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 3963, 4110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 4061, 4091);

                f_113_4061_4090(_root);
                DynAbs.Tracing.TraceSender.TraceExitMethod(113, 3963, 4110);

                int
                f_113_4061_4090(Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode?
                V)
                {
                    var return_v = AvlNode.AssertBalanced(V);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 4061, 4090);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 3963, 4110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 3963, 4110);
            }
        }
        private abstract class Node
        {
            public readonly K Key;

            public V Value;

            protected Node(K key, V value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(113, 4241, 4371);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 4192, 4195);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 4219, 4224);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 4304, 4319);

                    this.Key = key;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 4337, 4356);

                    this.Value = value;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(113, 4241, 4371);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 4241, 4371);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 4241, 4371);
                }
            }

            public virtual Node? Next
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 4413, 4420);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 4416, 4420);
                        return null; DynAbs.Tracing.TraceSender.TraceExitMethod(113, 4413, 4420);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 4413, 4420);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 4413, 4420);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static Node()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(113, 4122, 4432);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(113, 4122, 4432);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 4122, 4432);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(113, 4122, 4432);
        }
        private sealed class NodeLinked : Node
        {
            public NodeLinked(K key, V value, Node next)
            : base(f_113_4576_4579_C<K>(key), value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(113, 4507, 4652);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 4668, 4702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 4620, 4637);

                    this.Next = next;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(113, 4507, 4652);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 4507, 4652);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 4507, 4652);
                }
            }

            public override Node Next { get; }

            static NodeLinked()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(113, 4444, 4713);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(113, 4444, 4713);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 4444, 4713);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(113, 4444, 4713);

            static K
            f_113_4576_4579_C<K>(K
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(113, 4507, 4652);
                return return_v;
            }

        }
        private sealed class AvlNodeHead : AvlNode
        {
            public Node next;

            public AvlNodeHead(int hashCode, K key, V value, Node next)
            : base(f_113_4909_4917_C(hashCode), key, value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(113, 4825, 4995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 4804, 4808);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 4963, 4980);

                    this.next = next;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(113, 4825, 4995);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 4825, 4995);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 4825, 4995);
                }
            }

            public override Node Next
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 5037, 5044);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 5040, 5044);
                        return next; DynAbs.Tracing.TraceSender.TraceExitMethod(113, 5037, 5044);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 5037, 5044);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 5037, 5044);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static AvlNodeHead()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(113, 4725, 5056);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(113, 4725, 5056);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 4725, 5056);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(113, 4725, 5056);

            static int
            f_113_4909_4917_C(int
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(113, 4825, 4995);
                return return_v;
            }

        }
        private abstract class HashedNode : Node
        {
            public readonly int HashCode;

            public sbyte Balance;

            protected HashedNode(int hashCode, K key, V value)
            : base(f_113_5469_5472_C<K>(key), value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(113, 5394, 5553);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 5334, 5342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 5370, 5377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 5513, 5538);

                    this.HashCode = hashCode;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(113, 5394, 5553);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 5394, 5553);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 5394, 5553);
                }
            }

            static HashedNode()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(113, 5249, 5564);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(113, 5249, 5564);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 5249, 5564);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(113, 5249, 5564);

            static K
            f_113_5469_5472_C<K>(K
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(113, 5394, 5553);
                return return_v;
            }

        }
        private class AvlNode : HashedNode
        {
            public AvlNode? Left;

            public AvlNode? Right;

            public AvlNode(int hashCode, K key, V value)
            : base(f_113_5777_5785_C(hashCode), key, value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(113, 5708, 5815);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 5651, 5655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 5686, 5691);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(113, 5708, 5815);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 5708, 5815);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 5708, 5815);
                }
            }

            public static int AssertBalanced(AvlNode? V)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(113, 5842, 6291);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 5919, 5943) || true) && (V == null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 5919, 5943);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 5934, 5943);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(113, 5919, 5943);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 5963, 5994);

                    int
                    a = f_113_5971_5993(V.Left)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 6012, 6044);

                    int
                    b = f_113_6020_6043(V.Right)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 6064, 6230) || true) && (a - b != V.Balance || (DynAbs.Tracing.TraceSender.Expression_False(113, 6068, 6131) || f_113_6111_6126(a - b) >= 2))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 6064, 6230);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 6173, 6211);

                        throw f_113_6179_6210();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(113, 6064, 6230);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 6250, 6276);

                    return 1 + f_113_6261_6275(a, b);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(113, 5842, 6291);

                    int
                    f_113_5971_5993(Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode?
                    V)
                    {
                        var return_v = AssertBalanced(V);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 5971, 5993);
                        return return_v;
                    }


                    int
                    f_113_6020_6043(Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode?
                    V)
                    {
                        var return_v = AssertBalanced(V);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 6020, 6043);
                        return return_v;
                    }


                    int
                    f_113_6111_6126(int
                    value)
                    {
                        var return_v = Math.Abs(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 6111, 6126);
                        return return_v;
                    }


                    System.InvalidOperationException
                    f_113_6179_6210()
                    {
                        var return_v = new System.InvalidOperationException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 6179, 6210);
                        return return_v;
                    }


                    int
                    f_113_6261_6275(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Max(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 6261, 6275);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 5842, 6291);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 5842, 6291);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static AvlNode()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(113, 5576, 6310);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(113, 5576, 6310);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 5576, 6310);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(113, 5576, 6310);

            static int
            f_113_5777_5785_C(int
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(113, 5708, 5815);
                return return_v;
            }

        }

        private bool TryGetValue(int hashCode, K key, [MaybeNullWhen(returnValue: false)] out V value)
        {
            RoslynDebug.Assert(_root is object);
            AvlNode? b = _root;

            do
            {
                if (b.HashCode > hashCode)
                {
                    b = b.Left;
                }
                else if (b.HashCode < hashCode)
                {
                    b = b.Right;
                }
                else
                {
                    goto hasBucket;
                }
            } while (b != null);

            value = default!;
            return false;

hasBucket:
            if (CompareKeys(b.Key, key))
            {
                value = b.Value;
                return true;
            }

            return GetFromList(b.Next, key, out value!);
        }

        private bool GetFromList(Node? next, K key, [MaybeNullWhen(returnValue: false)] out V value)
        {
            while (next != null)
            {
                if (CompareKeys(key, next.Key))
                {
                    value = next.Value;
                    return true;
                }

                next = next.Next;
            }

            value = default!;
            return false;
        }

        private void Insert(int hashCode, K key, V value, bool add)
        {
            AvlNode? currentNode = _root;

            if (currentNode == null)
            {
                _root = new AvlNode(hashCode, key, value);
                return;
            }

            AvlNode? currentNodeParent = null;
            AvlNode unbalanced = currentNode;
            AvlNode? unbalancedParent = null;

            // ====== insert new node
            // also make a note of the last unbalanced node and its parent (for rotation if needed)
            // nodes on the search path from rotation candidate downwards will change balances because of the node added
            // unbalanced node itself will become balanced or will be rotated
            // either way nodes above unbalanced do not change their balance
            for (; ; )
            {
                // schedule hk read 
                var hc = currentNode.HashCode;

                if (currentNode.Balance != 0)
                {
                    unbalancedParent = currentNodeParent;
                    unbalanced = currentNode;
                }

                if (hc > hashCode)
                {
                    if (currentNode.Left == null)
                    {
                        var previousNode = currentNode;
                        currentNode = new AvlNode(hashCode, key, value);
                        previousNode.Left = currentNode;
                        break;
                    }

                    currentNodeParent = currentNode;
                    currentNode = currentNode.Left;
                }
                else if (hc < hashCode)
                {
                    if (currentNode.Right == null)
                    {
                        var previousNode = currentNode;
                        currentNode = new AvlNode(hashCode, key, value);
                        previousNode.Right = currentNode;
                        break;
                    }

                    currentNodeParent = currentNode;
                    currentNode = currentNode.Right;
                }
                else // (p.HashCode == hashCode)
                {
                    this.HandleInsert(currentNode, currentNodeParent, key, value, add);
                    return;
                }
            }

            Debug.Assert(unbalanced != currentNode);

            // ====== update balances on the path from unbalanced downwards
            var n = unbalanced;
            do
            {
                Debug.Assert(n.HashCode != hashCode);

                if (n.HashCode < hashCode)
                {
                    n.Balance--;
                    n = n.Right!;
                }
                else
                {
                    n.Balance++;
                    n = n.Left!;
                }
            }
            while (n != currentNode);

            // ====== rotate unbalanced node if needed
            AvlNode rotated;
            var balance = unbalanced.Balance;
            if (balance == -2)
            {
                rotated = unbalanced.Right!.Balance < 0 ?
                    LeftSimple(unbalanced) :
                    LeftComplex(unbalanced);
            }
            else if (balance == 2)
            {
                rotated = unbalanced.Left!.Balance > 0 ?
                    RightSimple(unbalanced) :
                    RightComplex(unbalanced);
            }
            else
            {
                return;
            }

            // ===== make parent to point to rotated
            if (unbalancedParent == null)
            {
                _root = rotated;
            }
            else if (unbalanced == unbalancedParent.Left)
            {
                unbalancedParent.Left = rotated;
            }
            else
            {
                unbalancedParent.Right = rotated;
            }
        }

        private static AvlNode LeftSimple(AvlNode unbalanced)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(113, 11688, 12047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 11766, 11813);

                f_113_11766_11812(unbalanced.Right is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 11827, 11856);

                var
                right = unbalanced.Right
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 11870, 11900);

                unbalanced.Right = right.Left;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 11914, 11938);

                right.Left = unbalanced;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 11954, 11977);

                unbalanced.Balance = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 11991, 12009);

                right.Balance = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 12023, 12036);

                return right;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(113, 11688, 12047);

                int
                f_113_11766_11812(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 11766, 11812);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 11688, 12047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 11688, 12047);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static AvlNode RightSimple(AvlNode unbalanced)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(113, 12059, 12413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 12138, 12184);

                f_113_12138_12183(unbalanced.Left is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 12198, 12225);

                var
                left = unbalanced.Left
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 12239, 12268);

                unbalanced.Left = left.Right;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 12282, 12306);

                left.Right = unbalanced;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 12322, 12345);

                unbalanced.Balance = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 12359, 12376);

                left.Balance = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 12390, 12402);

                return left;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(113, 12059, 12413);

                int
                f_113_12138_12183(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 12138, 12183);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 12059, 12413);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 12059, 12413);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static AvlNode LeftComplex(AvlNode unbalanced)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(113, 12425, 13305);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 12504, 12551);

                f_113_12504_12550(unbalanced.Right is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 12565, 12617);

                f_113_12565_12616(unbalanced.Right.Left is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 12631, 12660);

                var
                right = unbalanced.Right
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 12674, 12701);

                var
                rightLeft = right.Left
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 12715, 12744);

                right.Left = rightLeft.Right;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 12758, 12782);

                rightLeft.Right = right;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 12796, 12830);

                unbalanced.Right = rightLeft.Left;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 12844, 12872);

                rightLeft.Left = unbalanced;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 12888, 12929);

                var
                rightLeftBalance = rightLeft.Balance
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 12943, 12965);

                rightLeft.Balance = 0;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 12981, 13261) || true) && (rightLeftBalance < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 12981, 13261);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 13039, 13057);

                    right.Balance = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 13075, 13098);

                    unbalanced.Balance = 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(113, 12981, 13261);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 12981, 13261);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 13164, 13205);

                    right.Balance = (sbyte)-rightLeftBalance;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 13223, 13246);

                    unbalanced.Balance = 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(113, 12981, 13261);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 13277, 13294);

                return rightLeft;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(113, 12425, 13305);

                int
                f_113_12504_12550(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 12504, 12550);
                    return 0;
                }


                int
                f_113_12565_12616(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 12565, 12616);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 12425, 13305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 12425, 13305);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static AvlNode RightComplex(AvlNode unbalanced)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(113, 13317, 14187);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 13397, 13441);

                f_113_13397_13440(unbalanced.Left != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 13455, 13505);

                f_113_13455_13504(unbalanced.Left.Right != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 13519, 13546);

                var
                left = unbalanced.Left
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 13560, 13587);

                var
                leftRight = left.Right
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 13601, 13629);

                left.Right = leftRight.Left;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 13643, 13665);

                leftRight.Left = left;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 13679, 13713);

                unbalanced.Left = leftRight.Right;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 13727, 13756);

                leftRight.Right = unbalanced;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 13772, 13813);

                var
                leftRightBalance = leftRight.Balance
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 13827, 13849);

                leftRight.Balance = 0;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 13865, 14143) || true) && (leftRightBalance < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 13865, 14143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 13923, 13940);

                    left.Balance = 1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 13958, 13981);

                    unbalanced.Balance = 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(113, 13865, 14143);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 13865, 14143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 14047, 14064);

                    left.Balance = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 14082, 14128);

                    unbalanced.Balance = (sbyte)-leftRightBalance;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(113, 13865, 14143);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 14159, 14176);

                return leftRight;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(113, 13317, 14187);

                int
                f_113_13397_13440(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 13397, 13440);
                    return 0;
                }


                int
                f_113_13455_13504(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 13455, 13504);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 13317, 14187);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 13317, 14187);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }


        private void HandleInsert(AvlNode node, AvlNode? parent, K key, V value, bool add)
        {
            Node? currentNode = node;
            do
            {
                if (CompareKeys(currentNode.Key, key))
                {
                    if (add)
                    {
                        throw new InvalidOperationException();
                    }

                    currentNode.Value = value;
                    return;
                }

                currentNode = currentNode.Next;
            } while (currentNode != null);

            AddNode(node, parent, key, value);
        }

        private void AddNode(AvlNode node, AvlNode? parent, K key, V value)
        {
            AvlNodeHead? head = node as AvlNodeHead;
            if (head != null)
            {
                var newNext = new NodeLinked(key, value, head.next);
                head.next = newNext;
                return;
            }

            var newHead = new AvlNodeHead(node.HashCode, key, value, node);
            newHead.Balance = node.Balance;
            newHead.Left = node.Left;
            newHead.Right = node.Right;

            if (parent == null)
            {
                _root = newHead;
                return;
            }

            if (node == parent.Left)
            {
                parent.Left = newHead;
            }
            else
            {
                parent.Right = newHead;
            }
        }

        public KeyCollection Keys
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 15747, 15773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 15750, 15773);
                    return f_113_15750_15773(this); DynAbs.Tracing.TraceSender.TraceExitMethod(113, 15747, 15773);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 15747, 15773);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 15747, 15773);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal struct KeyCollection : IEnumerable<K>
        {

            private readonly SmallDictionary<K, V> _dict;

            public KeyCollection(SmallDictionary<K, V> dict)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(113, 15918, 16027);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 15999, 16012);

                    _dict = dict;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(113, 15918, 16027);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 15918, 16027);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 15918, 16027);
                }
            }

            public struct Enumerator
            {

                private readonly Stack<AvlNode>? _stack;

                private Node? _next;

                private Node? _current;

                public Enumerator(SmallDictionary<K, V> dict)
                                    : this()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(113, 16239, 16908);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 16355, 16377);

                        var
                        root = dict._root
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 16399, 16889) || true) && (root != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 16399, 16889);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 16530, 16866) || true) && (root.Left == root.Right)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 16530, 16866);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 16615, 16628);

                                _next = root;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(113, 16530, 16866);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 16530, 16866);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 16742, 16791);

                                _stack = f_113_16751_16790(f_113_16770_16789(dict));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 16821, 16839);

                                f_113_16821_16838(_stack, root);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(113, 16530, 16866);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(113, 16399, 16889);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(113, 16239, 16908);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 16239, 16908);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 16239, 16908);
                    }
                }

                public K Current
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 16945, 16961);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 16948, 16961);
                            return _current!.Key; DynAbs.Tracing.TraceSender.TraceExitMethod(113, 16945, 16961);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 16945, 16961);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 16945, 16961);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public bool MoveNext()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 16982, 17662);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 17045, 17235) || true) && (_next != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 17045, 17235);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 17112, 17129);

                            _current = _next;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 17155, 17174);

                            _next = f_113_17163_17173(_next);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 17200, 17212);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(113, 17045, 17235);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 17259, 17384) || true) && (_stack == null || (DynAbs.Tracing.TraceSender.Expression_False(113, 17263, 17298) || f_113_17281_17293(_stack) == 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 17259, 17384);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 17348, 17361);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(113, 17259, 17384);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 17408, 17432);

                        var
                        curr = f_113_17419_17431(_stack)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 17454, 17470);

                        _current = curr;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 17492, 17510);

                        _next = f_113_17500_17509(curr);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 17534, 17559);

                        PushIfNotNull(curr.Left);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 17581, 17607);

                        PushIfNotNull(curr.Right);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 17631, 17643);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(113, 16982, 17662);

                        Microsoft.CodeAnalysis.SmallDictionary<K, V>.Node?
                        f_113_17163_17173(Microsoft.CodeAnalysis.SmallDictionary<K, V>.Node
                        this_param)
                        {
                            var return_v = this_param.Next;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(113, 17163, 17173);
                            return return_v;
                        }


                        int
                        f_113_17281_17293(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(113, 17281, 17293);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode
                        f_113_17419_17431(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode>
                        this_param)
                        {
                            var return_v = this_param.Pop();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 17419, 17431);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SmallDictionary<K, V>.Node?
                        f_113_17500_17509(Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode
                        this_param)
                        {
                            var return_v = this_param.Next;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(113, 17500, 17509);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 16982, 17662);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 16982, 17662);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                private void PushIfNotNull(AvlNode? child)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 17682, 17894);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 17765, 17875) || true) && (child != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 17765, 17875);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 17832, 17852);

                            f_113_17832_17851(_stack!, child);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(113, 17765, 17875);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(113, 17682, 17894);

                        int
                        f_113_17832_17851(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode>
                        this_param, Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode
                        item)
                        {
                            this_param.Push(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 17832, 17851);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 17682, 17894);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 17682, 17894);
                    }
                }
                static Enumerator()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(113, 16043, 17909);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(113, 16043, 17909);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 16043, 17909);
                }

                static int
                f_113_16770_16789<K, V>(Microsoft.CodeAnalysis.SmallDictionary<K, V>
                this_param)
                {
                    var return_v = this_param.HeightApprox();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 16770, 16789);
                    return return_v;
                }


                static System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode>
                f_113_16751_16790(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 16751, 16790);
                    return return_v;
                }


                static int
                f_113_16821_16838(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode>
                this_param, Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 16821, 16838);
                    return 0;
                }

            }

            public Enumerator GetEnumerator()
            {
                return new Enumerator(_dict);
            }
            public class EnumerableImpl : IEnumerator<K>
            {
                private Enumerator _e;

                public EnumerableImpl(Enumerator e)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(113, 18170, 18272);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 18246, 18253);

                        _e = e;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(113, 18170, 18272);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 18170, 18272);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 18170, 18272);
                    }
                }

                K IEnumerator<K>.Current
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 18317, 18330);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 18320, 18330);
                            return _e.Current; DynAbs.Tracing.TraceSender.TraceExitMethod(113, 18317, 18330);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 18317, 18330);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 18317, 18330);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                void IDisposable.Dispose()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 18351, 18415);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(113, 18351, 18415);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 18351, 18415);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 18351, 18415);
                    }
                }

                object IEnumerator.Current
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 18462, 18475);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 18465, 18475);
                            return _e.Current; DynAbs.Tracing.TraceSender.TraceExitMethod(113, 18462, 18475);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 18462, 18475);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 18462, 18475);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                bool IEnumerator.MoveNext()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 18496, 18604);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 18564, 18585);

                        return _e.MoveNext();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(113, 18496, 18604);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 18496, 18604);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 18496, 18604);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                void IEnumerator.Reset()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 18624, 18742);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 18689, 18723);

                        throw f_113_18695_18722();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(113, 18624, 18742);

                        System.NotSupportedException
                        f_113_18695_18722()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 18695, 18722);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 18624, 18742);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 18624, 18742);
                    }
                }

                static EnumerableImpl()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(113, 18051, 18757);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(113, 18051, 18757);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 18051, 18757);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(113, 18051, 18757);
            }

            IEnumerator<K> IEnumerable<K>.GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 18773, 18909);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 18851, 18894);

                    return f_113_18858_18893(GetEnumerator());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(113, 18773, 18909);

                    Microsoft.CodeAnalysis.SmallDictionary<K, V>.KeyCollection.EnumerableImpl
                    f_113_18858_18893(Microsoft.CodeAnalysis.SmallDictionary<K, V>.KeyCollection.Enumerator
                    e)
                    {
                        var return_v = new Microsoft.CodeAnalysis.SmallDictionary<K, V>.KeyCollection.EnumerableImpl(e);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 18858, 18893);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 18773, 18909);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 18773, 18909);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 18925, 19048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 18997, 19033);

                    throw f_113_19003_19032();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(113, 18925, 19048);

                    System.NotImplementedException
                    f_113_19003_19032()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 19003, 19032);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 18925, 19048);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 18925, 19048);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static KeyCollection()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(113, 15786, 19059);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(113, 15786, 19059);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 15786, 19059);
            }
        }

        public ValueCollection Values
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 19101, 19129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 19104, 19129);
                    return f_113_19104_19129(this); DynAbs.Tracing.TraceSender.TraceExitMethod(113, 19101, 19129);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 19101, 19129);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 19101, 19129);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal struct ValueCollection : IEnumerable<V>
        {

            private readonly SmallDictionary<K, V> _dict;

            public ValueCollection(SmallDictionary<K, V> dict)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(113, 19276, 19387);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 19359, 19372);

                    _dict = dict;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(113, 19276, 19387);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 19276, 19387);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 19276, 19387);
                }
            }

            public struct Enumerator
            {

                private readonly Stack<AvlNode>? _stack;

                private Node? _next;

                private Node? _current;

                public Enumerator(SmallDictionary<K, V> dict)
                                    : this()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(113, 19599, 20263);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 19715, 19737);

                        var
                        root = dict._root
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 19759, 19855) || true) && (root == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 19759, 19855);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 19825, 19832);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(113, 19759, 19855);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 19940, 20244) || true) && (root.Left == root.Right)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 19940, 20244);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 20017, 20030);

                            _next = root;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(113, 19940, 20244);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 19940, 20244);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 20128, 20177);

                            _stack = f_113_20137_20176(f_113_20156_20175(dict));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 20203, 20221);

                            f_113_20203_20220(_stack, root);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(113, 19940, 20244);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(113, 19599, 20263);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 19599, 20263);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 19599, 20263);
                    }
                }

                public V Current
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 20300, 20318);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 20303, 20318);
                            return _current!.Value; DynAbs.Tracing.TraceSender.TraceExitMethod(113, 20300, 20318);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 20300, 20318);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 20300, 20318);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public bool MoveNext()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 20339, 21019);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 20402, 20592) || true) && (_next != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 20402, 20592);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 20469, 20486);

                            _current = _next;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 20512, 20531);

                            _next = f_113_20520_20530(_next);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 20557, 20569);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(113, 20402, 20592);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 20616, 20741) || true) && (_stack == null || (DynAbs.Tracing.TraceSender.Expression_False(113, 20620, 20655) || f_113_20638_20650(_stack) == 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 20616, 20741);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 20705, 20718);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(113, 20616, 20741);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 20765, 20789);

                        var
                        curr = f_113_20776_20788(_stack)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 20811, 20827);

                        _current = curr;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 20849, 20867);

                        _next = f_113_20857_20866(curr);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 20891, 20916);

                        PushIfNotNull(curr.Left);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 20938, 20964);

                        PushIfNotNull(curr.Right);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 20988, 21000);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(113, 20339, 21019);

                        Microsoft.CodeAnalysis.SmallDictionary<K, V>.Node?
                        f_113_20520_20530(Microsoft.CodeAnalysis.SmallDictionary<K, V>.Node
                        this_param)
                        {
                            var return_v = this_param.Next;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(113, 20520, 20530);
                            return return_v;
                        }


                        int
                        f_113_20638_20650(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(113, 20638, 20650);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode
                        f_113_20776_20788(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode>
                        this_param)
                        {
                            var return_v = this_param.Pop();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 20776, 20788);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SmallDictionary<K, V>.Node?
                        f_113_20857_20866(Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode
                        this_param)
                        {
                            var return_v = this_param.Next;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(113, 20857, 20866);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 20339, 21019);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 20339, 21019);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                private void PushIfNotNull(AvlNode? child)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 21039, 21251);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 21122, 21232) || true) && (child != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 21122, 21232);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 21189, 21209);

                            f_113_21189_21208(_stack!, child);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(113, 21122, 21232);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(113, 21039, 21251);

                        int
                        f_113_21189_21208(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode>
                        this_param, Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode
                        item)
                        {
                            this_param.Push(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 21189, 21208);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 21039, 21251);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 21039, 21251);
                    }
                }

                static int
                f_113_20156_20175<K, V>(Microsoft.CodeAnalysis.SmallDictionary<K, V>
                this_param)
                {
                    var return_v = this_param.HeightApprox();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 20156, 20175);
                    return return_v;
                }


                static System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode>
                f_113_20137_20176(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 20137, 20176);
                    return return_v;
                }


                static int
                f_113_20203_20220(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode>
                this_param, Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 20203, 20220);
                    return 0;
                }

            }

            public Enumerator GetEnumerator()
            {
                return new Enumerator(_dict);
            }
            public class EnumerableImpl : IEnumerator<V>
            {
                private Enumerator _e;

                public EnumerableImpl(Enumerator e)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(113, 21527, 21629);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 21603, 21610);

                        _e = e;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(113, 21527, 21629);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 21527, 21629);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 21527, 21629);
                    }
                }

                V IEnumerator<V>.Current
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 21674, 21687);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 21677, 21687);
                            return _e.Current; DynAbs.Tracing.TraceSender.TraceExitMethod(113, 21674, 21687);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 21674, 21687);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 21674, 21687);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                void IDisposable.Dispose()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 21708, 21772);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(113, 21708, 21772);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 21708, 21772);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 21708, 21772);
                    }
                }

                object? IEnumerator.Current
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 21820, 21833);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 21823, 21833);
                            return _e.Current; DynAbs.Tracing.TraceSender.TraceExitMethod(113, 21820, 21833);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 21820, 21833);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 21820, 21833);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                bool IEnumerator.MoveNext()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 21854, 21962);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 21922, 21943);

                        return _e.MoveNext();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(113, 21854, 21962);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 21854, 21962);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 21854, 21962);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                void IEnumerator.Reset()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 21982, 22102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 22047, 22083);

                        throw f_113_22053_22082();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(113, 21982, 22102);

                        System.NotImplementedException
                        f_113_22053_22082()
                        {
                            var return_v = new System.NotImplementedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 22053, 22082);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 21982, 22102);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 21982, 22102);
                    }
                }
            }

            IEnumerator<V> IEnumerable<V>.GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 22133, 22269);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 22211, 22254);

                    return f_113_22218_22253(GetEnumerator());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(113, 22133, 22269);

                    Microsoft.CodeAnalysis.SmallDictionary<K, V>.ValueCollection.EnumerableImpl
                    f_113_22218_22253(Microsoft.CodeAnalysis.SmallDictionary<K, V>.ValueCollection.Enumerator
                    e)
                    {
                        var return_v = new Microsoft.CodeAnalysis.SmallDictionary<K, V>.ValueCollection.EnumerableImpl(e);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 22218, 22253);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 22133, 22269);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 22133, 22269);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 22285, 22408);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 22357, 22393);

                    throw f_113_22363_22392();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(113, 22285, 22408);

                    System.NotImplementedException
                    f_113_22363_22392()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 22363, 22392);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 22285, 22408);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 22285, 22408);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static ValueCollection()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(113, 19142, 22419);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(113, 19142, 22419);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 19142, 22419);
            }
        }

        public struct Enumerator
        {

            private readonly Stack<AvlNode>? _stack;

            private Node? _next;

            private Node? _current;

            public Enumerator(SmallDictionary<K, V> dict)
                            : this()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(113, 22607, 23199);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 22711, 22733);

                    var
                    root = dict._root
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 22751, 22835) || true) && (root == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 22751, 22835);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 22809, 22816);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(113, 22751, 22835);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 22912, 23184) || true) && (root.Left == root.Right)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 22912, 23184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 22981, 22994);

                        _next = root;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(113, 22912, 23184);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 22912, 23184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 23076, 23125);

                        _stack = f_113_23085_23124(f_113_23104_23123(dict));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 23147, 23165);

                        f_113_23147_23164(_stack, root);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(113, 22912, 23184);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(113, 22607, 23199);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 22607, 23199);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 22607, 23199);
                }
            }

            public KeyValuePair<K, V> Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 23249, 23306);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 23252, 23306);
                        return f_113_23252_23306(_current!.Key, _current!.Value); DynAbs.Tracing.TraceSender.TraceExitMethod(113, 23249, 23306);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 23249, 23306);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 23249, 23306);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool MoveNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 23323, 23931);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 23378, 23548) || true) && (_next != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 23378, 23548);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 23437, 23454);

                        _current = _next;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 23476, 23495);

                        _next = f_113_23484_23494(_next);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 23517, 23529);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(113, 23378, 23548);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 23568, 23681) || true) && (_stack == null || (DynAbs.Tracing.TraceSender.Expression_False(113, 23572, 23607) || f_113_23590_23602(_stack) == 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 23568, 23681);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 23649, 23662);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(113, 23568, 23681);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 23701, 23725);

                    var
                    curr = f_113_23712_23724(_stack)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 23743, 23759);

                    _current = curr;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 23777, 23795);

                    _next = f_113_23785_23794(curr);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 23815, 23840);

                    PushIfNotNull(curr.Left);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 23858, 23884);

                    PushIfNotNull(curr.Right);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 23904, 23916);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(113, 23323, 23931);

                    Microsoft.CodeAnalysis.SmallDictionary<K, V>.Node?
                    f_113_23484_23494(Microsoft.CodeAnalysis.SmallDictionary<K, V>.Node
                    this_param)
                    {
                        var return_v = this_param.Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(113, 23484, 23494);
                        return return_v;
                    }


                    int
                    f_113_23590_23602(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(113, 23590, 23602);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode
                    f_113_23712_23724(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode>
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 23712, 23724);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SmallDictionary<K, V>.Node?
                    f_113_23785_23794(Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode
                    this_param)
                    {
                        var return_v = this_param.Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(113, 23785, 23794);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 23323, 23931);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 23323, 23931);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void PushIfNotNull(AvlNode? child)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 23947, 24135);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 24022, 24120) || true) && (child != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 24022, 24120);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 24081, 24101);

                        f_113_24081_24100(_stack!, child);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(113, 24022, 24120);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(113, 23947, 24135);

                    int
                    f_113_24081_24100(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode>
                    this_param, Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode
                    item)
                    {
                        this_param.Push(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 24081, 24100);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 23947, 24135);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 23947, 24135);
                }
            }

            static int
            f_113_23104_23123<K, V>(Microsoft.CodeAnalysis.SmallDictionary<K, V>
            this_param)
            {
                var return_v = this_param.HeightApprox();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 23104, 23123);
                return return_v;
            }


            static System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode>
            f_113_23085_23124(int
            capacity)
            {
                var return_v = new System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode>(capacity);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 23085, 23124);
                return return_v;
            }


            static int
            f_113_23147_23164(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode>
            this_param, Microsoft.CodeAnalysis.SmallDictionary<K, V>.AvlNode
            item)
            {
                this_param.Push(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 23147, 23164);
                return 0;
            }


            System.Collections.Generic.KeyValuePair<K, V>
            f_113_23252_23306(K
            key, V?
            value)
            {
                var return_v = new System.Collections.Generic.KeyValuePair<K, V>(key, value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 23252, 23306);
                return return_v;
            }

        }

        public Enumerator GetEnumerator()
        {
            return new Enumerator(this);
        }
        public class EnumerableImpl : IEnumerator<KeyValuePair<K, V>>
        {
            private Enumerator _e;

            public EnumerableImpl(Enumerator e)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(113, 24391, 24481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 24459, 24466);

                    _e = e;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(113, 24391, 24481);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 24391, 24481);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 24391, 24481);
                }
            }

            KeyValuePair<K, V> IEnumerator<KeyValuePair<K, V>>.Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 24556, 24569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 24559, 24569);
                        return _e.Current; DynAbs.Tracing.TraceSender.TraceExitMethod(113, 24556, 24569);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 24556, 24569);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 24556, 24569);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            void IDisposable.Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 24586, 24642);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(113, 24586, 24642);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 24586, 24642);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 24586, 24642);
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 24685, 24698);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 24688, 24698);
                        return _e.Current; DynAbs.Tracing.TraceSender.TraceExitMethod(113, 24685, 24698);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 24685, 24698);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 24685, 24698);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool IEnumerator.MoveNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 24715, 24811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 24775, 24796);

                    return _e.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(113, 24715, 24811);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 24715, 24811);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 24715, 24811);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            void IEnumerator.Reset()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 24827, 24935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 24884, 24920);

                    throw f_113_24890_24919();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(113, 24827, 24935);

                    System.NotImplementedException
                    f_113_24890_24919()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 24890, 24919);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 24827, 24935);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 24827, 24935);
                }
            }
        }

        IEnumerator<KeyValuePair<K, V>> IEnumerable<KeyValuePair<K, V>>.GetEnumerator()
        {
            return new EnumerableImpl(GetEnumerator());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 25128, 25239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 25192, 25228);

                throw f_113_25198_25227();
                DynAbs.Tracing.TraceSender.TraceExitMethod(113, 25128, 25239);

                System.NotImplementedException
                f_113_25198_25227()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 25198, 25227);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 25128, 25239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 25128, 25239);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int HeightApprox()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 25251, 25587);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 25365, 25375);

                var
                h = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 25389, 25405);

                var
                cur = _root
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 25419, 25523) || true) && (cur != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 25419, 25523);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 25471, 25475);

                        h++;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 25493, 25508);

                        cur = cur.Left;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(113, 25419, 25523);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(113, 25419, 25523);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(113, 25419, 25523);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 25539, 25553);

                h = h + h / 2;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 25567, 25576);

                return h;
                DynAbs.Tracing.TraceSender.TraceExitMethod(113, 25251, 25587);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 25251, 25587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 25251, 25587);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SmallDictionary()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(113, 1797, 25594);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 2112, 2152);
            Empty = f_113_2120_2152<K, V>(null!); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(113, 1797, 25594);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 1797, 25594);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(113, 1797, 25594);

        static Microsoft.CodeAnalysis.SmallDictionary<K, V>
        f_113_2120_2152<K, V>(System.Collections.Generic.IEqualityComparer<K>
        comparer)
        {
            var return_v = new Microsoft.CodeAnalysis.SmallDictionary<K, V>(comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 2120, 2152);
            return return_v;
        }


        static System.Collections.Generic.EqualityComparer<K>
        f_113_2197_2224<K>() where K : notnull

        {
            var return_v = EqualityComparer<K>.Default;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(113, 2197, 2224);
            return return_v;
        }


        static System.Collections.Generic.IEqualityComparer<K>
        f_113_2197_2224_C<K>(System.Collections.Generic.IEqualityComparer<K>
        i) where K : notnull

        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(113, 2165, 2229);
            return return_v;
        }


        static int
        f_113_2653_2679<K, V>(Microsoft.CodeAnalysis.SmallDictionary<K, V>
        this_param, K
        key, V?
        value) where K : notnull

        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 2653, 2679);
            return 0;
        }


        Microsoft.CodeAnalysis.SmallDictionary<K, V>
        f_113_2614_2619_I(Microsoft.CodeAnalysis.SmallDictionary<K, V>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 2614, 2619);
            return return_v;
        }


        static System.Collections.Generic.IEqualityComparer<K>
        f_113_2465_2473_C<K>(System.Collections.Generic.IEqualityComparer<K>
        i) where K : notnull

        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(113, 2362, 2706);
            return return_v;
        }


        Microsoft.CodeAnalysis.SmallDictionary<K, V>.KeyCollection
        f_113_15750_15773(Microsoft.CodeAnalysis.SmallDictionary<K, V>
        dict)
        {
            var return_v = new Microsoft.CodeAnalysis.SmallDictionary<K, V>.KeyCollection(dict);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 15750, 15773);
            return return_v;
        }


        Microsoft.CodeAnalysis.SmallDictionary<K, V>.ValueCollection
        f_113_19104_19129(Microsoft.CodeAnalysis.SmallDictionary<K, V>
        dict)
        {
            var return_v = new Microsoft.CodeAnalysis.SmallDictionary<K, V>.ValueCollection(dict);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 19104, 19129);
            return return_v;
        }

    }
}
