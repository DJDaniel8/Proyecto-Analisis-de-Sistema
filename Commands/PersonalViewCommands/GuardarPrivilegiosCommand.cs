using Proyecto_Analisis_de_Sistema.Services.DAO;
using Proyecto_Analisis_de_Sistema.ViewModels.PersonalViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Analisis_de_Sistema.Commands.PersonalViewCommands
{
    public class GuardarPrivilegiosCommand : CommandBase
    {
        private PrivilegiosPersonalViewModel _viewModel;

        public GuardarPrivilegiosCommand(PrivilegiosPersonalViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object? parameter)
        {
            TrabajadorDAO.UpdatePrivilegios(_viewModel.Trabajador.trabajador.Id, _viewModel);
            _viewModel.ViewModelPadre.PersonalInformacionVisibility = System.Windows.Visibility.Visible;
            _viewModel.ControlVisibility = System.Windows.Visibility.Collapsed;
        }
    }
}
