// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public abstract class ParseOptions
    {
        private readonly Lazy<ImmutableArray<Diagnostic>> _lazyErrors;

        public SourceCodeKind Kind { get; protected set; }

        public SourceCodeKind SpecifiedKind { get; protected set; }

        public DocumentationMode DocumentationMode { get; protected set; }

        internal ParseOptions(SourceCodeKind kind, DocumentationMode documentationMode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(158, 1554, 2085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 693, 704);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 861, 911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 1172, 1231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 1476, 1542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 1658, 1684);

                this.SpecifiedKind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 1698, 1745);

                this.Kind = f_158_1710_1744(kind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 1759, 1802);

                this.DocumentationMode = documentationMode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 1818, 2074);

                _lazyErrors = f_158_1832_2073(() =>
                            {
                                var builder = ArrayBuilder<Diagnostic>.GetInstance();
                                ValidateOptions(builder);
                                return builder.ToImmutableAndFree();
                            });
                DynAbs.Tracing.TraceSender.TraceExitConstructor(158, 1554, 2085);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(158, 1554, 2085);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(158, 1554, 2085);
            }
        }

        public abstract string Language { get; }

        public ImmutableArray<Diagnostic> Errors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(158, 2451, 2484);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 2457, 2482);

                    return f_158_2464_2481(_lazyErrors);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(158, 2451, 2484);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    f_158_2464_2481(System.Lazy<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(158, 2464, 2481);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(158, 2386, 2495);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(158, 2386, 2495);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ParseOptions WithKind(SourceCodeKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(158, 2635, 2748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 2709, 2737);

                return f_158_2716_2736(this, kind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(158, 2635, 2748);

                Microsoft.CodeAnalysis.ParseOptions
                f_158_2716_2736(Microsoft.CodeAnalysis.ParseOptions
                this_param, Microsoft.CodeAnalysis.SourceCodeKind
                kind)
                {
                    var return_v = this_param.CommonWithKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 2716, 2736);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(158, 2635, 2748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(158, 2635, 2748);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract void ValidateOptions(ArrayBuilder<Diagnostic> builder);

        internal void ValidateOptions(ArrayBuilder<Diagnostic> builder, CommonMessageProvider messageProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(158, 2988, 3645);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 3201, 3404) || true) && (!f_158_3206_3229(f_158_3206_3219()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(158, 3201, 3404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 3263, 3389);

                    f_158_3263_3388(builder, f_158_3275_3387(messageProvider, f_158_3308_3345(messageProvider), f_158_3347_3360(), f_158_3362_3386(f_158_3362_3375())));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(158, 3201, 3404);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 3420, 3634) || true) && (!f_158_3425_3452(f_158_3425_3442()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(158, 3420, 3634);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 3486, 3619);

                    f_158_3486_3618(builder, f_158_3498_3617(messageProvider, f_158_3531_3571(messageProvider), f_158_3573_3586(), f_158_3588_3616(f_158_3588_3605())));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(158, 3420, 3634);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(158, 2988, 3645);

                Microsoft.CodeAnalysis.SourceCodeKind
                f_158_3206_3219()
                {
                    var return_v = SpecifiedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(158, 3206, 3219);
                    return return_v;
                }


                bool
                f_158_3206_3229(Microsoft.CodeAnalysis.SourceCodeKind
                value)
                {
                    var return_v = value.IsValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 3206, 3229);
                    return return_v;
                }


                int
                f_158_3308_3345(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_BadSourceCodeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(158, 3308, 3345);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_158_3347_3360()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(158, 3347, 3360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceCodeKind
                f_158_3362_3375()
                {
                    var return_v = SpecifiedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(158, 3362, 3375);
                    return return_v;
                }


                string
                f_158_3362_3386(Microsoft.CodeAnalysis.SourceCodeKind
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 3362, 3386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_158_3275_3387(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 3275, 3387);
                    return return_v;
                }


                int
                f_158_3263_3388(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 3263, 3388);
                    return 0;
                }


                Microsoft.CodeAnalysis.DocumentationMode
                f_158_3425_3442()
                {
                    var return_v = DocumentationMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(158, 3425, 3442);
                    return return_v;
                }


                bool
                f_158_3425_3452(Microsoft.CodeAnalysis.DocumentationMode
                value)
                {
                    var return_v = value.IsValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 3425, 3452);
                    return return_v;
                }


                int
                f_158_3531_3571(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_BadDocumentationMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(158, 3531, 3571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_158_3573_3586()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(158, 3573, 3586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DocumentationMode
                f_158_3588_3605()
                {
                    var return_v = DocumentationMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(158, 3588, 3605);
                    return return_v;
                }


                string
                f_158_3588_3616(Microsoft.CodeAnalysis.DocumentationMode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 3588, 3616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_158_3498_3617(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 3498, 3617);
                    return return_v;
                }


                int
                f_158_3486_3618(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 3486, 3618);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(158, 2988, 3645);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(158, 2988, 3645);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public abstract ParseOptions CommonWithKind(SourceCodeKind kind);

        public ParseOptions WithDocumentationMode(DocumentationMode documentationMode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(158, 4191, 4359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 4294, 4348);

                return f_158_4301_4347(this, documentationMode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(158, 4191, 4359);

                Microsoft.CodeAnalysis.ParseOptions
                f_158_4301_4347(Microsoft.CodeAnalysis.ParseOptions
                this_param, Microsoft.CodeAnalysis.DocumentationMode
                documentationMode)
                {
                    var return_v = this_param.CommonWithDocumentationMode(documentationMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 4301, 4347);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(158, 4191, 4359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(158, 4191, 4359);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract ParseOptions CommonWithDocumentationMode(DocumentationMode documentationMode);

        public ParseOptions WithFeatures(IEnumerable<KeyValuePair<string, string>> features)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(158, 4596, 4752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 4705, 4741);

                return f_158_4712_4740(this, features);
                DynAbs.Tracing.TraceSender.TraceExitMethod(158, 4596, 4752);

                Microsoft.CodeAnalysis.ParseOptions
                f_158_4712_4740(Microsoft.CodeAnalysis.ParseOptions
                this_param, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>
                features)
                {
                    var return_v = this_param.CommonWithFeatures(features);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 4712, 4740);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(158, 4596, 4752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(158, 4596, 4752);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract ParseOptions CommonWithFeatures(IEnumerable<KeyValuePair<string, string>> features);

        public abstract IReadOnlyDictionary<string, string> Features
        {
            get;
        }

        public abstract IEnumerable<string> PreprocessorSymbolNames { get; }

        public abstract override bool Equals(object? obj);

        protected bool EqualsHelper([NotNullWhen(true)] ParseOptions? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(158, 5327, 5947);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 5420, 5521) || true) && (f_158_5424_5459(other, null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(158, 5420, 5521);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 5493, 5506);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(158, 5420, 5521);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 5537, 5936);

                return
                f_158_5561_5579(this) == f_158_5583_5602(other) && (DynAbs.Tracing.TraceSender.Expression_True(158, 5561, 5672) && f_158_5623_5645(this) == f_158_5649_5672(other)) && (DynAbs.Tracing.TraceSender.Expression_True(158, 5561, 5736) && f_158_5693_5736(f_158_5693_5706(this), f_158_5721_5735(other))) && (DynAbs.Tracing.TraceSender.Expression_True(158, 5561, 5935) && ((DynAbs.Tracing.TraceSender.Conditional_F1(158, 5758, 5794) || ((f_158_5758_5786(this) == null && DynAbs.Tracing.TraceSender.Conditional_F2(158, 5797, 5834)) || DynAbs.Tracing.TraceSender.Conditional_F3(158, 5837, 5934))) ? f_158_5797_5826(other) == null : f_158_5837_5934(f_158_5837_5865(this), f_158_5880_5909(other), f_158_5911_5933())));
                DynAbs.Tracing.TraceSender.TraceExitMethod(158, 5327, 5947);

                bool
                f_158_5424_5459(Microsoft.CodeAnalysis.ParseOptions?
                objA, object?
                objB)
                {
                    var return_v = object.ReferenceEquals((object?)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 5424, 5459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceCodeKind
                f_158_5561_5579(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.SpecifiedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(158, 5561, 5579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceCodeKind
                f_158_5583_5602(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.SpecifiedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(158, 5583, 5602);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DocumentationMode
                f_158_5623_5645(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.DocumentationMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(158, 5623, 5645);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DocumentationMode
                f_158_5649_5672(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.DocumentationMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(158, 5649, 5672);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyDictionary<string, string>
                f_158_5693_5706(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.Features;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(158, 5693, 5706);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyDictionary<string, string>
                f_158_5721_5735(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.Features;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(158, 5721, 5735);
                    return return_v;
                }


                bool
                f_158_5693_5736(System.Collections.Generic.IReadOnlyDictionary<string, string>
                first, System.Collections.Generic.IReadOnlyDictionary<string, string>
                second)
                {
                    var return_v = first.SequenceEqual<System.Collections.Generic.KeyValuePair<string, string>>((System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 5693, 5736);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_158_5758_5786(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.PreprocessorSymbolNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(158, 5758, 5786);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_158_5797_5826(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.PreprocessorSymbolNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(158, 5797, 5826);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_158_5837_5865(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.PreprocessorSymbolNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(158, 5837, 5865);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_158_5880_5909(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.PreprocessorSymbolNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(158, 5880, 5909);
                    return return_v;
                }


                System.StringComparer
                f_158_5911_5933()
                {
                    var return_v = StringComparer.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(158, 5911, 5933);
                    return return_v;
                }


                bool
                f_158_5837_5934(System.Collections.Generic.IEnumerable<string>
                first, System.Collections.Generic.IEnumerable<string>
                second, System.StringComparer
                comparer)
                {
                    var return_v = first.SequenceEqual<string>(second, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 5837, 5934);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(158, 5327, 5947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(158, 5327, 5947);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract override int GetHashCode();

        protected int GetHashCodeHelper()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(158, 6014, 6373);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 6072, 6362);

                return
                f_158_6096_6361(f_158_6114_6132(this), f_158_6151_6360(f_158_6169_6191(this), f_158_6210_6359(f_158_6223_6250(f_158_6236_6249(this)), f_158_6269_6358(f_158_6282_6354(f_158_6301_6329(this), f_158_6331_6353()), 0))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(158, 6014, 6373);

                Microsoft.CodeAnalysis.SourceCodeKind
                f_158_6114_6132(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.SpecifiedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(158, 6114, 6132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DocumentationMode
                f_158_6169_6191(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.DocumentationMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(158, 6169, 6191);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyDictionary<string, string>
                f_158_6236_6249(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.Features;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(158, 6236, 6249);
                    return return_v;
                }


                int
                f_158_6223_6250(System.Collections.Generic.IReadOnlyDictionary<string, string>
                features)
                {
                    var return_v = HashFeatures(features);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 6223, 6250);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_158_6301_6329(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.PreprocessorSymbolNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(158, 6301, 6329);
                    return return_v;
                }


                System.StringComparer
                f_158_6331_6353()
                {
                    var return_v = StringComparer.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(158, 6331, 6353);
                    return return_v;
                }


                int
                f_158_6282_6354(System.Collections.Generic.IEnumerable<string>
                values, System.StringComparer
                stringComparer)
                {
                    var return_v = Hash.CombineValues(values, stringComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 6282, 6354);
                    return return_v;
                }


                int
                f_158_6269_6358(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 6269, 6358);
                    return return_v;
                }


                int
                f_158_6210_6359(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 6210, 6359);
                    return return_v;
                }


                int
                f_158_6151_6360(Microsoft.CodeAnalysis.DocumentationMode
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine((int)newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 6151, 6360);
                    return return_v;
                }


                int
                f_158_6096_6361(Microsoft.CodeAnalysis.SourceCodeKind
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine((int)newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 6096, 6361);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(158, 6014, 6373);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(158, 6014, 6373);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int HashFeatures(IReadOnlyDictionary<string, string> features)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(158, 6385, 6744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 6487, 6501);

                int
                value = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 6515, 6704);
                    foreach (var kv in f_158_6534_6542_I(features))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(158, 6515, 6704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 6576, 6689);

                        value = f_158_6584_6688(f_158_6597_6617(kv.Key), f_158_6644_6687(f_158_6657_6679(kv.Value), value));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(158, 6515, 6704);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(158, 1, 190);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(158, 1, 190);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 6720, 6733);

                return value;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(158, 6385, 6744);

                int
                f_158_6597_6617(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 6597, 6617);
                    return return_v;
                }


                int
                f_158_6657_6679(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 6657, 6679);
                    return return_v;
                }


                int
                f_158_6644_6687(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 6644, 6687);
                    return return_v;
                }


                int
                f_158_6584_6688(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 6584, 6688);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyDictionary<string, string>
                f_158_6534_6542_I(System.Collections.Generic.IReadOnlyDictionary<string, string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 6534, 6542);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(158, 6385, 6744);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(158, 6385, 6744);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(ParseOptions? left, ParseOptions? right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(158, 6756, 6897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 6852, 6886);

                return f_158_6859_6885(left, right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(158, 6756, 6897);

                bool
                f_158_6859_6885(Microsoft.CodeAnalysis.ParseOptions?
                objA, Microsoft.CodeAnalysis.ParseOptions?
                objB)
                {
                    var return_v = object.Equals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 6859, 6885);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(158, 6756, 6897);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(158, 6756, 6897);
            }
        }

        public static bool operator !=(ParseOptions? left, ParseOptions? right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(158, 6909, 7051);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(158, 7005, 7040);

                return !f_158_7013_7039(left, right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(158, 6909, 7051);

                bool
                f_158_7013_7039(Microsoft.CodeAnalysis.ParseOptions?
                objA, Microsoft.CodeAnalysis.ParseOptions?
                objB)
                {
                    var return_v = object.Equals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 7013, 7039);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(158, 6909, 7051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(158, 6909, 7051);
            }
        }

        static ParseOptions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(158, 592, 7058);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(158, 592, 7058);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(158, 592, 7058);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(158, 592, 7058);

        static Microsoft.CodeAnalysis.SourceCodeKind
        f_158_1710_1744(Microsoft.CodeAnalysis.SourceCodeKind
        kind)
        {
            var return_v = kind.MapSpecifiedToEffectiveKind();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 1710, 1744);
            return return_v;
        }


        static System.Lazy<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
        f_158_1832_2073(System.Func<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
        valueFactory)
        {
            var return_v = new System.Lazy<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>(valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(158, 1832, 2073);
            return return_v;
        }

    }
}
