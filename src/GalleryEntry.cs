﻿using System;
using Microsoft.VisualStudio.ExtensionManager;

namespace BenMcCallum.BulkExtensionManager
{
    /// <summary>
    /// This class replicates the Microsoft.VisualStudio.ExtensionManager.UI.VsGalleryEntry in Microsoft.VisualStudio.ExtensionsManager.Implementation.dll.
    /// We do so to avoid dependency on Implementation.dll assembly, which is a private assembly of VS.
    /// </summary>
    public class GalleryEntry : IRepositoryEntry
    {
        private Version _nonNullVsixVersion;

        public string VsixID { get; set; }
        public string DownloadUrl { get; set; }
        public string DownloadUpdateUrl { get; set; }
        public string VsixReferences { get; set; }
        public string VsixVersion { get; set; }
		public string Name { get; set; }
		public int Ranking { get; set; }

		public Version NonNullVsixVersion
        {
            get
            {
                if (_nonNullVsixVersion == null)
                {
                    if (!Version.TryParse(VsixVersion, out _nonNullVsixVersion))
                    {
                        _nonNullVsixVersion = new Version();
                    }

                }

                return _nonNullVsixVersion;
            }
        }

		public override string ToString()
		{
			return Name;
		}
	}
}