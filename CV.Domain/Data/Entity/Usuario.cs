using CV.Domain.Service.Implementation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV.Domain.Data.Entity
{
    [Table("Usuario")]
    public class Usuario : EntityBase
    {

        [NotMapped]
        private string _password;
        [NotMapped]
        private string _confirmPassword;

        public Usuario() : base()
        {
        }

        [Required(ErrorMessageResourceName = "Usuario_UserName_Required", ErrorMessageResourceType = typeof(Properties.Resources))]
        [StringLength(40, ErrorMessageResourceName = "Usuario_UserName_StringLength", ErrorMessageResourceType = typeof(Properties.Resources), MinimumLength = 1)]
        [Index("IX_Usuario_UserName_UQ", 1, IsUnique = true)]
        public string UserName { get; set; }

        [Required(ErrorMessageResourceName = "Usuario_Password_Required", ErrorMessageResourceType = typeof(Properties.Resources))]
        [StringLength(255, ErrorMessageResourceName = "Usuario_Password_StringLength", ErrorMessageResourceType = typeof(Properties.Resources), MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password {
            get
            {
                return _password;
            }
            set
            {
                _password = CryptoService.Hash(value);
            }
        }

        [NotMapped]
        [Required(ErrorMessageResourceName = "Usuario_ConfirmPassword_Required", ErrorMessageResourceType = typeof(Properties.Resources))]
        [StringLength(255, ErrorMessageResourceName = "Usuario_ConfirmPassword_StringLength", ErrorMessageResourceType = typeof(Properties.Resources), MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessageResourceName = "Usuario_ConfirmPassword_Compare", ErrorMessageResourceType = typeof(Properties.Resources))]
        public string ConfirmPassword {
            get
            {
                return _confirmPassword;
            }
            set
            {
                _confirmPassword = CryptoService.Hash(value);
            }
        }

    }
}
