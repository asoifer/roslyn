// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.Test.Utilities
{
public static class Traits
{
public const string 
Editor = nameof(Editor)
;
public static class Editors
{
public const string 
KeyProcessors = nameof(KeyProcessors)
;

public const string 
KeyProcessorProviders = nameof(KeyProcessorProviders)
;

public const string 
Preview = nameof(Preview)
;

static Editors()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25138,382,651);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,454,491);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,526,579);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,614,639);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25138,382,651);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25138,382,651);
}

}

public const string 
Feature = nameof(Feature)
;
public static class Features
{
public const string 
AddAwait = "Refactoring.AddAwait"
;

public const string 
AddMissingImports = "Refactoring.AddMissingImports"
;

public const string 
AddMissingReference = nameof(AddMissingReference)
;

public const string 
AddMissingTokens = nameof(AddMissingTokens)
;

public const string 
Adornments = nameof(Adornments)
;

public const string 
AsyncLazy = nameof(AsyncLazy)
;

public const string 
AutomaticCompletion = nameof(AutomaticCompletion)
;

public const string 
AutomaticEndConstructCorrection = nameof(AutomaticEndConstructCorrection)
;

public const string 
BlockCommentEditing = nameof(BlockCommentEditing)
;

public const string 
BraceHighlighting = nameof(BraceHighlighting)
;

public const string 
BraceMatching = nameof(BraceMatching)
;

public const string 
Build = nameof(Build)
;

public const string 
CallHierarchy = nameof(CallHierarchy)
;

public const string 
CaseCorrection = nameof(CaseCorrection)
;

public const string 
ChangeSignature = nameof(ChangeSignature)
;

public const string 
ClassView = nameof(ClassView)
;

public const string 
Classification = nameof(Classification)
;

public const string 
CodeActionsAddAccessibilityModifiers = "CodeActions.AddAccessibilityModifiers"
;

public const string 
CodeActionsAddAnonymousTypeMemberName = "CodeActions.AddAnonymousTypeMemberName"
;

public const string 
CodeActionsAddAwait = "CodeActions.AddAwait"
;

public const string 
CodeActionsAddBraces = "CodeActions.AddBraces"
;

public const string 
CodeActionsAddConstructorParametersFromMembers = "CodeActions.AddConstructorParametersFromMembers"
;

public const string 
CodeActionsAddDebuggerDisplay = "CodeActions.AddDebuggerDisplay"
;

public const string 
CodeActionsAddDocCommentNodes = "CodeActions.AddDocCommentParamNodes"
;

public const string 
CodeActionsAddExplicitCast = "CodeActions.AddExplicitCast"
;

public const string 
CodeActionsAddFileBanner = "CodeActions.AddFileBanner"
;

public const string 
CodeActionsAddImport = "CodeActions.AddImport"
;

public const string 
CodeActionsAddMissingReference = "CodeActions.AddMissingReference"
;

public const string 
CodeActionsAddNew = "CodeActions.AddNew"
;

public const string 
CodeActionsRemoveNewModifier = "CodeActions.RemoveNewModifier"
;

public const string 
CodeActionsAddObsoleteAttribute = "CodeActions.AddObsoleteAttribute"
;

public const string 
CodeActionsAddOverload = "CodeActions.AddOverloads"
;

public const string 
CodeActionsAddParameter = "CodeActions.AddParameter"
;

public const string 
CodeActionsAddParenthesesAroundConditionalExpressionInInterpolatedString = "CodeActions.AddParenthesesAroundConditionalExpressionInInterpolatedString"
;

public const string 
CodeActionsAddRequiredParentheses = "CodeActions.AddRequiredParentheses"
;

public const string 
CodeActionsAddShadows = "CodeActions.AddShadows"
;

public const string 
CodeActionsMakeMemberStatic = "CodeActions.MakeMemberStatic"
;

public const string 
CodeActionsAliasAmbiguousType = "CodeActions.AliasAmbiguousType"
;

public const string 
CodeActionsAssignOutParameters = "CodeActions.AssignOutParameters"
;

public const string 
CodeActionsChangeToAsync = "CodeActions.ChangeToAsync"
;

public const string 
CodeActionsChangeToIEnumerable = "CodeActions.ChangeToIEnumerable"
;

public const string 
CodeActionsChangeToYield = "CodeActions.ChangeToYield"
;

public const string 
CodeActionsConfiguration = "CodeActions.Configuration"
;

public const string 
CodeActionsConvertAnonymousTypeToClass = "CodeActions.ConvertAnonymousTypeToClass"
;

public const string 
CodeActionsConvertAnonymousTypeToTuple = "CodeActions.ConvertAnonymousTypeToTuple"
;

public const string 
CodeActionsConvertBetweenRegularAndVerbatimString = "CodeActions.ConvertBetweenRegularAndVerbatimString"
;

public const string 
CodeActionsConvertForEachToFor = "CodeActions.ConvertForEachToFor"
;

public const string 
CodeActionsConvertForEachToQuery = "CodeActions.ConvertForEachToQuery"
;

public const string 
CodeActionsConvertForToForEach = "CodeActions.ConvertForToForEach"
;

public const string 
CodeActionsConvertIfToSwitch = "CodeActions.ConvertIfToSwitch"
;

public const string 
CodeActionsConvertLocalFunctionToMethod = "CodeActions.ConvertLocalFunctionToMethod"
;

public const string 
CodeActionsConvertNumericLiteral = "CodeActions.ConvertNumericLiteral"
;

public const string 
CodeActionsConvertQueryToForEach = "CodeActions.ConvertQueryToForEach"
;

public const string 
CodeActionsConvertSwitchStatementToExpression = "CodeActions.ConvertSwitchStatementToExpression"
;

public const string 
CodeActionsConvertToInterpolatedString = "CodeActions.ConvertToInterpolatedString"
;

public const string 
CodeActionsConvertToIterator = "CodeActions.ConvertToIterator"
;

public const string 
CodeActionsConvertTupleToStruct = "CodeActions.ConvertTupleToStruct"
;

public const string 
CodeActionsCorrectExitContinue = "CodeActions.CorrectExitContinue"
;

public const string 
CodeActionsCorrectFunctionReturnType = "CodeActions.CorrectFunctionReturnType"
;

public const string 
CodeActionsCorrectNextControlVariable = "CodeActions.CorrectNextControlVariable"
;

public const string 
CodeActionsDeclareAsNullable = "CodeActions.DeclareAsNullable"
;

public const string 
CodeActionsExtractInterface = "CodeActions.ExtractInterface"
;

public const string 
CodeActionsExtractLocalFunction = "CodeActions.ExtractLocalFunction"
;

public const string 
CodeActionsExtractMethod = "CodeActions.ExtractMethod"
;

public const string 
CodeActionsFixAllOccurrences = "CodeActions.FixAllOccurrences"
;

public const string 
CodeActionsFixReturnType = "CodeActions.FixReturnType"
;

public const string 
CodeActionsFullyQualify = "CodeActions.FullyQualify"
;

public const string 
CodeActionsGenerateComparisonOperators = "CodeActions.GenerateComparisonOperators"
;

public const string 
CodeActionsGenerateConstructor = "CodeActions.GenerateConstructor"
;

public const string 
CodeActionsGenerateConstructorFromMembers = "CodeActions.GenerateConstructorFromMembers"
;

public const string 
CodeActionsGenerateDefaultConstructors = "CodeActions.GenerateDefaultConstructors"
;

public const string 
CodeActionsGenerateEndConstruct = "CodeActions.GenerateEndConstruct"
;

public const string 
CodeActionsGenerateEnumMember = "CodeActions.GenerateEnumMember"
;

public const string 
CodeActionsGenerateEqualsAndGetHashCode = "CodeActions.GenerateEqualsAndGetHashCodeFromMembers"
;

public const string 
CodeActionsGenerateEvent = "CodeActions.GenerateEvent"
;

public const string 
CodeActionsGenerateLocal = "CodeActions.GenerateLocal"
;

public const string 
CodeActionsGenerateMethod = "CodeActions.GenerateMethod"
;

public const string 
CodeActionsGenerateOverrides = "CodeActions.GenerateOverrides"
;

public const string 
CodeActionsGenerateType = "CodeActions.GenerateType"
;

public const string 
CodeActionsGenerateVariable = "CodeActions.GenerateVariable"
;

public const string 
CodeActionsImplementAbstractClass = "CodeActions.ImplementAbstractClass"
;

public const string 
CodeActionsImplementInterface = "CodeActions.ImplementInterface"
;

public const string 
CodeActionsInitializeParameter = "CodeActions.InitializeParameter"
;

public const string 
CodeActionsInlineMethod = "CodeActions.InlineMethod"
;

public const string 
CodeActionsInlineDeclaration = "CodeActions.InlineDeclaration"
;

public const string 
CodeActionsInlineTemporary = "CodeActions.InlineTemporary"
;

public const string 
CodeActionsInlineTypeCheck = "CodeActions.InlineTypeCheck"
;

public const string 
CodeActionsInsertBraces = "CodeActions.InsertBraces"
;

public const string 
CodeActionsInsertMissingTokens = "CodeActions.InsertMissingTokens"
;

public const string 
CodeActionsIntroduceLocalForExpression = "CodeActions.IntroduceLocalForExpression"
;

public const string 
CodeActionsIntroduceUsingStatement = "CodeActions.IntroduceUsingStatement"
;

public const string 
CodeActionsIntroduceVariable = "CodeActions.IntroduceVariable"
;

public const string 
CodeActionsInvertConditional = "CodeActions.InvertConditional"
;

public const string 
CodeActionsInvertIf = "CodeActions.InvertIf"
;

public const string 
CodeActionsInvertLogical = "CodeActions.InvertLogical"
;

public const string 
CodeActionsInvokeDelegateWithConditionalAccess = "CodeActions.InvokeDelegateWithConditionalAccess"
;

public const string 
CodeActionsLambdaSimplifier = "CodeActions.LambdaSimplifier"
;

public const string 
CodeActionsMakeFieldReadonly = "CodeActions.MakeFieldReadonly"
;

public const string 
CodeActionsMakeLocalFunctionStatic = "CodeActions.MakeLocalFunctionStatic"
;

public const string 
CodeActionsMakeMethodAsynchronous = "CodeActions.MakeMethodAsynchronous"
;

public const string 
CodeActionsMakeMethodSynchronous = "CodeActions.MakeMethodSynchronous"
;

public const string 
CodeActionsMakeRefStruct = "CodeActions.MakeRefStruct"
;

public const string 
CodeActionsMakeStatementAsynchronous = "CodeActions.MakeStatementAsynchronous"
;

public const string 
CodeActionsMakeStructFieldsWritable = "CodeActions.MakeStructFieldsWritable"
;

public const string 
CodeActionsMakeTypeAbstract = "CodeActions.MakeTypeAbstract"
;

public const string 
CodeActionsMergeConsecutiveIfStatements = "CodeActions.MergeConsecutiveIfStatements"
;

public const string 
CodeActionsMergeNestedIfStatements = "CodeActions.MergeNestedIfStatements"
;

public const string 
CodeActionsMoveDeclarationNearReference = "CodeActions.MoveDeclarationNearReference"
;

public const string 
CodeActionsMoveToNamespace = nameof(CodeActionsMoveToNamespace)
;

public const string 
CodeActionsMoveToTopOfFile = "CodeActions.MoveToTopOfFile"
;

public const string 
CodeActionsMoveType = "CodeActions.MoveType"
;

public const string 
CodeActionsNameTupleElement = "CodeActions.NameTupleElement"
;

public const string 
CodeActionsOrderModifiers = "CodeActions.OrderModifiers"
;

public const string 
CodeActionsPopulateSwitch = "CodeActions.PopulateSwitch"
;

public const string 
CodeActionsPullMemberUp = "CodeActions.PullMemberUp"
;

public const string 
CodeActionsQualifyMemberAccess = "CodeActions.QualifyMemberAccess"
;

public const string 
CodeActionsRemoveAsyncModifier = "CodeActions.RemoveAsyncModifier"
;

public const string 
CodeActionsRemoveByVal = "CodeActions.RemoveByVal"
;

public const string 
CodeActionsRemoveDocCommentNode = "CodeActions.RemoveDocCommentNode"
;

public const string 
CodeActionsRemoveInKeyword = "CodeActions.RemoveInKeyword"
;

public const string 
CodeActionsRemoveUnnecessarySuppressions = "CodeActions.RemoveUnnecessarySuppressions"
;

public const string 
CodeActionsRemoveUnnecessaryCast = "CodeActions.RemoveUnnecessaryCast"
;

public const string 
CodeActionsRemoveUnnecessaryDiscardDesignation = "CodeActions.RemoveUnnecessaryDiscardDesignation"
;

public const string 
CodeActionsRemoveUnnecessaryImports = "CodeActions.RemoveUnnecessaryImports"
;

public const string 
CodeActionsRemoveUnnecessaryParentheses = "CodeActions.RemoveUnnecessaryParentheses"
;

public const string 
CodeActionsRemoveUnreachableCode = "CodeActions.RemoveUnreachableCode"
;

public const string 
CodeActionsRemoveUnusedLocalFunction = "CodeActions.RemoveUnusedLocalFunction"
;

public const string 
CodeActionsRemoveUnusedMembers = "CodeActions.RemoveUnusedMembers"
;

public const string 
CodeActionsRemoveUnusedParameters = "CodeActions.RemoveUnusedParameters"
;

public const string 
CodeActionsRemoveUnusedValues = "CodeActions.RemoveUnusedValues"
;

public const string 
CodeActionsRemoveUnusedVariable = "CodeActions.RemoveUnusedVariable"
;

public const string 
CodeActionsReplaceDefaultLiteral = "CodeActions.ReplaceDefaultLiteral"
;

public const string 
CodeActionsReplaceDocCommentTextWithTag = "CodeActions.ReplaceDocCommentTextWithTag"
;

public const string 
CodeActionsReplaceMethodWithProperty = "CodeActions.ReplaceMethodWithProperty"
;

public const string 
CodeActionsReplacePropertyWithMethods = "CodeActions.ReplacePropertyWithMethods"
;

public const string 
CodeActionsResolveConflictMarker = "CodeActions.ResolveConflictMarker"
;

public const string 
CodeActionsReverseForStatement = "CodeActions.ReverseForStatement"
;

public const string 
CodeActionsSimplifyConditional = "CodeActions.SimplifyConditional"
;

public const string 
CodeActionsSimplifyInterpolation = "CodeActions.SimplifyInterpolation"
;

public const string 
CodeActionsSimplifyLinqExpression = "CodeActions.SimplifyLinqExpression"
;

public const string 
CodeActionsSimplifyThisOrMe = "CodeActions.SimplifyThisOrMe"
;

public const string 
CodeActionsSimplifyTypeNames = "CodeActions.SimplifyTypeNames"
;

public const string 
CodeActionsSpellcheck = "CodeActions.Spellcheck"
;

public const string 
CodeActionsSplitIntoConsecutiveIfStatements = "CodeActions.SplitIntoConsecutiveIfStatements"
;

public const string 
CodeActionsSplitIntoNestedIfStatements = "CodeActions.SplitIntoNestedIfStatements"
;

public const string 
CodeActionsSuppression = "CodeActions.Suppression"
;

public const string 
CodeActionsSyncNamespace = "CodeActions.SyncNamespace"
;

public const string 
CodeActionsUnsealClass = "CodeActions.UnsealClass"
;

public const string 
CodeActionsUpdateLegacySuppressions = "CodeActions.UpdateLegacySuppressions"
;

public const string 
CodeActionsUpdateProjectToAllowUnsafe = "CodeActions.UpdateProjectToAllowUnsafe"
;

public const string 
CodeActionsUpgradeProject = "CodeActions.UpgradeProject"
;

public const string 
CodeActionsUseAutoProperty = "CodeActions.UseAutoProperty"
;

public const string 
CodeActionsUseCoalesceExpression = "CodeActions.UseCoalesceExpression"
;

public const string 
CodeActionsUseCollectionInitializer = "CodeActions.UseCollectionInitializer"
;

public const string 
CodeActionsUseCompoundAssignment = "CodeActions.UseCompoundAssignment"
;

public const string 
CodeActionsUseConditionalExpression = "CodeActions.UseConditionalExpression"
;

public const string 
CodeActionsUseDeconstruction = "CodeActions.UseDeconstruction"
;

public const string 
CodeActionsUseDefaultLiteral = "CodeActions.UseDefaultLiteral"
;

public const string 
CodeActionsUseExplicitTupleName = "CodeActions.UseExplicitTupleName"
;

public const string 
CodeActionsUseExplicitType = "CodeActions.UseExplicitType"
;

public const string 
CodeActionsUseExplicitTypeForConst = "CodeActions.UseExplicitTypeForConst"
;

public const string 
CodeActionsUseExpressionBody = "CodeActions.UseExpressionBody"
;

public const string 
CodeActionsUseFrameworkType = "CodeActions.UseFrameworkType"
;

public const string 
CodeActionsUseImplicitObjectCreation = "CodeActions.UseImplicitObjectCreation"
;

public const string 
CodeActionsUseImplicitType = "CodeActions.UseImplicitType"
;

public const string 
CodeActionsUseIndexOperator = "CodeActions.UseIndexOperator"
;

public const string 
CodeActionsUseInferredMemberName = "CodeActions.UseInferredMemberName"
;

public const string 
CodeActionsUseInterpolatedVerbatimString = "CodeActions.UseInterpolatedVerbatimString"
;

public const string 
CodeActionsUseIsNotExpression = "CodeActions.UseIsNotExpression"
;

public const string 
CodeActionsUseIsNullCheck = "CodeActions.UseIsNullCheck"
;

public const string 
CodeActionsUseLocalFunction = "CodeActions.UseLocalFunction"
;

public const string 
CodeActionsUseNamedArguments = "CodeActions.UseNamedArguments"
;

public const string 
CodeActionsUseNotPattern = "CodeActions.UseNotPattern"
;

public const string 
CodeActionsUsePatternCombinators = "CodeActions.UsePatternCombinators"
;

public const string 
CodeActionsUseNullPropagation = "CodeActions.UseNullPropagation"
;

public const string 
CodeActionsUseObjectInitializer = "CodeActions.UseObjectInitializer"
;

public const string 
CodeActionsUseRangeOperator = "CodeActions.UseRangeOperator"
;

public const string 
CodeActionsUseSimpleUsingStatement = "CodeActions.UseSimpleUsingStatement"
;

public const string 
CodeActionsUseSystemHashCode = "CodeActions.UseSystemHashCode"
;

public const string 
CodeActionsUseThrowExpression = "CodeActions.UseThrowExpression"
;

public const string 
CodeActionsWrapping = "CodeActions.Wrapping"
;

public const string 
CodeCleanup = nameof(CodeCleanup)
;

public const string 
CodeGeneration = nameof(CodeGeneration)
;

public const string 
CodeGenerationSortDeclarations = "CodeGeneration.SortDeclarations"
;

public const string 
CodeLens = nameof(CodeLens)
;

public const string 
CodeModel = nameof(CodeModel)
;

public const string 
CodeModelEvents = "CodeModel.Events"
;

public const string 
CodeModelMethodXml = "CodeModel.MethodXml"
;

public const string 
CommentSelection = nameof(CommentSelection)
;

public const string 
CompleteStatement = nameof(CompleteStatement)
;

public const string 
Completion = nameof(Completion)
;

public const string 
ConvertAutoPropertyToFullProperty = nameof(ConvertAutoPropertyToFullProperty)
;

public const string 
ConvertCast = nameof(ConvertCast)
;

public const string 
ConvertTypeOfToNameOf = nameof(ConvertTypeOfToNameOf)
;

public const string 
DebuggingBreakpoints = "Debugging.Breakpoints"
;

public const string 
DebuggingDataTips = "Debugging.DataTips"
;

public const string 
DebuggingEditAndContinue = "Debugging.EditAndContinue"
;

public const string 
DebuggingIntelliSense = "Debugging.IntelliSense"
;

public const string 
DebuggingLocationName = "Debugging.LocationName"
;

public const string 
DebuggingNameResolver = "Debugging.NameResolver"
;

public const string 
DebuggingProximityExpressions = "Debugging.ProximityExpressions"
;

public const string 
DecompiledSource = nameof(DecompiledSource)
;

public const string 
Diagnostics = nameof(Diagnostics)
;

public const string 
DisposeAnalysis = nameof(DisposeAnalysis)
;

public const string 
DocCommentFormatting = nameof(DocCommentFormatting)
;

public const string 
DocumentationComments = nameof(DocumentationComments)
;

public const string 
EditorConfig = nameof(EditorConfig)
;

public const string 
EncapsulateField = nameof(EncapsulateField)
;

public const string 
EndConstructGeneration = nameof(EndConstructGeneration)
;

public const string 
ErrorList = nameof(ErrorList)
;

public const string 
ErrorSquiggles = nameof(ErrorSquiggles)
;

public const string 
EventHookup = nameof(EventHookup)
;

public const string 
Expansion = nameof(Expansion)
;

public const string 
ExtractInterface = "Refactoring.ExtractInterface"
;

public const string 
ExtractMethod = "Refactoring.ExtractMethod"
;

public const string 
F1Help = nameof(F1Help)
;

public const string 
FindReferences = nameof(FindReferences)
;

public const string 
FixIncorrectTokens = nameof(FixIncorrectTokens)
;

public const string 
FixInterpolatedVerbatimString = nameof(FixInterpolatedVerbatimString)
;

public const string 
Formatting = nameof(Formatting)
;

public const string 
GoToAdjacentMember = nameof(GoToAdjacentMember)
;

public const string 
GoToBase = nameof(GoToBase)
;

public const string 
GoToDefinition = nameof(GoToDefinition)
;

public const string 
GoToImplementation = nameof(GoToImplementation)
;

public const string 
InlineHints = nameof(InlineHints)
;

public const string 
Interactive = nameof(Interactive)
;

public const string 
InteractiveHost = nameof(InteractiveHost)
;

public const string 
KeywordHighlighting = nameof(KeywordHighlighting)
;

public const string 
KeywordRecommending = nameof(KeywordRecommending)
;

public const string 
LineCommit = nameof(LineCommit)
;

public const string 
LineSeparators = nameof(LineSeparators)
;

public const string 
LinkedFileDiffMerging = nameof(LinkedFileDiffMerging)
;

public const string 
MSBuildWorkspace = nameof(MSBuildWorkspace)
;

public const string 
MetadataAsSource = nameof(MetadataAsSource)
;

public const string 
MoveToNamespace = nameof(MoveToNamespace)
;

public const string 
NamingStyle = nameof(NamingStyle)
;

public const string 
NavigableSymbols = nameof(NavigableSymbols)
;

public const string 
NavigateTo = nameof(NavigateTo)
;

public const string 
NavigationBar = nameof(NavigationBar)
;

public const string 
NetCore = nameof(NetCore)
;

public const string 
NormalizeModifiersOrOperators = nameof(NormalizeModifiersOrOperators)
;

public const string 
ObjectBrowser = nameof(ObjectBrowser)
;

public const string 
Options = nameof(Options)
;

public const string 
Organizing = nameof(Organizing)
;

public const string 
Outlining = nameof(Outlining)
;

public const string 
Packaging = nameof(Packaging)
;

public const string 
PasteTracking = nameof(PasteTracking)
;

public const string 
Peek = nameof(Peek)
;

public const string 
Progression = nameof(Progression)
;

public const string 
ProjectSystemShims = nameof(ProjectSystemShims)
;

public const string 
SarifErrorLogging = nameof(SarifErrorLogging)
;

public const string 
QuickInfo = nameof(QuickInfo)
;

public const string 
RQName = nameof(RQName)
;

public const string 
ReduceTokens = nameof(ReduceTokens)
;

public const string 
ReferenceHighlighting = nameof(ReferenceHighlighting)
;

public const string 
RemoteHost = nameof(RemoteHost)
;

public const string 
RemoveUnnecessaryLineContinuation = nameof(RemoveUnnecessaryLineContinuation)
;

public const string 
Rename = nameof(Rename)
;

public const string 
RenameTracking = nameof(RenameTracking)
;

public const string 
SignatureHelp = nameof(SignatureHelp)
;

public const string 
Simplification = nameof(Simplification)
;

public const string 
SmartIndent = nameof(SmartIndent)
;

public const string 
SmartTokenFormatting = nameof(SmartTokenFormatting)
;

public const string 
Snippets = nameof(Snippets)
;

public const string 
SourceGenerators = nameof(SourceGenerators)
;

public const string 
SplitComment = nameof(SplitComment)
;

public const string 
SplitStringLiteral = nameof(SplitStringLiteral)
;

public const string 
SuggestionTags = nameof(SuggestionTags)
;

public const string 
TargetTypedCompletion = nameof(TargetTypedCompletion)
;

public const string 
TextStructureNavigator = nameof(TextStructureNavigator)
;

public const string 
TodoComments = nameof(TodoComments)
;

public const string 
ToggleBlockComment = nameof(ToggleBlockComment)
;

public const string 
ToggleLineComment = nameof(ToggleLineComment)
;

public const string 
TypeInferenceService = nameof(TypeInferenceService)
;

public const string 
ValidateFormatString = nameof(ValidateFormatString)
;

public const string 
ValidateRegexString = nameof(ValidateRegexString)
;

public const string 
Venus = nameof(Venus)
;

public const string 
VsLanguageBlock = nameof(VsLanguageBlock)
;

public const string 
VsNavInfo = nameof(VsNavInfo)
;

public const string 
VsSearch = nameof(VsSearch)
;

public const string 
WinForms = nameof(WinForms)
;

public const string 
Workspace = nameof(Workspace)
;

public const string 
XmlTagCompletion = nameof(XmlTagCompletion)
;

static Features()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25138,719,26471);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,792,825);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,860,911);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,946,995);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,1030,1073);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,1108,1139);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,1174,1203);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,1238,1287);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,1322,1395);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,1430,1479);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,1514,1559);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,1594,1631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,1666,1687);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,1722,1759);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,1794,1833);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,1868,1909);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,1944,1973);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,2008,2047);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,2082,2160);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,2195,2275);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,2310,2354);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,2389,2435);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,2470,2568);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,2603,2667);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,2702,2771);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,2806,2864);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,2899,2953);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,2988,3034);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,3069,3135);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,3170,3210);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,3245,3307);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,3342,3410);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,3445,3496);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,3531,3583);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,3618,3768);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,3803,3875);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,3910,3958);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,3993,4053);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,4088,4152);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,4187,4253);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,4288,4342);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,4377,4443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,4478,4532);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,4567,4621);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,4656,4738);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,4773,4855);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,4890,4994);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,5029,5095);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,5130,5200);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,5235,5301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,5336,5398);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,5433,5517);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,5552,5622);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,5657,5727);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,5762,5858);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,5893,5975);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,6010,6072);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,6107,6175);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,6210,6276);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,6311,6389);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,6424,6504);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,6539,6601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,6636,6696);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,6731,6799);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,6834,6888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,6923,6985);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,7020,7074);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,7109,7161);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,7196,7278);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,7313,7379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,7414,7502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,7537,7619);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,7654,7722);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,7757,7821);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,7856,7951);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,7986,8040);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,8075,8129);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,8164,8220);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,8255,8317);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,8352,8404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,8439,8499);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,8534,8606);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,8641,8705);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,8740,8806);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,8841,8893);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,8928,8990);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,9025,9083);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,9118,9176);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,9211,9263);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,9298,9364);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,9399,9481);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,9516,9590);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,9625,9687);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,9722,9784);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,9819,9863);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,9898,9952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,9987,10085);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,10120,10180);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,10215,10277);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,10312,10386);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,10421,10493);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,10528,10598);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,10633,10687);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,10722,10800);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,10835,10911);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,10946,11006);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,11041,11125);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,11160,11234);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,11269,11353);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,11388,11451);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,11486,11544);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,11579,11623);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,11658,11718);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,11753,11809);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,11844,11900);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,11935,11987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,12022,12088);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,12123,12189);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,12224,12274);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,12309,12377);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,12412,12470);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,12505,12591);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,12626,12696);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,12731,12829);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,12864,12940);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,12975,13059);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,13094,13164);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,13199,13277);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,13312,13378);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,13413,13485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,13520,13584);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,13619,13687);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,13722,13792);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,13827,13911);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,13946,14024);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,14059,14139);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,14174,14244);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,14279,14345);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,14380,14446);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,14481,14551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,14586,14658);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,14693,14753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,14788,14850);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,14885,14933);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,14968,15060);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,15095,15177);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,15212,15262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,15297,15351);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,15386,15436);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,15471,15547);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,15582,15662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,15697,15753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,15788,15846);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,15881,15951);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,15986,16062);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,16097,16167);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,16202,16278);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,16313,16375);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,16410,16472);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,16507,16575);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,16610,16668);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,16703,16777);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,16812,16874);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,16909,16969);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,17004,17082);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,17117,17175);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,17210,17270);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,17305,17375);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,17410,17496);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,17531,17595);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,17630,17686);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,17721,17781);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,17816,17878);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,17913,17967);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,18002,18072);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,18107,18171);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,18206,18274);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,18309,18369);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,18404,18478);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,18513,18575);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,18610,18674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,18709,18753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,18788,18821);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,18856,18895);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,18930,18996);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,19031,19058);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,19093,19122);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,19157,19193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,19228,19270);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,19305,19348);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,19383,19428);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,19463,19494);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,19529,19606);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,19641,19674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,19709,19762);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,19797,19843);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,19878,19918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,19953,20007);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,20042,20090);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,20125,20173);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,20208,20256);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,20291,20355);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,20390,20433);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,20468,20501);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,20536,20577);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,20612,20663);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,20698,20751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,20786,20821);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,20856,20899);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,20934,20989);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,21024,21053);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,21088,21127);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,21162,21195);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,21230,21259);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,21294,21343);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,21378,21421);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,21456,21479);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,21514,21553);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,21588,21635);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,21670,21739);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,21774,21805);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,21840,21887);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,21922,21949);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,21984,22023);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,22058,22105);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,22140,22173);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,22208,22241);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,22276,22317);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,22352,22401);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,22436,22485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,22520,22551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,22586,22625);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,22660,22713);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,22748,22791);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,22826,22869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,22904,22945);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,22980,23013);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,23048,23091);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,23126,23157);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,23192,23229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,23264,23289);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,23324,23393);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,23428,23465);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,23500,23525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,23560,23591);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,23626,23655);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,23690,23719);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,23754,23791);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,23826,23845);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,23880,23913);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,23948,23995);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,24030,24075);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,24110,24139);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,24174,24197);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,24232,24267);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,24302,24355);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,24390,24421);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,24456,24533);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,24568,24591);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,24626,24665);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,24700,24737);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,24772,24811);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,24846,24879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,24914,24965);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,25000,25027);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,25062,25105);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,25140,25175);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,25210,25257);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,25292,25331);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,25366,25419);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,25454,25509);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,25544,25579);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,25614,25661);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,25696,25741);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,25776,25827);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,25862,25913);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,25948,25997);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,26032,26053);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,26088,26129);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,26164,26193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,26228,26255);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,26290,26317);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,26352,26381);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,26416,26459);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25138,719,26471);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25138,719,26471);
}

}

public const string 
Environment = nameof(Environment)
;
public static class Environments
{
public const string 
VSProductInstall = nameof(VSProductInstall)
;

static Environments()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25138,26547,26679);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,26624,26667);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25138,26547,26679);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25138,26547,26679);
}

}

static Traits()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25138,285,26686);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,348,371);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,683,708);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25138,26503,26536);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25138,285,26686);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25138,285,26686);
}

}
}
