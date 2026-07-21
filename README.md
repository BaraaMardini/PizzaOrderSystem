# pitzaaaa

![Language](https://img.shields.io/badge/language-C%23-239120)
![Framework](https://img.shields.io/badge/framework-.NET%20Windows%20Forms-512BD4)
![Platform](https://img.shields.io/badge/platform-Windows-0078D6)
![License](https://img.shields.io/badge/license-Not%20specified-lightgrey)

A Windows Forms desktop application for building and pricing a custom pizza order.

## Overview

`pitzaaaa` is a single-form Windows Forms (WinForms) desktop application built with C# and .NET. It lets a user configure a pizza order — size, crust type, toppings, and dine-in/take-out preference — and see a live order summary and total price calculated as selections change. The application appears to be a learning/practice project demonstrating WinForms event handling, control state management, and simple business logic (price calculation) within a single code-behind file.

## Features

- **Pizza size selection** via radio buttons: Small ($10), Medium ($20), Larg [sic] ($30).
- **Crust type selection** via radio buttons: "Thin Cust" ($10) and "Think Cust" ($20).
- **Topping selection** via checkboxes, each adding $5 to the total: Extra Cheese, Onion, Mushrooms, Olives, Tomatoes, Green Peppers.
- **Dine-in / take-out selection** via radio buttons: "Eat In" or "Take Out".
- **Live order summary panel** that displays the currently selected size, crust type, topping list, and eating location, updating automatically as selections change.
- **Live price calculation**, triggered on every relevant control change, summing size price, crust price, and $5 per selected topping.
- **Order confirmation**: an "Order Pizza" button shows a confirmation dialog (`MessageBox` with OK/Cancel) and, on confirmation, disables the order-configuration controls (size, crust, toppings, eat-in/take-out groups) to lock in the order.
- **Reset form**: a "Rest Form" [sic] button re-enables all controls, clears all size/crust/topping selections, and resets the size, crust type, and topping-summary labels back to their default placeholder text.

## Screenshots

_No screenshots are included in the provided project files._

## Demo

Not specified.

## Tech Stack

| Category | Technology |
|---|---|
| Language | C# |
| UI Framework | Windows Forms (WinForms) |
| Runtime | .NET (version not specified — no `.csproj`/project file was provided) |
| Resource files | `.resx` (Windows Forms resource file, standard/empty template) |

## Architecture

The application follows the standard WinForms **code-behind** pattern used by Visual Studio's Windows Forms Designer:

- **`Form1.Designer.cs`** — Auto-generated designer code that declares and initializes all UI controls (labels, checkboxes, radio buttons, group boxes, buttons) and wires their events to handler methods in the partial class. This file is intended to be maintained by the Visual Studio Designer rather than edited by hand.
- **`Form1.cs`** — The code-behind partial class containing all business logic:
  - Private fields hold the running state of the order (selected size price, crust price, per-topping prices, crust type string, eat-in/take-out string, and a composed topping-description string).
  - Each control's `CheckedChanged`/`Click` event handler updates the relevant state field(s), then explicitly re-invokes `PriceOfPizza_Click` to recalculate and redisplay the total price, and invokes helper methods (`label8_Click`, `label9_Click`, `label12_Click`, `label13_Click`) to refresh the order-summary labels.
  - There is no separation between UI and business logic (no MVC/MVVM); all pricing and state logic lives directly in the form's event handlers.
- **`Form1.resx`** — The resource file associated with `Form1`, containing only the standard auto-generated ResX schema/header with no custom embedded resources (images, icons, or strings).

### Notable implementation details

- Price and summary updates are performed by manually calling other controls' event handler methods (e.g., calling `PriceOfPizza_Click(sender, new EventArgs())` from inside topping/size/crust handlers) rather than using a centralized recalculation method.
- The topping summary is rebuilt from scratch on every topping change by concatenating per-topping string fields (`ToppingOfChess1`, `ToppingOfOnion1`, etc.) in `label13_Click`.
- Some minor naming/text inconsistencies exist in the source (e.g., the "Green Peppers" checkbox sets its display string to `"Extra Chess,"` instead of a green-peppers-specific string; the "Larg" and "Think Cust"/"thinkCust" labels appear to be typos for "Large" and "Thick Cust"/"thickCrust").

## Project Structure

```
pitzaaaa/
├── Form1.cs             # Code-behind: event handlers and pizza pricing/summary logic
├── Form1.Designer.cs    # Auto-generated: control declarations and layout
└── Form1.resx           # Resource file for Form1 (no custom resources present)
```

> **Note:** Only these three files were provided for analysis. A complete WinForms project would also typically include a `.csproj`/`.sln` file, `Program.cs` (application entry point), and an `app.config`/`app.manifest`, none of which were supplied, so they are not documented here.

## Requirements

- Windows OS (WinForms applications run on Windows; cross-platform support depends on the target .NET version, which is not specified in the provided files).
- .NET / .NET Framework SDK compatible with Windows Forms (exact version not specified — no project file was provided).
- Visual Studio (recommended) or another IDE/build toolchain capable of building WinForms projects.

## Installation

Since no `.csproj`/`.sln` project file was included in the provided files, exact build commands cannot be determined. In general, to run this project you would:

1. Open the project in Visual Studio (create a new **Windows Forms App** project if a project file does not already exist, and add `Form1.cs`, `Form1.Designer.cs`, and `Form1.resx` to it).
2. Restore any NuGet dependencies, if applicable (none are referenced in the provided code — only standard .NET/WinForms namespaces are used: `System`, `System.Windows.Forms`, `System.Drawing`, etc.).
3. Build the solution.

## Configuration

Not specified. No configuration files (e.g., `app.config`, environment variables, connection strings) are present in the provided project files.

## Running the Project

Open the project in Visual Studio and run/debug `Form1` as the startup form (F5), or run the compiled executable produced by the build once a project file is configured.

## Development

Not specified beyond standard WinForms Designer workflow: modify UI layout via the Visual Studio Form Designer (which updates `Form1.Designer.cs`), and add/edit event-handling logic in `Form1.cs`.

## Build

Not specified — no build scripts or project files were provided.

## Testing

Not specified. No test project, test files, or testing framework references were found in the provided files.

## API Documentation

Not applicable. This is a standalone desktop WinForms application with no exposed APIs, web endpoints, or network calls.

## Database

Not applicable. No database, ORM, or data persistence code is present — all state is held in in-memory fields for the duration of the form's lifetime.

## Deployment

Not specified. No Docker, CI/CD, or deployment configuration files were provided.

## Security Notes

Not applicable. The application performs no authentication, authorization, network communication, or handling of external/untrusted input beyond local UI control state.

## Performance Notes

Not applicable. This is a simple, single-form desktop application with no caching, background jobs, or performance-sensitive operations.

## Known Limitations

- No project file (`.csproj`/`.sln`) or application entry point (`Program.cs`) was provided, so the project cannot be built as-is from the supplied files alone.
- Price recalculation logic is duplicated across many event handlers (each handler explicitly calls `PriceOfPizza_Click`), rather than being centralized.
- The topping summary string ("Green Peppers" topping) incorrectly displays the text `"Extra Chess,"` instead of a green-peppers-specific label.
- Crust type labels contain apparent typos ("thinCust" / "thinkCust", "Thin Cust" / "Think Cust") that make the two crust options hard to distinguish in the UI/state.
- The "Larg" size label appears to be a typo for "Large".
- No input validation, unit tests, or error handling are present.
- No persistence — orders are not saved anywhere; closing the app discards all state.

## Future Improvements

- Add a proper .NET project file so the application can be built and run independently.
- Centralize price calculation into a single method rather than duplicating calls across handlers.
- Fix labeling typos ("Larg" → "Large", "Think Cust"/"thinkCust" → "Thick Cust"/"thickCrust", the mislabeled Green Peppers topping string).
- Add input validation (e.g., requiring a size to be selected before allowing an order).
- Add unit tests around the pricing logic.
- Persist orders (e.g., to a local file or database) instead of holding them only in memory.

## Contributing

Contributions are welcome. To contribute:

1. Fork the repository.
2. Create a feature branch (`git checkout -b feature/my-feature`).
3. Make your changes and commit them with clear messages.
4. Push to your fork and open a Pull Request describing your changes.

Please keep changes focused and consistent with the existing WinForms code-behind style used in this project.

## License

Not specified. No license file was included in the provided project files.

## Author

Baraa Mardini
