using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    public class Amigos
    {
        public Amigos()
        {

        }


        public Amigos(string nome, string sobrenome, DateTime aniversario)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Aniversario = aniversario;
        }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string NomeCompleto()
        {
            return Nome + " " + Sobrenome;
        }

        public DateTime Aniversario { get; set; }

        public TimeSpan ContagemParaAniversario()
        {
            var proximoAniversario = new DateTime(DateTime.Now.Year, Aniversario.Month, Aniversario.Day);

            if ((proximoAniversario - DateTime.Now).TotalDays < 0)
            {
                proximoAniversario = proximoAniversario.AddYears(1);
            }

            return (proximoAniversario - DateTime.Now);
        }
    }
}
