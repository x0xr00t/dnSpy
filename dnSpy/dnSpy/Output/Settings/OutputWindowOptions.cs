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

using dnSpy.Contracts.Settings.Groups;
using dnSpy.Text.Settings;
using Microsoft.VisualStudio.Utilities;

namespace dnSpy.Output.Settings {
	sealed class OutputWindowOptions : CommonEditorOptions, IOutputWindowOptions {
		public OutputWindowOptions(ITextViewOptionsGroup group, IContentType contentType)
			: base(group, contentType) {
		}

		public bool ShowTimestamps {
			get => group.GetOptionValue(ContentType.TypeName, DefaultOutputOptions.ShowTimestampsId);
			set => group.SetOptionValue(ContentType.TypeName, DefaultOutputOptions.ShowTimestampsId, value);
		}

		public string TimestampDateTimeFormat {
			get => group.GetOptionValue(ContentType.TypeName, DefaultOutputOptions.TimestampDateTimeFormatId);
			set => group.SetOptionValue(ContentType.TypeName, DefaultOutputOptions.TimestampDateTimeFormatId, value);
		}
	}
}
