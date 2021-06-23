
using System;
class Funcionario {

  public Funcionario(){}
  private string codigo_funcionario;
  private string crm;
  private string crb;
   private string certificado_digital;
  private string email;
  private string telefone;

  private string instituicoes_trabalhadas;

  public Funcionario(string cod, string reg, string doc, string cert, string mail, string tel, string inst){
    codigo_funcionario = cod;
    crm= reg;
    crb=doc;
    certificado_digital=cert;
    email = mail;
    telefone = tel;
    instituicoes_trabalhadas = inst;
  }
  
  public void setCodigoFuncionario(string cod){
    codigo_funcionario = cod;
  }
  
  public string getCodigoFuncionario(){ 
    return codigo_funcionario;
  }


  public void setCRM(string reg){
   crm= reg;
  }
  
  public string setCRM(){ 
    return crm;
  }


  public void setCRB(string doc){
   crb= doc;
  }
  
  public string getCRB(){ 
    return crb;
  }

  public void setCertificado(string cert){
   certificado_digital = cert;
  }
  
  public string getCertificado(){ 
    return certificado_digital;
  }


  public void setEmail(string mail){
   email = mail;
  }
  
  public string getEmail(){ 
    return email;
  }

   public void setTelefone(string tel){
     telefone = tel;
  }
  
  public string getTelefone(){ 
    return telefone;
  }

  public void setInstituicoes(string inst){
     instituicoes_trabalhadas = inst;
  }
  
  public string getInstituicoes(){ 
    return instituicoes_trabalhadas;
  }

}