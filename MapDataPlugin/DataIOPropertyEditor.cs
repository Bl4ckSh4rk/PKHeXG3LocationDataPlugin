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
        byte[] data = ((IRawDataAccessor)value!).Data.ToArray()!;
        if (provider.GetService(typeof(IWindowsFormsEditorService)) is IWindowsFormsEditorService editorService)
        {
            using DataIOPropertyEditorForm form = new(data);
            if (editorService.ShowDialog(form) == DialogResult.OK)
            {
                data = form.Data;
            }
        }

        string propertyName = context?.PropertyDescriptor?.PropertyType.Name!;
        if (propertyName == nameof(Coords))
            value = new Coords(data);
        if (propertyName == nameof(MiscMapData3))
            value = new MiscMapData3(data);
        if (propertyName == nameof(ObjectEvent3Data))
            value = new ObjectEvent3Data(data);
        if (propertyName == nameof(ObjectEvent3TemplateData))
            value = new ObjectEvent3TemplateData(data);
        if (propertyName == nameof(Warp3Data))
            value = new Warp3Data(data);
        return value;
    }
}
