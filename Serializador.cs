using System.Text;

namespace BattleshipsTDD;

public static class Serializador
{
    public static string SerializarTablero(char[,] tablero) {
        var generadorTableroEnTexto = new StringBuilder("   |");
        generadorTableroEnTexto.Append(GenerarEncabezadoRepresentacionTablero(tablero));
        generadorTableroEnTexto.Append(GenerarCuerpoRepresentacionTablero(tablero));
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
    
}