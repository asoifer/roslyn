// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Ids of well known runtime types.
    /// Values should not intersect with SpecialType enum!
    /// </summary>
    /// <remarks></remarks>
    internal enum WellKnownType
    {
        // Value 0 represents an unknown type
        Unknown = SpecialType.None,

        First = SpecialType.Count + 1,

        // The following type ids should be in sync with names in WellKnownTypes.metadataNames array.
        System_Math = First,
        System_Array,
        System_Attribute,
        System_CLSCompliantAttribute,
        System_Convert,
        System_Exception,
        System_FlagsAttribute,
        System_FormattableString,
        System_Guid,
        System_IFormattable,
        System_RuntimeTypeHandle,
        System_RuntimeFieldHandle,
        System_RuntimeMethodHandle,
        System_MarshalByRefObject,
        System_Type,
        System_Reflection_AssemblyKeyFileAttribute,
        System_Reflection_AssemblyKeyNameAttribute,
        System_Reflection_MethodInfo,
        System_Reflection_ConstructorInfo,
        System_Reflection_MethodBase,
        System_Reflection_FieldInfo,
        System_Reflection_MemberInfo,
        System_Reflection_Missing,
        System_Runtime_CompilerServices_FormattableStringFactory,
        System_Runtime_CompilerServices_RuntimeHelpers,
        System_Runtime_ExceptionServices_ExceptionDispatchInfo,
        System_Runtime_InteropServices_StructLayoutAttribute,
        System_Runtime_InteropServices_UnknownWrapper,
        System_Runtime_InteropServices_DispatchWrapper,
        System_Runtime_InteropServices_CallingConvention,
        System_Runtime_InteropServices_ClassInterfaceAttribute,
        System_Runtime_InteropServices_ClassInterfaceType,
        System_Runtime_InteropServices_CoClassAttribute,
        System_Runtime_InteropServices_ComAwareEventInfo,
        System_Runtime_InteropServices_ComEventInterfaceAttribute,
        System_Runtime_InteropServices_ComInterfaceType,
        System_Runtime_InteropServices_ComSourceInterfacesAttribute,
        System_Runtime_InteropServices_ComVisibleAttribute,
        System_Runtime_InteropServices_DispIdAttribute,
        System_Runtime_InteropServices_GuidAttribute,
        System_Runtime_InteropServices_InterfaceTypeAttribute,
        System_Runtime_InteropServices_Marshal,
        System_Runtime_InteropServices_TypeIdentifierAttribute,
        System_Runtime_InteropServices_BestFitMappingAttribute,
        System_Runtime_InteropServices_DefaultParameterValueAttribute,
        System_Runtime_InteropServices_LCIDConversionAttribute,
        System_Runtime_InteropServices_UnmanagedFunctionPointerAttribute,
        System_Activator,
        System_Threading_Tasks_Task,
        System_Threading_Tasks_Task_T,
        System_Threading_Interlocked,
        System_Threading_Monitor,
        System_Threading_Thread,
        Microsoft_CSharp_RuntimeBinder_Binder,
        Microsoft_CSharp_RuntimeBinder_CSharpArgumentInfo,
        Microsoft_CSharp_RuntimeBinder_CSharpArgumentInfoFlags,
        Microsoft_CSharp_RuntimeBinder_CSharpBinderFlags,
        Microsoft_VisualBasic_CallType,
        Microsoft_VisualBasic_Embedded,
        Microsoft_VisualBasic_CompilerServices_Conversions,
        Microsoft_VisualBasic_CompilerServices_Operators,
        Microsoft_VisualBasic_CompilerServices_NewLateBinding,
        Microsoft_VisualBasic_CompilerServices_EmbeddedOperators,
        Microsoft_VisualBasic_CompilerServices_StandardModuleAttribute,
        Microsoft_VisualBasic_CompilerServices_Utils,
        Microsoft_VisualBasic_CompilerServices_LikeOperator,
        Microsoft_VisualBasic_CompilerServices_ProjectData,
        Microsoft_VisualBasic_CompilerServices_ObjectFlowControl,
        Microsoft_VisualBasic_CompilerServices_ObjectFlowControl_ForLoopControl,
        Microsoft_VisualBasic_CompilerServices_StaticLocalInitFlag,
        Microsoft_VisualBasic_CompilerServices_StringType,
        Microsoft_VisualBasic_CompilerServices_IncompleteInitialization,
        Microsoft_VisualBasic_CompilerServices_Versioned,
        Microsoft_VisualBasic_CompareMethod,
        Microsoft_VisualBasic_Strings,
        Microsoft_VisualBasic_ErrObject,
        Microsoft_VisualBasic_FileSystem,
        Microsoft_VisualBasic_ApplicationServices_ApplicationBase,
        Microsoft_VisualBasic_ApplicationServices_WindowsFormsApplicationBase,
        Microsoft_VisualBasic_Information,
        Microsoft_VisualBasic_Interaction,

        // standard Func delegates - must be ordered by arity
        System_Func_T,
        System_Func_T2,
        System_Func_T3,
        System_Func_T4,
        System_Func_T5,
        System_Func_T6,
        System_Func_T7,
        System_Func_T8,
        System_Func_T9,
        System_Func_T10,
        System_Func_T11,
        System_Func_T12,
        System_Func_T13,
        System_Func_T14,
        System_Func_T15,
        System_Func_T16,
        System_Func_T17,
        System_Func_TMax = System_Func_T17,

        // standard Action delegates - must be ordered by arity
        System_Action,
        System_Action_T,
        System_Action_T2,
        System_Action_T3,
        System_Action_T4,
        System_Action_T5,
        System_Action_T6,
        System_Action_T7,
        System_Action_T8,
        System_Action_T9,
        System_Action_T10,
        System_Action_T11,
        System_Action_T12,
        System_Action_T13,
        System_Action_T14,
        System_Action_T15,
        System_Action_T16,
        System_Action_TMax = System_Action_T16,

        System_AttributeUsageAttribute,
        System_ParamArrayAttribute,
        System_NonSerializedAttribute,
        System_STAThreadAttribute,
        System_Reflection_DefaultMemberAttribute,
        System_Runtime_CompilerServices_DateTimeConstantAttribute,
        System_Runtime_CompilerServices_DecimalConstantAttribute,
        System_Runtime_CompilerServices_IUnknownConstantAttribute,
        System_Runtime_CompilerServices_IDispatchConstantAttribute,
        System_Runtime_CompilerServices_ExtensionAttribute,
        System_Runtime_CompilerServices_INotifyCompletion,
        System_Runtime_CompilerServices_InternalsVisibleToAttribute,
        System_Runtime_CompilerServices_CompilerGeneratedAttribute,
        System_Runtime_CompilerServices_AccessedThroughPropertyAttribute,
        System_Runtime_CompilerServices_CompilationRelaxationsAttribute,
        System_Runtime_CompilerServices_RuntimeCompatibilityAttribute,
        System_Runtime_CompilerServices_UnsafeValueTypeAttribute,
        System_Runtime_CompilerServices_FixedBufferAttribute,
        System_Runtime_CompilerServices_DynamicAttribute,
        System_Runtime_CompilerServices_CallSiteBinder,
        System_Runtime_CompilerServices_CallSite,
        System_Runtime_CompilerServices_CallSite_T,

        System_Runtime_InteropServices_WindowsRuntime_EventRegistrationToken,
        System_Runtime_InteropServices_WindowsRuntime_EventRegistrationTokenTable_T,
        System_Runtime_InteropServices_WindowsRuntime_WindowsRuntimeMarshal,

        Windows_Foundation_IAsyncAction,
        Windows_Foundation_IAsyncActionWithProgress_T,
        Windows_Foundation_IAsyncOperation_T,
        Windows_Foundation_IAsyncOperationWithProgress_T2,

        System_Diagnostics_Debugger,
        System_Diagnostics_DebuggerDisplayAttribute,
        System_Diagnostics_DebuggerNonUserCodeAttribute,
        System_Diagnostics_DebuggerHiddenAttribute,
        System_Diagnostics_DebuggerBrowsableAttribute,
        System_Diagnostics_DebuggerStepThroughAttribute,
        System_Diagnostics_DebuggerBrowsableState,
        System_Diagnostics_DebuggableAttribute,
        System_Diagnostics_DebuggableAttribute__DebuggingModes,

        System_ComponentModel_DesignerSerializationVisibilityAttribute,

        System_IEquatable_T,

        System_Collections_IList,
        System_Collections_ICollection,
        System_Collections_Generic_EqualityComparer_T,
        System_Collections_Generic_List_T,
        System_Collections_Generic_IDictionary_KV,
        System_Collections_Generic_IReadOnlyDictionary_KV,
        System_Collections_ObjectModel_Collection_T,
        System_Collections_ObjectModel_ReadOnlyCollection_T,
        System_Collections_Specialized_INotifyCollectionChanged,
        System_ComponentModel_INotifyPropertyChanged,
        System_ComponentModel_EditorBrowsableAttribute,
        System_ComponentModel_EditorBrowsableState,

        System_Linq_Enumerable,
        System_Linq_Expressions_Expression,
        System_Linq_Expressions_Expression_T,
        System_Linq_Expressions_ParameterExpression,
        System_Linq_Expressions_ElementInit,
        System_Linq_Expressions_MemberBinding,
        System_Linq_Expressions_ExpressionType,
        System_Linq_IQueryable,
        System_Linq_IQueryable_T,

        System_Xml_Linq_Extensions,
        System_Xml_Linq_XAttribute,
        System_Xml_Linq_XCData,
        System_Xml_Linq_XComment,
        System_Xml_Linq_XContainer,
        System_Xml_Linq_XDeclaration,
        System_Xml_Linq_XDocument,
        System_Xml_Linq_XElement,
        System_Xml_Linq_XName,
        System_Xml_Linq_XNamespace,
        System_Xml_Linq_XObject,
        System_Xml_Linq_XProcessingInstruction,

        System_Security_UnverifiableCodeAttribute,
        System_Security_Permissions_SecurityAction,
        System_Security_Permissions_SecurityAttribute,
        System_Security_Permissions_SecurityPermissionAttribute,

        System_NotSupportedException,

        System_Runtime_CompilerServices_ICriticalNotifyCompletion,
        System_Runtime_CompilerServices_IAsyncStateMachine,
        System_Runtime_CompilerServices_AsyncVoidMethodBuilder,
        System_Runtime_CompilerServices_AsyncTaskMethodBuilder,
        System_Runtime_CompilerServices_AsyncTaskMethodBuilder_T,
        System_Runtime_CompilerServices_AsyncStateMachineAttribute,
        System_Runtime_CompilerServices_IteratorStateMachineAttribute,

        System_Windows_Forms_Form,
        System_Windows_Forms_Application,

        System_Environment,

        System_Runtime_GCLatencyMode,
        System_IFormatProvider,

        CSharp7Sentinel = System_IFormatProvider, // all types that were known before CSharp7 should remain above this sentinel

        System_ValueTuple,
        System_ValueTuple_T1,
        System_ValueTuple_T2,
        System_ValueTuple_T3,

        ExtSentinel, // Not a real type, just a marker for types above 255 and strictly below 512

        System_ValueTuple_T4,
        System_ValueTuple_T5,
        System_ValueTuple_T6,
        System_ValueTuple_T7,
        System_ValueTuple_TRest,

        System_Runtime_CompilerServices_TupleElementNamesAttribute,

        Microsoft_CodeAnalysis_Runtime_Instrumentation,
        System_Runtime_CompilerServices_NullableAttribute,
        System_Runtime_CompilerServices_NullableContextAttribute,
        System_Runtime_CompilerServices_NullablePublicOnlyAttribute,
        System_Runtime_CompilerServices_ReferenceAssemblyAttribute,

        System_Runtime_CompilerServices_IsReadOnlyAttribute,
        System_Runtime_CompilerServices_IsByRefLikeAttribute,
        System_Runtime_InteropServices_InAttribute,
        System_ObsoleteAttribute,
        System_Span_T,
        System_ReadOnlySpan_T,
        System_Runtime_InteropServices_UnmanagedType,
        System_Runtime_CompilerServices_IsUnmanagedAttribute,

        Microsoft_VisualBasic_Conversion,
        System_Runtime_CompilerServices_NonNullTypesAttribute,
        System_AttributeTargets,
        Microsoft_CodeAnalysis_EmbeddedAttribute,
        System_Runtime_CompilerServices_ITuple,

        System_Index,
        System_Range,

        System_Runtime_CompilerServices_AsyncIteratorStateMachineAttribute,
        System_IAsyncDisposable,
        System_Collections_Generic_IAsyncEnumerable_T,
        System_Collections_Generic_IAsyncEnumerator_T,
        System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T,
        System_Threading_Tasks_Sources_ValueTaskSourceStatus,
        System_Threading_Tasks_Sources_ValueTaskSourceOnCompletedFlags,
        System_Threading_Tasks_Sources_IValueTaskSource_T,
        System_Threading_Tasks_Sources_IValueTaskSource,
        System_Threading_Tasks_ValueTask_T,
        System_Threading_Tasks_ValueTask,
        System_Runtime_CompilerServices_AsyncIteratorMethodBuilder,
        System_Threading_CancellationToken,
        System_Threading_CancellationTokenSource,

        System_InvalidOperationException,
        System_Runtime_CompilerServices_SwitchExpressionException,
        System_Collections_Generic_IEqualityComparer_T,
        System_Runtime_CompilerServices_NativeIntegerAttribute,

        System_Runtime_CompilerServices_IsExternalInit,
        System_Runtime_InteropServices_OutAttribute,

        System_Text_StringBuilder,

        NextAvailable,

        // Remember to update the AllWellKnownTypes tests when making changes here
    }
    internal static class WellKnownTypes
    {
        internal const int
        Count = WellKnownType.NextAvailable - WellKnownType.First
        ;

        private static readonly string[] s_metadataNames;

        private static readonly Dictionary<string, WellKnownType> s_nameToTypeIdMap;

        static WellKnownTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(45, 28262, 28616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 13844, 13901);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 14200, 28109);
                s_metadataNames = new string[]
                        {
            "System.Math",
            "System.Array",
            "System.Attribute",
            "System.CLSCompliantAttribute",
            "System.Convert",
            "System.Exception",
            "System.FlagsAttribute",
            "System.FormattableString",
            "System.Guid",
            "System.IFormattable",
            "System.RuntimeTypeHandle",
            "System.RuntimeFieldHandle",
            "System.RuntimeMethodHandle",
            "System.MarshalByRefObject",
            "System.Type",
            "System.Reflection.AssemblyKeyFileAttribute",
            "System.Reflection.AssemblyKeyNameAttribute",
            "System.Reflection.MethodInfo",
            "System.Reflection.ConstructorInfo",
            "System.Reflection.MethodBase",
            "System.Reflection.FieldInfo",
            "System.Reflection.MemberInfo",
            "System.Reflection.Missing",
            "System.Runtime.CompilerServices.FormattableStringFactory",
            "System.Runtime.CompilerServices.RuntimeHelpers",
            "System.Runtime.ExceptionServices.ExceptionDispatchInfo",
            "System.Runtime.InteropServices.StructLayoutAttribute",
            "System.Runtime.InteropServices.UnknownWrapper",
            "System.Runtime.InteropServices.DispatchWrapper",
            "System.Runtime.InteropServices.CallingConvention",
            "System.Runtime.InteropServices.ClassInterfaceAttribute",
            "System.Runtime.InteropServices.ClassInterfaceType",
            "System.Runtime.InteropServices.CoClassAttribute",
            "System.Runtime.InteropServices.ComAwareEventInfo",
            "System.Runtime.InteropServices.ComEventInterfaceAttribute",
            "System.Runtime.InteropServices.ComInterfaceType",
            "System.Runtime.InteropServices.ComSourceInterfacesAttribute",
            "System.Runtime.InteropServices.ComVisibleAttribute",
            "System.Runtime.InteropServices.DispIdAttribute",
            "System.Runtime.InteropServices.GuidAttribute",
            "System.Runtime.InteropServices.InterfaceTypeAttribute",
            "System.Runtime.InteropServices.Marshal",
            "System.Runtime.InteropServices.TypeIdentifierAttribute",
            "System.Runtime.InteropServices.BestFitMappingAttribute",
            "System.Runtime.InteropServices.DefaultParameterValueAttribute",
            "System.Runtime.InteropServices.LCIDConversionAttribute",
            "System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute",
            "System.Activator",
            "System.Threading.Tasks.Task",
            "System.Threading.Tasks.Task`1",
            "System.Threading.Interlocked",
            "System.Threading.Monitor",
            "System.Threading.Thread",
            "Microsoft.CSharp.RuntimeBinder.Binder",
            "Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo",
            "Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags",
            "Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags",
            "Microsoft.VisualBasic.CallType",
            "Microsoft.VisualBasic.Embedded",
            "Microsoft.VisualBasic.CompilerServices.Conversions",
            "Microsoft.VisualBasic.CompilerServices.Operators",
            "Microsoft.VisualBasic.CompilerServices.NewLateBinding",
            "Microsoft.VisualBasic.CompilerServices.EmbeddedOperators",
            "Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute",
            "Microsoft.VisualBasic.CompilerServices.Utils",
            "Microsoft.VisualBasic.CompilerServices.LikeOperator",
            "Microsoft.VisualBasic.CompilerServices.ProjectData",
            "Microsoft.VisualBasic.CompilerServices.ObjectFlowControl",
            "Microsoft.VisualBasic.CompilerServices.ObjectFlowControl+ForLoopControl",
            "Microsoft.VisualBasic.CompilerServices.StaticLocalInitFlag",
            "Microsoft.VisualBasic.CompilerServices.StringType",
            "Microsoft.VisualBasic.CompilerServices.IncompleteInitialization",
            "Microsoft.VisualBasic.CompilerServices.Versioned",
            "Microsoft.VisualBasic.CompareMethod",
            "Microsoft.VisualBasic.Strings",
            "Microsoft.VisualBasic.ErrObject",
            "Microsoft.VisualBasic.FileSystem",
            "Microsoft.VisualBasic.ApplicationServices.ApplicationBase",
            "Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase",
            "Microsoft.VisualBasic.Information",
            "Microsoft.VisualBasic.Interaction",

            "System.Func`1",
            "System.Func`2",
            "System.Func`3",
            "System.Func`4",
            "System.Func`5",
            "System.Func`6",
            "System.Func`7",
            "System.Func`8",
            "System.Func`9",
            "System.Func`10",
            "System.Func`11",
            "System.Func`12",
            "System.Func`13",
            "System.Func`14",
            "System.Func`15",
            "System.Func`16",
            "System.Func`17",
            "System.Action",
            "System.Action`1",
            "System.Action`2",
            "System.Action`3",
            "System.Action`4",
            "System.Action`5",
            "System.Action`6",
            "System.Action`7",
            "System.Action`8",
            "System.Action`9",
            "System.Action`10",
            "System.Action`11",
            "System.Action`12",
            "System.Action`13",
            "System.Action`14",
            "System.Action`15",
            "System.Action`16",

            "System.AttributeUsageAttribute",
            "System.ParamArrayAttribute",
            "System.NonSerializedAttribute",
            "System.STAThreadAttribute",
            "System.Reflection.DefaultMemberAttribute",
            "System.Runtime.CompilerServices.DateTimeConstantAttribute",
            "System.Runtime.CompilerServices.DecimalConstantAttribute",
            "System.Runtime.CompilerServices.IUnknownConstantAttribute",
            "System.Runtime.CompilerServices.IDispatchConstantAttribute",
            "System.Runtime.CompilerServices.ExtensionAttribute",
            "System.Runtime.CompilerServices.INotifyCompletion",
            "System.Runtime.CompilerServices.InternalsVisibleToAttribute",
            "System.Runtime.CompilerServices.CompilerGeneratedAttribute",
            "System.Runtime.CompilerServices.AccessedThroughPropertyAttribute",
            "System.Runtime.CompilerServices.CompilationRelaxationsAttribute",
            "System.Runtime.CompilerServices.RuntimeCompatibilityAttribute",
            "System.Runtime.CompilerServices.UnsafeValueTypeAttribute",
            "System.Runtime.CompilerServices.FixedBufferAttribute",
            "System.Runtime.CompilerServices.DynamicAttribute",
            "System.Runtime.CompilerServices.CallSiteBinder",
            "System.Runtime.CompilerServices.CallSite",
            "System.Runtime.CompilerServices.CallSite`1",

            "System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken",
            "System.Runtime.InteropServices.WindowsRuntime.EventRegistrationTokenTable`1",
            "System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal",

            "Windows.Foundation.IAsyncAction",
            "Windows.Foundation.IAsyncActionWithProgress`1",
            "Windows.Foundation.IAsyncOperation`1",
            "Windows.Foundation.IAsyncOperationWithProgress`2",

            "System.Diagnostics.Debugger",
            "System.Diagnostics.DebuggerDisplayAttribute",
            "System.Diagnostics.DebuggerNonUserCodeAttribute",
            "System.Diagnostics.DebuggerHiddenAttribute",
            "System.Diagnostics.DebuggerBrowsableAttribute",
            "System.Diagnostics.DebuggerStepThroughAttribute",
            "System.Diagnostics.DebuggerBrowsableState",
            "System.Diagnostics.DebuggableAttribute",
            "System.Diagnostics.DebuggableAttribute+DebuggingModes",

            "System.ComponentModel.DesignerSerializationVisibilityAttribute",

            "System.IEquatable`1",

            "System.Collections.IList",
            "System.Collections.ICollection",
            "System.Collections.Generic.EqualityComparer`1",
            "System.Collections.Generic.List`1",
            "System.Collections.Generic.IDictionary`2",
            "System.Collections.Generic.IReadOnlyDictionary`2",
            "System.Collections.ObjectModel.Collection`1",
            "System.Collections.ObjectModel.ReadOnlyCollection`1",
            "System.Collections.Specialized.INotifyCollectionChanged",
            "System.ComponentModel.INotifyPropertyChanged",
            "System.ComponentModel.EditorBrowsableAttribute",
            "System.ComponentModel.EditorBrowsableState",

            "System.Linq.Enumerable",
            "System.Linq.Expressions.Expression",
            "System.Linq.Expressions.Expression`1",
            "System.Linq.Expressions.ParameterExpression",
            "System.Linq.Expressions.ElementInit",
            "System.Linq.Expressions.MemberBinding",
            "System.Linq.Expressions.ExpressionType",
            "System.Linq.IQueryable",
            "System.Linq.IQueryable`1",

            "System.Xml.Linq.Extensions",
            "System.Xml.Linq.XAttribute",
            "System.Xml.Linq.XCData",
            "System.Xml.Linq.XComment",
            "System.Xml.Linq.XContainer",
            "System.Xml.Linq.XDeclaration",
            "System.Xml.Linq.XDocument",
            "System.Xml.Linq.XElement",
            "System.Xml.Linq.XName",
            "System.Xml.Linq.XNamespace",
            "System.Xml.Linq.XObject",
            "System.Xml.Linq.XProcessingInstruction",

            "System.Security.UnverifiableCodeAttribute",
            "System.Security.Permissions.SecurityAction",
            "System.Security.Permissions.SecurityAttribute",
            "System.Security.Permissions.SecurityPermissionAttribute",

            "System.NotSupportedException",

            "System.Runtime.CompilerServices.ICriticalNotifyCompletion",
            "System.Runtime.CompilerServices.IAsyncStateMachine",
            "System.Runtime.CompilerServices.AsyncVoidMethodBuilder",
            "System.Runtime.CompilerServices.AsyncTaskMethodBuilder",
            "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1",
            "System.Runtime.CompilerServices.AsyncStateMachineAttribute",
            "System.Runtime.CompilerServices.IteratorStateMachineAttribute",

            "System.Windows.Forms.Form",
            "System.Windows.Forms.Application",

            "System.Environment",

            "System.Runtime.GCLatencyMode",

            "System.IFormatProvider",

            "System.ValueTuple",
            "System.ValueTuple`1",
            "System.ValueTuple`2",
            "System.ValueTuple`3",

            "", // extension marker

            "System.ValueTuple`4",
            "System.ValueTuple`5",
            "System.ValueTuple`6",
            "System.ValueTuple`7",
            "System.ValueTuple`8",

            "System.Runtime.CompilerServices.TupleElementNamesAttribute",

            "Microsoft.CodeAnalysis.Runtime.Instrumentation",

            "System.Runtime.CompilerServices.NullableAttribute",
            "System.Runtime.CompilerServices.NullableContextAttribute",
            "System.Runtime.CompilerServices.NullablePublicOnlyAttribute",
            "System.Runtime.CompilerServices.ReferenceAssemblyAttribute",

            "System.Runtime.CompilerServices.IsReadOnlyAttribute",
            "System.Runtime.CompilerServices.IsByRefLikeAttribute",
            "System.Runtime.InteropServices.InAttribute",
            "System.ObsoleteAttribute",
            "System.Span`1",
            "System.ReadOnlySpan`1",
            "System.Runtime.InteropServices.UnmanagedType",
            "System.Runtime.CompilerServices.IsUnmanagedAttribute",

            "Microsoft.VisualBasic.Conversion",
            "System.Runtime.CompilerServices.NonNullTypesAttribute",
            "System.AttributeTargets",
            "Microsoft.CodeAnalysis.EmbeddedAttribute",
            "System.Runtime.CompilerServices.ITuple",

            "System.Index",
            "System.Range",

            "System.Runtime.CompilerServices.AsyncIteratorStateMachineAttribute",
            "System.IAsyncDisposable",
            "System.Collections.Generic.IAsyncEnumerable`1",
            "System.Collections.Generic.IAsyncEnumerator`1",
            "System.Threading.Tasks.Sources.ManualResetValueTaskSourceCore`1",
            "System.Threading.Tasks.Sources.ValueTaskSourceStatus",
            "System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags",
            "System.Threading.Tasks.Sources.IValueTaskSource`1",
            "System.Threading.Tasks.Sources.IValueTaskSource",
            "System.Threading.Tasks.ValueTask`1",
            "System.Threading.Tasks.ValueTask",
            "System.Runtime.CompilerServices.AsyncIteratorMethodBuilder",
            "System.Threading.CancellationToken",
            "System.Threading.CancellationTokenSource",

            "System.InvalidOperationException",
            "System.Runtime.CompilerServices.SwitchExpressionException",
            "System.Collections.Generic.IEqualityComparer`1",

            "System.Runtime.CompilerServices.NativeIntegerAttribute",
            "System.Runtime.CompilerServices.IsExternalInit",
            "System.Runtime.InteropServices.OutAttribute",

            "System.Text.StringBuilder",
                        }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 28180, 28249);
                s_nameToTypeIdMap = f_45_28200_28249((int)Count); DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 28310, 28337);

                f_45_28310_28336();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 28362, 28367);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 28353, 28605) || true) && (i < f_45_28373_28395(s_metadataNames))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 28397, 28400)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(45, 28353, 28605))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(45, 28353, 28605);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 28434, 28464);

                        var
                        name = s_metadataNames[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 28482, 28536);

                        var
                        typeId = (WellKnownType)(i + WellKnownType.First)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 28554, 28590);

                        f_45_28554_28589(s_nameToTypeIdMap, name, typeId);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(45, 1, 253);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(45, 1, 253);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(45, 28262, 28616);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(45, 28262, 28616);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(45, 28262, 28616);
            }
        }

        [Conditional("DEBUG")]
        private static void AssertEnumAndTableInSync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(45, 28628, 30461);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 28740, 28745);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 28731, 30287) || true) && (i < f_45_28751_28773(s_metadataNames))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 28775, 28778)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(45, 28731, 30287))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(45, 28731, 30287);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 28812, 28842);

                        var
                        name = s_metadataNames[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 28860, 28914);

                        var
                        typeId = (WellKnownType)(i + WellKnownType.First)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 28934, 28952);

                        string
                        typeIdName
                        = default(string);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 28970, 29849);

                        switch (typeId)
                        {

                            case WellKnownType.First:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(45, 28970, 29849);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 29077, 29104);

                                typeIdName = "System.Math";
                                DynAbs.Tracing.TraceSender.TraceBreak(45, 29130, 29136);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(45, 28970, 29849);

                            case WellKnownType.Microsoft_VisualBasic_CompilerServices_ObjectFlowControl_ForLoopControl:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(45, 28970, 29849);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 29275, 29362);

                                typeIdName = "Microsoft.VisualBasic.CompilerServices.ObjectFlowControl+ForLoopControl";
                                DynAbs.Tracing.TraceSender.TraceBreak(45, 29388, 29394);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(45, 28970, 29849);

                            case WellKnownType.CSharp7Sentinel:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(45, 28970, 29849);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 29477, 29515);

                                typeIdName = "System.IFormatProvider";
                                DynAbs.Tracing.TraceSender.TraceBreak(45, 29541, 29547);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(45, 28970, 29849);

                            case WellKnownType.ExtSentinel:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(45, 28970, 29849);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 29626, 29642);

                                typeIdName = "";
                                DynAbs.Tracing.TraceSender.TraceBreak(45, 29668, 29674);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(45, 28970, 29849);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(45, 28970, 29849);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 29730, 29798);

                                typeIdName = f_45_29743_29797(f_45_29743_29779(f_45_29743_29760(typeId), "__", "+"), '_', '.');
                                DynAbs.Tracing.TraceSender.TraceBreak(45, 29824, 29830);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(45, 28970, 29849);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 29869, 29903);

                        int
                        separator = f_45_29885_29902(name, '`')
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 29921, 30181) || true) && (separator >= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(45, 29921, 30181);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 30056, 30092);

                            name = f_45_30063_30091(name, 0, separator);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 30114, 30162);

                            typeIdName = f_45_30127_30161(typeIdName, 0, separator);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(45, 29921, 30181);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 30201, 30272);

                        f_45_30201_30271(name == typeIdName, "Enum name and type name must match");
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(45, 1, 1557);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(45, 1, 1557);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 30303, 30355);

                f_45_30303_30354((int)WellKnownType.ExtSentinel == 255);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 30369, 30450);

                f_45_30369_30449((int)WellKnownType.NextAvailable <= 512, "Time for a new sentinel");
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(45, 28628, 30461);

                int
                f_45_28751_28773(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(45, 28751, 28773);
                    return return_v;
                }


                string
                f_45_29743_29760(Microsoft.CodeAnalysis.WellKnownType
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(45, 29743, 29760);
                    return return_v;
                }


                string
                f_45_29743_29779(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(45, 29743, 29779);
                    return return_v;
                }


                string
                f_45_29743_29797(string
                this_param, char
                oldChar, char
                newChar)
                {
                    var return_v = this_param.Replace(oldChar, newChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(45, 29743, 29797);
                    return return_v;
                }


                int
                f_45_29885_29902(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(45, 29885, 29902);
                    return return_v;
                }


                string
                f_45_30063_30091(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(45, 30063, 30091);
                    return return_v;
                }


                string
                f_45_30127_30161(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(45, 30127, 30161);
                    return return_v;
                }


                int
                f_45_30201_30271(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(45, 30201, 30271);
                    return 0;
                }


                int
                f_45_30303_30354(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(45, 30303, 30354);
                    return 0;
                }


                int
                f_45_30369_30449(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(45, 30369, 30449);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(45, 28628, 30461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(45, 28628, 30461);
            }
        }

        public static bool IsWellKnownType(this WellKnownType typeId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(45, 30473, 30711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 30559, 30609);

                f_45_30559_30608(typeId != WellKnownType.ExtSentinel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 30623, 30700);

                return typeId >= WellKnownType.First && (DynAbs.Tracing.TraceSender.Expression_True(45, 30630, 30699) && typeId < WellKnownType.NextAvailable);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(45, 30473, 30711);

                int
                f_45_30559_30608(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(45, 30559, 30608);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(45, 30473, 30711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(45, 30473, 30711);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsValueTupleType(this WellKnownType typeId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(45, 30723, 30985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 30810, 30860);

                f_45_30810_30859(typeId != WellKnownType.ExtSentinel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 30874, 30974);

                return typeId >= WellKnownType.System_ValueTuple && (DynAbs.Tracing.TraceSender.Expression_True(45, 30881, 30973) && typeId <= WellKnownType.System_ValueTuple_TRest);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(45, 30723, 30985);

                int
                f_45_30810_30859(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(45, 30810, 30859);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(45, 30723, 30985);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(45, 30723, 30985);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsValid(this WellKnownType typeId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(45, 30997, 31202);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 31075, 31191);

                return typeId >= WellKnownType.First && (DynAbs.Tracing.TraceSender.Expression_True(45, 31082, 31151) && typeId < WellKnownType.NextAvailable) && (DynAbs.Tracing.TraceSender.Expression_True(45, 31082, 31190) && typeId != WellKnownType.ExtSentinel);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(45, 30997, 31202);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(45, 30997, 31202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(45, 30997, 31202);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string GetMetadataName(this WellKnownType id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(45, 31214, 31365);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 31298, 31354);

                return s_metadataNames[(int)(id - WellKnownType.First)];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(45, 31214, 31365);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(45, 31214, 31365);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(45, 31214, 31365);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static WellKnownType GetTypeFromMetadataName(string metadataName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(45, 31377, 31730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 31474, 31491);

                WellKnownType
                id
                = default(WellKnownType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 31507, 31621) || true) && (f_45_31511_31562(s_nameToTypeIdMap, metadataName, out id))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(45, 31507, 31621);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 31596, 31606);

                    return id;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(45, 31507, 31621);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 31637, 31676);

                f_45_31637_31675(WellKnownType.First != 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 31690, 31719);

                return WellKnownType.Unknown;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(45, 31377, 31730);

                bool
                f_45_31511_31562(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.WellKnownType>
                this_param, string
                key, out Microsoft.CodeAnalysis.WellKnownType
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(45, 31511, 31562);
                    return return_v;
                }


                int
                f_45_31637_31675(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(45, 31637, 31675);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(45, 31377, 31730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(45, 31377, 31730);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static WellKnownType GetWellKnownFunctionDelegate(int invokeArgumentCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(45, 31816, 32213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 31924, 31963);

                f_45_31924_31962(invokeArgumentCount >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 31977, 32202);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(45, 31984, 32069) || (((invokeArgumentCount <= WellKnownType.System_Func_TMax - WellKnownType.System_Func_T) && DynAbs.Tracing.TraceSender.Conditional_F2(45, 32089, 32160)) || DynAbs.Tracing.TraceSender.Conditional_F3(45, 32180, 32201))) ? (WellKnownType)((int)WellKnownType.System_Func_T + invokeArgumentCount) : WellKnownType.Unknown;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(45, 31816, 32213);

                int
                f_45_31924_31962(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(45, 31924, 31962);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(45, 31816, 32213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(45, 31816, 32213);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static WellKnownType GetWellKnownActionDelegate(int invokeArgumentCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(45, 32299, 32698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 32405, 32444);

                f_45_32405_32443(invokeArgumentCount >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(45, 32460, 32687);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(45, 32467, 32554) || (((invokeArgumentCount <= WellKnownType.System_Action_TMax - WellKnownType.System_Action) && DynAbs.Tracing.TraceSender.Conditional_F2(45, 32574, 32645)) || DynAbs.Tracing.TraceSender.Conditional_F3(45, 32665, 32686))) ? (WellKnownType)((int)WellKnownType.System_Action + invokeArgumentCount) : WellKnownType.Unknown;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(45, 32299, 32698);

                int
                f_45_32405_32443(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(45, 32405, 32443);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(45, 32299, 32698);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(45, 32299, 32698);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.WellKnownType>
        f_45_28200_28249(int
        capacity)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.WellKnownType>(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(45, 28200, 28249);
            return return_v;
        }


        static int
        f_45_28310_28336()
        {
            AssertEnumAndTableInSync();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(45, 28310, 28336);
            return 0;
        }


        static int
        f_45_28373_28395(string[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(45, 28373, 28395);
            return return_v;
        }


        static int
        f_45_28554_28589(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.WellKnownType>
        this_param, string
        key, Microsoft.CodeAnalysis.WellKnownType
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(45, 28554, 28589);
            return 0;
        }

    }
}
