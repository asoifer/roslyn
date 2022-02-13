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
    internal sealed class SynthesizedEmbeddedNullableAttributeSymbol : SynthesizedEmbeddedAttributeSymbolBase
    {
        private readonly ImmutableArray<FieldSymbol> _fields;

        private readonly ImmutableArray<MethodSymbol> _constructors;

        private readonly TypeSymbol _byteTypeSymbol;

        private const string
        NullableFlagsFieldName = "NullableFlags"
        ;

        public SynthesizedEmbeddedNullableAttributeSymbol(
                    string name,
                    NamespaceSymbol containingNamespace,
                    ModuleSymbol containingModule,
                    NamedTypeSymbol systemAttributeType,
                    TypeSymbol systemByteType)
        : base(f_10670_1132_1136_C(name), containingNamespace, containingModule, baseType: systemAttributeType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10670, 851, 2713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10670, 749, 764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10670, 1232, 1265);

                _byteTypeSymbol = systemByteType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10670, 1281, 1348);

                var
                annotatedByteType = TypeWithAnnotations.Create(systemByteType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10670, 1364, 1557);

                var
                byteArrayType = TypeWithAnnotations.Create(f_10670_1429_1555(f_10670_1481_1514(systemByteType), annotatedByteType))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10670, 1573, 1892);

                _fields = f_10670_1583_1891(f_10670_1636_1890(this, byteArrayType.Type, NullableFlagsFieldName, isPublic: true, isReadOnly: true, isStatic: false));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10670, 1908, 2522);

                _constructors = f_10670_1924_2521(f_10670_1978_2242(this, m => ImmutableArray.Create(SynthesizedParameterSymbol.Create(m, annotatedByteType, 0, RefKind.None)), GenerateSingleByteConstructorBody), f_10670_2261_2520(this, m => ImmutableArray.Create(SynthesizedParameterSymbol.Create(m, byteArrayType, 0, RefKind.None)), GenerateByteArrayConstructorBody));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10670, 2607, 2702);

                f_10670_2607_2701(_constructors.Length == f_10670_2644_2700(AttributeDescription.NullableAttribute.Signatures));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10670, 851, 2713);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10670, 851, 2713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10670, 851, 2713);
            }
        }

        internal override IEnumerable<FieldSymbol> GetFieldsToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10670, 2786, 2796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10670, 2789, 2796);
                return _fields; DynAbs.Tracing.TraceSender.TraceExitMethod(10670, 2786, 2796);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10670, 2786, 2796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10670, 2786, 2796);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<MethodSymbol> Constructors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10670, 2867, 2883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10670, 2870, 2883);
                    return _constructors; DynAbs.Tracing.TraceSender.TraceExitMethod(10670, 2867, 2883);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10670, 2867, 2883);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10670, 2867, 2883);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10670, 2928, 2936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10670, 2931, 2936);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10670, 2928, 2936);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10670, 2928, 2936);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10670, 2928, 2936);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasPossibleWellKnownCloneMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10670, 3004, 3012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10670, 3007, 3012);
                return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10670, 3004, 3012);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10670, 3004, 3012);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10670, 3004, 3012);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override AttributeUsageInfo GetAttributeUsageInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10670, 3025, 3441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10670, 3110, 3430);

                return f_10670_3117_3429(AttributeTargets.Class | AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.GenericParameter | AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.ReturnValue, allowMultiple: false, inherited: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10670, 3025, 3441);

                Microsoft.CodeAnalysis.AttributeUsageInfo
                f_10670_3117_3429(System.AttributeTargets
                validTargets, bool
                allowMultiple, bool
                inherited)
                {
                    var return_v = new Microsoft.CodeAnalysis.AttributeUsageInfo(validTargets, allowMultiple: allowMultiple, inherited: inherited);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10670, 3117, 3429);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10670, 3025, 3441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10670, 3025, 3441);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GenerateByteArrayConstructorBody(SyntheticBoundNodeFactory factory, ArrayBuilder<BoundStatement> statements, ImmutableArray<ParameterSymbol> parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10670, 3453, 4021);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10670, 3643, 4010);

                f_10670_3643_4009(statements, f_10670_3676_3994(factory, f_10670_3726_3975(factory, f_10670_3781_3887(factory, f_10670_3825_3839(factory), _fields.Single()), f_10670_3914_3952(factory, parameters.Single()))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10670, 3453, 4021);

                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10670_3825_3839(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10670, 3825, 3839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10670_3781_3887(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10670, 3781, 3887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10670_3914_3952(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                p)
                {
                    var return_v = this_param.Parameter(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10670, 3914, 3952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10670_3726_3975(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundParameter
                right)
                {
                    var return_v = this_param.AssignmentExpression((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10670, 3726, 3975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10670_3676_3994(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10670, 3676, 3994);
                    return return_v;
                }


                int
                f_10670_3643_4009(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10670, 3643, 4009);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10670, 3453, 4021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10670, 3453, 4021);
            }
        }

        private void GenerateSingleByteConstructorBody(SyntheticBoundNodeFactory factory, ArrayBuilder<BoundStatement> statements, ImmutableArray<ParameterSymbol> parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10670, 4033, 4823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10670, 4224, 4812);

                f_10670_4224_4811(statements, f_10670_4257_4796(factory, f_10670_4307_4777(factory, f_10670_4362_4468(factory, f_10670_4406_4420(factory), _fields.Single()), f_10670_4495_4754(factory, _byteTypeSymbol, f_10670_4585_4727(f_10670_4658_4696(factory, parameters.Single()))))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10670, 4033, 4823);

                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10670_4406_4420(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10670, 4406, 4420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10670_4362_4468(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10670, 4362, 4468);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10670_4658_4696(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                p)
                {
                    var return_v = this_param.Parameter(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10670, 4658, 4696);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10670_4585_4727(Microsoft.CodeAnalysis.CSharp.BoundParameter
                item)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10670, 4585, 4727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10670_4495_4754(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                elements)
                {
                    var return_v = this_param.Array(elementType, elements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10670, 4495, 4754);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10670_4307_4777(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.AssignmentExpression((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10670, 4307, 4777);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10670_4257_4796(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10670, 4257, 4796);
                    return return_v;
                }


                int
                f_10670_4224_4811(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10670, 4224, 4811);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10670, 4033, 4823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10670, 4033, 4823);
            }
        }

        static SynthesizedEmbeddedNullableAttributeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10670, 466, 4830);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10670, 798, 838);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10670, 466, 4830);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10670, 466, 4830);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10670, 466, 4830);

        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10670_1481_1514(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        this_param)
        {
            var return_v = this_param.ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10670, 1481, 1514);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
        f_10670_1429_1555(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        declaringAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        elementType)
        {
            var return_v = ArrayTypeSymbol.CreateSZArray(declaringAssembly, elementType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10670, 1429, 1555);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbol
        f_10670_1636_1890(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullableAttributeSymbol
        containingType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type, string
        name, bool
        isPublic, bool
        isReadOnly, bool
        isStatic)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containingType, type, name, isPublic: isPublic, isReadOnly: isReadOnly, isStatic: isStatic);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10670, 1636, 1890);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
        f_10670_1583_1891(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbol
        item)
        {
            var return_v = ImmutableArray.Create<FieldSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10670, 1583, 1891);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorWithBodySymbol
        f_10670_1978_2242(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullableAttributeSymbol
        containingType, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
        getParameters, System.Action<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
        getConstructorBody)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorWithBodySymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containingType, getParameters, getConstructorBody);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10670, 1978, 2242);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorWithBodySymbol
        f_10670_2261_2520(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedNullableAttributeSymbol
        containingType, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
        getParameters, System.Action<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
        getConstructorBody)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorWithBodySymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containingType, getParameters, getConstructorBody);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10670, 2261, 2520);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
        f_10670_1924_2521(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorWithBodySymbol
        item1, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorWithBodySymbol
        item2)
        {
            var return_v = ImmutableArray.Create<MethodSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)item1, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10670, 1924, 2521);
            return return_v;
        }


        int
        f_10670_2644_2700(byte[][]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10670, 2644, 2700);
            return return_v;
        }


        int
        f_10670_2607_2701(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10670, 2607, 2701);
            return 0;
        }


        static string
        f_10670_1132_1136_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10670, 851, 2713);
            return return_v;
        }

    }
    internal sealed class SynthesizedEmbeddedAttributeConstructorWithBodySymbol : SynthesizedInstanceConstructor
    {
        private readonly ImmutableArray<ParameterSymbol> _parameters;

        private readonly Action<SyntheticBoundNodeFactory, ArrayBuilder<BoundStatement>, ImmutableArray<ParameterSymbol>> _getConstructorBody;

        internal SynthesizedEmbeddedAttributeConstructorWithBodySymbol(
                    NamedTypeSymbol containingType,
                    Func<MethodSymbol, ImmutableArray<ParameterSymbol>> getParameters,
                    Action<SyntheticBoundNodeFactory, ArrayBuilder<BoundStatement>, ImmutableArray<ParameterSymbol>> getConstructorBody) : base(f_10670_5521_5535_C(containingType))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10670, 5182, 5661);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10670, 5150, 5169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10670, 5561, 5595);

                _parameters = f_10670_5575_5594(getParameters, this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10670, 5609, 5650);

                _getConstructorBody = getConstructorBody;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10670, 5182, 5661);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10670, 5182, 5661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10670, 5182, 5661);
            }
        }

        public override ImmutableArray<ParameterSymbol> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10670, 5732, 5746);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10670, 5735, 5746);
                    return _parameters; DynAbs.Tracing.TraceSender.TraceExitMethod(10670, 5732, 5746);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10670, 5732, 5746);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10670, 5732, 5746);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void GenerateMethodBody(TypeCompilationState compilationState, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10670, 5759, 5956);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10670, 5891, 5945);

                f_10670_5891_5944(this, compilationState, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10670, 5759, 5956);

                int
                f_10670_5891_5944(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorWithBodySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.GenerateMethodBodyCore(compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10670, 5891, 5944);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10670, 5759, 5956);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10670, 5759, 5956);
            }
        }

        internal override void GenerateMethodBodyStatements(SyntheticBoundNodeFactory factory, ArrayBuilder<BoundStatement> statements, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10670, 6123, 6179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10670, 6126, 6179);
                f_10670_6126_6179(this, factory, statements, _parameters); DynAbs.Tracing.TraceSender.TraceExitMethod(10670, 6123, 6179);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10670, 6123, 6179);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10670, 6123, 6179);
            }

            int
            f_10670_6126_6179(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorWithBodySymbol
            this_param, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
            arg1, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
            arg2, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            arg3)
            {
                this_param._getConstructorBody(arg1, arg2, arg3);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10670, 6126, 6179);
                return 0;
            }

        }

        static SynthesizedEmbeddedAttributeConstructorWithBodySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10670, 4838, 6187);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10670, 4838, 6187);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10670, 4838, 6187);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10670, 4838, 6187);

        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_10670_5575_5594(System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEmbeddedAttributeConstructorWithBodySymbol
        arg)
        {
            var return_v = this_param.Invoke((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)arg);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10670, 5575, 5594);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10670_5521_5535_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10670, 5182, 5661);
            return return_v;
        }

    }
}

