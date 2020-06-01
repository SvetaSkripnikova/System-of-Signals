using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class SignalInDoc
    {
        //id сигнала
        [System.ComponentModel.DataAnnotations.Key]
        public string Signal_id { get; set; }
        //имя сигнала в документе
        public string Name_signal { get; set; }
        //реальный сигнал
        public string Real_signal { get; set; }
        //id документа
        [System.ComponentModel.DataAnnotations.Key]
        public string Document_id { get; set; }
        //наименование документа
        public string Name_document { get; set; }
    }
}