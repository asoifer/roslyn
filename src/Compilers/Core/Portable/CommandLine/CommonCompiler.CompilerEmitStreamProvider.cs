// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.IO;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal abstract partial class CommonCompiler
    {
        private sealed class CompilerEmitStreamProvider : Compilation.EmitStreamProvider
        {
            private readonly CommonCompiler _compiler;

            private readonly string _filePath;

            private Stream? _streamToDispose;

            internal CompilerEmitStreamProvider(
                            CommonCompiler compiler,
                            string filePath)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(126, 1115, 1335);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 994, 1003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 1042, 1051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 1082, 1098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 1260, 1281);

                    _compiler = compiler;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 1299, 1320);

                    _filePath = filePath;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(126, 1115, 1335);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(126, 1115, 1335);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(126, 1115, 1335);
                }
            }

            public void Close(DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(126, 1351, 1907);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 1472, 1500);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_streamToDispose, 126, 1472, 1499)?.Dispose(), 126, 1489, 1499);
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(126, 1537, 1892);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 1597, 1645);

                        var
                        messageProvider = f_126_1619_1644(_compiler)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 1667, 1785);

                        var
                        diagnosticInfo = f_126_1688_1784(messageProvider, f_126_1724_1761(messageProvider), _filePath, f_126_1774_1783(e))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 1807, 1873);

                        f_126_1807_1872(diagnostics, f_126_1823_1871(messageProvider, diagnosticInfo));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(126, 1537, 1892);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(126, 1351, 1907);

                    Microsoft.CodeAnalysis.CommonMessageProvider
                    f_126_1619_1644(Microsoft.CodeAnalysis.CommonCompiler
                    this_param)
                    {
                        var return_v = this_param.MessageProvider;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(126, 1619, 1644);
                        return return_v;
                    }


                    int
                    f_126_1724_1761(Microsoft.CodeAnalysis.CommonMessageProvider
                    this_param)
                    {
                        var return_v = this_param.ERR_OutputWriteFailed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(126, 1724, 1761);
                        return return_v;
                    }


                    string
                    f_126_1774_1783(System.Exception
                    this_param)
                    {
                        var return_v = this_param.Message;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(126, 1774, 1783);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticInfo
                    f_126_1688_1784(Microsoft.CodeAnalysis.CommonMessageProvider
                    messageProvider, int
                    errorCode, params object[]
                    arguments)
                    {
                        var return_v = new Microsoft.CodeAnalysis.DiagnosticInfo(messageProvider, errorCode, arguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 1688, 1784);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostic
                    f_126_1823_1871(Microsoft.CodeAnalysis.CommonMessageProvider
                    this_param, Microsoft.CodeAnalysis.DiagnosticInfo
                    info)
                    {
                        var return_v = this_param.CreateDiagnostic(info);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 1823, 1871);
                        return return_v;
                    }


                    int
                    f_126_1807_1872(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param, Microsoft.CodeAnalysis.Diagnostic
                    diag)
                    {
                        this_param.Add(diag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 1807, 1872);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(126, 1351, 1907);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(126, 1351, 1907);
                }
            }

            public override Stream? Stream
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(126, 1954, 1961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 1957, 1961);
                        return null; DynAbs.Tracing.TraceSender.TraceExitMethod(126, 1954, 1961);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(126, 1954, 1961);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(126, 1954, 1961);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            protected override Stream? CreateStream(DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(126, 1978, 5027);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 2077, 2116);

                    f_126_2077_2115(_streamToDispose == null);

                    try
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 2232, 2256);

                            return f_126_2239_2255(this);
                        }
                        catch (IOException e)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(126, 2301, 4821);
                            // Other process is reading the file preventing us to write to it.
                            // We attempt to rename and delete the file in case the reader opened it with FileShare.Delete flag that
                            // allows the file to be deleted by other processes.
                            //
                            // Note that if the file is marked "readonly" or the current user doesn't have sufficient privileges
                            // the exception thrown is UnauthorizedAccessException, not IOException, so we won't attempt to delete the file.

                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 3025, 3087);

                                const int
                                eWin32SharingViolation = unchecked((int)0x80070020)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 3119, 4459) || true) && (f_126_3123_3155())
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 3119, 4459);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 3416, 3439);

                                    f_126_3416_3438(_filePath);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(126, 3119, 4459);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 3119, 4459);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 3505, 4459) || true) && (f_126_3509_3518(e) == eWin32SharingViolation)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 3505, 4459);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 3745, 3874);

                                        var
                                        newFilePath = f_126_3763_3873(f_126_3776_3808(_filePath)!, Guid.NewGuid().ToString() + "_" + f_126_3845_3872(_filePath))
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 4037, 4071);

                                        f_126_4037_4070(_filePath, newFilePath);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 4166, 4221);

                                        f_126_4166_4220(newFilePath, FileAttributes.Hidden);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 4403, 4428);

                                        f_126_4403_4427(newFilePath);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(126, 3505, 4459);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(126, 3119, 4459);
                                }
                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(126, 4512, 4746);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 4636, 4677);

                                f_126_4636_4676(this, diagnostics, e);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 4707, 4719);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(126, 4512, 4746);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 4774, 4798);

                            return f_126_4781_4797(this);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(126, 2301, 4821);
                        }
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(126, 4858, 5012);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 4918, 4959);

                        f_126_4918_4958(this, diagnostics, e);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 4981, 4993);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(126, 4858, 5012);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(126, 1978, 5027);

                    int
                    f_126_2077_2115(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 2077, 2115);
                        return 0;
                    }


                    System.IO.Stream
                    f_126_2239_2255(Microsoft.CodeAnalysis.CommonCompiler.CompilerEmitStreamProvider
                    this_param)
                    {
                        var return_v = this_param.OpenFileStream();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 2239, 2255);
                        return return_v;
                    }


                    bool
                    f_126_3123_3155()
                    {
                        var return_v = PathUtilities.IsUnixLikePlatform;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(126, 3123, 3155);
                        return return_v;
                    }


                    int
                    f_126_3416_3438(string
                    path)
                    {
                        File.Delete(path);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 3416, 3438);
                        return 0;
                    }


                    int
                    f_126_3509_3518(System.IO.IOException
                    this_param)
                    {
                        var return_v = this_param.HResult;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(126, 3509, 3518);
                        return return_v;
                    }


                    string?
                    f_126_3776_3808(string
                    path)
                    {
                        var return_v = Path.GetDirectoryName(path);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 3776, 3808);
                        return return_v;
                    }


                    string?
                    f_126_3845_3872(string
                    path)
                    {
                        var return_v = Path.GetFileName(path);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 3845, 3872);
                        return return_v;
                    }


                    string
                    f_126_3763_3873(string
                    path1, string
                    path2)
                    {
                        var return_v = Path.Combine(path1, path2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 3763, 3873);
                        return return_v;
                    }


                    int
                    f_126_4037_4070(string
                    sourceFileName, string
                    destFileName)
                    {
                        File.Move(sourceFileName, destFileName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 4037, 4070);
                        return 0;
                    }


                    int
                    f_126_4166_4220(string
                    path, System.IO.FileAttributes
                    fileAttributes)
                    {
                        File.SetAttributes(path, fileAttributes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 4166, 4220);
                        return 0;
                    }


                    int
                    f_126_4403_4427(string
                    path)
                    {
                        File.Delete(path);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 4403, 4427);
                        return 0;
                    }


                    int
                    f_126_4636_4676(Microsoft.CodeAnalysis.CommonCompiler.CompilerEmitStreamProvider
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, System.IO.IOException
                    e)
                    {
                        this_param.ReportOpenFileDiagnostic(diagnostics, (System.Exception)e);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 4636, 4676);
                        return 0;
                    }


                    System.IO.Stream
                    f_126_4781_4797(Microsoft.CodeAnalysis.CommonCompiler.CompilerEmitStreamProvider
                    this_param)
                    {
                        var return_v = this_param.OpenFileStream();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 4781, 4797);
                        return return_v;
                    }


                    int
                    f_126_4918_4958(Microsoft.CodeAnalysis.CommonCompiler.CompilerEmitStreamProvider
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, System.Exception
                    e)
                    {
                        this_param.ReportOpenFileDiagnostic(diagnostics, e);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 4918, 4958);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(126, 1978, 5027);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(126, 1978, 5027);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private Stream OpenFileStream()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(126, 5043, 5233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 5107, 5218);

                    return _streamToDispose = f_126_5133_5217(_compiler, _filePath, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(126, 5043, 5233);

                    System.IO.Stream
                    f_126_5133_5217(Microsoft.CodeAnalysis.CommonCompiler
                    this_param, string
                    arg1, System.IO.FileMode
                    arg2, System.IO.FileAccess
                    arg3, System.IO.FileShare
                    arg4)
                    {
                        var return_v = this_param.FileOpen(arg1, arg2, arg3, arg4);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 5133, 5217);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(126, 5043, 5233);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(126, 5043, 5233);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void ReportOpenFileDiagnostic(DiagnosticBag diagnostics, Exception e)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(126, 5249, 5566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 5359, 5407);

                    var
                    messageProvider = f_126_5381_5406(_compiler)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 5425, 5551);

                    f_126_5425_5550(diagnostics, f_126_5441_5549(messageProvider, f_126_5474_5511(messageProvider), f_126_5513_5526(), _filePath, f_126_5539_5548(e)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(126, 5249, 5566);

                    Microsoft.CodeAnalysis.CommonMessageProvider
                    f_126_5381_5406(Microsoft.CodeAnalysis.CommonCompiler
                    this_param)
                    {
                        var return_v = this_param.MessageProvider;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(126, 5381, 5406);
                        return return_v;
                    }


                    int
                    f_126_5474_5511(Microsoft.CodeAnalysis.CommonMessageProvider
                    this_param)
                    {
                        var return_v = this_param.ERR_CantOpenFileWrite;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(126, 5474, 5511);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_126_5513_5526()
                    {
                        var return_v = Location.None;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(126, 5513, 5526);
                        return return_v;
                    }


                    string
                    f_126_5539_5548(System.Exception
                    this_param)
                    {
                        var return_v = this_param.Message;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(126, 5539, 5548);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostic
                    f_126_5441_5549(Microsoft.CodeAnalysis.CommonMessageProvider
                    this_param, int
                    code, Microsoft.CodeAnalysis.Location
                    location, params object[]
                    args)
                    {
                        var return_v = this_param.CreateDiagnostic(code, location, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 5441, 5549);
                        return return_v;
                    }


                    int
                    f_126_5425_5550(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param, Microsoft.CodeAnalysis.Diagnostic
                    diag)
                    {
                        this_param.Add(diag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 5425, 5550);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(126, 5249, 5566);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(126, 5249, 5566);
                }
            }

            static CompilerEmitStreamProvider()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(126, 857, 5577);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(126, 857, 5577);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(126, 857, 5577);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(126, 857, 5577);
        }

        static CommonCompiler()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(126, 336, 5584);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 2178, 2188);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 2218, 2231);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(126, 336, 5584);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(126, 336, 5584);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(126, 336, 5584);
    }
}
