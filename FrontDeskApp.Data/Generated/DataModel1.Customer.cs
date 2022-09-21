using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;

namespace FrontDeskApp.Entities
{

    public partial class Customer
    {
        public virtual string FullName {
            get
            {
                return string.Concat(this.FirstName, " ", this.LastName);
            }
        }
    }
}
