﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.ServiceManagemenet.Common.Models;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Microsoft.WindowsAzure.Commands.Test.Utilities.Common;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.Azure.Commands.Websites.Test.ScenarioTests
{
    public class WebAppBackupRestoreTests : RMTestBase
    {
        public WebAppBackupRestoreTests(ITestOutputHelper output)
        {
            XunitTracingInterceptor.AddToContext(new XunitTracingInterceptor(output));
        }

#if NETSTANDARD
        [Fact(Skip = "Storage version out-of-date: Awaiting Storage.Management.Common")]
        [Trait(Category.RunType, Category.DesktopOnly)]
#else
        [Fact]
#endif
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestCreateNewWebAppBackup()
        {
            WebsitesController.NewInstance.RunPsTest("Test-CreateNewWebAppBackup");
        }

#if NETSTANDARD
        [Fact(Skip = "Storage version out-of-date: Awaiting Storage.Management.Common")]
        [Trait(Category.RunType, Category.DesktopOnly)]
#else
        [Fact]
#endif
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestCreateNewWebAppBackupPiping()
        {
            WebsitesController.NewInstance.RunPsTest("Test-CreateNewWebAppBackupPiping");
        }

#if NETSTANDARD
        [Fact(Skip = "Storage version out-of-date: Awaiting Storage.Management.Common")]
        [Trait(Category.RunType, Category.DesktopOnly)]
#else
        [Fact]
#endif
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetWebAppBackup()
        {
            WebsitesController.NewInstance.RunPsTest("Test-GetWebAppBackup");
        }

#if NETSTANDARD
        [Fact(Skip = "Storage version out-of-date: Awaiting Storage.Management.Common")]
        [Trait(Category.RunType, Category.DesktopOnly)]
#else
        [Fact]
#endif
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetWebAppBackupList()
        {
            WebsitesController.NewInstance.RunPsTest("Test-GetWebAppBackupList");
        }

#if NETSTANDARD
        [Fact(Skip = "Storage version out-of-date: Awaiting Storage.Management.Common")]
        [Trait(Category.RunType, Category.DesktopOnly)]
#else
        [Fact]
#endif
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestEditAndGetWebAppBackupConfiguration()
        {
            WebsitesController.NewInstance.RunPsTest("Test-EditAndGetWebAppBackupConfiguration");
        }

#if NETSTANDARD
        [Fact(Skip = "Storage version out-of-date: Awaiting Storage.Management.Common")]
        [Trait(Category.RunType, Category.DesktopOnly)]
#else
        [Fact]
#endif
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestEditAndGetWebAppBackupConfigurationPiping()
        {
            WebsitesController.NewInstance.RunPsTest("Test-EditAndGetWebAppBackupConfigurationPiping");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetWebAppSnapshot()
        {
            WebsitesController.NewInstance.RunPsTest("Test-GetWebAppSnapshot");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestRestoreWebAppSnapshot()
        {
            WebsitesController.NewInstance.RunPsTest("Test-RestoreWebAppSnapshot");
        }
    }
}