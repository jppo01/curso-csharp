
public class Retangulo 
{
    // Atributos
    private double Largura;
    private double Altura;

    // ======== MÉTODOS ========

    // Construtores
    public Retangulo (double largura, double altura){
        Largura = largura;
        Altura = altura;
    }

    //formulas matemáticas
    public double Area()
    {
        return (Altura * Largura);
    }
    public double Perimetro()
    {
        return (2*(Altura + Largura));
    }

    public double Diagonal()
    {
        return (Math.Sqrt(Altura * Altura + Largura * Largura));
    }
}