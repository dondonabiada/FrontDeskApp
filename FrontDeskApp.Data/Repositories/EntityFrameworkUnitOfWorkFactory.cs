//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using the template for generating Repositories and a Unit of Work for EF Core model.
// Code is generated on: 20/09/2022 10:58:29 pm
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
using System;
using Microsoft.EntityFrameworkCore;
using FrontDeskApp.Entities;

namespace FrontDeskApp.Data
{
    public partial class EntityFrameworkUnitOfWorkFactory : IUnitOfWorkFactory
    {
        protected DbContext context = null;

        public EntityFrameworkUnitOfWorkFactory()
            : this(new FrontDeskApp.Context.FrontDeskAppDbModel())
        {
        }

        public EntityFrameworkUnitOfWorkFactory(DbContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            this.context = context;
        }

        #region IUnitOfWorkFactory Members

        public virtual IUnitOfWork Create()
        {
            if (context == null)
                throw new InvalidOperationException("Context has not been initialized.");
            return new EntityFrameworkUnitOfWork(context);
        }
        #endregion
    }
}
