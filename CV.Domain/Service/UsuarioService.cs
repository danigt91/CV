using CV.Domain.DTO;
using CV.Infraestructure.Data.Entity;
using CV.Infraestructure.Data.Repository.Contract;
using CV.Infraestructure.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV.Domain.Service
{
    public class UsuarioService
    {

        private IAutoMapperEF6<Usuario, UsuarioDTO> _mapper;
        private IDataRepository<Usuario> _usuarios;

        public UsuarioService(IAutoMapperEF6<Usuario, UsuarioDTO> mapper, IDataRepository<Usuario> usuarios)
        {
            _mapper = mapper;
            _usuarios = usuarios;
        }
        

    }
}
