// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedEmbeddedNullableContextAttributeSymbol : SynthesizedEmbeddedAttributeSymbolBase
    {
        private readonly ImmutableArray<FieldSymbol> _fields;

        private readonly ImmutableArray<MethodSymbol> _constructors;

        public SynthesizedEmbeddedNullableContextAttributeSymbol(
                    string name,
                    NamespaceSymbol containingNamespace,
                    ModuleSymbol containingModule,
                    NamedTypeSymbol systemAttributeType,
                    TypeSymbol systemByteType)
        : base(f_10671_1018_1022_C(name), containingNamespace, containingModule, baseType: systemAttributeType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10671, 730, 1982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10671, 1118, 1417);

                _fields = f_10671_1128_1416(f_10671_1181_1415(this, systemByteType, "Flag", isPublic: true, isReadOnly: true, isStatic: false));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10671, 1433, 1784);

                _constructors = f_10671_1449_1783(f_10671_1503_1782(this, m => ImmutableArray.Create(SynthesizedParameterSymbol.Create(m, TypeWithAnnotations.Create(systemByteType), 0, RefKind.None)), GenerateConstructorBody));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10671, 1869, 1971);

                f_10671_1869_1970(_constructors.Length == f_10671_1906_1969(AttributeDescription.NullableContextAttribute.Signatures));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10671, 730, 1982);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10671, 730, 1982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10671, 730, 1982);
            }
        }

        internal override IEnumerable<FieldSymbol> GetFieldsToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10671, 2055, 2065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10671, 2058, 2065);
                return _fields; DynAbs.Tracing.TraceSender.TraceExitMethod(10671, 2055, 2065);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10671, 2055, 2065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10671, 2055, 2065);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<MethodSymbol> Constructors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10671, 2136, 2152);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10671, 2139, 2152);
                    return _constructors; DynAbs.Tracing.TraceSender.TraceExitMethod(10671, 2136, 2152);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10671, 2136, 2152);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10671, 2136, 2152);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10671, 2197, 2205);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10671, 2200, 2205);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10671, 2197, 2205);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10671, 2197, 2205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10671, 2197, 2205);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasPossibleWellKnownCloneMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10671, 2273, 2281);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10671, 2276, 2281);
                return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10671, 2273, 2281);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10671, 2273, 2281);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10671, 2273, 2281);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override AttributeUsageInfo GetAttributeUsageInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10671, 2294, 2645);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10671, 2379, 2634);

                return f_10671_2386_2633(AttributeTargets.Class | AttributeTargets.Delegate | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Struct, allowMultiple: false, inherited: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10671, 2294, 2645);

                Microsoft.CodeAnalysis.AttributeUsageInfo
                f_10671_2386_2633(System.AttributeTargets
                validTargets, bool
                allowMultiple, bool
                inherited)
                {
                    var return_v = new Microsoft.CodeAnalysis.AttributeUsageInfo(validTargets, allowMultiple: allowMultiple, inherited: inherited);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10671, 2386, 2633);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10671, 2294, 2645);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10671, 2294, 2645);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GenerateConstructorBody(SyntheticBoundNodeFactory factory, ArrayBuilder<BoundStatement> statements, ImmutableArray<ParameterSymbol> parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10671, 2657, 3103);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10671, 2838, 3092);

                f_10671_2838_3091(statements, f_10671_2871_3090(factory, f_10671_2921_3089(factory, f_10671_2976_3023(factory, f_10671_2990_3004(factory), _fields.Single()), f_10671_3050_3088(factory, parameters.Single()))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10671, 2657, 3103);

                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10671_2990_3004(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10671, 2990, 3004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10671_2976_3023(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10671, 2976, 3023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10671_3050_3088(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                p)
                {
                    var return_v = this_param.Parameter(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10671, 3050, 3088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10671_2921_3089(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundParameter
                right)
                {
                    var return_v = this_param.AssignmentExpression((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10671, 2921, 3089);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10671_2871_3090(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10671, 2871, 3090);
                    return return_v;
                }


                int
                f_10671_2838_3091(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10671, 2838, 3091);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10671, 2657, 3103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10671, 2657, 3103);
            }
        }

        static SynthesizedEmbeddedNullableContextAttributeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10671, 466, 3110);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10671, 466, 3110);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10671, 466, 3110);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10671, 466, 3110);

        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbol
        f_10671_1181_1415(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullableContextAttributeSymbol
        containingType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type, string
        name, bool
        isPublic, bool
        isReadOnly, bool
        isStatic)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containingType, type, name, isPublic: isPublic, isReadOnly: isReadOnly, isStatic: isStatic);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10671, 1181, 1415);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
        f_10671_1128_1416(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbol
        item)
        {
            var return_v = ImmutableArray.Create<FieldSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10671, 1128, 1416);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorWithBodySymbol
        f_10671_1503_1782(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullableContextAttributeSymbol
        containingType, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
        getParameters, System.Action<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
        getConstructorBody)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorWithBodySymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containingType, getParameters, getConstructorBody);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10671, 1503, 1782);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
        f_10671_1449_1783(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorWithBodySymbol
        item)
        {
            var return_v = ImmutableArray.Create<MethodSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10671, 1449, 1783);
            return return_v;
        }


        int
        f_10671_1906_1969(byte[][]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10671, 1906, 1969);
            return return_v;
        }


        int
        f_10671_1869_1970(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10671, 1869, 1970);
            return 0;
        }


        static string
        f_10671_1018_1022_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10671, 730, 1982);
            return return_v;
        }

    }
}
