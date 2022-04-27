
using Modelos;

namespace Examen3Parcial.Interfaces;


    public interface IUsuarioServicio
    {
        Task<Usuario> GetPorCodigo(string codigo);
    }

