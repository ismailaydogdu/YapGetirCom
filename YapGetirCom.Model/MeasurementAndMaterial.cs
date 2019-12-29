using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapGetirCom.Model
{
    public class MeasurementAndMaterial
    {
        public int MeasurementAndMaterialID { get; set; }
        public int MaterialID { get; set; }
        public int MeasurementUnitOfMaterialID { get; set; }
        public decimal Price { get; set; }

        public virtual Material Material { get; set; }
        public virtual MeasurementUnitOfMaterial MeasurementUnitOfMaterial { get; set; }

    }
}
