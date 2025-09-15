using Intellenum;
using Soenneker.Quark.Enums.GlobalKeywords;

namespace Soenneker.Quark.Enums.Visibilities;

/// <summary>
/// An enumeration for Quark, representing HTML visibility CSS values.
/// This enum contains all valid CSS visibility property values for use in HTML/CSS styling.
/// </summary>
[Intellenum<string>]
public partial class Visibility
{
    /// <summary>
    /// The element is visible and displayed normally in the document flow.
    /// This is the default value for most elements.
    /// </summary>
    public static readonly Visibility Visible = new("visible");

    /// <summary>
    /// The element is hidden but still takes up space in the layout.
    /// Unlike display: none, the element remains in the document flow and affects other elements' positioning.
    /// </summary>
    public static readonly Visibility Hidden = new("hidden");

    /// <summary>
    /// For table elements, this value hides the row or column and it does not take up any space in the layout.
    /// For non-table elements, this value behaves the same as 'hidden'.
    /// This is primarily used with table rows, columns, row groups, and column groups.
    /// </summary>
    public static readonly Visibility Collapse = new("collapse");

    public static implicit operator Visibility(GlobalKeyword style) => new(style.Value); // Value is the underlying string
}
