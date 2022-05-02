using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class ContactDal : EntityRepositoryBase<Contact,MakaleContext>, IContactDal
    {
    }
}
