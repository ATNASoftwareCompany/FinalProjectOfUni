using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalApp.Users.DTOs
{
    public class UserDto:User_VM
    {
        public int RowNumber { get; set; }
        public string StatusStr { get; set; }
    }
}
