using System;
using System.Windows.Forms;
using PKHeX.Core;

namespace MapDataPlugin;

public sealed class MapDataPlugin : IPlugin
{
    public string Name => nameof(MapDataPlugin);
    public int Priority => 1;
    public ISaveFileProvider SaveFileEditor { get; private set; } = null!;

    private ToolStripMenuItem ctrl = new();

    public void Initialize(params object[] args)
    {
        Console.WriteLine($"Loading {Name}...");
        if (args != null)
        {
            SaveFileEditor = (ISaveFileProvider)Array.Find(args, z => z is ISaveFileProvider)!;
            LoadMenuStrip((ToolStrip)Array.Find(args, static z => z is ToolStrip)!);
        }
    }

    private void LoadMenuStrip(ToolStrip menuStrip)
    {
        if (menuStrip.Items.Find("Menu_Tools", false)[0] is not ToolStripDropDownItem tools)
            throw new ArgumentException(null, nameof(menuStrip));

        AddPluginControl(tools);
    }

    private void AddPluginControl(ToolStripDropDownItem tools)
    {
        ctrl = new(Name) { Text = "Location Data Editor", Visible = false };
        tools.DropDownItems.Add(ctrl);
        ctrl.Click += (s, e) => { _ = new MapDataEditorForm((SAV3)SaveFileEditor.SAV).ShowDialog(); };
    }

    public void NotifySaveLoaded()
    {
        if (ctrl != null)
        {
            ctrl.Visible = SaveFileEditor.SAV is SAV3 && SaveFileEditor.SAV.State.Exportable;
        }
    }
    public bool TryLoadFile(string filePath) => false;
}
