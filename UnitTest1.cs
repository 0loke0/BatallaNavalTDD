using System.Text;
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
        batallaNaval.AddPlayer();
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
        batallaNaval.AddPlayer();        
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
    
    [Fact] 
    public void Si_ElJugador1AgregaUnaCañoneroEnPosicion1_1_y_El_jugador2AgregaUnaCañoneroEnPosicion2_2Y_El_jugador3AgregaUnaCañoneroEnPosicion3_3_Debe_AparecerEnElTableroDelJugador3UnicamenteEnLaPosicion3_3UnaCañonero()
    {
        //Arrange
        var batallaNaval = new BatallaNaval();
        batallaNaval.AddPlayer();
        batallaNaval.AddPlayer();
        batallaNaval.AddPlayer();

        //Act
        batallaNaval.ColocarBarco(jugador: 1,fila: 1,columna: 1,tipo:TipoBarco.Cañonero);
        batallaNaval.ColocarBarco(jugador: 2,fila: 2,columna: 2,tipo:TipoBarco.Cañonero);
        batallaNaval.ColocarBarco(jugador: 3,fila: 3,columna: 3,tipo:TipoBarco.Cañonero);
        string tablero = batallaNaval.Print(jugador:3);
        
        //Assert 
        string tableroEsperado = "   | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |\n" +
                                 " 0 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 1 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 2 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 3 |   |   |   | g |   |   |   |   |   |   |\n" +
                                 " 4 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 5 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 6 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 7 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 8 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 9 |   |   |   |   |   |   |   |   |   |   |\n";
        tablero.Should().Be(tableroEsperado);
    }

    [Fact]
    public void
        Si_AlIniciaLaPartidaElPrimerJugadorAtacaEnPosicion2_2_Y_FinalizaElTurno_Y_SegundoJugadorAtacaEnPosicion1_1_Debe_MostrarEnElTableroDelJugador2ComoLaUnicaPosicionAtacada_2_2()
    {
        //Arrange
        var batallaNaval = new BatallaNaval();
        batallaNaval.AddPlayer();
        batallaNaval.AddPlayer();
        batallaNaval.AddPlayer();
        batallaNaval.ColocarBarco(jugador: 1,fila: 3,columna: 3,tipo:TipoBarco.Cañonero);
        batallaNaval.ColocarBarco(jugador: 2,fila: 1,columna: 1,tipo:TipoBarco.Cañonero);
        batallaNaval.Start();
        batallaNaval.Fire(fila: 2,columna: 2);// ataque jugador 1 => mod al 2
        batallaNaval.EndTurn();
        batallaNaval.Fire(fila: 1,columna: 1);// ataque jugador 2 => mod al 1
         
        //Act
        
        string tablero = batallaNaval.Print(jugador:2);
        
        
        //Assert 
        string tableroEsperado = "   | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |\n" +
                                 " 0 |   |   |   |   |   |   |   |   |   |   |\n" +
                                 " 1 |   | g |   |   |   |   |   |   |   |   |\n" +
                                 " 2 |   |   | o |   |   |   |   |   |   |   |\n" +
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
    private char[,] _tableroGenerico;
    private Dictionary<int, char [,]> _jugadores = new ();
    private int _jugadorActual;
    
    public BatallaNaval(int filasTablero = 10,int columnasTablero = 10)
    {
        _tableroGenerico = new char[filasTablero, columnasTablero];
        LlenarTableroGenericoConEspacios();
    }
    private void LlenarTableroGenericoConEspacios()
    {
        for (int i = 0; i <_tableroGenerico.GetLength(1); i++) {
            for (int j = 0; j < _tableroGenerico.GetLength(0); j++) {
                _tableroGenerico[i,j]= ' ';
            }
        }
    }
    public string Print(int jugador = 1)
    { 
        char[,] tableroJugadorSeleccionado = ObtenerTableroJugador(jugador);
        var generadorTableroEnTexto = new StringBuilder("   |");
        generadorTableroEnTexto.Append(GenerarEncabezadoRepresentacionTablero(tableroJugadorSeleccionado));
        generadorTableroEnTexto.Append(GenerarCuerpoRepresentacionTablero(tableroJugadorSeleccionado));
        return generadorTableroEnTexto.ToString();
    }

    private static string GenerarCuerpoRepresentacionTablero(char[,] tableroJugadorSeleccionado)
    {
        StringBuilder generadorCuerpo = new StringBuilder(); 
        for (int x = 0; x < tableroJugadorSeleccionado.GetLength(1); x++) //Columnas
        {
            generadorCuerpo.Append($" {x} |");
            for (int y = 0; y < tableroJugadorSeleccionado.GetLength(0); y++) //Filas
            {
                generadorCuerpo.Append($" {tableroJugadorSeleccionado[x,y]} |");
            }
            generadorCuerpo.Append('\n');
        }

        return generadorCuerpo.ToString();
    }

    private static string GenerarEncabezadoRepresentacionTablero(char[,] tableroJugadorSeleccionado)
    {
        StringBuilder generadorEncabezado = new StringBuilder();
        for (int j = 0; j < tableroJugadorSeleccionado.GetLength(0); j++) //FilasEncabezado
        {
            generadorEncabezado.Append($" {j} |");
        }

        generadorEncabezado.Append('\n');
        return generadorEncabezado.ToString();
    }

    private char[,] ObtenerTableroJugador(int jugador)
    {
        return _jugadores.GetValueOrDefault(jugador)!;
    }

    public void AddPlayer()
    {
        _jugadores.Add(_jugadores.Count+1, (char[,])_tableroGenerico.Clone());
    }

    public void ColocarBarco(int jugador, int columna, int fila, TipoBarco tipo, TipoOrientacion? orientacion = null)
    {
        var longitudDelBarco = CalcularLogitudBarco(tipo);
        char[,] tableroActual = ObtenerTableroJugador(jugador);
        
        while (longitudDelBarco is not 0)
        {
            tableroActual![columna,fila] = (char)tipo;
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

    public void Start()
    {
        _jugadorActual = 1;
    }

    public void Fire(int fila, int columna)
    {
        var tableroJugador= ObtenerTableroJugador(_jugadorActual+1);
        tableroJugador[columna,fila] = 'o';
    }

    public void EndTurn()
    {
        _jugadorActual++;
    }
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