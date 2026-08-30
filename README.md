[![](https://img.shields.io/nuget/v/soenneker.quark.enums.visibilities.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.visibilities/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.visibilities/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.visibilities/actions/workflows/publish-package.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.visibilities/build-and-test.yml?label=Build&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.visibilities/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.enums.visibilities.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.visibilities/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.visibilities/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.visibilities/actions/workflows/codeql.yml)

# Soenneker.Quark.Enums.Visibilities

Strongly typed CSS `visibility` values for Quark components and styles.

## Install

```bash
dotnet add package Soenneker.Quark.Enums.Visibilities
```

## Usage

```csharp
VisibilityKeyword visibility = VisibilityKeyword.Hidden;
string cssValue = visibility.Value; // "hidden"
```

Use `Hidden` when the element should keep its layout space while not being painted. If the element should be removed from layout, use an appropriate `display` value instead. The type also includes CSS-wide values from `GlobalKeyword`.

## Values

| Member | CSS value | Behavior |
| --- | --- | --- |
| `Visible` | `visible` | Paints the element normally. |
| `Hidden` | `hidden` | Hides the element while preserving its layout space. |
| `Collapse` | `collapse` | Collapses supported table rows or columns; otherwise generally behaves like `hidden`. |
