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

using dnlib.DotNet;

namespace dnSpy.Contracts.Metadata {
	/// <summary>
	/// Creates <see cref="ModuleId"/>s
	/// </summary>
	public interface IModuleIdFactory {
		/// <summary>
		/// Creates a <see cref="ModuleId"/> or returns null. The returned value can be cached so
		/// it must always produce the same value for the same input module.
		/// </summary>
		/// <param name="module">Module</param>
		/// <returns></returns>
		ModuleId? Create(ModuleDef module);
	}
}
