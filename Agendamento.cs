
using System;
using System.Collections.Generic;

class Agendamento: Paciente{

  public Agendamento(){}
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

  public void buscarDadosPaciente (List<Paciente> lista, string nome){
    foreach(var element in lista)
       {
           if(element.nome == nome){
              Console.WriteLine(element);

           }
        }  
  }


  public void buscarDadosAgendamento(List<Agendamento> lista, string nome){
    foreach(var element in lista){
      try{
         if(element.paciente == nome){
          Console.Write(
          "Nome Paciente - "+ element.paciente +"\n" + 
          "Data de vacinação - " + element.dataVacinacao + "\n" + 
          "Local - " + element.local + "\n"
          );
      }

      }catch(ArgumentException){
         throw new System.ArgumentException("O nome informado é inválido, informe um nome válido por favor.");
      }
     
    }
  }

   public void verificarDose(List<Paciente> lista, string nome){
     foreach(var element in lista)
       {
           if(element.nome == nome){
             Console.WriteLine("Essa é a dose n° " + element.dose + " do(a) Paciente " + element.nome);

           }
           else {
             throw new System.ArgumentException("O nome informado é inválido, informe um nome válido por favor.");
           }
        }  

  }
}