using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTAPI.Models
{
    public class EditMemberResponse
    {
        public bool ok { get; set; }
        public string errMsg { get; set; }

        public EditMemberResponse()
        {
            this.ok = ok;
            this.errMsg = "";

        }
    }
}