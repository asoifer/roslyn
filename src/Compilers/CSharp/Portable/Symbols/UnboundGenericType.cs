// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal static partial class TypeSymbolExtensions
    {
        public static NamedTypeSymbol AsUnboundGenericType(this NamedTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10178, 644, 1819);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 746, 969) || true) && (f_10178_750_769_M(!type.IsGenericType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10178, 746, 969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 916, 954);

                    throw f_10178_922_953();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10178, 746, 969);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 985, 1024);

                var
                original = f_10178_1000_1023(type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 1038, 1061);

                int
                n = f_10178_1046_1060(original)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 1075, 1140);

                NamedTypeSymbol
                originalContainingType = f_10178_1116_1139(original)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 1156, 1395);

                var
                constructedFrom = (DynAbs.Tracing.TraceSender.Conditional_F1(10178, 1178, 1218) || ((((object)originalContainingType == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10178, 1238, 1246)) || DynAbs.Tracing.TraceSender.Conditional_F3(10178, 1266, 1394))) ? original : f_10178_1266_1394(original, (DynAbs.Tracing.TraceSender.Conditional_F1(10178, 1284, 1320) || ((f_10178_1284_1320(originalContainingType) && DynAbs.Tracing.TraceSender.Conditional_F2(10178, 1323, 1368)) || DynAbs.Tracing.TraceSender.Conditional_F3(10178, 1371, 1393))) ? f_10178_1323_1368(originalContainingType) : originalContainingType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 1409, 1491) || true) && (n == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10178, 1409, 1491);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 1453, 1476);

                    return constructedFrom;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10178, 1409, 1491);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 1507, 1731);

                var
                typeArguments = f_10178_1527_1730(f_10178_1596_1626(constructedFrom), n, f_10178_1665_1729(ErrorCode.ERR_UnexpectedUnboundGenericName))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 1745, 1808);

                return f_10178_1752_1807(constructedFrom, typeArguments, unbound: true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10178, 644, 1819);

                bool
                f_10178_750_769_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10178, 750, 769);
                    return return_v;
                }


                System.InvalidOperationException
                f_10178_922_953()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10178, 922, 953);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10178_1000_1023(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10178, 1000, 1023);
                    return return_v;
                }


                int
                f_10178_1046_1060(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10178, 1046, 1060);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10178_1116_1139(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10178, 1116, 1139);
                    return return_v;
                }


                bool
                f_10178_1284_1320(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10178, 1284, 1320);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10178_1323_1368(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.AsUnboundGenericType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10178, 1323, 1368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10178_1266_1394(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10178, 1266, 1394);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10178_1596_1626(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10178, 1596, 1626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10178_1665_1729(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10178, 1665, 1729);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10178_1527_1730(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, int
                n, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                errorInfo)
                {
                    var return_v = UnboundArgumentErrorTypeSymbol.CreateTypeArguments(typeParameters, n, (Microsoft.CodeAnalysis.DiagnosticInfo)errorInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10178, 1527, 1730);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10178_1752_1807(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, bool
                unbound)
                {
                    var return_v = this_param.Construct(typeArguments, unbound: unbound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10178, 1752, 1807);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10178, 644, 1819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10178, 644, 1819);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
    internal sealed class UnboundArgumentErrorTypeSymbol : ErrorTypeSymbol
    {
        public static ImmutableArray<TypeWithAnnotations> CreateTypeArguments(ImmutableArray<TypeParameterSymbol> typeParameters, int n, DiagnosticInfo errorInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10178, 1921, 2502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 2100, 2161);

                var
                result = f_10178_2113_2160()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 2184, 2189);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 2175, 2442) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 2198, 2201)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10178, 2175, 2442))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10178, 2175, 2442);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 2235, 2317);

                        string
                        name = (DynAbs.Tracing.TraceSender.Conditional_F1(10178, 2249, 2276) || (((i < typeParameters.Length) && DynAbs.Tracing.TraceSender.Conditional_F2(10178, 2279, 2301)) || DynAbs.Tracing.TraceSender.Conditional_F3(10178, 2304, 2316))) ? f_10178_2279_2301(typeParameters[i]) : string.Empty
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 2335, 2427);

                        f_10178_2335_2426(result, TypeWithAnnotations.Create(f_10178_2373_2424(name, errorInfo)));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10178, 1, 268);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10178, 1, 268);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 2456, 2491);

                return f_10178_2463_2490(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10178, 1921, 2502);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10178_2113_2160()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10178, 2113, 2160);
                    return return_v;
                }


                string
                f_10178_2279_2301(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10178, 2279, 2301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.UnboundArgumentErrorTypeSymbol
                f_10178_2373_2424(string
                name, Microsoft.CodeAnalysis.DiagnosticInfo
                errorInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnboundArgumentErrorTypeSymbol(name, errorInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10178, 2373, 2424);
                    return return_v;
                }


                int
                f_10178_2335_2426(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10178, 2335, 2426);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10178_2463_2490(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10178, 2463, 2490);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10178, 1921, 2502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10178, 1921, 2502);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static readonly ErrorTypeSymbol Instance;

        private readonly string _name;

        private readonly DiagnosticInfo _errorInfo;

        private UnboundArgumentErrorTypeSymbol(string name, DiagnosticInfo errorInfo, TupleExtraData? tupleData = null)
        : base(f_10178_2918_2927_C(tupleData))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10178, 2786, 3014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 2715, 2720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 2763, 2773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 2953, 2966);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 2980, 3003);

                _errorInfo = errorInfo;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10178, 2786, 3014);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10178, 2786, 3014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10178, 2786, 3014);
            }
        }

        protected override NamedTypeSymbol WithTupleDataCore(TupleExtraData newData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10178, 3026, 3208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 3127, 3197);

                return f_10178_3134_3196(_name, _errorInfo, newData);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10178, 3026, 3208);

                Microsoft.CodeAnalysis.CSharp.Symbols.UnboundArgumentErrorTypeSymbol
                f_10178_3134_3196(string
                name, Microsoft.CodeAnalysis.DiagnosticInfo
                errorInfo, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                tupleData)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnboundArgumentErrorTypeSymbol(name, errorInfo, tupleData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10178, 3134, 3196);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10178, 3026, 3208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10178, 3026, 3208);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10178, 3272, 3336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 3308, 3321);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10178, 3272, 3336);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10178, 3220, 3347);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10178, 3220, 3347);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool MangleName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10178, 3417, 3524);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 3453, 3478);

                    f_10178_3453_3477(f_10178_3466_3471() == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 3496, 3509);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10178, 3417, 3524);

                    int
                    f_10178_3466_3471()
                    {
                        var return_v = Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10178, 3466, 3471);
                        return return_v;
                    }


                    int
                    f_10178_3453_3477(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10178, 3453, 3477);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10178, 3359, 3535);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10178, 3359, 3535);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override DiagnosticInfo ErrorInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10178, 3614, 3683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 3650, 3668);

                    return _errorInfo;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10178, 3614, 3683);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10178, 3547, 3694);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10178, 3547, 3694);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool Equals(TypeSymbol t2, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10178, 3706, 4152);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 3803, 3894) || true) && ((object)t2 == (object)this)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10178, 3803, 3894);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 3867, 3879);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10178, 3803, 3894);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 3910, 3987);

                UnboundArgumentErrorTypeSymbol?
                other = t2 as UnboundArgumentErrorTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 4001, 4141);

                return (object?)other != null && (DynAbs.Tracing.TraceSender.Expression_True(10178, 4008, 4093) && f_10178_4034_4093(other._name, _name, StringComparison.Ordinal)) && (DynAbs.Tracing.TraceSender.Expression_True(10178, 4008, 4140) && f_10178_4097_4140(other._errorInfo, _errorInfo));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10178, 3706, 4152);

                bool
                f_10178_4034_4093(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10178, 4034, 4093);
                    return return_v;
                }


                bool
                f_10178_4097_4140(Microsoft.CodeAnalysis.DiagnosticInfo
                objA, Microsoft.CodeAnalysis.DiagnosticInfo
                objB)
                {
                    var return_v = object.Equals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10178, 4097, 4140);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10178, 3706, 4152);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10178, 3706, 4152);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10178, 4164, 4354);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 4222, 4343);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10178, 4229, 4247) || ((_errorInfo == null
                && DynAbs.Tracing.TraceSender.Conditional_F2(10178, 4267, 4286)) || DynAbs.Tracing.TraceSender.Conditional_F3(10178, 4306, 4342))) ? f_10178_4267_4286(_name) : f_10178_4306_4342(_name, f_10178_4326_4341(_errorInfo));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10178, 4164, 4354);

                int
                f_10178_4267_4286(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10178, 4267, 4286);
                    return return_v;
                }


                int
                f_10178_4326_4341(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10178, 4326, 4341);
                    return return_v;
                }


                int
                f_10178_4306_4342(string
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10178, 4306, 4342);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10178, 4164, 4354);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10178, 4164, 4354);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static UnboundArgumentErrorTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10178, 1834, 4361);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10178, 2553, 2678);
            Instance = f_10178_2564_2678(string.Empty, f_10178_2613_2677(ErrorCode.ERR_UnexpectedUnboundGenericName)); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10178, 1834, 4361);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10178, 1834, 4361);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10178, 1834, 4361);

        static Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10178_2613_2677(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10178, 2613, 2677);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.UnboundArgumentErrorTypeSymbol
        f_10178_2564_2678(string
        name, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        errorInfo)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnboundArgumentErrorTypeSymbol(name, (Microsoft.CodeAnalysis.DiagnosticInfo)errorInfo);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10178, 2564, 2678);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
        f_10178_2918_2927_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10178, 2786, 3014);
            return return_v;
        }

    }
}
