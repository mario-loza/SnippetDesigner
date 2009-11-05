namespace Microsoft.SnippetDesigner
{
    /// <summary>
    /// String constants that don't belong in a resource file
    /// These are strings which are passed around internally and should not change
    /// </summary>
    public static class StringConstants
    {
        public static readonly string MakeSnippetDTEFormat = "/template:\"{0}\\{1}\"";
        public static readonly string NewFileDTECommand = "File.NewFile";

        //the extension associated with a snippet file
        public const string SnippetExtension = ".snippet";

        //yellow marker name for attribute - this is defined also in a resource but needs to also be here to use in attirbue ProvideCustomMarker
        public const string SnippetReplacementMarker = "Snippet Replacement Marker";
        public const string ActiveSnippetReplacementMarker = "Active Snippet Replacement Marker";
        public const string MarkerServiceName = "HighlightMarkerService";

        public const string ArgumentStartMarker = " ";

        public const string ColumnDefault = "DefaultsTo";
        public const string ColumnEditable = "Editable";
        public const string ColumnFunction = "Function";
        public const string ColumnID = "ID";
        public const string ColumnReplacementKind = "ReplacementKind";
        public const string ColumnTooltip = "Tooltip";
        public const string ColumnType = "Type";
        public const string DoubleQuoteString = "\"";
        public const string ExportNameCSharp = "csharp";
        public const string ExportNameVisualBasic = "basic";
        public const string ExportNameXML = "xml";
        public const string MySnippetsDir = "My Code Snippets";
        public const string MyXmlSnippetsDir = "My Xml Snippets";
        public const string SchemaNameCSharp = "csharp";
        public const string SchemaNameCSharp2 = "vcsharp";
        public const string SchemaNameVisualBasic = "vb";
        public const string SchemaNameXML = "xml";
        public const string SnippetDirectoryName = "Code Snippets";
        public const string SnippetDirNameCSharp = "Visual C#";
        public const string SnippetDirNameVisualBasic = "Visual Basic";
        public const string SnippetDirNameXML = "XML";
        public const string SnippetTypeExpansion = "Expansion";
        public const string SnippetTypeMethodBody = "method body";
        public const string SnippetTypeMethodDeclaration = "method decl";
        public const string SnippetTypeTypeDeclaration = "type decl";
        public const string SymbolEndWord = "end";
        public const string SymbolReplacement = "$";
        public const string SymbolSelected = "$selected$";
        public const string SymbolSelectedWord = "selected";
        public const string ValidPotentialReplacementString = @"^(("".*"")|(\w+))$";
        public const string ValidExistingReplacementString = @"^\$(("".*"")|(\w+))\$$";
        public const string VSRegistryRegistrationName = "Registration";
        public const string VSRegistryRegistrationNameEntry = "UserName";
    }
}