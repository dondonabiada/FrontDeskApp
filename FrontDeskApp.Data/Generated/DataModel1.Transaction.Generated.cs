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
    /// There are no comments for FrontDeskApp.Entities.Transaction in the schema.
    /// </summary>
    [GeneratedCode("Devart Entity Developer", "")]
    [Serializable()]
    public partial class Transaction : BaseEntity {

        /// <summary>
        /// There are no comments for Transaction constructor in the schema.
        /// </summary>
        public Transaction()
        {
            OnCreated();
        }

        /// <summary>
        /// There are no comments for TransactionId in the schema.
        /// </summary>
        [Key]
        [Required(ErrorMessage = @"Data is required.")]
        public virtual int TransactionId { get; set; }

        /// <summary>
        /// There are no comments for CustomerId in the schema.
        /// </summary>
        [Required(ErrorMessage = @"Data is required.")]
        public virtual int CustomerId { get; set; }

        /// <summary>
        /// There are no comments for AreaBoxId in the schema.
        /// </summary>
        [Required(ErrorMessage = @"Data is required.")]
        public virtual int AreaBoxId { get; set; }

        /// <summary>
        /// There are no comments for DateStored in the schema.
        /// </summary>
        [Required(ErrorMessage = @"Data is required.")]
        public virtual DateTime DateStored { get; set; }

        /// <summary>
        /// There are no comments for DateRetrieved in the schema.
        /// </summary>
        [Required(ErrorMessage = @"Data is required.")]
        public virtual DateTime DateRetrieved { get; set; }

        /// <summary>
        /// STORED, RETRIEVED
        /// </summary>
        [StringLength(10)]
        [Required(ErrorMessage = @"Data is required.")]
        public virtual string Status { get; set; }

        /// <summary>
        /// There are no comments for Customer in the schema.
        /// </summary>
        public virtual Customer Customer { get; set; }

        /// <summary>
        /// There are no comments for AreaBox in the schema.
        /// </summary>
        public virtual AreaBox AreaBox { get; set; }

        #region Extensibility Method Definitions

        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();

        #endregion
    }

}