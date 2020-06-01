using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class SignalInObj
    {

        //id реального сигнала
        [System.ComponentModel.DataAnnotations.Key]
        public string Signal_id { get; set; }
        //имя сигнала в документе
        public string Name_signal { get; set; }
        //реальный сигнал
        public string Real_signal { get; set; }
        //id объекта
        [System.ComponentModel.DataAnnotations.Key]
        public string Object_id { get; set; }
        //наименовани объекта
        public string Name_object { get; set; }
    }
}