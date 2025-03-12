using EcoEnergyRazorProject.Models;
namespace EcoEnergyRazorTesting
{
    public class CalcularEnergiaTesting
    {
        [Fact]
        public void Test1()
        {
            SistemaEnergia simulacio = new SistemaEnergia(DateTime.Now, "Solar", 0, 3, 0.2, 0.5);
            Assert.Equal(simulacio.Energia, 0, 29999999999999999);
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
            SistemaEnergia simulacio = new SistemaEnergia(DateTime.Now, "Solar", 1, 0.1, 1, 2);
            Assert.Equal(simulacio.CostTotal, 0.1);
        }
        [Fact]
        public void Test2()
        {
            SistemaEnergia simulacio = new SistemaEnergia(DateTime.Now, "Solar", 34, 1, 1, 2);
            Assert.Equal(simulacio.CostTotal, 34);
        }
        [Fact]
        public void Test3()
        {
            SistemaEnergia simulacio = new SistemaEnergia(DateTime.Now, "Solar", 1, 1, 0.1, 2);
            Assert.Equal(simulacio.CostTotal, 0.1);
        }
        [Fact]
        public void Test4()
        {
            SistemaEnergia simulacio = new SistemaEnergia(DateTime.Now, "Solar", 1, 1, 20, 2);
            Assert.Equal(simulacio.CostTotal, 20);
        }
    }
    public class CalcularPreuTotalTesting
    {
        [Fact]
        public void Test1()
        {
            SistemaEnergia simulacio = new SistemaEnergia(DateTime.Now, "Solar", 1, 0.1, 0.1, 1);
            Assert.Equal(simulacio.PreuTotal, 0.1);
        }
        [Fact]
        public void Test2()
        {
            SistemaEnergia simulacio = new SistemaEnergia(DateTime.Now, "Solar", 34, 1, 0.1, 1);
            Assert.Equal(simulacio.PreuTotal, 34);
        }
        [Fact]
        public void Test3()
        {
            SistemaEnergia simulacio = new SistemaEnergia(DateTime.Now, "Solar", 1, 1, 0.1, 0.1);
            Assert.Equal(simulacio.PreuTotal, 0.1);
        }
        [Fact]
        public void Test4()
        {
            SistemaEnergia simulacio = new SistemaEnergia(DateTime.Now, "Solar", 1, 1, 0.1, 20);
            Assert.Equal(simulacio.PreuTotal, 20);
        }
    }
}
