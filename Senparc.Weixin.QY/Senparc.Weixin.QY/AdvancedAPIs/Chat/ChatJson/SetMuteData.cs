﻿/*----------------------------------------------------------------
    Copyright (C) 2015 Senparc
    
    文件名：SetMuteData.cs
    文件功能描述：成员新消息免打扰参数
    
    
    创建标识：Senparc - 20150728
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Senparc.Weixin.Entities;

namespace Senparc.Weixin.QY.AdvancedAPIs.OAuth2
{
    /// <summary>
    /// 成员新消息免打扰参数
    /// </summary>
    public class UserMute
    {
        /// <summary>
        /// 成员UserID
        /// </summary>
        public string userid { get; set; }
        /// <summary>
        /// 免打扰状态
        /// </summary>
        public Mute_Status status { get; set; }
    }
}