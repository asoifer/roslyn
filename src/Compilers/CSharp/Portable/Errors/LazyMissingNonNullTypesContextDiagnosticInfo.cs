// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class LazyMissingNonNullTypesContextDiagnosticInfo : LazyDiagnosticInfo
    {
        private readonly TypeWithAnnotations _type;

        private readonly DiagnosticInfo _info;

        private LazyMissingNonNullTypesContextDiagnosticInfo(TypeWithAnnotations type, DiagnosticInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10613, 761, 977);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10613, 743, 748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10613, 885, 912);

                f_10613_885_911(type.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10613, 926, 939);

                _type = type;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10613, 953, 966);

                _info = info;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10613, 761, 977);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10613, 761, 977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10613, 761, 977);
            }
        }

        public static void AddAll(bool isNullableEnabled, bool isGeneratedCode, TypeWithAnnotations type, Location location, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10613, 989, 1563);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10613, 1157, 1215);

                var
                rawInfos = f_10613_1172_1214()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10613, 1229, 1336);

                f_10613_1229_1335(isNullableEnabled, isGeneratedCode, f_10613_1305_1324(location), rawInfos);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10613, 1350, 1522);
                    foreach (var rawInfo in f_10613_1374_1382_I(rawInfos))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10613, 1350, 1522);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10613, 1416, 1507);

                        f_10613_1416_1506(diagnostics, f_10613_1432_1495(type, rawInfo), location);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10613, 1350, 1522);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10613, 1, 173);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10613, 1, 173);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10613, 1536, 1552);

                f_10613_1536_1551(rawInfos);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10613, 989, 1563);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DiagnosticInfo>
                f_10613_1172_1214()
                {
                    var return_v = ArrayBuilder<DiagnosticInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10613, 1172, 1214);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_10613_1305_1324(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10613, 1305, 1324);
                    return return_v;
                }


                int
                f_10613_1229_1335(bool
                isNullableEnabled, bool
                isGeneratedCode, Microsoft.CodeAnalysis.SyntaxTree?
                tree, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DiagnosticInfo>
                infos)
                {
                    GetRawDiagnosticInfos(isNullableEnabled, isGeneratedCode, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree?)tree, infos);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10613, 1229, 1335);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.LazyMissingNonNullTypesContextDiagnosticInfo
                f_10613_1432_1495(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.DiagnosticInfo
                info)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.LazyMissingNonNullTypesContextDiagnosticInfo(type, info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10613, 1432, 1495);
                    return return_v;
                }


                int
                f_10613_1416_1506(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.LazyMissingNonNullTypesContextDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10613, 1416, 1506);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DiagnosticInfo>
                f_10613_1374_1382_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DiagnosticInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10613, 1374, 1382);
                    return return_v;
                }


                int
                f_10613_1536_1551(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DiagnosticInfo>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10613, 1536, 1551);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10613, 989, 1563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10613, 989, 1563);
            }
        }

        private static void GetRawDiagnosticInfos(bool isNullableEnabled, bool isGeneratedCode, CSharpSyntaxTree tree, ArrayBuilder<DiagnosticInfo> infos)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10613, 1593, 2415);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10613, 1764, 1836);

                const MessageID
                featureId = MessageID.IDS_FeatureNullableReferenceTypes
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10613, 1850, 1922);

                var
                info = f_10613_1861_1921(featureId, f_10613_1908_1920(tree))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10613, 1936, 2019) || true) && (info is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10613, 1936, 2019);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10613, 1988, 2004);

                    f_10613_1988_2003(infos, info);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10613, 1936, 2019);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10613, 2035, 2404) || true) && (!isNullableEnabled && (DynAbs.Tracing.TraceSender.Expression_True(10613, 2039, 2103) && f_10613_2061_2075_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(info, 10613, 2061, 2075)?.Severity) != DiagnosticSeverity.Error))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10613, 2035, 2404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10613, 2137, 2333);

                    var
                    code = (DynAbs.Tracing.TraceSender.Conditional_F1(10613, 2148, 2163) || ((isGeneratedCode
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10613, 2187, 2255)) || DynAbs.Tracing.TraceSender.Conditional_F3(10613, 2279, 2332))) ? ErrorCode.WRN_MissingNonNullTypesContextForAnnotationInGeneratedCode
                    : ErrorCode.WRN_MissingNonNullTypesContextForAnnotation
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10613, 2351, 2389);

                    f_10613_2351_2388(infos, f_10613_2361_2387(code));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10613, 2035, 2404);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10613, 1593, 2415);

                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10613_1908_1920(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10613, 1908, 1920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo?
                f_10613_1861_1921(Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options)
                {
                    var return_v = feature.GetFeatureAvailabilityDiagnosticInfo(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10613, 1861, 1921);
                    return return_v;
                }


                int
                f_10613_1988_2003(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.DiagnosticInfo)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10613, 1988, 2003);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity?
                f_10613_2061_2075_M(Microsoft.CodeAnalysis.DiagnosticSeverity?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10613, 2061, 2075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10613_2361_2387(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10613, 2361, 2387);
                    return return_v;
                }


                int
                f_10613_2351_2388(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.DiagnosticInfo)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10613, 2351, 2388);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10613, 1593, 2415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10613, 1593, 2415);
            }
        }

        private static bool IsNullableReference(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10613, 2516, 2576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10613, 2519, 2576);
                return type is null || (DynAbs.Tracing.TraceSender.Expression_False(10613, 2519, 2576) || !(f_10613_2537_2553(type) || (DynAbs.Tracing.TraceSender.Expression_False(10613, 2537, 2575) || f_10613_2557_2575(type)))); DynAbs.Tracing.TraceSender.TraceExitMethod(10613, 2516, 2576);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10613, 2516, 2576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10613, 2516, 2576);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10613_2537_2553(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            this_param)
            {
                var return_v = this_param.IsValueType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10613, 2537, 2553);
                return return_v;
            }


            bool
            f_10613_2557_2575(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            type)
            {
                var return_v = type.IsErrorType();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10613, 2557, 2575);
                return return_v;
            }

        }

        protected override DiagnosticInfo ResolveInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10613, 2637, 2686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10613, 2640, 2686);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10613, 2640, 2671) || ((f_10613_2640_2671(_type.Type) && DynAbs.Tracing.TraceSender.Conditional_F2(10613, 2674, 2679)) || DynAbs.Tracing.TraceSender.Conditional_F3(10613, 2682, 2686))) ? _info : null; DynAbs.Tracing.TraceSender.TraceExitMethod(10613, 2637, 2686);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10613, 2637, 2686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10613, 2637, 2686);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10613_2640_2671(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            type)
            {
                var return_v = IsNullableReference(type);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10613, 2640, 2671);
                return return_v;
            }

        }

        public static void ReportNullableReferenceTypesIfNeeded(
                    bool isNullableEnabled,
                    bool isGeneratedCode,
                    TypeWithAnnotations type,
                    Location location,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10613, 2915, 3369);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10613, 3179, 3358) || true) && (f_10613_3183_3213(type.Type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10613, 3179, 3358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10613, 3247, 3343);

                    f_10613_3247_3342(isNullableEnabled, isGeneratedCode, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10613, 3179, 3358);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10613, 2915, 3369);

                bool
                f_10613_3183_3213(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsNullableReference(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10613, 3183, 3213);
                    return return_v;
                }


                int
                f_10613_3247_3342(bool
                isNullableEnabled, bool
                isGeneratedCode, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ReportNullableReferenceTypesIfNeeded(isNullableEnabled, isGeneratedCode, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10613, 3247, 3342);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10613, 2915, 3369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10613, 2915, 3369);
            }
        }

        public static void ReportNullableReferenceTypesIfNeeded(
                    bool isNullableEnabled,
                    bool isGeneratedCode,
                    Location location,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10613, 3381, 3956);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10613, 3606, 3664);

                var
                rawInfos = f_10613_3621_3663()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10613, 3678, 3785);

                f_10613_3678_3784(isNullableEnabled, isGeneratedCode, f_10613_3754_3773(location), rawInfos);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10613, 3799, 3915);
                    foreach (var rawInfo in f_10613_3823_3831_I(rawInfos))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10613, 3799, 3915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10613, 3865, 3900);

                        f_10613_3865_3899(diagnostics, rawInfo, location);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10613, 3799, 3915);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10613, 1, 117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10613, 1, 117);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10613, 3929, 3945);

                f_10613_3929_3944(rawInfos);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10613, 3381, 3956);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DiagnosticInfo>
                f_10613_3621_3663()
                {
                    var return_v = ArrayBuilder<DiagnosticInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10613, 3621, 3663);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_10613_3754_3773(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10613, 3754, 3773);
                    return return_v;
                }


                int
                f_10613_3678_3784(bool
                isNullableEnabled, bool
                isGeneratedCode, Microsoft.CodeAnalysis.SyntaxTree?
                tree, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DiagnosticInfo>
                infos)
                {
                    GetRawDiagnosticInfos(isNullableEnabled, isGeneratedCode, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree?)tree, infos);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10613, 3678, 3784);
                    return 0;
                }


                int
                f_10613_3865_3899(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10613, 3865, 3899);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DiagnosticInfo>
                f_10613_3823_3831_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DiagnosticInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10613, 3823, 3831);
                    return return_v;
                }


                int
                f_10613_3929_3944(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DiagnosticInfo>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10613, 3929, 3944);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10613, 3381, 3956);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10613, 3381, 3956);
            }
        }

        static LazyMissingNonNullTypesContextDiagnosticInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10613, 554, 3963);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10613, 554, 3963);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10613, 554, 3963);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10613, 554, 3963);

        int
        f_10613_885_911(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10613, 885, 911);
            return 0;
        }

    }
}

