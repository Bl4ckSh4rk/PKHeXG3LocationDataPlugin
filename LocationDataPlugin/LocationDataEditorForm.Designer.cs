namespace LocationDataPlugin
{
    partial class LocationDataEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImportMapViewButton = new System.Windows.Forms.Button();
            this.ExportMapViewButton = new System.Windows.Forms.Button();
            this.CurrentCoordXBox = new System.Windows.Forms.MaskedTextBox();
            this.CurrentCoordYBox = new System.Windows.Forms.MaskedTextBox();
            this.XCoordLabel = new System.Windows.Forms.Label();
            this.YCoordLabel = new System.Windows.Forms.Label();
            this.CurrentCoordsGroupBox = new System.Windows.Forms.GroupBox();
            this.MapViewDataGroupBox = new System.Windows.Forms.GroupBox();
            this.ClearMapViewButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WarpSelectionDropDown = new System.Windows.Forms.ComboBox();
            this.WarpMapsGroupBox = new System.Windows.Forms.GroupBox();
            this.WarpMapIdLabel = new System.Windows.Forms.Label();
            this.WarpMapGroupBox = new System.Windows.Forms.MaskedTextBox();
            this.WarpMapIdBox = new System.Windows.Forms.MaskedTextBox();
            this.WarpMapGroupLabel = new System.Windows.Forms.Label();
            this.WarpMapNumberLabel = new System.Windows.Forms.Label();
            this.WarpMapNumberBox = new System.Windows.Forms.MaskedTextBox();
            this.WarpCoordsGroupBox = new System.Windows.Forms.GroupBox();
            this.WarpCoordXLabel = new System.Windows.Forms.Label();
            this.WarpCoordYLabel = new System.Windows.Forms.Label();
            this.WarpCoordYBox = new System.Windows.Forms.MaskedTextBox();
            this.WarpCoordXBox = new System.Windows.Forms.MaskedTextBox();
            this.MiscGroupBox = new System.Windows.Forms.GroupBox();
            this.MapLayoutLabel = new System.Windows.Forms.Label();
            this.MapLayoutBox = new System.Windows.Forms.MaskedTextBox();
            this.FlashLevelLabel = new System.Windows.Forms.Label();
            this.FlashLevelBox = new System.Windows.Forms.MaskedTextBox();
            this.MusicLabel = new System.Windows.Forms.Label();
            this.MusicBox = new System.Windows.Forms.MaskedTextBox();
            this.WeatherStageLabel = new System.Windows.Forms.Label();
            this.WeatherStageBox = new System.Windows.Forms.MaskedTextBox();
            this.WeatherLabel = new System.Windows.Forms.Label();
            this.WeatherBox = new System.Windows.Forms.MaskedTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.CurrentCoordsGroupBox.SuspendLayout();
            this.MapViewDataGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.WarpMapsGroupBox.SuspendLayout();
            this.WarpCoordsGroupBox.SuspendLayout();
            this.MiscGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImportMapViewButton
            // 
            this.ImportMapViewButton.Location = new System.Drawing.Point(12, 19);
            this.ImportMapViewButton.Name = "ImportMapViewButton";
            this.ImportMapViewButton.Size = new System.Drawing.Size(50, 23);
            this.ImportMapViewButton.TabIndex = 0;
            this.ImportMapViewButton.Text = "Import";
            this.ImportMapViewButton.UseVisualStyleBackColor = true;
            this.ImportMapViewButton.Click += new System.EventHandler(this.ImportMapViewButton_Click);
            // 
            // ExportMapViewButton
            // 
            this.ExportMapViewButton.Location = new System.Drawing.Point(68, 19);
            this.ExportMapViewButton.Name = "ExportMapViewButton";
            this.ExportMapViewButton.Size = new System.Drawing.Size(50, 23);
            this.ExportMapViewButton.TabIndex = 1;
            this.ExportMapViewButton.Text = "Export";
            this.ExportMapViewButton.UseVisualStyleBackColor = true;
            this.ExportMapViewButton.Click += new System.EventHandler(this.ExportMapViewButton_Click);
            // 
            // CurrentCoordXBox
            // 
            this.CurrentCoordXBox.Location = new System.Drawing.Point(38, 21);
            this.CurrentCoordXBox.Mask = "00000";
            this.CurrentCoordXBox.Name = "CurrentCoordXBox";
            this.CurrentCoordXBox.Size = new System.Drawing.Size(42, 20);
            this.CurrentCoordXBox.TabIndex = 2;
            this.CurrentCoordXBox.TextChanged += new System.EventHandler(this.Validate_short);
            // 
            // CurrentCoordYBox
            // 
            this.CurrentCoordYBox.Location = new System.Drawing.Point(118, 21);
            this.CurrentCoordYBox.Mask = "00000";
            this.CurrentCoordYBox.Name = "CurrentCoordYBox";
            this.CurrentCoordYBox.Size = new System.Drawing.Size(42, 20);
            this.CurrentCoordYBox.TabIndex = 3;
            this.CurrentCoordYBox.TextChanged += new System.EventHandler(this.Validate_short);
            // 
            // XCoordLabel
            // 
            this.XCoordLabel.AutoSize = true;
            this.XCoordLabel.Location = new System.Drawing.Point(22, 24);
            this.XCoordLabel.Name = "XCoordLabel";
            this.XCoordLabel.Size = new System.Drawing.Size(14, 13);
            this.XCoordLabel.TabIndex = 4;
            this.XCoordLabel.Text = "X";
            // 
            // YCoordLabel
            // 
            this.YCoordLabel.AutoSize = true;
            this.YCoordLabel.Location = new System.Drawing.Point(102, 24);
            this.YCoordLabel.Name = "YCoordLabel";
            this.YCoordLabel.Size = new System.Drawing.Size(14, 13);
            this.YCoordLabel.TabIndex = 5;
            this.YCoordLabel.Text = "Y";
            // 
            // CurrentCoordsGroupBox
            // 
            this.CurrentCoordsGroupBox.Controls.Add(this.XCoordLabel);
            this.CurrentCoordsGroupBox.Controls.Add(this.YCoordLabel);
            this.CurrentCoordsGroupBox.Controls.Add(this.CurrentCoordYBox);
            this.CurrentCoordsGroupBox.Controls.Add(this.CurrentCoordXBox);
            this.CurrentCoordsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.CurrentCoordsGroupBox.Name = "CurrentCoordsGroupBox";
            this.CurrentCoordsGroupBox.Size = new System.Drawing.Size(186, 58);
            this.CurrentCoordsGroupBox.TabIndex = 6;
            this.CurrentCoordsGroupBox.TabStop = false;
            this.CurrentCoordsGroupBox.Text = "Current Position";
            // 
            // MapViewDataGroupBox
            // 
            this.MapViewDataGroupBox.Controls.Add(this.ClearMapViewButton);
            this.MapViewDataGroupBox.Controls.Add(this.ImportMapViewButton);
            this.MapViewDataGroupBox.Controls.Add(this.ExportMapViewButton);
            this.MapViewDataGroupBox.Location = new System.Drawing.Point(12, 81);
            this.MapViewDataGroupBox.Name = "MapViewDataGroupBox";
            this.MapViewDataGroupBox.Size = new System.Drawing.Size(186, 56);
            this.MapViewDataGroupBox.TabIndex = 7;
            this.MapViewDataGroupBox.TabStop = false;
            this.MapViewDataGroupBox.Text = "Map Data";
            // 
            // ClearMapViewButton
            // 
            this.ClearMapViewButton.Location = new System.Drawing.Point(124, 19);
            this.ClearMapViewButton.Name = "ClearMapViewButton";
            this.ClearMapViewButton.Size = new System.Drawing.Size(50, 23);
            this.ClearMapViewButton.TabIndex = 2;
            this.ClearMapViewButton.Text = "Clear";
            this.ClearMapViewButton.UseVisualStyleBackColor = true;
            this.ClearMapViewButton.Click += new System.EventHandler(this.ClearMapViewButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WarpSelectionDropDown);
            this.groupBox1.Controls.Add(this.WarpMapsGroupBox);
            this.groupBox1.Controls.Add(this.WarpCoordsGroupBox);
            this.groupBox1.Location = new System.Drawing.Point(214, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 168);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Warp Data";
            // 
            // WarpSelectionDropDown
            // 
            this.WarpSelectionDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WarpSelectionDropDown.FormattingEnabled = true;
            this.WarpSelectionDropDown.Items.AddRange(new object[] {
            "Warp Location",
            "Continue Game Warp",
            "Dynamic Warp",
            "Last Heal Warp",
            "Escape Warp"});
            this.WarpSelectionDropDown.Location = new System.Drawing.Point(6, 19);
            this.WarpSelectionDropDown.MaxDropDownItems = 5;
            this.WarpSelectionDropDown.Name = "WarpSelectionDropDown";
            this.WarpSelectionDropDown.Size = new System.Drawing.Size(199, 21);
            this.WarpSelectionDropDown.TabIndex = 10;
            this.WarpSelectionDropDown.SelectedIndexChanged += new System.EventHandler(this.WarpSelectionDropDown_SelectedIndexChanged);
            // 
            // WarpMapsGroupBox
            // 
            this.WarpMapsGroupBox.Controls.Add(this.WarpMapIdLabel);
            this.WarpMapsGroupBox.Controls.Add(this.WarpMapGroupBox);
            this.WarpMapsGroupBox.Controls.Add(this.WarpMapIdBox);
            this.WarpMapsGroupBox.Controls.Add(this.WarpMapGroupLabel);
            this.WarpMapsGroupBox.Controls.Add(this.WarpMapNumberLabel);
            this.WarpMapsGroupBox.Controls.Add(this.WarpMapNumberBox);
            this.WarpMapsGroupBox.Location = new System.Drawing.Point(6, 50);
            this.WarpMapsGroupBox.Name = "WarpMapsGroupBox";
            this.WarpMapsGroupBox.Size = new System.Drawing.Size(108, 112);
            this.WarpMapsGroupBox.TabIndex = 9;
            this.WarpMapsGroupBox.TabStop = false;
            this.WarpMapsGroupBox.Text = "Map";
            // 
            // WarpMapIdLabel
            // 
            this.WarpMapIdLabel.AutoSize = true;
            this.WarpMapIdLabel.Location = new System.Drawing.Point(10, 76);
            this.WarpMapIdLabel.Name = "WarpMapIdLabel";
            this.WarpMapIdLabel.Size = new System.Drawing.Size(18, 13);
            this.WarpMapIdLabel.TabIndex = 13;
            this.WarpMapIdLabel.Text = "ID";
            // 
            // WarpMapGroupBox
            // 
            this.WarpMapGroupBox.Location = new System.Drawing.Point(60, 22);
            this.WarpMapGroupBox.Mask = "000";
            this.WarpMapGroupBox.Name = "WarpMapGroupBox";
            this.WarpMapGroupBox.Size = new System.Drawing.Size(30, 20);
            this.WarpMapGroupBox.TabIndex = 8;
            this.WarpMapGroupBox.TextChanged += new System.EventHandler(this.Validate_byte);
            // 
            // WarpMapIdBox
            // 
            this.WarpMapIdBox.Location = new System.Drawing.Point(60, 74);
            this.WarpMapIdBox.Mask = "000";
            this.WarpMapIdBox.Name = "WarpMapIdBox";
            this.WarpMapIdBox.Size = new System.Drawing.Size(30, 20);
            this.WarpMapIdBox.TabIndex = 12;
            this.WarpMapIdBox.TextChanged += new System.EventHandler(this.Validate_byte);
            // 
            // WarpMapGroupLabel
            // 
            this.WarpMapGroupLabel.AutoSize = true;
            this.WarpMapGroupLabel.Location = new System.Drawing.Point(10, 24);
            this.WarpMapGroupLabel.Name = "WarpMapGroupLabel";
            this.WarpMapGroupLabel.Size = new System.Drawing.Size(36, 13);
            this.WarpMapGroupLabel.TabIndex = 9;
            this.WarpMapGroupLabel.Text = "Group";
            // 
            // WarpMapNumberLabel
            // 
            this.WarpMapNumberLabel.AutoSize = true;
            this.WarpMapNumberLabel.Location = new System.Drawing.Point(10, 50);
            this.WarpMapNumberLabel.Name = "WarpMapNumberLabel";
            this.WarpMapNumberLabel.Size = new System.Drawing.Size(44, 13);
            this.WarpMapNumberLabel.TabIndex = 11;
            this.WarpMapNumberLabel.Text = "Number";
            // 
            // WarpMapNumberBox
            // 
            this.WarpMapNumberBox.Location = new System.Drawing.Point(60, 48);
            this.WarpMapNumberBox.Mask = "000";
            this.WarpMapNumberBox.Name = "WarpMapNumberBox";
            this.WarpMapNumberBox.Size = new System.Drawing.Size(30, 20);
            this.WarpMapNumberBox.TabIndex = 10;
            this.WarpMapNumberBox.TextChanged += new System.EventHandler(this.Validate_byte);
            // 
            // WarpCoordsGroupBox
            // 
            this.WarpCoordsGroupBox.Controls.Add(this.WarpCoordXLabel);
            this.WarpCoordsGroupBox.Controls.Add(this.WarpCoordYLabel);
            this.WarpCoordsGroupBox.Controls.Add(this.WarpCoordYBox);
            this.WarpCoordsGroupBox.Controls.Add(this.WarpCoordXBox);
            this.WarpCoordsGroupBox.Location = new System.Drawing.Point(120, 50);
            this.WarpCoordsGroupBox.Name = "WarpCoordsGroupBox";
            this.WarpCoordsGroupBox.Size = new System.Drawing.Size(85, 112);
            this.WarpCoordsGroupBox.TabIndex = 7;
            this.WarpCoordsGroupBox.TabStop = false;
            this.WarpCoordsGroupBox.Text = "Coordinates";
            // 
            // WarpCoordXLabel
            // 
            this.WarpCoordXLabel.AutoSize = true;
            this.WarpCoordXLabel.Location = new System.Drawing.Point(10, 39);
            this.WarpCoordXLabel.Name = "WarpCoordXLabel";
            this.WarpCoordXLabel.Size = new System.Drawing.Size(14, 13);
            this.WarpCoordXLabel.TabIndex = 4;
            this.WarpCoordXLabel.Text = "X";
            // 
            // WarpCoordYLabel
            // 
            this.WarpCoordYLabel.AutoSize = true;
            this.WarpCoordYLabel.Location = new System.Drawing.Point(10, 65);
            this.WarpCoordYLabel.Name = "WarpCoordYLabel";
            this.WarpCoordYLabel.Size = new System.Drawing.Size(14, 13);
            this.WarpCoordYLabel.TabIndex = 5;
            this.WarpCoordYLabel.Text = "Y";
            // 
            // WarpCoordYBox
            // 
            this.WarpCoordYBox.Location = new System.Drawing.Point(26, 62);
            this.WarpCoordYBox.Mask = "00000";
            this.WarpCoordYBox.Name = "WarpCoordYBox";
            this.WarpCoordYBox.Size = new System.Drawing.Size(42, 20);
            this.WarpCoordYBox.TabIndex = 3;
            this.WarpCoordYBox.TextChanged += new System.EventHandler(this.Validate_short);
            // 
            // WarpCoordXBox
            // 
            this.WarpCoordXBox.Location = new System.Drawing.Point(26, 36);
            this.WarpCoordXBox.Mask = "00000";
            this.WarpCoordXBox.Name = "WarpCoordXBox";
            this.WarpCoordXBox.Size = new System.Drawing.Size(42, 20);
            this.WarpCoordXBox.TabIndex = 2;
            this.WarpCoordXBox.TextChanged += new System.EventHandler(this.Validate_short);
            // 
            // MiscGroupBox
            // 
            this.MiscGroupBox.Controls.Add(this.MapLayoutLabel);
            this.MiscGroupBox.Controls.Add(this.MapLayoutBox);
            this.MiscGroupBox.Controls.Add(this.FlashLevelLabel);
            this.MiscGroupBox.Controls.Add(this.FlashLevelBox);
            this.MiscGroupBox.Controls.Add(this.MusicLabel);
            this.MiscGroupBox.Controls.Add(this.MusicBox);
            this.MiscGroupBox.Controls.Add(this.WeatherStageLabel);
            this.MiscGroupBox.Controls.Add(this.WeatherStageBox);
            this.MiscGroupBox.Controls.Add(this.WeatherLabel);
            this.MiscGroupBox.Controls.Add(this.WeatherBox);
            this.MiscGroupBox.Location = new System.Drawing.Point(441, 12);
            this.MiscGroupBox.Name = "MiscGroupBox";
            this.MiscGroupBox.Size = new System.Drawing.Size(145, 168);
            this.MiscGroupBox.TabIndex = 9;
            this.MiscGroupBox.TabStop = false;
            this.MiscGroupBox.Text = "Misc";
            // 
            // MapLayoutLabel
            // 
            this.MapLayoutLabel.AutoSize = true;
            this.MapLayoutLabel.Location = new System.Drawing.Point(16, 130);
            this.MapLayoutLabel.Name = "MapLayoutLabel";
            this.MapLayoutLabel.Size = new System.Drawing.Size(63, 13);
            this.MapLayoutLabel.TabIndex = 23;
            this.MapLayoutLabel.Text = "Map Layout";
            // 
            // MapLayoutBox
            // 
            this.MapLayoutBox.Location = new System.Drawing.Point(97, 128);
            this.MapLayoutBox.Mask = "00000";
            this.MapLayoutBox.Name = "MapLayoutBox";
            this.MapLayoutBox.Size = new System.Drawing.Size(42, 20);
            this.MapLayoutBox.TabIndex = 22;
            this.MapLayoutBox.TextChanged += new System.EventHandler(this.Validate_ushort);
            // 
            // FlashLevelLabel
            // 
            this.FlashLevelLabel.AutoSize = true;
            this.FlashLevelLabel.Location = new System.Drawing.Point(16, 104);
            this.FlashLevelLabel.Name = "FlashLevelLabel";
            this.FlashLevelLabel.Size = new System.Drawing.Size(61, 13);
            this.FlashLevelLabel.TabIndex = 21;
            this.FlashLevelLabel.Text = "Flash Level";
            // 
            // FlashLevelBox
            // 
            this.FlashLevelBox.Location = new System.Drawing.Point(97, 102);
            this.FlashLevelBox.Mask = "000";
            this.FlashLevelBox.Name = "FlashLevelBox";
            this.FlashLevelBox.Size = new System.Drawing.Size(30, 20);
            this.FlashLevelBox.TabIndex = 20;
            this.FlashLevelBox.TextChanged += new System.EventHandler(this.Validate_byte);
            // 
            // MusicLabel
            // 
            this.MusicLabel.AutoSize = true;
            this.MusicLabel.Location = new System.Drawing.Point(16, 78);
            this.MusicLabel.Name = "MusicLabel";
            this.MusicLabel.Size = new System.Drawing.Size(35, 13);
            this.MusicLabel.TabIndex = 19;
            this.MusicLabel.Text = "Music";
            // 
            // MusicBox
            // 
            this.MusicBox.Location = new System.Drawing.Point(97, 76);
            this.MusicBox.Mask = "00000";
            this.MusicBox.Name = "MusicBox";
            this.MusicBox.Size = new System.Drawing.Size(42, 20);
            this.MusicBox.TabIndex = 18;
            this.MusicBox.TextChanged += new System.EventHandler(this.Validate_ushort);
            // 
            // WeatherStageLabel
            // 
            this.WeatherStageLabel.AutoSize = true;
            this.WeatherStageLabel.Location = new System.Drawing.Point(16, 52);
            this.WeatherStageLabel.Name = "WeatherStageLabel";
            this.WeatherStageLabel.Size = new System.Drawing.Size(79, 13);
            this.WeatherStageLabel.TabIndex = 17;
            this.WeatherStageLabel.Text = "Weather Stage";
            // 
            // WeatherStageBox
            // 
            this.WeatherStageBox.Location = new System.Drawing.Point(97, 50);
            this.WeatherStageBox.Mask = "000";
            this.WeatherStageBox.Name = "WeatherStageBox";
            this.WeatherStageBox.Size = new System.Drawing.Size(30, 20);
            this.WeatherStageBox.TabIndex = 16;
            this.WeatherStageBox.TextChanged += new System.EventHandler(this.Validate_byte);
            // 
            // WeatherLabel
            // 
            this.WeatherLabel.AutoSize = true;
            this.WeatherLabel.Location = new System.Drawing.Point(16, 26);
            this.WeatherLabel.Name = "WeatherLabel";
            this.WeatherLabel.Size = new System.Drawing.Size(48, 13);
            this.WeatherLabel.TabIndex = 15;
            this.WeatherLabel.Text = "Weather";
            // 
            // WeatherBox
            // 
            this.WeatherBox.Location = new System.Drawing.Point(97, 24);
            this.WeatherBox.Mask = "000";
            this.WeatherBox.Name = "WeatherBox";
            this.WeatherBox.Size = new System.Drawing.Size(30, 20);
            this.WeatherBox.TabIndex = 14;
            this.WeatherBox.TextChanged += new System.EventHandler(this.Validate_byte);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(511, 186);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // WarningLabel
            // 
            this.WarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(32, 149);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(141, 57);
            this.WarningLabel.TabIndex = 11;
            this.WarningLabel.Text = "WARNING:\r\nUse at your own risk!\r\nKeep a backup!";
            this.WarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LocationDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 221);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.MiscGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MapViewDataGroupBox);
            this.Controls.Add(this.CurrentCoordsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LocationDataForm";
            this.Text = "Location Data Editor";
            this.CurrentCoordsGroupBox.ResumeLayout(false);
            this.CurrentCoordsGroupBox.PerformLayout();
            this.MapViewDataGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.WarpMapsGroupBox.ResumeLayout(false);
            this.WarpMapsGroupBox.PerformLayout();
            this.WarpCoordsGroupBox.ResumeLayout(false);
            this.WarpCoordsGroupBox.PerformLayout();
            this.MiscGroupBox.ResumeLayout(false);
            this.MiscGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ImportMapViewButton;
        private System.Windows.Forms.Button ExportMapViewButton;
        private System.Windows.Forms.MaskedTextBox CurrentCoordXBox;
        private System.Windows.Forms.MaskedTextBox CurrentCoordYBox;
        private System.Windows.Forms.Label XCoordLabel;
        private System.Windows.Forms.Label YCoordLabel;
        private System.Windows.Forms.GroupBox CurrentCoordsGroupBox;
        private System.Windows.Forms.GroupBox MapViewDataGroupBox;
        private System.Windows.Forms.Button ClearMapViewButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox WarpMapGroupBox;
        private System.Windows.Forms.GroupBox WarpCoordsGroupBox;
        private System.Windows.Forms.Label WarpCoordXLabel;
        private System.Windows.Forms.Label WarpCoordYLabel;
        private System.Windows.Forms.MaskedTextBox WarpCoordYBox;
        private System.Windows.Forms.MaskedTextBox WarpCoordXBox;
        private System.Windows.Forms.Label WarpMapGroupLabel;
        private System.Windows.Forms.Label WarpMapNumberLabel;
        private System.Windows.Forms.MaskedTextBox WarpMapNumberBox;
        private System.Windows.Forms.Label WarpMapIdLabel;
        private System.Windows.Forms.MaskedTextBox WarpMapIdBox;
        private System.Windows.Forms.GroupBox WarpMapsGroupBox;
        private System.Windows.Forms.ComboBox WarpSelectionDropDown;
        private System.Windows.Forms.GroupBox MiscGroupBox;
        private System.Windows.Forms.Label WeatherStageLabel;
        private System.Windows.Forms.MaskedTextBox WeatherStageBox;
        private System.Windows.Forms.Label WeatherLabel;
        private System.Windows.Forms.MaskedTextBox WeatherBox;
        private System.Windows.Forms.Label MusicLabel;
        private System.Windows.Forms.MaskedTextBox MusicBox;
        private System.Windows.Forms.Label FlashLevelLabel;
        private System.Windows.Forms.MaskedTextBox FlashLevelBox;
        private System.Windows.Forms.Label MapLayoutLabel;
        private System.Windows.Forms.MaskedTextBox MapLayoutBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label WarningLabel;
    }
}

