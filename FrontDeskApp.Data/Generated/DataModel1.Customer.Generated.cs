﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 20/09/2022 10:58:28 pm
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using Newtonsoft.Json;

namespace FrontDeskApp.Entities
{
    /// <summary>
    /// There are no comments for FrontDeskApp.Entities.Customer in the schema.
    /// </summary>
    [GeneratedCode("Devart Entity Developer", "")]
    [Serializable()]
    public partial class Customer : BaseEntity {

        /// <summary>
        /// There are no comments for Customer constructor in the schema.
        /// </summary>
        public Customer()
        {
            this.Transactions = new List<Transaction>();
            OnCreated();
        }

        /// <summary>
        /// There are no comments for CustomerId in the schema.
        /// </summary>
        [Key]
        [Required(ErrorMessage = @"Data is required.")]
        public virtual int CustomerId { get; set; }

        /// <summary>
        /// There are no comments for FirstName in the schema.
        /// </summary>
        [StringLength(50)]
        [Required(ErrorMessage = @"Data is required.")]
        public virtual string FirstName { get; set; }

        /// <summary>
        /// There are no comments for LastName in the schema.
        /// </summary>
        [StringLength(50)]
        [Required(ErrorMessage = @"Data is required.")]
        public virtual string LastName { get; set; }

        /// <summary>
        /// There are no comments for PhoneNumber in the schema.
        /// </summary>
        [StringLength(20)]
        [Required(ErrorMessage = @"Data is required.")]
        public virtual string PhoneNumber { get; set; }

        /// <summary>
        /// There are no comments for Transactions in the schema.
        /// </summary>
        public virtual IList<Transaction> Transactions { get; set; }

        #region Extensibility Method Definitions

        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();

        #endregion
    }

}
