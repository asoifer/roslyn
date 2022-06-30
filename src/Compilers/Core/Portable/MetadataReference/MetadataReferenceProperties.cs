// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Immutable;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    public struct MetadataReferenceProperties : IEquatable<MetadataReferenceProperties>
    {

        private readonly MetadataImageKind _kind;

        private readonly ImmutableArray<string> _aliases;

        private readonly bool _embedInteropTypes;

        public static MetadataReferenceProperties Module
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(432, 886, 946);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 889, 946);
                    return f_432_889_946(MetadataImageKind.Module); DynAbs.Tracing.TraceSender.TraceExitMethod(432, 886, 946);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(432, 886, 946);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(432, 886, 946);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static MetadataReferenceProperties Assembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(432, 1116, 1178);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 1119, 1178);
                    return f_432_1119_1178(MetadataImageKind.Assembly); 
                    DynAbs.Tracing.TraceSender.TraceExitMethod(432, 1116, 1178);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(432, 1116, 1178);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(432, 1116, 1178);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public MetadataReferenceProperties(MetadataImageKind kind = MetadataImageKind.Assembly, ImmutableArray<string> aliases = default, bool embedInteropTypes = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(432, 1620, 2954);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 1806, 1926) || true) && (!f_432_1811_1825(kind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(432, 1806, 1926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 1859, 1911);

                    throw f_432_1865_1910(nameof(kind));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(432, 1806, 1926);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 1942, 2417) || true) && (kind == MetadataImageKind.Module)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(432, 1942, 2417);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 2012, 2206) || true) && (embedInteropTypes)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(432, 2012, 2206);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 2075, 2187);

                        throw f_432_2081_2186(f_432_2103_2158(), nameof(embedInteropTypes));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(432, 2012, 2206);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 2226, 2402) || true) && (f_432_2230_2255_M(!aliases.IsDefaultOrEmpty))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(432, 2226, 2402);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 2297, 2383);

                        throw f_432_2303_2382(f_432_2325_2364(), nameof(aliases));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(432, 2226, 2402);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(432, 1942, 2417);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 2433, 2786) || true) && (f_432_2437_2462_M(!aliases.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(432, 2433, 2786);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 2496, 2771);
                        foreach (var alias in f_432_2518_2525_I(aliases))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(432, 2496, 2771);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 2567, 2752) || true) && (!f_432_2572_2598(alias))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(432, 2567, 2752);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 2648, 2729);

                                throw f_432_2654_2728(f_432_2676_2710(), nameof(aliases));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(432, 2567, 2752);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(432, 2496, 2771);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(432, 1, 276);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(432, 1, 276);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(432, 2433, 2786);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 2802, 2815);

                _kind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 2829, 2848);

                _aliases = aliases;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 2862, 2901);

                _embedInteropTypes = embedInteropTypes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 2915, 2943);

                HasRecursiveAliases = false;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(432, 1620, 2954);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(432, 1620, 2954);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(432, 1620, 2954);
            }
        }

        internal MetadataReferenceProperties(MetadataImageKind kind, ImmutableArray<string> aliases, bool embedInteropTypes, bool hasRecursiveAliases)
        : this(f_432_3129_3133_C(kind), aliases, embedInteropTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(432, 2966, 3240);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 3187, 3229);

                HasRecursiveAliases = hasRecursiveAliases;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(432, 2966, 3240);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(432, 2966, 3240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(432, 2966, 3240);
            }
        }

        public MetadataReferenceProperties WithAliases(IEnumerable<string> aliases)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(432, 3566, 3726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 3666, 3715);

                return WithAliases(f_432_3685_3713(aliases));
                DynAbs.Tracing.TraceSender.TraceExitMethod(432, 3566, 3726);

                System.Collections.Immutable.ImmutableArray<string>
                f_432_3685_3713(System.Collections.Generic.IEnumerable<string>
                items)
                {
                    var return_v = items.AsImmutableOrEmpty<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(432, 3685, 3713);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(432, 3566, 3726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(432, 3566, 3726);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public MetadataReferenceProperties WithAliases(ImmutableArray<string> aliases)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(432, 4052, 4262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 4155, 4251);

                return f_432_4162_4250(_kind, aliases, _embedInteropTypes, HasRecursiveAliases);
                DynAbs.Tracing.TraceSender.TraceExitMethod(432, 4052, 4262);

                Microsoft.CodeAnalysis.MetadataReferenceProperties
                f_432_4162_4250(Microsoft.CodeAnalysis.MetadataImageKind
                kind, System.Collections.Immutable.ImmutableArray<string>
                aliases, bool
                embedInteropTypes, bool
                hasRecursiveAliases)
                {
                    var return_v = new Microsoft.CodeAnalysis.MetadataReferenceProperties(kind, aliases, embedInteropTypes, hasRecursiveAliases);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(432, 4162, 4250);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(432, 4052, 4262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(432, 4052, 4262);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public MetadataReferenceProperties WithEmbedInteropTypes(bool embedInteropTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(432, 4617, 4829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 4722, 4818);

                return f_432_4729_4817(_kind, _aliases, embedInteropTypes, HasRecursiveAliases);
                DynAbs.Tracing.TraceSender.TraceExitMethod(432, 4617, 4829);

                Microsoft.CodeAnalysis.MetadataReferenceProperties
                f_432_4729_4817(Microsoft.CodeAnalysis.MetadataImageKind
                kind, System.Collections.Immutable.ImmutableArray<string>
                aliases, bool
                embedInteropTypes, bool
                hasRecursiveAliases)
                {
                    var return_v = new Microsoft.CodeAnalysis.MetadataReferenceProperties(kind, aliases, embedInteropTypes, hasRecursiveAliases);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(432, 4729, 4817);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(432, 4617, 4829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(432, 4617, 4829);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal MetadataReferenceProperties WithRecursiveAliases(bool value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(432, 5014, 5202);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 5108, 5191);

                return f_432_5115_5190(_kind, _aliases, _embedInteropTypes, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(432, 5014, 5202);

                Microsoft.CodeAnalysis.MetadataReferenceProperties
                f_432_5115_5190(Microsoft.CodeAnalysis.MetadataImageKind
                kind, System.Collections.Immutable.ImmutableArray<string>
                aliases, bool
                embedInteropTypes, bool
                hasRecursiveAliases)
                {
                    var return_v = new Microsoft.CodeAnalysis.MetadataReferenceProperties(kind, aliases, embedInteropTypes, hasRecursiveAliases);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(432, 5115, 5190);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(432, 5014, 5202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(432, 5014, 5202);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public MetadataImageKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(432, 5365, 5373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 5368, 5373);
                    return _kind; DynAbs.Tracing.TraceSender.TraceExitMethod(432, 5365, 5373);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(432, 5365, 5373);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(432, 5365, 5373);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static string GlobalAlias
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(432, 5719, 5730);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 5722, 5730);
                    return "global"; DynAbs.Tracing.TraceSender.TraceExitMethod(432, 5719, 5730);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(432, 5719, 5730);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(432, 5719, 5730);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<string> Aliases
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(432, 6086, 6292);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 6247, 6277);

                    return _aliases.NullToEmpty();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(432, 6086, 6292);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(432, 6024, 6303);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(432, 6024, 6303);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool EmbedInteropTypes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(432, 6528, 6549);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 6531, 6549);
                    return _embedInteropTypes; DynAbs.Tracing.TraceSender.TraceExitMethod(432, 6528, 6549);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(432, 6528, 6549);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(432, 6528, 6549);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasRecursiveAliases { get; private set; }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(432, 6879, 7041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 6944, 7030);

                return obj is MetadataReferenceProperties && (DynAbs.Tracing.TraceSender.Expression_True(432, 6951, 7029) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(432, 6879, 7041);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(432, 6879, 7041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(432, 6879, 7041);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(MetadataReferenceProperties other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(432, 7053, 7363);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 7131, 7352);

                return Aliases.SequenceEqual(other.Aliases) && (DynAbs.Tracing.TraceSender.Expression_True(432, 7138, 7241) && _embedInteropTypes == other._embedInteropTypes
                ) && (DynAbs.Tracing.TraceSender.Expression_True(432, 7138, 7282) && _kind == other._kind
                ) && (DynAbs.Tracing.TraceSender.Expression_True(432, 7138, 7351) && HasRecursiveAliases == other.HasRecursiveAliases);
                DynAbs.Tracing.TraceSender.TraceExitMethod(432, 7053, 7363);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(432, 7053, 7363);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(432, 7053, 7363);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(432, 7375, 7583);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 7433, 7572);

                return f_432_7440_7571(f_432_7453_7480(Aliases), f_432_7482_7570(_embedInteropTypes, f_432_7515_7569(HasRecursiveAliases, f_432_7549_7568(_kind))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(432, 7375, 7583);

                int
                f_432_7453_7480(System.Collections.Immutable.ImmutableArray<string>
                values)
                {
                    var return_v = Hash.CombineValues(values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(432, 7453, 7480);
                    return return_v;
                }


                int
                f_432_7549_7568(Microsoft.CodeAnalysis.MetadataImageKind
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(432, 7549, 7568);
                    return return_v;
                }


                int
                f_432_7515_7569(bool
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(432, 7515, 7569);
                    return return_v;
                }


                int
                f_432_7482_7570(bool
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(432, 7482, 7570);
                    return return_v;
                }


                int
                f_432_7440_7571(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(432, 7440, 7571);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(432, 7375, 7583);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(432, 7375, 7583);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(MetadataReferenceProperties left, MetadataReferenceProperties right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(432, 7595, 7756);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 7719, 7745);

                return left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(432, 7595, 7756);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(432, 7595, 7756);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(432, 7595, 7756);
            }
        }

        public static bool operator !=(MetadataReferenceProperties left, MetadataReferenceProperties right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(432, 7768, 7930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(432, 7892, 7919);

                return !left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(432, 7768, 7930);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(432, 7768, 7930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(432, 7768, 7930);
            }
        }
        static MetadataReferenceProperties()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(432, 471, 7937);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(432, 471, 7937);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(432, 471, 7937);
        }

        static Microsoft.CodeAnalysis.MetadataReferenceProperties
        f_432_889_946(Microsoft.CodeAnalysis.MetadataImageKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.MetadataReferenceProperties(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(432, 889, 946);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReferenceProperties
        f_432_1119_1178(Microsoft.CodeAnalysis.MetadataImageKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.MetadataReferenceProperties(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(432, 1119, 1178);
            return return_v;
        }


        static bool
        f_432_1811_1825(Microsoft.CodeAnalysis.MetadataImageKind
        kind)
        {
            var return_v = kind.IsValid();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(432, 1811, 1825);
            return return_v;
        }


        static System.ArgumentOutOfRangeException
        f_432_1865_1910(string
        paramName)
        {
            var return_v = new System.ArgumentOutOfRangeException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(432, 1865, 1910);
            return return_v;
        }


        static string
        f_432_2103_2158()
        {
            var return_v = CodeAnalysisResources.CannotEmbedInteropTypesFromModule;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(432, 2103, 2158);
            return return_v;
        }


        static System.ArgumentException
        f_432_2081_2186(string
        message, string
        paramName)
        {
            var return_v = new System.ArgumentException(message, paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(432, 2081, 2186);
            return return_v;
        }


        static bool
        f_432_2230_2255_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(432, 2230, 2255);
            return return_v;
        }


        static string
        f_432_2325_2364()
        {
            var return_v = CodeAnalysisResources.CannotAliasModule;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(432, 2325, 2364);
            return return_v;
        }


        static System.ArgumentException
        f_432_2303_2382(string
        message, string
        paramName)
        {
            var return_v = new System.ArgumentException(message, paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(432, 2303, 2382);
            return return_v;
        }


        static bool
        f_432_2437_2462_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(432, 2437, 2462);
            return return_v;
        }


        static bool
        f_432_2572_2598(string
        name)
        {
            var return_v = name.IsValidClrTypeName();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(432, 2572, 2598);
            return return_v;
        }


        static string
        f_432_2676_2710()
        {
            var return_v = CodeAnalysisResources.InvalidAlias;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(432, 2676, 2710);
            return return_v;
        }


        static System.ArgumentException
        f_432_2654_2728(string
        message, string
        paramName)
        {
            var return_v = new System.ArgumentException(message, paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(432, 2654, 2728);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<string>
        f_432_2518_2525_I(System.Collections.Immutable.ImmutableArray<string>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(432, 2518, 2525);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataImageKind
        f_432_3129_3133_C(Microsoft.CodeAnalysis.MetadataImageKind
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(432, 2966, 3240);
            return return_v;
        }

    }
}
