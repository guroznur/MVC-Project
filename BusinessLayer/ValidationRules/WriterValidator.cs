﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty()
                .WithMessage("Yazar adını boş geçemezsiniz");
            RuleFor(x => x.WriterSurName).NotEmpty()
                .WithMessage("Soyadı kısmını boş geçemezsiniz");
            RuleFor(x => x.WriterAbout).NotEmpty()
                .WithMessage("Unvan kısmını boş geçemezsiniz");
            RuleFor(x => x.WriterTitle).NotEmpty()
                .WithMessage("Hakkında kısmını boş geçemezsiniz");
            RuleFor(x => x.WriterName).MinimumLength(2)
                .WithMessage("Lütfen en az iki karakter girişi yapın");
            RuleFor(x => x.WriterName).MaximumLength(50)
                .WithMessage("Lütfen 50 karakterden fazla değer girişi yapmayın");
            
        }
    }
}
