using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace MapDataPlugin;

public sealed class DataIOPropertyEditor : UITypeEditor
{
    public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext? context)
    {
        return UITypeEditorEditStyle.Modal;
    }

    public override object EditValue(ITypeDescriptorContext? context, IServiceProvider provider, object? value)
    {
        if (provider.GetService(typeof(IWindowsFormsEditorService)) is IWindowsFormsEditorService editorService)
        {
            using DataIOPropertyEditorForm form = new(((IRawDataAccessor)value!).Data.ToArray()!);
            if (editorService.ShowDialog(form) == DialogResult.OK)
            {
                ((IRawDataAccessor)value!).Data = form.Data;
            }
        }

        return value!;
    }
}
