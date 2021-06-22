using System;

namespace sistemaVacina
{
    class Program
    {
        static void Main(string[] args)
        {

           Vacina vacina = new Vacina();
           
           Console.WriteLine("Cadastrar vacina? 1-Sim, 0-Não ");
           int adicionar = int.Parse(Console.ReadLine());


           while(adicionar == 1){

            string cod_vacina  = System.Guid.NewGuid().ToString();
               
            Console.WriteLine("Informe o nome da vacina: ");
            string nome_vacina = Console.ReadLine();
           
            Console.WriteLine("Informe o tipo da vacina: ");
            string tipo_vacina = Console.ReadLine();
           
            Console.WriteLine("{0:MM/dd/yyyy} Informe a data de validade da vacina: ");
            string data_vacina = Console.ReadLine();
           
            Console.WriteLine("Informe a temperatura de amarzenamento: ");
            int armazenamento_vacina = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Informe a temperatura de Descongelamento: ");
            int descongelamento_vacina = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Possui efeitos colaterais ? : ");
            string efeitos_vacina = Console.ReadLine();
           
            Console.WriteLine("Possui reações alérgicas ? : ");
            string reacoes_vacina = Console.ReadLine();
           
            vacina.setCodig(cod_vacina);
            vacina.setNomeVacina(nome_vacina);
            vacina.setTipoVacina(tipo_vacina);
            vacina.setDataValidade(data_vacina);
            vacina.setTempArmazenamento(armazenamento_vacina);
            vacina.setTempDescongelamento(descongelamento_vacina);
            vacina.setEfeitosColaterais(efeitos_vacina);
            vacina.setReacoesAlergicas(reacoes_vacina);
           
            vacina.addVacina();

            Console.WriteLine("Cadastrar vacina? 1-Sim, 0-Não ");
            adicionar = int.Parse(Console.ReadLine());
          

           }

            vacina.exibirListaVacinas();
  
        }
    }
}
