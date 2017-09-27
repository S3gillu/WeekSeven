using Associate.Core;
using Associate.Core.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Associate.Infra
{
    public class AssociateAppRepository: IAssociateAppRepository
    {
        AssociateRepository context = new AssociateRepository();
        public void Add(AssociateApp p)
        {
            context.AssociateApps.Add(p);
            context.SaveChanges();
        }
        public void Edit(AssociateApp p)
        {
            context.Entry(p).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public AssociateApp FindById(int Id)
        {
            var result = (from r in context.AssociateApps where r.Id == Id select r).FirstOrDefault();
            return result;
        }
        public IEnumerable GetAssociates()
        {
            return context.AssociateApps;
        }
        public void Remove(int Id)
        {
            AssociateApp p = context.AssociateApps.Find(Id);
            context.AssociateApps.Remove(p);
            context.SaveChanges();
        }
    }
}
