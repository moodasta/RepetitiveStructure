using System;

namespace VerificacaoSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            int senhaCorreta = 2002;

            while (true)
            {
                Console.Write("Digite a senha: ");
                //lendo a entrada do usuário que retorna uma string contendo o valor digitado pelo usuário
                //converte essa string em um valor inteiro.
                int senha = int.Parse(Console.ReadLine());

                if (senha == senhaCorreta)
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }
                else
                {
                    Console.WriteLine("Senha Inválida");
                }
            }
        }
    }
}

