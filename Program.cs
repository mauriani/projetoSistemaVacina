using System;
using System.Collections.Generic;

namespace sistemaVacina
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Cadastrar vacina? 1-Sim, 0-Não ");
            int adicionar = int.Parse(Console.ReadLine());

            List<Vacina> listVacinas  = new List<Vacina>();
           

           while(adicionar == 1){

            string cod_vacina  = System.Guid.NewGuid().ToString();
               
            Console.WriteLine("Informe o nome da vacina: ");
            string nome_vacina = Console.ReadLine();
           
            Console.WriteLine("Informe o tipo da vacina: ");
            string tipo_vacina = Console.ReadLine();
           
            Console.WriteLine("Informe a data de validade da vacina: ");
            DateTime data_vacina = DateTime.Parse(Console.ReadLine());
           
            Console.WriteLine("Informe a temperatura de amarzenamento: ");
            int armazenamento_vacina = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Informe a temperatura de Descongelamento: ");
            int descongelamento_vacina = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Possui efeitos colaterais ? : ");
            string efeitos_vacina = Console.ReadLine();
           
            Console.WriteLine("Possui reações alérgicas ? : ");
            string reacoes_vacina = Console.ReadLine();

            listVacinas.Add( new Vacina () {
                    codigo = cod_vacina, 
                    nomeVacina = nome_vacina, 
                    tipoVacina = tipo_vacina,
                    dataValidade = data_vacina,
                    temperaturaAmarzenamento = armazenamento_vacina,
                    temperaturaDescongelamento = descongelamento_vacina,
                    efeitosColaterais = efeitos_vacina,
                    reacoesAlergicas = reacoes_vacina
                });
           
        
            Console.WriteLine("Cadastrar vacina? 1-Sim, 0-Não ");
            adicionar = int.Parse(Console.ReadLine());
          
           }
        }
    }
}
