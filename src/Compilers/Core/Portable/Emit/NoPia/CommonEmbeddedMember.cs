// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Emit.NoPia
{
internal abstract partial class EmbeddedTypesManager<
        TPEModuleBuilder,
        TModuleCompilationState,
        TEmbeddedTypesManager,
        TSyntaxNode,
        TAttributeData,
        TSymbol,
        TAssemblySymbol,
        TNamedTypeSymbol,
        TFieldSymbol,
        TMethodSymbol,
        TEventSymbol,
        TPropertySymbol,
        TParameterSymbol,
        TTypeParameterSymbol,
        TEmbeddedType,
        TEmbeddedField,
        TEmbeddedMethod,
        TEmbeddedEvent,
        TEmbeddedProperty,
        TEmbeddedParameter,
        TEmbeddedTypeParameter>
{internal abstract class CommonEmbeddedMember
{
internal abstract TEmbeddedTypesManager TypeManager {get; }

public CommonEmbeddedMember()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(772,1050,1190);
DynAbs.Tracing.TraceSender.TraceExitConstructor(772,1050,1190);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(772,1050,1190);
}


static CommonEmbeddedMember()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(772,1050,1190);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(772,1050,1190);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(772,1050,1190);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(772,1050,1190);
}
internal abstract class CommonEmbeddedMember<TMember> : CommonEmbeddedMember, Cci.IReference
            where TMember : TSymbol, Cci.ITypeMemberReference
{
protected readonly TMember UnderlyingSymbol;

private ImmutableArray<TAttributeData> _lazyAttributes;

protected CommonEmbeddedMember(TMember underlyingSymbol)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(772,1511,1656);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(772,1409,1425);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(772,1600,1641);

this.UnderlyingSymbol = underlyingSymbol;
DynAbs.Tracing.TraceSender.TraceExitConstructor(772,1511,1656);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(772,1511,1656);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(772,1511,1656);
}
		}

protected abstract IEnumerable<TAttributeData> GetCustomAttributesToEmit(TPEModuleBuilder moduleBuilder);

protected virtual TAttributeData PortAttributeIfNeedTo(TAttributeData attrData, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(772,1793,1986);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(772,1959,1971);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(772,1793,1986);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(772,1793,1986);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(772,1793,1986);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

            private ImmutableArray<TAttributeData> GetAttributes(TPEModuleBuilder moduleBuilder, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
            {
                var builder = ArrayBuilder<TAttributeData>.GetInstance();

                // Copy some of the attributes.

                // Note, when porting attributes, we are not using constructors from original symbol.
                // The constructors might be missing (for example, in metadata case) and doing lookup
                // will ensure that we report appropriate errors.

                foreach (var attrData in GetCustomAttributesToEmit(moduleBuilder))
                {
                    if (TypeManager.IsTargetAttribute(UnderlyingSymbol, attrData, AttributeDescription.DispIdAttribute))
                    {
                        if (attrData.CommonConstructorArguments.Length == 1)
                        {
                            builder.AddOptional(TypeManager.CreateSynthesizedAttribute(WellKnownMember.System_Runtime_InteropServices_DispIdAttribute__ctor, attrData, syntaxNodeOpt, diagnostics));
                        }
                    }
                    else
                    {
                        builder.AddOptional(PortAttributeIfNeedTo(attrData, syntaxNodeOpt, diagnostics));
                    }
                }

                return builder.ToImmutableAndFree();
            }

            IEnumerable<Cci.ICustomAttribute> Cci.IReference.GetAttributes(EmitContext context)
            {
                if (_lazyAttributes.IsDefault)
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    var attributes = GetAttributes((TPEModuleBuilder)context.Module, (TSyntaxNode)context.SyntaxNodeOpt, diagnostics);

                    if (ImmutableInterlocked.InterlockedInitialize(ref _lazyAttributes, attributes))
                    {
                        // Save any diagnostics that we encountered.
                        context.Diagnostics.AddRange(diagnostics);
                    }

                    diagnostics.Free();
                }

                return _lazyAttributes;
            }

void Cci.IReference.Dispatch(Cci.MetadataVisitor visitor)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(772,4237,4379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(772,4327,4364);

throw f_772_4333_4363();
DynAbs.Tracing.TraceSender.TraceExitMethod(772,4237,4379);

System.Exception
f_772_4333_4363()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(772, 4333, 4363);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(772,4237,4379);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(772,4237,4379);
}
		}

Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(772,4395,4544);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(772,4492,4529);

throw f_772_4498_4528();
DynAbs.Tracing.TraceSender.TraceExitMethod(772,4395,4544);

System.Exception
f_772_4498_4528()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(772, 4498, 4528);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(772,4395,4544);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(772,4395,4544);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

Symbols.ISymbolInternal Cci.IReference.GetInternalSymbol() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(772,4619,4626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(772,4622,4626);
return null;DynAbs.Tracing.TraceSender.TraceExitMethod(772,4619,4626);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(772,4619,4626);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(772,4619,4626);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public sealed override bool Equals(object obj)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(772,4643,4938);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(772,4869,4923);

throw f_772_4875_4922();
DynAbs.Tracing.TraceSender.TraceExitMethod(772,4643,4938);

System.Exception
f_772_4875_4922()
{
var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(772, 4875, 4922);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(772,4643,4938);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(772,4643,4938);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public sealed override int GetHashCode()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(772,4954,5243);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(772,5174,5228);

throw f_772_5180_5227();
DynAbs.Tracing.TraceSender.TraceExitMethod(772,4954,5243);

System.Exception
f_772_5180_5227()
{
var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(772, 5180, 5227);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(772,4954,5243);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(772,4954,5243);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
}
