using System;
using System.Collections.Generic;

namespace sistemaVacina
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Cadastrar vacina? 1-Sim, 0-Não ");
            int addVacina = int.Parse(Console.ReadLine());

            List<Vacina> listVacinas  = new List<Vacina>();
           

           while(addVacina == 1){

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

            Console.WriteLine("Informe a quantidade ? : ");
            int quant = int.Parse(Console.ReadLine());

            listVacinas.Add( new Vacina () {
                    codigo = cod_vacina, 
                    nomeVacina = nome_vacina, 
                    tipoVacina = tipo_vacina,
                    dataValidade = data_vacina,
                    temperaturaAmarzenamento = armazenamento_vacina,
                    temperaturaDescongelamento = descongelamento_vacina,
                    efeitosColaterais = efeitos_vacina,
                    reacoesAlergicas = reacoes_vacina,
                    quantidade = quant,
                });
           
        
            Console.WriteLine("Cadastrar vacina? 1-Sim, 0-Não ");
            addVacina = int.Parse(Console.ReadLine());
          
           }


            Console.WriteLine("Cadastrar Pacientes? 1-Sim, 0-Não ");
            int addPaciente = int.Parse(Console.ReadLine());

            List<Paciente> listaPacientes  = new List<Paciente>();
           

           while(addPaciente == 1){

            Console.WriteLine("Informe o número do cartão de vacina: ");
            string cartao_vacina = Console.ReadLine();
               
            Console.WriteLine("Informe o nome completo: ");
            string nome_completo = Console.ReadLine();
           
            Console.WriteLine("Informe o cpf do Paciente: ");
            string cpf_paciente = Console.ReadLine();
           
            Console.WriteLine("Informe a idade do paciente: ");
            int idade_paciente = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome da vacina que vai ser aplicada: ");
            string nome_vacina_paciente = Console.ReadLine();

            Console.WriteLine("Informe a dose da vacina: ");
            int dose_vacina_paciente = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o email do paciente: ");
            string email_paciente = Console.ReadLine();

            Console.WriteLine("Informe o número de telefone: ");
            string telefone_paciente = Console.ReadLine();
           
          
            listaPacientes.Add( new Paciente () {
                numeroCartaoVacina = cartao_vacina,
                nome = nome_completo,
                cpf = cpf_paciente,
                idade = idade_paciente,
                vacina = nome_vacina_paciente,
                dose=dose_vacina_paciente,
                email = email_paciente,
                telefone= telefone_paciente

                });
           
        
            Console.WriteLine("Cadastrar Pacientes? 1-Sim, 0-Não ");
            addPaciente = int.Parse(Console.ReadLine());
          
           }
        }
    }
}
