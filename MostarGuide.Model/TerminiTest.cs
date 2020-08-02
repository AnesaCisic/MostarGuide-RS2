using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MostarGuide.Model
{
    public class TerminiTest
    {
        public int TerminId { get; set; }
        public string Vodic { get; set; }
        public string Izlet { get; set; }
        public string Datum { get; set; }


        //[DataType(DataType.Date)]
        //public DateTime Datum { get; set; }

        //[DataType(DataType.Time)]
        //public DateTime Vrijeme { get; set; }

    }
}
