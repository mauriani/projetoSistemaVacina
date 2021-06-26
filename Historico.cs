using System;
using System.Collections.Generic;


class Historico: Vacina
{
    System.DateTime moment = new System.DateTime(
                                1999, 1, 13, 3, 57, 32, 11);
    public void maisAplicadasMes(List<Vacina> lista){

        List<String> aplicadasMes  = new List<String>();
        
        int month = moment.Month;
        
        foreach(var element in lista)
        {
          if(month == element.mes){
              aplicadasMes.Add(element.nomeVacina);
          }

        }

        foreach(var item in aplicadasMes){
            if(aplicadasMes.Count > 0){
                Console.WriteLine(item);
            }
        }
    }

    public void maisAplicadasAnualmente(List<Vacina> lista){
        List<String> aplicadasAno = new List<String>();
        
        int year = moment.Year;
        
        foreach(var element in lista)
        {
          if(year == element.ano){
              aplicadasAno.Add(element.nomeVacina);
          }

        }

        foreach(var item in aplicadasAno){
            if(aplicadasAno.Count > 0){
                Console.WriteLine(item);
            }
        }
    }


}