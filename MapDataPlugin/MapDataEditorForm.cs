using System;
using System.IO;
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

    private void ImportButton_Click(object sender, EventArgs e)
    {
        using var ofd = new OpenFileDialog();
        ofd.Filter = $"Binary Files (*.bin)|*.bin|All Files (*.*)|*.*";
        ofd.Title = "Import Data";
        ofd.FilterIndex = 1;

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            long fileSize = new FileInfo(ofd.FileName).Length;
            if (fileSize != MapData3.SIZE)
            {
                MessageBox.Show($"Invalid file size. Expected {MapData3.SIZE} bytes, got {fileSize} bytes.", "Invalid File Size", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            md.SetData(File.ReadAllBytes(ofd.FileName));
        }
    }

    private void ExportButton_Click(object sender, EventArgs e)
    {
        using var sfd = new SaveFileDialog();
        sfd.Filter = $"Binary Files (*.bin)|*.bin|All Files (*.*)|*.*";
        sfd.Title = "Export Data";
        sfd.FilterIndex = 1;

        if (sfd.ShowDialog() == DialogResult.OK)
        {
            File.WriteAllBytes(sfd.FileName, md.GetData());
        }
    }
}
