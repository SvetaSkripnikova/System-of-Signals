using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Signal
    {
        //id сигнала
        public string Id { get; set; }
        //имя сигнала в документе
        public string Name_signal { get; set; }
        //реальный сигнал
        public string Real_signal { get; set; }
    }
}