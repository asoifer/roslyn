// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Microsoft.DiaSymReader
{
    internal sealed class SymUnmanagedWriterImpl : SymUnmanagedWriter
    {
        private static readonly object s_zeroInt32;

        private ISymUnmanagedWriter5 _symWriter;

        private readonly ComMemoryStream _pdbStream;

        private readonly List<ISymUnmanagedDocumentWriter> _documentWriters;

        private readonly string _symWriterModuleName;

        private bool _disposed;

        internal SymUnmanagedWriterImpl(ComMemoryStream pdbStream, ISymUnmanagedWriter5 symWriter, string symWriterModuleName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(755, 864, 1358);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 621, 631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 675, 685);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 747, 763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 798, 818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 842, 851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 1007, 1039);

                f_755_1007_1038(pdbStream != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 1053, 1085);

                f_755_1053_1084(symWriter != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 1099, 1141);

                f_755_1099_1140(symWriterModuleName != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 1157, 1180);

                _pdbStream = pdbStream;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 1194, 1217);

                _symWriter = symWriter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 1231, 1290);

                _documentWriters = f_755_1250_1289();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 1304, 1347);

                _symWriterModuleName = symWriterModuleName;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(755, 864, 1358);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 864, 1358);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 864, 1358);
            }
        }

        private ISymUnmanagedWriter5 GetSymWriter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 1427, 1557);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 1430, 1557);
                return _symWriter ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.DiaSymReader.ISymUnmanagedWriter5>(755, 1430, 1557) ?? throw ((DynAbs.Tracing.TraceSender.Conditional_F1(755, 1451, 1460) || ((_disposed && DynAbs.Tracing.TraceSender.Conditional_F2(755, 1463, 1522)) || DynAbs.Tracing.TraceSender.Conditional_F3(755, 1525, 1556))) ? f_755_1463_1522(nameof(SymUnmanagedWriterImpl)) : f_755_1525_1556())); DynAbs.Tracing.TraceSender.TraceExitMethod(755, 1427, 1557);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 1427, 1557);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 1427, 1557);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.ObjectDisposedException
            f_755_1463_1522(string
            objectName)
            {
                var return_v = new System.ObjectDisposedException(objectName);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 1463, 1522);
                return return_v;
            }


            System.InvalidOperationException
            f_755_1525_1556()
            {
                var return_v = new System.InvalidOperationException();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 1525, 1556);
                return return_v;
            }

        }

        private ISymUnmanagedWriter8 GetSymWriter8()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 1628, 1750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 1631, 1750);

                // LAFHIS
                DynAbs.Tracing.TraceSender.Conditional_F1(755, 1631, 1680);
                var temp = f_755_1631_1645(this);
                return ((temp is ISymUnmanagedWriter8 && 
                    DynAbs.Tracing.TraceSender.Conditional_F2(755, 1683, 1693)) || 
                    DynAbs.Tracing.TraceSender.Conditional_F3(755, 1696, 1750)) ? (ISymUnmanagedWriter8)temp : 
                    throw f_755_1702_1750(this, f_755_1722_1749()); 
                
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 1628, 1750);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 1628, 1750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 1628, 1750);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.DiaSymReader.ISymUnmanagedWriter5
            f_755_1631_1645(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
            this_param)
            {
                var return_v = this_param.GetSymWriter();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 1631, 1645);
                return return_v;
            }


            System.NotSupportedException
            f_755_1722_1749()
            {
                var return_v = new System.NotSupportedException();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 1722, 1749);
                return return_v;
            }


            System.Exception
            f_755_1702_1750(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
            this_param, System.NotSupportedException
            inner)
            {
                var return_v = this_param.PdbWritingException((System.Exception)inner);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 1702, 1750);
                return return_v;
            }

        }

        private Exception PdbWritingException(Exception inner)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 1831, 1894);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 1834, 1894);
                return f_755_1834_1894(inner, _symWriterModuleName); DynAbs.Tracing.TraceSender.TraceExitMethod(755, 1831, 1894);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 1831, 1894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 1831, 1894);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.DiaSymReader.SymUnmanagedWriterException
            f_755_1834_1894(System.Exception
            innerException, string
            implementationModuleName)
            {
                var return_v = new Microsoft.DiaSymReader.SymUnmanagedWriterException(innerException, implementationModuleName);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 1834, 1894);
                return return_v;
            }

        }

        public override void WriteTo(Stream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 2069, 2653);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 2137, 2252) || true) && (stream == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 2137, 2252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 2189, 2237);

                    throw f_755_2195_2236(nameof(stream));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 2137, 2252);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 2412, 2429);

                f_755_2412_2428(this);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 2481, 2507);

                    f_755_2481_2506(_pdbStream, stream);
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 2536, 2642);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 2589, 2619);

                    throw f_755_2595_2618(this, ex);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(755, 2536, 2642);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 2069, 2653);

                System.ArgumentNullException
                f_755_2195_2236(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 2195, 2236);
                    return return_v;
                }


                int
                f_755_2412_2428(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param)
                {
                    this_param.CloseSymWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 2412, 2428);
                    return 0;
                }


                int
                f_755_2481_2506(Microsoft.DiaSymReader.ComMemoryStream
                this_param, System.IO.Stream
                stream)
                {
                    this_param.CopyTo(stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 2481, 2506);
                    return 0;
                }


                System.Exception
                f_755_2595_2618(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 2595, 2618);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 2069, 2653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 2069, 2653);
            }
        }

        public override void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 2665, 2785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 2720, 2734);

                f_755_2720_2733(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 2748, 2774);

                f_755_2748_2773(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 2665, 2785);

                int
                f_755_2720_2733(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param)
                {
                    this_param.DisposeImpl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 2720, 2733);
                    return 0;
                }


                int
                f_755_2748_2773(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 2748, 2773);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 2665, 2785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 2665, 2785);
            }
        }

        ~SymUnmanagedWriterImpl()
        {
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 2847, 2861);

            f_755_2847_2860(this);
        }

        private void DisposeImpl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 2884, 3140);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 2971, 2988);

                    f_755_2971_2987(this);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 3017, 3096);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(755, 3017, 3096);
                    // Dispose shall not throw
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 3112, 3129);

                _disposed = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 2884, 3140);

                int
                f_755_2971_2987(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param)
                {
                    this_param.CloseSymWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 2971, 2987);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 2884, 3140);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 2884, 3140);
            }
        }

        private void CloseSymWriter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 3152, 4010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 3206, 3265);

                var
                symWriter = f_755_3222_3264(ref _symWriter, null)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 3279, 3356) || true) && (symWriter == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 3279, 3356);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 3334, 3341);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 3279, 3356);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 3408, 3426);

                    f_755_3408_3425(symWriter);
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 3455, 3553);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 3508, 3538);

                    throw f_755_3514_3537(this, ex);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(755, 3455, 3553);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(755, 3567, 3999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 3959, 3984);

                    f_755_3959_3983(                // We leave releasing SymWriter and document writer COM objects the to GC -- 
                                                    // we write to an in-memory stream hence no files are being locked.
                                                    // We need to keep these alive until the symWriter is closed because the
                                                    // symWriter seems to have a un-ref-counted reference to them.  
                                    _documentWriters);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(755, 3567, 3999);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 3152, 4010);

                Microsoft.DiaSymReader.ISymUnmanagedWriter5
                f_755_3222_3264(ref Microsoft.DiaSymReader.ISymUnmanagedWriter5
                location1, Microsoft.DiaSymReader.ISymUnmanagedWriter5
                value)
                {
                    var return_v = Interlocked.Exchange(ref location1, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 3222, 3264);
                    return return_v;
                }


                int
                f_755_3408_3425(Microsoft.DiaSymReader.ISymUnmanagedWriter5
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 3408, 3425);
                    return 0;
                }


                System.Exception
                f_755_3514_3537(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 3514, 3537);
                    return return_v;
                }


                int
                f_755_3959_3983(System.Collections.Generic.List<Microsoft.DiaSymReader.ISymUnmanagedDocumentWriter>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 3959, 3983);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 3152, 4010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 3152, 4010);
            }
        }

        public override IEnumerable<ArraySegment<byte>> GetUnderlyingData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 4022, 4274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 4193, 4217);

                f_755_4193_4216(f_755_4193_4207(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 4233, 4263);

                return f_755_4240_4262(_pdbStream);
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 4022, 4274);

                Microsoft.DiaSymReader.ISymUnmanagedWriter5
                f_755_4193_4207(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param)
                {
                    var return_v = this_param.GetSymWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 4193, 4207);
                    return return_v;
                }


                int
                f_755_4193_4216(Microsoft.DiaSymReader.ISymUnmanagedWriter5
                this_param)
                {
                    this_param.Commit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 4193, 4216);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.ArraySegment<byte>>
                f_755_4240_4262(Microsoft.DiaSymReader.ComMemoryStream
                this_param)
                {
                    var return_v = this_param.GetChunks();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 4240, 4262);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 4022, 4274);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 4022, 4274);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int DocumentTableCapacity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 4356, 4384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 4359, 4384);
                    return f_755_4359_4384(_documentWriters); DynAbs.Tracing.TraceSender.TraceExitMethod(755, 4356, 4384);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 4286, 4592);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 4286, 4592);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 4401, 4581);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 4437, 4566) || true) && (value > f_755_4449_4471(_documentWriters))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 4437, 4566);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 4513, 4547);

                        _documentWriters.Capacity = value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(755, 4437, 4566);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(755, 4401, 4581);

                    int
                    f_755_4449_4471(System.Collections.Generic.List<Microsoft.DiaSymReader.ISymUnmanagedDocumentWriter>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 4449, 4471);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 4286, 4592);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 4286, 4592);
                }
            }
        }

        public override int DefineDocument(string name, Guid language, Guid vendor, Guid type, Guid algorithmId, ReadOnlySpan<byte> checksum, ReadOnlySpan<byte> source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 4604, 6501);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 4789, 4900) || true) && (name == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 4789, 4900);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 4839, 4885);

                    throw f_755_4845_4884(nameof(name));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 4789, 4900);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 4916, 4947);

                var
                symWriter = f_755_4932_4946(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 4963, 4998);

                int
                index = f_755_4975_4997(_documentWriters)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 5012, 5055);

                ISymUnmanagedDocumentWriter
                documentWriter
                = default(ISymUnmanagedDocumentWriter);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 5107, 5191);

                    documentWriter = f_755_5124_5190(symWriter, name, ref language, ref vendor, ref type);
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 5220, 5318);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 5273, 5303);

                    throw f_755_5279_5302(this, ex);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(755, 5220, 5318);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 5334, 5371);

                f_755_5334_5370(
                            _documentWriters, documentWriter);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 5387, 5944) || true) && (algorithmId != default(Guid) && (DynAbs.Tracing.TraceSender.Expression_True(755, 5391, 5442) && checksum.Length > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 5387, 5944);
                    try
                    {
                        unsafe
                        {
                            fixed (byte*
    bytes = checksum
    )
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 5662, 5732);

                                f_755_5662_5731(documentWriter, algorithmId, checksum.Length, bytes);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 5819, 5929);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 5880, 5910);

                        throw f_755_5886_5909(this, ex);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(755, 5819, 5929);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 5387, 5944);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 5960, 6461) || true) && (source != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 5960, 6461);
                    try
                    {
                        unsafe
                        {
                            fixed (byte*
    bytes = source
    )
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 6196, 6249);

                                f_755_6196_6248(documentWriter, source.Length, bytes);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 6336, 6446);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 6397, 6427);

                        throw f_755_6403_6426(this, ex);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(755, 6336, 6446);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 5960, 6461);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 6477, 6490);

                return index;
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 4604, 6501);

                System.ArgumentNullException
                f_755_4845_4884(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 4845, 4884);
                    return return_v;
                }


                Microsoft.DiaSymReader.ISymUnmanagedWriter5
                f_755_4932_4946(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param)
                {
                    var return_v = this_param.GetSymWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 4932, 4946);
                    return return_v;
                }


                int
                f_755_4975_4997(System.Collections.Generic.List<Microsoft.DiaSymReader.ISymUnmanagedDocumentWriter>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 4975, 4997);
                    return return_v;
                }


                Microsoft.DiaSymReader.ISymUnmanagedDocumentWriter
                f_755_5124_5190(Microsoft.DiaSymReader.ISymUnmanagedWriter5
                this_param, string
                url, ref System.Guid
                language, ref System.Guid
                languageVendor, ref System.Guid
                documentType)
                {
                    var return_v = this_param.DefineDocument(url, ref language, ref languageVendor, ref documentType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 5124, 5190);
                    return return_v;
                }


                System.Exception
                f_755_5279_5302(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 5279, 5302);
                    return return_v;
                }


                int
                f_755_5334_5370(System.Collections.Generic.List<Microsoft.DiaSymReader.ISymUnmanagedDocumentWriter>
                this_param, Microsoft.DiaSymReader.ISymUnmanagedDocumentWriter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 5334, 5370);
                    return 0;
                }


                unsafe int
                f_755_5662_5731(Microsoft.DiaSymReader.ISymUnmanagedDocumentWriter
                this_param, System.Guid
                algorithmId, int
                checkSumSize, byte*
                checkSum)
                {
                    this_param.SetCheckSum(algorithmId, (uint)checkSumSize, checkSum);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 5662, 5731);
                    return 0;
                }


                System.Exception
                f_755_5886_5909(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 5886, 5909);
                    return return_v;
                }


                unsafe int
                f_755_6196_6248(Microsoft.DiaSymReader.ISymUnmanagedDocumentWriter
                this_param, int
                sourceSize, byte*
                source)
                {
                    this_param.SetSource((uint)sourceSize, source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 6196, 6248);
                    return 0;
                }


                System.Exception
                f_755_6403_6426(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 6403, 6426);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 4604, 6501);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 4604, 6501);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void DefineSequencePoints(int documentIndex, int count, int[] offsets, int[] startLines, int[] startColumns, int[] endLines, int[] endColumns)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 6513, 8076);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 6696, 6870) || true) && (documentIndex < 0 || (DynAbs.Tracing.TraceSender.Expression_False(755, 6700, 6760) || documentIndex >= f_755_6738_6760(_documentWriters)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 6696, 6870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 6794, 6855);

                    throw f_755_6800_6854(nameof(documentIndex));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 6696, 6870);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 6886, 6956) || true) && (offsets == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 6886, 6956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 6907, 6956);

                    throw f_755_6913_6955(nameof(offsets));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 6886, 6956);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 6970, 7046) || true) && (startLines == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 6970, 7046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 6994, 7046);

                    throw f_755_7000_7045(nameof(startLines));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 6970, 7046);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 7060, 7140) || true) && (startColumns == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 7060, 7140);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 7086, 7140);

                    throw f_755_7092_7139(nameof(startColumns));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 7060, 7140);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 7154, 7226) || true) && (endLines == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 7154, 7226);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 7176, 7226);

                    throw f_755_7182_7225(nameof(endLines));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 7154, 7226);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 7240, 7316) || true) && (endColumns == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 7240, 7316);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 7264, 7316);

                    throw f_755_7270_7315(nameof(endColumns));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 7240, 7316);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 7332, 7563) || true) && (count < 0 || (DynAbs.Tracing.TraceSender.Expression_False(755, 7336, 7374) || count > f_755_7357_7374(startLines)) || (DynAbs.Tracing.TraceSender.Expression_False(755, 7336, 7405) || count > f_755_7386_7405(startColumns)) || (DynAbs.Tracing.TraceSender.Expression_False(755, 7336, 7432) || count > f_755_7417_7432(endLines)) || (DynAbs.Tracing.TraceSender.Expression_False(755, 7336, 7461) || count > f_755_7444_7461(endColumns)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 7332, 7563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 7495, 7548);

                    throw f_755_7501_7547(nameof(count));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 7332, 7563);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 7579, 7610);

                var
                symWriter = f_755_7595_7609(this)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 7662, 7938);

                    f_755_7662_7937(symWriter, f_755_7715_7746(_documentWriters, documentIndex), count, offsets, startLines, startColumns, endLines, endColumns);
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 7967, 8065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 8020, 8050);

                    throw f_755_8026_8049(this, ex);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(755, 7967, 8065);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 6513, 8076);

                int
                f_755_6738_6760(System.Collections.Generic.List<Microsoft.DiaSymReader.ISymUnmanagedDocumentWriter>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 6738, 6760);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_755_6800_6854(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 6800, 6854);
                    return return_v;
                }


                System.ArgumentNullException
                f_755_6913_6955(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 6913, 6955);
                    return return_v;
                }


                System.ArgumentNullException
                f_755_7000_7045(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 7000, 7045);
                    return return_v;
                }


                System.ArgumentNullException
                f_755_7092_7139(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 7092, 7139);
                    return return_v;
                }


                System.ArgumentNullException
                f_755_7182_7225(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 7182, 7225);
                    return return_v;
                }


                System.ArgumentNullException
                f_755_7270_7315(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 7270, 7315);
                    return return_v;
                }


                int
                f_755_7357_7374(int[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 7357, 7374);
                    return return_v;
                }


                int
                f_755_7386_7405(int[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 7386, 7405);
                    return return_v;
                }


                int
                f_755_7417_7432(int[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 7417, 7432);
                    return return_v;
                }


                int
                f_755_7444_7461(int[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 7444, 7461);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_755_7501_7547(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 7501, 7547);
                    return return_v;
                }


                Microsoft.DiaSymReader.ISymUnmanagedWriter5
                f_755_7595_7609(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param)
                {
                    var return_v = this_param.GetSymWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 7595, 7609);
                    return return_v;
                }


                Microsoft.DiaSymReader.ISymUnmanagedDocumentWriter
                f_755_7715_7746(System.Collections.Generic.List<Microsoft.DiaSymReader.ISymUnmanagedDocumentWriter>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 7715, 7746);
                    return return_v;
                }


                int
                f_755_7662_7937(Microsoft.DiaSymReader.ISymUnmanagedWriter5
                this_param, Microsoft.DiaSymReader.ISymUnmanagedDocumentWriter
                document, int
                count, int[]
                offsets, int[]
                lines, int[]
                columns, int[]
                endLines, int[]
                endColumns)
                {
                    this_param.DefineSequencePoints(document, count, offsets, lines, columns, endLines, endColumns);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 7662, 7937);
                    return 0;
                }


                System.Exception
                f_755_8026_8049(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 8026, 8049);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 6513, 8076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 6513, 8076);
            }
        }

        public override void OpenMethod(int methodToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 8088, 8433);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 8161, 8192);

                var
                symWriter = f_755_8177_8191(this)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 8244, 8295);

                    f_755_8244_8294(symWriter, unchecked(methodToken));
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 8324, 8422);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 8377, 8407);

                    throw f_755_8383_8406(this, ex);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(755, 8324, 8422);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 8088, 8433);

                Microsoft.DiaSymReader.ISymUnmanagedWriter5
                f_755_8177_8191(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param)
                {
                    var return_v = this_param.GetSymWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 8177, 8191);
                    return return_v;
                }


                int
                f_755_8244_8294(Microsoft.DiaSymReader.ISymUnmanagedWriter5
                this_param, int
                methodToken)
                {
                    this_param.OpenMethod((uint)methodToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 8244, 8294);
                    return 0;
                }


                System.Exception
                f_755_8383_8406(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 8383, 8406);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 8088, 8433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 8088, 8433);
            }
        }

        public override void CloseMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 8445, 8749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 8504, 8535);

                var
                symWriter = f_755_8520_8534(this)
                ;
                try

                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 8587, 8611);

                    f_755_8587_8610(symWriter);
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 8640, 8738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 8693, 8723);

                    throw f_755_8699_8722(this, ex);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(755, 8640, 8738);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 8445, 8749);

                Microsoft.DiaSymReader.ISymUnmanagedWriter5
                f_755_8520_8534(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param)
                {
                    var return_v = this_param.GetSymWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 8520, 8534);
                    return return_v;
                }


                int
                f_755_8587_8610(Microsoft.DiaSymReader.ISymUnmanagedWriter5
                this_param)
                {
                    this_param.CloseMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 8587, 8610);
                    return 0;
                }


                System.Exception
                f_755_8699_8722(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 8699, 8722);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 8445, 8749);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 8445, 8749);
            }
        }

        public override void OpenScope(int startOffset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 8761, 9087);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 8833, 8864);

                var
                symWriter = f_755_8849_8863(this)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 8916, 8949);

                    f_755_8916_8948(symWriter, startOffset);
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 8978, 9076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 9031, 9061);

                    throw f_755_9037_9060(this, ex);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(755, 8978, 9076);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 8761, 9087);

                Microsoft.DiaSymReader.ISymUnmanagedWriter5
                f_755_8849_8863(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param)
                {
                    var return_v = this_param.GetSymWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 8849, 8863);
                    return return_v;
                }


                uint
                f_755_8916_8948(Microsoft.DiaSymReader.ISymUnmanagedWriter5
                this_param, int
                startOffset)
                {
                    var return_v = this_param.OpenScope(startOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 8916, 8948);
                    return return_v;
                }


                System.Exception
                f_755_9037_9060(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 9037, 9060);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 8761, 9087);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 8761, 9087);
            }
        }

        public override void CloseScope(int endOffset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 9099, 9423);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 9170, 9201);

                var
                symWriter = f_755_9186_9200(this)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 9253, 9285);

                    f_755_9253_9284(symWriter, endOffset);
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 9314, 9412);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 9367, 9397);

                    throw f_755_9373_9396(this, ex);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(755, 9314, 9412);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 9099, 9423);

                Microsoft.DiaSymReader.ISymUnmanagedWriter5
                f_755_9186_9200(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param)
                {
                    var return_v = this_param.GetSymWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 9186, 9200);
                    return return_v;
                }


                int
                f_755_9253_9284(Microsoft.DiaSymReader.ISymUnmanagedWriter5
                this_param, int
                endOffset)
                {
                    this_param.CloseScope(endOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 9253, 9284);
                    return 0;
                }


                System.Exception
                f_755_9373_9396(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 9373, 9396);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 9099, 9423);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 9099, 9423);
            }
        }

        public override void DefineLocalVariable(int index, string name, int attributes, int localSignatureToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 9435, 9939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 9565, 9596);

                var
                symWriter = f_755_9581_9595(this)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 9648, 9678);

                    const uint
                    ADDR_IL_OFFSET = 1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 9696, 9801);

                    f_755_9696_9800(symWriter, name, attributes, localSignatureToken, ADDR_IL_OFFSET, index, 0, 0, 0, 0);
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 9830, 9928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 9883, 9913);

                    throw f_755_9889_9912(this, ex);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(755, 9830, 9928);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 9435, 9939);

                Microsoft.DiaSymReader.ISymUnmanagedWriter5
                f_755_9581_9595(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param)
                {
                    var return_v = this_param.GetSymWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 9581, 9595);
                    return return_v;
                }


                int
                f_755_9696_9800(Microsoft.DiaSymReader.ISymUnmanagedWriter5
                this_param, string
                name, int
                attributes, int
                localSignatureToken, uint
                addrKind, int
                index, int
                addr2, int
                addr3, int
                startOffset, int
                endOffset)
                {
                    this_param.DefineLocalVariable2(name, attributes, localSignatureToken, addrKind, index, (uint)addr2, (uint)addr3, (uint)startOffset, (uint)endOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 9696, 9800);
                    return 0;
                }


                System.Exception
                f_755_9889_9912(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 9889, 9912);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 9435, 9939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 9435, 9939);
            }
        }

        public override bool DefineLocalConstant(string name, object value, int constantSignatureToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 9951, 11984);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 10071, 10102);

                var
                symWriter = f_755_10087_10101(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 10118, 11973);

                switch (value)
                {

                    case string str:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 10118, 11973);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 10203, 10282);

                        return f_755_10210_10281(this, symWriter, name, str, constantSignatureToken);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(755, 10118, 11973);

                    case DateTime dateTime:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 10118, 11973);
                        // Note: Do not use DefineConstant as it doesn't set the local signature token, which is required in order to avoid callbacks to IMetadataEmit.

                        // Marshal.GetNativeVariantForObject would create a variant with type VT_DATE and value equal to the
                        // number of days since 1899/12/30.  However, ConstantValue::VariantFromConstant in the native VB
                        // compiler actually created a variant with type VT_DATE and value equal to the tick count.
                        // http://blogs.msdn.com/b/ericlippert/archive/2003/09/16/eric-s-complete-guide-to-vt-date.aspx
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 11037, 11125);

                            f_755_11037_11124(symWriter, name, f_755_11069_11099(dateTime), constantSignatureToken);
                        }
                        catch (Exception ex)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 11170, 11292);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 11239, 11269);

                            throw f_755_11245_11268(this, ex);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(755, 11170, 11292);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 11316, 11328);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(755, 10118, 11973);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 10118, 11973);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 11668, 11755);

                            f_755_11668_11754(this, symWriter, name, value ?? (DynAbs.Tracing.TraceSender.Expression_Null<object>(755, 11709, 11729) ?? s_zeroInt32), constantSignatureToken);
                        }
                        catch (Exception ex)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 11800, 11922);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 11869, 11899);

                            throw f_755_11875_11898(this, ex);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(755, 11800, 11922);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 11946, 11958);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(755, 10118, 11973);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 9951, 11984);

                Microsoft.DiaSymReader.ISymUnmanagedWriter5
                f_755_10087_10101(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param)
                {
                    var return_v = this_param.GetSymWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 10087, 10101);
                    return return_v;
                }


                bool
                f_755_10210_10281(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, Microsoft.DiaSymReader.ISymUnmanagedWriter5
                symWriter, string
                name, string
                value, int
                constantSignatureToken)
                {
                    var return_v = this_param.DefineLocalStringConstant(symWriter, name, value, constantSignatureToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 10210, 10281);
                    return return_v;
                }


                Microsoft.DiaSymReader.VariantStructure
                f_755_11069_11099(System.DateTime
                date)
                {
                    var return_v = new Microsoft.DiaSymReader.VariantStructure(date);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 11069, 11099);
                    return return_v;
                }


                int
                f_755_11037_11124(Microsoft.DiaSymReader.ISymUnmanagedWriter5
                this_param, string
                name, Microsoft.DiaSymReader.VariantStructure
                value, int
                constantSignatureToken)
                {
                    this_param.DefineConstant2(name, value, constantSignatureToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 11037, 11124);
                    return 0;
                }


                System.Exception
                f_755_11245_11268(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 11245, 11268);
                    return return_v;
                }


                int
                f_755_11668_11754(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, Microsoft.DiaSymReader.ISymUnmanagedWriter5
                symWriter, string
                name, object
                value, int
                constantSignatureToken)
                {
                    this_param.DefineLocalConstantImpl(symWriter, name, value, constantSignatureToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 11668, 11754);
                    return 0;
                }


                System.Exception
                f_755_11875_11898(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 11875, 11898);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 9951, 11984);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 9951, 11984);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private unsafe void DefineLocalConstantImpl(ISymUnmanagedWriter5 symWriter, string name, object value, int constantSignatureToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 11996, 12492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 12151, 12201);

                VariantStructure
                variant = f_755_12178_12200()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 12277, 12340);

                f_755_12277_12339(value, f_755_12318_12338(&variant));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 12416, 12481);

                f_755_12416_12480(symWriter, name, variant, constantSignatureToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 11996, 12492);

                Microsoft.DiaSymReader.VariantStructure
                f_755_12178_12200()
                {
                    var return_v = new Microsoft.DiaSymReader.VariantStructure();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 12178, 12200);
                    return return_v;
                }


                unsafe System.IntPtr
                f_755_12318_12338(Microsoft.DiaSymReader.VariantStructure*
                value)
                {
                    var return_v = new System.IntPtr((void*)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 12318, 12338);
                    return return_v;
                }


                int
                f_755_12277_12339(object
                obj, System.IntPtr
                pDstNativeVariant)
                {
#pragma warning disable CS0618 // Type or member is obsolete
                    Marshal.GetNativeVariantForObject(obj, pDstNativeVariant);
#pragma warning restore CS0618 // Type or member is obsolete
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 12277, 12339);
                    return 0;
                }


                int
                f_755_12416_12480(Microsoft.DiaSymReader.ISymUnmanagedWriter5
                this_param, string
                name, Microsoft.DiaSymReader.VariantStructure
                value, int
                constantSignatureToken)
                {
                    this_param.DefineConstant2(name, value, constantSignatureToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 12416, 12480);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 11996, 12492);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 11996, 12492);
            }
        }

        private bool DefineLocalStringConstant(ISymUnmanagedWriter5 symWriter, string name, string value, int constantSignatureToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 12504, 15084);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 12654, 12682);

                f_755_12654_12681(value != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 12698, 12716);

                int
                encodedLength
                = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 12958, 13321) || true) && (!f_755_12963_12990(value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 12958, 13321);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 13024, 13069);

                    byte[]
                    bytes = f_755_13039_13068(f_755_13039_13052(), value)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 13087, 13116);

                    encodedLength = f_755_13103_13115(bytes);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 13134, 13190);

                    value = f_755_13142_13189(f_755_13142_13155(), bytes, 0, f_755_13176_13188(bytes));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 12958, 13321);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 12958, 13321);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 13256, 13306);

                    encodedLength = f_755_13272_13305(f_755_13272_13285(), value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 12958, 13321);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 13386, 13402);

                encodedLength++;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 13833, 13919) || true) && (encodedLength > 2032)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 13833, 13919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 13891, 13904);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 13833, 13919);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 13971, 14043);

                    f_755_13971_14042(this, symWriter, name, value, constantSignatureToken);
                }
                catch (ArgumentException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 14072, 14933);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 14905, 14918);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(755, 14072, 14933);
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 14947, 15045);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 15000, 15030);

                    throw f_755_15006_15029(this, ex);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(755, 14947, 15045);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 15061, 15073);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 12504, 15084);

                int
                f_755_12654_12681(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 12654, 12681);
                    return 0;
                }


                bool
                f_755_12963_12990(string
                str)
                {
                    var return_v = IsValidUnicodeString(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 12963, 12990);
                    return return_v;
                }


                System.Text.Encoding
                f_755_13039_13052()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 13039, 13052);
                    return return_v;
                }


                byte[]
                f_755_13039_13068(System.Text.Encoding
                this_param, string
                s)
                {
                    var return_v = this_param.GetBytes(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 13039, 13068);
                    return return_v;
                }


                int
                f_755_13103_13115(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 13103, 13115);
                    return return_v;
                }


                System.Text.Encoding
                f_755_13142_13155()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 13142, 13155);
                    return return_v;
                }


                int
                f_755_13176_13188(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 13176, 13188);
                    return return_v;
                }


                string
                f_755_13142_13189(System.Text.Encoding
                this_param, byte[]
                bytes, int
                index, int
                count)
                {
                    var return_v = this_param.GetString(bytes, index, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 13142, 13189);
                    return return_v;
                }


                System.Text.Encoding
                f_755_13272_13285()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 13272, 13285);
                    return return_v;
                }


                int
                f_755_13272_13305(System.Text.Encoding
                this_param, string
                s)
                {
                    var return_v = this_param.GetByteCount(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 13272, 13305);
                    return return_v;
                }


                int
                f_755_13971_14042(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, Microsoft.DiaSymReader.ISymUnmanagedWriter5
                symWriter, string
                name, string
                value, int
                constantSignatureToken)
                {
                    this_param.DefineLocalConstantImpl(symWriter, name, (object)value, constantSignatureToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 13971, 14042);
                    return 0;
                }


                System.Exception
                f_755_15006_15029(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 15006, 15029);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 12504, 15084);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 12504, 15084);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsValidUnicodeString(string str)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(755, 15096, 16030);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 15173, 15183);

                int
                i = 0
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 15197, 15991) || true) && (i < f_755_15208_15218(str))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 15197, 15991);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 15252, 15270);

                        char
                        c = f_755_15261_15269(str, i++)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 15388, 15976) || true) && (f_755_15392_15415(c))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 15388, 15976);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 15457, 15767) || true) && (i < f_755_15465_15475(str) && (DynAbs.Tracing.TraceSender.Expression_True(755, 15461, 15506) && f_755_15479_15506(f_755_15499_15505(str, i))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 15457, 15767);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 15556, 15560);

                                i++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(755, 15457, 15767);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 15457, 15767);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 15731, 15744);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(755, 15457, 15767);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(755, 15388, 15976);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 15388, 15976);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 15809, 15976) || true) && (f_755_15813_15835(c))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 15809, 15976);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 15944, 15957);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(755, 15809, 15976);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(755, 15388, 15976);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(755, 15197, 15991);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(755, 15197, 15991);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(755, 15197, 15991);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 16007, 16019);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(755, 15096, 16030);

                int
                f_755_15208_15218(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 15208, 15218);
                    return return_v;
                }


                char
                f_755_15261_15269(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 15261, 15269);
                    return return_v;
                }


                bool
                f_755_15392_15415(char
                c)
                {
                    var return_v = char.IsHighSurrogate(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 15392, 15415);
                    return return_v;
                }


                int
                f_755_15465_15475(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 15465, 15475);
                    return return_v;
                }


                char
                f_755_15499_15505(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 15499, 15505);
                    return return_v;
                }


                bool
                f_755_15479_15506(char
                c)
                {
                    var return_v = char.IsLowSurrogate(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 15479, 15506);
                    return return_v;
                }


                bool
                f_755_15813_15835(char
                c)
                {
                    var return_v = char.IsLowSurrogate(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 15813, 15835);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 15096, 16030);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 15096, 16030);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void UsingNamespace(string importString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 16042, 16526);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 16123, 16250) || true) && (importString == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 16123, 16250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 16181, 16235);

                    throw f_755_16187_16234(nameof(importString));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 16123, 16250);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 16266, 16297);

                var
                symWriter = f_755_16282_16296(this)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 16349, 16388);

                    f_755_16349_16387(symWriter, importString);
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 16417, 16515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 16470, 16500);

                    throw f_755_16476_16499(this, ex);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(755, 16417, 16515);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 16042, 16526);

                System.ArgumentNullException
                f_755_16187_16234(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 16187, 16234);
                    return return_v;
                }


                Microsoft.DiaSymReader.ISymUnmanagedWriter5
                f_755_16282_16296(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param)
                {
                    var return_v = this_param.GetSymWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 16282, 16296);
                    return return_v;
                }


                int
                f_755_16349_16387(Microsoft.DiaSymReader.ISymUnmanagedWriter5
                this_param, string
                fullName)
                {
                    this_param.UsingNamespace(fullName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 16349, 16387);
                    return 0;
                }


                System.Exception
                f_755_16476_16499(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 16476, 16499);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 16042, 16526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 16042, 16526);
            }
        }

        public override void SetAsyncInfo(
                    int moveNextMethodToken,
                    int kickoffMethodToken,
                    int catchHandlerOffset,
                    ReadOnlySpan<int> yieldOffsets,
                    ReadOnlySpan<int> resumeOffsets)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 16538, 18781);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 16800, 16880) || true) && (yieldOffsets == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 16800, 16880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 16826, 16880);

                    throw f_755_16832_16879(nameof(yieldOffsets));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 16800, 16880);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 16894, 16976) || true) && (resumeOffsets == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 16894, 16976);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 16921, 16976);

                    throw f_755_16927_16975(nameof(resumeOffsets));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 16894, 16976);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 16992, 17148) || true) && (yieldOffsets.Length != resumeOffsets.Length)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 16992, 17148);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 17073, 17133);

                    throw f_755_17079_17132(nameof(yieldOffsets));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 16992, 17148);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 17164, 18770) || true) && (f_755_17168_17182(this) is ISymUnmanagedAsyncMethodPropertiesWriter asyncMethodPropertyWriter)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 17164, 18770);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 17286, 17318);

                    int
                    count = yieldOffsets.Length
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 17338, 18281) || true) && (count > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 17338, 18281);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 17393, 17422);

                        var
                        methods = new int[count]
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 17453, 17458);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 17444, 17580) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 17471, 17474)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(755, 17444, 17580))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 17444, 17580);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 17524, 17557);

                                methods[i] = moveNextMethodToken;
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(755, 1, 137);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(755, 1, 137);
                        }
                        try
                        {
                            unsafe
                            {
                                fixed (int*
    yieldPtr = yieldOffsets
    )
                                fixed (int*
    resumePtr = resumeOffsets
    )
                                fixed (int*
    methodsPtr = methods
    )
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 17951, 18037);

                                    f_755_17951_18036(asyncMethodPropertyWriter, count, yieldPtr, resumePtr, methodsPtr);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 18140, 18262);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 18209, 18239);

                            throw f_755_18215_18238(this, ex);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(755, 18140, 18262);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(755, 17338, 18281);
                    }

                    try
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 18345, 18518) || true) && (catchHandlerOffset >= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 18345, 18518);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 18422, 18495);

                            f_755_18422_18494(asyncMethodPropertyWriter, catchHandlerOffset);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(755, 18345, 18518);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 18542, 18608);

                        f_755_18542_18607(
                                            asyncMethodPropertyWriter, kickoffMethodToken);
                    }
                    catch (Exception ex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 18645, 18755);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 18706, 18736);

                        throw f_755_18712_18735(this, ex);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(755, 18645, 18755);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 17164, 18770);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 16538, 18781);

                System.ArgumentNullException
                f_755_16832_16879(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 16832, 16879);
                    return return_v;
                }


                System.ArgumentNullException
                f_755_16927_16975(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 16927, 16975);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_755_17079_17132(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 17079, 17132);
                    return return_v;
                }


                Microsoft.DiaSymReader.ISymUnmanagedWriter5
                f_755_17168_17182(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param)
                {
                    var return_v = this_param.GetSymWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 17168, 17182);
                    return return_v;
                }


                unsafe int
                f_755_17951_18036(Microsoft.DiaSymReader.ISymUnmanagedAsyncMethodPropertiesWriter
                this_param, int
                count, int*
                yieldOffsets, int*
                breakpointOffset, int*
                breakpointMethod)
                {
                    this_param.DefineAsyncStepInfo(count, yieldOffsets, breakpointOffset, breakpointMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 17951, 18036);
                    return 0;
                }


                System.Exception
                f_755_18215_18238(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 18215, 18238);
                    return return_v;
                }


                int
                f_755_18422_18494(Microsoft.DiaSymReader.ISymUnmanagedAsyncMethodPropertiesWriter
                this_param, int
                catchHandlerOffset)
                {
                    this_param.DefineCatchHandlerILOffset(catchHandlerOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 18422, 18494);
                    return 0;
                }


                int
                f_755_18542_18607(Microsoft.DiaSymReader.ISymUnmanagedAsyncMethodPropertiesWriter
                this_param, int
                kickoffMethod)
                {
                    this_param.DefineKickoffMethod(kickoffMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 18542, 18607);
                    return 0;
                }


                System.Exception
                f_755_18712_18735(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 18712, 18735);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 16538, 18781);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 16538, 18781);
            }
        }

        public override unsafe void DefineCustomMetadata(byte[] metadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 18793, 19599);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 18883, 19002) || true) && (metadata == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 18883, 19002);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 18937, 18987);

                    throw f_755_18943_18986(nameof(metadata));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 18883, 19002);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 19018, 19098) || true) && (f_755_19022_19037(metadata) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 19018, 19098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 19076, 19083);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 19018, 19098);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 19114, 19145);

                var
                symWriter = f_755_19130_19144(this)
                ;

                try
                {
                    fixed (byte*
    pb = metadata
    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 19385, 19442);

                        f_755_19385_19441(                    // parent parameter is not used, it must be zero or the current method token passed to OpenMethod.
                                            symWriter, 0, "MD2", f_755_19421_19436(metadata), pb);
                    }
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 19490, 19588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 19543, 19573);

                    throw f_755_19549_19572(this, ex);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(755, 19490, 19588);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 18793, 19599);

                System.ArgumentNullException
                f_755_18943_18986(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 18943, 18986);
                    return return_v;
                }


                int
                f_755_19022_19037(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 19022, 19037);
                    return return_v;
                }


                Microsoft.DiaSymReader.ISymUnmanagedWriter5
                f_755_19130_19144(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param)
                {
                    var return_v = this_param.GetSymWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 19130, 19144);
                    return return_v;
                }


                int
                f_755_19421_19436(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 19421, 19436);
                    return return_v;
                }


                unsafe int
                f_755_19385_19441(Microsoft.DiaSymReader.ISymUnmanagedWriter5
                this_param, int
                parent, string
                name, int
                length, byte*
                data)
                {
                    this_param.SetSymAttribute((uint)parent, name, length, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 19385, 19441);
                    return 0;
                }


                System.Exception
                f_755_19549_19572(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 19549, 19572);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 18793, 19599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 18793, 19599);
            }
        }

        public override void SetEntryPoint(int entryMethodToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 19611, 19959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 19692, 19723);

                var
                symWriter = f_755_19708_19722(this)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 19775, 19821);

                    f_755_19775_19820(symWriter, entryMethodToken);
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 19850, 19948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 19903, 19933);

                    throw f_755_19909_19932(this, ex);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(755, 19850, 19948);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 19611, 19959);

                Microsoft.DiaSymReader.ISymUnmanagedWriter5
                f_755_19708_19722(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param)
                {
                    var return_v = this_param.GetSymWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 19708, 19722);
                    return return_v;
                }


                int
                f_755_19775_19820(Microsoft.DiaSymReader.ISymUnmanagedWriter5
                this_param, int
                entryMethodToken)
                {
                    this_param.SetUserEntryPoint(entryMethodToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 19775, 19820);
                    return 0;
                }


                System.Exception
                f_755_19909_19932(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 19909, 19932);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 19611, 19959);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 19611, 19959);
            }
        }

        public override void UpdateSignature(Guid guid, uint stamp, int age)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 19971, 20330);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 20064, 20096);

                var
                symWriter = f_755_20080_20095(this)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 20148, 20192);

                    f_755_20148_20191(symWriter, guid, stamp, age);
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 20221, 20319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 20274, 20304);

                    throw f_755_20280_20303(this, ex);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(755, 20221, 20319);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 19971, 20330);

                Microsoft.DiaSymReader.ISymUnmanagedWriter8
                f_755_20080_20095(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param)
                {
                    var return_v = this_param.GetSymWriter8();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 20080, 20095);
                    return return_v;
                }


                int
                f_755_20148_20191(Microsoft.DiaSymReader.ISymUnmanagedWriter8
                this_param, System.Guid
                pdbId, uint
                stamp, int
                age)
                {
                    this_param.UpdateSignature(pdbId, stamp, age);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 20148, 20191);
                    return 0;
                }


                System.Exception
                f_755_20280_20303(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 20280, 20303);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 19971, 20330);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 19971, 20330);
            }
        }

        public override unsafe void SetSourceServerData(byte[] data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 20342, 21008);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 20427, 20538) || true) && (data == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 20427, 20538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 20477, 20523);

                    throw f_755_20483_20522(nameof(data));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 20427, 20538);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 20554, 20630) || true) && (f_755_20558_20569(data) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 20554, 20630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 20608, 20615);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 20554, 20630);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 20646, 20678);

                var
                symWriter = f_755_20662_20677(this)
                ;

                try
                {
                    fixed (byte*
    dataPtr = data
    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 20799, 20851);

                        f_755_20799_20850(symWriter, dataPtr, f_755_20838_20849(data));
                    }
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 20899, 20997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 20952, 20982);

                    throw f_755_20958_20981(this, ex);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(755, 20899, 20997);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 20342, 21008);

                System.ArgumentNullException
                f_755_20483_20522(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 20483, 20522);
                    return return_v;
                }


                int
                f_755_20558_20569(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 20558, 20569);
                    return return_v;
                }


                Microsoft.DiaSymReader.ISymUnmanagedWriter8
                f_755_20662_20677(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param)
                {
                    var return_v = this_param.GetSymWriter8();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 20662, 20677);
                    return return_v;
                }


                int
                f_755_20838_20849(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 20838, 20849);
                    return return_v;
                }


                unsafe int
                f_755_20799_20850(Microsoft.DiaSymReader.ISymUnmanagedWriter8
                this_param, byte*
                data, int
                size)
                {
                    this_param.SetSourceServerData(data, size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 20799, 20850);
                    return 0;
                }


                System.Exception
                f_755_20958_20981(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 20958, 20981);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 20342, 21008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 20342, 21008);
            }
        }

        public override unsafe void SetSourceLinkData(byte[] data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 21020, 21682);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 21103, 21214) || true) && (data == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 21103, 21214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 21153, 21199);

                    throw f_755_21159_21198(nameof(data));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 21103, 21214);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 21230, 21306) || true) && (f_755_21234_21245(data) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 21230, 21306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 21284, 21291);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 21230, 21306);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 21322, 21354);

                var
                symWriter = f_755_21338_21353(this)
                ;

                try
                {
                    fixed (byte*
    dataPtr = data
    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 21475, 21525);

                        f_755_21475_21524(symWriter, dataPtr, f_755_21512_21523(data));
                    }
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 21573, 21671);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 21626, 21656);

                    throw f_755_21632_21655(this, ex);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(755, 21573, 21671);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 21020, 21682);

                System.ArgumentNullException
                f_755_21159_21198(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 21159, 21198);
                    return return_v;
                }


                int
                f_755_21234_21245(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 21234, 21245);
                    return return_v;
                }


                Microsoft.DiaSymReader.ISymUnmanagedWriter8
                f_755_21338_21353(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param)
                {
                    var return_v = this_param.GetSymWriter8();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 21338, 21353);
                    return return_v;
                }


                int
                f_755_21512_21523(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 21512, 21523);
                    return return_v;
                }


                unsafe int
                f_755_21475_21524(Microsoft.DiaSymReader.ISymUnmanagedWriter8
                this_param, byte*
                data, int
                size)
                {
                    this_param.SetSourceLinkData(data, size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 21475, 21524);
                    return 0;
                }


                System.Exception
                f_755_21632_21655(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 21632, 21655);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 21020, 21682);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 21020, 21682);
            }
        }

        public override void OpenTokensToSourceSpansMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 21694, 22028);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 21768, 21799);

                var
                symWriter = f_755_21784_21798(this)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 21851, 21890);

                    f_755_21851_21889(symWriter);
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 21919, 22017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 21972, 22002);

                    throw f_755_21978_22001(this, ex);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(755, 21919, 22017);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 21694, 22028);

                Microsoft.DiaSymReader.ISymUnmanagedWriter5
                f_755_21784_21798(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param)
                {
                    var return_v = this_param.GetSymWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 21784, 21798);
                    return return_v;
                }


                int
                f_755_21851_21889(Microsoft.DiaSymReader.ISymUnmanagedWriter5
                this_param)
                {
                    this_param.OpenMapTokensToSourceSpans();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 21851, 21889);
                    return 0;
                }


                System.Exception
                f_755_21978_22001(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 21978, 22001);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 21694, 22028);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 21694, 22028);
            }
        }

        public override void MapTokenToSourceSpan(int token, int documentIndex, int startLine, int startColumn, int endLine, int endColumn)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 22040, 22849);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 22196, 22370) || true) && (documentIndex < 0 || (DynAbs.Tracing.TraceSender.Expression_False(755, 22200, 22260) || documentIndex >= f_755_22238_22260(_documentWriters)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(755, 22196, 22370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 22294, 22355);

                    throw f_755_22300_22354(nameof(documentIndex));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(755, 22196, 22370);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 22386, 22417);

                var
                symWriter = f_755_22402_22416(this)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 22469, 22711);

                    f_755_22469_22710(symWriter, token, f_755_22550_22581(_documentWriters, documentIndex), startLine, startColumn, endLine, endColumn);
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 22740, 22838);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 22793, 22823);

                    throw f_755_22799_22822(this, ex);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(755, 22740, 22838);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 22040, 22849);

                int
                f_755_22238_22260(System.Collections.Generic.List<Microsoft.DiaSymReader.ISymUnmanagedDocumentWriter>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 22238, 22260);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_755_22300_22354(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 22300, 22354);
                    return return_v;
                }


                Microsoft.DiaSymReader.ISymUnmanagedWriter5
                f_755_22402_22416(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param)
                {
                    var return_v = this_param.GetSymWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 22402, 22416);
                    return return_v;
                }


                Microsoft.DiaSymReader.ISymUnmanagedDocumentWriter
                f_755_22550_22581(System.Collections.Generic.List<Microsoft.DiaSymReader.ISymUnmanagedDocumentWriter>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 22550, 22581);
                    return return_v;
                }


                int
                f_755_22469_22710(Microsoft.DiaSymReader.ISymUnmanagedWriter5
                this_param, int
                token, Microsoft.DiaSymReader.ISymUnmanagedDocumentWriter
                document, int
                startLine, int
                startColumn, int
                endLine, int
                endColumn)
                {
                    this_param.MapTokenToSourceSpan(token, document, startLine, startColumn, endLine, endColumn);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 22469, 22710);
                    return 0;
                }


                System.Exception
                f_755_22799_22822(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 22799, 22822);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 22040, 22849);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 22040, 22849);
            }
        }

        public override void CloseTokensToSourceSpansMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 22861, 23197);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 22936, 22967);

                var
                symWriter = f_755_22952_22966(this)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 23019, 23059);

                    f_755_23019_23058(symWriter);
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 23088, 23186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 23141, 23171);

                    throw f_755_23147_23170(this, ex);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(755, 23088, 23186);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 22861, 23197);

                Microsoft.DiaSymReader.ISymUnmanagedWriter5
                f_755_22952_22966(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param)
                {
                    var return_v = this_param.GetSymWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 22952, 22966);
                    return return_v;
                }


                int
                f_755_23019_23058(Microsoft.DiaSymReader.ISymUnmanagedWriter5
                this_param)
                {
                    this_param.CloseMapTokensToSourceSpans();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 23019, 23058);
                    return 0;
                }


                System.Exception
                f_755_23147_23170(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 23147, 23170);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 22861, 23197);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 22861, 23197);
            }
        }

        public override unsafe void GetSignature(out Guid guid, out uint stamp, out int age)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(755, 23209, 25520);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 23318, 23349);

                var
                symWriter = f_755_23334_23348(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 23855, 23896);

                var
                debugDir = f_755_23870_23895()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 23910, 23926);

                uint
                dataLength
                = default(uint);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 23978, 24040);

                    f_755_23978_24039(symWriter, ref debugDir, 0, out dataLength, null);
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 24069, 24167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 24122, 24152);

                    throw f_755_24128_24151(this, ex);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(755, 24069, 24167);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 24183, 24218);

                byte[]
                data = new byte[dataLength]
                ;
                fixed (byte*
    pb = data
    )
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 24332, 24401);

                        f_755_24332_24400(symWriter, ref debugDir, dataLength, out dataLength, pb);
                    }
                    catch (Exception ex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(755, 24438, 24548);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 24499, 24529);

                        throw f_755_24505_24528(this, ex);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(755, 24438, 24548);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 24992, 25016);

                const int
                GuidSize = 16
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 25030, 25065);

                var
                guidBytes = new byte[GuidSize]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 25079, 25137);

                f_755_25079_25136(data, 4, guidBytes, 0, f_755_25119_25135(guidBytes));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 25151, 25178);

                guid = f_755_25158_25177(guidBytes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 25449, 25509);

                f_755_25449_25508(
                            // Retrieve the timestamp the PDB writer generates when creating a new PDB stream.
                            // Note that ImageDebugDirectory.TimeDateStamp is not set by GetDebugInfo, 
                            // we need to go through IPdbWriter interface to get it.
                            ((IPdbWriter)symWriter), out stamp, out age);
                DynAbs.Tracing.TraceSender.TraceExitMethod(755, 23209, 25520);

                Microsoft.DiaSymReader.ISymUnmanagedWriter5
                f_755_23334_23348(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param)
                {
                    var return_v = this_param.GetSymWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 23334, 23348);
                    return return_v;
                }


                Microsoft.DiaSymReader.ImageDebugDirectory
                f_755_23870_23895()
                {
                    var return_v = new Microsoft.DiaSymReader.ImageDebugDirectory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 23870, 23895);
                    return return_v;
                }


                unsafe int
                f_755_23978_24039(Microsoft.DiaSymReader.ISymUnmanagedWriter5
                this_param, ref Microsoft.DiaSymReader.ImageDebugDirectory
                debugDirectory, int
                dataCount, out uint
                dataCountPtr, byte*
                data)
                {
                    this_param.GetDebugInfo(ref debugDirectory, (uint)dataCount, out dataCountPtr, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 23978, 24039);
                    return 0;
                }


                System.Exception
                f_755_24128_24151(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 24128, 24151);
                    return return_v;
                }


                unsafe int
                f_755_24332_24400(Microsoft.DiaSymReader.ISymUnmanagedWriter5
                this_param, ref Microsoft.DiaSymReader.ImageDebugDirectory
                debugDirectory, uint
                dataCount, out uint
                dataCountPtr, byte*
                data)
                {
                    this_param.GetDebugInfo(ref debugDirectory, dataCount, out dataCountPtr, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 24332, 24400);
                    return 0;
                }


                System.Exception
                f_755_24505_24528(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
                this_param, System.Exception
                inner)
                {
                    var return_v = this_param.PdbWritingException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 24505, 24528);
                    return return_v;
                }


                int
                f_755_25119_25135(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 25119, 25135);
                    return return_v;
                }


                int
                f_755_25079_25136(byte[]
                src, int
                srcOffset, byte[]
                dst, int
                dstOffset, int
                count)
                {
                    Buffer.BlockCopy((System.Array)src, srcOffset, (System.Array)dst, dstOffset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 25079, 25136);
                    return 0;
                }


                System.Guid
                f_755_25158_25177(byte[]
                b)
                {
                    var return_v = new System.Guid(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 25158, 25177);
                    return return_v;
                }


                int
                f_755_25449_25508(Microsoft.DiaSymReader.IPdbWriter
                this_param, out uint
                sig, out int
                age)
                {
                    this_param.GetSignatureAge(out sig, out age);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 25449, 25508);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(755, 23209, 25520);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 23209, 25520);
            }
        }

        static SymUnmanagedWriterImpl()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(755, 451, 25527);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(755, 564, 579);
            s_zeroInt32 = 0; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(755, 451, 25527);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(755, 451, 25527);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(755, 451, 25527);

        static int
        f_755_1007_1038(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 1007, 1038);
            return 0;
        }


        static int
        f_755_1053_1084(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 1053, 1084);
            return 0;
        }


        static int
        f_755_1099_1140(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 1099, 1140);
            return 0;
        }


        static System.Collections.Generic.List<Microsoft.DiaSymReader.ISymUnmanagedDocumentWriter>
        f_755_1250_1289()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.DiaSymReader.ISymUnmanagedDocumentWriter>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 1250, 1289);
            return return_v;
        }


        int
        f_755_2847_2860(Microsoft.DiaSymReader.SymUnmanagedWriterImpl
        this_param)
        {
            this_param.DisposeImpl();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(755, 2847, 2860);
            return 0;
        }


        int
        f_755_4359_4384(System.Collections.Generic.List<Microsoft.DiaSymReader.ISymUnmanagedDocumentWriter>
        this_param)
        {
            var return_v = this_param.Capacity;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(755, 4359, 4384);
            return return_v;
        }

    }
}
