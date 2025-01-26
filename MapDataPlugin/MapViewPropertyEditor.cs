using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace MapDataPlugin;

public sealed class MapViewPropertyEditor : UITypeEditor
{
    public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext? context)
    {
        return UITypeEditorEditStyle.Modal;
    }

    public override object EditValue(ITypeDescriptorContext? context, IServiceProvider provider, object? value)
    {
        if (provider.GetService(typeof(IWindowsFormsEditorService)) is IWindowsFormsEditorService editorService)
        {
            using MapViewPropertyEditorForm form = new(value as MapView3 ?? new MapView3(new byte[MapView3.SIZE]));
            if (editorService.ShowDialog(form) == DialogResult.OK)
            {
                value = form.MapView;
            }
        }

        return value as MapView3 ?? new MapView3(new byte[MapView3.SIZE]);
    }
}
