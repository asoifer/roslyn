// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.IO;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    public sealed class DisposableDirectory : TempDirectory, IDisposable
    {
        public DisposableDirectory(TempRoot root)
        : base(f_25026_467_471_C(root))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25026, 405, 494);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25026, 405, 494);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25026, 405, 494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25026, 405, 494);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25026, 506, 818);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25026, 552, 807) || true) && (f_25026_556_560() != null && (DynAbs.Tracing.TraceSender.Expression_True(25026, 556, 594) && f_25026_572_594(f_25026_589_593())))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25026, 552, 807);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25026, 672, 712);

                        f_25026_672_711(f_25026_689_693(), recursive: true);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(25026, 749, 792);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(25026, 749, 792);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25026, 552, 807);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25026, 506, 818);

                string
                f_25026_556_560()
                {
                    var return_v = Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25026, 556, 560);
                    return return_v;
                }


                string
                f_25026_589_593()
                {
                    var return_v = Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25026, 589, 593);
                    return return_v;
                }


                bool
                f_25026_572_594(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25026, 572, 594);
                    return return_v;
                }


                string
                f_25026_689_693()
                {
                    var return_v = Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25026, 689, 693);
                    return return_v;
                }


                int
                f_25026_672_711(string
                path, bool
                recursive)
                {
                    Directory.Delete(path, recursive: recursive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25026, 672, 711);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25026, 506, 818);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25026, 506, 818);
            }
        }

        static DisposableDirectory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25026, 320, 825);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25026, 320, 825);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25026, 320, 825);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25026, 320, 825);

        static Microsoft.CodeAnalysis.Test.Utilities.TempRoot
        f_25026_467_471_C(Microsoft.CodeAnalysis.Test.Utilities.TempRoot
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(25026, 405, 494);
            return return_v;
        }

    }
}
