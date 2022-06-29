// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal partial class IdentifierCollection
    {
        private abstract class CollectionBase : ICollection<string>
        {
            protected readonly IdentifierCollection IdentifierCollection;

            private int _count;

            protected CollectionBase(IdentifierCollection identifierCollection)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(103, 641, 805);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(103, 566, 586);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(103, 613, 624);
                    this._count = -1; DynAbs.Tracing.TraceSender.TraceSimpleStatement(103, 741, 790);

                    this.IdentifierCollection = identifierCollection;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(103, 641, 805);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(103, 641, 805);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(103, 641, 805);
                }
            }

            public abstract bool Contains(string item);

            public void CopyTo(string[] array, int arrayIndex)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(103, 880, 1291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(103, 963, 1276);
                    using (var
                    enumerator = f_103_987_1007(this)
                    )
                    {
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(103, 1049, 1257) || true) && (arrayIndex < f_103_1069_1081(array) && (DynAbs.Tracing.TraceSender.Expression_True(103, 1056, 1106) && f_103_1085_1106(enumerator)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(103, 1049, 1257);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(103, 1156, 1195);

                                array[arrayIndex] = f_103_1176_1194(enumerator);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(103, 1221, 1234);

                                arrayIndex++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(103, 1049, 1257);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(103, 1049, 1257);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(103, 1049, 1257);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(103, 963, 1276);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(103, 880, 1291);

                    System.Collections.Generic.IEnumerator<string>
                    f_103_987_1007(Microsoft.CodeAnalysis.IdentifierCollection.CollectionBase
                    this_param)
                    {
                        var return_v = this_param.GetEnumerator();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(103, 987, 1007);
                        return return_v;
                    }


                    int
                    f_103_1069_1081(string[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(103, 1069, 1081);
                        return return_v;
                    }


                    bool
                    f_103_1085_1106(System.Collections.Generic.IEnumerator<string>
                    this_param)
                    {
                        var return_v = this_param.MoveNext();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(103, 1085, 1106);
                        return return_v;
                    }


                    string
                    f_103_1176_1194(System.Collections.Generic.IEnumerator<string>
                    this_param)
                    {
                        var return_v = this_param.Current;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(103, 1176, 1194);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(103, 880, 1291);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(103, 880, 1291);
                }
            }

            public int Count
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(103, 1356, 1645);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(103, 1400, 1588) || true) && (_count == -1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(103, 1400, 1588);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(103, 1466, 1565);

                            _count = f_103_1475_1564(f_103_1475_1512(this.IdentifierCollection._map), o => o is string ? 1 : ((ISet<string>)o).Count);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(103, 1400, 1588);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(103, 1612, 1626);

                        return _count;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(103, 1356, 1645);

                        System.Collections.Generic.Dictionary<string, object>.ValueCollection
                        f_103_1475_1512(System.Collections.Generic.Dictionary<string, object>
                        this_param)
                        {
                            var return_v = this_param.Values;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(103, 1475, 1512);
                            return return_v;
                        }


                        int
                        f_103_1475_1564(System.Collections.Generic.Dictionary<string, object>.ValueCollection
                        source, System.Func<object, int>
                        selector)
                        {
                            var return_v = source.Sum<object>(selector);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(103, 1475, 1564);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(103, 1307, 1660);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(103, 1307, 1660);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsReadOnly
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(103, 1699, 1706);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(103, 1702, 1706);
                        return true; DynAbs.Tracing.TraceSender.TraceExitMethod(103, 1699, 1706);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(103, 1699, 1706);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(103, 1699, 1706);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public IEnumerator<string> GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(103, 1723, 2321);

                    var listYield = new List<String>();
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(103, 1798, 2306);
                        foreach (var obj in f_103_1818_1855_I(f_103_1818_1855(this.IdentifierCollection._map)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(103, 1798, 2306);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(103, 1897, 1931);

                            var
                            strs = obj as HashSet<string>
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(103, 1953, 2287) || true) && (strs != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(103, 1953, 2287);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(103, 2019, 2141);
                                    foreach (var s in f_103_2037_2041_I(strs))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(103, 2019, 2141);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(103, 2099, 2114);

                                        listYield.Add(s);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(103, 2019, 2141);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(103, 1, 123);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(103, 1, 123);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(103, 1953, 2287);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(103, 1953, 2287);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(103, 2239, 2264);

                                listYield.Add((string)obj);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(103, 1953, 2287);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(103, 1798, 2306);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(103, 1, 509);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(103, 1, 509);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(103, 1723, 2321);

                    return listYield.GetEnumerator();

                    System.Collections.Generic.Dictionary<string, object>.ValueCollection
                    f_103_1818_1855(System.Collections.Generic.Dictionary<string, object>
                    this_param)
                    {
                        var return_v = this_param.Values;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(103, 1818, 1855);
                        return return_v;
                    }


                    System.Collections.Generic.HashSet<string>
                    f_103_2037_2041_I(System.Collections.Generic.HashSet<string>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(103, 2037, 2041);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, object>.ValueCollection
                    f_103_1818_1855_I(System.Collections.Generic.Dictionary<string, object>.ValueCollection
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(103, 1818, 1855);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(103, 1723, 2321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(103, 1723, 2321);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(103, 2337, 2490);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(103, 2447, 2475);

                    return f_103_2454_2474(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(103, 2337, 2490);

                    System.Collections.Generic.IEnumerator<string>
                    f_103_2454_2474(Microsoft.CodeAnalysis.IdentifierCollection.CollectionBase
                    this_param)
                    {
                        var return_v = this_param.GetEnumerator();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(103, 2454, 2474);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(103, 2337, 2490);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(103, 2337, 2490);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void Add(string item)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(103, 2541, 2651);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(103, 2602, 2636);

                    throw f_103_2608_2635();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(103, 2541, 2651);

                    System.NotSupportedException
                    f_103_2608_2635()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(103, 2608, 2635);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(103, 2541, 2651);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(103, 2541, 2651);
                }
            }

            public void Clear()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(103, 2667, 2768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(103, 2719, 2753);

                    throw f_103_2725_2752();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(103, 2667, 2768);

                    System.NotSupportedException
                    f_103_2725_2752()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(103, 2725, 2752);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(103, 2667, 2768);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(103, 2667, 2768);
                }
            }

            public bool Remove(string item)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(103, 2784, 2897);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(103, 2848, 2882);

                    throw f_103_2854_2881();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(103, 2784, 2897);

                    System.NotSupportedException
                    f_103_2854_2881()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(103, 2854, 2881);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(103, 2784, 2897);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(103, 2784, 2897);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static CollectionBase()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(103, 442, 2932);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(103, 442, 2932);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(103, 442, 2932);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(103, 442, 2932);
        }
        private sealed class CaseSensitiveCollection : CollectionBase
        {
            public CaseSensitiveCollection(IdentifierCollection identifierCollection) : base(f_103_3111_3131_C(identifierCollection))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(103, 3030, 3162);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(103, 3030, 3162);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(103, 3030, 3162);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(103, 3030, 3162);
                }
            }

            public override bool Contains(string item)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(103, 3221, 3272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(103, 3224, 3272);
                    return f_103_3224_3272(IdentifierCollection, item); DynAbs.Tracing.TraceSender.TraceExitMethod(103, 3221, 3272);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(103, 3221, 3272);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(103, 3221, 3272);
                }
                throw new System.Exception("Slicer error: unreachable code");

                bool
                f_103_3224_3272(Microsoft.CodeAnalysis.IdentifierCollection
                this_param, string
                identifier)
                {
                    var return_v = this_param.CaseSensitiveContains(identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(103, 3224, 3272);
                    return return_v;
                }

            }

            static CaseSensitiveCollection()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(103, 2944, 3284);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(103, 2944, 3284);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(103, 2944, 3284);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(103, 2944, 3284);

            static Microsoft.CodeAnalysis.IdentifierCollection
            f_103_3111_3131_C(Microsoft.CodeAnalysis.IdentifierCollection
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(103, 3030, 3162);
                return return_v;
            }

        }
        private sealed class CaseInsensitiveCollection : CollectionBase
        {
            public CaseInsensitiveCollection(IdentifierCollection identifierCollection) : base(f_103_3467_3487_C(identifierCollection))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(103, 3384, 3518);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(103, 3384, 3518);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(103, 3384, 3518);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(103, 3384, 3518);
                }
            }

            public override bool Contains(string item)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(103, 3577, 3630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(103, 3580, 3630);
                    return f_103_3580_3630(IdentifierCollection, item); DynAbs.Tracing.TraceSender.TraceExitMethod(103, 3577, 3630);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(103, 3577, 3630);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(103, 3577, 3630);
                }
                throw new System.Exception("Slicer error: unreachable code");

                bool
                f_103_3580_3630(Microsoft.CodeAnalysis.IdentifierCollection
                this_param, string
                identifier)
                {
                    var return_v = this_param.CaseInsensitiveContains(identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(103, 3580, 3630);
                    return return_v;
                }

            }

            static CaseInsensitiveCollection()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(103, 3296, 3642);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(103, 3296, 3642);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(103, 3296, 3642);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(103, 3296, 3642);

            static Microsoft.CodeAnalysis.IdentifierCollection
            f_103_3467_3487_C(Microsoft.CodeAnalysis.IdentifierCollection
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(103, 3384, 3518);
                return return_v;
            }

        }

        static IdentifierCollection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(103, 382, 3649);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(103, 382, 3649);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(103, 382, 3649);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(103, 382, 3649);
    }
}
