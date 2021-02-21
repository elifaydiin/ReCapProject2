using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(c => c.BrandName).MinimumLength(2);
            RuleFor(c => c.BrandName).NotEmpty();
            RuleFor(c => c.BrandName).NotEmpty();
            RuleFor(c => c.BrandName).Must(StartsWithM).WithMessage("Ürünler M harfi ile başlamalı");
        }

        private bool StartsWithM(string arg)
        {
            return arg.StartsWith("M");
        }
    }
    }

