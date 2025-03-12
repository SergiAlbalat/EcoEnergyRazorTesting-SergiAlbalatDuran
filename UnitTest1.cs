using EcoEnergyRazorProject.Models;
namespace EcoEnergyRazorTesting
{
    public class CalcularEnergiaTesting
    {
        [Fact]
        public void Test1()
        {
            SistemaEnergia simulacio = new SistemaEnergia(DateTime.Now, "Solar", 0, 3, 0.2, 0.5);
            Assert.Equal(simulacio.Energia, 0);
        }
        [Fact]
        public void Test2()
        {
            SistemaEnergia simulacio = new SistemaEnergia(DateTime.Now, "Solar", 20, 3, 0.2, 0.5);
            Assert.Equal(simulacio.Energia, 60);
        }
        [Fact]
        public void Test3()
        {
            SistemaEnergia simulacio = new SistemaEnergia(DateTime.Now, "Solar", 5, 0.1, 0.2, 0.5);
            Assert.Equal(simulacio.Energia, 0.5);
        }
        [Fact]
        public void Test4()
        {
            SistemaEnergia simulacio = new SistemaEnergia(DateTime.Now, "Solar", 20, 0.1, 0.2, 0.5);
            Assert.Equal(simulacio.Energia, 2);
        }
    }
    public class CalcularCostTotalTesting
    {
        [Fact]
        public void Test1()
        {

        }
    }
}
