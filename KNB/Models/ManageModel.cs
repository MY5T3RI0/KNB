using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KNB.Models
{
    public class ManageModel
    {
        public int Id { get; set; }

        public string UserName { get; set; }
        public string Login { get; set; }

        public int Age { get; set; }

        public int Balance { get; set; }

        public string Email { get; set; }
    }
}