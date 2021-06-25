
using System;
class Funcionario {

  public Funcionario(){}

  public string codigo_funcionario { get; set; }

  public string crm { get; set; }

  public string crb { get; set; }

  public string certificado_digita { get; set; }

  public string email { get; set; }

  public string telefone { get; set; }

  public string instituicoes_trabalhadas { get; set; }


    public override string ToString(){
    return 
    "Codigo funcionário: " + this.codigo_funcionario + "\n" +
    "CRM: " + this.crm + "\n" +
    "CRB: "+ this.crb + "\n" +
    "Certificado Digital: " + this.certificado_digita + "\n" +
    "Telefone: " + this.telefone + "\n" +
    "E-mail: " + this.email + "\n" +
    "Instituições trabalhada: " + this.instituicoes_trabalhadas + "\n";
    
  }

}