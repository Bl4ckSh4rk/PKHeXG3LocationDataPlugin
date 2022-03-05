using System;
using System.IO;
using System.Windows.Forms;
using PKHeX.Core;

namespace LocationDataPlugin
{
    public partial class LocationDataEditorForm : Form
    {
        private readonly SAV3 sav;

        private int LocationDataOffset => 0; // Block 1, 0x000 - 0x33
        private int MapViewOffset => sav is SAV3RS or SAV3E ? 0x34 : 0x898; // Block 1, 0x034 - 0x233 (RSE), 0x898 - 0xA97 (FRLG)

        private readonly LocationData3 data;
        private readonly WarpData3[] warp = new WarpData3[5];
        private int selected = 0;

        public LocationDataEditorForm(SAV3 sav)
        {
            InitializeComponent();

            this.sav = sav;
            data = new(sav.Large.Slice(LocationDataOffset, LocationData3.SIZE));

            CurrentCoordXBox.Text = data.CurrentPosition.X.ToString();
            CurrentCoordYBox.Text = data.CurrentPosition.Y.ToString();

            WeatherBox.Text = data.Weather.ToString();
            WeatherStageBox.Text = data.WeatherCycleStage.ToString();
            MusicBox.Text = data.Music.ToString();
            FlashLevelBox.Text = data.FlashLevel.ToString();
            MapLayoutBox.Text = data.MapLayoutId.ToString();

            warp[0] = data.WarpLocation;
            warp[1] = data.ContinueGameWarp;
            warp[2] = data.DynamicWarp;
            warp[3] = data.LastHealWarp;
            warp[4] = data.EscapeWarp;

            WarpMapGroupBox.Text = warp[selected].Group.ToString();
            WarpMapNumberBox.Text = warp[selected].Number.ToString();
            WarpMapIdBox.Text = warp[selected].Id.ToString();
            WarpCoordXBox.Text = warp[selected].Coords.X.ToString();
            WarpCoordYBox.Text = warp[selected].Coords.Y.ToString();

            WarpSelectionDropDown.SelectedIndex = 0;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            warp[selected].Group = byte.TryParse(WarpMapGroupBox.Text, out var g) ? g : (byte)0;
            warp[selected].Number = byte.TryParse(WarpMapNumberBox.Text, out var n) ? n : (byte)0;
            warp[selected].Id = byte.TryParse(WarpMapIdBox.Text, out var i) ? i : (byte)0;
            warp[selected].Coords = new(short.TryParse(WarpCoordXBox.Text, out var wx) ? wx : (short)0, short.TryParse(WarpCoordYBox.Text, out var wy) ? wy : (short)0);

            data.WarpLocation = warp[0];
            data.ContinueGameWarp = warp[1];
            data.DynamicWarp = warp[2];
            data.LastHealWarp = warp[3];
            data.EscapeWarp = warp[4];

            data.CurrentPosition = new(short.TryParse(CurrentCoordXBox.Text, out var cx) ? cx : (short)0, short.TryParse(CurrentCoordYBox.Text, out var cy) ? cy : (short)0);

            data.Weather = byte.TryParse(WeatherBox.Text, out var w) ? w : (byte)0;
            data.WeatherCycleStage = byte.TryParse(WeatherStageBox.Text, out var wcs) ? wcs : (byte)0;
            data.Music = ushort.TryParse(MusicBox.Text, out var m) ? m : (ushort)0;
            data.FlashLevel = byte.TryParse(FlashLevelBox.Text, out var fl) ? fl : (byte)0;
            data.MapLayoutId = ushort.TryParse(MapLayoutBox.Text, out var mli) ? mli : (ushort)0;

            data.Data.CopyTo(sav.Large, 0);
            Close();
        }

        private void WarpSelectionDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            warp[selected].Group = byte.TryParse(WarpMapGroupBox.Text, out var g) ? g : (byte)0;
            warp[selected].Number = byte.TryParse(WarpMapNumberBox.Text, out var n) ? n : (byte)0;
            warp[selected].Id = byte.TryParse(WarpMapIdBox.Text, out var i) ? i : (byte)0;
            warp[selected].Coords = new(short.TryParse(WarpCoordXBox.Text, out var x) ? x : (short)0, short.TryParse(WarpCoordYBox.Text, out var y) ? y : (short)0);

            selected = WarpSelectionDropDown.SelectedIndex;

            WarpMapGroupBox.Text = warp[selected].Group.ToString();
            WarpMapNumberBox.Text = warp[selected].Number.ToString();
            WarpMapIdBox.Text = warp[selected].Id.ToString();

            WarpCoordXBox.Text = warp[selected].Coords.X.ToString();
            WarpCoordYBox.Text = warp[selected].Coords.Y.ToString();
        }

        private void ImportMapViewButton_Click(object sender, EventArgs e)
        {
            bool success = false;

            using var ofd = new OpenFileDialog();
            ofd.Filter = "Binary files (*.bin)|*.bin|All files (*.*)|*.*";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                long fileSize = new FileInfo(ofd.FileName).Length;

                if (fileSize == MapView3.SIZE)
                {
                    try
                    {
                        File.ReadAllBytes(ofd.FileName).CopyTo(sav.Large, MapViewOffset);

                        success = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"Unable to read Map View data:\n{ofd.FileName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Invalid file size:{fileSize} bytes\nExpected: {MapView3.SIZE} bytes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (success)
            {
                MessageBox.Show("Map View data imported!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExportMapViewButton_Click(object sender, EventArgs e)
        {
            bool success = false;

            using var sfd = new SaveFileDialog();
            sfd.Filter = "Binary files (*.bin)|*.bin|All files (*.*)|*.*";
            sfd.FilterIndex = 1;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllBytes(sfd.FileName, sav.Large.Slice(MapViewOffset, MapView3.SIZE));

                    success = true;
                }
                catch (Exception)
                {
                    MessageBox.Show($"Unable to write Map View data:\n{sfd.FileName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (success)
            {
                MessageBox.Show($"Map View data exported to:\n{sfd.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearMapViewButton_Click(object sender, EventArgs e)
        {
            new MapView3().Data.CopyTo(sav.Large, MapViewOffset);
        }

        private void Validate_ushort(object sender, EventArgs e)
        {
            MaskedTextBox mb = (MaskedTextBox)sender;

            string text = mb.Text;
            if (string.IsNullOrWhiteSpace(text))
                mb.Text = ushort.MinValue.ToString();
            else if (Convert.ToUInt32(text) > ushort.MaxValue)
                mb.Text = ushort.MaxValue.ToString();
        }

        private void Validate_short(object sender, EventArgs e)
        {
            MaskedTextBox mb = (MaskedTextBox)sender;

            string text = mb.Text;
            if (string.IsNullOrWhiteSpace(text))
                mb.Text = short.MinValue.ToString();
            else if (Convert.ToInt32(text) > short.MaxValue)
                mb.Text = short.MaxValue.ToString();
        }

        private void Validate_byte(object sender, EventArgs e)
        {
            MaskedTextBox mb = (MaskedTextBox)sender;

            string text = mb.Text;
            if (string.IsNullOrWhiteSpace(text))
                mb.Text = byte.MinValue.ToString();
            else if (Convert.ToInt32(text) > byte.MaxValue)
                mb.Text = byte.MaxValue.ToString();
        }
    }
}
