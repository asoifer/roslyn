// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    internal partial struct MetadataTypeName
    {

        public struct Key : IEquatable<Key>
        {

            private readonly string _namespaceOrFullyQualifiedName;

            private readonly string _typeName;

            private readonly byte _useCLSCompliantNameArityEncoding;

            private readonly short _forcedArity;

            internal Key(in MetadataTypeName mdTypeName)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(412, 1162, 2340);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 1239, 2325) || true) && (mdTypeName.IsNull)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(412, 1239, 2325);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 1302, 1340);

                        _namespaceOrFullyQualifiedName = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 1362, 1379);

                        _typeName = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 1401, 1439);

                        _useCLSCompliantNameArityEncoding = 0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 1461, 1478);

                        _forcedArity = 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(412, 1239, 2325);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(412, 1239, 2325);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 1560, 2121) || true) && (mdTypeName._fullName != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(412, 1560, 2121);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 1642, 1696);

                            _namespaceOrFullyQualifiedName = mdTypeName._fullName;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 1722, 1739);

                            _typeName = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(412, 1560, 2121);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(412, 1560, 2121);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 1837, 1885);

                            f_412_1837_1884(mdTypeName._namespaceName != null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 1911, 1954);

                            f_412_1911_1953(mdTypeName._typeName != null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 1980, 2039);

                            _namespaceOrFullyQualifiedName = mdTypeName._namespaceName;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 2065, 2098);

                            _typeName = mdTypeName._typeName;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(412, 1560, 2121);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 2145, 2245);

                        _useCLSCompliantNameArityEncoding = (DynAbs.Tracing.TraceSender.Conditional_F1(412, 2181, 2224) || ((mdTypeName.UseCLSCompliantNameArityEncoding && DynAbs.Tracing.TraceSender.Conditional_F2(412, 2227, 2234)) || DynAbs.Tracing.TraceSender.Conditional_F3(412, 2237, 2244))) ? (byte)1 : (byte)0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 2267, 2306);

                        _forcedArity = mdTypeName._forcedArity;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(412, 1239, 2325);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(412, 1162, 2340);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(412, 1162, 2340);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(412, 1162, 2340);
                }
            }

            private bool HasFullyQualifiedName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(412, 2423, 2511);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 2467, 2492);

                        return _typeName == null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(412, 2423, 2511);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(412, 2356, 2526);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(412, 2356, 2526);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool Equals(Key other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(412, 2542, 2808);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 2604, 2793);

                    return _useCLSCompliantNameArityEncoding == other._useCLSCompliantNameArityEncoding && (DynAbs.Tracing.TraceSender.Expression_True(412, 2611, 2746) && _forcedArity == other._forcedArity) && (DynAbs.Tracing.TraceSender.Expression_True(412, 2611, 2792) && EqualNames(ref other));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(412, 2542, 2808);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(412, 2542, 2808);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(412, 2542, 2808);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool EqualNames(ref Key other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(412, 2824, 3619);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 2895, 3066) || true) && (_typeName == other._typeName)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(412, 2895, 3066);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 2969, 3047);

                        return _namespaceOrFullyQualifiedName == other._namespaceOrFullyQualifiedName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(412, 2895, 3066);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 3086, 3321) || true) && (this.HasFullyQualifiedName)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(412, 3086, 3321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 3158, 3302);

                        return f_412_3165_3301(other._namespaceOrFullyQualifiedName, other._typeName, _namespaceOrFullyQualifiedName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(412, 3086, 3321);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 3341, 3571) || true) && (other.HasFullyQualifiedName)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(412, 3341, 3571);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 3414, 3552);

                        return f_412_3421_3551(_namespaceOrFullyQualifiedName, _typeName, other._namespaceOrFullyQualifiedName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(412, 3341, 3571);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 3591, 3604);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(412, 2824, 3619);

                    bool
                    f_412_3165_3301(string
                    namespaceName, string
                    typeName, string
                    fullyQualified)
                    {
                        var return_v = MetadataHelpers.SplitNameEqualsFullyQualifiedName(namespaceName, typeName, fullyQualified);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(412, 3165, 3301);
                        return return_v;
                    }


                    bool
                    f_412_3421_3551(string
                    namespaceName, string
                    typeName, string
                    fullyQualified)
                    {
                        var return_v = MetadataHelpers.SplitNameEqualsFullyQualifiedName(namespaceName, typeName, fullyQualified);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(412, 3421, 3551);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(412, 2824, 3619);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(412, 2824, 3619);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(object obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(412, 3635, 3765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 3707, 3750);

                    return obj is Key && (DynAbs.Tracing.TraceSender.Expression_True(412, 3714, 3749) && this.Equals(obj));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(412, 3635, 3765);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(412, 3635, 3765);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(412, 3635, 3765);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(412, 3781, 4017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 3847, 4002);

                    return f_412_3854_4001(GetHashCodeName(), f_412_3910_4000(_useCLSCompliantNameArityEncoding != 0, _forcedArity));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(412, 3781, 4017);

                    int
                    f_412_3910_4000(bool
                    newKeyPart, short
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKeyPart, (int)currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(412, 3910, 4000);
                        return return_v;
                    }


                    int
                    f_412_3854_4001(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(412, 3854, 4001);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(412, 3781, 4017);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(412, 3781, 4017);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private int GetHashCodeName()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(412, 4033, 4470);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 4095, 4162);

                    int
                    hashCode = f_412_4110_4161(_namespaceOrFullyQualifiedName)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 4182, 4419) || true) && (f_412_4186_4213_M(!this.HasFullyQualifiedName))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(412, 4182, 4419);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 4255, 4326);

                        hashCode = f_412_4266_4325(hashCode, MetadataHelpers.DotDelimiter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 4348, 4400);

                        hashCode = f_412_4359_4399(hashCode, _typeName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(412, 4182, 4419);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 4439, 4455);

                    return hashCode;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(412, 4033, 4470);

                    int
                    f_412_4110_4161(string
                    text)
                    {
                        var return_v = Hash.GetFNVHashCode(text);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(412, 4110, 4161);
                        return return_v;
                    }


                    bool
                    f_412_4186_4213_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(412, 4186, 4213);
                        return return_v;
                    }


                    int
                    f_412_4266_4325(int
                    hashCode, char
                    ch)
                    {
                        var return_v = Hash.CombineFNVHash(hashCode, ch);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(412, 4266, 4325);
                        return return_v;
                    }


                    int
                    f_412_4359_4399(int
                    hashCode, string
                    text)
                    {
                        var return_v = Hash.CombineFNVHash(hashCode, text);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(412, 4359, 4399);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(412, 4033, 4470);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(412, 4033, 4470);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static Key()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(412, 553, 4481);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(412, 553, 4481);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(412, 553, 4481);
            }

            static int
            f_412_1837_1884(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(412, 1837, 1884);
                return 0;
            }


            static int
            f_412_1911_1953(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(412, 1911, 1953);
                return 0;
            }

        }

        public readonly Key ToKey()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(412, 4493, 4580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(412, 4545, 4569);

                // LAFHIS
                // return f_412_4552_4568(this);
                var temp = new Microsoft.CodeAnalysis.MetadataTypeName.Key(this);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(412, 4552, 4568);
                return temp;

                DynAbs.Tracing.TraceSender.TraceExitMethod(412, 4493, 4580);

                Microsoft.CodeAnalysis.MetadataTypeName.Key
                f_412_4552_4568(Microsoft.CodeAnalysis.MetadataTypeName
                mdTypeName)
                {
                    var return_v = new Microsoft.CodeAnalysis.MetadataTypeName.Key(mdTypeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(412, 4552, 4568);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(412, 4493, 4580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(412, 4493, 4580);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
