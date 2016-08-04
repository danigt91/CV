using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CV.Infraestructure.Data.Entity.Contract;

namespace CV.Infraestructure.Data.Entity
{
    [Table("Usuario")]
    public class Usuario : EntityBase
    {

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
        public string Password { get; set; }

        [Required(ErrorMessageResourceName = "Usuario_ConfirmPassword_Required", ErrorMessageResourceType = typeof(Properties.Resources))]
        [StringLength(255, ErrorMessageResourceName = "Usuario_ConfirmPassword_StringLength", ErrorMessageResourceType = typeof(Properties.Resources), MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessageResourceName = "Usuario_ConfirmPassword_Compare", ErrorMessageResourceType = typeof(Properties.Resources))]
        public string ConfirmPassword { get; set; }

    }
}
