// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.IO;
using System.Threading;
using System.Collections.Immutable;
using System.Collections.Generic;

namespace Microsoft.CodeAnalysis
{
    public abstract class PortableExecutableReference : MetadataReference
    {
        private readonly string? _filePath;

        private DocumentationProvider? _lazyDocumentation;

        protected PortableExecutableReference(
                    MetadataReferenceProperties properties,
                    string? fullPath = null,
                    DocumentationProvider? initialDocumentation = null)
        : base(f_435_910_920_C(properties))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(435, 695, 1034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 611, 620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 664, 682);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 946, 967);

                _filePath = fullPath;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 981, 1023);

                _lazyDocumentation = initialDocumentation;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(435, 695, 1034);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(435, 695, 1034);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(435, 695, 1034);
            }
        }

        public override string? Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(435, 1227, 1251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 1233, 1249);

                    return f_435_1240_1248();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(435, 1227, 1251);

                    string?
                    f_435_1240_1248()
                    {
                        var return_v = FilePath;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(435, 1240, 1248);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(435, 1171, 1262);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(435, 1171, 1262);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string? FilePath
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(435, 1470, 1495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 1476, 1493);

                    return _filePath;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(435, 1470, 1495);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(435, 1422, 1506);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(435, 1422, 1506);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal DocumentationProvider DocumentationProvider
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(435, 1710, 1987);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 1746, 1926) || true) && (_lazyDocumentation == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(435, 1746, 1926);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 1818, 1907);

                        f_435_1818_1906(ref _lazyDocumentation, f_435_1870_1899(this), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(435, 1746, 1926);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 1946, 1972);

                    return _lazyDocumentation;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(435, 1710, 1987);

                    Microsoft.CodeAnalysis.DocumentationProvider
                    f_435_1870_1899(Microsoft.CodeAnalysis.PortableExecutableReference
                    this_param)
                    {
                        var return_v = this_param.CreateDocumentationProvider();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(435, 1870, 1899);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DocumentationProvider?
                    f_435_1818_1906(ref Microsoft.CodeAnalysis.DocumentationProvider?
                    location1, Microsoft.CodeAnalysis.DocumentationProvider
                    value, Microsoft.CodeAnalysis.DocumentationProvider?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(435, 1818, 1906);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(435, 1633, 1998);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(435, 1633, 1998);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract DocumentationProvider CreateDocumentationProvider();

        public new PortableExecutableReference WithAliases(IEnumerable<string> aliases)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(435, 2798, 2974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 2902, 2963);

                return f_435_2909_2962(this, f_435_2926_2961(aliases));
                DynAbs.Tracing.TraceSender.TraceExitMethod(435, 2798, 2974);

                System.Collections.Immutable.ImmutableArray<string>
                f_435_2926_2961(System.Collections.Generic.IEnumerable<string>
                items)
                {
                    var return_v = ImmutableArray.CreateRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(435, 2926, 2961);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_435_2909_2962(Microsoft.CodeAnalysis.PortableExecutableReference
                this_param, System.Collections.Immutable.ImmutableArray<string>
                aliases)
                {
                    var return_v = this_param.WithAliases(aliases);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(435, 2909, 2962);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(435, 2798, 2974);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(435, 2798, 2974);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new PortableExecutableReference WithAliases(ImmutableArray<string> aliases)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(435, 3287, 3460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 3394, 3449);

                return f_435_3401_3448(this, f_435_3416_3426().WithAliases(aliases));
                DynAbs.Tracing.TraceSender.TraceExitMethod(435, 3287, 3460);

                Microsoft.CodeAnalysis.MetadataReferenceProperties
                f_435_3416_3426()
                {
                    var return_v = Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(435, 3416, 3426);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_435_3401_3448(Microsoft.CodeAnalysis.PortableExecutableReference
                this_param, Microsoft.CodeAnalysis.MetadataReferenceProperties
                properties)
                {
                    var return_v = this_param.WithProperties(properties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(435, 3401, 3448);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(435, 3287, 3460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(435, 3287, 3460);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new PortableExecutableReference WithEmbedInteropTypes(bool value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(435, 3837, 4008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 3934, 3997);

                return f_435_3941_3996(this, f_435_3956_3966().WithEmbedInteropTypes(value));
                DynAbs.Tracing.TraceSender.TraceExitMethod(435, 3837, 4008);

                Microsoft.CodeAnalysis.MetadataReferenceProperties
                f_435_3956_3966()
                {
                    var return_v = Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(435, 3956, 3966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_435_3941_3996(Microsoft.CodeAnalysis.PortableExecutableReference
                this_param, Microsoft.CodeAnalysis.MetadataReferenceProperties
                properties)
                {
                    var return_v = this_param.WithProperties(properties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(435, 3941, 3996);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(435, 3837, 4008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(435, 3837, 4008);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new PortableExecutableReference WithProperties(MetadataReferenceProperties properties)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(435, 4385, 4662);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 4503, 4597) || true) && (properties == f_435_4521_4536(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(435, 4503, 4597);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 4570, 4582);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(435, 4503, 4597);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 4613, 4651);

                return f_435_4620_4650(this, properties);
                DynAbs.Tracing.TraceSender.TraceExitMethod(435, 4385, 4662);

                Microsoft.CodeAnalysis.MetadataReferenceProperties
                f_435_4521_4536(Microsoft.CodeAnalysis.PortableExecutableReference
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(435, 4521, 4536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_435_4620_4650(Microsoft.CodeAnalysis.PortableExecutableReference
                this_param, Microsoft.CodeAnalysis.MetadataReferenceProperties
                properties)
                {
                    var return_v = this_param.WithPropertiesImpl(properties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(435, 4620, 4650);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(435, 4385, 4662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(435, 4385, 4662);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override MetadataReference WithPropertiesImplReturningMetadataReference(MetadataReferenceProperties properties)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(435, 4674, 4875);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 4826, 4864);

                return f_435_4833_4863(this, properties);
                DynAbs.Tracing.TraceSender.TraceExitMethod(435, 4674, 4875);

                Microsoft.CodeAnalysis.PortableExecutableReference
                f_435_4833_4863(Microsoft.CodeAnalysis.PortableExecutableReference
                this_param, Microsoft.CodeAnalysis.MetadataReferenceProperties
                properties)
                {
                    var return_v = this_param.WithPropertiesImpl(properties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(435, 4833, 4863);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(435, 4674, 4875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(435, 4674, 4875);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract PortableExecutableReference WithPropertiesImpl(MetadataReferenceProperties properties);

        protected abstract Metadata GetMetadataImpl();

        internal Metadata GetMetadataNoCopy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(435, 7234, 7332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 7296, 7321);

                return f_435_7303_7320(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(435, 7234, 7332);

                Microsoft.CodeAnalysis.Metadata
                f_435_7303_7320(Microsoft.CodeAnalysis.PortableExecutableReference
                this_param)
                {
                    var return_v = this_param.GetMetadataImpl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(435, 7303, 7320);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(435, 7234, 7332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(435, 7234, 7332);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Metadata GetMetadata()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(435, 7917, 8016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 7971, 8005);

                return f_435_7978_8004(f_435_7978_7997(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(435, 7917, 8016);

                Microsoft.CodeAnalysis.Metadata
                f_435_7978_7997(Microsoft.CodeAnalysis.PortableExecutableReference
                this_param)
                {
                    var return_v = this_param.GetMetadataNoCopy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(435, 7978, 7997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Metadata
                f_435_7978_8004(Microsoft.CodeAnalysis.Metadata
                this_param)
                {
                    var return_v = this_param.Copy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(435, 7978, 8004);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(435, 7917, 8016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(435, 7917, 8016);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public MetadataId GetMetadataId()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(435, 8644, 8743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 8702, 8732);

                return f_435_8709_8731(f_435_8709_8728(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(435, 8644, 8743);

                Microsoft.CodeAnalysis.Metadata
                f_435_8709_8728(Microsoft.CodeAnalysis.PortableExecutableReference
                this_param)
                {
                    var return_v = this_param.GetMetadataNoCopy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(435, 8709, 8728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataId
                f_435_8709_8731(Microsoft.CodeAnalysis.Metadata
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(435, 8709, 8731);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(435, 8644, 8743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(435, 8644, 8743);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Diagnostic ExceptionToDiagnostic(Exception e, CommonMessageProvider messageProvider, Location location, string display, MetadataImageKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(435, 8755, 9863);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 8939, 9262) || true) && (e is BadImageFormatException)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(435, 8939, 9262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 9005, 9148);

                    int
                    errorCode = (DynAbs.Tracing.TraceSender.Conditional_F1(435, 9021, 9057) || (((kind == MetadataImageKind.Assembly) && DynAbs.Tracing.TraceSender.Conditional_F2(435, 9060, 9103)) || DynAbs.Tracing.TraceSender.Conditional_F3(435, 9106, 9147))) ? f_435_9060_9103(messageProvider) : f_435_9106_9147(messageProvider)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 9166, 9247);

                    return f_435_9173_9246(messageProvider, errorCode, location, display, f_435_9236_9245(e));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(435, 8939, 9262);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 9278, 9324);

                var
                fileNotFound = e as FileNotFoundException
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 9338, 9852) || true) && (fileNotFound != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(435, 9338, 9852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 9396, 9527);

                    return f_435_9403_9526(messageProvider, f_435_9436_9476(messageProvider), location, f_435_9488_9509(fileNotFound) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(435, 9488, 9525) ?? string.Empty));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(435, 9338, 9852);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(435, 9338, 9852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 9593, 9738);

                    int
                    errorCode = (DynAbs.Tracing.TraceSender.Conditional_F1(435, 9609, 9645) || (((kind == MetadataImageKind.Assembly) && DynAbs.Tracing.TraceSender.Conditional_F2(435, 9648, 9692)) || DynAbs.Tracing.TraceSender.Conditional_F3(435, 9695, 9737))) ? f_435_9648_9692(messageProvider) : f_435_9695_9737(messageProvider)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(435, 9756, 9837);

                    return f_435_9763_9836(messageProvider, errorCode, location, display, f_435_9826_9835(e));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(435, 9338, 9852);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(435, 8755, 9863);

                int
                f_435_9060_9103(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_InvalidAssemblyMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(435, 9060, 9103);
                    return return_v;
                }


                int
                f_435_9106_9147(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_InvalidModuleMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(435, 9106, 9147);
                    return return_v;
                }


                string
                f_435_9236_9245(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(435, 9236, 9245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_435_9173_9246(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(435, 9173, 9246);
                    return return_v;
                }


                int
                f_435_9436_9476(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_MetadataFileNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(435, 9436, 9476);
                    return return_v;
                }


                string?
                f_435_9488_9509(System.IO.FileNotFoundException
                this_param)
                {
                    var return_v = this_param.FileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(435, 9488, 9509);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_435_9403_9526(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(435, 9403, 9526);
                    return return_v;
                }


                int
                f_435_9648_9692(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_ErrorOpeningAssemblyFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(435, 9648, 9692);
                    return return_v;
                }


                int
                f_435_9695_9737(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_ErrorOpeningModuleFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(435, 9695, 9737);
                    return return_v;
                }


                string
                f_435_9826_9835(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(435, 9826, 9835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_435_9763_9836(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(435, 9763, 9836);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(435, 8755, 9863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(435, 8755, 9863);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PortableExecutableReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(435, 500, 9870);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(435, 500, 9870);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(435, 500, 9870);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(435, 500, 9870);

        static Microsoft.CodeAnalysis.MetadataReferenceProperties
        f_435_910_920_C(Microsoft.CodeAnalysis.MetadataReferenceProperties
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(435, 695, 1034);
            return return_v;
        }

    }
}
