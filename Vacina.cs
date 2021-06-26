using System.Collections.Generic;

using System;

[Serializable]
class Vacina {

  public Vacina(){}

  public string codigo { get; set; }

  public string nomeVacina { get; set; }

   public string tipoVacina { get; set; }

  public DateTime dataValidade { get; set; }

  public int temperaturaAmarzenamento { get; set; }

  public int temperaturaDescongelamento { get; set; }


  public string efeitosColaterais { get; set; }

  public string reacoesAlergicas { get; set; }

  public int quantidade {get; set;}

  public int mes {get; set;}

  public int ano {get; set;}


  public override string ToString(){
    return 
    "Codigo: " + this.codigo + "\n" +
    "Nome: " + this.nomeVacina + "\n" +
    "Tipo: "+ this.tipoVacina + "\n" +
    "Data de Validade: " + this.dataValidade + "\n" +
    "Temperatura de Armazenamento: " + this.temperaturaAmarzenamento + "\n" +
    "Temperatura de descongelamento: " + this.temperaturaDescongelamento + "\n" +
    "Tem efeitos colaterais: " + this.efeitosColaterais + "\n" +
    "Reações Alergicas: " + this.reacoesAlergicas + "\n" +
    "Quantidades: " +  this.quantidade + "\n" +
    "Mes de Cadastro" + this.mes + "\n" +
    "Ano de Cadastro" + this.ano;
  }


}