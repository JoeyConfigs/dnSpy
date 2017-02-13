﻿/*
    Copyright (C) 2014-2017 de4dot@gmail.com

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

using System;
using dnSpy.Contracts.Debugger;
using dnSpy.Contracts.Debugger.DotNet;
using dnSpy.Contracts.Debugger.DotNet.CorDebug;

namespace dnSpy.Debugger.CorDebug.Impl {
	sealed class DbgDnRuntimeImpl : CorDebugRuntime {
		public override DbgProcess Process { get; }

		public override DbgModule[] Modules {
			get {
				throw new NotImplementedException();//TODO:
			}
		}

		public override DbgDnAppDomain[] AppDomains {
			get {
				throw new NotImplementedException();//TODO:
			}
		}

		public override CorDebugRuntimeKind Kind { get; }

		public override string Version {
			get {
				throw new NotImplementedException();//TODO:
			}
		}

		public override string ClrFilename {
			get {
				throw new NotImplementedException();//TODO:
			}
		}

		public override string RuntimeDirectory {
			get {
				throw new NotImplementedException();//TODO:
			}
		}

		public DbgDnRuntimeImpl(DbgProcess process, CorDebugRuntimeKind kind) {
			if (process == null)
				throw new ArgumentNullException(nameof(process));
			Process = process;
			Kind = kind;
		}
	}
}
