namespace MapDataPlugin;

partial class DataIOPropertyEditorForm
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
        ImportButton = new System.Windows.Forms.Button();
        ExportButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // ImportButton
        // 
        ImportButton.DialogResult = System.Windows.Forms.DialogResult.OK;
        ImportButton.Location = new System.Drawing.Point(39, 44);
        ImportButton.Name = "ImportButton";
        ImportButton.Size = new System.Drawing.Size(75, 23);
        ImportButton.TabIndex = 0;
        ImportButton.Text = "Import";
        ImportButton.UseVisualStyleBackColor = true;
        ImportButton.Click += ImportButton_Click;
        // 
        // ExportButton
        // 
        ExportButton.DialogResult = System.Windows.Forms.DialogResult.OK;
        ExportButton.Location = new System.Drawing.Point(140, 44);
        ExportButton.Name = "ExportButton";
        ExportButton.Size = new System.Drawing.Size(75, 23);
        ExportButton.TabIndex = 1;
        ExportButton.Text = "Export";
        ExportButton.UseVisualStyleBackColor = true;
        ExportButton.Click += ExportButton_Click;
        // 
        // DataIOPropertyEditorForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(255, 111);
        Controls.Add(ExportButton);
        Controls.Add(ImportButton);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "DataIOPropertyEditorForm";
        ShowIcon = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Data I/O";
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Button ImportButton;
    private System.Windows.Forms.Button ExportButton;
}
