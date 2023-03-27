using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, RoutedEventArgs e)
        {
            //Obter os valores da caixa de texto
            string valor1 = TextValor1.Text;
            string valor2 = TextValor2.Text;
            string operacaoString = TextOperacao.Text;

            //converter string para int
            int ValorInt1= Converter.ToInt32(valor1);
            int ValorInt2= Converter.ToInt32(valor2);

            if (operacaoString == "+")
            {
                int somaInt = ValorInt1 + ValorInt2;
                string somaFinal = Convert.ToString(somaInt);
                TextResultado.Text = somaFinal;
            }
            else if(operacaoString == "-")
            {
                int subtracaoInt= ValorInt1 - ValorInt2;        
                string subtracaoFinal = Convert.ToString(subtracaoInt);
            }

            else if (operacaoString == "*")
            {
                int multiplicacaoInt = ValorInt1 * ValorInt2 ;
                string multiplicacaoFinal= Convert.ToString(multiplicacaoInt);
                TextResultado.Text= multiplicacaoFinal;
            }

            else if (operacaoString=="/")
            {
                int divisaoInt = ValorInt1 / ValorInt2;
                string divisaoFinal = Convert.ToString(divisaoInt);
                TextResultado.Text =(divisaoFinal); 
            }

            else
            {
                TextResultado.Text = "Operador errado";
            }
        }
    }       
}
