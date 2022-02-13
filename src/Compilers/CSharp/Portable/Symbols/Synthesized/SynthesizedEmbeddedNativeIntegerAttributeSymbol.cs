// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedEmbeddedNativeIntegerAttributeSymbol : SynthesizedEmbeddedAttributeSymbolBase
    {
        private readonly ImmutableArray<FieldSymbol> _fields;

        private readonly ImmutableArray<MethodSymbol> _constructors;

        private readonly TypeSymbol _boolType;

        private const string
        FieldName = "TransformFlags"
        ;

        public SynthesizedEmbeddedNativeIntegerAttributeSymbol(
                    string name,
                    NamespaceSymbol containingNamespace,
                    ModuleSymbol containingModule,
                    NamedTypeSymbol systemAttributeType,
                    TypeSymbol boolType)
        : base(f_10669_1097_1101_C(name), containingNamespace, containingModule, baseType: systemAttributeType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10669, 817, 2574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10669, 733, 742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10669, 1197, 1218);

                _boolType = boolType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10669, 1234, 1440);

                var
                boolArrayType = TypeWithAnnotations.Create(f_10669_1299_1438(f_10669_1351_1378(boolType), TypeWithAnnotations.Create(boolType)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10669, 1456, 1762);

                _fields = f_10669_1466_1761(f_10669_1519_1760(this, boolArrayType.Type, FieldName, isPublic: true, isReadOnly: true, isStatic: false));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10669, 1778, 2378);

                _constructors = f_10669_1794_2377(f_10669_1848_2076(this, m => ImmutableArray<ParameterSymbol>.Empty, (f, s, p) => GenerateParameterlessConstructorBody(f, s)), f_10669_2095_2376(this, m => ImmutableArray.Create(SynthesizedParameterSymbol.Create(m, boolArrayType, 0, RefKind.None)), (f, s, p) => GenerateBoolArrayConstructorBody(f, s, p)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10669, 2463, 2563);

                f_10669_2463_2562(_constructors.Length == f_10669_2500_2561(AttributeDescription.NativeIntegerAttribute.Signatures));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10669, 817, 2574);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10669, 817, 2574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10669, 817, 2574);
            }
        }

        internal override IEnumerable<FieldSymbol> GetFieldsToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10669, 2647, 2657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10669, 2650, 2657);
                return _fields; DynAbs.Tracing.TraceSender.TraceExitMethod(10669, 2647, 2657);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10669, 2647, 2657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10669, 2647, 2657);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<MethodSymbol> Constructors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10669, 2728, 2744);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10669, 2731, 2744);
                    return _constructors; DynAbs.Tracing.TraceSender.TraceExitMethod(10669, 2728, 2744);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10669, 2728, 2744);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10669, 2728, 2744);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10669, 2789, 2797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10669, 2792, 2797);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10669, 2789, 2797);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10669, 2789, 2797);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10669, 2789, 2797);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasPossibleWellKnownCloneMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10669, 2865, 2873);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10669, 2868, 2873);
                return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10669, 2865, 2873);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10669, 2865, 2873);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10669, 2865, 2873);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override AttributeUsageInfo GetAttributeUsageInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10669, 2886, 3302);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10669, 2971, 3291);

                return f_10669_2978_3290(AttributeTargets.Class | AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.GenericParameter | AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.ReturnValue, allowMultiple: false, inherited: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10669, 2886, 3302);

                Microsoft.CodeAnalysis.AttributeUsageInfo
                f_10669_2978_3290(System.AttributeTargets
                validTargets, bool
                allowMultiple, bool
                inherited)
                {
                    var return_v = new Microsoft.CodeAnalysis.AttributeUsageInfo(validTargets, allowMultiple: allowMultiple, inherited: inherited);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10669, 2978, 3290);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10669, 2886, 3302);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10669, 2886, 3302);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GenerateParameterlessConstructorBody(SyntheticBoundNodeFactory factory, ArrayBuilder<BoundStatement> statements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10669, 3314, 3976);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10669, 3464, 3965);

                f_10669_3464_3964(statements, f_10669_3497_3949(factory, f_10669_3547_3930(factory, f_10669_3602_3708(factory, f_10669_3646_3660(factory), _fields.Single()), f_10669_3735_3907(factory, _boolType, f_10669_3819_3880(f_10669_3858_3879(factory, true))))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10669, 3314, 3976);

                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10669_3646_3660(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10669, 3646, 3660);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10669_3602_3708(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10669, 3602, 3708);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10669_3858_3879(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, bool
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10669, 3858, 3879);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10669_3819_3880(Microsoft.CodeAnalysis.CSharp.BoundLiteral
                item)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10669, 3819, 3880);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10669_3735_3907(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                elements)
                {
                    var return_v = this_param.Array(elementType, elements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10669, 3735, 3907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10669_3547_3930(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.AssignmentExpression((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10669, 3547, 3930);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10669_3497_3949(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10669, 3497, 3949);
                    return return_v;
                }


                int
                f_10669_3464_3964(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10669, 3464, 3964);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10669, 3314, 3976);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10669, 3314, 3976);
            }
        }

        private void GenerateBoolArrayConstructorBody(SyntheticBoundNodeFactory factory, ArrayBuilder<BoundStatement> statements, ImmutableArray<ParameterSymbol> parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10669, 3988, 4556);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10669, 4178, 4545);

                f_10669_4178_4544(statements, f_10669_4211_4529(factory, f_10669_4261_4510(factory, f_10669_4316_4422(factory, f_10669_4360_4374(factory), _fields.Single()), f_10669_4449_4487(factory, parameters.Single()))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10669, 3988, 4556);

                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10669_4360_4374(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10669, 4360, 4374);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10669_4316_4422(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10669, 4316, 4422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10669_4449_4487(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                p)
                {
                    var return_v = this_param.Parameter(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10669, 4449, 4487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10669_4261_4510(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundParameter
                right)
                {
                    var return_v = this_param.AssignmentExpression((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10669, 4261, 4510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10669_4211_4529(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10669, 4211, 4529);
                    return return_v;
                }


                int
                f_10669_4178_4544(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10669, 4178, 4544);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10669, 3988, 4556);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10669, 3988, 4556);
            }
        }

        static SynthesizedEmbeddedNativeIntegerAttributeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10669, 445, 4563);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10669, 776, 804);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10669, 445, 4563);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10669, 445, 4563);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10669, 445, 4563);

        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10669_1351_1378(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        this_param)
        {
            var return_v = this_param.ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10669, 1351, 1378);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
        f_10669_1299_1438(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        declaringAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        elementType)
        {
            var return_v = ArrayTypeSymbol.CreateSZArray(declaringAssembly, elementType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10669, 1299, 1438);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbol
        f_10669_1519_1760(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNativeIntegerAttributeSymbol
        containingType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type, string
        name, bool
        isPublic, bool
        isReadOnly, bool
        isStatic)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containingType, type, name, isPublic: isPublic, isReadOnly: isReadOnly, isStatic: isStatic);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10669, 1519, 1760);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
        f_10669_1466_1761(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbol
        item)
        {
            var return_v = ImmutableArray.Create<FieldSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10669, 1466, 1761);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorWithBodySymbol
        f_10669_1848_2076(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNativeIntegerAttributeSymbol
        containingType, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
        getParameters, System.Action<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
        getConstructorBody)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorWithBodySymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containingType, getParameters, getConstructorBody);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10669, 1848, 2076);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorWithBodySymbol
        f_10669_2095_2376(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNativeIntegerAttributeSymbol
        containingType, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
        getParameters, System.Action<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
        getConstructorBody)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorWithBodySymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containingType, getParameters, getConstructorBody);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10669, 2095, 2376);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
        f_10669_1794_2377(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorWithBodySymbol
        item1, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorWithBodySymbol
        item2)
        {
            var return_v = ImmutableArray.Create<MethodSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)item1, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10669, 1794, 2377);
            return return_v;
        }


        int
        f_10669_2500_2561(byte[][]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10669, 2500, 2561);
            return return_v;
        }


        int
        f_10669_2463_2562(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10669, 2463, 2562);
            return 0;
        }


        static string
        f_10669_1097_1101_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10669, 817, 2574);
            return return_v;
        }

    }
}

