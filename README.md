# PrintQueueWatch

A .NET component for monitoring printers on a *windows* operating system.  This uses the underlying API and, as such, cannot be made OS portable.

## ScheduledPrintApp

This repository now includes `ScheduledPrintApp`, a simple WinForms application for scheduling PDF printing. The app watches a `Queue` folder for PDF files, prints them at a chosen time, and then moves them to a `Printed` folder. You can open the solution in Visual Studio or VS Code and build the project.

### Building

1. Install the .NET Framework developer tools.
2. Open `PrinterQueueWatch/PrinterQueueWatch.sln`.
3. Build the `ScheduledPrintApp` project.

### Running

After building, run `ScheduledPrintApp.exe`. Use the **Choose Printer** button to select your printer and configure settings. Pick a time with the date/time picker and click **Start**. Place PDF files in the `Queue` folder and they will be printed at the scheduled time.
