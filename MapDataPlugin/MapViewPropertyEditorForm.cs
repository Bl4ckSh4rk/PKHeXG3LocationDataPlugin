using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace MapDataPlugin;

public partial class MapViewPropertyEditorForm : Form
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public MapView3 MapView { get; private set; }

    public MapViewPropertyEditorForm(MapView3 mapview)
    {
        InitializeComponent();
        MapView = mapview;
    }

    private void ImportButton_Click(object sender, System.EventArgs e)
    {
        using var ofd = new OpenFileDialog();
        ofd.Filter = $"Binary Files (*.bin)|*.bin|All Files (*.*)|*.*";
        ofd.Title = "Import Map View Data";
        ofd.FilterIndex = 1;

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            long fileSize = new FileInfo(ofd.FileName).Length;
            if (fileSize != MapView3.SIZE)
            {
                MessageBox.Show($"Invalid file size. Expected {MapView3.SIZE} bytes, got {fileSize} bytes.", "Invalid File Size", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MapView = new(File.ReadAllBytes(ofd.FileName));
        }
        Close();
    }

    private void ExportButton_Click(object sender, System.EventArgs e)
    {
        using var sfd = new SaveFileDialog();
        sfd.Filter = $"Binary Files (*.bin)|*.bin|All Files (*.*)|*.*";
        sfd.Title = "Export Map View Data";
        sfd.FilterIndex = 1;

        if (sfd.ShowDialog() == DialogResult.OK)
        {
            File.WriteAllBytes(sfd.FileName, MapView.Data.ToArray());
        }
        Close();
    }
}
