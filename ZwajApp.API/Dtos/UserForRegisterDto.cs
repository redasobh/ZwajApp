using System.ComponentModel.DataAnnotations;

namespace ZwajApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
       [StringLength(8,MinimumLength=4,ErrorMessage="يجب كلمة المرور لا تقل عن 4 حروف ولاتزد عن 8 حروف")]
        public string Password { get; set; }
    }
}