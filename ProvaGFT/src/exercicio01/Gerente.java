package exercicio01;

public class Gerente extends Funcionario {

	public Gerente(String nome, int idade, double salario) {
		super(nome, idade, salario);
		
	}
	
	@Override
	public void Bonificacao() {
		this.setSalario(this.getSalario()+10000.00);	
		System.out.println(this.getNome() + ", com o salário de " + this.getSalario());
	}
	

}
