// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.DiaSymReader;

namespace Roslyn.Test.Utilities
{
    internal class MockSymUnmanagedWriter : SymUnmanagedWriter
    {
        private Exception MakeException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24014, 479, 553);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24014, 482, 553);
                return f_24014_482_553("MockSymUnmanagedWriter error message"); DynAbs.Tracing.TraceSender.TraceExitMethod(24014, 479, 553);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24014, 479, 553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 479, 553);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int DocumentTableCapacity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24014, 614, 638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24014, 617, 638);
                    throw f_24014_623_638(this); DynAbs.Tracing.TraceSender.TraceExitMethod(24014, 614, 638);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24014, 566, 671);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 566, 671);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24014, 644, 668);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24014, 647, 668);
                    throw f_24014_653_668(this); DynAbs.Tracing.TraceSender.TraceExitMethod(24014, 644, 668);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24014, 566, 671);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 566, 671);
                }
            }
        }

        public override void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24014, 683, 775);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24014, 683, 775);
                // Dispose shall not throw
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24014, 683, 775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 683, 775);
            }
        }

        public override void CloseMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24014, 787, 879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24014, 846, 868);

                throw f_24014_852_867(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24014, 787, 879);

                System.Exception
                f_24014_852_867(Roslyn.Test.Utilities.MockSymUnmanagedWriter
                this_param)
                {
                    var return_v = this_param.MakeException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24014, 852, 867);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24014, 787, 879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 787, 879);
            }
        }

        public override void CloseScope(int endOffset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24014, 891, 995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24014, 962, 984);

                throw f_24014_968_983(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24014, 891, 995);

                System.Exception
                f_24014_968_983(Roslyn.Test.Utilities.MockSymUnmanagedWriter
                this_param)
                {
                    var return_v = this_param.MakeException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24014, 968, 983);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24014, 891, 995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 891, 995);
            }
        }

        public override void CloseTokensToSourceSpansMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24014, 1007, 1115);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24014, 1082, 1104);

                throw f_24014_1088_1103(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24014, 1007, 1115);

                System.Exception
                f_24014_1088_1103(Roslyn.Test.Utilities.MockSymUnmanagedWriter
                this_param)
                {
                    var return_v = this_param.MakeException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24014, 1088, 1103);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24014, 1007, 1115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 1007, 1115);
            }
        }

        public override void DefineCustomMetadata(byte[] metadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24014, 1127, 1243);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24014, 1210, 1232);

                throw f_24014_1216_1231(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24014, 1127, 1243);

                System.Exception
                f_24014_1216_1231(Roslyn.Test.Utilities.MockSymUnmanagedWriter
                this_param)
                {
                    var return_v = this_param.MakeException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24014, 1216, 1231);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24014, 1127, 1243);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 1127, 1243);
            }
        }

        public override int DefineDocument(string name, Guid language, Guid vendor, Guid type, Guid algorithmId, ReadOnlySpan<byte> checksum, ReadOnlySpan<byte> source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24014, 1255, 1473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24014, 1440, 1462);

                throw f_24014_1446_1461(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24014, 1255, 1473);

                System.Exception
                f_24014_1446_1461(Roslyn.Test.Utilities.MockSymUnmanagedWriter
                this_param)
                {
                    var return_v = this_param.MakeException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24014, 1446, 1461);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24014, 1255, 1473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 1255, 1473);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool DefineLocalConstant(string name, object value, int constantSignatureToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24014, 1485, 1638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24014, 1605, 1627);

                throw f_24014_1611_1626(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24014, 1485, 1638);

                System.Exception
                f_24014_1611_1626(Roslyn.Test.Utilities.MockSymUnmanagedWriter
                this_param)
                {
                    var return_v = this_param.MakeException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24014, 1611, 1626);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24014, 1485, 1638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 1485, 1638);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void DefineLocalVariable(int index, string name, int attributes, int localSignatureToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24014, 1650, 1813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24014, 1780, 1802);

                throw f_24014_1786_1801(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24014, 1650, 1813);

                System.Exception
                f_24014_1786_1801(Roslyn.Test.Utilities.MockSymUnmanagedWriter
                this_param)
                {
                    var return_v = this_param.MakeException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24014, 1786, 1801);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24014, 1650, 1813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 1650, 1813);
            }
        }

        public override void DefineSequencePoints(int documentIndex, int count, int[] offsets, int[] startLines, int[] startColumns, int[] endLines, int[] endColumns)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24014, 1825, 2041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24014, 2008, 2030);

                throw f_24014_2014_2029(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24014, 1825, 2041);

                System.Exception
                f_24014_2014_2029(Roslyn.Test.Utilities.MockSymUnmanagedWriter
                this_param)
                {
                    var return_v = this_param.MakeException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24014, 2014, 2029);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24014, 1825, 2041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 1825, 2041);
            }
        }

        public override void GetSignature(out Guid guid, out uint stamp, out int age)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24014, 2053, 2188);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24014, 2155, 2177);

                throw f_24014_2161_2176(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24014, 2053, 2188);

                System.Exception
                f_24014_2161_2176(Roslyn.Test.Utilities.MockSymUnmanagedWriter
                this_param)
                {
                    var return_v = this_param.MakeException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24014, 2161, 2176);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24014, 2053, 2188);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 2053, 2188);
            }
        }

        public override IEnumerable<ArraySegment<byte>> GetUnderlyingData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24014, 2200, 2325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24014, 2292, 2314);

                throw f_24014_2298_2313(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24014, 2200, 2325);

                System.Exception
                f_24014_2298_2313(Roslyn.Test.Utilities.MockSymUnmanagedWriter
                this_param)
                {
                    var return_v = this_param.MakeException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24014, 2298, 2313);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24014, 2200, 2325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 2200, 2325);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void MapTokenToSourceSpan(int token, int documentIndex, int startLine, int startColumn, int endLine, int endColumn)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24014, 2337, 2526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24014, 2493, 2515);

                throw f_24014_2499_2514(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24014, 2337, 2526);

                System.Exception
                f_24014_2499_2514(Roslyn.Test.Utilities.MockSymUnmanagedWriter
                this_param)
                {
                    var return_v = this_param.MakeException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24014, 2499, 2514);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24014, 2337, 2526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 2337, 2526);
            }
        }

        public override void OpenMethod(int methodToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24014, 2538, 2644);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24014, 2611, 2633);

                throw f_24014_2617_2632(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24014, 2538, 2644);

                System.Exception
                f_24014_2617_2632(Roslyn.Test.Utilities.MockSymUnmanagedWriter
                this_param)
                {
                    var return_v = this_param.MakeException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24014, 2617, 2632);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24014, 2538, 2644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 2538, 2644);
            }
        }

        public override void OpenScope(int startOffset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24014, 2656, 2761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24014, 2728, 2750);

                throw f_24014_2734_2749(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24014, 2656, 2761);

                System.Exception
                f_24014_2734_2749(Roslyn.Test.Utilities.MockSymUnmanagedWriter
                this_param)
                {
                    var return_v = this_param.MakeException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24014, 2734, 2749);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24014, 2656, 2761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 2656, 2761);
            }
        }

        public override void OpenTokensToSourceSpansMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24014, 2773, 2880);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24014, 2847, 2869);

                throw f_24014_2853_2868(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24014, 2773, 2880);

                System.Exception
                f_24014_2853_2868(Roslyn.Test.Utilities.MockSymUnmanagedWriter
                this_param)
                {
                    var return_v = this_param.MakeException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24014, 2853, 2868);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24014, 2773, 2880);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 2773, 2880);
            }
        }

        public override void SetAsyncInfo(int moveNextMethodToken, int kickoffMethodToken, int catchHandlerOffset, ReadOnlySpan<int> yieldOffsets, ReadOnlySpan<int> resumeOffsets)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24014, 2892, 3121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24014, 3088, 3110);

                throw f_24014_3094_3109(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24014, 2892, 3121);

                System.Exception
                f_24014_3094_3109(Roslyn.Test.Utilities.MockSymUnmanagedWriter
                this_param)
                {
                    var return_v = this_param.MakeException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24014, 3094, 3109);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24014, 2892, 3121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 2892, 3121);
            }
        }

        public override void SetEntryPoint(int entryMethodToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24014, 3133, 3247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24014, 3214, 3236);

                throw f_24014_3220_3235(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24014, 3133, 3247);

                System.Exception
                f_24014_3220_3235(Roslyn.Test.Utilities.MockSymUnmanagedWriter
                this_param)
                {
                    var return_v = this_param.MakeException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24014, 3220, 3235);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24014, 3133, 3247);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 3133, 3247);
            }
        }

        public override void SetSourceLinkData(byte[] data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24014, 3259, 3368);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24014, 3335, 3357);

                throw f_24014_3341_3356(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24014, 3259, 3368);

                System.Exception
                f_24014_3341_3356(Roslyn.Test.Utilities.MockSymUnmanagedWriter
                this_param)
                {
                    var return_v = this_param.MakeException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24014, 3341, 3356);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24014, 3259, 3368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 3259, 3368);
            }
        }

        public override void SetSourceServerData(byte[] data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24014, 3380, 3491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24014, 3458, 3480);

                throw f_24014_3464_3479(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24014, 3380, 3491);

                System.Exception
                f_24014_3464_3479(Roslyn.Test.Utilities.MockSymUnmanagedWriter
                this_param)
                {
                    var return_v = this_param.MakeException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24014, 3464, 3479);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24014, 3380, 3491);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 3380, 3491);
            }
        }

        public override void UpdateSignature(Guid guid, uint stamp, int age)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24014, 3503, 3629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24014, 3596, 3618);

                throw f_24014_3602_3617(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24014, 3503, 3629);

                System.Exception
                f_24014_3602_3617(Roslyn.Test.Utilities.MockSymUnmanagedWriter
                this_param)
                {
                    var return_v = this_param.MakeException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24014, 3602, 3617);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24014, 3503, 3629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 3503, 3629);
            }
        }

        public override void UsingNamespace(string importString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24014, 3641, 3755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24014, 3722, 3744);

                throw f_24014_3728_3743(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24014, 3641, 3755);

                System.Exception
                f_24014_3728_3743(Roslyn.Test.Utilities.MockSymUnmanagedWriter
                this_param)
                {
                    var return_v = this_param.MakeException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24014, 3728, 3743);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24014, 3641, 3755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 3641, 3755);
            }
        }

        public override void WriteTo(Stream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24014, 3767, 3868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24014, 3835, 3857);

                throw f_24014_3841_3856(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24014, 3767, 3868);

                System.Exception
                f_24014_3841_3856(Roslyn.Test.Utilities.MockSymUnmanagedWriter
                this_param)
                {
                    var return_v = this_param.MakeException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24014, 3841, 3856);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24014, 3767, 3868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 3767, 3868);
            }
        }

        public MockSymUnmanagedWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(24014, 370, 3875);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(24014, 370, 3875);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 370, 3875);
        }


        static MockSymUnmanagedWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24014, 370, 3875);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24014, 370, 3875);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24014, 370, 3875);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(24014, 370, 3875);

        Microsoft.DiaSymReader.SymUnmanagedWriterException
        f_24014_482_553(string
        message)
        {
            var return_v = new Microsoft.DiaSymReader.SymUnmanagedWriterException(message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24014, 482, 553);
            return return_v;
        }


        System.Exception
        f_24014_623_638(Roslyn.Test.Utilities.MockSymUnmanagedWriter
        this_param)
        {
            var return_v = this_param.MakeException();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24014, 623, 638);
            return return_v;
        }


        System.Exception
        f_24014_653_668(Roslyn.Test.Utilities.MockSymUnmanagedWriter
        this_param)
        {
            var return_v = this_param.MakeException();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24014, 653, 668);
            return return_v;
        }

    }
}
