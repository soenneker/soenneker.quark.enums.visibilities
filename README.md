[![](https://img.shields.io/nuget/v/soenneker.quark.enums.visibilities.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.visibilities/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.visibilities/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.visibilities/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.enums.visibilities.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.visibilities/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.visibilities/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.visibilities/actions/workflows/codeql.yml)

# Soenneker.Quark.Enums.Visibilities

An enumeration for Quark, representing HTML visibility CSS values. This enum contains all valid CSS visibility property values for use in HTML/CSS styling.

## Install

```bash
dotnet add package Soenneker.Quark.Enums.Visibilities
```

## What you get

- `VisibilityKeyword` — An enumeration for Quark, representing HTML visibility CSS values. This enum contains all valid CSS visibility property values for use in HTML/CSS styling.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `VisibilityKeyword.Visible` | The element is visible and displayed normally in the document flow. This is the default value for most elements. | The element is visible and displayed normally in the document flow. This is the default value for most elements. |
| `VisibilityKeyword.Hidden` | The element is hidden but still takes up space in the layout. Unlike display: none, the element remains in the document flow and affects other elements' positioning. | The element is hidden but still takes up space in the layout. Unlike display: none, the element remains in the document flow and affects other elements' positioning. |
| `VisibilityKeyword.Collapse` | For table elements, this value hides the row or column and it does not take up any space in the layout. For non-table elements, this value behaves the same as 'hidden'. This is primarily used with table rows, columns, row groups, and column groups. | For table elements, this value hides the row or column and it does not take up any space in the layout. For non-table elements, this value behaves the same as 'hidden'. This is primarily used with table rows, columns, row groups, and column groups. |
