// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis
{
    internal partial class CommonReferenceManager<TCompilation, TAssemblySymbol>
    {
        [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
        internal abstract class AssemblyData
        {
            public abstract AssemblyIdentity Identity { get; }

            public abstract ImmutableArray<AssemblyIdentity> AssemblyReferences { get; }

            public abstract IEnumerable<TAssemblySymbol> AvailableSymbols { get; }

            public abstract bool IsMatchingAssembly(TAssemblySymbol? assembly);

            public abstract AssemblyReferenceBinding[] BindAssemblyReferences(ImmutableArray<AssemblyData> assemblies, AssemblyIdentityComparer assemblyIdentityComparer);

            public abstract bool ContainsNoPiaLocalTypes { get; }

            public abstract bool IsLinked { get; }

            public abstract bool DeclaresTheObjectClass { get; }

            public abstract Compilation? SourceCompilation { get; }

            private string GetDebuggerDisplay()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(524, 3328, 3381);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(524, 3331, 3381);
                    return $"{f_524_3334_3348(f_524_3334_3343(this))}: [{f_524_3353_3378(f_524_3353_3361())}]"; DynAbs.Tracing.TraceSender.TraceExitMethod(524, 3328, 3381);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(524, 3328, 3381);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(524, 3328, 3381);
                }
                throw new System.Exception("Slicer error: unreachable code");

                System.Type
                f_524_3334_3343(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(524, 3334, 3343);
                    return return_v;
                }


                string
                f_524_3334_3348(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(524, 3334, 3348);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_524_3353_3361()
                {
                    var return_v = Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(524, 3353, 3361);
                    return return_v;
                }


                string
                f_524_3353_3378(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.GetDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(524, 3353, 3378);
                    return return_v;
                }

            }

            public AssemblyData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(524, 573, 3393);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(524, 573, 3393);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(524, 573, 3393);
            }


            static AssemblyData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(524, 573, 3393);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(524, 573, 3393);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(524, 573, 3393);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(524, 573, 3393);
        }

        static CommonReferenceManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(524, 350, 3400);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 19449, 19506);
            // LAFHIS
            s_supersededAlias = f_531_19469_19506("<superseded>");
            
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(524, 350, 3400);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(524, 350, 3400);
        }

        // LAFHIS
        static ImmutableArray<string> f_531_19469_19506(string s)
        {
            var temp = ImmutableArray.Create(s);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 19469, 19506);
            return temp;
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(524, 350, 3400);
    }
}
