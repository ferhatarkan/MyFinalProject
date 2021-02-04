using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Interfacin operasyonlar  public
    public interface IProductDal:IEntityRepository<Product>
    {
        
    }
}
