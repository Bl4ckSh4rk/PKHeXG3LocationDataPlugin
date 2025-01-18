using System;
using System.Windows.Forms;
using PKHeX.Core;

namespace LocationDataPlugin;

public partial class LocationDataEditorForm : Form
{
    private readonly MapData3 md;

    public LocationDataEditorForm(SAV3 sav)
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
