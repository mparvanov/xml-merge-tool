https://github.com/telerik/kendo/issues/13998

# xml-merge-tool

We are releasing MVC and Core products together with DPL product so we add DPL change log to MVC and Core changelogs on release. This is currently done manually:
"Add the DPL related release notes to MVC and Core Release Notes."
The task is to create a tool which merges MVC xml with DPL xml and Core xml with DPL xml.

Usage:
### Default config
1. Run MergeReleaseNotes.exe
1. Check that merged.xml contains the content of source.xml and dpl.xml in the working directory 
### Custom config 
1. Run MergeReleaseNotes.exe ```<source file path> <dpl file path> <merged file path>```
e.g. MergeReleaseNotes.exe source.xml dpl.xml merged.xml
1. Check that merged.xml contains the content of source.xml and dpl.xml
