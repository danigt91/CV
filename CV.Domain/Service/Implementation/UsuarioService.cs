using CV.Domain.DTO;
using CV.Domain.Service.Contract;
using CV.Infraestructure.Data.Entity;
using CV.Infraestructure.Data.Repository.Contract;
using CV.Infraestructure.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV.Domain.Service.Implementation
{
    public class UsuarioService : DataService<Usuario, UsuarioDTO>, IUsuarioService
    {
                
        // Hacer de manerga genérica, mapeo de entidades/dto
        public UsuarioService(IAutoMapperEF6<Usuario, UsuarioDTO> mapper, IDataRepository<Usuario> entities) : base(mapper, entities)
        {

        }

    }
}
