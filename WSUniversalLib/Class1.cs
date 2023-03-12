using System;

namespace WSUniversalLib
{
    public class CalcMaterials
    {

        public int count, product_type, material_type, quantity_raw;
        public float width, length;

        public CalcMaterials(int count, int product_type,
            float width, float length, int material_type)
        {
            this.count = count;
            this.product_type = product_type;
            this.width = width;
            this.length = length;
            this.material_type = material_type;
            this.quantity_raw = GetQuantityForProduct(this.count, this.product_type, 
                this.width , this.length, this.material_type);
        }

        //Метод по расчёту 
        public int GetQuantityForProduct(int count, int product_type,
            float width, float length, int material_type)
        {
            //Коэфиценты типа продукции
            float[] product_coefficient = new float[] {1.1F, 2.5F, 8.43F};
            //Процент брака материала в зависимости от его типа
            float[] material_coefficient = new float[] {0.3F, 0.12F};

            try
            {
                if (width <= 0 || length <= 0 || count < 0 || width == float.MaxValue || length == float.MaxValue)
                    return -1;
                float raw_materials_without_defects = count * width * length * product_coefficient[product_type - 1];
                return (int)Math.Ceiling(raw_materials_without_defects / 100.0F * material_coefficient[material_type-1] + raw_materials_without_defects);
            }
            catch //При обращении к несуществующим элементам массива - возвращает -1
            {
                return -1;
            }
        }


    }
}
