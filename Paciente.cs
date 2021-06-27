
using System;
using System.Collections.Generic;
class Paciente {

  public Paciente(){}

  public string numeroCartaoVacina { get; set; }

  public string nome { get; set; }

   public string cpf { get; set; }

  public int idade { get; set; }

  public string vacina { get; set; }

  public int dose { get; set; }

  public string email { get; set; }

  public string telefone { get; set; }



  public override string ToString(){
    return 
    "Cartão de Vacina: " + this.numeroCartaoVacina + "\n" +
    "Nome completo: " + this.nome + "\n" +
    "CPF: "+ this.cpf + "\n" +
    "Idade: " + this.idade + "\n" +
    "Nome da vacina: " + this.vacina + "\n" +
    "Dose: " + this.dose + "\n" +
    "E-mail: " + this.email + "\n" +
    "Telefone: " + this.telefone + "\n";
  }
  public string historicoDevacinacao (){
    // exibir nome da vacina e dose
    return (
      "Cartão de Vacina: " + this.numeroCartaoVacina + "\n" +
     "Nome completo: " + this.nome + "\n" +
     "Nome da vacina: " + this.vacina + "\n" +
     "Dose: " + this.dose

    );
    
  }


 
  public void marcarOutraAplicacao(){
    if(this.dose == 1){
      Console.WriteLine("Precisa-se agendar a segunda dose");
    }
    else if(this.dose == 2){
      return; 
    }
  }
 

}