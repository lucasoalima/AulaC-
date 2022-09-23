using System.ComponentModel.DataAnnotations;

namespace API_Folhas.Validations{
    public class CpfEmUso : ValidationAttribute{
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //
            string cpf = value;
            // caso de sucesso
            return ValidationResult.Success;

            // caso de erro
            return new ValidationResult("Esse funcionário já existe");
        }
    }
}
