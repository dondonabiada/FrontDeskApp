﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using the template for generating Repositories and a Unit of Work for EF Core model.
// Code is generated on: 20/09/2022 10:58:29 pm
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace FrontDeskApp.Entities
{
    public partial interface ICustomerRepository : IRepository<Customer>
    {
        ICollection<Customer> GetAll();
        Customer GetByKey(int _CustomerId);
    }
}
