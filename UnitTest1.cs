using AwesomeAssertions;

namespace BattleshipsTDD;

public class BattleshipsTest 
{
    public BattleshipsTest()
    {
    }

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

    [Fact] public void Si_ElJugador1AgregaUnaCañoneraEnPosicion0_0_Debe_AparecerEnElTableroDelJugador1LaPosicion0_0LaCañonera()
    {
        //Arrange
        var batallaNaval = new BatallaNaval();
        batallaNaval.AddPlayer();

        //Act
        batallaNaval.ColocarBarco(jugador: 1,fila: 0,columna: 0,tipo:'g');
        string tablero = batallaNaval.Print();
        
        //Assert 
        string tableroEsperado = "   | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |\n" +
                                 " 0 | g |   |   |   |   |   |   |   |   |   |\n" +
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
    public void Si_SeCreaUnTablero09X09_Al_Imprimirlo_Debe_MostrarUnTableroVacioDe09X09()
    {
        //Arrange
        var batallaNaval = new BatallaNaval(filasTablero:9,columnasTablero:9);
        
        //Act
        string tablero = batallaNaval.Print();
        
        //Assert
        string tableroEsperado = "   | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 |\n" +
                                 " 0 |   |   |   |   |   |   |   |   |   |\n" +
                                 " 1 |   |   |   |   |   |   |   |   |   |\n" +
                                 " 2 |   |   |   |   |   |   |   |   |   |\n" +
                                 " 3 |   |   |   |   |   |   |   |   |   |\n" +
                                 " 4 |   |   |   |   |   |   |   |   |   |\n" +
                                 " 5 |   |   |   |   |   |   |   |   |   |\n" +
                                 " 6 |   |   |   |   |   |   |   |   |   |\n" +
                                 " 7 |   |   |   |   |   |   |   |   |   |\n" +
                                 " 8 |   |   |   |   |   |   |   |   |   |\n";
        tablero.Should().Be(tableroEsperado);
    }
    
    [Fact] public void Si_ElJugador1AgregaUnaCañoneraEnPosicion1_1_Debe_AparecerEnElTableroDelJugador1LaPosicion1_1LaCañonera()
    {
        //Arrange
        var batallaNaval = new BatallaNaval();
        batallaNaval.AddPlayer();

        //Act
        batallaNaval.ColocarBarco(jugador: 1,fila: 1,columna: 1,tipo:'g');
        string tablero = batallaNaval.Print();
        
        //Assert 
        string tableroEsperado = "   | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |\n" +
                                 " 0 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 1 |   | g |   |   |   |   |   |   |   |   |\n" +
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
    public int cantidadJugadores;
    public string textoTablero = "";
    public char[,] tablero;
    public BatallaNaval(int filasTablero = 10,int columnasTablero = 10)
    {   
        tablero = new char[filasTablero, columnasTablero];
    }

    

    public string Print()
    {
        if (!textoTablero.Any(g=> g=='g'))
        {
            string texto = "   |";
            for (int j = 0; j < tablero.GetLength(0); j++) //FilasEncabezado
            {
                texto += $" {j} |";
            }
            texto += "\n";
            for (int i = 0; i < tablero.GetLength(1); i++) //Columnas
            {
                texto += $" {i} |";
                for (int j = 0; j < tablero.GetLength(0); j++) //Filas
                {
                    texto += "   |";
                }
                texto += "\n";
            }
            textoTablero = texto;
        }
          
        return textoTablero;
    }

    public void AddPlayer()
    {
        cantidadJugadores++;
    }

    public void ColocarBarco(int jugador, int fila, int columna, char tipo)
    {
        textoTablero = "   | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |\n" +
                  " 0 | g |   |   |   |   |   |   |   |   |   |\n" +
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
}