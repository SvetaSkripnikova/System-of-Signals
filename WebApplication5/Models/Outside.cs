using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Outside
    {
        //id сигнала
        public string Id { get; set; }
        //Сигнал в документе
        public string Name_signal { get; set; }
        //Реальный сигнал на объекте
        public string Real_signal { get; set; }
    }
}