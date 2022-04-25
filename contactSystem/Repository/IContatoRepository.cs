using contactSystem.Models;
using System.Collections.Generic;
namespace contactSystem.Repository
{
    public interface IContatoRepository
    {
        IEnumerable<ContatoModels> Add(ContatoModels contato);
        IEnumerable<ContatoModels> GetAll();
        ContatoModels Get(int id);
        IEnumerable<ContatoModels> Alter(ContatoModels contato);
        IEnumerable<ContatoModels> Delete(int id);



    }
}
