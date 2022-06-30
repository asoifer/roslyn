// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Reflection.PortableExecutable;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public abstract class MetadataReference
    {
        public MetadataReferenceProperties Properties { get; }

        protected MetadataReference(MetadataReferenceProperties properties)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(431, 933, 1065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 1025, 1054);

                this.Properties = properties;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(431, 933, 1065);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(431, 933, 1065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(431, 933, 1065);
            }
        }

        public virtual string? Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(431, 1233, 1253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 1239, 1251);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(431, 1233, 1253);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(431, 1200, 1255);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(431, 1200, 1255);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool IsUnresolved
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(431, 1445, 1466);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 1451, 1464);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(431, 1445, 1466);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(431, 1386, 1477);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(431, 1386, 1477);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public MetadataReference WithAliases(IEnumerable<string> aliases)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(431, 1790, 1947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 1880, 1936);

                return f_431_1887_1935(this, f_431_1899_1934(aliases));
                DynAbs.Tracing.TraceSender.TraceExitMethod(431, 1790, 1947);

                System.Collections.Immutable.ImmutableArray<string>
                f_431_1899_1934(System.Collections.Generic.IEnumerable<string>
                items)
                {
                    var return_v = ImmutableArray.CreateRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 1899, 1934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_431_1887_1935(Microsoft.CodeAnalysis.MetadataReference
                this_param, System.Collections.Immutable.ImmutableArray<string>
                aliases)
                {
                    var return_v = this_param.WithAliases(aliases);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 1887, 1935);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(431, 1790, 1947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(431, 1790, 1947);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public MetadataReference WithEmbedInteropTypes(bool value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(431, 2324, 2481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 2407, 2470);

                return f_431_2414_2469(this, f_431_2429_2439().WithEmbedInteropTypes(value));
                DynAbs.Tracing.TraceSender.TraceExitMethod(431, 2324, 2481);

                Microsoft.CodeAnalysis.MetadataReferenceProperties
                f_431_2429_2439()
                {
                    var return_v = Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(431, 2429, 2439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_431_2414_2469(Microsoft.CodeAnalysis.MetadataReference
                this_param, Microsoft.CodeAnalysis.MetadataReferenceProperties
                properties)
                {
                    var return_v = this_param.WithProperties(properties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 2414, 2469);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(431, 2324, 2481);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(431, 2324, 2481);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public MetadataReference WithAliases(ImmutableArray<string> aliases)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(431, 2794, 2953);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 2887, 2942);

                return f_431_2894_2941(this, f_431_2909_2919().WithAliases(aliases));
                DynAbs.Tracing.TraceSender.TraceExitMethod(431, 2794, 2953);

                Microsoft.CodeAnalysis.MetadataReferenceProperties
                f_431_2909_2919()
                {
                    var return_v = Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(431, 2909, 2919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_431_2894_2941(Microsoft.CodeAnalysis.MetadataReference
                this_param, Microsoft.CodeAnalysis.MetadataReferenceProperties
                properties)
                {
                    var return_v = this_param.WithProperties(properties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 2894, 2941);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(431, 2794, 2953);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(431, 2794, 2953);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public MetadataReference WithProperties(MetadataReferenceProperties properties)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(431, 3329, 3618);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 3433, 3527) || true) && (properties == f_431_3451_3466(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(431, 3433, 3527);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 3500, 3512);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(431, 3433, 3527);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 3543, 3607);

                return f_431_3550_3606(this, properties);
                DynAbs.Tracing.TraceSender.TraceExitMethod(431, 3329, 3618);

                Microsoft.CodeAnalysis.MetadataReferenceProperties
                f_431_3451_3466(Microsoft.CodeAnalysis.MetadataReference
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(431, 3451, 3466);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_431_3550_3606(Microsoft.CodeAnalysis.MetadataReference
                this_param, Microsoft.CodeAnalysis.MetadataReferenceProperties
                properties)
                {
                    var return_v = this_param.WithPropertiesImplReturningMetadataReference(properties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 3550, 3606);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(431, 3329, 3618);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(431, 3329, 3618);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract MetadataReference WithPropertiesImplReturningMetadataReference(MetadataReferenceProperties properties);

        public static PortableExecutableReference CreateFromImage(
                    ImmutableArray<byte> peImage,
                    MetadataReferenceProperties properties = default,
                    DocumentationProvider? documentation = null,
                    string? filePath = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(431, 5969, 6432);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 6254, 6311);

                var
                metadata = f_431_6269_6310(peImage)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 6325, 6421);

                return f_431_6332_6420(metadata, properties, documentation, filePath, display: null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(431, 5969, 6432);

                Microsoft.CodeAnalysis.AssemblyMetadata
                f_431_6269_6310(System.Collections.Immutable.ImmutableArray<byte>
                peImage)
                {
                    var return_v = AssemblyMetadata.CreateFromImage(peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 6269, 6310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataImageReference
                f_431_6332_6420(Microsoft.CodeAnalysis.AssemblyMetadata
                metadata, Microsoft.CodeAnalysis.MetadataReferenceProperties
                properties, Microsoft.CodeAnalysis.DocumentationProvider?
                documentation, string?
                filePath, string?
                display)
                {
                    var return_v = new Microsoft.CodeAnalysis.MetadataImageReference((Microsoft.CodeAnalysis.Metadata)metadata, properties, documentation, filePath, display: display);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 6332, 6420);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(431, 5969, 6432);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(431, 5969, 6432);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static PortableExecutableReference CreateFromImage(
                    IEnumerable<byte> peImage,
                    MetadataReferenceProperties properties = default,
                    DocumentationProvider? documentation = null,
                    string? filePath = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(431, 8403, 8863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 8685, 8742);

                var
                metadata = f_431_8700_8741(peImage)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 8756, 8852);

                return f_431_8763_8851(metadata, properties, documentation, filePath, display: null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(431, 8403, 8863);

                Microsoft.CodeAnalysis.AssemblyMetadata
                f_431_8700_8741(System.Collections.Generic.IEnumerable<byte>
                peImage)
                {
                    var return_v = AssemblyMetadata.CreateFromImage(peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 8700, 8741);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataImageReference
                f_431_8763_8851(Microsoft.CodeAnalysis.AssemblyMetadata
                metadata, Microsoft.CodeAnalysis.MetadataReferenceProperties
                properties, Microsoft.CodeAnalysis.DocumentationProvider?
                documentation, string?
                filePath, string?
                display)
                {
                    var return_v = new Microsoft.CodeAnalysis.MetadataImageReference((Microsoft.CodeAnalysis.Metadata)metadata, properties, documentation, filePath, display: display);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 8763, 8851);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(431, 8403, 8863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(431, 8403, 8863);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static PortableExecutableReference CreateFromStream(
                    Stream peStream,
                    MetadataReferenceProperties properties = default,
                    DocumentationProvider? documentation = null,
                    string? filePath = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(431, 11153, 11698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 11479, 11575);

                var
                metadata = f_431_11494_11574(peStream, PEStreamOptions.PrefetchEntireImage)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 11591, 11687);

                return f_431_11598_11686(metadata, properties, documentation, filePath, display: null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(431, 11153, 11698);

                Microsoft.CodeAnalysis.AssemblyMetadata
                f_431_11494_11574(System.IO.Stream
                peStream, System.Reflection.PortableExecutable.PEStreamOptions
                options)
                {
                    var return_v = AssemblyMetadata.CreateFromStream(peStream, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 11494, 11574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataImageReference
                f_431_11598_11686(Microsoft.CodeAnalysis.AssemblyMetadata
                metadata, Microsoft.CodeAnalysis.MetadataReferenceProperties
                properties, Microsoft.CodeAnalysis.DocumentationProvider?
                documentation, string?
                filePath, string?
                display)
                {
                    var return_v = new Microsoft.CodeAnalysis.MetadataImageReference((Microsoft.CodeAnalysis.Metadata)metadata, properties, documentation, filePath, display: display);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 11598, 11686);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(431, 11153, 11698);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(431, 11153, 11698);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static PortableExecutableReference CreateFromFile(
                    string path,
                    MetadataReferenceProperties properties = default,
                    DocumentationProvider? documentation = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(431, 13600, 14551);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 13829, 13879);

                var
                peStream = f_431_13844_13878(path)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 13961, 14053);

                var
                module = f_431_13974_14052(peStream, PEStreamOptions.PrefetchEntireImage)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 14069, 14255) || true) && (properties.Kind == MetadataImageKind.Module)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(431, 14069, 14255);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 14150, 14240);

                    return f_431_14157_14239(module, properties, documentation, path, display: null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(431, 14069, 14255);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 14357, 14426);

                var
                assemblyMetadata = f_431_14380_14425(module, path)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 14440, 14540);

                return f_431_14447_14539(assemblyMetadata, properties, documentation, path, display: null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(431, 13600, 14551);

                System.IO.Stream
                f_431_13844_13878(string
                path)
                {
                    var return_v = FileUtilities.OpenFileStream(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 13844, 13878);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ModuleMetadata
                f_431_13974_14052(System.IO.Stream
                peStream, System.Reflection.PortableExecutable.PEStreamOptions
                options)
                {
                    var return_v = ModuleMetadata.CreateFromStream(peStream, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 13974, 14052);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataImageReference
                f_431_14157_14239(Microsoft.CodeAnalysis.ModuleMetadata
                metadata, Microsoft.CodeAnalysis.MetadataReferenceProperties
                properties, Microsoft.CodeAnalysis.DocumentationProvider?
                documentation, string
                filePath, string?
                display)
                {
                    var return_v = new Microsoft.CodeAnalysis.MetadataImageReference((Microsoft.CodeAnalysis.Metadata)metadata, properties, documentation, filePath, display: display);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 14157, 14239);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyMetadata
                f_431_14380_14425(Microsoft.CodeAnalysis.ModuleMetadata
                manifestModule, string
                path)
                {
                    var return_v = AssemblyMetadata.CreateFromFile(manifestModule, path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 14380, 14425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataImageReference
                f_431_14447_14539(Microsoft.CodeAnalysis.AssemblyMetadata
                metadata, Microsoft.CodeAnalysis.MetadataReferenceProperties
                properties, Microsoft.CodeAnalysis.DocumentationProvider?
                documentation, string
                filePath, string?
                display)
                {
                    var return_v = new Microsoft.CodeAnalysis.MetadataImageReference((Microsoft.CodeAnalysis.Metadata)metadata, properties, documentation, filePath, display: display);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 14447, 14539);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(431, 13600, 14551);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(431, 13600, 14551);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Obsolete("Use CreateFromFile(assembly.Location) instead", error: true)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static MetadataReference CreateFromAssembly(Assembly assembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(431, 15414, 15700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 15645, 15689);

                return f_431_15652_15688(assembly);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(431, 15414, 15700);

                Microsoft.CodeAnalysis.MetadataReference
                f_431_15652_15688(System.Reflection.Assembly
                assembly)
                {
                    var return_v = CreateFromAssemblyInternal(assembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 15652, 15688);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(431, 15414, 15700);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(431, 15414, 15700);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static MetadataReference CreateFromAssemblyInternal(Assembly assembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(431, 15712, 15909);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 15816, 15898);

                return f_431_15823_15897(assembly, default(MetadataReferenceProperties));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(431, 15712, 15909);

                Microsoft.CodeAnalysis.PortableExecutableReference
                f_431_15823_15897(System.Reflection.Assembly
                assembly, Microsoft.CodeAnalysis.MetadataReferenceProperties
                properties)
                {
                    var return_v = CreateFromAssemblyInternal(assembly, properties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 15823, 15897);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(431, 15712, 15909);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(431, 15712, 15909);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Obsolete("Use CreateFromFile(assembly.Location) instead", error: true)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static MetadataReference CreateFromAssembly(
                    Assembly assembly,
                    MetadataReferenceProperties properties,
                    DocumentationProvider? documentation = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(431, 17171, 17609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 17527, 17598);

                return f_431_17534_17597(assembly, properties, documentation);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(431, 17171, 17609);

                Microsoft.CodeAnalysis.PortableExecutableReference
                f_431_17534_17597(System.Reflection.Assembly
                assembly, Microsoft.CodeAnalysis.MetadataReferenceProperties
                properties, Microsoft.CodeAnalysis.DocumentationProvider?
                documentation)
                {
                    var return_v = CreateFromAssemblyInternal(assembly, properties, documentation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 17534, 17597);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(431, 17171, 17609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(431, 17171, 17609);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PortableExecutableReference CreateFromAssemblyInternal(
                    Assembly assembly,
                    MetadataReferenceProperties properties,
                    DocumentationProvider? documentation = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(431, 17621, 19265);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 18045, 18164) || true) && (assembly == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(431, 18045, 18164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 18099, 18149);

                    throw f_431_18105_18148(nameof(assembly));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(431, 18045, 18164);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 18180, 18343) || true) && (f_431_18184_18202(assembly))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(431, 18180, 18343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 18236, 18328);

                    throw f_431_18242_18327(f_431_18268_18326());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(431, 18180, 18343);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 18359, 18564) || true) && (properties.Kind != MetadataImageKind.Assembly)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(431, 18359, 18564);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 18442, 18549);

                    throw f_431_18448_18548(f_431_18470_18527(), nameof(properties));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(431, 18359, 18564);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 18580, 18616);

                string
                location = f_431_18598_18615(assembly)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 18630, 18813) || true) && (f_431_18634_18664(location))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(431, 18630, 18813);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 18698, 18798);

                    throw f_431_18704_18797(f_431_18730_18796());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(431, 18630, 18813);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 18829, 18886);

                Stream
                peStream = f_431_18847_18885(location)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 19083, 19142);

                var
                metadata = f_431_19098_19141(peStream)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 19158, 19254);

                return f_431_19165_19253(metadata, properties, documentation, location, display: null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(431, 17621, 19265);

                System.ArgumentNullException
                f_431_18105_18148(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 18105, 18148);
                    return return_v;
                }


                bool
                f_431_18184_18202(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.IsDynamic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(431, 18184, 18202);
                    return return_v;
                }


                string
                f_431_18268_18326()
                {
                    var return_v = CodeAnalysisResources.CantCreateReferenceToDynamicAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(431, 18268, 18326);
                    return return_v;
                }


                System.NotSupportedException
                f_431_18242_18327(string
                message)
                {
                    var return_v = new System.NotSupportedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 18242, 18327);
                    return return_v;
                }


                string
                f_431_18470_18527()
                {
                    var return_v = CodeAnalysisResources.CantCreateModuleReferenceToAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(431, 18470, 18527);
                    return return_v;
                }


                System.ArgumentException
                f_431_18448_18548(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 18448, 18548);
                    return return_v;
                }


                string
                f_431_18598_18615(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(431, 18598, 18615);
                    return return_v;
                }


                bool
                f_431_18634_18664(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 18634, 18664);
                    return return_v;
                }


                string
                f_431_18730_18796()
                {
                    var return_v = CodeAnalysisResources.CantCreateReferenceToAssemblyWithoutLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(431, 18730, 18796);
                    return return_v;
                }


                System.NotSupportedException
                f_431_18704_18797(string
                message)
                {
                    var return_v = new System.NotSupportedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 18704, 18797);
                    return return_v;
                }


                System.IO.Stream
                f_431_18847_18885(string
                path)
                {
                    var return_v = FileUtilities.OpenFileStream(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 18847, 18885);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyMetadata
                f_431_19098_19141(System.IO.Stream
                peStream)
                {
                    var return_v = AssemblyMetadata.CreateFromStream(peStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 19098, 19141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataImageReference
                f_431_19165_19253(Microsoft.CodeAnalysis.AssemblyMetadata
                metadata, Microsoft.CodeAnalysis.MetadataReferenceProperties
                properties, Microsoft.CodeAnalysis.DocumentationProvider?
                documentation, string
                filePath, string?
                display)
                {
                    var return_v = new Microsoft.CodeAnalysis.MetadataImageReference((Microsoft.CodeAnalysis.Metadata)metadata, properties, documentation, filePath, display: display);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 19165, 19253);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(431, 17621, 19265);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(431, 17621, 19265);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasMetadata(Assembly assembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(431, 19277, 19435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(431, 19353, 19424);

                return f_431_19360_19379_M(!assembly.IsDynamic) && (DynAbs.Tracing.TraceSender.Expression_True(431, 19360, 19423) && !f_431_19384_19423(f_431_19405_19422(assembly)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(431, 19277, 19435);

                bool
                f_431_19360_19379_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(431, 19360, 19379);
                    return return_v;
                }


                string
                f_431_19405_19422(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(431, 19405, 19422);
                    return return_v;
                }


                bool
                f_431_19384_19423(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(431, 19384, 19423);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(431, 19277, 19435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(431, 19277, 19435);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MetadataReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(431, 811, 19442);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(431, 811, 19442);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(431, 811, 19442);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(431, 811, 19442);
    }
}
