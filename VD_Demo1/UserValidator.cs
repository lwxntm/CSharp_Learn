using FluentValidation;
using System;
using System.Linq;
namespace VD_Demo1
{
    //创建User的Validator，继承至泛型抽象类AbstractValidator
    public class UserValidator : AbstractValidator<User>
    {
        //重写构造函数
        public UserValidator()
        {
            RuleFor(user => user.Id).GreaterThan(0).WithMessage("Id must be above zero");
            RuleFor(user => user.FirstName).NotEmpty().WithMessage("Please specify a First Name")
                .MaximumLength(20).WithMessage("must be less 20 character");
            RuleFor(user => user.LastName).NotEmpty().WithMessage("Please specify a Last Name")
                .MaximumLength(40).WithMessage("must less than 40 characters")
                .NotEqual(user => user.FirstName).WithMessage("Must not equal with FirstName");
            RuleFor(user => user.Sex).Must(sex => new string[] { "male", "female" }.Contains(sex))
                .WithMessage("Sex only can be male or female");
            RuleFor(User => User.Email).EmailAddress().WithMessage("wrong email");
            RuleFor(user => user.Salary).InclusiveBetween(2000, 20000)
                .WithMessage("Salary should be between 2000-20000");
        }
    }
}
