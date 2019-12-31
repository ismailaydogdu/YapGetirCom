using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;

namespace YapGetirCom.BLL.Abstract
{
    public interface IUnitAndProductService : IBaseService<UnitAndProduct>
    {
        List<UnitAndProduct> GetByProductID(int productID);
    }
}
