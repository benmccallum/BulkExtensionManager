## Visual Studio Bulk Extension Manager

[![Build status](https://ci.appveyor.com/api/projects/status/cocghfvc3fjnf4eb?svg=true)](https://ci.appveyor.com/project/benmccallum/bulkextensionmanager)

[Download the extension from the VS Gallery](https://google.com/todo)
or get the [nightly build](https://ci.appveyor.com/project/benmccallum/bulkextensionmanager/build/artifacts)

This extension allows you to perform bulk operations on your Visual Studio extensions.

### How it works

Right now, the extension supports an export/import feature, allowing you to easily setup a new VS instance with all your favourite extensions.

You can perform the export and import via a flyout menu located in the `Tools` menu.

![Screenshot](https://raw.githubusercontent.com/benmccallum/BulkExtensionManager/master/artifacts/screenshot.png)

Exporting let's you write a file to disk of your currently installed extensions, which can be imported elsewhere using the `Import` menu option. 
An import will install any extensions you don't already have. 

Not all extensions are supported. Only the ones that can be auto installed on import, which excludes:

1. Extensions installed by MSIs.
2. Extensions that require admin permissions to update.
3. Extensions that are shipped as part of Visual Studio.

### Future feature ideas

Depending on built-in support for managing extensions in later versions of VS, some future features I'm considering are:

1. Some curated extension lists (i.e. Install web development extensions..., Install Win Phone dev extensions..., etc.)
2. Anything else the OS community thinks would be cool!