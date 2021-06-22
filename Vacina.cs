
using System;
using System.Collections.Generic;

class Vacina {

  public Vacina(){}
  private string codigo;
  private string nomeVacina;
  private string tipoVacina;
   private string dataValidade;
  private int temperaturaAmarzenamento;
  private int temperaturaDescongelamento;
  private string efeitosColaterais;

  private string reacoesAlergicas;

  List<Vacina> listVacinas;

  public Vacina(string cod, string data, string tipo, string nome, int tempArm, int tempDesc, string efeitos, string alergia){
    codigo = cod;
    nomeVacina = nome;
    tipoVacina = tipo;
    dataValidade = data;
    temperaturaAmarzenamento = tempArm;
    temperaturaDescongelamento = tempDesc;
    efeitosColaterais=efeitos;
    reacoesAlergicas = alergia;
  }

  public void setCodig(string cod){
    codigo =cod;
  }

   public string getCodig(){
    return codigo;
  }


  public void setNomeVacina(string nome){
    nomeVacina = nome;
  }

  public string getNomeVacina(){
    return nomeVacina;
  }

    public void setTipoVacina(string tipo){
    tipoVacina = tipo;
  }

  public string getTipoVacina(){
    return tipoVacina;
  }


  public void setDataValidade(string data){
    dataValidade = data;
  }

  public string getDataValidade(){
    return dataValidade;
  }

  public void setTempArmazenamento(int tempArm){
    temperaturaAmarzenamento = tempArm;
  }

  public int getTempArmazenamento(int tempArm){
    return temperaturaAmarzenamento;
  }

  public void setTempDescongelamento(int tempDesc){
    temperaturaDescongelamento = tempDesc;
  }

  public int getTempDescongelamento(int tempDesc){
    return temperaturaAmarzenamento;
  }


  public void setEfeitosColaterais(string efeitos){
    efeitosColaterais = efeitos;
  }

   public string getEfeitosColaterais(){
     return efeitosColaterais;
  }

  public void setReacoesAlergicas(string alergia){
    reacoesAlergicas = alergia;
  }

  public string getReacoesAlergicas(){
    return reacoesAlergicas;
  }

  public override string ToString(){
    return 
    "Codigo: " + this.codigo + "\n" +
    "Nome: " + this.nomeVacina + "\n" +
    "Tipo: "+ this.tipoVacina + "\n" +
    "Data de Validade: " + this.dataValidade + "\n" +
    "Temperatura de Armazenamento: " + this.temperaturaAmarzenamento + "\n" +
    "Temperatura de descongelamento: " + this.temperaturaDescongelamento + "\n" +
    "Tem efeitos colaterais: " + this.efeitosColaterais + "\n" +
    "Reações Alergicas: " + this.reacoesAlergicas + "\n" ;
  }


  public void addVacina(){

  
    this.listVacinas = new List<Vacina>();

    this.listVacinas.Add(new Vacina() {
      codigo = this.codigo, 
      nomeVacina = this.nomeVacina, 
      tipoVacina = this.tipoVacina, 
      dataValidade = this.dataValidade, 
      temperaturaAmarzenamento = this.temperaturaAmarzenamento, 
      temperaturaDescongelamento= this.temperaturaDescongelamento,
      efeitosColaterais = this.efeitosColaterais, 
      reacoesAlergicas = this.reacoesAlergicas
    });
    
    Console.WriteLine("Number of Items in the List is:" + this.listVacinas.Count);  
    Console.WriteLine("Capacity of the List is:" + this.listVacinas.Capacity); 
   
   }

  public void exibirListaVacinas(){
      //Ordena a lista
    this.listVacinas.Sort();
    
    Console.WriteLine("A lista tem " + this.listVacinas.Count + " itens:");
    //Imprime cada item da lista
    this.listVacinas.ForEach(i => Console.WriteLine(i));
  }

}