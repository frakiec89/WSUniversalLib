using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    /// <summary>
    /// псевда  контент  данных // может  быть  бд но  ее  нет
    /// </summary>
    public class MockContent
    {
        public static List<Material_type> GetMaterial_Types()
        {
            List<Material_type> material_Types = new List<Material_type>()
            {
                new Material_type(){ Name="Материал 1" , IdMaterial_type = 1 , CoefficientValue =0.003f},
                new Material_type(){ Name="Материал 2" , IdMaterial_type = 2 , CoefficientValue =0.0012f},
            };
            return material_Types;
        }


        public static List<Product_type> GetProduct_Types()
        {
            return new List<Product_type>
            {
                new Product_type(){ Name="Тип продукции 1" , CoefficientValue= 1.1f , IdProduct_type=1},
                new Product_type(){ Name="Тип продукции 2" , CoefficientValue= 2.5f , IdProduct_type=2},
                new Product_type(){ Name="Тип продукции 3" , CoefficientValue= 8.43f,IdProduct_type=3},
            };
        }
    }
}
