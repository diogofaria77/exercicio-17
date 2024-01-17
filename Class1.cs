using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp12
{
    internal class Class1
    {
        public string Nome;
        public string Email;
        public string Password;

        public static List<Class1> listusers = new List<Class1>();
        //construtor: metodo especial dentro de uma clase
        // que é invocado automaticamente quando um objeto 
        //dessa classe é criado.
        //usado para inicializar o objeto atribuir valores iniciais.

        public Class1(string nome, string email, string password)
        {
            Nome = nome;
            Email = email;
            Password = password;
        
         
                                                         
                                                         


        }
      public static void registar (string nome, string email, string password)
        {
            Class1 newutilizador = new Class1 (nome, email, password);
            listusers.Add(newutilizador);
        }


       

    


    }

}
