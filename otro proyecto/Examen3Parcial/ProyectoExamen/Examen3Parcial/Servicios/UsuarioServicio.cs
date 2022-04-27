using Datos.Interfaces;
using Datos.Repositorios;
using Examen3Parcial.Data;
using Examen3Parcial.Interfaces;
using Modelos;

namespace Examen3Parcial.Servicios;

    public class UsuarioServicio : IUsuarioServicio
    {
    private readonly MySQLConfiguration _configuration;
    private IUsuarioRepositorio usuarioRepositorio;

    public UsuarioServicio(MySQLConfiguration configuration)
    {
        _configuration = configuration;
        usuarioRepositorio = new UsuarioRepositorio(configuration.CadenaConexion);
    }


    public async Task<Usuario> GetPorCodigo(string codigo)
    {
        return await usuarioRepositorio.GetPorCodigo(codigo);
    }

}

