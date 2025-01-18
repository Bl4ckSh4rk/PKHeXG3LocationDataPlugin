namespace LocationDataPlugin;

public partial class LocationDataEditorForm
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
        SaveButton = new System.Windows.Forms.Button();
        WarningLabel = new System.Windows.Forms.Label();
        MapDataPropertyGrid = new System.Windows.Forms.PropertyGrid();
        SuspendLayout();
        // 
        // SaveButton
        // 
        SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        SaveButton.Location = new System.Drawing.Point(603, 354);
        SaveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        SaveButton.Name = "SaveButton";
        SaveButton.Size = new System.Drawing.Size(88, 25);
        SaveButton.TabIndex = 10;
        SaveButton.Text = "Save";
        SaveButton.UseVisualStyleBackColor = true;
        SaveButton.Click += SaveButton_Click;
        // 
        // WarningLabel
        // 
        WarningLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        WarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
        WarningLabel.ForeColor = System.Drawing.Color.Red;
        WarningLabel.Location = new System.Drawing.Point(13, 353);
        WarningLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        WarningLabel.Name = "WarningLabel";
        WarningLabel.Size = new System.Drawing.Size(564, 31);
        WarningLabel.TabIndex = 11;
        WarningLabel.Text = "WARNING: Use at your own risk! Keep a backup!";
        WarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // MapDataPropertyGrid
        // 
        MapDataPropertyGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        MapDataPropertyGrid.BackColor = System.Drawing.SystemColors.Control;
        MapDataPropertyGrid.HelpVisible = false;
        MapDataPropertyGrid.Location = new System.Drawing.Point(0, 0);
        MapDataPropertyGrid.Name = "MapDataPropertyGrid";
        MapDataPropertyGrid.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
        MapDataPropertyGrid.Size = new System.Drawing.Size(704, 347);
        MapDataPropertyGrid.TabIndex = 12;
        MapDataPropertyGrid.ToolbarVisible = false;
        // 
        // LocationDataEditorForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        AutoScroll = true;
        ClientSize = new System.Drawing.Size(704, 391);
        Controls.Add(MapDataPropertyGrid);
        Controls.Add(WarningLabel);
        Controls.Add(SaveButton);
        Font = new System.Drawing.Font("Consolas", 9F);
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(350, 320);
        Name = "LocationDataEditorForm";
        SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Location Data Editor";
        ResumeLayout(false);
    }

    #endregion
    private System.Windows.Forms.Button SaveButton;
    private System.Windows.Forms.Label WarningLabel;
    private System.Windows.Forms.PropertyGrid MapDataPropertyGrid;
}
