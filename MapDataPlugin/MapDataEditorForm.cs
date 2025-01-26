using System;
using System.Windows.Forms;
using PKHeX.Core;

namespace MapDataPlugin;

public partial class MapDataEditorForm : Form
{
    private readonly MapData3 md;

    public MapDataEditorForm(SAV3 sav)
    {
        InitializeComponent();

        MapDataPropertyGrid.SelectedObject = md = new MapData3(sav);
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        md.Write();
        Close();
    }
}
