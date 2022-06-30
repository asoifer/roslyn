// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Symbols;
using EmitContext = Microsoft.CodeAnalysis.Emit.EmitContext;

namespace Microsoft.Cci
{
    internal enum PlatformType
    {
        SystemObject = CodeAnalysis.SpecialType.System_Object,
        SystemDecimal = CodeAnalysis.SpecialType.System_Decimal,
        SystemTypedReference = CodeAnalysis.SpecialType.System_TypedReference,
        SystemType = CodeAnalysis.WellKnownType.System_Type,
        SystemInt32 = CodeAnalysis.SpecialType.System_Int32,
        SystemVoid = CodeAnalysis.SpecialType.System_Void,
        SystemString = CodeAnalysis.SpecialType.System_String,
    }

    /// <summary>
    /// This interface models the metadata representation of an array type reference.
    /// </summary>
    internal interface IArrayTypeReference : ITypeReference
    {

        ITypeReference GetElementType(EmitContext context);

        bool IsSZArray
        {
            get;
        }

        ImmutableArray<int> LowerBounds
        {
            get;
        }

        int Rank
        {
            get;
        }

        ImmutableArray<int> Sizes
        {
            get;
        }
    }

    /// <summary>
    /// Modifies the set of allowed values for a type, or the semantics of operations allowed on those values. 
    /// Custom modifiers are not associated directly with types, but rather with typed storage locations for values.
    /// </summary>
    internal interface ICustomModifier
    {

        bool IsOptional { get; }

        ITypeReference GetModifier(EmitContext context);
    }

    /// <summary>
    /// Information that describes a method or property parameter, but does not include all the information in a IParameterDefinition.
    /// </summary>
    internal interface IParameterTypeInformation : IParameterListEntry
    {

        ImmutableArray<ICustomModifier> CustomModifiers
        {
            get;
        }

        ImmutableArray<ICustomModifier> RefCustomModifiers
        {
            get;
        }

        bool IsByReference { get; }

        ITypeReference GetType(EmitContext context);
    }

    /// <summary>
    /// The definition of a type parameter of a generic type or method.
    /// </summary>
    internal interface IGenericParameter : IGenericParameterReference
    {

        IEnumerable<TypeReferenceWithAttributes> GetConstraints(EmitContext context);

        bool MustBeReferenceType
        {
            get;
        }

        bool MustBeValueType
        {
            get;
        }

        bool MustHaveDefaultConstructor { get; }

        TypeParameterVariance Variance { get; }

        IGenericMethodParameter? AsGenericMethodParameter { get; }

        IGenericTypeParameter? AsGenericTypeParameter { get; }
    }

    /// <summary>
    /// A reference to the definition of a type parameter of a generic type or method.
    /// </summary>
    internal interface IGenericParameterReference : ITypeReference, INamedEntity, IParameterListEntry
    {
    }

    /// <summary>
    /// The definition of a type parameter of a generic method.
    /// </summary>
    internal interface IGenericMethodParameter : IGenericParameter, IGenericMethodParameterReference
    {

        new IMethodDefinition DefiningMethod
        {
            get;
        }
    }

    /// <summary>
    /// A reference to a type parameter of a generic method.
    /// </summary>
    internal interface IGenericMethodParameterReference : IGenericParameterReference
    {

        IMethodReference DefiningMethod { get; }
    }

    /// <summary>
    /// A generic type instantiated with a list of type arguments
    /// </summary>
    internal interface IGenericTypeInstanceReference : ITypeReference
    {

        ImmutableArray<ITypeReference> GetGenericArguments(EmitContext context);

        INamedTypeReference GetGenericType(EmitContext context);
        // ^ ensures result.ResolvedType.IsGeneric;
    }

    /// <summary>
    /// The definition of a type parameter of a generic type.
    /// </summary>
    internal interface IGenericTypeParameter : IGenericParameter, IGenericTypeParameterReference
    {

        new ITypeDefinition DefiningType { get; }
    }

    /// <summary>
    /// A reference to a type parameter of a generic type.
    /// </summary>
    internal interface IGenericTypeParameterReference : IGenericParameterReference
    {

        ITypeReference DefiningType { get; }
    }

    /// <summary>
    /// A reference to a named type, such as an INamespaceTypeReference or an INestedTypeReference.
    /// </summary>
    internal interface INamedTypeReference : ITypeReference, INamedEntity
    {

        ushort GenericParameterCount { get; }

        bool MangleName { get; }
    }

    /// <summary>
    /// A named type definition, such as an INamespaceTypeDefinition or an INestedTypeDefinition.
    /// </summary>
    internal interface INamedTypeDefinition : ITypeDefinition, INamedTypeReference
    {
    }

    /// <summary>
    /// A type definition that is a member of a namespace definition.
    /// </summary>
    internal interface INamespaceTypeDefinition : INamedTypeDefinition, INamespaceTypeReference
    {

        bool IsPublic { get; }
    }

    /// <summary>
    /// Represents a namespace.
    /// </summary>
    internal interface INamespace : INamedEntity
    {

        INamespace ContainingNamespace { get; }

        INamespaceSymbolInternal GetInternalSymbol();
    }

    /// <summary>
    /// A reference to a type definition that is a member of a namespace definition.
    /// </summary>
    internal interface INamespaceTypeReference : INamedTypeReference
    {

        IUnitReference GetUnit(EmitContext context);

        string NamespaceName { get; }
    }

    /// <summary>
    /// A type definition that is a member of another type definition.
    /// </summary>
    internal interface INestedTypeDefinition : INamedTypeDefinition, ITypeDefinitionMember, INestedTypeReference
    {
    }

    /// <summary>
    /// A type definition that is a member of another type definition.
    /// </summary>
    internal interface INestedTypeReference : INamedTypeReference, ITypeMemberReference
    {
    }

    /// <summary>
    /// A reference to a type definition that is a specialized nested type.
    /// </summary>
    internal interface ISpecializedNestedTypeReference : INestedTypeReference
    {

        [return: NotNull]
        INestedTypeReference GetUnspecializedVersion(EmitContext context);
    }

    internal struct MethodImplementation
    {

        public readonly Cci.IMethodDefinition ImplementingMethod;

        public readonly Cci.IMethodReference ImplementedMethod;

        public MethodImplementation(Cci.IMethodDefinition ImplementingMethod, Cci.IMethodReference ImplementedMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(520, 13253, 13500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(520, 13387, 13432);

                this.ImplementingMethod = ImplementingMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(520, 13446, 13489);

                this.ImplementedMethod = ImplementedMethod;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(520, 13253, 13500);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(520, 13253, 13500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(520, 13253, 13500);
            }
        }

        public Cci.ITypeDefinition ContainingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(520, 13771, 13830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(520, 13777, 13828);

                    return f_520_13784_13827(ImplementingMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(520, 13771, 13830);

                    Microsoft.Cci.ITypeDefinition
                    f_520_13784_13827(Microsoft.Cci.IMethodDefinition
                    this_param)
                    {
                        var return_v = this_param.ContainingTypeDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(520, 13784, 13827);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(520, 13705, 13841);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(520, 13705, 13841);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
        static MethodImplementation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(520, 12751, 13848);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(520, 12751, 13848);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(520, 12751, 13848);
        }
    }

    /// <summary>
    /// A type reference that has custom modifiers associated with it. For example a reference to the target type of a managed pointer to a constant.
    /// </summary>
    internal interface IModifiedTypeReference : ITypeReference
    {

        ImmutableArray<ICustomModifier> CustomModifiers { get; }

        ITypeReference UnmodifiedType { get; }
    }

    /// <summary>
    /// This interface models the metadata representation of a pointer to a location in unmanaged memory.
    /// </summary>
    internal interface IPointerTypeReference : ITypeReference
    {

        ITypeReference GetTargetType(EmitContext context);
    }

    /// <summary>
    /// This interface models the metadata representation of a pointer to a function in unmanaged memory.
    /// </summary>
    internal interface IFunctionPointerTypeReference : ITypeReference
    {

        ISignature Signature { get; }
    }

    internal struct TypeReferenceWithAttributes
    {

        public ITypeReference TypeRef { get; }

        public ImmutableArray<ICustomAttribute> Attributes { get; }

        public TypeReferenceWithAttributes(
                    ITypeReference typeRef,
                    ImmutableArray<ICustomAttribute> attributes = default(ImmutableArray<ICustomAttribute>))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(520, 16474, 16754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(520, 16673, 16691);

                TypeRef = typeRef;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(520, 16705, 16743);

                Attributes = attributes.NullToEmpty();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(520, 16474, 16754);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(520, 16474, 16754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(520, 16474, 16754);
            }
        }
        static TypeReferenceWithAttributes()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(520, 16108, 16761);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(520, 16108, 16761);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(520, 16108, 16761);
        }
    }

    /// <summary>
    /// This interface models the metadata representation of a type.
    /// </summary>
    internal interface ITypeDefinition : IDefinition, ITypeReference
    {

        ushort Alignment { get; }

        ITypeReference? GetBaseClass(EmitContext context);

        IEnumerable<IEventDefinition> GetEvents(EmitContext context);

        IEnumerable<MethodImplementation> GetExplicitImplementationOverrides(EmitContext context);

        IEnumerable<IFieldDefinition> GetFields(EmitContext context);

        IEnumerable<IGenericTypeParameter> GenericParameters
        {
            get;
        }

        ushort GenericParameterCount
        {
            get;
        }

        bool HasDeclarativeSecurity { get; }

        IEnumerable<TypeReferenceWithAttributes> Interfaces(EmitContext context);

        bool IsAbstract { get; }

        bool IsBeforeFieldInit { get; }

        bool IsComObject { get; }

        bool IsGeneric { get; }

        bool IsInterface { get; }

        bool IsDelegate { get; }

        bool IsRuntimeSpecial { get; }

        bool IsSerializable { get; }

        bool IsSpecialName { get; }

        bool IsWindowsRuntimeImport { get; }

        bool IsSealed { get; }

        LayoutKind Layout { get; }

        IEnumerable<IMethodDefinition> GetMethods(EmitContext context);

        IEnumerable<INestedTypeDefinition> GetNestedTypes(EmitContext context);

        IEnumerable<IPropertyDefinition> GetProperties(EmitContext context);

        IEnumerable<SecurityAttribute> SecurityAttributes { get; }

        uint SizeOf { get; }

        CharSet StringFormat { get; }
    }

    /// <summary>
    /// A reference to a type.
    /// </summary>
    internal interface ITypeReference : IReference
    {

        bool IsEnum { get; }

        bool IsValueType { get; }

        ITypeDefinition? GetResolvedType(EmitContext context);

        PrimitiveTypeCode TypeCode { get; }

        TypeDefinitionHandle TypeDef { get; }

        IGenericMethodParameterReference? AsGenericMethodParameterReference { get; }

        IGenericTypeInstanceReference? AsGenericTypeInstanceReference { get; }

        IGenericTypeParameterReference? AsGenericTypeParameterReference { get; }

        INamespaceTypeDefinition? AsNamespaceTypeDefinition(EmitContext context);

        INamespaceTypeReference? AsNamespaceTypeReference { get; }

        INestedTypeDefinition? AsNestedTypeDefinition(EmitContext context);

        INestedTypeReference? AsNestedTypeReference { get; }

        ISpecializedNestedTypeReference? AsSpecializedNestedTypeReference { get; }

        ITypeDefinition? AsTypeDefinition(EmitContext context);
    }

    /// <summary>
    /// A enumeration of all of the value types that are built into the Runtime (and thus have specialized IL instructions that manipulate them).
    /// </summary>
    internal enum PrimitiveTypeCode
    {
        /// <summary>
        /// A single bit.
        /// </summary>
        Boolean,

        /// <summary>
        /// An unsigned 16 bit integer representing a Unicode UTF16 code point.
        /// </summary>
        Char,

        /// <summary>
        /// A signed 8 bit integer.
        /// </summary>
        Int8,

        /// <summary>
        /// A 32 bit IEEE floating point number.
        /// </summary>
        Float32,

        /// <summary>
        /// A 64 bit IEEE floating point number.
        /// </summary>
        Float64,

        /// <summary>
        /// A signed 16 bit integer.
        /// </summary>
        Int16,

        /// <summary>
        /// A signed 32 bit integer.
        /// </summary>
        Int32,

        /// <summary>
        /// A signed 64 bit integer.
        /// </summary>
        Int64,

        /// <summary>
        /// A signed 32 bit integer or 64 bit integer, depending on the native word size of the underlying processor.
        /// </summary>
        IntPtr,

        /// <summary>
        /// A pointer to fixed or unmanaged memory.
        /// </summary>
        Pointer,

        /// <summary>
        /// A reference to managed memory.
        /// </summary>
        Reference,

        /// <summary>
        /// A string.
        /// </summary>
        String,

        /// <summary>
        /// An unsigned 8 bit integer.
        /// </summary>
        UInt8,

        /// <summary>
        /// An unsigned 16 bit integer.
        /// </summary>
        UInt16,

        /// <summary>
        /// An unsigned 32 bit integer.
        /// </summary>
        UInt32,

        /// <summary>
        /// An unsigned 64 bit integer.
        /// </summary>
        UInt64,

        /// <summary>
        /// An unsigned 32 bit integer or 64 bit integer, depending on the native word size of the underlying processor.
        /// </summary>
        UIntPtr,

        /// <summary>
        /// A type that denotes the absence of a value.
        /// </summary>
        Void,

        /// <summary>
        /// Not a primitive type.
        /// </summary>
        NotPrimitive,

        /// <summary>
        /// A pointer to a function in fixed or managed memory.
        /// </summary>
        FunctionPointer,

        /// <summary>
        /// Type is a dummy type.
        /// </summary>
        Invalid,
    }

    /// <summary>
    /// Enumerates the different kinds of levels of visibility a type member can have.
    /// </summary>
    internal enum TypeMemberVisibility
    {
        /// <summary>
        /// The member is visible only within its own type.
        /// </summary>
        Private = 1,

        /// <summary>
        /// The member is visible only within the intersection of its family (its own type and any subtypes) and assembly. 
        /// </summary>
        FamilyAndAssembly = 2,

        /// <summary>
        /// The member is visible only within its own assembly.
        /// </summary>
        Assembly = 3,

        /// <summary>
        /// The member is visible only within its own type and any subtypes.
        /// </summary>
        Family = 4,

        /// <summary>
        /// The member is visible only within the union of its family and assembly. 
        /// </summary>
        FamilyOrAssembly = 5,

        /// <summary>
        /// The member is visible everywhere its declaring type is visible.
        /// </summary>
        Public = 6
    }

    /// <summary>
    /// Enumerates the different kinds of variance a generic method or generic type parameter may have.
    /// </summary>
    internal enum TypeParameterVariance
    {
        /// <summary>
        /// Two type or method instances are compatible only if they have exactly the same type argument for this parameter.
        /// </summary>
        NonVariant = 0,

        /// <summary>
        /// A type or method instance will match another instance if it has a type for this parameter that is the same or a subtype of the type the
        /// other instance has for this parameter.
        /// </summary>
        Covariant = 1,

        /// <summary>
        /// A type or method instance will match another instance if it has a type for this parameter that is the same or a supertype of the type the
        /// other instance has for this parameter.
        /// </summary>
        Contravariant = 2,
    }
}
