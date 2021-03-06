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

            List<Agendamento> dadosAgendamento  = new List<Agendamento>();

            Estoque estoque = new Estoque();

            Historico historico = new Historico();

            Agendamento agendamento = new Agendamento();

            Paciente paciente = new Paciente();
           

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

            Console.WriteLine("Informe o MES que esta vacina esta sendo cadastrada ? : ");
            int mes_vacina = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o ANO que esta vacina esta sendo cadastrada ? : ");
            int ano_vacina = int.Parse(Console.ReadLine());



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
                    mes= mes_vacina,
                    ano = ano_vacina
                });

           foreach(var i in listVacinas){
                    Console.WriteLine(i);
            }
                
            // verifica temperatura ideal
            estoque.controlarTemperatura();

    
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
           
           Console.WriteLine("Deseja verificar vencidas ? 1- sim, 0 - não?");
           int vencidas = int.Parse(Console.ReadLine());

           if(vencidas == 1){
            // verificar vencidas
            estoque.verificarVencidas(listVacinas);

           }
           
           Console.WriteLine("Deseja verificar faltas ? 1- sim, 0 - não?");
           int faltas = int.Parse(Console.ReadLine());

           if(faltas == 1){
            // verificar vencidas
            estoque.verificarFaltas(listVacinas);
            
            }

            Console.WriteLine("Deseja verificar as mais aplicadas ? 1- sim, 0 - não?");
           int aplicadas = int.Parse(Console.ReadLine());

            if(aplicadas == 1){
                // historico
                historico.maisAplicadasMes(listVacinas);
            }


            Console.WriteLine("Cadastrar Funcionário? 1-Sim, 0-Não ");
            int addFuncionario = int.Parse(Console.ReadLine());

            List<Funcionario> listaFuncionarios  = new List<Funcionario>();

            List<Paciente> listaPacientes  = new List<Paciente>();
           

           while(addFuncionario == 1){

            string cod_funcionario  = System.Guid.NewGuid().ToString();

            Console.WriteLine("Informe o nome: ");
            string nome_funcionario = Console.ReadLine();
               

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
                nome_funcionario = nome_funcionario,
                crm = crm_funcionario,
                crb = crb_funcionario,
                certificado_digital = certificado,
                telefone= tel_funcionario,
                email = mail_funcionario,
                instituicoes_trabalhadas = inst_trabalhadas,
            
                });

            foreach(var i in listaFuncionarios){
                    Console.WriteLine(i);
                    
            }
        
            Console.WriteLine("Cadastrar Funcionario? 1-Sim, 0-Não ");
            addFuncionario = int.Parse(Console.ReadLine());


           Console.WriteLine("Cadastrar Pacientes? 1-Sim, 0-Não ");
           int addPaciente = int.Parse(Console.ReadLine());
           
           
           

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
            
            Console.WriteLine("Desejar realizar um agendamento 1-Sim ?");
            int agendar = int.Parse(Console.ReadLine());

            if(agendar == 1){

                Console.WriteLine("Informe a data de vacinação: ");
                DateTime data_agendamento = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Informe o local vacinação: ");
                String local_agendamento = Console.ReadLine();

                dadosAgendamento.Add(new Agendamento(){
                    paciente = nome_completo,
                    dataVacinacao = data_agendamento,
                    local = local_agendamento,
                    aplicacaoFuncionario = cod_funcionario,

                });

            }
                foreach(var i in listaPacientes){
                    Console.WriteLine(i);                
                }

                foreach(var i in dadosAgendamento){
                    Console.WriteLine(i);                
                }

                Console.WriteLine("Cadastrar Pacientes? 1-Sim, 0-Não ");
                addPaciente = int.Parse(Console.ReadLine());
            
            }
            
            }

            Console.WriteLine("Deseja pesquisar algum paciente 1- sim 0- Não");
            int pesquisar = int.Parse(Console.ReadLine());
            if(pesquisar == 1){
                Console.WriteLine("Informe o nome do Paciente");
                string pac_name = Console.ReadLine();

                agendamento.buscarDadosPaciente(listaPacientes, pac_name);

                agendamento.buscarDadosAgendamento(dadosAgendamento, pac_name);

                agendamento.verificarDose(listaPacientes, pac_name);


            }
            
           
            
        }
    }
}
