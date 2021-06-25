
using System;
class Agendamento {

  public Agendamento(){}

  public string dataVacinacao { get; set; }

  public string local { get; set; }

   public string aplicacaoFuncionario { get; set; }


  public override string ToString(){
    return 
    "Data de Vacina: " + this.dataVacinacao + "\n" +
    "Local: " + this.local + "\n" +
    "Aplicação por: "+ this.aplicacaoFuncionario + "\n" ;
  }

  public void buscarDadosPaciente (){}

  public void buscarDadosFuncionario (){}

}