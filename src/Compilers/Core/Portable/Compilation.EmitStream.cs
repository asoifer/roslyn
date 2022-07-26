// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection.PortableExecutable;
using Microsoft.CodeAnalysis.Interop;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public abstract partial class Compilation
    {        /// <summary>
             /// Describes the kind of real signing that is being done during Emit. In the case of public signing
             /// this value will be <see cref="None"/>.
             /// </summary>
        internal enum EmitStreamSignKind
        {
            None,

            /// <summary>
            /// This form of signing occurs in memory using the <see cref="PEBuilder"/> APIs. This is the default 
            /// form of signing and will be used when a strong name key is provided in a file on disk.
            /// </summary>
            SignedWithBuilder,

            /// <summary>
            /// This form of signing occurs using the <see cref="IClrStrongName"/> COM APIs. This form of signing
            /// requires the unsigned PE to be written to disk before it can be signed (typically by writing it
            /// out to the %TEMP% folder). This signing is used when the key in a key container, the signing 
            /// requires a counter signature or customers opted in via the UseLegacyStrongNameProvider feature 
            /// flag.
            /// </summary>
            SignedWithFile,
        }
        internal sealed class EmitStream
        {
            private readonly EmitStreamProvider _emitStreamProvider;

            private readonly EmitStreamSignKind _emitStreamSignKind;

            private readonly StrongNameProvider? _strongNameProvider;

            private (Stream tempStream, string tempFilePath)? _tempInfo;

            private Stream? _stream;

            internal EmitStream(
                            EmitStreamProvider emitStreamProvider,
                            EmitStreamSignKind emitStreamSignKind,
                            StrongNameProvider? strongNameProvider)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(6, 2864, 3439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 2123, 2142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 2193, 2212);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 2264, 2283);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 2348, 2357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 2840, 2847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 3086, 3133);

                    f_6_3086_3132(emitStreamProvider != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 3151, 3247);

                    f_6_3151_3246(strongNameProvider != null || (DynAbs.Tracing.TraceSender.Expression_False(6, 3170, 3245) || emitStreamSignKind == EmitStreamSignKind.None));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 3265, 3306);

                    _emitStreamProvider = emitStreamProvider;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 3324, 3365);

                    _emitStreamSignKind = emitStreamSignKind;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 3383, 3424);

                    _strongNameProvider = strongNameProvider;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(6, 2864, 3439);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(6, 2864, 3439);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(6, 2864, 3439);
                }
            }

            internal Func<Stream?> GetCreateStreamFunc(DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(6, 3455, 3611);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 3557, 3596);

                    return () => CreateStream(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(6, 3455, 3611);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(6, 3455, 3611);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(6, 3455, 3611);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal void Close()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(6, 3627, 4573);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 3829, 3844);

                    _stream = null;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 3864, 4558) || true) && (_tempInfo.HasValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(6, 3864, 4558);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 3928, 3991);

                        var (tempStream, tempFilePath) = _tempInfo.GetValueOrDefault();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 4013, 4030);

                        _tempInfo = null;

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 4106, 4127);

                            f_6_4106_4126(tempStream);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(6, 4172, 4539);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 4288, 4314);

                                f_6_4288_4313(tempFilePath);
                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(6, 4367, 4516);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(6, 4367, 4516);
                                // Not much to do if we can't delete from the temp directory
                            }
                            DynAbs.Tracing.TraceSender.TraceExitFinally(6, 4172, 4539);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(6, 3864, 4558);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(6, 3627, 4573);

                    int
                    f_6_4106_4126(System.IO.Stream
                    this_param)
                    {
                        this_param.Dispose();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 4106, 4126);
                        return 0;
                    }


                    int
                    f_6_4288_4313(string
                    path)
                    {
                        File.Delete(path);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 4288, 4313);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(6, 3627, 4573);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(6, 3627, 4573);
                }
            }

            private Stream? CreateStream(DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(6, 4747, 6857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 4835, 4871);

                    f_6_4835_4870(_stream == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 4889, 4929);

                    f_6_4889_4928(diagnostics != null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 4949, 5052) || true) && (f_6_4953_4979(diagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(6, 4949, 5052);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 5021, 5033);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(6, 4949, 5052);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 5072, 5133);

                    _stream = f_6_5082_5132(_emitStreamProvider, diagnostics);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 5151, 5243) || true) && (_stream == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(6, 5151, 5243);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 5212, 5224);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(6, 5151, 5243);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 5654, 6842) || true) && (_emitStreamSignKind == EmitStreamSignKind.SignedWithFile)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(6, 5654, 6842);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 5756, 5804);

                        f_6_5756_5803(_strongNameProvider != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 5828, 5846);

                        Stream
                        tempStream
                        = default(Stream);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 5868, 5888);

                        string
                        tempFilePath
                        = default(string);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 5962, 6010);

                            var
                            fileSystem = f_6_5979_6009(_strongNameProvider)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 6036, 6179);

                            Func<string, Stream>
                            streamConstructor = path => fileSystem.CreateFileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 6207, 6246);

                            var
                            tempDir = f_6_6221_6245(fileSystem)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 6272, 6339);

                            tempFilePath = f_6_6287_6338(tempDir, Guid.NewGuid().ToString("N"));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 6365, 6449);

                            tempStream = f_6_6378_6448(streamConstructor, tempFilePath);
                        }
                        catch (IOException e)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(6, 6494, 6623);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 6564, 6600);

                            throw f_6_6570_6599(e);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(6, 6494, 6623);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 6647, 6686);

                        _tempInfo = (tempStream, tempFilePath);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 6708, 6726);

                        return tempStream;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(6, 5654, 6842);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(6, 5654, 6842);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 6808, 6823);

                        return _stream;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(6, 5654, 6842);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(6, 4747, 6857);

                    int
                    f_6_4835_4870(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 4835, 4870);
                        return 0;
                    }


                    int
                    f_6_4889_4928(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 4889, 4928);
                        return 0;
                    }


                    bool
                    f_6_4953_4979(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param)
                    {
                        var return_v = this_param.HasAnyErrors();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 4953, 4979);
                        return return_v;
                    }


                    System.IO.Stream?
                    f_6_5082_5132(Microsoft.CodeAnalysis.Compilation.EmitStreamProvider
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.GetOrCreateStream(diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 5082, 5132);
                        return return_v;
                    }


                    int
                    f_6_5756_5803(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 5756, 5803);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.StrongNameFileSystem
                    f_6_5979_6009(Microsoft.CodeAnalysis.StrongNameProvider
                    this_param)
                    {
                        var return_v = this_param.FileSystem;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(6, 5979, 6009);
                        return return_v;
                    }


                    string
                    f_6_6221_6245(Microsoft.CodeAnalysis.StrongNameFileSystem
                    this_param)
                    {
                        var return_v = this_param.GetTempPath();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 6221, 6245);
                        return return_v;
                    }


                    string
                    f_6_6287_6338(string
                    path1, string
                    path2)
                    {
                        var return_v = Path.Combine(path1, path2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 6287, 6338);
                        return return_v;
                    }


                    System.IO.Stream
                    f_6_6378_6448(System.Func<string, System.IO.Stream>
                    factory, string
                    path)
                    {
                        var return_v = FileUtilities.CreateFileStreamChecked(factory, path);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 6378, 6448);
                        return return_v;
                    }


                    Microsoft.Cci.PeWritingException
                    f_6_6570_6599(System.IO.IOException
                    inner)
                    {
                        var return_v = new Microsoft.Cci.PeWritingException((System.Exception)inner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 6570, 6599);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(6, 4747, 6857);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(6, 4747, 6857);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal bool Complete(StrongNameKeys strongNameKeys, CommonMessageProvider messageProvider, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(6, 6873, 9112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 7025, 7061);

                    f_6_7025_7060(_stream != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 7079, 7178);

                    f_6_7079_7177(_emitStreamSignKind != EmitStreamSignKind.SignedWithFile || (DynAbs.Tracing.TraceSender.Expression_False(6, 7098, 7176) || _tempInfo.HasValue));

                    try
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 7242, 8953) || true) && (_tempInfo.HasValue)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(6, 7242, 8953);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 7314, 7391);

                            f_6_7314_7390(_emitStreamSignKind == EmitStreamSignKind.SignedWithFile);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 7417, 7467);

                            f_6_7417_7466(_strongNameProvider is object);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 7493, 7556);

                            var (tempStream, tempFilePath) = _tempInfo.GetValueOrDefault();

                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 7784, 7805);

                                f_6_7784_7804(                            // Dispose the temp stream to ensure all of the contents are written to 
                                                                          // disk.
                                                            tempStream);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 7837, 7896);

                                f_6_7837_7895(
                                                            _strongNameProvider, strongNameKeys, tempFilePath);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 7928, 8127);
                                using (var
                                tempFileStream = f_6_7956_7999(tempFilePath, FileMode.Open)
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 8065, 8096);

                                    f_6_8065_8095(tempFileStream, _stream);
                                    DynAbs.Tracing.TraceSender.TraceExitUsing(6, 7928, 8127);
                                }
                            }
                            catch (DesktopStrongNameProvider.ClrStrongNameMissingException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(6, 8180, 8628);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 8300, 8558);

                                f_6_8300_8557(diagnostics, f_6_8316_8556(strongNameKeys.KeyFilePath, strongNameKeys.KeyContainer, f_6_8430_8538(nameof(CodeAnalysisResources.AssemblySigningNotSupported)), messageProvider));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 8588, 8601);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(6, 8180, 8628);
                            }
                            catch (IOException ex)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(6, 8654, 8930);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 8733, 8860);

                                f_6_8733_8859(diagnostics, f_6_8749_8858(strongNameKeys.KeyFilePath, strongNameKeys.KeyContainer, f_6_8830_8840(ex), messageProvider));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 8890, 8903);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(6, 8654, 8930);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(6, 7242, 8953);
                        }
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(6, 8990, 9065);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 9038, 9046);

                        f_6_9038_9045(this);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(6, 8990, 9065);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(6, 9085, 9097);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(6, 6873, 9112);

                    int
                    f_6_7025_7060(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 7025, 7060);
                        return 0;
                    }


                    int
                    f_6_7079_7177(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 7079, 7177);
                        return 0;
                    }


                    int
                    f_6_7314_7390(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 7314, 7390);
                        return 0;
                    }


                    int
                    f_6_7417_7466(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 7417, 7466);
                        return 0;
                    }


                    int
                    f_6_7784_7804(System.IO.Stream
                    this_param)
                    {
                        this_param.Dispose();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 7784, 7804);
                        return 0;
                    }


                    int
                    f_6_7837_7895(Microsoft.CodeAnalysis.StrongNameProvider
                    this_param, Microsoft.CodeAnalysis.StrongNameKeys
                    keys, string
                    filePath)
                    {
                        this_param.SignFile(keys, filePath);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 7837, 7895);
                        return 0;
                    }


                    System.IO.FileStream
                    f_6_7956_7999(string
                    path, System.IO.FileMode
                    mode)
                    {
                        var return_v = new System.IO.FileStream(path, mode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 7956, 7999);
                        return return_v;
                    }


                    int
                    f_6_8065_8095(System.IO.FileStream
                    this_param, System.IO.Stream
                    destination)
                    {
                        this_param.CopyTo(destination);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 8065, 8095);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CodeAnalysisResourcesLocalizableErrorArgument
                    f_6_8430_8538(string
                    targetResourceId)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CodeAnalysisResourcesLocalizableErrorArgument(targetResourceId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 8430, 8538);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostic
                    f_6_8316_8556(string?
                    keyFilePath, string?
                    keyContainerName, Microsoft.CodeAnalysis.CodeAnalysisResourcesLocalizableErrorArgument
                    message, Microsoft.CodeAnalysis.CommonMessageProvider
                    messageProvider)
                    {
                        var return_v = StrongNameKeys.GetError(keyFilePath, keyContainerName, (object)message, messageProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 8316, 8556);
                        return return_v;
                    }


                    int
                    f_6_8300_8557(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param, Microsoft.CodeAnalysis.Diagnostic
                    diag)
                    {
                        this_param.Add(diag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 8300, 8557);
                        return 0;
                    }


                    string
                    f_6_8830_8840(System.IO.IOException
                    this_param)
                    {
                        var return_v = this_param.Message;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(6, 8830, 8840);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostic
                    f_6_8749_8858(string?
                    keyFilePath, string?
                    keyContainerName, string
                    message, Microsoft.CodeAnalysis.CommonMessageProvider
                    messageProvider)
                    {
                        var return_v = StrongNameKeys.GetError(keyFilePath, keyContainerName, (object)message, messageProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 8749, 8858);
                        return return_v;
                    }


                    int
                    f_6_8733_8859(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param, Microsoft.CodeAnalysis.Diagnostic
                    diag)
                    {
                        this_param.Add(diag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 8733, 8859);
                        return 0;
                    }


                    int
                    f_6_9038_9045(Microsoft.CodeAnalysis.Compilation.EmitStream
                    this_param)
                    {
                        this_param.Close();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 9038, 9045);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(6, 6873, 9112);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(6, 6873, 9112);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static EmitStream()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(6, 2030, 9123);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(6, 2030, 9123);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(6, 2030, 9123);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(6, 2030, 9123);

            static int
            f_6_3086_3132(bool
            b)
            {
                RoslynDebug.Assert(b);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 3086, 3132);
                return 0;
            }


            static int
            f_6_3151_3246(bool
            b)
            {
                RoslynDebug.Assert(b);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(6, 3151, 3246);
                return 0;
            }

        }

        static Compilation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(6, 420, 9130);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 12002, 12037);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 15431, 15468);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 15497, 15534);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 65639, 65689);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(145, 136230, 136287);
            s_createSetCallback = t => new Microsoft.CodeAnalysis.Collections.SmallConcurrentSetOfInts(); 
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(6, 420, 9130);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(6, 420, 9130);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(6, 420, 9130);
    }
}
