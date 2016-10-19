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
using Servicios;
using Entidades;
namespace OMB_Desktop.Views
{
    /// <summary>
    /// Interaction logic for BookAddControl.xaml
    /// </summary>
    public partial class BookAddControl : UserControl
    {
        public BookAddControl()
        {
            InitializeComponent();
            List<Editorial> lEditoriales = new List<Editorial>();
            cbEditorial.DataContext = lEditoriales; 
               
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (validar_campos() == true)
            {

                Libro lib = new Libro();
                Editorial edit = new Editorial();
                int id_editorial;
                lib.Titulo = txtTitulo.Text;
                lib.Subtitulo = txtSubtitulo.Text;
                lib.Paginas = Convert.ToInt32(txtpag.Text);
                lib.FechaPublicacion = Convert.ToDateTime(txtFechaPublica.Text);
                id_editorial = (int)cbEditorial.SelectedValue;            
                  

            } 
        }

        public bool validar_campos()
        {
            if(txtISBN.Text == "")
            {
                MessageBox.Show("Debe ingresar el ISBN del Libro.");
                txtISBN.Focus();
                return false;                     

            }

            if (txtTitulo.Text == "" )
            {
                MessageBox.Show("Debe ingresar el Titulo del Libro.");
                txtTitulo.Focus();
                return false;
            }

            if (txtSubtitulo.Text == "")
            {
                MessageBox.Show("Debe ingresar el Subtitulo del Libro.");
                txtSubtitulo.Focus();
                return false;

            }
            if (txtpag.Text == "")
            {
                MessageBox.Show("Debe ingresar el Número de Paginas del Libro.");
                txtpag.Focus();
                return false;
            }

            if (txtFechaPublica.Text == "")
            {
                MessageBox.Show("Debe ingresar la Fecha de Publicación del Libro.");
                txtFechaPublica.Focus();
                return false;
            }
            return true;
        }

    }
}
