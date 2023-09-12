using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDelegados
{
    public delegate void Imprimir(string valor);
    internal class EjemploDelegado
    {
        public void ImprimirEnPantalla(string valorDeEntrada) {
            Console.WriteLine(valorDeEntrada);
        }
        public void DelegadoEjemplo()
        {
            Imprimir imprimirDelegado = new Imprimir(ImprimirEnPantalla);
            imprimirDelegado("Texto a Imprimir");
        }

        public void EjemploAction() {
            Action<string> actionEjemplo = ImprimirEnPantalla;
            actionEjemplo("Action a imprimir");
        }

        public void EjemploFunc()
        {
            //Func<int, string> delegadoFunc = v => $"El valor es {v}";
            Func<int, string> delegadoFunc = DevuelveString;
            Console.WriteLine(delegadoFunc(3));
        }

        public string DevuelveString(int v)
        {
            return $"El valor es {v}";
        }

        public void EjemploPredicate()
        {
            Predicate<int> delegadoPred = v => v > 18;
            Console.WriteLine(delegadoPred(20));
        }
    }
    internal class ClaseDePrueba
    {
        public void ClaseParaProbarDelegado(Action<string> a) {
            a("Texto a Imprimir desde otra clase");
        }
    }
}
