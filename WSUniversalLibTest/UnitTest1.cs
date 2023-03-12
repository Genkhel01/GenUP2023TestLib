using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSUniversalLib;

namespace WSUniversalLibTest
{
    [TestClass]
    public class UnitTestsCalcMaterials //LowComplexityMethods
    {
        [TestMethod]
        public void GetQuantityForProduct_PositiveTest()
        {
            int count = 15, product_type = 3, material_type = 1;
            float width = 20, length = 45;

            int expended = 114147; //114148

            CalcMaterials testCalcMaterials = new CalcMaterials( count, product_type, width, length, material_type);

            Assert.AreEqual(expended, testCalcMaterials.quantity_raw);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentProductType()
        {
            int count = 15, product_type = -10, material_type = 1;
            float width = 20, length = 45;

            int expended = -1;

            CalcMaterials testCalcMaterials = new CalcMaterials(count, product_type, width, length, material_type);

            Assert.AreEqual(expended, testCalcMaterials.quantity_raw);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentMaterialsType()
        {
            int count = 15, product_type = 3, material_type = 50;
            float width = 20, length = 45;

            int expended = -1;

            CalcMaterials testCalcMaterials = new CalcMaterials(count, product_type, width, length, material_type);

            Assert.AreEqual(expended, testCalcMaterials.quantity_raw);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentLenght()
        {
            int count = 15, product_type = 3, material_type = 1;
            float width = 20, length = -45;

            int expended = -1;

            CalcMaterials testCalcMaterials = new CalcMaterials(count, product_type, width, length, material_type);

            Assert.AreEqual(expended, testCalcMaterials.quantity_raw);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentWidth()
        {
            int count = 15, product_type = 3, material_type = 1;
            float width = -20, length = 45;

            int expended = -1;

            CalcMaterials testCalcMaterials = new CalcMaterials(count, product_type, width, length, material_type);

            Assert.AreEqual(expended, testCalcMaterials.quantity_raw);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentCount()
        {
            int count = -1, product_type = 3, material_type = 1;
            float width = 20, length = 45;

            int expended = -1;

            CalcMaterials testCalcMaterials = new CalcMaterials(count, product_type, width, length, material_type);

            Assert.AreEqual(expended, testCalcMaterials.quantity_raw);
        }

        [TestMethod]
        public void GetQuantityForProduct_ZeroCount()
        {
            int count = 0, product_type = 3, material_type = 1;
            float width = 20, length = 45;

            int expended = 0;

            CalcMaterials testCalcMaterials = new CalcMaterials(count, product_type, width, length, material_type);

            Assert.AreEqual(expended, testCalcMaterials.quantity_raw);
        }

        [TestMethod]
        public void GetQuantityForProduct_TooSmallWidth()
        {
            int count = 0, product_type = 3, material_type = 1;
            float width = float.MinValue, length = 45;

            int expended = -1;

            CalcMaterials testCalcMaterials = new CalcMaterials(count, product_type, width, length, material_type);

            Assert.AreEqual(expended, testCalcMaterials.quantity_raw);
        }

        [TestMethod]
        public void GetQuantityForProduct_TooBigWidth()
        {
            int count = 0, product_type = 3, material_type = 1;
            float width = float.MaxValue, length = 45;

            int expended = -1;

            CalcMaterials testCalcMaterials = new CalcMaterials(count, product_type, width, length, material_type);

            Assert.AreEqual(expended, testCalcMaterials.quantity_raw);
        }

        [TestMethod]
        public void GetQuantityForProduct_TooSmallLenght()
        {
            int count = 0, product_type = 3, material_type = 1;
            float width = 20, length = float.MinValue;

            int expended = -1;

            CalcMaterials testCalcMaterials = new CalcMaterials(count, product_type, width, length, material_type);

            Assert.AreEqual(expended, testCalcMaterials.quantity_raw);
        }

        [TestMethod]
        public void GetQuantityForProduct_TooBigLenght()
        {
            int count = 0, product_type = 3, material_type = 1;
            float width = 20, length = float.MaxValue;

            int expended = -1;

            CalcMaterials testCalcMaterials = new CalcMaterials(count, product_type, width, length, material_type);

            Assert.AreEqual(expended, testCalcMaterials.quantity_raw);
        }
    }
}
