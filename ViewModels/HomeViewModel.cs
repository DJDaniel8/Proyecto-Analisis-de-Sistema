using Proyecto_Analisis_de_Sistema.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using Proyecto_Analisis_de_Sistema.Views.VentasViews;
using Proyecto_Analisis_de_Sistema.Views.ProductosViews;
using Proyecto_Analisis_de_Sistema.Views.StocksViews;
using Proyecto_Analisis_de_Sistema.Views.FacturasViews;
using Proyecto_Analisis_de_Sistema.Views.PersonalViews;
using Proyecto_Analisis_de_Sistema.Views.UtilidadesViews;
using Proyecto_Analisis_de_Sistema.Views.ProveedoresViews;
using Proyecto_Analisis_de_Sistema.Views.IngresosViews;

namespace Proyecto_Analisis_de_Sistema.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public HomeViewModel()
        {
            CloseCommand = new CloseCommand();
            MinimizeCommand = new MinimizeCommand();
            MaximizeCommand = new MaximizeCommand();
            RestoreCommand = new RestoreCommand();
            //LogOutCommand = new LogOutCommand();
            VentaCommand = new CreateWindowCommand(() =>
            {
                VentaView nuevaVentana = new VentaView();
                nuevaVentana.Show();
            });
            //CotizacionCommand = new CreateWindowCommand(() =>
            //{
            //    CotizacionView nuevaVentana = new CotizacionView();
            //    nuevaVentana.Show();
            //});
            ProductosCommand = new CreateWindowCommand(() =>
            {
                ProductosView nuevaVenta = new ProductosView();
                nuevaVenta.Show();
            });

            StocksCommand = new CreateWindowCommand(() =>
            {
                StocksView nuevaVentana = new StocksView();
                nuevaVentana.Show();
            });
            FacturasCommand = new CreateWindowCommand(() =>
            {
                FacturasView nuevaVentana = new();
                nuevaVentana.Show();
            });
            PersonalCommand = new CreateWindowCommand(() =>
            {
                PersonalView nuevaVentana = new PersonalView();
                nuevaVentana.Show();
            });
            //ClientesCommand = new CreateWindowCommand(() =>
            //{
            //    ClientesView nuevaVentana = new ClientesView();
            //    nuevaVentana.Show();
            //});
            //CategoriaCommand = new CreateWindowCommand(() =>
            //{
            //    CategoriasView nuevaVentana = new CategoriasView();
            //    nuevaVentana.Show();
            //});
            ProveedoresCommand = new CreateWindowCommand(() =>
            {
                ProveedoresView nuevaVentana = new ProveedoresView();
                nuevaVentana.Show();
            });
            IngresosCommand = new CreateWindowCommand(() =>
            {
                IngresosView nuevaVentana = new IngresosView();
                nuevaVentana.Show();
            });
            UtilidadesCommand = new CreateWindowCommand(() =>
            {
                UtilidadesView nuevaVentana = new();
                nuevaVentana.Show();
            });
            //CajaCommand = new CreateWindowCommand(() =>
            //{
            //    CajaView nuevaVentana = new CajaView();
            //    nuevaVentana.Show();
            //});
            //ContabilidadCommand = new CreateWindowCommand(() =>
            //{
            //    ContabilidadView nuevaVentana = new ContabilidadView();
            //    nuevaVentana.Show();
            //});
            //PagosCommand = new CreateWindowCommand(() =>
            //{
            //    PagosView nuevaVentana = new PagosView();
            //    nuevaVentana.Show();
            //});
            //GastosCommand = new CreateWindowCommand(() =>
            //{
            //    GastosView nuevaVentana = new GastosView();
            //    nuevaVentana.Show();
            //});
            //InformacionIngresosCommand = new CreateWindowCommand(() =>
            //{
            //    InformacionIngresosView nuevaVentana = new InformacionIngresosView();
            //    nuevaVentana.Show();
            //});
            //DepositosInternosCommand = new CreateWindowCommand(() =>
            //{
            //    DepositosInternosView nuevaVentana = new DepositosInternosView();
            //    nuevaVentana.Show();
            //});
            //InyeccionCapitalCommand = new CreateWindowCommand(() =>
            //{
            //    InyeccionCapitalView nuevaVentana = new InyeccionCapitalView();
            //    nuevaVentana.Show();
            //});
            //ConfiguracionesCommand = new CreateWindowCommand(() =>
            //{
            //    ConfiguracionesView nuevaVentana = new ConfiguracionesView();
            //    nuevaVentana.Show();
            //});

            RestoreVisibility = Visibility.Collapsed;
        }

        public ICommand CloseCommand { get; }
        public ICommand MinimizeCommand { get; }
        public ICommand MaximizeCommand { get; }
        public ICommand RestoreCommand { get; }
        public ICommand LogOutCommand { get; }
        public ICommand VentaCommand { get; }
        public ICommand CotizacionCommand { get; }
        public ICommand ProductosCommand { get; }
        public ICommand StocksCommand { get; }
        public ICommand FacturasCommand { get; }
        public ICommand PersonalCommand { get; }
        public ICommand ClientesCommand { get; }
        public ICommand CategoriaCommand { get; }
        public ICommand ProveedoresCommand { get; }
        public ICommand IngresosCommand { get; }
        public ICommand UtilidadesCommand { get; }
        public ICommand CajaCommand { get; }
        public ICommand ContabilidadCommand { get; }
        public ICommand PagosCommand { get; }
        public ICommand GastosCommand { get; }
        public ICommand InformacionIngresosCommand { get; }
        public ICommand DepositosInternosCommand { get; }
        public ICommand InyeccionCapitalCommand { get; }
        public ICommand ConfiguracionesCommand { get; }



        private Visibility _maximizeVisibility = Visibility.Visible;

        public Visibility MaximizeVisibility
        {
            get { return _maximizeVisibility; }
            set
            {
                _maximizeVisibility = value;
                OnPropertyChanged(nameof(MaximizeVisibility));
            }
        }

        private Visibility _restoreVisibility;

        public Visibility RestoreVisibility
        {
            get { return _restoreVisibility; }
            set
            {
                _restoreVisibility = value;
                OnPropertyChanged(nameof(RestoreVisibility));
            }
        }

        private WindowState _windowState;

        public WindowState StateOfWindow
        {
            get { return _windowState; }
            set
            {
                _windowState = value;
                OnPropertyChanged(nameof(StateOfWindow));
                if (WindowState.Maximized == _windowState)
                {
                    MaximizeVisibility = Visibility.Collapsed;
                    RestoreVisibility = Visibility.Visible;
                }
                else if (WindowState.Normal == _windowState)
                {
                    MaximizeVisibility = Visibility.Visible;
                    RestoreVisibility = Visibility.Collapsed;
                }
            }
        }
    }
}
