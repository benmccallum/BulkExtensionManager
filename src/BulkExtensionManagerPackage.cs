using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.ExtensionManager;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

namespace BenMcCallum.BulkExtensionManager
{
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [ProvideAutoLoad(UIContextGuids80.NoSolution)]
    [ProvideAutoLoad(UIContextGuids80.SolutionExists)]
    [InstalledProductRegistration("#110", "#112", Version, IconResourceID = 400)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [Guid(GuidList.guidBulkExtensionManagerPkgString)]
    public sealed class BulkExtensionManagerPackage : ExtensionPointPackage
    {
        public const string Version = "1.0";

        protected override void Initialize()
        {
            base.Initialize();

            var repository = (IVsExtensionRepository)GetService(typeof(SVsExtensionRepository));
            var manager = (IVsExtensionManager)GetService(typeof(SVsExtensionManager));
            var mcs = GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
            var outWindow = GetService(typeof(SVsOutputWindow)) as IVsOutputWindow;

            if (repository == null || manager == null || mcs == null || outWindow == null)
            {
                return;
            }

            // Get a unique output window pane
            var paneGuid = new Guid("233a6542-251a-42b1-b435-c80a3d70340e");
            outWindow.CreatePane(ref paneGuid, "Bulk Extension Manager", 1, 1);
            IVsOutputWindowPane customOutputPane;
            outWindow.GetPane(ref paneGuid, out customOutputPane);


            // Setup the menu buttons
            Commands commands = new Commands(repository, manager, mcs, customOutputPane);
            commands.Initialize();
        }
    }
}
