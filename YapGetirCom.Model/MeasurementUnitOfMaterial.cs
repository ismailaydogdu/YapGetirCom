using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace YapGetirCom.Model
{
    public class MeasurementUnitOfMaterial
    {
        public MeasurementUnitOfMaterial()
        {
            MeasurementAndMaterials = new List<MeasurementAndMaterial>();
        }
        public int MeasurementUnitOfMaterialID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MeasurementAndMaterial> MeasurementAndMaterials { get; set; }
    }
}
