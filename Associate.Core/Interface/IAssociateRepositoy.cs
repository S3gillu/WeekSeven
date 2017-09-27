
using System.Collections;

namespace Associate.Core.Interface
{
    public interface IAssociateAppRepository
    {

        void Add(AssociateApp p);
        void Edit(AssociateApp p);
        void Remove(int Id);
        IEnumerable GetAssociates();
        AssociateApp FindById(int Id);

    }
}
