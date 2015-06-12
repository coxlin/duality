﻿using System.Linq;
using System.Reflection;

using AdamsLair.WinForms.PropertyEditing;
using AdamsLair.WinForms.PropertyEditing.Editors;

using Duality;
using Duality.Resources;
using Duality.Editor;

namespace Duality.Editor.Plugins.Base.PropertyEditors
{
	public class FontContentPropertyEditor : ResourcePropertyEditor
	{
		protected override PropertyEditor AutoCreateMemberEditor(MemberInfo info)
		{
			if (info.IsEquivalent(ReflectionInfo.Property_Font_Family))
			{
				ObjectSelectorPropertyEditor e = new ObjectSelectorPropertyEditor();
				e.EditedType = (info as System.Reflection.PropertyInfo).PropertyType;
				e.Items = System.Drawing.FontFamily.Families.Select(f => new ObjectItem(f.Name, f.Name));
				this.ParentGrid.ConfigureEditor(e);
				return e;
			}
			return base.AutoCreateMemberEditor(info);
		}
	}
}
