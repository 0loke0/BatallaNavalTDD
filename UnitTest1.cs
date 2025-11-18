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
    
    [Fact]
    public void Si_SeAgregaUnUnicoJugador_Debe_ElConteoDeJugadoresSerUno()
    {
        //Arrange
        var batallaNaval = new BatallaNaval();
        
        //Act
        batallaNaval.AddPlayer();
        
        //Assert
        batallaNaval.cantidadJugadores.Should().Be(1);
    }
    [Fact]
    public void Si_SeAgregaDosJugadores_Debe_ElConteoDeJugadoresSerDos()
    {
        //Arrange
        var batallaNaval = new BatallaNaval();
        
        //Act
        batallaNaval.AddPlayer();
        batallaNaval.AddPlayer();
        
        //Assert
        batallaNaval.cantidadJugadores.Should().Be(2);

    }
    
    
}

public class BatallaNaval
{
    public int cantidadJugadores;

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

    public void AddPlayer()
    {
        cantidadJugadores = 1;
    }
}