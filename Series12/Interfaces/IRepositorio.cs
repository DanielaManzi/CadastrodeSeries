using System.Collections.Generic;

namespace Series.Interface
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int Id);
        void Insere (T entidade);
        void Excluir (int id);
        void Atualizar (int id, T entidade);
        int ProximoId();

    }
}