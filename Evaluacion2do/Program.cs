// Tipo de rueda: diámetro, llanta y neumático
public class Rueda
{
    public int Diametro { get; set; }
    public string Llanta { get; set; }
    public string Neumatico { get; set; }
}
// Tipo de carrocería
public class Carroceria
{
    public string Material { get; set; }
    public string TipoCarroceria { get; set; }
}
// Interfaz que expone las propiedades del motor
public interface IMotor
{
    string ConsumirCombustible();
    string InyectarCombustible(int cantidad);
    string RealizarEscape();
    string RealizarExpansion();
}
