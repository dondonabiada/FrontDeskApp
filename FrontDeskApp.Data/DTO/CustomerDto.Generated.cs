﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Data Transfer Object template.
// Code is generated on: 20/09/2022 10:58:30 pm
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace FrontDeskApp.Data.DTO
{

    public partial class CustomerDto
    {
        #region Constructors

        public CustomerDto() {
        }

        public CustomerDto(int customerId, string firstName, string lastName, string phoneNumber, List<TransactionDto> transactions) {

          this.CustomerId = customerId;
          this.FirstName = firstName;
          this.LastName = lastName;
          this.PhoneNumber = phoneNumber;
          this.Transactions = transactions;
        }

        #endregion

        #region Properties

        [Key]
        [Required()]
        public int CustomerId { get; set; }

        [StringLength(50)]
        [Required()]
        public string FirstName { get; set; }

        [StringLength(50)]
        [Required()]
        public string LastName { get; set; }

        [StringLength(20)]
        [Required()]
        public string PhoneNumber { get; set; }

        #endregion

        #region Navigation Properties

        public List<TransactionDto> Transactions { get; set; }

        #endregion
    }

}
