﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschraenkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using Squidex.CLI.Commands.Implementation.Utils;
using Squidex.ClientLibrary.Management;

namespace Squidex.CLI.Commands.Implementation.Sync.App
{
    public static class Extensions
    {
        public static AppRoleModel ToModel(this RoleDto role)
        {
            return SimpleMapper.Map(role, new AppRoleModel());
        }

        public static UpdateRoleDto ToUpdate(this AppRoleModel model)
        {
            return SimpleMapper.Map(model, new UpdateRoleDto());
        }

        public static AppClientModel ToModel(this ClientDto client)
        {
            return SimpleMapper.Map(client, new AppClientModel());
        }

        public static UpdateClientDto ToUpdate(this AppClientModel model)
        {
            return SimpleMapper.Map(model, new UpdateClientDto());
        }

        public static UpdateLanguageDto ToModel(this AppLanguageDto language)
        {
            return SimpleMapper.Map(language, new UpdateLanguageDto());
        }
    }
}
