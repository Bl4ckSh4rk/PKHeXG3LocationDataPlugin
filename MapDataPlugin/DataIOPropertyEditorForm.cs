using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace MapDataPlugin;

public partial class DataIOPropertyEditorForm : Form
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public byte[] Data { get; private set; }
    private readonly int expectedSize;

    public DataIOPropertyEditorForm(byte[] data)
    {
        InitializeComponent();
        Data = data;
        expectedSize = data.Length;
    }

    private void ImportButton_Click(object sender, System.EventArgs e)
    {
        using var ofd = new OpenFileDialog();
        ofd.Filter = $"Binary Files (*.bin)|*.bin|All Files (*.*)|*.*";
        ofd.Title = "Import Data";
        ofd.FilterIndex = 1;

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            long fileSize = new FileInfo(ofd.FileName).Length;
            if (fileSize != expectedSize)
            {
                MessageBox.Show($"Invalid file size. Expected {expectedSize} bytes, got {fileSize} bytes.", "Invalid File Size", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Data = File.ReadAllBytes(ofd.FileName);
        }
        Close();
    }

    private void ExportButton_Click(object sender, System.EventArgs e)
    {
        using var sfd = new SaveFileDialog();
        sfd.Filter = $"Binary Files (*.bin)|*.bin|All Files (*.*)|*.*";
        sfd.Title = "Export Data";
        sfd.FilterIndex = 1;

        if (sfd.ShowDialog() == DialogResult.OK)
        {
            File.WriteAllBytes(sfd.FileName, Data);
        }
        Close();
    }
}
