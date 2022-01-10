using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Order
{
    public class Person : EntityBase
    {

        [Required(ErrorMessage = "O campo nome é obrigatorio!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Digite um nome valido!")]
        public string FirstName { get; private set; }
        [Required(ErrorMessage = "O campo sobrenome é obrigatorio!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Digite um sobrenome valido!")]
        public string LastName { get; private set; }

        [Required(ErrorMessage = "O campo data de nascimento é obrigatorio!")]
        public DateTime BirthDate { get; private set; }
        [Required(ErrorMessage = "O campo idade é obrigatorio!")]

        public int Age { 
            get
            {
                var actualDate = DateTime.Now;
                var age = actualDate.Year - BirthDate.Year;

                if (actualDate.Month < BirthDate.Month)
                    age--;

                return age;
            }
        }
        [Required(ErrorMessage = "O campo cpf é obrigatorio!")]

        public Cpf Cpf { get; private set; }
        [Required(ErrorMessage = "O campo email é obrigatorio!")]

        public Email Email { get; private set; }

        public Person(string firstName, string lastName, string birthDate, Cpf cpf, Email email)
        {
            FirstName = firstName.Trim();
            LastName = lastName.Trim();
          
            ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(this, context, results, true);

            if (isValid == false)
            {
                StringBuilder sbrErrors = new StringBuilder();
                foreach (var validationResult in results)
                {
                    sbrErrors.AppendLine(validationResult.ErrorMessage);
                }
                throw new ValidationException(sbrErrors.ToString());
            }
        
            if (!cpf.IsValid)
                throw new OrderException("Cpf inválido!");

            if (!email.IsValid)
            {
                throw new OrderException("E-mail inválido!");

            }
            if (string.IsNullOrEmpty(birthDate))
            {
                throw new OrderException("Insira uma data de nascimento valida");
            }
            else
            {
                try
                {
                    BirthDate = Convert.ToDateTime(birthDate);

                }
                catch (FormatException)
                {

                    throw new FormatException("Digite uma data de nascimento no formato dd/mm/yyyy");
                }

            }
            Cpf = cpf;
            Email = email;
            base.DateHourRegister = DateTime.Now;

          
        }
        public void trataDado()
        {

        }

        public string FullName =>
            $"{FirstName} {LastName}";
    }
}
