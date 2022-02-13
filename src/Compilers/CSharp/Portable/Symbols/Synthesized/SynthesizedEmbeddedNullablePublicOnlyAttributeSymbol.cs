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
    internal sealed class SynthesizedEmbeddedNullablePublicOnlyAttributeSymbol : SynthesizedEmbeddedAttributeSymbolBase
    {
        private readonly ImmutableArray<FieldSymbol> _fields;

        private readonly ImmutableArray<MethodSymbol> _constructors;

        public SynthesizedEmbeddedNullablePublicOnlyAttributeSymbol(
                    string name,
                    NamespaceSymbol containingNamespace,
                    ModuleSymbol containingModule,
                    NamedTypeSymbol systemAttributeType,
                    TypeSymbol systemBooleanType)
        : base(f_10672_1027_1031_C(name), containingNamespace, containingModule, baseType: systemAttributeType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10672, 733, 2013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10672, 1127, 1442);

                _fields = f_10672_1137_1441(f_10672_1190_1440(this, systemBooleanType, "IncludesInternals", isPublic: true, isReadOnly: true, isStatic: false));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10672, 1458, 1812);

                _constructors = f_10672_1474_1811(f_10672_1528_1810(this, m => ImmutableArray.Create(SynthesizedParameterSymbol.Create(m, TypeWithAnnotations.Create(systemBooleanType), 0, RefKind.None)), GenerateConstructorBody));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10672, 1897, 2002);

                f_10672_1897_2001(_constructors.Length == f_10672_1934_2000(AttributeDescription.NullablePublicOnlyAttribute.Signatures));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10672, 733, 2013);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10672, 733, 2013);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10672, 733, 2013);
            }
        }

        internal override IEnumerable<FieldSymbol> GetFieldsToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10672, 2086, 2096);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10672, 2089, 2096);
                return _fields; DynAbs.Tracing.TraceSender.TraceExitMethod(10672, 2086, 2096);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10672, 2086, 2096);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10672, 2086, 2096);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<MethodSymbol> Constructors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10672, 2167, 2183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10672, 2170, 2183);
                    return _constructors; DynAbs.Tracing.TraceSender.TraceExitMethod(10672, 2167, 2183);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10672, 2167, 2183);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10672, 2167, 2183);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10672, 2228, 2236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10672, 2231, 2236);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10672, 2228, 2236);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10672, 2228, 2236);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10672, 2228, 2236);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasPossibleWellKnownCloneMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10672, 2304, 2312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10672, 2307, 2312);
                return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10672, 2304, 2312);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10672, 2304, 2312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10672, 2304, 2312);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override AttributeUsageInfo GetAttributeUsageInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10672, 2325, 2516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10672, 2410, 2505);

                return f_10672_2417_2504(AttributeTargets.Module, allowMultiple: false, inherited: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10672, 2325, 2516);

                Microsoft.CodeAnalysis.AttributeUsageInfo
                f_10672_2417_2504(System.AttributeTargets
                validTargets, bool
                allowMultiple, bool
                inherited)
                {
                    var return_v = new Microsoft.CodeAnalysis.AttributeUsageInfo(validTargets, allowMultiple: allowMultiple, inherited: inherited);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10672, 2417, 2504);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10672, 2325, 2516);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10672, 2325, 2516);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GenerateConstructorBody(SyntheticBoundNodeFactory factory, ArrayBuilder<BoundStatement> statements, ImmutableArray<ParameterSymbol> parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10672, 2528, 2974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10672, 2709, 2963);

                f_10672_2709_2962(statements, f_10672_2742_2961(factory, f_10672_2792_2960(factory, f_10672_2847_2894(factory, f_10672_2861_2875(factory), _fields.Single()), f_10672_2921_2959(factory, parameters.Single()))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10672, 2528, 2974);

                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10672_2861_2875(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10672, 2861, 2875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10672_2847_2894(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10672, 2847, 2894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10672_2921_2959(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                p)
                {
                    var return_v = this_param.Parameter(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10672, 2921, 2959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10672_2792_2960(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundParameter
                right)
                {
                    var return_v = this_param.AssignmentExpression((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10672, 2792, 2960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10672_2742_2961(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10672, 2742, 2961);
                    return return_v;
                }


                int
                f_10672_2709_2962(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10672, 2709, 2962);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10672, 2528, 2974);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10672, 2528, 2974);
            }
        }

        static SynthesizedEmbeddedNullablePublicOnlyAttributeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10672, 466, 2981);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10672, 466, 2981);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10672, 466, 2981);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10672, 466, 2981);

        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbol
        f_10672_1190_1440(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullablePublicOnlyAttributeSymbol
        containingType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type, string
        name, bool
        isPublic, bool
        isReadOnly, bool
        isStatic)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containingType, type, name, isPublic: isPublic, isReadOnly: isReadOnly, isStatic: isStatic);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10672, 1190, 1440);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
        f_10672_1137_1441(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbol
        item)
        {
            var return_v = ImmutableArray.Create<FieldSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10672, 1137, 1441);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorWithBodySymbol
        f_10672_1528_1810(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullablePublicOnlyAttributeSymbol
        containingType, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
        getParameters, System.Action<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
        getConstructorBody)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorWithBodySymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containingType, getParameters, getConstructorBody);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10672, 1528, 1810);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
        f_10672_1474_1811(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorWithBodySymbol
        item)
        {
            var return_v = ImmutableArray.Create<MethodSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10672, 1474, 1811);
            return return_v;
        }


        int
        f_10672_1934_2000(byte[][]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10672, 1934, 2000);
            return return_v;
        }


        int
        f_10672_1897_2001(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10672, 1897, 2001);
            return 0;
        }


        static string
        f_10672_1027_1031_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10672, 733, 2013);
            return return_v;
        }

    }
}
