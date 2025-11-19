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
        batallaNaval.ColocarBarco(jugador: 1,columna: 0,fila: 0, tipo:TipoBarco.Cañonero);
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
        batallaNaval.ColocarBarco(jugador: 1,columna: 1,fila: 1, tipo: TipoBarco.Cañonero);
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
        batallaNaval.ColocarBarco(jugador: 1,fila: 1,columna: 1,tipo:TipoBarco.Destructor, orientacion: TipoOrientacion.Horizontal);
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
        batallaNaval.ColocarBarco(jugador: 1,fila: 1,columna: 1,tipo:TipoBarco.Destructor, orientacion: TipoOrientacion.Vertical);
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
        batallaNaval.ColocarBarco(jugador: 1,fila: 1,columna: 1,tipo:TipoBarco.PortaAviones, orientacion: TipoOrientacion.Vertical);
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
    
    [Fact] public void Si_ElJugador1AgregaUnPortaavionesEnPosicion1_1ConOrientacionHorizonta_Debe_AparecerEnElTableroDelJugador1LaPosicion1_1Y1_2Y1_3Y1_4ElPortaaviones()
    {
        //Arrange
        var batallaNaval = new BatallaNaval();
        batallaNaval.AddPlayer();

        //Act
        batallaNaval.ColocarBarco(jugador: 1,fila: 1,columna: 1,tipo:TipoBarco.PortaAviones, orientacion: TipoOrientacion.Horizontal);
        string tablero = batallaNaval.Print();
        
        //Assert 
        string tableroEsperado = "   | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |\n" +
                                 " 0 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 1 |   | c | c | c | c |   |   |   |   |   |\n" +
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
    public void Si_ElJugador1AgregaUnaCañoneroEnPosicion1_1_y_El_jugador2AgregaUnaCañoneroEnPosicion2_2_Debe_AparecerEnElTableroDelJugador2UnicamenteEnLaPosicion2_2UnaCañonero()
    {
        //Arrange
        var batallaNaval = new BatallaNaval();
        batallaNaval.AddPlayer();
        batallaNaval.AddPlayer();

        //Act
        batallaNaval.ColocarBarco(jugador: 1,fila: 1,columna: 1,tipo:TipoBarco.Cañonero);
        batallaNaval.ColocarBarco(jugador: 2,fila: 2,columna: 2,tipo:TipoBarco.Cañonero);
        string tablero = batallaNaval.Print(jugador:2);
        
        //Assert 
        string tableroEsperado = "   | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |\n" +
                                 " 0 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 1 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 2 |   |   | g |   |   |   |   |   |   |   |\n" +
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
    public char[,] tableroJugador1;
    public char[,] tableroJugador2;
    public BatallaNaval(int filasTablero = 10,int columnasTablero = 10)
    {   
        tableroJugador1 = new char[filasTablero, columnasTablero];
        tableroJugador2 = new char[filasTablero, columnasTablero];
        for (int i = 0; i <tableroJugador1.GetLength(1); i++) {
            for (int j = 0; j < tableroJugador1.GetLength(0); j++) {
                tableroJugador1[i,j]= ' ';
            }
        }
        for (int i = 0; i <tableroJugador2.GetLength(1); i++) {
            for (int j = 0; j < tableroJugador2.GetLength(0); j++) {
                tableroJugador2[i,j]= ' ';
            }
        }
    }

    

    public string Print(int jugador = 1)
    { 
        char[,] tableroJugador = jugador == 1 ? tableroJugador1 : tableroJugador2;
        // | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |\n
        string texto = "   |";
        for (int j = 0; j < tableroJugador.GetLength(0); j++) //FilasEncabezado
        {
            texto += $" {j} |";
        }
        texto += "\n";
        
        for (int x = 0; x < tableroJugador.GetLength(1); x++) //Columnas
        {
            texto += $" {x} |";
            for (int y = 0; y < tableroJugador.GetLength(0); y++) //Filas
            {
                texto += $" {tableroJugador[x,y]} |";
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

    public void ColocarBarco(int jugador, int columna, int fila, TipoBarco tipo, TipoOrientacion? orientacion = null)
    {
        var longitudDelBarco = CalcularLogitudBarco(tipo);
       
        char[,] tableroActual = jugador == 1 ? tableroJugador1 : tableroJugador2;
        while (longitudDelBarco is not 0)
        {
            tableroActual[columna,fila] = (char)tipo;
            if (orientacion == TipoOrientacion.Vertical)
                columna++;
            if (orientacion == TipoOrientacion.Horizontal)
                fila++;
            longitudDelBarco--;
        }   
    }

    private static int CalcularLogitudBarco(TipoBarco tipo) =>
        tipo switch
        {
            TipoBarco.PortaAviones => 4,
            TipoBarco.Destructor => 3,
            TipoBarco.Cañonero => 1
        };
}

public enum TipoOrientacion
{
    Vertical,
    Horizontal
}
public enum TipoBarco
{
    PortaAviones = 'c',
    Destructor = 'd',
    Cañonero = 'g'
}