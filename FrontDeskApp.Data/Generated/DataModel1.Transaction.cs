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

    public partial class Transaction
    {
        public virtual string CustomerName
        {
            get
            {
                if (Customer is not null)
                    return Customer.FullName;
                else
                    return string.Empty;
            }
        }

        public virtual string BoxName
        {
            get
            {
                if (AreaBox is not null)
                    return AreaBox.Name;
                else
                    return string.Empty;
            }
        }

        public virtual string AreaType
        {
            get
            {
                if (AreaBox is not null)
                    return AreaBox.AreaType;
                else
                    return string.Empty;
            }
        }

        

    }
}
