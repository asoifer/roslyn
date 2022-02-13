// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal enum MessageID
    {
        None = 0,
        MessageBase = 1200,

        IDS_SK_METHOD = MessageBase + 2000,
        IDS_SK_TYPE = MessageBase + 2001,
        IDS_SK_NAMESPACE = MessageBase + 2002,
        IDS_SK_FIELD = MessageBase + 2003,
        IDS_SK_PROPERTY = MessageBase + 2004,
        IDS_SK_UNKNOWN = MessageBase + 2005,
        IDS_SK_VARIABLE = MessageBase + 2006,
        IDS_SK_EVENT = MessageBase + 2007,
        IDS_SK_TYVAR = MessageBase + 2008,
        //IDS_SK_GCLASS = MessageBase + 2009,
        IDS_SK_ALIAS = MessageBase + 2010,
        //IDS_SK_EXTERNALIAS = MessageBase + 2011,
        IDS_SK_LABEL = MessageBase + 2012,
        IDS_SK_CONSTRUCTOR = MessageBase + 2013,

        IDS_NULL = MessageBase + 10001,
        //IDS_RELATEDERROR = MessageBase + 10002,
        //IDS_RELATEDWARNING = MessageBase + 10003,
        IDS_XMLIGNORED = MessageBase + 10004,
        IDS_XMLIGNORED2 = MessageBase + 10005,
        IDS_XMLFAILEDINCLUDE = MessageBase + 10006,
        IDS_XMLBADINCLUDE = MessageBase + 10007,
        IDS_XMLNOINCLUDE = MessageBase + 10008,
        IDS_XMLMISSINGINCLUDEFILE = MessageBase + 10009,
        IDS_XMLMISSINGINCLUDEPATH = MessageBase + 10010,
        IDS_GlobalNamespace = MessageBase + 10011,
        IDS_FeatureGenerics = MessageBase + 12500,
        IDS_FeatureAnonDelegates = MessageBase + 12501,
        IDS_FeatureModuleAttrLoc = MessageBase + 12502,
        IDS_FeatureGlobalNamespace = MessageBase + 12503,
        IDS_FeatureFixedBuffer = MessageBase + 12504,
        IDS_FeaturePragma = MessageBase + 12505,
        IDS_FOREACHLOCAL = MessageBase + 12506,
        IDS_USINGLOCAL = MessageBase + 12507,
        IDS_FIXEDLOCAL = MessageBase + 12508,
        IDS_FeatureStaticClasses = MessageBase + 12511,
        IDS_FeaturePartialTypes = MessageBase + 12512,
        IDS_MethodGroup = MessageBase + 12513,
        IDS_AnonMethod = MessageBase + 12514,
        IDS_FeatureSwitchOnBool = MessageBase + 12517,
        //IDS_WarnAsError = MessageBase + 12518,
        IDS_Collection = MessageBase + 12520,
        IDS_FeaturePropertyAccessorMods = MessageBase + 12522,
        IDS_FeatureExternAlias = MessageBase + 12523,
        IDS_FeatureIterators = MessageBase + 12524,
        IDS_FeatureDefault = MessageBase + 12525,
        IDS_FeatureNullable = MessageBase + 12528,
        IDS_Lambda = MessageBase + 12531,
        IDS_FeaturePatternMatching = MessageBase + 12532,
        IDS_FeatureThrowExpression = MessageBase + 12533,

        IDS_FeatureImplicitArray = MessageBase + 12557,
        IDS_FeatureImplicitLocal = MessageBase + 12558,
        IDS_FeatureAnonymousTypes = MessageBase + 12559,
        IDS_FeatureAutoImplementedProperties = MessageBase + 12560,
        IDS_FeatureObjectInitializer = MessageBase + 12561,
        IDS_FeatureCollectionInitializer = MessageBase + 12562,
        IDS_FeatureLambda = MessageBase + 12563,
        IDS_FeatureQueryExpression = MessageBase + 12564,
        IDS_FeatureExtensionMethod = MessageBase + 12565,
        IDS_FeaturePartialMethod = MessageBase + 12566,
        IDS_FeatureDynamic = MessageBase + 12644,
        IDS_FeatureTypeVariance = MessageBase + 12645,
        IDS_FeatureNamedArgument = MessageBase + 12646,
        IDS_FeatureOptionalParameter = MessageBase + 12647,
        IDS_FeatureExceptionFilter = MessageBase + 12648,
        IDS_FeatureAutoPropertyInitializer = MessageBase + 12649,

        IDS_SK_TYPE_OR_NAMESPACE = MessageBase + 12652,
        IDS_Contravariant = MessageBase + 12659,
        IDS_Contravariantly = MessageBase + 12660,
        IDS_Covariant = MessageBase + 12661,
        IDS_Covariantly = MessageBase + 12662,
        IDS_Invariantly = MessageBase + 12663,

        IDS_FeatureAsync = MessageBase + 12668,
        IDS_FeatureStaticAnonymousFunction = MessageBase + 12669,

        IDS_LIB_ENV = MessageBase + 12680,
        IDS_LIB_OPTION = MessageBase + 12681,
        IDS_REFERENCEPATH_OPTION = MessageBase + 12682,
        IDS_DirectoryDoesNotExist = MessageBase + 12683,
        IDS_DirectoryHasInvalidPath = MessageBase + 12684,

        IDS_Namespace1 = MessageBase + 12685,
        IDS_PathList = MessageBase + 12686,
        IDS_Text = MessageBase + 12687,

        IDS_FeatureDiscards = MessageBase + 12688,

        IDS_FeatureDefaultTypeParameterConstraint = MessageBase + 12689,
        IDS_FeatureNullPropagatingOperator = MessageBase + 12690,
        IDS_FeatureExpressionBodiedMethod = MessageBase + 12691,
        IDS_FeatureExpressionBodiedProperty = MessageBase + 12692,
        IDS_FeatureExpressionBodiedIndexer = MessageBase + 12693,
        // IDS_VersionExperimental = MessageBase + 12694,
        IDS_FeatureNameof = MessageBase + 12695,
        IDS_FeatureDictionaryInitializer = MessageBase + 12696,

        IDS_ToolName = MessageBase + 12697,
        IDS_LogoLine1 = MessageBase + 12698,
        IDS_LogoLine2 = MessageBase + 12699,
        IDS_CSCHelp = MessageBase + 12700,

        IDS_FeatureUsingStatic = MessageBase + 12701,
        IDS_FeatureInterpolatedStrings = MessageBase + 12702,
        IDS_OperationCausedStackOverflow = MessageBase + 12703,
        IDS_AwaitInCatchAndFinally = MessageBase + 12704,
        IDS_FeatureReadonlyAutoImplementedProperties = MessageBase + 12705,
        IDS_FeatureBinaryLiteral = MessageBase + 12706,
        IDS_FeatureDigitSeparator = MessageBase + 12707,
        IDS_FeatureLocalFunctions = MessageBase + 12708,
        IDS_FeatureNullableReferenceTypes = MessageBase + 12709,

        IDS_FeatureRefLocalsReturns = MessageBase + 12710,
        IDS_FeatureTuples = MessageBase + 12711,
        IDS_FeatureOutVar = MessageBase + 12713,

        // IDS_FeaturePragmaWarningEnable = MessageBase + 12714,
        IDS_FeatureExpressionBodiedAccessor = MessageBase + 12715,
        IDS_FeatureExpressionBodiedDeOrConstructor = MessageBase + 12716,
        IDS_ThrowExpression = MessageBase + 12717,
        IDS_FeatureDefaultLiteral = MessageBase + 12718,
        IDS_FeatureInferredTupleNames = MessageBase + 12719,
        IDS_FeatureGenericPatternMatching = MessageBase + 12720,
        IDS_FeatureAsyncMain = MessageBase + 12721,
        IDS_LangVersions = MessageBase + 12722,

        IDS_FeatureLeadingDigitSeparator = MessageBase + 12723,
        IDS_FeatureNonTrailingNamedArguments = MessageBase + 12724,

        IDS_FeatureReadOnlyReferences = MessageBase + 12725,
        IDS_FeatureRefStructs = MessageBase + 12726,
        IDS_FeatureReadOnlyStructs = MessageBase + 12727,
        IDS_FeatureRefExtensionMethods = MessageBase + 12728,
        // IDS_StackAllocExpression = MessageBase + 12729,
        IDS_FeaturePrivateProtected = MessageBase + 12730,

        IDS_FeatureRefConditional = MessageBase + 12731,
        IDS_FeatureAttributesOnBackingFields = MessageBase + 12732,
        IDS_FeatureImprovedOverloadCandidates = MessageBase + 12733,
        IDS_FeatureRefReassignment = MessageBase + 12734,
        IDS_FeatureRefFor = MessageBase + 12735,
        IDS_FeatureRefForEach = MessageBase + 12736,
        IDS_FeatureEnumGenericTypeConstraint = MessageBase + 12737,
        IDS_FeatureDelegateGenericTypeConstraint = MessageBase + 12738,
        IDS_FeatureUnmanagedGenericTypeConstraint = MessageBase + 12739,
        IDS_FeatureStackAllocInitializer = MessageBase + 12740,
        IDS_FeatureTupleEquality = MessageBase + 12741,
        IDS_FeatureExpressionVariablesInQueriesAndInitializers = MessageBase + 12742,
        IDS_FeatureExtensibleFixedStatement = MessageBase + 12743,
        IDS_FeatureIndexingMovableFixedBuffers = MessageBase + 12744,

        IDS_FeatureAltInterpolatedVerbatimStrings = MessageBase + 12745,
        IDS_FeatureCoalesceAssignmentExpression = MessageBase + 12746,
        IDS_FeatureUnconstrainedTypeParameterInNullCoalescingOperator = MessageBase + 12747,
        IDS_FeatureNotNullGenericTypeConstraint = MessageBase + 12748,
        IDS_FeatureIndexOperator = MessageBase + 12749,
        IDS_FeatureRangeOperator = MessageBase + 12750,
        IDS_FeatureAsyncStreams = MessageBase + 12751,
        IDS_FeatureRecursivePatterns = MessageBase + 12752,
        IDS_Disposable = MessageBase + 12753,
        IDS_FeatureUsingDeclarations = MessageBase + 12754,
        IDS_FeatureStaticLocalFunctions = MessageBase + 12755,
        IDS_FeatureNameShadowingInNestedFunctions = MessageBase + 12756,
        IDS_FeatureUnmanagedConstructedTypes = MessageBase + 12757,
        IDS_FeatureObsoleteOnPropertyAccessor = MessageBase + 12758,
        IDS_FeatureReadOnlyMembers = MessageBase + 12759,
        IDS_DefaultInterfaceImplementation = MessageBase + 12760,
        IDS_OverrideWithConstraints = MessageBase + 12761,
        IDS_FeatureNestedStackalloc = MessageBase + 12762,
        IDS_FeatureSwitchExpression = MessageBase + 12763,
        IDS_FeatureAsyncUsing = MessageBase + 12764,
        IDS_FeatureLambdaDiscardParameters = MessageBase + 12765,
        IDS_FeatureLocalFunctionAttributes = MessageBase + 12766,
        IDS_FeatureExternLocalFunctions = MessageBase + 12767,
        IDS_FeatureMemberNotNull = MessageBase + 12768,

        IDS_FeatureNativeInt = MessageBase + 12769,
        IDS_FeatureImplicitObjectCreation = MessageBase + 12770,
        IDS_FeatureTypePattern = MessageBase + 12771,
        IDS_FeatureParenthesizedPattern = MessageBase + 12772,
        IDS_FeatureOrPattern = MessageBase + 12773,
        IDS_FeatureAndPattern = MessageBase + 12774,
        IDS_FeatureNotPattern = MessageBase + 12775,
        IDS_FeatureRelationalPattern = MessageBase + 12776,
        IDS_FeatureExtendedPartialMethods = MessageBase + 12777,
        IDS_TopLevelStatements = MessageBase + 12778,
        IDS_FeatureFunctionPointers = MessageBase + 12779,
        IDS_AddressOfMethodGroup = MessageBase + 12780,
        IDS_FeatureInitOnlySetters = MessageBase + 12781,
        IDS_FeatureRecords = MessageBase + 12782,
        IDS_FeatureNullPointerConstantPattern = MessageBase + 12783,
        IDS_FeatureModuleInitializers = MessageBase + 12784,
        IDS_FeatureTargetTypedConditional = MessageBase + 12785,
        IDS_FeatureCovariantReturnsForOverrides = MessageBase + 12786,
        IDS_FeatureExtensionGetEnumerator = MessageBase + 12787,
        IDS_FeatureExtensionGetAsyncEnumerator = MessageBase + 12788,
        IDS_Parameter = MessageBase + 12789,
        IDS_Return = MessageBase + 12790,
        IDS_FeatureVarianceSafetyForStaticInterfaceMembers = MessageBase + 12791,
        IDS_FeatureConstantInterpolatedStrings = MessageBase + 12792,
        IDS_FeatureMixedDeclarationsAndExpressionsInDeconstruction = MessageBase + 12793,
    }

    internal struct LocalizableErrorArgument : IFormattable
    {

        private readonly MessageID _id;

        internal LocalizableErrorArgument(MessageID id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10023, 11464, 11556);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 11536, 11545);

                _id = id;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10023, 11464, 11556);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10023, 11464, 11556);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10023, 11464, 11556);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10023, 11568, 11665);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 11626, 11654);

                return ToString(null, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10023, 11568, 11665);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10023, 11568, 11665);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10023, 11568, 11665);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10023, 11677, 11870);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 11773, 11859);

                return f_10023_11780_11858(_id, formatProvider as System.Globalization.CultureInfo);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10023, 11677, 11870);

                string
                f_10023_11780_11858(Microsoft.CodeAnalysis.CSharp.MessageID
                code, System.IFormatProvider?
                culture)
                {
                    var return_v = ErrorFacts.GetMessage(code, (System.Globalization.CultureInfo?)culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10023, 11780, 11858);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10023, 11677, 11870);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10023, 11677, 11870);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static LocalizableErrorArgument()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10023, 11349, 11877);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10023, 11349, 11877);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10023, 11349, 11877);
        }
    }
    internal static partial class MessageIDExtensions
    {
        public static LocalizableErrorArgument Localize(this MessageID id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10023, 12025, 12167);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 12116, 12156);

                return f_10023_12123_12155(id);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10023, 12025, 12167);

                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10023_12123_12155(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10023, 12123, 12155);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10023, 12025, 12167);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10023, 12025, 12167);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string? RequiredFeature(this MessageID feature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10023, 12666, 12959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 12842, 12948);

                switch (feature)
                {

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10023, 12842, 12948);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 12921, 12933);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10023, 12842, 12948);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10023, 12666, 12959);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10023, 12666, 12959);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10023, 12666, 12959);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CheckFeatureAvailability(
                    this MessageID feature,
                    DiagnosticBag diagnostics,
                    SyntaxNode syntax,
                    Location? location = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10023, 12971, 13500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 13191, 13295);

                var
                diag = f_10023_13202_13294(feature, f_10023_13268_13293(f_10023_13268_13285(syntax)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 13309, 13463) || true) && (diag is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10023, 13309, 13463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 13361, 13417);

                    f_10023_13361_13416(diagnostics, diag, location ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Location?>(10023, 13383, 13415) ?? f_10023_13395_13415(syntax)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 13435, 13448);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10023, 13309, 13463);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 13477, 13489);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10023, 12971, 13500);

                Microsoft.CodeAnalysis.SyntaxTree
                f_10023_13268_13285(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10023, 13268, 13285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParseOptions
                f_10023_13268_13293(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10023, 13268, 13293);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo?
                f_10023_13202_13294(Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.ParseOptions
                options)
                {
                    var return_v = feature.GetFeatureAvailabilityDiagnosticInfo((Microsoft.CodeAnalysis.CSharp.CSharpParseOptions)options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10023, 13202, 13294);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10023_13395_13415(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10023, 13395, 13415);
                    return return_v;
                }


                int
                f_10023_13361_13416(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10023, 13361, 13416);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10023, 12971, 13500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10023, 12971, 13500);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CheckFeatureAvailability(
                    this MessageID feature,
                    DiagnosticBag diagnostics,
                    Compilation compilation,
                    Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10023, 13512, 13980);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 13730, 13943) || true) && (f_10023_13734_13811(feature, compilation) is { } diagInfo)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10023, 13730, 13943);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 13861, 13897);

                    f_10023_13861_13896(diagnostics, diagInfo, location);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 13915, 13928);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10023, 13730, 13943);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 13957, 13969);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10023, 13512, 13980);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo?
                f_10023_13734_13811(Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = feature.GetFeatureAvailabilityDiagnosticInfo((Microsoft.CodeAnalysis.CSharp.CSharpCompilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10023, 13734, 13811);
                    return return_v;
                }


                int
                f_10023_13861_13896(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10023, 13861, 13896);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10023, 13512, 13980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10023, 13512, 13980);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CSDiagnosticInfo? GetFeatureAvailabilityDiagnosticInfo(this MessageID feature, CSharpParseOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10023, 14128, 14240);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 14131, 14240);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10023, 14131, 14164) || ((f_10023_14131_14164(options, feature) && DynAbs.Tracing.TraceSender.Conditional_F2(10023, 14167, 14171)) || DynAbs.Tracing.TraceSender.Conditional_F3(10023, 14174, 14240))) ? null : f_10023_14174_14240(feature, f_10023_14216_14239(options)); DynAbs.Tracing.TraceSender.TraceExitMethod(10023, 14128, 14240);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10023, 14128, 14240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10023, 14128, 14240);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CSDiagnosticInfo? GetFeatureAvailabilityDiagnosticInfo(this MessageID feature, CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10023, 14392, 14512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 14395, 14512);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10023, 14395, 14432) || ((f_10023_14395_14432(compilation, feature) && DynAbs.Tracing.TraceSender.Conditional_F2(10023, 14435, 14439)) || DynAbs.Tracing.TraceSender.Conditional_F3(10023, 14442, 14512))) ? null : f_10023_14442_14512(feature, f_10023_14484_14511(compilation)); DynAbs.Tracing.TraceSender.TraceExitMethod(10023, 14392, 14512);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10023, 14392, 14512);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10023, 14392, 14512);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CSDiagnosticInfo GetDisabledFeatureDiagnosticInfo(MessageID feature, LanguageVersion availableVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10023, 14525, 15332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 14667, 14719);

                string?
                requiredFeature = f_10023_14693_14718(feature)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 14733, 14911) || true) && (requiredFeature != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10023, 14733, 14911);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 14794, 14896);

                    return f_10023_14801_14895(ErrorCode.ERR_FeatureIsExperimental, f_10023_14859_14877(feature), requiredFeature);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10023, 14733, 14911);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 14927, 14987);

                LanguageVersion
                requiredVersion = f_10023_14961_14986(feature)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 15001, 15321);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10023, 15008, 15083) || ((requiredVersion == f_10023_15027_15083(LanguageVersion.Preview) && DynAbs.Tracing.TraceSender.Conditional_F2(10023, 15103, 15175)) || DynAbs.Tracing.TraceSender.Conditional_F3(10023, 15195, 15320))) ? f_10023_15103_15175(ErrorCode.ERR_FeatureInPreview, f_10023_15156_15174(feature)) : f_10023_15195_15320(f_10023_15216_15247(availableVersion), f_10023_15249_15267(feature), f_10023_15269_15319(requiredVersion));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10023, 14525, 15332);

                string?
                f_10023_14693_14718(Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = feature.RequiredFeature();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10023, 14693, 14718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10023_14859_14877(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10023, 14859, 14877);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10023_14801_14895(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10023, 14801, 14895);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10023_14961_14986(Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = feature.RequiredVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10023, 14961, 14986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10023_15027_15083(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = version.MapSpecifiedToEffectiveVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10023, 15027, 15083);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10023_15156_15174(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10023, 15156, 15174);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10023_15103_15175(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10023, 15103, 15175);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10023_15216_15247(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = version.GetErrorCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10023, 15216, 15247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10023_15249_15267(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10023, 15249, 15267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpRequiredLanguageVersion
                f_10023_15269_15319(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpRequiredLanguageVersion(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10023, 15269, 15319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10023_15195_15320(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10023, 15195, 15320);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10023, 14525, 15332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10023, 14525, 15332);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static LanguageVersion RequiredVersion(this MessageID feature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10023, 15344, 25735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 15440, 15487);

                f_10023_15440_15486(f_10023_15453_15477(feature) == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 15655, 25724);

                switch (feature)
                {

                    case MessageID.IDS_FeatureMixedDeclarationsAndExpressionsInDeconstruction:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10023, 15655, 25724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 15841, 15872);

                        return LanguageVersion.Preview;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10023, 15655, 25724);

                    case MessageID.IDS_FeatureLambdaDiscardParameters: // semantic check
                    case MessageID.IDS_FeatureFunctionPointers:
                    case MessageID.IDS_FeatureLocalFunctionAttributes: // syntax check
                    case MessageID.IDS_FeatureExternLocalFunctions: // syntax check
                    case MessageID.IDS_FeatureImplicitObjectCreation: // syntax check
                    case MessageID.IDS_FeatureMemberNotNull:
                    case MessageID.IDS_FeatureAndPattern:
                    case MessageID.IDS_FeatureNotPattern:
                    case MessageID.IDS_FeatureOrPattern:
                    case MessageID.IDS_FeatureParenthesizedPattern:
                    case MessageID.IDS_FeatureTypePattern:
                    case MessageID.IDS_FeatureRelationalPattern:
                    case MessageID.IDS_FeatureExtensionGetEnumerator: // semantic check
                    case MessageID.IDS_FeatureExtensionGetAsyncEnumerator: // semantic check
                    case MessageID.IDS_FeatureNativeInt:
                    case MessageID.IDS_FeatureExtendedPartialMethods: // semantic check
                    case MessageID.IDS_TopLevelStatements:
                    case MessageID.IDS_FeatureInitOnlySetters: // semantic check
                    case MessageID.IDS_FeatureRecords:
                    case MessageID.IDS_FeatureTargetTypedConditional:  // semantic check
                    case MessageID.IDS_FeatureCovariantReturnsForOverrides: // semantic check
                    case MessageID.IDS_FeatureStaticAnonymousFunction: // syntax check
                    case MessageID.IDS_FeatureModuleInitializers: // semantic check on method attribute
                    case MessageID.IDS_FeatureDefaultTypeParameterConstraint:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10023, 15655, 25724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 17668, 17699);

                        return LanguageVersion.CSharp9;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10023, 15655, 25724);

                    case MessageID.IDS_FeatureVarianceSafetyForStaticInterfaceMembers: //semantic check
                    case MessageID.IDS_FeatureConstantInterpolatedStrings: //semantic check
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10023, 15655, 25724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 17913, 17944);

                        return LanguageVersion.Preview;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10023, 15655, 25724);

                    case MessageID.IDS_FeatureAltInterpolatedVerbatimStrings:
                    case MessageID.IDS_FeatureCoalesceAssignmentExpression:
                    case MessageID.IDS_FeatureUnconstrainedTypeParameterInNullCoalescingOperator:
                    case MessageID.IDS_FeatureNullableReferenceTypes: // syntax and semantic check
                    case MessageID.IDS_FeatureIndexOperator: // semantic check
                    case MessageID.IDS_FeatureRangeOperator: // semantic check
                    case MessageID.IDS_FeatureAsyncStreams:
                    case MessageID.IDS_FeatureRecursivePatterns:
                    case MessageID.IDS_FeatureUsingDeclarations:
                    case MessageID.IDS_FeatureStaticLocalFunctions:
                    case MessageID.IDS_FeatureNameShadowingInNestedFunctions:
                    case MessageID.IDS_FeatureUnmanagedConstructedTypes: // semantic check
                    case MessageID.IDS_FeatureObsoleteOnPropertyAccessor:
                    case MessageID.IDS_FeatureReadOnlyMembers:
                    case MessageID.IDS_DefaultInterfaceImplementation: // semantic check
                    case MessageID.IDS_OverrideWithConstraints: // semantic check
                    case MessageID.IDS_FeatureNestedStackalloc: // semantic check
                    case MessageID.IDS_FeatureNotNullGenericTypeConstraint:// semantic check
                    case MessageID.IDS_FeatureSwitchExpression:
                    case MessageID.IDS_FeatureAsyncUsing:
                    case MessageID.IDS_FeatureNullPointerConstantPattern: //semantic check
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10023, 15655, 25724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 19574, 19605);

                        return LanguageVersion.CSharp8;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10023, 15655, 25724);

                    case MessageID.IDS_FeatureAttributesOnBackingFields: // semantic check
                    case MessageID.IDS_FeatureImprovedOverloadCandidates: // semantic check
                    case MessageID.IDS_FeatureTupleEquality: // semantic check
                    case MessageID.IDS_FeatureRefReassignment:
                    case MessageID.IDS_FeatureRefFor:
                    case MessageID.IDS_FeatureRefForEach:
                    case MessageID.IDS_FeatureEnumGenericTypeConstraint: // semantic check
                    case MessageID.IDS_FeatureDelegateGenericTypeConstraint: // semantic check
                    case MessageID.IDS_FeatureUnmanagedGenericTypeConstraint: // semantic check
                    case MessageID.IDS_FeatureStackAllocInitializer:
                    case MessageID.IDS_FeatureExpressionVariablesInQueriesAndInitializers: // semantic check
                    case MessageID.IDS_FeatureExtensibleFixedStatement:  // semantic check
                    case MessageID.IDS_FeatureIndexingMovableFixedBuffers: //semantic check
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10023, 15655, 25724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 20707, 20740);

                        return LanguageVersion.CSharp7_3;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10023, 15655, 25724);

                    case MessageID.IDS_FeatureNonTrailingNamedArguments: // semantic check
                    case MessageID.IDS_FeatureLeadingDigitSeparator:
                    case MessageID.IDS_FeaturePrivateProtected:
                    case MessageID.IDS_FeatureReadOnlyReferences:
                    case MessageID.IDS_FeatureRefStructs:
                    case MessageID.IDS_FeatureReadOnlyStructs:
                    case MessageID.IDS_FeatureRefExtensionMethods:
                    case MessageID.IDS_FeatureRefConditional:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10023, 15655, 25724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 21317, 21350);

                        return LanguageVersion.CSharp7_2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10023, 15655, 25724);

                    case MessageID.IDS_FeatureAsyncMain:
                    case MessageID.IDS_FeatureDefaultLiteral:
                    case MessageID.IDS_FeatureInferredTupleNames:
                    case MessageID.IDS_FeatureGenericPatternMatching:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10023, 15655, 25724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 21654, 21687);

                        return LanguageVersion.CSharp7_1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10023, 15655, 25724);

                    case MessageID.IDS_FeatureBinaryLiteral:
                    case MessageID.IDS_FeatureDigitSeparator:
                    case MessageID.IDS_FeatureLocalFunctions:
                    case MessageID.IDS_FeatureRefLocalsReturns:
                    case MessageID.IDS_FeaturePatternMatching:
                    case MessageID.IDS_FeatureThrowExpression:
                    case MessageID.IDS_FeatureTuples:
                    case MessageID.IDS_FeatureOutVar:
                    case MessageID.IDS_FeatureExpressionBodiedAccessor:
                    case MessageID.IDS_FeatureExpressionBodiedDeOrConstructor:
                    case MessageID.IDS_FeatureDiscards:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10023, 15655, 25724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 22403, 22434);

                        return LanguageVersion.CSharp7;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10023, 15655, 25724);

                    case MessageID.IDS_FeatureExceptionFilter:
                    case MessageID.IDS_FeatureAutoPropertyInitializer:
                    case MessageID.IDS_FeatureNullPropagatingOperator:
                    case MessageID.IDS_FeatureExpressionBodiedMethod:
                    case MessageID.IDS_FeatureExpressionBodiedProperty:
                    case MessageID.IDS_FeatureExpressionBodiedIndexer:
                    case MessageID.IDS_FeatureNameof:
                    case MessageID.IDS_FeatureDictionaryInitializer:
                    case MessageID.IDS_FeatureUsingStatic:
                    case MessageID.IDS_FeatureInterpolatedStrings:
                    case MessageID.IDS_AwaitInCatchAndFinally:
                    case MessageID.IDS_FeatureReadonlyAutoImplementedProperties:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10023, 15655, 25724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 23268, 23299);

                        return LanguageVersion.CSharp6;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10023, 15655, 25724);

                    case MessageID.IDS_FeatureAsync:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10023, 15655, 25724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 23408, 23439);

                        return LanguageVersion.CSharp5;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10023, 15655, 25724);

                    case MessageID.IDS_FeatureDynamic: // Checked in the binder.
                    case MessageID.IDS_FeatureTypeVariance:
                    case MessageID.IDS_FeatureNamedArgument:
                    case MessageID.IDS_FeatureOptionalParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10023, 15655, 25724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 23753, 23784);

                        return LanguageVersion.CSharp4;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10023, 15655, 25724);

                    case MessageID.IDS_FeatureImplicitArray:
                    case MessageID.IDS_FeatureAnonymousTypes:
                    case MessageID.IDS_FeatureObjectInitializer:
                    case MessageID.IDS_FeatureCollectionInitializer:
                    case MessageID.IDS_FeatureLambda:
                    case MessageID.IDS_FeatureQueryExpression:
                    case MessageID.IDS_FeatureExtensionMethod:
                    case MessageID.IDS_FeaturePartialMethod:
                    case MessageID.IDS_FeatureImplicitLocal: // Checked in the binder.
                    case MessageID.IDS_FeatureAutoImplementedProperties:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10023, 15655, 25724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 24471, 24502);

                        return LanguageVersion.CSharp3;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10023, 15655, 25724);

                    case MessageID.IDS_FeatureGenerics: // Also affects crefs.
                    case MessageID.IDS_FeatureAnonDelegates:
                    case MessageID.IDS_FeatureGlobalNamespace: // Also affects crefs.
                    case MessageID.IDS_FeatureFixedBuffer:
                    case MessageID.IDS_FeatureStaticClasses:
                    case MessageID.IDS_FeaturePartialTypes:
                    case MessageID.IDS_FeaturePropertyAccessorMods:
                    case MessageID.IDS_FeatureExternAlias:
                    case MessageID.IDS_FeatureIterators:
                    case MessageID.IDS_FeatureDefault:
                    case MessageID.IDS_FeatureNullable:
                    case MessageID.IDS_FeaturePragma: // Checked in the directive parser.
                    case MessageID.IDS_FeatureSwitchOnBool: // Checked in the binder.
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10023, 15655, 25724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 25399, 25430);

                        return LanguageVersion.CSharp2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10023, 15655, 25724);

                    case MessageID.IDS_FeatureModuleAttrLoc:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10023, 15655, 25724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 25578, 25609);

                        return LanguageVersion.CSharp1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10023, 15655, 25724);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10023, 15655, 25724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10023, 25659, 25709);

                        throw f_10023_25665_25708(feature);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10023, 15655, 25724);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10023, 15344, 25735);

                string?
                f_10023_15453_15477(Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = feature.RequiredFeature();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10023, 15453, 15477);
                    return return_v;
                }


                int
                f_10023_15440_15486(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10023, 15440, 15486);
                    return 0;
                }


                System.Exception
                f_10023_25665_25708(Microsoft.CodeAnalysis.CSharp.MessageID
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10023, 25665, 25708);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10023, 15344, 25735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10023, 15344, 25735);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MessageIDExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10023, 11959, 25742);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10023, 11959, 25742);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10023, 11959, 25742);
        }


        static bool
        f_10023_14131_14164(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
this_param, Microsoft.CodeAnalysis.CSharp.MessageID
feature)
        {
            var return_v = this_param.IsFeatureEnabled(feature);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10023, 14131, 14164);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.LanguageVersion
f_10023_14216_14239(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
this_param)
        {
            var return_v = this_param.LanguageVersion;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10023, 14216, 14239);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10023_14174_14240(Microsoft.CodeAnalysis.CSharp.MessageID
feature, Microsoft.CodeAnalysis.CSharp.LanguageVersion
availableVersion)
        {
            var return_v = GetDisabledFeatureDiagnosticInfo(feature, availableVersion);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10023, 14174, 14240);
            return return_v;
        }


        static bool
        f_10023_14395_14432(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation, Microsoft.CodeAnalysis.CSharp.MessageID
feature)
        {
            var return_v = compilation.IsFeatureEnabled(feature);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10023, 14395, 14432);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.LanguageVersion
f_10023_14484_14511(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
        {
            var return_v = this_param.LanguageVersion;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10023, 14484, 14511);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10023_14442_14512(Microsoft.CodeAnalysis.CSharp.MessageID
        feature, Microsoft.CodeAnalysis.CSharp.LanguageVersion
        availableVersion)
        {
            var return_v = GetDisabledFeatureDiagnosticInfo(feature, availableVersion);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10023, 14442, 14512);
            return return_v;
        }

    }
}
