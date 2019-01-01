﻿/*
    Copyright (C) 2014-2019 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.ComponentModel.Composition;
using dnSpy.Contracts.Settings.AppearanceCategory;
using dnSpy.Contracts.Themes;
using dnSpy.Properties;

namespace dnSpy.Settings.AppearanceCategory {
	static class TextAppearanceCategoryDefinitions {
		[Export(typeof(TextAppearanceCategoryDefinition))]
		sealed class TextEditorTextAppearanceCategoryDefinition : TextAppearanceCategoryDefinition {
			public override bool IsUserVisible => true;
			public override string DisplayName => dnSpy_Resources.TextEditor;
			public override string Category => AppearanceCategoryConstants.TextEditor;
			public override ColorType ColorType => ColorType.Text;
		}

		[Export(typeof(TextAppearanceCategoryDefinition))]
		sealed class HexEditorTextAppearanceCategoryDefinition : TextAppearanceCategoryDefinition {
			public override bool IsUserVisible => true;
			public override string DisplayName => dnSpy_Resources.BgImgDisplayName_HexEditor;
			public override string Category => AppearanceCategoryConstants.HexEditor;
			public override ColorType ColorType => ColorType.HexText;
		}

		[Export(typeof(TextAppearanceCategoryDefinition))]
		sealed class UITextAppearanceCategoryDefinition : TextAppearanceCategoryDefinition {
			public override bool IsUserVisible => false;
			public override string DisplayName => null;
			public override string Category => AppearanceCategoryConstants.UIMisc;
			public override ColorType ColorType => ColorType.Text;
		}
	}
}
