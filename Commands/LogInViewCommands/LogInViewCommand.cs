using Proyecto_Analisis_de_Sistema.Services.DAO;
using Proyecto_Analisis_de_Sistema.ViewModels;
using Proyecto_Analisis_de_Sistema.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Proyecto_Analisis_de_Sistema.Commands.LogInViewCommands
{
    public class LogInCommand : CommandBase
    {
        private LogInViewModel ViewModel;

        public LogInCommand(LogInViewModel viewModel)
        {
            ViewModel = viewModel;
            ViewModel.PropertyChanged += ViewModel_PropertyChanged;
        }

        private void ViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(LogInViewModel.Usuario) ||
                e.PropertyName == nameof(LogInViewModel.Contraseña)) OnCanExecutedChanged();
        }

        public override bool CanExecute(object? parameter)
        {
            return (!String.IsNullOrEmpty(ViewModel.Usuario)) &&
                    (!String.IsNullOrEmpty(ViewModel.Contraseña)) &&
                    base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            if (TrabajadorDAO.RequestAccess(ViewModel.Usuario, ViewModel.Contraseña))
            {
                Models.CurrentEmploye.Trabajador = TrabajadorDAO.GetEmployeByUser(ViewModel.Usuario);
                Models.CurrentEmploye.PrivilegiosTrabajador = TrabajadorDAO.GetPrivilegios(Models.CurrentEmploye.Trabajador.Id);
                Models.PrivilegiosToVisibility.LoadFromPrivilegios();
                HomeView nuevaVentana = new();
                nuevaVentana.Show();
                if (parameter != null) ((Window)parameter).Close();
            }
            else MessageBox.Show("Credenciales Incorrectas Por Favor Ingrese unas Credenciales correctas");
        }
    }
}
