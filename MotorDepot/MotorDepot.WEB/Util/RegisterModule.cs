﻿using MotorDepot.BLL.Interfaces;
using MotorDepot.BLL.Services;
using Ninject.Modules;

namespace MotorDepot.WEB.Util
{
    public class RegisterModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserService>();
        }
    }
}