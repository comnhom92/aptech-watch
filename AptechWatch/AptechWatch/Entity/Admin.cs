﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechWatch.Entity
{
    public class Admin : BaseEntity
    {
        public bool IsSuperAdmin { get; set; }
        [Required]
        public string Realname { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public int PhotoUrl { get; set; }
        public virtual List<News> News { get; set; }
        public virtual List<Chat> Chats { get; set; }

        public Admin()
        {

        }

        public Admin(bool isSuperAdmin, string realName, string userName, string password, string emaill, int photoType, int photoUrl)
        {
            IsSuperAdmin = isSuperAdmin;
            Realname = realName;
            Username = userName;
            Password = password;
            Email = emaill;
            PhotoUrl = photoUrl;
        }
    }
}