using AwesomeAssertions;

namespace BattleshipsTDD;

public class BattleshipsTest 
{
    [Fact]
    public void Si_SeCreaUnTablero10X10_Al_Imprimirlo_Debe_MostrarUnTableroVacioDe10X10()
    {
        //Arrange
        var batallaNaval = new BatallaNaval();
        
        //Act
        string tablero = batallaNaval.Print();
        
        //Assert
        string tableroEsperado = "   | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |\n" +
                                 " 0 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 1 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 2 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 3 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 4 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 5 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 6 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 7 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 8 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 9 |   |   |   |   |   |   |   |   |   |   |\n";
        tablero.Should().Be(tableroEsperado);
    }
}

public class BatallaNaval
{

    public string Print()
    {
        return "   | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |\n" +
            " 0 |   |   |   |   |   |   |   |   |   |   |\n" +
            " 1 |   |   |   |   |   |   |   |   |   |   |\n" +
            " 2 |   |   |   |   |   |   |   |   |   |   |\n" +
            " 3 |   |   |   |   |   |   |   |   |   |   |\n" +
            " 4 |   |   |   |   |   |   |   |   |   |   |\n" +
            " 5 |   |   |   |   |   |   |   |   |   |   |\n" +
            " 6 |   |   |   |   |   |   |   |   |   |   |\n" +
            " 7 |   |   |   |   |   |   |   |   |   |   |\n" +
            " 8 |   |   |   |   |   |   |   |   |   |   |\n" +
            " 9 |   |   |   |   |   |   |   |   |   |   |\n";
    }