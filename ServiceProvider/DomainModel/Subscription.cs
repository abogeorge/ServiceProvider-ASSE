﻿using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Subscription
    {

        #region Fields
        public Subscription()
        {

        }

        [System.ComponentModel.DataAnnotations.Key,
            System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int SubscriptionId
        {
            get;
            set;
        }

        [NotNullValidator(MessageTemplate = "Subscription Name cannot be null!")]
        [StringLengthValidator(3, RangeBoundaryType.Inclusive, 30, RangeBoundaryType.Inclusive, ErrorMessage = "Subscription Name should have between {3} and {30} letters!")]
        public String SubscriptionName
        {
            get;
            set;
        }

        //[NotNullValidator(MessageTemplate = "Subscription Type Name cannot be null!")]
        //[
        //public Double Price
        //{
        //    get;
        //    set;
        //}

        #endregion
        #region Validation

        internal static void Validate(SubscriptionType subscription, ValidationResults results)
        {
            if (true)
            {
                results.AddResult
                    (
                        new ValidationResult("some reason from SelfValidation method", subscription, "ValidateMethod", "error", null)
                    );
            }
        }

        #endregion

    }
}
