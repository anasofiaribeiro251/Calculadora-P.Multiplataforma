using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Aulinha5
{
    /// <summary>
    /// Lógica interna para AdicionarWindow.xaml
    /// </summary>

    //Atributo para guardar a figura escolhida
    public partial class AdicionarWindow : Window
    {
        public string NomeFigura { get; private set; }
        public AdicionarWindow()
        {
            InitializeComponent();
        }

        private void btInserir_click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;

            //Verificar qual radio button está selecionado
            if (RBRetangulo.IsChecked == True)
            {
                NomeFigura = "Retangulo";
            }

            if (RBQuadrado.IsChecked == True)
            {
                NomeFigura = "Quadrado";
            }

            if (RBcirculo.IsChecked == True)
            {
                NomeFigura = "Circulo";
            }

        }
    }
}