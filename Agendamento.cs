
using System;
class Agendamento: Paciente{

  public Agendamento(){}


  
  string nome_completo;

  public string paciente {get; set;}

  public DateTime dataVacinacao { get; set; }

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