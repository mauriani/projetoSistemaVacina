
using System;
using System.Collections.Generic;

class Estoque: Vacina
{

    int temp_atual = - 10;
    
    public void controlarTemperatura(){
        
        int temperatura = temperaturaAmarzenamento;
        
        if(temp_atual != temperatura){
            Console.WriteLine("Ajuste a temperatura de amarzenamento para a que foi indicada no cadastro");
            
        }

   }

   public void verificarEstoque(List<Vacina> lista,string nome_vacina){
       foreach(var element in lista)
       {
           if(element.nomeVacina == nome_vacina){
              Console.WriteLine("Existem " + element.quantidade + " vacinas no estoque.");

           }
        }     
     
   }

   public void verificarFaltas(List<Vacina> lista){

       List<Object> faltas  = new List<Object>();

       foreach(var element in lista)
        {
           if(element.quantidade <= 0){
               Console.WriteLine("A vacina " + element.nomeVacina + "está em falta, faça um novo pedido");

           }
        }    
     
   }

   public void verificarVencidas(List<Vacina> lista){
       DateTime thisDay = DateTime.Today;

       foreach(var element in lista)
       {
           if(element.dataValidade >= thisDay){
              Console.WriteLine("Essa vacina passou do prazo de validade!!");

           }
        } 

   
   }
   
   /*public void verificarRetiradas(){

    }*/
}