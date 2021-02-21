using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()//kurallar buraya yazılır.
        {
            RuleFor(c=>c.Description).MinimumLength(2);
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.Description).Must(StartsWithM).WithMessage("Ürünler M harfi ile başlamalı");
        }

        private bool StartsWithM(string arg)
        {
            return arg.StartsWith("M");
        }
    }
}
