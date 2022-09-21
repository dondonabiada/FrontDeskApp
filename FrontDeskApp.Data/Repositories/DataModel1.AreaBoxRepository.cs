﻿//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using the template for generating Repositories and a Unit of Work for EF Core model.
// Code is generated on: 14/09/2022 7:16:18 am
//
//------------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using FrontDeskApp.Entities;
using System.Drawing;

namespace FrontDeskApp.Data
{
    public partial class AreaBoxRepository
    {
        public virtual ICollection<FrontDeskApp.Entities.AreaBox> GetVacantBySize(string size)
        {
            return objectSet.Where(e => e.AreaType.Equals(size) && e.Status == "VACANT").ToList();
        }

    

        public virtual string SmallCount()
        {
            return objectSet.Where(e => e.AreaType.Equals("SMALL") && e.Status.Equals("VACANT")).ToList().Count.ToString();
        }

        public virtual string MediumCount()
        {
            return objectSet.Where(e => e.AreaType.Equals("MEDIUM") && e.Status.Equals("VACANT")).ToList().Count.ToString();
        }

        public virtual string LargeCount()
        {
            return objectSet.Where(e => e.AreaType.Equals("LARGE") && e.Status.Equals("VACANT")).ToList().Count.ToString();
        }

    }
}
