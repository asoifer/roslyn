// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class LocalRewriter
    {
        private static BoundObjectInitializerExpressionBase UpdateInitializers(BoundObjectInitializerExpressionBase initializerExpression, ImmutableArray<BoundExpression> newInitializers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10516, 635, 1451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 839, 1440);

                switch (initializerExpression)
                {

                    case BoundObjectInitializerExpression objectInitializer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 839, 1440);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 980, 1088);

                        return f_10516_987_1087(objectInitializer, f_10516_1012_1041(objectInitializer), newInitializers, f_10516_1060_1086(initializerExpression));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 839, 1440);

                    case BoundCollectionInitializerExpression collectionInitializer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 839, 1440);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 1192, 1308);

                        return f_10516_1199_1307(collectionInitializer, f_10516_1228_1261(collectionInitializer), newInitializers, f_10516_1280_1306(initializerExpression));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 839, 1440);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 839, 1440);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 1356, 1425);

                        throw f_10516_1362_1424(f_10516_1397_1423(initializerExpression));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 839, 1440);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10516, 635, 1451);

                Microsoft.CodeAnalysis.CSharp.BoundObjectOrCollectionValuePlaceholder
                f_10516_1012_1041(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpression
                this_param)
                {
                    var return_v = this_param.Placeholder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 1012, 1041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10516_1060_1086(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 1060, 1086);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpression
                f_10516_987_1087(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpression
                this_param, Microsoft.CodeAnalysis.CSharp.BoundObjectOrCollectionValuePlaceholder
                placeholder, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                initializers, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(placeholder, initializers, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 987, 1087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectOrCollectionValuePlaceholder
                f_10516_1228_1261(Microsoft.CodeAnalysis.CSharp.BoundCollectionInitializerExpression
                this_param)
                {
                    var return_v = this_param.Placeholder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 1228, 1261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10516_1280_1306(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 1280, 1306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCollectionInitializerExpression
                f_10516_1199_1307(Microsoft.CodeAnalysis.CSharp.BoundCollectionInitializerExpression
                this_param, Microsoft.CodeAnalysis.CSharp.BoundObjectOrCollectionValuePlaceholder
                placeholder, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                initializers, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(placeholder, initializers, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 1199, 1307);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10516_1397_1423(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 1397, 1423);
                    return return_v;
                }


                System.Exception
                f_10516_1362_1424(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 1362, 1424);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10516, 635, 1451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10516, 635, 1451);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddObjectOrCollectionInitializers(
                    ref ArrayBuilder<BoundExpression>? dynamicSiteInitializers,
                    ref ArrayBuilder<LocalSymbol>? temps,
                    ArrayBuilder<BoundExpression> result,
                    BoundExpression rewrittenReceiver,
                    BoundExpression initializerExpression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10516, 1463, 3160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 1810, 1845);

                f_10516_1810_1844(!_inExpressionLambda);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 1859, 1899);

                f_10516_1859_1898(rewrittenReceiver != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 1915, 3149);

                switch (initializerExpression)
                {

                    case BoundObjectInitializerExpression objectInitializer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 1915, 3149);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 2083, 2131);

                            var
                            placeholder = f_10516_2101_2130(objectInitializer)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 2157, 2215);

                            f_10516_2157_2214(this, placeholder, rewrittenReceiver);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 2241, 2362);

                            f_10516_2241_2361(this, ref dynamicSiteInitializers, ref temps, result, rewrittenReceiver, f_10516_2330_2360(objectInitializer));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 2388, 2430);

                            f_10516_2388_2429(this, placeholder);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 2475, 2482);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 1915, 3149);

                    case BoundCollectionInitializerExpression collectionInitializer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 1915, 3149);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 2615, 2667);

                            var
                            placeholder = f_10516_2633_2666(collectionInitializer)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 2693, 2751);

                            f_10516_2693_2750(this, placeholder, rewrittenReceiver);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 2777, 2895);

                            f_10516_2777_2894(this, ref dynamicSiteInitializers, result, rewrittenReceiver, f_10516_2859_2893(collectionInitializer));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 2921, 2963);

                            f_10516_2921_2962(this, placeholder);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 3008, 3015);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 1915, 3149);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 1915, 3149);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 3065, 3134);

                        throw f_10516_3071_3133(f_10516_3106_3132(initializerExpression));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 1915, 3149);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10516, 1463, 3160);

                int
                f_10516_1810_1844(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 1810, 1844);
                    return 0;
                }


                int
                f_10516_1859_1898(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 1859, 1898);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectOrCollectionValuePlaceholder
                f_10516_2101_2130(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpression
                this_param)
                {
                    var return_v = this_param.Placeholder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 2101, 2130);
                    return return_v;
                }


                int
                f_10516_2157_2214(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundObjectOrCollectionValuePlaceholder
                placeholder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    this_param.AddPlaceholderReplacement((Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase)placeholder, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 2157, 2214);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10516_2330_2360(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpression
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 2330, 2360);
                    return return_v;
                }


                int
                f_10516_2241_2361(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>?
                dynamicSiteInitializers, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>?
                temps, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                result, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenReceiver, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                initializers)
                {
                    this_param.AddObjectInitializers(ref dynamicSiteInitializers, ref temps, result, rewrittenReceiver, initializers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 2241, 2361);
                    return 0;
                }


                int
                f_10516_2388_2429(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundObjectOrCollectionValuePlaceholder
                placeholder)
                {
                    this_param.RemovePlaceholderReplacement((Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase)placeholder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 2388, 2429);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectOrCollectionValuePlaceholder
                f_10516_2633_2666(Microsoft.CodeAnalysis.CSharp.BoundCollectionInitializerExpression
                this_param)
                {
                    var return_v = this_param.Placeholder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 2633, 2666);
                    return return_v;
                }


                int
                f_10516_2693_2750(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundObjectOrCollectionValuePlaceholder
                placeholder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    this_param.AddPlaceholderReplacement((Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase)placeholder, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 2693, 2750);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10516_2859_2893(Microsoft.CodeAnalysis.CSharp.BoundCollectionInitializerExpression
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 2859, 2893);
                    return return_v;
                }


                int
                f_10516_2777_2894(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>?
                dynamicSiteInitializers, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                result, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenReceiver, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                initializers)
                {
                    this_param.AddCollectionInitializers(ref dynamicSiteInitializers, result, rewrittenReceiver, initializers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 2777, 2894);
                    return 0;
                }


                int
                f_10516_2921_2962(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundObjectOrCollectionValuePlaceholder
                placeholder)
                {
                    this_param.RemovePlaceholderReplacement((Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase)placeholder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 2921, 2962);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10516_3106_3132(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 3106, 3132);
                    return return_v;
                }


                System.Exception
                f_10516_3071_3133(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 3071, 3133);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10516, 1463, 3160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10516, 1463, 3160);
            }
        }

        private ImmutableArray<BoundExpression> MakeObjectOrCollectionInitializersForExpressionTree(BoundExpression initializerExpression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10516, 3172, 4327);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 3327, 3361);

                f_10516_3327_3360(_inExpressionLambda);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 3377, 4316);

                switch (f_10516_3385_3411(initializerExpression))
                {

                    case BoundKind.ObjectInitializerExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 3377, 4316);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 3510, 3599);

                        return f_10516_3517_3598(this, f_10516_3527_3597(((BoundObjectInitializerExpression)initializerExpression)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 3377, 4316);

                    case BoundKind.CollectionInitializerExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 3377, 4316);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 3688, 3745);

                        var
                        result = f_10516_3701_3744()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 3767, 3829);

                        ArrayBuilder<BoundExpression>?
                        dynamicSiteInitializers = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 3851, 3996);

                        f_10516_3851_3995(this, ref dynamicSiteInitializers, result, null, f_10516_3920_3994(((BoundCollectionInitializerExpression)initializerExpression)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 4077, 4123);

                        f_10516_4077_4122(dynamicSiteInitializers == null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 4147, 4182);

                        return f_10516_4154_4181(result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 3377, 4316);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 3377, 4316);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 4232, 4301);

                        throw f_10516_4238_4300(f_10516_4273_4299(initializerExpression));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 3377, 4316);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10516, 3172, 4327);

                int
                f_10516_3327_3360(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 3327, 3360);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10516_3385_3411(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 3385, 3411);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10516_3527_3597(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpression
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 3527, 3597);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10516_3517_3598(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                list)
                {
                    var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundExpression>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 3517, 3598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10516_3701_3744()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 3701, 3744);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10516_3920_3994(Microsoft.CodeAnalysis.CSharp.BoundCollectionInitializerExpression
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 3920, 3994);
                    return return_v;
                }


                int
                f_10516_3851_3995(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>?
                dynamicSiteInitializers, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                result, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                rewrittenReceiver, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                initializers)
                {
                    this_param.AddCollectionInitializers(ref dynamicSiteInitializers, result, rewrittenReceiver, initializers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 3851, 3995);
                    return 0;
                }


                int
                f_10516_4077_4122(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 4077, 4122);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10516_4154_4181(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 4154, 4181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10516_4273_4299(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 4273, 4299);
                    return return_v;
                }


                System.Exception
                f_10516_4238_4300(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 4238, 4300);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10516, 3172, 4327);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10516, 3172, 4327);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddCollectionInitializers(ref ArrayBuilder<BoundExpression>? dynamicSiteInitializers, ArrayBuilder<BoundExpression> result, BoundExpression? rewrittenReceiver, ImmutableArray<BoundExpression> initializers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10516, 4469, 5972);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 4712, 4774);

                f_10516_4712_4773(rewrittenReceiver is { } || (DynAbs.Tracing.TraceSender.Expression_False(10516, 4725, 4772) || _inExpressionLambda));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 4790, 5961);
                    foreach (var initializer in f_10516_4818_4830_I(initializers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 4790, 5961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 5080, 5118);

                        BoundExpression?
                        rewrittenInitializer
                        = default(BoundExpression?);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 5136, 5749) || true) && (f_10516_5140_5156(initializer) == BoundKind.CollectionElementInitializer)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 5136, 5749);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 5240, 5356);

                            rewrittenInitializer = f_10516_5263_5355(this, rewrittenReceiver, initializer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 5136, 5749);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 5136, 5749);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 5438, 5473);

                            f_10516_5438_5472(!_inExpressionLambda);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 5495, 5575);

                            f_10516_5495_5574(f_10516_5508_5524(initializer) == BoundKind.DynamicCollectionElementInitializer);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 5599, 5730);

                            rewrittenInitializer = f_10516_5622_5729(this, rewrittenReceiver!, initializer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 5136, 5749);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 5820, 5946) || true) && (rewrittenInitializer != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 5820, 5946);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 5894, 5927);

                            f_10516_5894_5926(result, rewrittenInitializer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 5820, 5946);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 4790, 5961);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10516, 1, 1172);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10516, 1, 1172);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10516, 4469, 5972);

                int
                f_10516_4712_4773(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 4712, 4773);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10516_5140_5156(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 5140, 5156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10516_5263_5355(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                rewrittenReceiver, Microsoft.CodeAnalysis.CSharp.BoundExpression
                initializer)
                {
                    var return_v = this_param.MakeCollectionInitializer(rewrittenReceiver, (Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer)initializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 5263, 5355);
                    return return_v;
                }


                int
                f_10516_5438_5472(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 5438, 5472);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10516_5508_5524(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 5508, 5524);
                    return return_v;
                }


                int
                f_10516_5495_5574(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 5495, 5574);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10516_5622_5729(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenReceiver, Microsoft.CodeAnalysis.CSharp.BoundExpression
                initializer)
                {
                    var return_v = this_param.MakeDynamicCollectionInitializer(rewrittenReceiver, (Microsoft.CodeAnalysis.CSharp.BoundDynamicCollectionElementInitializer)initializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 5622, 5729);
                    return return_v;
                }


                int
                f_10516_5894_5926(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 5894, 5926);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10516_4818_4830_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 4818, 4830);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10516, 4469, 5972);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10516, 4469, 5972);
            }
        }

        private BoundExpression MakeDynamicCollectionInitializer(BoundExpression rewrittenReceiver, BoundDynamicCollectionElementInitializer initializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10516, 5984, 6966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 6154, 6212);

                var
                rewrittenArguments = f_10516_6179_6211(this, f_10516_6189_6210(initializer))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 6395, 6479);

                f_10516_6395_6478(this, rewrittenReceiver, f_10516_6428_6457(initializer), initializer.Syntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 6495, 6955);

                return f_10516_6502_6939(_dynamicFactory, WellKnownMemberNames.CollectionInitializerAddMethodName, rewrittenReceiver, ImmutableArray<TypeWithAnnotations>.Empty, rewrittenArguments, default(ImmutableArray<string>), default(ImmutableArray<RefKind>), hasImplicitReceiver: false, resultDiscarded: true).ToExpression();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10516, 5984, 6966);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10516_6189_6210(Microsoft.CodeAnalysis.CSharp.BoundDynamicCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 6189, 6210);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10516_6179_6211(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                list)
                {
                    var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundExpression>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 6179, 6211);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10516_6428_6457(Microsoft.CodeAnalysis.CSharp.BoundDynamicCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.ApplicableMethods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 6428, 6457);
                    return return_v;
                }


                int
                f_10516_6395_6478(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                methods, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmbedIfNeedTo(receiver, methods, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 6395, 6478);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
                f_10516_6502_6939(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, string
                name, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredReceiver, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgumentsWithAnnotations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, bool
                hasImplicitReceiver, bool
                resultDiscarded)
                {
                    var return_v = this_param.MakeDynamicMemberInvocation(name, loweredReceiver, typeArgumentsWithAnnotations, loweredArguments, argumentNames, refKinds, hasImplicitReceiver: hasImplicitReceiver, resultDiscarded: resultDiscarded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 6502, 6939);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10516, 5984, 6966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10516, 5984, 6966);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression? MakeCollectionInitializer(BoundExpression? rewrittenReceiver, BoundCollectionElementInitializer initializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10516, 7192, 10452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 7350, 7397);

                MethodSymbol
                addMethod = f_10516_7375_7396(initializer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 7413, 7451);

                f_10516_7413_7450(f_10516_7426_7440(addMethod) == "Add");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 7465, 7641);

                f_10516_7465_7640(f_10516_7478_7639(f_10516_7478_7558(addMethod.Parameters
                , (DynAbs.Tracing.TraceSender.Conditional_F1(10516, 7522, 7549) || ((f_10516_7522_7549(addMethod) && DynAbs.Tracing.TraceSender.Conditional_F2(10516, 7552, 7553)) || DynAbs.Tracing.TraceSender.Conditional_F3(10516, 7556, 7557))) ? 1 : 0), p => p.RefKind == RefKind.None || p.RefKind == RefKind.In));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 7655, 7697);

                f_10516_7655_7696(initializer.Arguments.Any());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 7711, 7774);

                f_10516_7711_7773(rewrittenReceiver != null || (DynAbs.Tracing.TraceSender.Expression_False(10516, 7724, 7772) || _inExpressionLambda));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 7790, 7822);

                var
                syntax = initializer.Syntax
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 7838, 8194) || true) && (_allowOmissionOfConditionalCalls)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 7838, 8194);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 8053, 8179) || true) && (f_10516_8057_8106(addMethod, f_10516_8083_8105(initializer)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 8053, 8179);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 8148, 8160);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 8053, 8179);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 7838, 8194);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 8210, 8268);

                var
                rewrittenArguments = f_10516_8235_8267(this, f_10516_8245_8266(initializer))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 8282, 8330);

                var
                rewrittenType = f_10516_8302_8329(this, f_10516_8312_8328(initializer))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 8615, 8649);

                ImmutableArray<LocalSymbol>
                temps
                = default(ImmutableArray<LocalSymbol>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 8663, 8722);

                var
                argumentRefKindsOpt = default(ImmutableArray<RefKind>)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 8736, 9367) || true) && (f_10516_8740_8771(f_10516_8740_8760(addMethod)[0]) == RefKind.Ref)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 8736, 9367);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 9149, 9240);

                    var
                    builder = f_10516_9163_9239(addMethod.Parameters.Length, RefKind.None)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 9258, 9283);

                    builder[0] = RefKind.Ref;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 9301, 9352);

                    argumentRefKindsOpt = f_10516_9323_9351(builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 8736, 9367);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 9383, 9579);

                rewrittenArguments = f_10516_9404_9578(this, syntax, rewrittenArguments, addMethod, f_10516_9457_9477(initializer), f_10516_9479_9506(initializer), ref argumentRefKindsOpt, out temps, enableCallerInfo: ThreeState.True);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 9595, 9922) || true) && (f_10516_9599_9635(initializer))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 9595, 9922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 9669, 9702);

                    f_10516_9669_9701(f_10516_9682_9700(addMethod));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 9720, 9762);

                    f_10516_9720_9761(f_10516_9733_9760(addMethod));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 9780, 9864);

                    f_10516_9780_9863(!_inExpressionLambda, "Expression trees do not support extension Add");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 9882, 9907);

                    rewrittenReceiver = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 9595, 9922);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 9938, 10233) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 9938, 10233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 9995, 10218);

                    return f_10516_10002_10217(initializer, addMethod, rewrittenArguments, rewrittenReceiver, expanded: false, argsToParamsOpt: default, defaultArguments: default, f_10516_10141_10177(initializer), f_10516_10179_10201(initializer), rewrittenType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 9938, 10233);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 10249, 10441);

                return f_10516_10256_10440(this, null, syntax, rewrittenReceiver, addMethod, rewrittenArguments, argumentRefKindsOpt, f_10516_10350_10386(initializer), f_10516_10388_10410(initializer), f_10516_10412_10432(addMethod), temps);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10516, 7192, 10452);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10516_7375_7396(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.AddMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 7375, 7396);
                    return return_v;
                }


                string
                f_10516_7426_7440(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 7426, 7440);
                    return return_v;
                }


                int
                f_10516_7413_7450(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 7413, 7450);
                    return 0;
                }


                bool
                f_10516_7522_7549(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 7522, 7549);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10516_7478_7558(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                source, int
                count)
                {
                    var return_v = source.Skip<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 7478, 7558);
                    return return_v;
                }


                bool
                f_10516_7478_7639(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol, bool>
                predicate)
                {
                    var return_v = source.All<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 7478, 7639);
                    return return_v;
                }


                int
                f_10516_7465_7640(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 7465, 7640);
                    return 0;
                }


                int
                f_10516_7655_7696(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 7655, 7696);
                    return 0;
                }


                int
                f_10516_7711_7773(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 7711, 7773);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_10516_8083_8105(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 8083, 8105);
                    return return_v;
                }


                bool
                f_10516_8057_8106(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.SyntaxTree?
                syntaxTree)
                {
                    var return_v = this_param.CallsAreOmitted(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 8057, 8106);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10516_8245_8266(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 8245, 8266);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10516_8235_8267(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                list)
                {
                    var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundExpression>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 8235, 8267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10516_8312_8328(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 8312, 8328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10516_8302_8329(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 8302, 8329);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10516_8740_8760(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 8740, 8760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10516_8740_8771(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 8740, 8771);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                f_10516_9163_9239(int
                capacity, Microsoft.CodeAnalysis.RefKind
                fillWithValue)
                {
                    var return_v = ArrayBuilder<RefKind>.GetInstance(capacity, fillWithValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 9163, 9239);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10516_9323_9351(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 9323, 9351);
                    return return_v;
                }


                bool
                f_10516_9457_9477(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.Expanded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 9457, 9477);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10516_9479_9506(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 9479, 9506);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10516_9404_9578(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                rewrittenArguments, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodOrIndexer, bool
                expanded, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps, Microsoft.CodeAnalysis.ThreeState
                enableCallerInfo)
                {
                    var return_v = this_param.MakeArguments(syntax, rewrittenArguments, (Microsoft.CodeAnalysis.CSharp.Symbol)methodOrIndexer, expanded, argsToParamsOpt, ref argumentRefKindsOpt, out temps, enableCallerInfo: enableCallerInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 9404, 9578);
                    return return_v;
                }


                bool
                f_10516_9599_9635(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.InvokedAsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 9599, 9635);
                    return return_v;
                }


                bool
                f_10516_9682_9700(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 9682, 9700);
                    return return_v;
                }


                int
                f_10516_9669_9701(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 9669, 9701);
                    return 0;
                }


                bool
                f_10516_9733_9760(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 9733, 9760);
                    return return_v;
                }


                int
                f_10516_9720_9761(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 9720, 9761);
                    return 0;
                }


                int
                f_10516_9780_9863(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 9780, 9863);
                    return 0;
                }


                bool
                f_10516_10141_10177(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.InvokedAsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 10141, 10177);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10516_10179_10201(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 10179, 10201);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                f_10516_10002_10217(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                addMethod, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                implicitReceiverOpt, bool
                expanded, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, bool
                invokedAsExtensionMethod, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(addMethod, arguments, implicitReceiverOpt, expanded: expanded, argsToParamsOpt: argsToParamsOpt, defaultArguments: defaultArguments, invokedAsExtensionMethod, resultKind, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 10002, 10217);
                    return return_v;
                }


                bool
                f_10516_10350_10386(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.InvokedAsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 10350, 10386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10516_10388_10410(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 10388, 10410);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10516_10412_10432(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 10412, 10432);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10516_10256_10440(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall?
                node, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                rewrittenReceiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                rewrittenArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKinds, bool
                invokedAsExtensionMethod, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps)
                {
                    var return_v = this_param.MakeCall(node, syntax, rewrittenReceiver, method, rewrittenArguments, argumentRefKinds, invokedAsExtensionMethod, resultKind, type, temps);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 10256, 10440);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10516, 7192, 10452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10516, 7192, 10452);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddObjectInitializers(
                    ref ArrayBuilder<BoundExpression>? dynamicSiteInitializers,
                    ref ArrayBuilder<LocalSymbol>? temps,
                    ArrayBuilder<BoundExpression> result,
                    BoundExpression rewrittenReceiver,
                    ImmutableArray<BoundExpression> initializers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10516, 10550, 11365);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 10892, 10927);

                f_10516_10892_10926(!_inExpressionLambda);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 10943, 11354);
                    foreach (var initializer in f_10516_10971_10983_I(initializers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 10943, 11354);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 11213, 11339);

                        f_10516_11213_11338(this, ref dynamicSiteInitializers, ref temps, result, rewrittenReceiver, initializer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 10943, 11354);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10516, 1, 412);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10516, 1, 412);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10516, 10550, 11365);

                int
                f_10516_10892_10926(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 10892, 10926);
                    return 0;
                }


                int
                f_10516_11213_11338(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>?
                dynamicSiteInitializers, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>?
                temps, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                result, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenReceiver, Microsoft.CodeAnalysis.CSharp.BoundExpression
                assignment)
                {
                    this_param.AddObjectInitializer(ref dynamicSiteInitializers, ref temps, result, rewrittenReceiver, (Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator)assignment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 11213, 11338);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10516_10971_10983_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 10971, 10983);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10516, 10550, 11365);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10516, 10550, 11365);
            }
        }

        private void AddObjectInitializer(
                    ref ArrayBuilder<BoundExpression>? dynamicSiteInitializers,
                    ref ArrayBuilder<LocalSymbol>? temps,
                    ArrayBuilder<BoundExpression> result,
                    BoundExpression rewrittenReceiver,
                    BoundAssignmentOperator assignment)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10516, 11541, 21145);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 11872, 11912);

                f_10516_11872_11911(rewrittenReceiver != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 11926, 11961);

                f_10516_11926_11960(!_inExpressionLambda);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 12109, 12147);

                BoundExpression?
                rewrittenLeft = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 12231, 12387) || true) && (f_10516_12235_12255(f_10516_12235_12250(assignment)) != BoundKind.PointerElementAccess)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 12231, 12387);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 12323, 12372);

                    rewrittenLeft = f_10516_12339_12371(this, f_10516_12355_12370(assignment));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 12231, 12387);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 12403, 12445);

                BoundKind
                rhsKind = f_10516_12423_12444(f_10516_12423_12439(assignment))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 12459, 12594);

                bool
                isRhsNestedInitializer = rhsKind == BoundKind.ObjectInitializerExpression || (DynAbs.Tracing.TraceSender.Expression_False(10516, 12489, 12593) || rhsKind == BoundKind.CollectionInitializerExpression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 12610, 12642);

                BoundExpression
                rewrittenAccess
                = default(BoundExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 12656, 21001);

                switch (f_10516_12664_12703((rewrittenLeft ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpression?>(10516, 12665, 12697) ?? f_10516_12682_12697(assignment)))))
                {

                    case BoundKind.ObjectInitializerMember:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 12656, 21001);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 12825, 12887);

                            var
                            memberInit = (BoundObjectInitializerMember?)rewrittenLeft
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 12913, 12945);

                            f_10516_12913_12944(memberInit is { });

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 12973, 14037) || true) && (f_10516_12977_13015_M(!memberInit.Arguments.IsDefaultOrEmpty))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 12973, 14037);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 13073, 13381);

                                var
                                args = f_10516_13084_13380(this, f_10516_13156_13176(memberInit), f_10516_13235_13258(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10516_13211_13234(memberInit), 10516, 13211, 13258)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>?>(10516, 13211, 13294) ?? default(ImmutableArray<RefKind>)), result, ref temps)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 13413, 14010);

                                memberInit = f_10516_13426_14009(memberInit, f_10516_13478_13501(memberInit), args, f_10516_13575_13602(memberInit), f_10516_13637_13667(memberInit), f_10516_13702_13721(memberInit), f_10516_13756_13782(memberInit), f_10516_13817_13844(memberInit), f_10516_13879_13900(memberInit), f_10516_13935_13958(memberInit), f_10516_13993_14008(memberInit));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 12973, 14037);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 14065, 16587) || true) && (f_10516_14069_14092(memberInit) == null && (DynAbs.Tracing.TraceSender.Expression_True(10516, 14069, 14131) && f_10516_14104_14131(f_10516_14104_14119(memberInit))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 14065, 16587);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 14189, 14391) || true) && (dynamicSiteInitializers == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 14189, 14391);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 14290, 14360);

                                    dynamicSiteInitializers = f_10516_14316_14359();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 14189, 14391);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 14423, 15282) || true) && (!isRhsNestedInitializer)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 14423, 15282);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 14516, 14571);

                                    var
                                    rewrittenRight = f_10516_14537_14570(this, f_10516_14553_14569(assignment))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 14605, 14961);

                                    var
                                    setMember = f_10516_14621_14960(_dynamicFactory, rewrittenReceiver, f_10516_14751_14771(memberInit), f_10516_14810_14837(memberInit), f_10516_14876_14906(memberInit), rewrittenRight)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 14997, 15047);

                                    f_10516_14997_15046(setMember.SiteInitialization is { });
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 15081, 15139);

                                    f_10516_15081_15138(dynamicSiteInitializers, setMember.SiteInitialization);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 15173, 15210);

                                    f_10516_15173_15209(result, setMember.SiteInvocation);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 15244, 15251);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 14423, 15282);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 15314, 15601);

                                var
                                getMember = f_10516_15330_15600(_dynamicFactory, rewrittenReceiver, f_10516_15452_15472(memberInit), f_10516_15507_15534(memberInit), f_10516_15569_15599(memberInit))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 15633, 15683);

                                f_10516_15633_15682(getMember.SiteInitialization is { });
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 15713, 15771);

                                f_10516_15713_15770(dynamicSiteInitializers, getMember.SiteInitialization);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 15801, 15844);

                                rewrittenAccess = getMember.SiteInvocation;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 14065, 16587);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 14065, 16587);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 15958, 16065);

                                rewrittenAccess = f_10516_15976_16064(this, rewrittenReceiver, memberInit, isRhsNestedInitializer);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 16095, 16560) || true) && (!isRhsNestedInitializer)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 16095, 16560);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 16269, 16324);

                                    var
                                    rewrittenRight = f_10516_16290_16323(this, f_10516_16306_16322(assignment))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 16358, 16488);

                                    f_10516_16358_16487(result, f_10516_16369_16486(this, assignment.Syntax, rewrittenAccess, rewrittenRight, false, f_10516_16457_16472(assignment), used: false));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 16522, 16529);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 16095, 16560);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 14065, 16587);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10516, 16613, 16619);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 12656, 21001);

                    case BoundKind.DynamicObjectInitializerMember:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 12656, 21001);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 16757, 16947) || true) && (dynamicSiteInitializers == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 16757, 16947);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 16850, 16920);

                                dynamicSiteInitializers = f_10516_16876_16919();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 16757, 16947);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 16975, 17010);

                            f_10516_16975_17009(rewrittenLeft is { });
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 17036, 17111);

                            var
                            initializerMember = (BoundDynamicObjectInitializerMember)rewrittenLeft
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 17139, 17726) || true) && (!isRhsNestedInitializer)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 17139, 17726);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 17224, 17279);

                                var
                                rewrittenRight = f_10516_17245_17278(this, f_10516_17261_17277(assignment))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 17309, 17427);

                                var
                                setMember = f_10516_17325_17426(_dynamicFactory, rewrittenReceiver, f_10516_17381_17409(initializerMember), rewrittenRight)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 17457, 17507);

                                f_10516_17457_17506(setMember.SiteInitialization is { });
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 17537, 17595);

                                f_10516_17537_17594(dynamicSiteInitializers, setMember.SiteInitialization);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 17625, 17662);

                                f_10516_17625_17661(result, setMember.SiteInvocation);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 17692, 17699);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 17139, 17726);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 17754, 17878);

                            var
                            getMember = f_10516_17770_17877(_dynamicFactory, rewrittenReceiver, f_10516_17826_17854(initializerMember), resultIndexed: false)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 17904, 17954);

                            f_10516_17904_17953(getMember.SiteInitialization is { });
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 17980, 18038);

                            f_10516_17980_18037(dynamicSiteInitializers, getMember.SiteInitialization);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 18064, 18107);

                            rewrittenAccess = getMember.SiteInvocation;
                            DynAbs.Tracing.TraceSender.TraceBreak(10516, 18133, 18139);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 12656, 21001);

                    case BoundKind.ArrayAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 12656, 21001);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 18258, 18293);

                            f_10516_18258_18292(rewrittenLeft is { });
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 18319, 18369);

                            var
                            arrayAccess = (BoundArrayAccess)rewrittenLeft
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 18395, 18631);

                            var
                            indices = f_10516_18409_18630(this, f_10516_18477_18496(arrayAccess), paramRefKindsOpt: default, result, ref temps)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 18657, 18740);

                            rewrittenAccess = f_10516_18675_18739(arrayAccess, rewrittenReceiver, indices, f_10516_18722_18738(arrayAccess));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 18768, 19209) || true) && (!isRhsNestedInitializer)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 18768, 19209);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 18930, 18985);

                                var
                                rewrittenRight = f_10516_18951_18984(this, f_10516_18967_18983(assignment))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 19015, 19145);

                                f_10516_19015_19144(result, f_10516_19026_19143(this, assignment.Syntax, rewrittenAccess, rewrittenRight, false, f_10516_19114_19129(assignment), used: false));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 19175, 19182);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 18768, 19209);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10516, 19237, 19243);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 12656, 21001);

                    case BoundKind.PointerElementAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 12656, 21001);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 19442, 19505);

                            var
                            pointerAccess = (BoundPointerElementAccess)f_10516_19489_19504(assignment)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 19531, 19589);

                            var
                            rewrittenIndex = f_10516_19552_19588(this, f_10516_19568_19587(pointerAccess))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 19617, 20219) || true) && (f_10516_19621_19663(rewrittenIndex))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 19617, 20219);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 19721, 19751);

                                BoundAssignmentOperator
                                store
                                = default(BoundAssignmentOperator);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 19781, 19840);

                                var
                                temp = f_10516_19792_19839(_factory, rewrittenIndex, out store)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 19870, 19892);

                                rewrittenIndex = temp;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 19924, 20086) || true) && (temps == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 19924, 20086);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 20007, 20055);

                                    temps = f_10516_20015_20054();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 19924, 20086);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 20116, 20144);

                                f_10516_20116_20143(temps, f_10516_20126_20142(temp));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 20174, 20192);

                                f_10516_20174_20191(result, store);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 19617, 20219);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 20247, 20343);

                            rewrittenAccess = f_10516_20265_20342(this, pointerAccess, rewrittenReceiver, rewrittenIndex);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 20371, 20797) || true) && (!isRhsNestedInitializer)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 20371, 20797);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 20518, 20573);

                                var
                                rewrittenRight = f_10516_20539_20572(this, f_10516_20555_20571(assignment))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 20603, 20733);

                                f_10516_20603_20732(result, f_10516_20614_20731(this, assignment.Syntax, rewrittenAccess, rewrittenRight, false, f_10516_20702_20717(assignment), used: false));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 20763, 20770);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 20371, 20797);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10516, 20825, 20831);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 12656, 21001);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 12656, 21001);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 20904, 20986);

                        throw f_10516_20910_20985(f_10516_20945_20984((rewrittenLeft ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpression?>(10516, 20946, 20978) ?? f_10516_20963_20978(assignment)))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 12656, 21001);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 21017, 21134);

                f_10516_21017_21133(this, ref dynamicSiteInitializers, ref temps, result, rewrittenAccess, f_10516_21116_21132(assignment));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10516, 11541, 21145);

                int
                f_10516_11872_11911(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 11872, 11911);
                    return 0;
                }


                int
                f_10516_11926_11960(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 11926, 11960);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10516_12235_12250(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 12235, 12250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10516_12235_12255(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 12235, 12255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10516_12355_12370(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 12355, 12370);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10516_12339_12371(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpression(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 12339, 12371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10516_12423_12439(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 12423, 12439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10516_12423_12444(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 12423, 12444);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10516_12682_12697(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 12682, 12697);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10516_12664_12703(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 12664, 12703);
                    return return_v;
                }


                int
                f_10516_12913_12944(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 12913, 12944);
                    return 0;
                }


                bool
                f_10516_12977_13015_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 12977, 13015);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10516_13156_13176(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 13156, 13176);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10516_13211_13234(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.MemberSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 13211, 13234);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>?
                f_10516_13235_13258(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member?.GetParameterRefKinds();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 13235, 13258);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10516_13084_13380(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                paramRefKindsOpt, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideeffects, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>?
                temps)
                {
                    var return_v = this_param.EvaluateSideEffectingArgumentsToTemps(args, paramRefKindsOpt, sideeffects, ref temps);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 13084, 13380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10516_13478_13501(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.MemberSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 13478, 13501);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10516_13575_13602(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.ArgumentNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 13575, 13602);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10516_13637_13667(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 13637, 13667);
                    return return_v;
                }


                bool
                f_10516_13702_13721(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.Expanded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 13702, 13721);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10516_13756_13782(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 13756, 13782);
                    return return_v;
                }


                Microsoft.CodeAnalysis.BitVector
                f_10516_13817_13844(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.DefaultArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 13817, 13844);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10516_13879_13900(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 13879, 13900);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10516_13935_13958(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.ReceiverType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 13935, 13958);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10516_13993_14008(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 13993, 14008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                f_10516_13426_14009(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol?
                memberSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, bool
                expanded, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                receiverType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(memberSymbol, arguments, argumentNamesOpt, argumentRefKindsOpt, expanded, argsToParamsOpt, defaultArguments, resultKind, receiverType, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 13426, 14009);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10516_14069_14092(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.MemberSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 14069, 14092);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10516_14104_14119(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 14104, 14119);
                    return return_v;
                }


                bool
                f_10516_14104_14131(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 14104, 14131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10516_14316_14359()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 14316, 14359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10516_14553_14569(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 14553, 14569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10516_14537_14570(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpression(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 14537, 14570);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10516_14751_14771(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 14751, 14771);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10516_14810_14837(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.ArgumentNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 14810, 14837);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10516_14876_14906(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 14876, 14906);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
                f_10516_14621_14960(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredReceiver, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredRight)
                {
                    var return_v = this_param.MakeDynamicSetIndex(loweredReceiver, loweredArguments, argumentNames, refKinds, loweredRight);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 14621, 14960);
                    return return_v;
                }


                int
                f_10516_14997_15046(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 14997, 15046);
                    return 0;
                }


                int
                f_10516_15081_15138(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 15081, 15138);
                    return 0;
                }


                int
                f_10516_15173_15209(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 15173, 15209);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10516_15452_15472(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 15452, 15472);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10516_15507_15534(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.ArgumentNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 15507, 15534);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10516_15569_15599(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 15569, 15599);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
                f_10516_15330_15600(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredReceiver, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                loweredArguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds)
                {
                    var return_v = this_param.MakeDynamicGetIndex(loweredReceiver, loweredArguments, argumentNames, refKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 15330, 15600);
                    return return_v;
                }


                int
                f_10516_15633_15682(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 15633, 15682);
                    return 0;
                }


                int
                f_10516_15713_15770(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 15713, 15770);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10516_15976_16064(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenReceiver, Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                rewrittenLeft, bool
                isRhsNestedInitializer)
                {
                    var return_v = this_param.MakeObjectInitializerMemberAccess(rewrittenReceiver, rewrittenLeft, isRhsNestedInitializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 15976, 16064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10516_16306_16322(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 16306, 16322);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10516_16290_16323(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpression(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 16290, 16323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10516_16457_16472(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 16457, 16472);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10516_16369_16486(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenLeft, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenRight, bool
                isRef, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                used)
                {
                    var return_v = this_param.MakeStaticAssignmentOperator(syntax, rewrittenLeft, rewrittenRight, isRef, type, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 16369, 16486);
                    return return_v;
                }


                int
                f_10516_16358_16487(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 16358, 16487);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10516_16876_16919()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 16876, 16919);
                    return return_v;
                }


                int
                f_10516_16975_17009(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 16975, 17009);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10516_17261_17277(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 17261, 17277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10516_17245_17278(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpression(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 17245, 17278);
                    return return_v;
                }


                string
                f_10516_17381_17409(Microsoft.CodeAnalysis.CSharp.BoundDynamicObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.MemberName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 17381, 17409);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
                f_10516_17325_17426(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredReceiver, string
                name, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredRight)
                {
                    var return_v = this_param.MakeDynamicSetMember(loweredReceiver, name, loweredRight);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 17325, 17426);
                    return return_v;
                }


                int
                f_10516_17457_17506(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 17457, 17506);
                    return 0;
                }


                int
                f_10516_17537_17594(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 17537, 17594);
                    return 0;
                }


                int
                f_10516_17625_17661(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 17625, 17661);
                    return 0;
                }


                string
                f_10516_17826_17854(Microsoft.CodeAnalysis.CSharp.BoundDynamicObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.MemberName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 17826, 17854);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
                f_10516_17770_17877(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredReceiver, string
                name, bool
                resultIndexed)
                {
                    var return_v = this_param.MakeDynamicGetMember(loweredReceiver, name, resultIndexed: resultIndexed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 17770, 17877);
                    return return_v;
                }


                int
                f_10516_17904_17953(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 17904, 17953);
                    return 0;
                }


                int
                f_10516_17980_18037(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 17980, 18037);
                    return 0;
                }


                int
                f_10516_18258_18292(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 18258, 18292);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10516_18477_18496(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Indices;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 18477, 18496);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10516_18409_18630(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                paramRefKindsOpt, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideeffects, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>?
                temps)
                {
                    var return_v = this_param.EvaluateSideEffectingArgumentsToTemps(args, paramRefKindsOpt: paramRefKindsOpt, sideeffects, ref temps);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 18409, 18630);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10516_18722_18738(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 18722, 18738);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                f_10516_18675_18739(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                indices, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(expression, indices, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 18675, 18739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10516_18967_18983(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 18967, 18983);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10516_18951_18984(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpression(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 18951, 18984);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10516_19114_19129(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 19114, 19129);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10516_19026_19143(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenLeft, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenRight, bool
                isRef, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                used)
                {
                    var return_v = this_param.MakeStaticAssignmentOperator(syntax, rewrittenLeft, rewrittenRight, isRef, type, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 19026, 19143);
                    return return_v;
                }


                int
                f_10516_19015_19144(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 19015, 19144);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10516_19489_19504(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 19489, 19504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10516_19568_19587(Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 19568, 19587);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10516_19552_19588(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpression(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 19552, 19588);
                    return return_v;
                }


                bool
                f_10516_19621_19663(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = CanChangeValueBetweenReads(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 19621, 19663);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10516_19792_19839(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                store)
                {
                    var return_v = this_param.StoreToTemp(argument, out store);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 19792, 19839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10516_20015_20054()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 20015, 20054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10516_20126_20142(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 20126, 20142);
                    return return_v;
                }


                int
                f_10516_20116_20143(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 20116, 20143);
                    return 0;
                }


                int
                f_10516_20174_20191(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 20174, 20191);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10516_20265_20342(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenExpression, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenIndex)
                {
                    var return_v = this_param.RewritePointerElementAccess(node, rewrittenExpression, rewrittenIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 20265, 20342);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10516_20555_20571(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 20555, 20571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10516_20539_20572(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpression(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 20539, 20572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10516_20702_20717(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 20702, 20717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10516_20614_20731(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenLeft, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenRight, bool
                isRef, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                used)
                {
                    var return_v = this_param.MakeStaticAssignmentOperator(syntax, rewrittenLeft, rewrittenRight, isRef, type, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 20614, 20731);
                    return return_v;
                }


                int
                f_10516_20603_20732(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 20603, 20732);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10516_20963_20978(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 20963, 20978);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10516_20945_20984(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 20945, 20984);
                    return return_v;
                }


                System.Exception
                f_10516_20910_20985(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 20910, 20985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10516_21116_21132(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 21116, 21132);
                    return return_v;
                }


                int
                f_10516_21017_21133(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>?
                dynamicSiteInitializers, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>?
                temps, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                result, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenReceiver, Microsoft.CodeAnalysis.CSharp.BoundExpression
                initializerExpression)
                {
                    this_param.AddObjectOrCollectionInitializers(ref dynamicSiteInitializers, ref temps, result, rewrittenReceiver, initializerExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 21017, 21133);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10516, 11541, 21145);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10516, 11541, 21145);
            }
        }

        private ImmutableArray<BoundExpression> EvaluateSideEffectingArgumentsToTemps(
                                                         ImmutableArray<BoundExpression> args,
                                                         ImmutableArray<RefKind> paramRefKindsOpt,
                                                         ArrayBuilder<BoundExpression> sideeffects,
                                                         ref ArrayBuilder<LocalSymbol>? temps)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10516, 21157, 22804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 21621, 21667);

                ArrayBuilder<BoundExpression>?
                newArgs = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 21692, 21697);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 21683, 22732) || true) && (i < args.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 21716, 21719)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 21683, 22732))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 21683, 22732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 21753, 21771);

                        var
                        arg = args[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 21791, 22717) || true) && (f_10516_21795_21826(arg))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 21791, 22717);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 21868, 22077) || true) && (newArgs == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 21868, 22077);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 21937, 22002);

                                newArgs = f_10516_21947_22001(args.Length);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 22028, 22054);

                                f_10516_22028_22053(newArgs, args, i);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 21868, 22077);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 22101, 22148);

                            RefKind
                            refKind = paramRefKindsOpt.RefKinds(i)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 22172, 22202);

                            BoundAssignmentOperator
                            store
                            = default(BoundAssignmentOperator);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 22224, 22281);

                            var
                            temp = f_10516_22235_22280(_factory, arg, out store, refKind)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 22303, 22321);

                            f_10516_22303_22320(newArgs, temp);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 22345, 22483) || true) && (temps == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 22345, 22483);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 22412, 22460);

                                temps = f_10516_22420_22459();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 22345, 22483);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 22505, 22533);

                            f_10516_22505_22532(temps, f_10516_22515_22531(temp));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 22555, 22578);

                            f_10516_22555_22577(sideeffects, store);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 21791, 22717);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 21791, 22717);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 22620, 22717) || true) && (newArgs != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 22620, 22717);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 22681, 22698);

                                f_10516_22681_22697(newArgs, arg);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 22620, 22717);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 21791, 22717);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10516, 1, 1050);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10516, 1, 1050);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 22748, 22793);

                return f_10516_22755_22784_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(newArgs, 10516, 22755, 22784)?.ToImmutableAndFree()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>?>(10516, 22755, 22792) ?? args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10516, 21157, 22804);

                bool
                f_10516_21795_21826(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = CanChangeValueBetweenReads(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 21795, 21826);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10516_21947_22001(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 21947, 22001);
                    return return_v;
                }


                int
                f_10516_22028_22053(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                items, int
                length)
                {
                    this_param.AddRange(items, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 22028, 22053);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10516_22235_22280(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                store, Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = this_param.StoreToTemp(argument, out store, refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 22235, 22280);
                    return return_v;
                }


                int
                f_10516_22303_22320(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 22303, 22320);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10516_22420_22459()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 22420, 22459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10516_22515_22531(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 22515, 22531);
                    return return_v;
                }


                int
                f_10516_22505_22532(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 22505, 22532);
                    return 0;
                }


                int
                f_10516_22555_22577(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 22555, 22577);
                    return 0;
                }


                int
                f_10516_22681_22697(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 22681, 22697);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>?
                f_10516_22755_22784_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 22755, 22784);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10516, 21157, 22804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10516, 21157, 22804);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression MakeObjectInitializerMemberAccess(
                    BoundExpression rewrittenReceiver,
                    BoundObjectInitializerMember rewrittenLeft,
                    bool isRhsNestedInitializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10516, 22816, 25689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 23046, 23092);

                var
                memberSymbol = f_10516_23065_23091(rewrittenLeft)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 23106, 23157);

                HashSet<DiagnosticInfo>?
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 23171, 23349);

                f_10516_23171_23348(memberSymbol != null && (DynAbs.Tracing.TraceSender.Expression_True(10516, 23184, 23347) && f_10516_23208_23336(f_10516_23208_23232(_compilation), f_10516_23260_23282(rewrittenReceiver), f_10516_23284_23311(memberSymbol), ref useSiteDiagnostics).IsImplicit));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 23520, 25678);

                switch (f_10516_23528_23545(memberSymbol))
                {

                    case SymbolKind.Field:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 23520, 25678);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 23623, 23667);

                        var
                        fieldSymbol = (FieldSymbol)memberSymbol
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 23689, 23816);

                        return f_10516_23696_23815(this, rewrittenLeft.Syntax, rewrittenReceiver, fieldSymbol, null, f_10516_23772_23796(rewrittenLeft), f_10516_23798_23814(fieldSymbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 23520, 25678);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 23520, 25678);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 23883, 23933);

                        var
                        propertySymbol = (PropertySymbol)memberSymbol
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 23955, 23995);

                        var
                        arguments = f_10516_23971_23994(rewrittenLeft)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 24017, 25296) || true) && (f_10516_24021_24039_M(!arguments.IsEmpty) || (DynAbs.Tracing.TraceSender.Expression_False(10516, 24021, 24075) || f_10516_24043_24075(propertySymbol)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 24017, 25296);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 24125, 24825);

                            return f_10516_24132_24824(this, rewrittenLeft.Syntax, rewrittenReceiver, propertySymbol, f_10516_24324_24347(rewrittenLeft), f_10516_24378_24408(rewrittenLeft), f_10516_24439_24472(rewrittenLeft), f_10516_24503_24525(rewrittenLeft), f_10516_24556_24585(rewrittenLeft), f_10516_24616_24646(rewrittenLeft), type: f_10516_24683_24702(propertySymbol), oldNodeOpt: null, isLeftOfAssignment: !isRhsNestedInitializer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 24017, 25296);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 24017, 25296);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 24923, 25273);

                            return f_10516_24930_25272(this, rewrittenLeft.Syntax, rewrittenReceiver, propertySymbol, f_10516_25123_25147(rewrittenLeft), f_10516_25178_25197(propertySymbol), isLeftOfAssignment: !isRhsNestedInitializer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 24017, 25296);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 23520, 25678);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 23520, 25678);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 25360, 25404);

                        var
                        eventSymbol = (EventSymbol)memberSymbol
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 25426, 25553);

                        return f_10516_25433_25552(this, rewrittenLeft.Syntax, rewrittenReceiver, eventSymbol, null, f_10516_25509_25533(rewrittenLeft), f_10516_25535_25551(eventSymbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 23520, 25678);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10516, 23520, 25678);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10516, 25603, 25663);

                        throw f_10516_25609_25662(f_10516_25644_25661(memberSymbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10516, 23520, 25678);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10516, 22816, 25689);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10516_23065_23091(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.MemberSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 23065, 23091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10516_23208_23232(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 23208, 23232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10516_23260_23282(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 23260, 23282);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10516_23284_23311(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 23284, 23311);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10516_23208_23336(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                source, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyConversionFromType(source, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 23208, 23336);
                    return return_v;
                }


                int
                f_10516_23171_23348(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 23171, 23348);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10516_23528_23545(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 23528, 23545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10516_23772_23796(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 23772, 23796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10516_23798_23814(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 23798, 23814);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10516_23696_23815(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenReceiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MakeFieldAccess(syntax, rewrittenReceiver, fieldSymbol, constantValueOpt, resultKind, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 23696, 23815);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10516_23971_23994(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 23971, 23994);
                    return return_v;
                }


                bool
                f_10516_24021_24039_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 24021, 24039);
                    return return_v;
                }


                bool
                f_10516_24043_24075(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.IsIndexedProperty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 24043, 24075);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10516_24324_24347(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 24324, 24347);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10516_24378_24408(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.ArgumentNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 24378, 24408);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10516_24439_24472(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 24439, 24472);
                    return return_v;
                }


                bool
                f_10516_24503_24525(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.Expanded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 24503, 24525);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10516_24556_24585(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 24556, 24585);
                    return return_v;
                }


                Microsoft.CodeAnalysis.BitVector
                f_10516_24616_24646(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.DefaultArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 24616, 24646);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10516_24683_24702(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 24683, 24702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10516_24132_24824(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenReceiver, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                indexer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                rewrittenArguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, bool
                expanded, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess?
                oldNodeOpt, bool
                isLeftOfAssignment)
                {
                    var return_v = this_param.MakeIndexerAccess(syntax, rewrittenReceiver, indexer, rewrittenArguments, argumentNamesOpt, argumentRefKindsOpt, expanded, argsToParamsOpt, defaultArguments, type: type, oldNodeOpt: oldNodeOpt, isLeftOfAssignment: isLeftOfAssignment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 24132, 24824);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10516_25123_25147(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 25123, 25147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10516_25178_25197(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 25178, 25197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10516_24930_25272(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenReceiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                propertySymbol, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                isLeftOfAssignment)
                {
                    var return_v = this_param.MakePropertyAccess(syntax, rewrittenReceiverOpt, propertySymbol, resultKind, type, isLeftOfAssignment: isLeftOfAssignment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 24930, 25272);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10516_25509_25533(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 25509, 25533);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10516_25535_25551(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 25535, 25551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10516_25433_25552(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenReceiver, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                eventSymbol, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MakeEventAccess(syntax, rewrittenReceiver, eventSymbol, constantValueOpt, resultKind, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 25433, 25552);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10516_25644_25661(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10516, 25644, 25661);
                    return return_v;
                }


                System.Exception
                f_10516_25609_25662(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10516, 25609, 25662);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10516, 22816, 25689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10516, 22816, 25689);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
