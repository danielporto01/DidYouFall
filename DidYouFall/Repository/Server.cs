﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DidYouFall.Repository
{
    public class Server
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Host { get; set; }
        public virtual Times CheckTime { get; set; }
        public virtual DateTime LastCheck { get; set; }
        public virtual string Contactemail { get; set; }
        public virtual bool Emailsent { get; set; }
        public virtual IList<int> Ports { get; set; }
        public virtual User User { get; set; }
    }
    public enum Times
    {
        Cinco_minutos = 5,
        Dez_minutos = 10,
        Trinta_minutos = 30,
        Uma_hora = 60,
        Uma_hora_e_meia = 90,
        Suas_horas = 120,
        Três_horas = 180,
    }
}