
using System;
class Paciente {

  public Paciente(){}

  public string cartaoVacina { get; set; }

  public string nome { get; set; }

   public string cpf { get; set; }

  public int idade { get; set; }

  public int vacina { get; set; }

  public int dose { get; set; }

  public string email { get; set; }

  public string telefone { get; set; }



  public override string ToString(){
    return 
    "Cartão de Vacina: " + this.cartaoVacina + "\n" +
    "Nome completo: " + this.nome + "\n" +
    "CPF: "+ this.cpf + "\n" +
    "Idade: " + this.idade + "\n" +
    "Nome da vacina: " + this.vacina + "\n" +
    "Dose: " + this.dose + "\n" +
    "E-mail: " + this.email + "\n" +
    "Telefone: " + this.telefone + "\n";
  }

  public void buscarDadosAgendamento (){}

  public void historicoDevacinacao (){}


  public void verificarDose(){

  }
  public void marcarOutraAplicacao(){}
 

}