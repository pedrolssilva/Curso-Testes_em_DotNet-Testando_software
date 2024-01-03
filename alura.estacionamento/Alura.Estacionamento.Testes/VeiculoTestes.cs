using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;

namespace Alura.Estacionamento.Testes
{
    public class VeiculoTestes
    {
        [Fact]
        public void TestaVeiculoAcelerarComParametro10()
        {
            // Arrange
            var veiculo = new Veiculo();

            // Act
            veiculo.Acelerar(10);

            // Assert
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestaVeiculoFrearComParametro10()
        {
            // Arrange
            var veiculo = new Veiculo();
            
            // Act
            veiculo.Frear(10);

            //Assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact(Skip = "Teste ainda nao implementado. Ignorar")]
        public void ValidaNomeProprietariDoVeiculo()
        {

        }

        [Fact]
        public void FichaDeInformacaoDoVeiculo()
        {
            // Arrange
            var carro = new Veiculo();
            carro.Proprietario = "Carlos Silva";
            carro.Tipo = TipoVeiculo.Automovel;
            carro.Cor = "Verde";
            carro.Modelo = "Variante";
            carro.Placa = "ZAP-7419";

            // Act
            string dados = carro.ToString();

            // Assert
            Assert.Contains("Ficha do Veículo:", dados);
        }
    }
}