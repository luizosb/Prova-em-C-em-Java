package exercicio01;

import java.util.ArrayList;
import java.util.List;

public class Exercicio01 {

	public static void main(String[] args) {
		
		Pessoa p1 = new Pessoa("Jõao", 15);
		Pessoa p2 = new Pessoa("Leandro", 21);
		Pessoa p3 = new Pessoa("Paulo", 17);
		Pessoa p4 = new Pessoa("Jessica", 18);
		
	List<Pessoa> pessoas = new ArrayList<>();
	pessoas.add(p1);
	pessoas.add(p2);
	pessoas.add(p3);
	pessoas.add(p4);
	
	System.out.println("----------Lista Antes------------");

	for(Pessoa ind : pessoas) {
		System.out.println(ind.getNome() + ", " + ind.getIdade());						
	}
	 	
	
	
	for ( int i = 0; i < pessoas.size() - 1; i++) {
		if(pessoas.get(i).getIdade() > pessoas.get(i + 1).getIdade()){
			System.out.println("A pessoa mais velha é " + pessoas.get(i).getNome());
		}
	}
	
	for ( int i = 0; i < pessoas.size() - 1; i++) {
		Pessoa p = pessoas.get(i);
		if(p.getIdade() < 18) {
		
		pessoas.remove(i);
		}
	}
	
	System.out.println("----------Lista Depois------------");
	for (int i = 0; i < pessoas.size(); i++ ) {
		System.out.println(pessoas.get(i).getNome() + ", " + pessoas.get(i).getIdade());
	}
		
	for(int i = 0; i < pessoas.size(); i++) {
		if (pessoas.get(i).getNome().equals("Jessica")) {
			System.out.println("Jessica está lista.");
		}
	}
	
	System.out.println("----------------------------------------------------");
	
	Gerente gerente = new Gerente("Robson", 45, 6500 );
	Supervisor supervisor = new Supervisor("Tavaes", 30, 4000 );
	Vendedor vendedor = new Vendedor("Josevaldo", 25, 2000 );
	
	gerente.Bonificacao();
	supervisor.Bonificacao();
	vendedor.Bonificacao();
			
	}
	
	
	
	
}
	
	
	
	
	
	
	
	
	



