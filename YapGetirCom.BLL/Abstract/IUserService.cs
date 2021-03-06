﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.DTO;
using YapGetirCom.Model;

namespace YapGetirCom.BLL.Abstract
{
    public interface IUserService : IBaseService<User>
    {
        User Login(LoginDTO loginDto);
        User RestaurantLogin(LoginDTO loginDto);
    }
}
