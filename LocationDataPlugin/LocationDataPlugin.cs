using System;
using System.Windows.Forms;
using PKHeX.Core;

namespace LocationDataPlugin
{
    public class LocationDataEditor : IPlugin
    {
        public string Name => "Location Data Editor";
        public int Priority => 1; // Loading order, lowest is first.
        public ISaveFileProvider SaveFileEditor { get; private set; } = null!;

        private ToolStripMenuItem? ctrl;

        public void Initialize(params object[] args)
        {
            Console.WriteLine($"Loading {Name}...");
            SaveFileEditor = (ISaveFileProvider)Array.Find(args, z => z is ISaveFileProvider)!;
            var menu = (ToolStrip)Array.Find(args, z => z is ToolStrip);
            LoadMenuStrip(menu);
        }

        private void LoadMenuStrip(ToolStrip menuStrip)
        {
            var items = menuStrip.Items;
            var tools = (ToolStripDropDownItem)items.Find("Menu_Tools", false)[0];
            AddPluginControl(tools);
        }

        private void AddPluginControl(ToolStripDropDownItem tools)
        {
            ctrl = new ToolStripMenuItem(Name);
            ctrl.Visible = false;
            tools.DropDownItems.Add(ctrl);
            ctrl.Click += new EventHandler(OpenMapEditor);
        }

        private void OpenMapEditor(object sender, EventArgs e)
        {
            using LocationDataEditorForm mdf = new((SAV3)SaveFileEditor.SAV);
            _ = mdf.ShowDialog();
        }

        public void NotifySaveLoaded()
        {
            if (ctrl != null)
                ctrl.Visible = SaveFileEditor.SAV is SAV3;
        }
        public bool TryLoadFile(string filePath)
        {
            Console.WriteLine($"{Name} was provided with the file path, but chose to do nothing with it.");
            return false; // no action taken
        }
    }
}
