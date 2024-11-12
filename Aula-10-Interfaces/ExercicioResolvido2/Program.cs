using System;
using ExercicioResolvido2.Interfaces;
using ExercicioResolvido2.Services;
namespace ExercicioResolvido2
{
    class Program
    {
        static void Main()
        {
            ILog logDebug = new LogDebug();
            logDebug.Registrar("Operação realizada com sucesso.");

            ILog logErro = new LogErro();
            logErro.Registrar("Ocorreu um erro inesperado.");
        }
}
    }