using System;

namespace BenMcCallum.BulkExtensionManager
{
    static class GuidList
    {
        public const string guidBulkExtensionManagerPkgString = "cb8900a0-79fb-4c76-a6d6-f4e88d3384d3";

        public const string guidImportExportCmdSetString = "c1703d5f-c150-4977-a4a7-d4a6094412be";
        public const string guidFlyoutImportExportMenuString = "c1703d5f-c150-4977-a4a2-d4a6094412bb";
        
        public static readonly Guid guidImportExportCmdSet = new Guid(guidImportExportCmdSetString);
        public static readonly Guid guidFlyoutImportExportMenu = new Guid(guidFlyoutImportExportMenuString);
    }

    static class PkgCmdIDList
    {
        public const uint cmdImport = 0x400;
        public const uint cmdExport = 0x500;
    }
}
