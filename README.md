# MegamerShitwareSuite

A humorous, lightweight Microsoft Office parody suite built with .NET 10 and Windows Forms. This project provides simplified alternatives to Word, PowerPoint, and Excel with custom file formats and a playful twist.

## Applications

### ShitWord
A document editor for creating text and image-based documents.

**Features:**
- Add and format rich text boxes with custom fonts and colors
- Insert images from your file system
- Delete mode for removing elements
- Adjust text box dimensions
- Documents saved as `.msv` (Megamer Shit Word) files using JSON format

### ShitPowerPoint
An image-based presentation creator.

**Features:**
- Build slideshows from imported images
- Thumbnail gallery view with large preview
- Fullscreen or windowed presentation mode
- Navigate slides with arrow keys, spacebar, or mouse clicks
- Presentations saved as `.spp` files using binary format

### ShitExcel
A CSV-based spreadsheet editor.

**Features:**
- Import and export CSV files
- Add and remove columns dynamically
- Direct cell editing in a grid view
- Simple, lightweight data management

## Requirements

- Windows 10/11
- [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) or later

## Building

Clone the repository and build using the .NET CLI:

```bash
git clone https://github.com/Megamer-studios/Megamer-Shitware-Suite.git
cd MegamerShitwareSuite
dotnet build
```

Or open `MegamerShitwareSuite.slnx` in Visual Studio 2022 (17.10+) and build from there.

## Running

Run individual applications:

```bash
# ShitWord
dotnet run --project MegamerShitwareSuite

# ShitPowerPoint
dotnet run --project ShitPowerPoint

# ShittyExcel
dotnet run --project ShittyExcel
```

## Project Structure

```
MegamerShitwareSuite/
├── MegamerShitwareSuite/     # ShitWord application
│   ├── StartForm.cs          # Welcome screen
│   ├── Form1.cs              # Main document editor
│   ├── NumInput.cs           # Numeric input dialog
│   └── AboutBox1.cs          # About dialog
├── ShitPowerPoint/           # ShitPowerPoint application
│   ├── StartScreen.cs        # Welcome screen
│   ├── Form1.cs              # Slide editor
│   ├── Presentation.cs       # Slideshow viewer
│   └── AboutBox1.cs          # About dialog
├── ShittyExcel/              # ShittyExcel application
│   ├── StartMenu.cs          # Welcome screen
│   ├── Form1.cs              # Spreadsheet editor
│   ├── TextInput.cs          # Text input dialog
│   └── AboutBox1.cs          # About dialog
└── MegamerShitwareSuite.slnx # Solution file
```

## File Formats

| Application | Extension | Format | Description |
|-------------|-----------|--------|-------------|
| ShitWord | `.msv` | JSON | Stores text boxes, images (base64), fonts, and colors |
| ShitPowerPoint | `.spp` | Binary | Contains image count header and base64-encoded images |
| ShittyExcel | `.csv` | CSV | Standard comma-separated values |

## Technologies

- **.NET 10.0** - Latest .NET runtime
- **Windows Forms** - Desktop GUI framework
- **Newtonsoft.Json** - JSON serialization (ShitWord)
- **P/Invoke** - Windows API interop for custom window behavior


## License

This project is provided for free as-is for educational and entertainment purposes. 

## Contributing

Feel free to open issues or submit pull requests if you want to add more "features" to the suite!
