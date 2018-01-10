using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using dotNetcore_for_selfweb.Entity.Core;

namespace dotnet_for_mywebsite.Models
{
    public class UserModel:BaseEntity
    {

        /// <summary>
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
