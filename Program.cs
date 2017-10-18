using System;

namespace semana3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           int valor = 0;
           int total = 0;
           System.Console.WriteLine("Digite o número para saber a tabuada: ");
             //valor = Int16.Parse(Console.ReadLine());            
            //valor = Convert.ToInt16(Console.ReadLine());           
            valor= Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i< 10; i++)
            {
                total = valor * i;
                System.Console.WriteLine(valor + "x" + i + "=" + total);
            }
             */

             /*ARRAY  array declarado inplicito e com objeto new
            string[] nome = {"Sandro","Bete"};
            string[] nome1 = new string [10];
            */

            /*
            string[] alunos = {"Sandro","Paulo","Bete","Francisco","Aline","Paulo"};
            for (int i = 0; i <alunos.Length; i++)
            {
                System.Console.WriteLine("Nome: " + alunos[i]);
            } 
             /*     
             int[] alunos = {2,3,4,5};
             System.Console.WriteLine("Digite um número: ");
             int valor = Convert.ToInt16(Console.ReadLine());

             for (int i = 0; i < alunos.Length; i++)
             {
                 if (valor == alunos[i])
                 {
                     Console.WriteLine("Encontrou na posição: " + i);
                     break;
                 }
             }
             */

             /* string é um array de caractere veja: */
             /*
             string nome = "Sandro";
             for (int i = 0; i <nome.Length; i++)
             {
                 System.Console.WriteLine(nome[i]);
             } 
             */          

             /*
             string[] nomes = {"Sandro","Rosana","Harian","Vitor"};
             foreach (string nome in nomes)
             {
                 System.Console.WriteLine(nome);
             }
             int[] num = {9,8,7,6,5,4,3,2,1};
             foreach(int valor in num)
             {
                Console.WriteLine(valor);
             }

              */
              /* ARRAY MATRIZ */
              /*
              string[,] dados = {
               {"Nome", "Idade"},
               {"Sandro", "23"},
               {"Rosana", "45"}
               };
              System.Console.WriteLine("Posição 1 coluna 0: " + dados[1,0]);
        */
            
            /*
            string[,] nomes = {
                {"Carlos", "21"},
                {"Endereço", "Rua Divina"},
                {"Telefone", "123456"}            
                };
            System.Console.WriteLine("posição 1 coluna 1: " + nomes[1,1]);
            */

            /*
             string[,] dados = {
               {"Nome", "Idade"},
               {"Sandro", "23"},
               {"Rosana", "45"}
               };
              
              for (int l = 0; l <= 2; l ++){
                  for (int c = 0; c <=1; c++){
                      System.Console.WriteLine("Dados: " + dados[l,c]);
                  }                  
              }
              Console.ReadKey();            
               /* 
               string[,]aluno = {
                {"Sandro", "8"},
                {"Rosana", "7"},
                {"Padro", "5"}
               };
               for (int i = 0; i <=2; i++){
                   for (int j = 0; j < 2; j++){
                       System.Console.WriteLine("Aluno: ",aluno[i,j]);
                    }
                }                              
                */
                /*
            bool encontrou = false;
            string[,] dados = {
                {"Nome", "Idade"},
                {"Sandro", "45"},
                {"Ligia", "23"}
            };
                Console.WriteLine("Digite seu nome: ");
                string nome = Console.ReadLine();
                for (int i = 0; i <=2 ; i++){
                    for (int j = 0; j <=1 ; j++){
                        if(nome == dados[i,j]){
                            //encontrou = true;
                            System.Console.WriteLine("Seu nome" + dados[1,0] + " e sua idade é " + dados[1,0] );
                        }
                    }
                }        
                */
        }
    }
}
