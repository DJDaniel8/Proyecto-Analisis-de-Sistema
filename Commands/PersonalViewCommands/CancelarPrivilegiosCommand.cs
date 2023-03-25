﻿using Proyecto_Analisis_de_Sistema.ViewModels.PersonalViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Analisis_de_Sistema.Commands.PersonalViewCommands
{
    public class CancelarPrivilegiosCommand : CommandBase
    {
        private PrivilegiosPersonalViewModel _viewModel;

        public CancelarPrivilegiosCommand(PrivilegiosPersonalViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object? parameter)
        {
            _viewModel.ViewModelPadre.PersonalInformacionVisibility = System.Windows.Visibility.Visible;
            _viewModel.ControlVisibility = System.Windows.Visibility.Collapsed;
        }
    }
}
