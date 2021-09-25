public class SerieRepositorio : IRepositorio<Serie>
{
    private List<Serie> listaSerie = new List<Serie>();
    public void Atualiza(int id, Serie serie);
    public void Atualiza(int id, Serie objeto)
    {
        listaSerie[id] = objeto;
    }
    public void Excluir(int id)
    {
        listaSerie[id].Excluir();
    }
    public void Insere(Serie entidade)
    {
        listaSerie.Add(objeto);
    }
    public List<Serie> Lista()
    {
        return listaSerie;
    }
    public int ProximoId()
    {
        return listaSerie.Count;
    }
    public Serie RetornaPorId(int id)
    {
        return listaSerie[id];
    }

}