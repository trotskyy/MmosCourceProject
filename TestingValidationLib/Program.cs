using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModelValidation;

namespace TestingValidationLib
{
    [ValidateDomainConstraints(ValidationType.OnDelete | ValidationType.OnCreate)]
    class ClassUnderValidation
    {
        public ClassUnderValidation(int property)
        {
            Property = property;
        }

        public int Property { get; set; }
    }

    [ValidateDomainConstraints(ValidationType.OnDelete | ValidationType.OnCreate)]
    class Other
    {
        public Other(int property)
        {
            Property = property;
        }

        public int Property { get; set; }
    }

    class DataSource
    {
        public List<ClassUnderValidation> Data { get; set; }
        public List<Other> OtherData { get; set; }
    }

    class Program
    {
        static DataSource InitDataSource()
        {
            DataSource res = new DataSource();
            res.Data = new List<ClassUnderValidation>()
            {
                new ClassUnderValidation(1),
                new ClassUnderValidation(2),
                new ClassUnderValidation(3),
                new ClassUnderValidation(4),
                new ClassUnderValidation(5),
                new ClassUnderValidation(6)
            };
            res.OtherData = new List<Other>()
            {
                new Other(1),
                new Other(2),
                new Other(3),
                new Other(4),
                new Other(5),
                new Other(6)
            };
            return res;
        }

        static void InitValidator()
        {
            DomainModelValidator<DataSource>.Configure(cfg =>
            {
                cfg.ConfigureOnCreate(ruleSet =>
                {
                    ruleSet.UsingExceptionApproach()
                        .AddRule<ClassUnderValidation>((c, ds) => ds.Data[0].Property == c.Property)
                        //.ThrowingException(new Exception("The first is the same"))
                        .Including((c, ds) => ds.Data[0].Property > c.Property)
                        .ThrowingException(new Exception("bla"));

                    ruleSet.UsingNotificationApproach()
                        .AddRule<Other>((c, ds) => ds.Data[0].Property == c.Property)
                        .NotifiedAs(new Notification() { Message = "1" })
                        .Including((c, ds) => ds.Data[1].Property > c.Property)
                        .NotifiedAs(new Notification() { Message = "2" })
                        .WithValidationExceptionMessage("Failed Other");
                });

                cfg.ConfigureOnDelete(ruleSet =>
                {
                    ruleSet.UsingExceptionApproach()
                        .AddRule<ClassUnderValidation>((c, ds) => ds.Data[0].Property != c.Property)
                        .ThrowingException(new Exception("DELETE The first is the same"))
                        .Including((c, ds) => ds.Data[0].Property > c.Property)
                        .ThrowingException(new Exception("DELETE bla"));

                    ruleSet.UsingNotificationApproach()
                        .AddRule<Other>((c, ds) => ds.Data[0].Property != c.Property)
                        .NotifiedAs(new Notification() { Message = "DELETE 1" })
                        .Including((c, ds) => ds.Data[1].Property > c.Property)
                        .NotifiedAs(new Notification() { Message = "DELETE 2" })
                        .WithValidationExceptionMessage("DELETE Failed Other");
                });
            });
        }

        static void Main(string[] args)
        {
            DataSource dataSource = InitDataSource();
            InitValidator();

            ClassUnderValidation test = new ClassUnderValidation(1);
            Other other = new Other(0);

            //DomainModelValidator<DataSource>.Configure(cfg => { });
            //DomainModelValidator<string>.Validate(test, "", ValidationType.OnCreate);

            try
            {
                DomainModelValidator<DataSource>.Validate(other, dataSource, ValidationType.OnCreate);
            }
            catch (Exception ex)
            {
                int i = 10;
                //throw;
            }

            Console.ReadLine();
        }
    }
}
