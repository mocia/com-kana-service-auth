﻿using Com.Kana.Service.Auth.Lib.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Com.Kana.Service.Auth.Lib.Services.ValidateService
{
    public class ValidateService : IValidateService
    {
        private readonly IServiceProvider serviceProvider;

        public ValidateService(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void Validate(dynamic model)
        {
            List<ValidationResult> validationResults = new List<ValidationResult>();
            ValidationContext validationContext = new ValidationContext(model, serviceProvider, null);

            if (!Validator.TryValidateObject(model, validationContext, validationResults, true))
                throw new ServiceValidationException(validationContext, validationResults);
        }
    }
}
