// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.Debugging;
using Microsoft.CodeAnalysis.Emit;
using EmitContext = Microsoft.CodeAnalysis.Emit.EmitContext;

namespace Microsoft.Cci
{
    /// <summary>
    /// Specifies how the caller passes parameters to the callee and who cleans up the stack.
    /// </summary>
    [Flags]
    internal enum CallingConvention
    {
        /// <summary>
        /// C/C++ style calling convention for unmanaged methods. The call stack is cleaned up by the caller, 
        /// which makes this convention suitable for calling methods that accept extra arguments.
        /// </summary>
        CDecl = SignatureCallingConvention.CDecl,

        /// <summary>
        /// The convention for calling managed methods with a fixed number of arguments.
        /// </summary>
        Default = SignatureCallingConvention.Default,

        /// <summary>
        /// The convention for calling managed methods that accept extra arguments.
        /// </summary>
        ExtraArguments = SignatureCallingConvention.VarArgs,

        /// <summary>
        /// Arguments are passed in registers when possible. This calling convention is not yet supported.
        /// </summary>
        FastCall = SignatureCallingConvention.FastCall,

        /// <summary>
        /// Win32 API calling convention for calling unmanaged methods via PlatformInvoke. The call stack is cleaned up by the callee.
        /// </summary>
        Standard = SignatureCallingConvention.StdCall,

        /// <summary>
        /// C++ member unmanaged method (non-vararg) calling convention. The callee cleans the stack and the this pointer is pushed on the stack last.
        /// </summary>
        ThisCall = SignatureCallingConvention.ThisCall,

        /// <summary>
        /// Extensible calling convention protocol. This represents either the union of calling convention modopts after the paramcount specifier
        /// in IL, or platform default if none are present
        /// </summary>
        Unmanaged = SignatureCallingConvention.Unmanaged,

        /// <summary>
        /// The convention for calling a generic method.
        /// </summary>
        Generic = SignatureAttributes.Generic,

        /// <summary>
        /// The convention for calling an instance method with an implicit this parameter (the method does not have an explicit parameter definition for this).
        /// </summary>
        HasThis = SignatureAttributes.Instance,

        /// <summary>
        /// The convention for calling an instance method that explicitly declares its first parameter to correspond to the this instance.
        /// </summary>
        ExplicitThis = SignatureAttributes.ExplicitThis,
    }
    internal static class CallingConventionUtils
    {
        private const SignatureCallingConvention
        SignatureCallingConventionMask =
                    SignatureCallingConvention.Default
                    | SignatureCallingConvention.CDecl
                    | SignatureCallingConvention.StdCall
                    | SignatureCallingConvention.ThisCall
                    | SignatureCallingConvention.FastCall
                    | SignatureCallingConvention.VarArgs
                    | SignatureCallingConvention.Unmanaged
        ;

        private const SignatureAttributes
        SignatureAttributesMask =
                    SignatureAttributes.Generic
                    | SignatureAttributes.Instance
                    | SignatureAttributes.ExplicitThis
        ;

        internal static CallingConvention FromSignatureConvention(this SignatureCallingConvention convention)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(497, 3956, 4295);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(497, 4082, 4196) || true) && (!f_497_4087_4107(convention))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(497, 4082, 4196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(497, 4141, 4181);

                    throw f_497_4147_4180();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(497, 4082, 4196);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(497, 4212, 4284);

                return (CallingConvention)(convention & SignatureCallingConventionMask);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(497, 3956, 4295);

                bool
                f_497_4087_4107(System.Reflection.Metadata.SignatureCallingConvention
                convention)
                {
                    var return_v = convention.IsValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(497, 4087, 4107);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_497_4147_4180()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(497, 4147, 4180);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(497, 3956, 4295);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(497, 3956, 4295);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsValid(this SignatureCallingConvention convention)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(497, 4393, 4498);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(497, 4396, 4498);
                return convention <= SignatureCallingConvention.VarArgs || (DynAbs.Tracing.TraceSender.Expression_False(497, 4396, 4498) || convention == SignatureCallingConvention.Unmanaged); DynAbs.Tracing.TraceSender.TraceExitMethod(497, 4393, 4498);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(497, 4393, 4498);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(497, 4393, 4498);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SignatureCallingConvention ToSignatureConvention(this CallingConvention convention)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(497, 4624, 4698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(497, 4627, 4698);
                return (SignatureCallingConvention)convention & SignatureCallingConventionMask; DynAbs.Tracing.TraceSender.TraceExitMethod(497, 4624, 4698);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(497, 4624, 4698);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(497, 4624, 4698);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsCallingConvention(this CallingConvention original, CallingConvention compare)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(497, 4841, 5156);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(497, 4966, 5048);

                f_497_4966_5047((compare & ~(CallingConvention)SignatureCallingConventionMask) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(497, 5062, 5145);

                return ((original & (CallingConvention)SignatureCallingConventionMask)) == compare;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(497, 4841, 5156);

                int
                f_497_4966_5047(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(497, 4966, 5047);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(497, 4841, 5156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(497, 4841, 5156);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasUnknownCallingConventionAttributeBits(this CallingConvention convention)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(497, 5278, 5446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(497, 5281, 5446);
                return (convention & ~((CallingConvention)SignatureCallingConventionMask
                                               | (CallingConvention)SignatureAttributesMask))
                               != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(497, 5278, 5446);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(497, 5278, 5446);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(497, 5278, 5446);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CallingConventionUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(497, 3254, 5454);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(497, 3356, 3738);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(497, 3785, 3943);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(497, 3254, 5454);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(497, 3254, 5454);
        }

    }

    /// <summary>
    /// An event is a member that enables an object or class to provide notifications. Clients can attach executable code for events by supplying event handlers.
    /// This interface models the metadata representation of an event.
    /// </summary>
    internal interface IEventDefinition : ITypeDefinitionMember
    {

        IEnumerable<IMethodReference> GetAccessors(EmitContext context);

        IMethodReference Adder { get; }

        IMethodReference? Caller { get; }

        bool IsRuntimeSpecial { get; }

        bool IsSpecialName { get; }

        IMethodReference Remover { get; }

        ITypeReference GetType(EmitContext context);
    }

    /// <summary>
    /// A field is a member that represents a variable associated with an object or class.
    /// This interface models the metadata representation of a field.
    /// </summary>
    internal interface IFieldDefinition : ITypeDefinitionMember, IFieldReference
    {

        MetadataConstant? GetCompileTimeValue(EmitContext context);

        ImmutableArray<byte> MappedData
        {
            get;
        }

        bool IsCompileTimeConstant { get; }

        bool IsMarshalledExplicitly { get; }

        bool IsNotSerialized { get; }

        bool IsReadOnly { get; }

        bool IsRuntimeSpecial { get; }

        bool IsSpecialName { get; }

        bool IsStatic { get; }

        IMarshallingInformation? MarshallingInformation
        {
            get;
        }

        ImmutableArray<byte> MarshallingDescriptor
        {
            get;
        }

        int Offset
        {
            get;
        }
    }

    /// <summary>
    /// A reference to a field.
    /// </summary>
    internal interface IFieldReference : ITypeMemberReference
    { // TODO: add custom modifiers

        ITypeReference GetType(EmitContext context);

        IFieldDefinition? GetResolvedField(EmitContext context);

        ISpecializedFieldReference? AsSpecializedFieldReference { get; }

        bool IsContextualNamedEntity
        {
            get;
        }
    }

    /// <summary>
    /// An object that represents a local variable or constant.
    /// </summary>
    internal interface ILocalDefinition : INamedEntity
    {

        MetadataConstant CompileTimeValue
        {
            get;
        }

        ImmutableArray<ICustomModifier> CustomModifiers
        {
            get;
        }

        bool IsPinned { get; }

        bool IsReference { get; }

        LocalSlotConstraints Constraints { get; }

        LocalVariableAttributes PdbAttributes { get; }

        ImmutableArray<bool> DynamicTransformFlags { get; }

        ImmutableArray<string> TupleElementNames { get; }

        ITypeReference Type { get; }

        Location Location { get; }

        int SlotIndex { get; }

        byte[]? Signature { get; }

        LocalSlotDebugInfo SlotInfo { get; }
    }

    /// <summary>
    /// A metadata (IL) level representation of the body of a method or of a property/event accessor.
    /// </summary>
    internal interface IMethodBody
    {

        ImmutableArray<ExceptionHandlerRegion> ExceptionRegions
        {
            get;
        }

        bool AreLocalsZeroed { get; }

        bool HasStackalloc { get; }

        ImmutableArray<ILocalDefinition> LocalVariables { get; }

        IMethodDefinition MethodDefinition { get; }

        StateMachineMoveNextBodyDebugInfo MoveNextBodyInfo { get; }

        ushort MaxStack { get; }

        ImmutableArray<byte> IL { get; }

        ImmutableArray<SequencePoint> SequencePoints { get; }

        bool HasDynamicLocalVariables { get; }

        ImmutableArray<LocalScope> LocalScopes { get; }

        IImportScope ImportScope { get; }

        DebugId MethodId { get; }

        ImmutableArray<StateMachineHoistedLocalScope> StateMachineHoistedLocalScopes { get; }

        string StateMachineTypeName { get; }

        ImmutableArray<EncHoistedLocalInfo> StateMachineHoistedLocalSlots { get; }

        ImmutableArray<ITypeReference> StateMachineAwaiterSlots { get; }

        ImmutableArray<ClosureDebugInfo> ClosureDebugInfo { get; }

        ImmutableArray<LambdaDebugInfo> LambdaDebugInfo { get; }

        DynamicAnalysisMethodBodyData DynamicAnalysisData { get; }
    }

    /// <summary>
    /// This interface models the metadata representation of a method.
    /// </summary>
    internal interface IMethodDefinition : ITypeDefinitionMember, IMethodReference
    {

        IMethodBody GetBody(EmitContext context);

        IEnumerable<IGenericMethodParameter> GenericParameters
        {
            get;
        }

        bool HasDeclarativeSecurity { get; }

        bool IsAbstract { get; }

        bool IsAccessCheckedOnOverride { get; }

        bool IsConstructor { get; }

        bool IsExternal { get; }

        bool IsHiddenBySignature { get; }

        bool IsNewSlot { get; }

        bool IsPlatformInvoke { get; }

        bool IsRuntimeSpecial { get; }

        bool IsSealed { get; }

        bool IsSpecialName { get; }

        bool IsStatic { get; }

        bool IsVirtual
        {
            get;
        }

        MethodImplAttributes GetImplementationAttributes(EmitContext context);

        ImmutableArray<IParameterDefinition> Parameters { get; }

        IPlatformInvokeInformation PlatformInvokeData
        {
            get;
        }

        bool RequiresSecurityObject { get; }

        IEnumerable<ICustomAttribute> GetReturnValueAttributes(EmitContext context);

        bool ReturnValueIsMarshalledExplicitly { get; }

        IMarshallingInformation ReturnValueMarshallingInformation
        {
            get;
        }

        ImmutableArray<byte> ReturnValueMarshallingDescriptor
        {
            get;
        }

        IEnumerable<SecurityAttribute> SecurityAttributes { get; }

        INamespace ContainingNamespace { get; }
    }

    /// <summary>
    /// This interface models the metadata representation of a method or property parameter.
    /// </summary>
    internal interface IParameterDefinition : IDefinition, INamedEntity, IParameterTypeInformation
    {

        MetadataConstant? GetDefaultValue(EmitContext context);

        bool HasDefaultValue { get; }

        bool IsIn { get; }

        bool IsMarshalledExplicitly { get; }

        bool IsOptional
        {
            get;
        }

        bool IsOut { get; }

        IMarshallingInformation? MarshallingInformation
        {
            get;
        }

        ImmutableArray<byte> MarshallingDescriptor
        {
            get;
        }
    }

    /// <summary>
    /// A property is a member that provides access to an attribute of an object or a class.
    /// This interface models the metadata representation of a property.
    /// </summary>
    internal interface IPropertyDefinition : ISignature, ITypeDefinitionMember
    {

        IEnumerable<IMethodReference> GetAccessors(EmitContext context);

        MetadataConstant? DefaultValue
        {
            get;
        }

        IMethodReference? Getter { get; }

        bool HasDefaultValue { get; }

        bool IsRuntimeSpecial { get; }

        bool IsSpecialName { get; }

        ImmutableArray<IParameterDefinition> Parameters { get; }

        IMethodReference? Setter { get; }
    }

    /// <summary>
    /// The parameters and return type that makes up a method or property signature.
    /// This interface models the metadata representation of a signature.
    /// </summary>
    internal interface ISignature
    {

        CallingConvention CallingConvention { get; }

        ushort ParameterCount { get; }

        ImmutableArray<IParameterTypeInformation> GetParameters(EmitContext context);

        ImmutableArray<ICustomModifier> ReturnValueCustomModifiers
        {
            get;
        }

        ImmutableArray<ICustomModifier> RefCustomModifiers
        {
            get;
        }

        bool ReturnValueIsByRef { get; }

        ITypeReference GetType(EmitContext context);
    }

    /// <summary>
    /// A member of a type definition, such as a field or a method.
    /// This interface models the metadata representation of a type member.
    /// </summary>
    internal interface ITypeDefinitionMember : ITypeMemberReference, IDefinition
    {

        ITypeDefinition ContainingTypeDefinition { get; }

        TypeMemberVisibility Visibility { get; }
    }

    /// <summary>
    /// A reference to a member of a type, such as a field or a method.
    /// This interface models the metadata representation of a type member reference.
    /// </summary>
    internal interface ITypeMemberReference : IReference, INamedEntity
    {

        ITypeReference GetContainingType(EmitContext context);
    }

    /// <summary>
    /// Represents the specialized event definition.
    /// </summary>
    internal interface ISpecializedEventDefinition : IEventDefinition
    {

        [NotNull]
        IEventDefinition UnspecializedVersion
        {
            get;
        }
    }

    /// <summary>
    /// Represents reference specialized field.
    /// </summary>
    internal interface ISpecializedFieldReference : IFieldReference
    {

        IFieldReference UnspecializedVersion { get; }
    }

    /// <summary>
    /// Represents reference specialized method.
    /// </summary>
    internal interface ISpecializedMethodReference : IMethodReference
    {

        IMethodReference UnspecializedVersion { get; }
    }

    /// <summary>
    /// Represents the specialized property definition.
    /// </summary>
    internal interface ISpecializedPropertyDefinition : IPropertyDefinition
    {

        [NotNull]
        IPropertyDefinition UnspecializedVersion
        {
            get;
        }
    }

    /// <summary>
    /// A reference to a method.
    /// </summary>
    internal interface IMethodReference : ISignature, ITypeMemberReference
    {

        bool AcceptsExtraArguments { get; }

        ushort GenericParameterCount
        {
            get;
        }

        bool IsGeneric { get; }

        IMethodDefinition? GetResolvedMethod(EmitContext context);

        ImmutableArray<IParameterTypeInformation> ExtraParameters { get; }

        IGenericMethodInstanceReference? AsGenericMethodInstanceReference { get; }

        ISpecializedMethodReference? AsSpecializedMethodReference { get; }
    }

    /// <summary>
    /// A reference to generic method instantiated with a list of type arguments.
    /// </summary>
    internal interface IGenericMethodInstanceReference : IMethodReference
    {

        IEnumerable<ITypeReference> GetGenericArguments(EmitContext context);

        IMethodReference GetGenericMethod(EmitContext context);
        // ^ ensures result.ResolvedMethod.IsGeneric;
    }

    /// <summary>
    /// Represents a global field in symbol table.
    /// </summary>
    internal interface IGlobalFieldDefinition : IFieldDefinition
    {
    }

    /// <summary>
    /// Represents a global method in symbol table.
    /// </summary>
    internal interface IGlobalMethodDefinition : IMethodDefinition
    {

        new string Name { get; }
    }
    internal static class Extensions
    {
        internal static bool HasBody(this IMethodDefinition methodDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(497, 38833, 39259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(497, 39078, 39248);

                return f_497_39085_39106_M(!methodDef.IsAbstract) && (DynAbs.Tracing.TraceSender.Expression_True(497, 39085, 39131) && f_497_39110_39131_M(!methodDef.IsExternal)) && (DynAbs.Tracing.TraceSender.Expression_True(497, 39085, 39247) && (f_497_39153_39187(methodDef) == null || (DynAbs.Tracing.TraceSender.Expression_False(497, 39153, 39246) || f_497_39199_39246_M(!f_497_39200_39234(methodDef).IsComObject))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(497, 38833, 39259);

                bool
                f_497_39085_39106_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(497, 39085, 39106);
                    return return_v;
                }


                bool
                f_497_39110_39131_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(497, 39110, 39131);
                    return return_v;
                }


                Microsoft.Cci.ITypeDefinition
                f_497_39153_39187(Microsoft.Cci.IMethodDefinition
                this_param)
                {
                    var return_v = this_param.ContainingTypeDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(497, 39153, 39187);
                    return return_v;
                }


                Microsoft.Cci.ITypeDefinition
                f_497_39200_39234(Microsoft.Cci.IMethodDefinition
                this_param)
                {
                    var return_v = this_param.ContainingTypeDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(497, 39200, 39234);
                    return return_v;
                }


                bool
                f_497_39199_39246_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(497, 39199, 39246);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(497, 38833, 39259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(497, 38833, 39259);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool ShouldInclude(this ITypeDefinitionMember member, EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(497, 39396, 40232);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(497, 39509, 39603) || true) && (context.IncludePrivateMembers)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(497, 39509, 39603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(497, 39576, 39588);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(497, 39509, 39603);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(497, 39619, 39660);

                var
                method = member as IMethodDefinition
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(497, 39674, 39773) || true) && (method != null && (DynAbs.Tracing.TraceSender.Expression_True(497, 39678, 39712) && f_497_39696_39712(method)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(497, 39674, 39773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(497, 39746, 39758);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(497, 39674, 39773);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(497, 39789, 40195);

                switch (f_497_39797_39814(member))
                {

                    case TypeMemberVisibility.Private:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(497, 39789, 40195);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(497, 39904, 39941);

                        return context.IncludePrivateMembers;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(497, 39789, 40195);

                    case TypeMemberVisibility.Assembly:
                    case TypeMemberVisibility.FamilyAndAssembly:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(497, 39789, 40195);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(497, 40078, 40180);

                        return context.IncludePrivateMembers || (DynAbs.Tracing.TraceSender.Expression_False(497, 40085, 40179) || f_497_40118_40171_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_497_40118_40150(context.Module), 497, 40118, 40171)?.InternalsAreVisible) == true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(497, 39789, 40195);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(497, 40209, 40221);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(497, 39396, 40232);

                bool
                f_497_39696_39712(Microsoft.Cci.IMethodDefinition
                this_param)
                {
                    var return_v = this_param.IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(497, 39696, 39712);
                    return return_v;
                }


                Microsoft.Cci.TypeMemberVisibility
                f_497_39797_39814(Microsoft.Cci.ITypeDefinitionMember
                this_param)
                {
                    var return_v = this_param.Visibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(497, 39797, 39814);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.ISourceAssemblySymbolInternal
                f_497_40118_40150(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.SourceAssemblyOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(497, 40118, 40150);
                    return return_v;
                }


                bool?
                f_497_40118_40171_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(497, 40118, 40171);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(497, 39396, 40232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(497, 39396, 40232);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static Extensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(497, 38784, 40239);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(497, 38784, 40239);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(497, 38784, 40239);
        }

    }
}
