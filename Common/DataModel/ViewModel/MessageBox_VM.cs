using DataModel.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ViewModel
{
    public class MessageBox_VM
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public ErrorType ErrorType { get; set; }
        public bool Yes { get; set; } = false;
        public bool No { get; set; } = false ;
        public bool OK { get; set; } = false;
        public bool Cancel { get; set; } = false;
    }
}
