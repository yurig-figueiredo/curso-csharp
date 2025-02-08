using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaAluno
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool AprovadoOuReprovado()
        {
            if (NotaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Faltou()
        {
            return (60 - NotaFinal());
        }



    }
}
