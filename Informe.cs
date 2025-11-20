using System.Collections.ObjectModel;

namespace BattleshipsTDD;

public class Informe
{    
    public int DisparosRecibidos { get; set; }
    public int DisparosAsertadosEnemigo { get; set; }
    public int DisparosFalladosEnemigo { get;  set; }
    public string RepresentacionTablero { get; set; }

    private List<(TipoBarco TipoBarco, Coordenada cordenada)> _BarcosUndidos { get; set; } = new ();

    public void AgregarBarcoUndido(TipoBarco tipoBarco, Coordenada coordenada)
    {
        _BarcosUndidos.Add((tipoBarco, coordenada));
    }
    public ReadOnlyCollection<(TipoBarco TipoBarco, Coordenada cordenada)> ObtenerBarcosUndidos() {
        return  _BarcosUndidos.AsReadOnly();;
    }
}