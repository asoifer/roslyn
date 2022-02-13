// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class WrappedFieldSymbol : FieldSymbol
    {
        protected readonly FieldSymbol _underlyingField;

        public WrappedFieldSymbol(FieldSymbol underlyingField)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10384, 981, 1166);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 952, 968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 1060, 1106);

                f_10384_1060_1105((object)underlyingField != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 1120, 1155);

                _underlyingField = underlyingField;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10384, 981, 1166);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10384, 981, 1166);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 981, 1166);
            }
        }

        public FieldSymbol UnderlyingField
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10384, 1237, 1312);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 1273, 1297);

                    return _underlyingField;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10384, 1237, 1312);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10384, 1178, 1323);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 1178, 1323);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10384, 1401, 1454);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 1407, 1452);

                    return f_10384_1414_1451(_underlyingField);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10384, 1401, 1454);

                    bool
                    f_10384_1414_1451(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.IsImplicitlyDeclared;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10384, 1414, 1451);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10384, 1335, 1465);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 1335, 1465);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override FlowAnalysisAnnotations FlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10384, 1565, 1621);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 1571, 1619);

                    return f_10384_1578_1618(_underlyingField);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10384, 1565, 1621);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
                    f_10384_1578_1618(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.FlowAnalysisAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10384, 1578, 1618);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10384, 1477, 1632);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 1477, 1632);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10384, 1720, 1817);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 1756, 1802);

                    return f_10384_1763_1801(_underlyingField);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10384, 1720, 1817);

                    Microsoft.CodeAnalysis.Accessibility
                    f_10384_1763_1801(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaredAccessibility;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10384, 1763, 1801);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10384, 1644, 1828);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 1644, 1828);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10384, 1892, 1972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 1928, 1957);

                    return f_10384_1935_1956(_underlyingField);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10384, 1892, 1972);

                    string
                    f_10384_1935_1956(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10384, 1935, 1956);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10384, 1840, 1983);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 1840, 1983);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10384, 2057, 2147);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 2093, 2132);

                    return f_10384_2100_2131(_underlyingField);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10384, 2057, 2147);

                    bool
                    f_10384_2100_2131(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.HasSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10384, 2100, 2131);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10384, 1995, 2158);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 1995, 2158);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasRuntimeSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10384, 2239, 2336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 2275, 2321);

                    return f_10384_2282_2320(_underlyingField);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10384, 2239, 2336);

                    bool
                    f_10384_2282_2320(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.HasRuntimeSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10384, 2282, 2320);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10384, 2170, 2347);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 2170, 2347);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10384, 2359, 2680);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 2565, 2669);

                return f_10384_2572_2668(_underlyingField, preferredCulture, expandIncludes, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10384, 2359, 2680);

                string
                f_10384_2572_2668(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, System.Globalization.CultureInfo?
                preferredCulture, bool
                expandIncludes, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10384, 2572, 2668);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10384, 2359, 2680);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 2359, 2680);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsNotSerialized
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10384, 2755, 2846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 2791, 2831);

                    return f_10384_2798_2830(_underlyingField);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10384, 2755, 2846);

                    bool
                    f_10384_2798_2830(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.IsNotSerialized;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10384, 2798, 2830);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10384, 2692, 2857);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 2692, 2857);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasPointerType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10384, 2907, 2941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 2910, 2941);
                    return f_10384_2910_2941(_underlyingField); DynAbs.Tracing.TraceSender.TraceExitMethod(10384, 2907, 2941);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10384, 2907, 2941);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 2907, 2941);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMarshalledExplicitly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10384, 3024, 3122);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 3060, 3107);

                    return f_10384_3067_3106(_underlyingField);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10384, 3024, 3122);

                    bool
                    f_10384_3067_3106(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMarshalledExplicitly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10384, 3067, 3106);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10384, 2954, 3133);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 2954, 3133);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override MarshalPseudoCustomAttributeData MarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10384, 3243, 3341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 3279, 3326);

                    return f_10384_3286_3325(_underlyingField);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10384, 3243, 3341);

                    Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    f_10384_3286_3325(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.MarshallingInformation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10384, 3286, 3325);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10384, 3145, 3352);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 3145, 3352);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<byte> MarshallingDescriptor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10384, 3449, 3546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 3485, 3531);

                    return f_10384_3492_3530(_underlyingField);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10384, 3449, 3546);

                    System.Collections.Immutable.ImmutableArray<byte>
                    f_10384_3492_3530(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.MarshallingDescriptor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10384, 3492, 3530);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10384, 3364, 3557);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 3364, 3557);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsFixedSizeBuffer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10384, 3632, 3725);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 3668, 3710);

                    return f_10384_3675_3709(_underlyingField);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10384, 3632, 3725);

                    bool
                    f_10384_3675_3709(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.IsFixedSizeBuffer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10384, 3675, 3709);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10384, 3569, 3736);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 3569, 3736);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int? TypeLayoutOffset
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10384, 3812, 3904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 3848, 3889);

                    return f_10384_3855_3888(_underlyingField);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10384, 3812, 3904);

                    int?
                    f_10384_3855_3888(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeLayoutOffset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10384, 3855, 3888);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10384, 3748, 3915);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 3748, 3915);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10384, 3983, 4069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 4019, 4054);

                    return f_10384_4026_4053(_underlyingField);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10384, 3983, 4069);

                    bool
                    f_10384_4026_4053(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.IsReadOnly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10384, 4026, 4053);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10384, 3927, 4080);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 3927, 4080);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsVolatile
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10384, 4148, 4234);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 4184, 4219);

                    return f_10384_4191_4218(_underlyingField);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10384, 4148, 4234);

                    bool
                    f_10384_4191_4218(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.IsVolatile;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10384, 4191, 4218);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10384, 4092, 4245);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 4092, 4245);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsConst
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10384, 4310, 4393);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 4346, 4378);

                    return f_10384_4353_4377(_underlyingField);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10384, 4310, 4393);

                    bool
                    f_10384_4353_4377(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.IsConst;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10384, 4353, 4377);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10384, 4257, 4404);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 4257, 4404);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10384, 4502, 4599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 4538, 4584);

                    return f_10384_4545_4583(_underlyingField);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10384, 4502, 4599);

                    Microsoft.CodeAnalysis.ObsoleteAttributeData
                    f_10384_4545_4583(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.ObsoleteAttributeData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10384, 4545, 4583);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10384, 4416, 4610);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 4416, 4610);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override object ConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10384, 4683, 4772);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 4719, 4757);

                    return f_10384_4726_4756(_underlyingField);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10384, 4683, 4772);

                    object
                    f_10384_4726_4756(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.ConstantValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10384, 4726, 4756);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10384, 4622, 4783);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 4622, 4783);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ConstantValue GetConstantValue(ConstantFieldsInProgress inProgress, bool earlyDecodingWellKnownAttributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10384, 4795, 5042);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 4944, 5031);

                return f_10384_4951_5030(_underlyingField, inProgress, earlyDecodingWellKnownAttributes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10384, 4795, 5042);

                Microsoft.CodeAnalysis.ConstantValue
                f_10384_4951_5030(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgress
                inProgress, bool
                earlyDecodingWellKnownAttributes)
                {
                    var return_v = this_param.GetConstantValue(inProgress, earlyDecodingWellKnownAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10384, 4951, 5030);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10384, 4795, 5042);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 4795, 5042);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10384, 5129, 5214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 5165, 5199);

                    return f_10384_5172_5198(_underlyingField);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10384, 5129, 5214);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10384_5172_5198(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10384, 5172, 5198);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10384, 5054, 5225);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 5054, 5225);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10384, 5335, 5436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 5371, 5421);

                    return f_10384_5378_5420(_underlyingField);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10384, 5335, 5436);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10384_5378_5420(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaringSyntaxReferences;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10384, 5378, 5420);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10384, 5237, 5447);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 5237, 5447);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10384, 5513, 5597);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10384, 5549, 5582);

                    return f_10384_5556_5581(_underlyingField);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10384, 5513, 5597);

                    bool
                    f_10384_5556_5581(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10384, 5556, 5581);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10384, 5459, 5608);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 5459, 5608);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static WrappedFieldSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10384, 760, 5615);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10384, 760, 5615);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10384, 760, 5615);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10384, 760, 5615);

        int
        f_10384_1060_1105(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10384, 1060, 1105);
            return 0;
        }


        bool
        f_10384_2910_2941(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        this_param)
        {
            var return_v = this_param.HasPointerType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10384, 2910, 2941);
            return return_v;
        }

    }
}
