using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using dotNetcore_for_selfweb.Entity.Core;

namespace dotNetcore_for_selfweb.Entity
{
    public  class UserInfoEntity:BaseEntity
    {  /// <summary>
       /// 用户Id
       /// </summary>
        [DataMember]
        public string F_UserId { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [DataMember]
        public string F_UserName { get; set; }

        public string F_Psd { get; set; }

        public string F_Contact { get; set; }

        public string F_Mail { get; set; }
    }
}
