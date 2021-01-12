﻿using System;
using app.service.Identity.Commands.CreateNewAccount;
using app.service.Identity.Commands.Login;
using app.service.Identity.Commands.SignOut;
using app.service.Identity.Query.FindByName;

namespace app.service
{
    public interface IIdentityService
    {
        CreateNewAccountResult CreateNewAccount(CreateNewAccountCommand creds);
        LoginResult Login(LoginCommand creds);
        SignOutResult SignOut();
        FindByNameResult FindByName(FindByNameQuery creds);
    }
}
