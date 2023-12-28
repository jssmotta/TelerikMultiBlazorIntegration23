using System.Collections.Generic;

namespace TelerikBlazorApp1.Shared;
public class MenuItem
{
    public string Text { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public List<MenuItem>? Items { get; set; }
}
