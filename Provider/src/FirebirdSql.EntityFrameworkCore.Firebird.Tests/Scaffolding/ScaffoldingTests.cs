﻿/*
 *    The contents of this file are subject to the Initial
 *    Developer's Public License Version 1.0 (the "License");
 *    you may not use this file except in compliance with the
 *    License. You may obtain a copy of the License at
 *    https://github.com/FirebirdSQL/NETProvider/blob/master/license.txt.
 *
 *    Software distributed under the License is distributed on
 *    an "AS IS" basis, WITHOUT WARRANTY OF ANY KIND, either
 *    express or implied. See the License for the specific
 *    language governing rights and limitations under the License.
 *
 *    All Rights Reserved.
 */

//$Authors = Jiri Cincura (jiri@cincura.net)

using FirebirdSql.EntityFrameworkCore.Firebird.Scaffolding.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding;
using NUnit.Framework;

namespace FirebirdSql.EntityFrameworkCore.Firebird.Tests.Scaffolding
{
#pragma warning disable EF1001
	public class ScaffoldingTests : EntityFrameworkCoreTestsBase
	{
		[Test]
		public void JustCanRun()
		{
			var modelFactory = GetModelFactory();
			Assert.DoesNotThrow(() => modelFactory.Create(Connection, new DatabaseModelFactoryOptions()));
		}

		static IDatabaseModelFactory GetModelFactory()
		{
			return new FbDatabaseModelFactory();
		}
	}
#pragma warning restore EF1001
}
