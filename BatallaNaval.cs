using System.Text;

namespace BattleshipsTDD;

public class BatallaNaval
{
    private char[,] _tableroGenerico;
    private Dictionary<int, char[,]> _jugadores = new();
    private int _jugadorActual;

    public BatallaNaval(int filasTablero = 10, int columnasTablero = 10)
    {
        _tableroGenerico = new char[filasTablero, columnasTablero];
        LlenarTableroGenericoConEspacios();
    }

    private void LlenarTableroGenericoConEspacios()
    {
        for (int i = 0; i < _tableroGenerico.GetLength(1); i++)
        {
            for (int j = 0; j < _tableroGenerico.GetLength(0); j++)
            {
                _tableroGenerico[i, j] = ' ';
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
                generadorCuerpo.Append($" {tableroJugadorSeleccionado[x, y]} |");
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
        _jugadores.Add(_jugadores.Count + 1, (char[,])_tableroGenerico.Clone());
    }

    public void ColocarBarco(int jugador, int columna, int fila, TipoBarco tipo, TipoOrientacion? orientacion = null)
    {
        var longitudDelBarco = CalcularLogitudBarco(tipo);
        char[,] tableroActual = ObtenerTableroJugador(jugador);

        while (longitudDelBarco is not 0)
        {
            tableroActual![columna, fila] = (char)tipo;
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
        var jugadorAtacado = ObtenerSiguienteJugador();
        var tableroJugadorAtacado = ObtenerTableroJugador(jugadorAtacado);

        var posicionAtacada = tableroJugadorAtacado[columna, fila];
        if (posicionAtacada == ' ')
        {
            tableroJugadorAtacado[columna, fila] = 'o';
        }
        else
        {
            if (posicionAtacada is (char)TipoBarco.PortaAviones or (char)TipoBarco.Destructor)
                tableroJugadorAtacado[columna, fila] = 'x';
            else
                tableroJugadorAtacado[columna, fila] = 'X';
        }
    }

    public void EndTurn()
    {
        _jugadorActual = ObtenerSiguienteJugador();
    }

    private int ObtenerSiguienteJugador()
    {
        if (_jugadorActual == _jugadores.Count) return 1;
        return _jugadorActual + 1;
    }

    public Informe InformeGeneral()
    {
        return new() { DisparosRecibidos = 0, DisparosAsertadosEnemigo = 0, DisparosFalladosEnemigo = 0, RepresentacionTablero = Print(1)};
    }
}

public class Informe
{
    public int DisparosRecibidos { get; set; }
    public int DisparosAsertadosEnemigo { get; set; }
    public int DisparosFalladosEnemigo { get;  set; }
    public string RepresentacionTablero { get; set; }
}