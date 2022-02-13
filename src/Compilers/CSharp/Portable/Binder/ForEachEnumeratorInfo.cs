// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class ForEachEnumeratorInfo
    {
        public readonly TypeSymbol CollectionType;

        public readonly TypeWithAnnotations ElementTypeWithAnnotations;

        public TypeSymbol ElementType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10339, 939, 973);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 942, 973);
                    return ElementTypeWithAnnotations.Type; DynAbs.Tracing.TraceSender.TraceExitMethod(10339, 939, 973);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10339, 939, 973);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10339, 939, 973);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public readonly MethodArgumentInfo GetEnumeratorInfo;

        public readonly MethodSymbol CurrentPropertyGetter;

        public readonly MethodArgumentInfo MoveNextInfo;

        public readonly bool NeedsDisposal;

        public readonly bool IsAsync;

        public readonly BoundAwaitableInfo? DisposeAwaitableInfo;

        public readonly MethodArgumentInfo? PatternDisposeInfo;

        public readonly Conversion CollectionConversion;

        public readonly Conversion CurrentConversion;

        public readonly Conversion EnumeratorConversion;

        public readonly BinderFlags Location;

        private ForEachEnumeratorInfo(
                    TypeSymbol collectionType,
                    TypeWithAnnotations elementType,
                    MethodArgumentInfo getEnumeratorInfo,
                    MethodSymbol currentPropertyGetter,
                    MethodArgumentInfo moveNextInfo,
                    bool isAsync,
                    bool needsDisposal,
                    BoundAwaitableInfo? disposeAwaitableInfo,
                    MethodArgumentInfo? patternDisposeInfo,
                    Conversion collectionConversion,
                    Conversion currentConversion,
                    Conversion enumeratorConversion,
                    BinderFlags location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10339, 2474, 4437);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 706, 720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 1121, 1138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 1178, 1199);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 1245, 1257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 1536, 1549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 1583, 1590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 1749, 1769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 1908, 1926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 2453, 2461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 3099, 3196);

                f_10339_3099_3195((object)collectionType != null, $"Field '{nameof(collectionType)}' cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 3210, 3293);

                f_10339_3210_3292(elementType.HasType, $"Field '{nameof(elementType)}' cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 3307, 3410);

                f_10339_3307_3409((object)getEnumeratorInfo != null, $"Field '{nameof(getEnumeratorInfo)}' cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 3424, 3535);

                f_10339_3424_3534((object)currentPropertyGetter != null, $"Field '{nameof(currentPropertyGetter)}' cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 3549, 3642);

                f_10339_3549_3641((object)moveNextInfo != null, $"Field '{nameof(moveNextInfo)}' cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 3656, 3714);

                f_10339_3656_3713(patternDisposeInfo == null || (DynAbs.Tracing.TraceSender.Expression_False(10339, 3669, 3712) || needsDisposal));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 3730, 3767);

                this.CollectionType = collectionType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 3781, 3827);

                this.ElementTypeWithAnnotations = elementType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 3841, 3884);

                this.GetEnumeratorInfo = getEnumeratorInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 3898, 3949);

                this.CurrentPropertyGetter = currentPropertyGetter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 3963, 3996);

                this.MoveNextInfo = moveNextInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 4010, 4033);

                this.IsAsync = isAsync;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 4047, 4082);

                this.NeedsDisposal = needsDisposal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 4096, 4145);

                this.DisposeAwaitableInfo = disposeAwaitableInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 4159, 4204);

                this.PatternDisposeInfo = patternDisposeInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 4218, 4267);

                this.CollectionConversion = collectionConversion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 4281, 4324);

                this.CurrentConversion = currentConversion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 4338, 4387);

                this.EnumeratorConversion = enumeratorConversion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 4401, 4426);

                this.Location = location;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10339, 2474, 4437);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10339, 2474, 4437);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10339, 2474, 4437);
            }
        }

        internal struct Builder
        {

            public TypeSymbol CollectionType;

            public TypeWithAnnotations ElementTypeWithAnnotations;

            public TypeSymbol ElementType
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10339, 4731, 4765);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 4734, 4765);
                        return ElementTypeWithAnnotations.Type; DynAbs.Tracing.TraceSender.TraceExitMethod(10339, 4731, 4765);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10339, 4731, 4765);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10339, 4731, 4765);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public MethodArgumentInfo? GetEnumeratorInfo;

            public MethodSymbol CurrentPropertyGetter;

            public MethodArgumentInfo? MoveNextInfo;

            public bool IsAsync;

            public bool NeedsDisposal;

            public BoundAwaitableInfo? DisposeAwaitableInfo;

            public MethodArgumentInfo? PatternDisposeInfo;

            public Conversion CollectionConversion;

            public Conversion CurrentConversion;

            public Conversion EnumeratorConversion;

            public ForEachEnumeratorInfo Build(BinderFlags location)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10339, 5309, 6397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 5398, 5489);

                    f_10339_5398_5488((object)CollectionType != null, $"'{nameof(CollectionType)}' cannot be null");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 5507, 5592);

                    f_10339_5507_5591((object)ElementType != null, $"'{nameof(ElementType)}' cannot be null");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 5610, 5699);

                    f_10339_5610_5698(GetEnumeratorInfo != null, $"'{nameof(GetEnumeratorInfo)}' cannot be null");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 5719, 5754);

                    f_10339_5719_5753(MoveNextInfo != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 5772, 5816);

                    f_10339_5772_5815(CurrentPropertyGetter != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 5836, 6382);

                    return f_10339_5843_6381(CollectionType, ElementTypeWithAnnotations, GetEnumeratorInfo, CurrentPropertyGetter, MoveNextInfo, IsAsync, NeedsDisposal, DisposeAwaitableInfo, PatternDisposeInfo, CollectionConversion, CurrentConversion, EnumeratorConversion, location);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10339, 5309, 6397);

                    int
                    f_10339_5398_5488(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10339, 5398, 5488);
                        return 0;
                    }


                    int
                    f_10339_5507_5591(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10339, 5507, 5591);
                        return 0;
                    }


                    int
                    f_10339_5610_5698(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10339, 5610, 5698);
                        return 0;
                    }


                    int
                    f_10339_5719_5753(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10339, 5719, 5753);
                        return 0;
                    }


                    int
                    f_10339_5772_5815(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10339, 5772, 5815);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo
                    f_10339_5843_6381(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    collectionType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    elementType, Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                    getEnumeratorInfo, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    currentPropertyGetter, Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                    moveNextInfo, bool
                    isAsync, bool
                    needsDisposal, Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
                    disposeAwaitableInfo, Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo?
                    patternDisposeInfo, Microsoft.CodeAnalysis.CSharp.Conversion
                    collectionConversion, Microsoft.CodeAnalysis.CSharp.Conversion
                    currentConversion, Microsoft.CodeAnalysis.CSharp.Conversion
                    enumeratorConversion, Microsoft.CodeAnalysis.CSharp.BinderFlags
                    location)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo(collectionType, elementType, getEnumeratorInfo, currentPropertyGetter, moveNextInfo, isAsync, needsDisposal, disposeAwaitableInfo, patternDisposeInfo, collectionConversion, currentConversion, enumeratorConversion, location);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10339, 5843, 6381);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10339, 5309, 6397);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10339, 5309, 6397);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool IsIncomplete
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10339, 6455, 6540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10339, 6458, 6540);
                        return GetEnumeratorInfo is null || (DynAbs.Tracing.TraceSender.Expression_False(10339, 6458, 6507) || MoveNextInfo is null) || (DynAbs.Tracing.TraceSender.Expression_False(10339, 6458, 6540) || CurrentPropertyGetter is null); DynAbs.Tracing.TraceSender.TraceExitMethod(10339, 6455, 6540);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10339, 6455, 6540);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10339, 6455, 6540);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }
            static Builder()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10339, 4538, 6552);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10339, 4538, 6552);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10339, 4538, 6552);
            }
        }

        static ForEachEnumeratorInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10339, 552, 6559);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10339, 552, 6559);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10339, 552, 6559);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10339, 552, 6559);

        int
        f_10339_3099_3195(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10339, 3099, 3195);
            return 0;
        }


        int
        f_10339_3210_3292(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10339, 3210, 3292);
            return 0;
        }


        int
        f_10339_3307_3409(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10339, 3307, 3409);
            return 0;
        }


        int
        f_10339_3424_3534(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10339, 3424, 3534);
            return 0;
        }


        int
        f_10339_3549_3641(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10339, 3549, 3641);
            return 0;
        }


        int
        f_10339_3656_3713(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10339, 3656, 3713);
            return 0;
        }

    }
}
