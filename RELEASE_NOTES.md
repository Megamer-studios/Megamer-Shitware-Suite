# Release Notes

## Version 1.0.0 - January 20, 2026

The first official release of MegamerShitwareSuite, featuring a complete trio of Office-parody applications.

### New Applications

#### ShitPowerPoint (New!)
A brand new presentation application joins the suite:
- **Image-based slideshows** - Create presentations from imported images
- **Thumbnail gallery** - View all slides as 100x100px thumbnails with a large preview panel
- **Presentation mode** - Present in fullscreen or windowed mode
- **Slide navigation** - Navigate with arrow keys, spacebar, or mouse clicks
- **Custom file format** - Save presentations as `.spp` files
- **Delete mode** - Easily remove unwanted slides

#### ShittyExcel (Complete Overhaul)
Major updates to the spreadsheet application:
- **New Start Menu** - Consistent welcome screen matching other apps
- **Add/Remove columns** - Dynamic column management with custom naming
- **Text input dialog** - New dialog for entering column names
- **CSV import/export** - Full support for opening and saving CSV files
- **Cell editing** - Direct in-grid cell modification
- **About dialog** - Added application information screen

#### ShitWord (Enhancements)
Updates to the document editor:
- **About dialog** - Added application information screen
- **Start screen improvements** - Enhanced welcome screen with about button
- **New resources** - Added profile images and artwork

### Suite-Wide Improvements

- **Consistent UI** - All three applications now share a unified start screen design with New, Open, About, and Exit options
- **About dialogs** - Every application now includes a proper About box with version and copyright information
- **Resource library** - Expanded icon and image resources across all applications
- **.NET 10 upgrade** - Entire suite upgraded to .NET 10.0 for improved performance and latest features

### File Formats

| Application | Extension | Format |
|-------------|-----------|--------|
| ShitWord | `.msv` | JSON with base64 images |
| ShitPowerPoint | `.spp` | Binary with base64 images |
| ShittyExcel | `.csv` | Comma-separated values |

### Technical Details

- **Framework**: .NET 10.0 Windows
- **UI Framework**: Windows Forms
- **Dependencies**: Newtonsoft.Json 13.0.4 (ShitWord only)

### Getting Started

```bash
# Clone the repository
git clone https://github.com/yourusername/MegamerShitwareSuite.git

# Build all applications
dotnet build

# Run individual apps
dotnet run --project MegamerShitwareSuite    # ShitWord
dotnet run --project ShitPowerPoint          # ShitPowerPoint
dotnet run --project ShittyExcel             # ShittyExcel
```

### Known Limitations

- Windows only (requires Windows Forms)
- Requires .NET 10.0 SDK or runtime installed

---

*MegamerShitwareSuite - Because sometimes you just need a simpler Office suite.*
