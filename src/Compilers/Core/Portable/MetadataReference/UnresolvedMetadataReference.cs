// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis
{
    public sealed class UnresolvedMetadataReference : MetadataReference
    {
        public string Reference { get; }

        internal UnresolvedMetadataReference(string reference, MetadataReferenceProperties properties)
        : base(f_437_728_738_C(properties))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(437, 613, 802);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(437, 569, 601);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(437, 764, 791);

                this.Reference = reference;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(437, 613, 802);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(437, 613, 802);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(437, 613, 802);
            }
        }

        public override string Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(437, 869, 972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(437, 905, 957);

                    return f_437_912_944() + f_437_947_956();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(437, 869, 972);

                    string
                    f_437_912_944()
                    {
                        var return_v = CodeAnalysisResources.Unresolved;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(437, 912, 944);
                        return return_v;
                    }


                    string
                    f_437_947_956()
                    {
                        var return_v = Reference;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(437, 947, 956);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(437, 814, 983);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(437, 814, 983);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsUnresolved
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(437, 1055, 1075);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(437, 1061, 1073);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(437, 1055, 1075);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(437, 995, 1086);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(437, 995, 1086);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override MetadataReference WithPropertiesImplReturningMetadataReference(MetadataReferenceProperties properties)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(437, 1098, 1321);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(437, 1243, 1310);

                return f_437_1250_1309(f_437_1282_1296(this), properties);
                DynAbs.Tracing.TraceSender.TraceExitMethod(437, 1098, 1321);

                string
                f_437_1282_1296(Microsoft.CodeAnalysis.UnresolvedMetadataReference
                this_param)
                {
                    var return_v = this_param.Reference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(437, 1282, 1296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnresolvedMetadataReference
                f_437_1250_1309(string
                reference, Microsoft.CodeAnalysis.MetadataReferenceProperties
                properties)
                {
                    var return_v = new Microsoft.CodeAnalysis.UnresolvedMetadataReference(reference, properties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(437, 1250, 1309);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(437, 1098, 1321);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(437, 1098, 1321);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static UnresolvedMetadataReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(437, 485, 1328);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(437, 485, 1328);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(437, 485, 1328);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(437, 485, 1328);

        static Microsoft.CodeAnalysis.MetadataReferenceProperties
        f_437_728_738_C(Microsoft.CodeAnalysis.MetadataReferenceProperties
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(437, 613, 802);
            return return_v;
        }

    }
}
