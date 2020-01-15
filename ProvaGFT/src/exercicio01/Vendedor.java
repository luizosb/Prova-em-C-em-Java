package exercicio01;

public class Vendedor extends Funcionario {

	public Vendedor(String nome, int idade, double salario) {
		super(nome, idade, salario);
		
	}
	
	@Override
	public void Bonificacao() {
		this.setSalario(this.getSalario()+3000.00);		
		System.out.println(this.getNome() + ", com o salário de " + this.getSalario());
	}
	

}
