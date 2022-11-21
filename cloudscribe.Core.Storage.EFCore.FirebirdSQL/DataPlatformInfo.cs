// Copyright (c) Source Tree Solutions, LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
//	Author:                 Arcantar
//  Created:			    2022-11-10
// 


using cloudscribe.Core.Models;

namespace cloudscribe.Core.Storage.EFCore.FirebirdSQL;

public class DataPlatformInfo : IDataPlatformInfo
{
    public string DBPlatform
    {
        get { return "Entity Framework with FbSql"; }
    }
}
