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
        batallaNaval.ColocarBarco(jugador: 1,columna: 0,fila: 0, tipo: 'g');
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
        batallaNaval.ColocarBarco(jugador: 1,columna: 1,fila: 1, tipo: 'g');
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
    
    
    [Fact] public void Si_ElJugador1AgregaUnDestructorEnPosicion1_1ConOrientacionHorizontal_Debe_AparecerEnElTableroDelJugador1LaPosicion1_1Y1_2Y1_3ElDestructor()
    {
        //Arrange
        var batallaNaval = new BatallaNaval();
        batallaNaval.AddPlayer();

        //Act
        batallaNaval.ColocarBarco(jugador: 1,fila: 1,columna: 1,tipo:'d', orientacion: "horizontal");
        string tablero = batallaNaval.Print();
        
        //Assert 
        string tableroEsperado = "   | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |\n" +
                                 " 0 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 1 |   | d | d | d |   |   |   |   |   |   |\n" +
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
    
    [Fact] public void Si_ElJugador1AgregaUnDestructorEnPosicion1_1ConOrientacionVertical_Debe_AparecerEnElTableroDelJugador1LaPosicion1_1Y2_1Y3_1ElDestructor()
    {
        //Arrange
        var batallaNaval = new BatallaNaval();
        batallaNaval.AddPlayer();

        //Act
        batallaNaval.ColocarBarco(jugador: 1,fila: 1,columna: 1,tipo:'d', orientacion: "vertical");
        string tablero = batallaNaval.Print();
        
        //Assert 
        string tableroEsperado = "   | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |\n" +
                                 " 0 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 1 |   | d |   |   |   |   |   |   |   |   |\n" +
                                 " 2 |   | d |   |   |   |   |   |   |   |   |\n" +
                                 " 3 |   | d |   |   |   |   |   |   |   |   |\n" +
                                 " 4 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 5 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 6 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 7 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 8 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 9 |   |   |   |   |   |   |   |   |   |   |\n";
        tablero.Should().Be(tableroEsperado);
    }
    
    [Fact] public void Si_ElJugador1AgregaUnPortaavionesEnPosicion1_1ConOrientacionVertical_Debe_AparecerEnElTableroDelJugador1LaPosicion1_1Y2_1Y3_1Y4_1ElPortaaviones()
    {
        //Arrange
        var batallaNaval = new BatallaNaval();
        batallaNaval.AddPlayer();

        //Act
        batallaNaval.ColocarBarco(jugador: 1,fila: 1,columna: 1,tipo:'c', orientacion: "vertical");
        string tablero = batallaNaval.Print();
        
        //Assert 
        string tableroEsperado = "   | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |\n" +
                                 " 0 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 1 |   | c |   |   |   |   |   |   |   |   |\n" +
                                 " 2 |   | c |   |   |   |   |   |   |   |   |\n" +
                                 " 3 |   | c |   |   |   |   |   |   |   |   |\n" +
                                 " 4 |   | c |   |   |   |   |   |   |   |   |\n" +
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
        for (int i = 0; i <tablero.GetLength(1); i++) {
            for (int j = 0; j < tablero.GetLength(0); j++) {
                tablero[i,j]= ' ';
            }
        }
    }

    

    public string Print()
    { 
        // | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |\n
        string texto = "   |";
        for (int j = 0; j < tablero.GetLength(0); j++) //FilasEncabezado
        {
            texto += $" {j} |";
        }
        texto += "\n";
        
        for (int x = 0; x < tablero.GetLength(1); x++) //Columnas
        {
            texto += $" {x} |";
            for (int y = 0; y < tablero.GetLength(0); y++) //Filas
            {
                texto += $" {tablero[x,y]} |";
            }
            texto += "\n";
        }
        textoTablero = texto;
        
          
        return textoTablero;
    }
    
    public void AddPlayer()
    {
        cantidadJugadores++;
    }

    public void ColocarBarco(int jugador, int columna, int fila, char tipo, string? orientacion = null)
    {
        
        tablero[columna,fila] = tipo;
        
        
        if (tipo == 'd' && orientacion == "vertical")
        {
            for (int i = 0; i < 3; i++)
            {
                tablero[columna+i,fila] = tipo;
            }
        }
        if (tipo == 'd' && orientacion == "horizontal")
        {
            for (int i = 0; i < 3; i++)
            {
                tablero[columna,fila+i] = tipo;
            }
        }
        if (tipo == 'c' && orientacion == "vertical")
        {
            for (int i = 0; i < 4; i++)
            {
                tablero[columna+i,fila] = tipo;
            }
        }
    }
}