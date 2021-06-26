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

            Estoque estoque = new Estoque();
           

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
                
                
            // verifica temperatura ideal
            // estoque.controlarTemperatura();
           
    
            Console.WriteLine("Cadastrar vacina? 1-Sim, 0-Não ");
            addVacina = int.Parse(Console.ReadLine());
          
           }
        
           Console.WriteLine("Deseja verificar estoque ? 1- sim, 0 - não?");
          
          int verificar = int.Parse(Console.ReadLine());

           if(verificar == 1){
               
               Console.WriteLine("Informe o nome da vacina a ser pesquisada?");
               string nome = Console.ReadLine();
               estoque.verificarEstoque(listVacinas,nome);

           }

           // verificar faltas
           estoque.verificarFaltas(listVacinas);

           // verificar vencidas
           estoque.verificarVencidas(listVacinas);
           
           
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

             Console.WriteLine("Cadastrar Funcionário? 1-Sim, 0-Não ");
            int addFuncionario = int.Parse(Console.ReadLine());

            List<Funcionario> listaFuncionarios  = new List<Funcionario>();
           

           while(addFuncionario == 1){

            string cod_funcionario  = System.Guid.NewGuid().ToString();

            Console.WriteLine("Informe o crm: ");
            string crm_funcionario = Console.ReadLine();
               
            Console.WriteLine("Informe o crb: ");
            string crb_funcionario = Console.ReadLine();
           
            Console.WriteLine("Informe o certificado digital: ");
            string certificado = Console.ReadLine();
           
            Console.WriteLine("Informe o telfone: ");
            string tel_funcionario = Console.ReadLine();

            Console.WriteLine("Informe o e-mail: ");
            string mail_funcionario = Console.ReadLine();

            Console.WriteLine("Informe a ultima instituição trabalhada: ");
            string inst_trabalhadas = Console.ReadLine();

          
            listaFuncionarios.Add( new Funcionario () {
                codigo_funcionario = cod_funcionario,
                crm = crm_funcionario,
                crb = crb_funcionario,
                certificado_digital = certificado,
                telefone= tel_funcionario,
                email = mail_funcionario,
                instituicoes_trabalhadas = inst_trabalhadas,
            
                });
           
        
            Console.WriteLine("Cadastrar Funcionario? 1-Sim, 0-Não ");
            addFuncionario = int.Parse(Console.ReadLine());
          
           }
        }
    }
}
