package exercicio01;

public class Supervisor extends Funcionario{

	public Supervisor(String nome, int idade, double salario) {
		super(nome, idade, salario);
		
	}
	
	@Override
	public void Bonificacao() {
		this.setSalario(this.getSalario()+5000.00);	
		System.out.println(this.getNome() + ", com o salário de " + this.getSalario());
	}
	
	

}
