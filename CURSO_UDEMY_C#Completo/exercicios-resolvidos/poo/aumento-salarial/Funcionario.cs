public class Funcionario {

    //========== ATRIBUTOS ============
    private string Nome;
    private double SalarioBruto;
    private double Imposto;


    //========== MÉTODOS ==============
    // Construtor
    public Funcionario(string nome, double salarioBruto, double imposto){
        Nome = nome;
        SalarioBruto = salarioBruto;
        Imposto = imposto;
    }
    // ToString do object
    public override string ToString()
    {
        return ("Funcionário: " + Nome + ", Salário líquido: R$ "  + SalarioLiquido().ToString("F2"));
    }

    //Operações matemáticas
    public double SalarioLiquido(){
        return (SalarioBruto-Imposto);
    }

    public void AumentarSalario(double porcentagem){
        SalarioBruto = (SalarioBruto + (SalarioBruto * (porcentagem/100)));
    }
}