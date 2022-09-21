using FrontDeskApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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

    public partial class AreaBox
    {
       
        public virtual string CustomerName
        {
            get
            {
                if (Transactions.Count > 0)
                {
                    var trans = this.Transactions.Where(t => t.Status.Trim() == "STORED").FirstOrDefault();
                    if (trans is not null)
                    {
                        return trans.Customer.FullName;
                    }
                    else
                        return string.Empty;
                }
                else
                    return string.Empty;
            }
        }
    }
}
