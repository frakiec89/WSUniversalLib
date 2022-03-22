using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Calculation
    {
        /// <summary>
        /// Метод вычисления целого количества сырья, необходимого для производства определенного типа продукции
        /// </summary>
        /// <param name="productType"></param>
        /// <param name="materialType"></param>
        /// <param name="count"></param>
        /// <param name="width"></param>
        /// <param name="length"></param>
        /// <returns>целое количество сырья</returns>
        public int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
          
            if ( MockContent.GetMaterial_Types().Any(x=>x.IdMaterial_type==materialType)== false)
            {
                return -1;
            }

            if (MockContent.GetProduct_Types().Any(x => x.IdProduct_type == productType)==false)
            {
                return -1;
            }

            if (count<0 || width<0 || length< 0)
            {
                return -1;
            }

            Material_type material = MockContent.GetMaterial_Types().Single(x => x.IdMaterial_type == materialType);
            Product_type product = MockContent.GetProduct_Types().Single(x => x.IdProduct_type == productType);

            double countMaterail =(double) count * (double) width * (double)length * (double) product.CoefficientValue ; 
            countMaterail = Math.Ceiling(countMaterail);

            double brak  = Convert.ToSingle(countMaterail) * Convert.ToSingle( material.CoefficientValue)  ;
            brak = Math.Ceiling(brak);

            var rez = countMaterail + brak ;
            return  (int) rez ;
        }
    }
}
