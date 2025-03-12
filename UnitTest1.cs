using EcoEnergyRazorProject.Models;
namespace EcoEnergyRazorTesting
{
    public class CalcularEnergiaTesting
    {
        [Fact]
        public void Test1()
        {
            SistemaEnergia simulacio = new SistemaEnergia(DateTime.Now, "Solar", 0, 2, 0.2, 0.5);
            Assert.Equal(simulacio.Energia, 0);
        }
        [Fact]
        public void Test2()
        {
            SistemaEnergia simulacio = new SistemaEnergia(DateTime.Now, "Solar", 20, 2, 0.2, 0.5);
            Assert.Equal(simulacio.Energia, 40);
        }
    }
}
