using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Order
{
    public class Product : EntityBase
    {
        [Required(ErrorMessage = "O campo descrição é obrigatorio!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Digite uma descrição valida!")]

        public string Description { get; private set; }
        [Required(ErrorMessage = "O campo valor unitario é obrigatorio!")]

        public decimal UnitaryValue { get; private set; }
        [Required(ErrorMessage = "O campo quantidade disponivel é obrigatorio!")]

        public int AvailableQuantity { get; private set; }

        public Product(string description, string unitaryValue, string availableQuantity)
        {
            Description = description;

           
            base.DateHourRegister = DateTime.Now;
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
            try
            {
                UnitaryValue = Convert.ToDecimal(unitaryValue);
                AvailableQuantity = Convert.ToInt32(availableQuantity);
            }
            catch (FormatException)
            {
                throw new FormatException("preencha os campos valor unitario e quantidade disponivel corretamente");
                
            }
         
        }

        public void AddAvailableQuantity(int quantity)
        {
            AvailableQuantity += quantity;
        }

        public void RemoveAvailableQuantity(int quantity)
        {
            if (quantity > AvailableQuantity)
                throw new OrderException("Quantidade disponível insuficiente");

            AvailableQuantity -= quantity;
        }
    }
}
