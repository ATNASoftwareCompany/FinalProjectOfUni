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
        public bool Yes { get; set; }
        public bool No { get; set; }
        public bool OK { get; set; }
        public bool Cancel { get; set; }
    }
}
