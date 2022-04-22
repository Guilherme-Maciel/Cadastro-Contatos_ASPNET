using contactSystem.Models;
using System.Collections.Generic;
namespace contactSystem.Repository
{
    public interface IContatoRepository
    {
        IEnumerable<ContatoModels> Add(ContatoModels contato);
        IEnumerable<ContatoModels> GetAll();

    }
}
