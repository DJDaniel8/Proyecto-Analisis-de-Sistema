using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Proyecto_Analisis_de_Sistema.Commands
{
    public class RestoreCommand : CommandBase
    {
        public override void Execute(object? parameter)
        {
            if (parameter != null)
            {
                SystemCommands.RestoreWindow((Window)parameter);
            }
        }
    }
}
