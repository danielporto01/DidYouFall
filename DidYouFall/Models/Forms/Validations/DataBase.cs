﻿using DidYouFall.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DidYouFall.Models.Forms.Validations
{
    public class DataBase
    {
        public void RegisteredEmail(string email)
        {


            var session = DidYouFall.MvcApplication.SessionFactory.GetCurrentSession();
            {
                Users user = session.QueryOver<Users>().Where(i => i.Email == email).SingleOrDefault();
                if (user != null)
                    throw new Exception("Usuario já registado");
            }
        }
    }
}