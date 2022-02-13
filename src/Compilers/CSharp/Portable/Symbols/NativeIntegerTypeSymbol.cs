// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class NativeIntegerTypeSymbol : WrappedNamedTypeSymbol
    {
        private ImmutableArray<NamedTypeSymbol> _lazyInterfaces;

        private ImmutableArray<Symbol> _lazyMembers;

        private NativeIntegerTypeMap? _lazyTypeMap;

        internal NativeIntegerTypeSymbol(NamedTypeSymbol underlyingType) : base(f_10129_875_889_C(underlyingType), tupleData: null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10129, 803, 1249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 778, 790);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 932, 979);

                f_10129_932_978(f_10129_945_969(underlyingType) is null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 993, 1043);

                f_10129_993_1042(f_10129_1006_1041_M(!underlyingType.IsNativeIntegerType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 1057, 1187);

                f_10129_1057_1186(f_10129_1070_1096(underlyingType) == SpecialType.System_IntPtr || (DynAbs.Tracing.TraceSender.Expression_False(10129, 1070, 1185) || f_10129_1129_1155(underlyingType) == SpecialType.System_UIntPtr));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 1201, 1238);

                f_10129_1201_1237(this, underlyingType);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10129, 803, 1249);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 803, 1249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 803, 1249);
            }
        }

        public override ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 1328, 1372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 1331, 1372);
                    return ImmutableArray<TypeParameterSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 1328, 1372);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 1328, 1372);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 1328, 1372);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override NamedTypeSymbol ConstructedFrom
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 1433, 1440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 1436, 1440);
                    return this; DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 1433, 1440);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 1433, 1440);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 1433, 1440);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 1493, 1528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 1496, 1528);
                    return f_10129_1496_1528(_underlyingType); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 1493, 1528);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 1493, 1528);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 1493, 1528);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotationsNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 1644, 1688);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 1647, 1688);
                    return ImmutableArray<TypeWithAnnotations>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 1644, 1688);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 1644, 1688);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 1644, 1688);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsComImport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 1736, 1766);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 1739, 1766);
                    return f_10129_1739_1766(_underlyingType); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 1736, 1766);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 1736, 1766);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 1736, 1766);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override NamedTypeSymbol BaseTypeNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 1842, 1889);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 1845, 1889);
                    return f_10129_1845_1889(_underlyingType); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 1842, 1889);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 1842, 1889);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 1842, 1889);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override SpecialType SpecialType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 1942, 1972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 1945, 1972);
                    return f_10129_1945_1972(_underlyingType); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 1942, 1972);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 1942, 1972);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 1942, 1972);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override IEnumerable<string> MemberNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 2033, 2068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 2036, 2068);
                    return f_10129_2036_2048(this).Select(m => m.Name); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 2033, 2068);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 2033, 2068);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 2033, 2068);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Symbol> GetMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 2981, 6311);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 3057, 3236) || true) && (_lazyMembers.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10129, 3057, 3236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 3117, 3221);

                    f_10129_3117_3220(ref _lazyMembers, f_10129_3178_3219(f_10129_3190_3218(_underlyingType)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10129, 3057, 3236);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 3250, 3270);

                return _lazyMembers;

                ImmutableArray<Symbol> makeMembers(ImmutableArray<Symbol> underlyingMembers)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 3286, 6300);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 3395, 3444);

                        var
                        builder = f_10129_3409_3443()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 3462, 3516);

                        f_10129_3462_3515(builder, f_10129_3474_3514(this));
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 3534, 6231);
                            foreach (var underlyingMember in f_10129_3567_3584_I(underlyingMembers))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10129, 3534, 6231);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 3626, 3698);

                                f_10129_3626_3697(f_10129_3639_3696(_underlyingType, f_10129_3662_3695(underlyingMember)));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 3720, 3868) || true) && (f_10129_3724_3762(underlyingMember) != Accessibility.Public)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10129, 3720, 3868);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 3836, 3845);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10129, 3720, 3868);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 3890, 6212);

                                switch (underlyingMember)
                                {

                                    case MethodSymbol underlyingMethod:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10129, 3890, 6212);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 4029, 4201) || true) && (f_10129_4033_4065(underlyingMethod) || (DynAbs.Tracing.TraceSender.Expression_False(10129, 4033, 4098) || f_10129_4069_4098(underlyingMethod)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10129, 4029, 4201);
                                            DynAbs.Tracing.TraceSender.TraceBreak(10129, 4164, 4170);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10129, 4029, 4201);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 4231, 5269);

                                        switch (f_10129_4239_4266(underlyingMethod))
                                        {

                                            case MethodKind.Ordinary:
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10129, 4231, 5269);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 4395, 5194);

                                                switch (f_10129_4403_4424(underlyingMethod))
                                                {

                                                    case "Add":
                                                    case "Subtract":
                                                    case "ToInt32":
                                                    case "ToInt64":
                                                    case "ToUInt32":
                                                    case "ToUInt64":
                                                    case "ToPointer":
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10129, 4395, 5194);
                                                        DynAbs.Tracing.TraceSender.TraceBreak(10129, 4910, 4916);

                                                        break;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10129, 4395, 5194);

                                                    default:
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10129, 4395, 5194);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 5012, 5103);

                                                        f_10129_5012_5102(builder, f_10129_5024_5101(this, underlyingMethod, associatedSymbol: null));
                                                        DynAbs.Tracing.TraceSender.TraceBreak(10129, 5149, 5155);

                                                        break;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10129, 4395, 5194);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceBreak(10129, 5232, 5238);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10129, 4231, 5269);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(10129, 5299, 5305);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10129, 3890, 6212);

                                    case PropertySymbol underlyingProperty:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10129, 3890, 6212);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 5400, 6153) || true) && (f_10129_5404_5437(underlyingProperty) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10129, 5404, 5512) && f_10129_5479_5502(underlyingProperty) != "Size"))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10129, 5400, 6153);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 5578, 5916);

                                            var
                                            property = f_10129_5593_5915(this, underlyingProperty, (container, property, underlyingAccessor) => underlyingAccessor is null ? null : new NativeIntegerMethodSymbol(container, underlyingAccessor, property))
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 5950, 5972);

                                            f_10129_5950_5971(builder, property);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 6006, 6047);

                                            f_10129_6006_6046(builder, f_10129_6027_6045(property));
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 6081, 6122);

                                            f_10129_6081_6121(builder, f_10129_6102_6120(property));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10129, 5400, 6153);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(10129, 6183, 6189);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10129, 3890, 6212);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10129, 3534, 6231);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10129, 1, 2698);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10129, 1, 2698);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 6249, 6285);

                        return f_10129_6256_6284(builder);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 3286, 6300);

                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        f_10129_3409_3443()
                        {
                            var return_v = ArrayBuilder<Symbol>.GetInstance();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 3409, 3443);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor
                        f_10129_3474_3514(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol
                        containingType)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containingType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 3474, 3514);
                            return return_v;
                        }


                        int
                        f_10129_3462_3515(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor
                        item)
                        {
                            this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 3462, 3515);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10129_3662_3695(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 3662, 3695);
                            return return_v;
                        }


                        bool
                        f_10129_3639_3696(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                        obj)
                        {
                            var return_v = this_param.Equals((object)obj);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 3639, 3696);
                            return return_v;
                        }


                        int
                        f_10129_3626_3697(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 3626, 3697);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.Accessibility
                        f_10129_3724_3762(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.DeclaredAccessibility;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 3724, 3762);
                            return return_v;
                        }


                        bool
                        f_10129_4033_4065(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.IsGenericMethod;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 4033, 4065);
                            return return_v;
                        }


                        bool
                        f_10129_4069_4098(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        methodSymbol)
                        {
                            var return_v = methodSymbol.IsAccessor();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 4069, 4098);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.MethodKind
                        f_10129_4239_4266(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.MethodKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 4239, 4266);
                            return return_v;
                        }


                        string
                        f_10129_4403_4424(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 4403, 4424);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerMethodSymbol
                        f_10129_5024_5101(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol
                        container, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        underlyingMethod, Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerPropertySymbol?
                        associatedSymbol)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerMethodSymbol(container, underlyingMethod, associatedSymbol: associatedSymbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 5024, 5101);
                            return return_v;
                        }


                        int
                        f_10129_5012_5102(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerMethodSymbol
                        item)
                        {
                            this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 5012, 5102);
                            return 0;
                        }


                        int
                        f_10129_5404_5437(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                        this_param)
                        {
                            var return_v = this_param.ParameterCount;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 5404, 5437);
                            return return_v;
                        }


                        string
                        f_10129_5479_5502(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 5479, 5502);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerPropertySymbol
                        f_10129_5593_5915(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol
                        container, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                        underlyingProperty, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerPropertySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?, Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerMethodSymbol?>
                        getAccessor)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerPropertySymbol(container, underlyingProperty, getAccessor);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 5593, 5915);
                            return return_v;
                        }


                        int
                        f_10129_5950_5971(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerPropertySymbol
                        item)
                        {
                            this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 5950, 5971);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                        f_10129_6027_6045(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerPropertySymbol
                        this_param)
                        {
                            var return_v = this_param.GetMethod;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 6027, 6045);
                            return return_v;
                        }


                        int
                        f_10129_6006_6046(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        builder, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                        value)
                        {
                            builder.AddIfNotNull<Microsoft.CodeAnalysis.CSharp.Symbol>((Microsoft.CodeAnalysis.CSharp.Symbol?)value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 6006, 6046);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                        f_10129_6102_6120(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerPropertySymbol
                        this_param)
                        {
                            var return_v = this_param.SetMethod;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 6102, 6120);
                            return return_v;
                        }


                        int
                        f_10129_6081_6121(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        builder, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                        value)
                        {
                            builder.AddIfNotNull<Microsoft.CodeAnalysis.CSharp.Symbol>((Microsoft.CodeAnalysis.CSharp.Symbol?)value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 6081, 6121);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        f_10129_3567_3584_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 3567, 3584);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        f_10129_6256_6284(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param)
                        {
                            var return_v = this_param.ToImmutableAndFree();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 6256, 6284);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 3286, 6300);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 3286, 6300);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 2981, 6311);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10129_3190_3218(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 3190, 3218);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10129_3178_3219(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                underlyingMembers)
                {
                    var return_v = makeMembers(underlyingMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 3178, 3219);
                    return return_v;
                }


                bool
                f_10129_3117_3220(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 3117, 3220);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 2981, 6311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 2981, 6311);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Symbol> GetMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 6386, 6459);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 6389, 6459);
                return f_10129_6389_6401(this).WhereAsArray((member, name) => member.Name == name, name); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 6386, 6459);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 6386, 6459);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 6386, 6459);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
            f_10129_6389_6401(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol
            this_param)
            {
                var return_v = this_param.GetMembers();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 6389, 6401);
                return return_v;
            }

        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 6537, 6577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 6540, 6577);
                return ImmutableArray<NamedTypeSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 6537, 6577);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 6537, 6577);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 6537, 6577);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 6666, 6706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 6669, 6706);
                return ImmutableArray<NamedTypeSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 6666, 6706);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 6666, 6706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 6666, 6706);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name, int arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 6806, 6846);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 6809, 6846);
                return ImmutableArray<NamedTypeSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 6806, 6846);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 6806, 6846);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 6806, 6846);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol GetDeclaredBaseType(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 6954, 7012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 6957, 7012);
                return f_10129_6957_7012(_underlyingType, basesBeingResolved); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 6954, 7012);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 6954, 7012);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 6954, 7012);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10129_6957_7012(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
            basesBeingResolved)
            {
                var return_v = this_param.GetDeclaredBaseType(basesBeingResolved);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 6957, 7012);
                return return_v;
            }

        }

        internal override ImmutableArray<NamedTypeSymbol> GetDeclaredInterfaces(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 7138, 7174);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 7141, 7174);
                return f_10129_7141_7174(this, basesBeingResolved); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 7138, 7174);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 7138, 7174);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 7138, 7174);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
            f_10129_7141_7174(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol
            this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
            basesBeingResolved)
            {
                var return_v = this_param.GetInterfaces(basesBeingResolved);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 7141, 7174);
                return return_v;
            }

        }

        internal override ImmutableArray<Symbol> GetEarlyAttributeDecodingMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 7263, 7302);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 7266, 7302);
                throw f_10129_7272_7302(); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 7263, 7302);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 7263, 7302);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 7263, 7302);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10129_7272_7302()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 7272, 7302);
                return return_v;
            }

        }

        internal override ImmutableArray<Symbol> GetEarlyAttributeDecodingMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 7402, 7441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 7405, 7441);
                throw f_10129_7411_7441(); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 7402, 7441);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 7402, 7441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 7402, 7441);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10129_7411_7441()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 7411, 7441);
                return return_v;
            }

        }

        internal override IEnumerable<FieldSymbol> GetFieldsToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 7515, 7554);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 7518, 7554);
                throw f_10129_7524_7554(); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 7515, 7554);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 7515, 7554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 7515, 7554);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10129_7524_7554()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 7524, 7554);
                return return_v;
            }

        }

        internal override ImmutableArray<NamedTypeSymbol> GetInterfacesToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 7639, 7678);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 7642, 7678);
                throw f_10129_7648_7678(); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 7639, 7678);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 7639, 7678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 7639, 7678);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10129_7648_7678()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 7648, 7678);
                return return_v;
            }

        }

        internal override ImmutableArray<NamedTypeSymbol> InterfacesNoUseSiteDiagnostics(ConsList<TypeSymbol>? basesBeingResolved = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 7821, 7857);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 7824, 7857);
                return f_10129_7824_7857(this, basesBeingResolved); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 7821, 7857);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 7821, 7857);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 7821, 7857);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
            f_10129_7824_7857(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol
            this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
            basesBeingResolved)
            {
                var return_v = this_param.GetInterfaces(basesBeingResolved);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 7824, 7857);
                return return_v;
            }

        }

        protected override NamedTypeSymbol WithTupleDataCore(TupleExtraData newData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 7947, 7986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 7950, 7986);
                throw f_10129_7956_7986(); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 7947, 7986);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 7947, 7986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 7947, 7986);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10129_7956_7986()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 7956, 7986);
                return return_v;
            }

        }

        internal override DiagnosticInfo? GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 7999, 8288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 8080, 8136);

                var
                diagnostic = f_10129_8097_8135(_underlyingType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 8150, 8183);

                f_10129_8150_8182(diagnostic is null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 8259, 8277);

                return diagnostic;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 7999, 8288);

                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10129_8097_8135(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 8097, 8135);
                    return return_v;
                }


                int
                f_10129_8150_8182(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 8150, 8182);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 7999, 8288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 7999, 8288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 8337, 8376);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 8340, 8376);
                    throw f_10129_8346_8376(); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 8337, 8376);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 8337, 8376);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 8337, 8376);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsNativeIntegerType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 8432, 8439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 8435, 8439);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 8432, 8439);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 8432, 8439);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 8432, 8439);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override NamedTypeSymbol AsNativeInteger()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 8511, 8550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 8514, 8550);
                throw f_10129_8520_8550(); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 8511, 8550);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 8511, 8550);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 8511, 8550);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10129_8520_8550()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 8520, 8550);
                return return_v;
            }

        }

        internal sealed override NamedTypeSymbol NativeIntegerUnderlyingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 8632, 8650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 8635, 8650);
                    return _underlyingType; DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 8632, 8650);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 8632, 8650);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 8632, 8650);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 8702, 8710);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 8705, 8710);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 8702, 8710);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 8702, 8710);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 8702, 8710);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool HasPossibleWellKnownCloneMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 8785, 8793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 8788, 8793);
                return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 8785, 8793);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 8785, 8793);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 8785, 8793);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool Equals(TypeSymbol? other, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 8806, 9343);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 8907, 8986) || true) && (other is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10129, 8907, 8986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 8958, 8971);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10129, 8907, 8986);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 9000, 9086) || true) && ((object)this == other)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10129, 9000, 9086);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 9059, 9071);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10129, 9000, 9086);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 9100, 9208) || true) && (!f_10129_9105_9146(_underlyingType, other, comparison))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10129, 9100, 9208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 9180, 9193);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10129, 9100, 9208);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 9222, 9332);

                return (comparison & TypeCompareKind.IgnoreNativeIntegers) != 0 || (DynAbs.Tracing.TraceSender.Expression_False(10129, 9229, 9331) || f_10129_9306_9331(other));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 8806, 9343);

                bool
                f_10129_9105_9146(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals(t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 9105, 9146);
                    return return_v;
                }


                bool
                f_10129_9306_9331(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 9306, 9331);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 8806, 9343);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 8806, 9343);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 9389, 9421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 9392, 9421);
                return f_10129_9392_9421(_underlyingType); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 9389, 9421);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 9389, 9421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 9389, 9421);
            }
            throw new System.Exception("Slicer error: unreachable code");

            int
            f_10129_9392_9421(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            this_param)
            {
                var return_v = this_param.GetHashCode();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 9392, 9421);
                return return_v;
            }

        }

        private ImmutableArray<NamedTypeSymbol> GetInterfaces(ConsList<TypeSymbol>? basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 9655, 10153);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 9775, 10105) || true) && (_lazyInterfaces.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10129, 9775, 10105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 9838, 9996);

                    var
                    interfaces = f_10129_9855_9921(_underlyingType, basesBeingResolved).SelectAsArray((type, map) => map.SubstituteNamedType(type), f_10129_9982_9994(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 10014, 10090);

                    f_10129_10014_10089(ref _lazyInterfaces, interfaces);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10129, 9775, 10105);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 10119, 10142);

                return _lazyInterfaces;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 9655, 10153);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10129_9855_9921(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.InterfacesNoUseSiteDiagnostics(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 9855, 9921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol.NativeIntegerTypeMap
                f_10129_9982_9994(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 9982, 9994);
                    return return_v;
                }


                bool
                f_10129_10014_10089(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 10014, 10089);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 9655, 10153);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 9655, 10153);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NativeIntegerTypeMap GetTypeMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 10165, 10433);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 10231, 10388) || true) && (_lazyTypeMap is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10129, 10231, 10388);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 10289, 10373);

                    f_10129_10289_10372(ref _lazyTypeMap, f_10129_10335_10365(this), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10129, 10231, 10388);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 10402, 10422);

                return _lazyTypeMap;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 10165, 10433);

                Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol.NativeIntegerTypeMap
                f_10129_10335_10365(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol.NativeIntegerTypeMap(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 10335, 10365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol.NativeIntegerTypeMap?
                f_10129_10289_10372(ref Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol.NativeIntegerTypeMap?
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol.NativeIntegerTypeMap
                value, Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol.NativeIntegerTypeMap?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 10289, 10372);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 10165, 10433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 10165, 10433);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeWithAnnotations SubstituteUnderlyingType(TypeWithAnnotations type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 10664, 10700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 10667, 10700);
                return type.SubstituteType(f_10129_10687_10699(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 10664, 10700);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 10664, 10700);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 10664, 10700);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol.NativeIntegerTypeMap
            f_10129_10687_10699(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol
            this_param)
            {
                var return_v = this_param.GetTypeMap();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 10687, 10699);
                return return_v;
            }

        }

        internal NamedTypeSymbol SubstituteUnderlyingType(NamedTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 10924, 10965);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 10927, 10965);
                return f_10129_10927_10965(f_10129_10927_10939(this), type); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 10924, 10965);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 10924, 10965);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 10924, 10965);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol.NativeIntegerTypeMap
            f_10129_10927_10939(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol
            this_param)
            {
                var return_v = this_param.GetTypeMap();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 10927, 10939);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10129_10927_10965(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol.NativeIntegerTypeMap
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            previous)
            {
                var return_v = this_param.SubstituteNamedType(previous);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 10927, 10965);
                return return_v;
            }

        }

        internal static bool EqualsHelper<TSymbol>(TSymbol symbol, Symbol? other, TypeCompareKind comparison, Func<TSymbol, Symbol> getUnderlyingSymbol)
                    where TSymbol : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10129, 10978, 11624);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 11183, 11262) || true) && (other is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10129, 11183, 11262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 11234, 11247);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10129, 11183, 11262);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 11276, 11364) || true) && ((object)symbol == other)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10129, 11276, 11364);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 11337, 11349);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10129, 11276, 11364);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 11378, 11498) || true) && (!f_10129_11383_11436<TSymbol>(f_10129_11383_11410<TSymbol>(getUnderlyingSymbol, symbol), other, comparison))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10129, 11378, 11498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 11470, 11483);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10129, 11378, 11498);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 11512, 11613);

                return (comparison & TypeCompareKind.IgnoreNativeIntegers) != 0 || (DynAbs.Tracing.TraceSender.Expression_False(10129, 11519, 11612) || other is TSymbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10129, 10978, 11624);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10129_11383_11410<TSymbol>(System.Func<TSymbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, TSymbol
                arg) where TSymbol : Symbol

                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 11383, 11410);
                    return return_v;
                }


                bool
                f_10129_11383_11436<TSymbol>(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind) where TSymbol : Symbol

                {
                    var return_v = this_param.Equals(other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 11383, 11436);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 10978, 11624);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 10978, 11624);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Conditional("DEBUG")]
        internal static void VerifyEquality(Symbol symbolA, Symbol symbolB)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10129, 11636, 12190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 11760, 11835);

                f_10129_11760_11834(!f_10129_11774_11833(symbolA, symbolB, TypeCompareKind.ConsiderEverything));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 11849, 11924);

                f_10129_11849_11923(!f_10129_11863_11922(symbolB, symbolA, TypeCompareKind.ConsiderEverything));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 11938, 12014);

                f_10129_11938_12013(f_10129_11951_12012(symbolA, symbolB, TypeCompareKind.IgnoreNativeIntegers));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 12028, 12104);

                f_10129_12028_12103(f_10129_12041_12102(symbolB, symbolA, TypeCompareKind.IgnoreNativeIntegers));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 12118, 12179);

                f_10129_12118_12178(f_10129_12131_12152(symbolA) == f_10129_12156_12177(symbolB));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10129, 11636, 12190);

                bool
                f_10129_11774_11833(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 11774, 11833);
                    return return_v;
                }


                int
                f_10129_11760_11834(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 11760, 11834);
                    return 0;
                }


                bool
                f_10129_11863_11922(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 11863, 11922);
                    return return_v;
                }


                int
                f_10129_11849_11923(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 11849, 11923);
                    return 0;
                }


                bool
                f_10129_11951_12012(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 11951, 12012);
                    return return_v;
                }


                int
                f_10129_11938_12013(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 11938, 12013);
                    return 0;
                }


                bool
                f_10129_12041_12102(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 12041, 12102);
                    return return_v;
                }


                int
                f_10129_12028_12103(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 12028, 12103);
                    return 0;
                }


                int
                f_10129_12131_12152(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 12131, 12152);
                    return return_v;
                }


                int
                f_10129_12156_12177(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 12156, 12177);
                    return return_v;
                }


                int
                f_10129_12118_12178(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 12118, 12178);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 11636, 12190);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 11636, 12190);
            }
        }
        private sealed class NativeIntegerTypeMap : AbstractTypeMap
        {
            private readonly NativeIntegerTypeSymbol _type;

            private readonly SpecialType _specialType;

            internal NativeIntegerTypeMap(NativeIntegerTypeSymbol type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10129, 12405, 12718);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 12327, 12332);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 12376, 12388);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 12497, 12510);

                    _type = type;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 12528, 12581);

                    _specialType = f_10129_12543_12580(f_10129_12543_12568(_type));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 12601, 12703);

                    f_10129_12601_12702(_specialType == SpecialType.System_IntPtr || (DynAbs.Tracing.TraceSender.Expression_False(10129, 12614, 12701) || _specialType == SpecialType.System_UIntPtr));
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10129, 12405, 12718);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 12405, 12718);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 12405, 12718);
                }
            }

            internal override NamedTypeSymbol SubstituteTypeDeclaration(NamedTypeSymbol previous)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 12734, 13004);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 12852, 12989);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10129, 12859, 12895) || ((f_10129_12859_12879(previous) == _specialType && DynAbs.Tracing.TraceSender.Conditional_F2(10129, 12919, 12924)) || DynAbs.Tracing.TraceSender.Conditional_F3(10129, 12948, 12988))) ? _type : DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SubstituteTypeDeclaration(previous), 10129, 12948, 12988);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 12734, 13004);

                    Microsoft.CodeAnalysis.SpecialType
                    f_10129_12859_12879(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 12859, 12879);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 12734, 13004);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 12734, 13004);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override ImmutableArray<CustomModifier> SubstituteCustomModifiers(ImmutableArray<CustomModifier> customModifiers)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 13020, 13213);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 13175, 13198);

                    return customModifiers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 13020, 13213);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 13020, 13213);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 13020, 13213);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static NativeIntegerTypeMap()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10129, 12202, 13224);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10129, 12202, 13224);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 12202, 13224);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10129, 12202, 13224);

            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10129_12543_12568(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol
            this_param)
            {
                var return_v = this_param.UnderlyingNamedType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 12543, 12568);
                return return_v;
            }


            Microsoft.CodeAnalysis.SpecialType
            f_10129_12543_12580(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            this_param)
            {
                var return_v = this_param.SpecialType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 12543, 12580);
                return return_v;
            }


            int
            f_10129_12601_12702(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 12601, 12702);
                return 0;
            }

        }

        static NativeIntegerTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10129, 495, 13231);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10129, 495, 13231);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 495, 13231);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10129, 495, 13231);

        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
        f_10129_945_969(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.TupleData;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 945, 969);
            return return_v;
        }


        int
        f_10129_932_978(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 932, 978);
            return 0;
        }


        bool
        f_10129_1006_1041_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 1006, 1041);
            return return_v;
        }


        int
        f_10129_993_1042(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 993, 1042);
            return 0;
        }


        Microsoft.CodeAnalysis.SpecialType
        f_10129_1070_1096(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.SpecialType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 1070, 1096);
            return return_v;
        }


        Microsoft.CodeAnalysis.SpecialType
        f_10129_1129_1155(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.SpecialType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 1129, 1155);
            return return_v;
        }


        int
        f_10129_1057_1186(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 1057, 1186);
            return 0;
        }


        int
        f_10129_1201_1237(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol
        symbolA, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        symbolB)
        {
            VerifyEquality((Microsoft.CodeAnalysis.CSharp.Symbol)symbolA, (Microsoft.CodeAnalysis.CSharp.Symbol)symbolB);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 1201, 1237);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10129_875_889_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10129, 803, 1249);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbol
        f_10129_1496_1528(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.ContainingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 1496, 1528);
            return return_v;
        }


        bool
        f_10129_1739_1766(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsComImport;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 1739, 1766);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10129_1845_1889(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 1845, 1889);
            return return_v;
        }


        Microsoft.CodeAnalysis.SpecialType
        f_10129_1945_1972(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.SpecialType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 1945, 1972);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_10129_2036_2048(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol
        this_param)
        {
            var return_v = this_param.GetMembers();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 2036, 2048);
            return return_v;
        }


        System.Exception
        f_10129_8346_8376()
        {
            var return_v = ExceptionUtilities.Unreachable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 8346, 8376);
            return return_v;
        }

    }
    internal sealed class NativeIntegerMethodSymbol : WrappedMethodSymbol
    {
        private readonly NativeIntegerTypeSymbol _container;

        private readonly NativeIntegerPropertySymbol? _associatedSymbol;

        private ImmutableArray<ParameterSymbol> _lazyParameters;

        internal NativeIntegerMethodSymbol(NativeIntegerTypeSymbol container, MethodSymbol underlyingMethod, NativeIntegerPropertySymbol? associatedSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10129, 13575, 14021);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 13412, 13422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 13479, 13496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 14099, 14153);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 13747, 13795);

                f_10129_13747_13794(f_10129_13760_13793_M(!underlyingMethod.IsGenericMethod));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 13809, 13832);

                _container = container;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 13846, 13883);

                _associatedSymbol = associatedSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 13897, 13933);

                UnderlyingMethod = underlyingMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 13947, 14010);

                f_10129_13947_14009(this, underlyingMethod);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10129, 13575, 14021);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 13575, 14021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 13575, 14021);
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 14073, 14086);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 14076, 14086);
                    return _container; DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 14073, 14086);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 14073, 14086);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 14073, 14086);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodSymbol UnderlyingMethod { get; }

        public override TypeWithAnnotations ReturnTypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 14227, 14309);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 14230, 14309);
                    return f_10129_14230_14309(_container, f_10129_14266_14308(f_10129_14266_14282())); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 14227, 14309);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 14227, 14309);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 14227, 14309);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 14403, 14447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 14406, 14447);
                    return ImmutableArray<TypeWithAnnotations>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 14403, 14447);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 14403, 14447);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 14403, 14447);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 14527, 14571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 14530, 14571);
                    return ImmutableArray<TypeParameterSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 14527, 14571);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 14527, 14571);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 14527, 14571);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ParameterSymbol> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 14667, 15093);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 14703, 15037) || true) && (_lazyParameters.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10129, 14703, 15037);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 14774, 14920);

                        var
                        parameters = f_10129_14791_14807().Parameters.SelectAsArray((p, m) => (ParameterSymbol)new NativeIntegerParameterSymbol(m._container, m, p), this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 14942, 15018);

                        f_10129_14942_15017(ref _lazyParameters, parameters);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10129, 14703, 15037);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 15055, 15078);

                    return _lazyParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 14667, 15093);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10129_14791_14807()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 14791, 14807);
                        return return_v;
                    }


                    bool
                    f_10129_14942_15017(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 14942, 15017);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 14584, 15104);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 14584, 15104);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<MethodSymbol> ExplicitInterfaceImplementations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 15194, 15231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 15197, 15231);
                    return ImmutableArray<MethodSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 15194, 15231);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 15194, 15231);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 15194, 15231);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 15310, 15348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 15313, 15348);
                    return f_10129_15313_15348(f_10129_15313_15329()); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 15310, 15348);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 15310, 15348);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 15310, 15348);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override UnmanagedCallersOnlyAttributeData? GetUnmanagedCallersOnlyAttributeData(bool forceComplete)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 15471, 15542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 15474, 15542);
                return f_10129_15474_15542(f_10129_15474_15490(), forceComplete); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 15471, 15542);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 15471, 15542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 15471, 15542);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            f_10129_15474_15490()
            {
                var return_v = UnderlyingMethod;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 15474, 15490);
                return return_v;
            }


            Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData?
            f_10129_15474_15542(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            this_param, bool
            forceComplete)
            {
                var return_v = this_param.GetUnmanagedCallersOnlyAttributeData(forceComplete);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 15474, 15542);
                return return_v;
            }

        }

        public override Symbol? AssociatedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 15596, 15616);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 15599, 15616);
                    return _associatedSymbol; DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 15596, 15616);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 15596, 15616);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 15596, 15616);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 15629, 15791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 15743, 15780);

                throw f_10129_15749_15779();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 15629, 15791);

                System.Exception
                f_10129_15749_15779()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 15749, 15779);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 15629, 15791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 15629, 15791);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsNullableAnalysisEnabled()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 15854, 15893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 15857, 15893);
                throw f_10129_15863_15893(); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 15854, 15893);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 15854, 15893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 15854, 15893);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10129_15863_15893()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 15863, 15893);
                return return_v;
            }

        }

        public override bool Equals(Symbol? other, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 15977, 16076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 15980, 16076);
                return f_10129_15980_16076(this, other, comparison, symbol => symbol.UnderlyingMethod); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 15977, 16076);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 15977, 16076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 15977, 16076);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10129_15980_16076(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerMethodSymbol
            symbol, Microsoft.CodeAnalysis.CSharp.Symbol?
            other, Microsoft.CodeAnalysis.TypeCompareKind
            comparison, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerMethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbol>
            getUnderlyingSymbol)
            {
                var return_v = NativeIntegerTypeSymbol.EqualsHelper(symbol, other, comparison, getUnderlyingSymbol);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 15980, 16076);
                return return_v;
            }

        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 16123, 16156);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 16126, 16156);
                return f_10129_16126_16156(f_10129_16126_16142()); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 16123, 16156);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 16123, 16156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 16123, 16156);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            f_10129_16126_16142()
            {
                var return_v = UnderlyingMethod;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 16126, 16142);
                return return_v;
            }


            int
            f_10129_16126_16156(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            this_param)
            {
                var return_v = this_param.GetHashCode();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 16126, 16156);
                return return_v;
            }

        }

        static NativeIntegerMethodSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10129, 13239, 16383);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10129, 13239, 16383);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 13239, 16383);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10129, 13239, 16383);

        bool
        f_10129_13760_13793_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 13760, 13793);
            return return_v;
        }


        int
        f_10129_13747_13794(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 13747, 13794);
            return 0;
        }


        int
        f_10129_13947_14009(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerMethodSymbol
        symbolA, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        symbolB)
        {
            NativeIntegerTypeSymbol.VerifyEquality((Microsoft.CodeAnalysis.CSharp.Symbol)symbolA, (Microsoft.CodeAnalysis.CSharp.Symbol)symbolB);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 13947, 14009);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10129_14266_14282()
        {
            var return_v = UnderlyingMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 14266, 14282);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_10129_14266_14308(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ReturnTypeWithAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 14266, 14308);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_10129_14230_14309(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        type)
        {
            var return_v = this_param.SubstituteUnderlyingType(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 14230, 14309);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10129_15313_15329()
        {
            var return_v = UnderlyingMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 15313, 15329);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
        f_10129_15313_15348(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.RefCustomModifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 15313, 15348);
            return return_v;
        }

    }
    internal sealed class NativeIntegerParameterSymbol : WrappedParameterSymbol
    {
        private readonly NativeIntegerTypeSymbol _containingType;

        private readonly NativeIntegerMethodSymbol _container;

        internal NativeIntegerParameterSymbol(NativeIntegerTypeSymbol containingType, NativeIntegerMethodSymbol container, ParameterSymbol underlyingParameter) : base(f_10129_16821_16840_C(underlyingParameter))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10129, 16662, 17027);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 16570, 16585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 16639, 16649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 16866, 16899);

                _containingType = containingType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 16913, 16936);

                _container = container;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 16950, 17016);

                f_10129_16950_17015(this, underlyingParameter);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10129, 16662, 17027);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 16662, 17027);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 16662, 17027);
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 17079, 17092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 17082, 17092);
                    return _container; DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 17079, 17092);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 17079, 17092);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 17079, 17092);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeWithAnnotations TypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 17161, 17246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 17164, 17246);
                    return f_10129_17164_17246(_containingType, f_10129_17205_17245(_underlyingParameter)); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 17161, 17246);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 17161, 17246);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 17161, 17246);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 17325, 17367);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 17328, 17367);
                    return f_10129_17328_17367(_underlyingParameter); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 17325, 17367);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 17325, 17367);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 17325, 17367);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool Equals(Symbol? other, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 17451, 17554);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 17454, 17554);
                return f_10129_17454_17554(this, other, comparison, symbol => symbol._underlyingParameter); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 17451, 17554);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 17451, 17554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 17451, 17554);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10129_17454_17554(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerParameterSymbol
            symbol, Microsoft.CodeAnalysis.CSharp.Symbol?
            other, Microsoft.CodeAnalysis.TypeCompareKind
            comparison, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbol>
            getUnderlyingSymbol)
            {
                var return_v = NativeIntegerTypeSymbol.EqualsHelper(symbol, other, comparison, getUnderlyingSymbol);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 17454, 17554);
                return return_v;
            }

        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 17601, 17638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 17604, 17638);
                return f_10129_17604_17638(_underlyingParameter); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 17601, 17638);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 17601, 17638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 17601, 17638);
            }
            throw new System.Exception("Slicer error: unreachable code");

            int
            f_10129_17604_17638(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
            this_param)
            {
                var return_v = this_param.GetHashCode();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 17604, 17638);
                return return_v;
            }

        }

        static NativeIntegerParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10129, 16391, 17864);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10129, 16391, 17864);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 16391, 17864);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10129, 16391, 17864);

        int
        f_10129_16950_17015(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerParameterSymbol
        symbolA, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        symbolB)
        {
            NativeIntegerTypeSymbol.VerifyEquality((Microsoft.CodeAnalysis.CSharp.Symbol)symbolA, (Microsoft.CodeAnalysis.CSharp.Symbol)symbolB);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 16950, 17015);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        f_10129_16821_16840_C(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10129, 16662, 17027);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_10129_17205_17245(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.TypeWithAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 17205, 17245);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_10129_17164_17246(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        type)
        {
            var return_v = this_param.SubstituteUnderlyingType(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 17164, 17246);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
        f_10129_17328_17367(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.RefCustomModifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 17328, 17367);
            return return_v;
        }

    }
    internal sealed class NativeIntegerPropertySymbol : WrappedPropertySymbol
    {
        private readonly NativeIntegerTypeSymbol _container;

        internal NativeIntegerPropertySymbol(
                    NativeIntegerTypeSymbol container,
                    PropertySymbol underlyingProperty,
                    Func<NativeIntegerTypeSymbol, NativeIntegerPropertySymbol, MethodSymbol?, NativeIntegerMethodSymbol?> getAccessor) : base(f_10129_18354_18372_C(underlyingProperty))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10129, 18072, 18748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 18049, 18059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 19205, 19253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 19265, 19313);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 18398, 18451);

                f_10129_18398_18450(f_10129_18411_18444(underlyingProperty) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 18465, 18488);

                _container = container;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 18502, 18573);

                GetMethod = f_10129_18514_18572(getAccessor, container, this, f_10129_18543_18571(underlyingProperty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 18587, 18658);

                SetMethod = f_10129_18599_18657(getAccessor, container, this, f_10129_18628_18656(underlyingProperty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 18672, 18737);

                f_10129_18672_18736(this, underlyingProperty);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10129, 18072, 18748);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 18072, 18748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 18072, 18748);
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 18800, 18813);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 18803, 18813);
                    return _container; DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 18800, 18813);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 18800, 18813);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 18800, 18813);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeWithAnnotations TypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 18882, 18961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 18885, 18961);
                    return f_10129_18885_18961(_container, f_10129_18921_18960(_underlyingProperty)); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 18882, 18961);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 18882, 18961);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 18882, 18961);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 19040, 19080);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 19043, 19080);
                    return f_10129_19043_19080(f_10129_19043_19061()); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 19040, 19080);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 19040, 19080);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 19040, 19080);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ParameterSymbol> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 19152, 19192);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 19155, 19192);
                    return ImmutableArray<ParameterSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 19152, 19192);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 19152, 19192);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 19152, 19192);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodSymbol? GetMethod { get; }

        public override MethodSymbol? SetMethod { get; }

        public override ImmutableArray<PropertySymbol> ExplicitInterfaceImplementations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 19405, 19444);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 19408, 19444);
                    return ImmutableArray<PropertySymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 19405, 19444);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 19405, 19444);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 19405, 19444);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool MustCallMethodsDirectly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 19504, 19550);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 19507, 19550);
                    return f_10129_19507_19550(_underlyingProperty); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 19504, 19550);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 19504, 19550);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 19504, 19550);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool Equals(Symbol? other, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 19634, 19736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 19637, 19736);
                return f_10129_19637_19736(this, other, comparison, symbol => symbol._underlyingProperty); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 19634, 19736);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 19634, 19736);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 19634, 19736);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10129_19637_19736(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerPropertySymbol
            symbol, Microsoft.CodeAnalysis.CSharp.Symbol?
            other, Microsoft.CodeAnalysis.TypeCompareKind
            comparison, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerPropertySymbol, Microsoft.CodeAnalysis.CSharp.Symbol>
            getUnderlyingSymbol)
            {
                var return_v = NativeIntegerTypeSymbol.EqualsHelper(symbol, other, comparison, getUnderlyingSymbol);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 19637, 19736);
                return return_v;
            }

        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10129, 19783, 19819);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10129, 19786, 19819);
                return f_10129_19786_19819(_underlyingProperty); DynAbs.Tracing.TraceSender.TraceExitMethod(10129, 19783, 19819);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10129, 19783, 19819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 19783, 19819);
            }
            throw new System.Exception("Slicer error: unreachable code");

            int
            f_10129_19786_19819(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
            this_param)
            {
                var return_v = this_param.GetHashCode();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 19786, 19819);
                return return_v;
            }

        }

        static NativeIntegerPropertySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10129, 17872, 20045);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10129, 17872, 20045);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10129, 17872, 20045);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10129, 17872, 20045);

        int
        f_10129_18411_18444(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        this_param)
        {
            var return_v = this_param.ParameterCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 18411, 18444);
            return return_v;
        }


        int
        f_10129_18398_18450(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 18398, 18450);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10129_18543_18571(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        this_param)
        {
            var return_v = this_param.GetMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 18543, 18571);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerMethodSymbol?
        f_10129_18514_18572(System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerPropertySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?, Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerMethodSymbol?>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol
        arg1, Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerPropertySymbol
        arg2, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        arg3)
        {
            var return_v = this_param.Invoke(arg1, arg2, arg3);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 18514, 18572);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10129_18628_18656(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        this_param)
        {
            var return_v = this_param.SetMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 18628, 18656);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerMethodSymbol?
        f_10129_18599_18657(System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerPropertySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?, Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerMethodSymbol?>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol
        arg1, Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerPropertySymbol
        arg2, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        arg3)
        {
            var return_v = this_param.Invoke(arg1, arg2, arg3);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 18599, 18657);
            return return_v;
        }


        int
        f_10129_18672_18736(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerPropertySymbol
        symbolA, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        symbolB)
        {
            NativeIntegerTypeSymbol.VerifyEquality((Microsoft.CodeAnalysis.CSharp.Symbol)symbolA, (Microsoft.CodeAnalysis.CSharp.Symbol)symbolB);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 18672, 18736);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        f_10129_18354_18372_C(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10129, 18072, 18748);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_10129_18921_18960(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        this_param)
        {
            var return_v = this_param.TypeWithAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 18921, 18960);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_10129_18885_18961(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerTypeSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        type)
        {
            var return_v = this_param.SubstituteUnderlyingType(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10129, 18885, 18961);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        f_10129_19043_19061()
        {
            var return_v = UnderlyingProperty;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 19043, 19061);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
        f_10129_19043_19080(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        this_param)
        {
            var return_v = this_param.RefCustomModifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 19043, 19080);
            return return_v;
        }


        bool
        f_10129_19507_19550(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        this_param)
        {
            var return_v = this_param.MustCallMethodsDirectly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10129, 19507, 19550);
            return return_v;
        }

    }
}
