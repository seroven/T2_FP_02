using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2_FP_02
{
    public partial class OrderingForm : Form
    {

        public List<int> numbers = new List<int>() { };

        public OrderingForm()
        {
            InitializeComponent();
            G2_Set_Numbers_To_ListBox();
        }

        // Método para setear los numeros en el ListBox
        private void G2_Set_Numbers_To_ListBox()
        {
            G2_Numbers_Lbx.Items.Clear();
            foreach (int number in numbers)
            {
                G2_Numbers_Lbx.Items.Add(number);
            }
        }

        // Método para traer el número y validarlo
        private int G2_Get_Number()
        {
            try
            {
                int number = Int32.Parse(G2_Number_Txt.Text);
                return number;
            } catch(Exception ex)
            {
                MessageBox.Show("El número ingresado no es válido");
                return -1;
            }
        }

        // Evento para agregar un número a la lista
        private void G2_Add_Btn_Click(object sender, EventArgs e)
        {
            int number = G2_Get_Number();
            if (number < 0) return;
            numbers.Add(number);
            G2_Set_Numbers_To_ListBox();
            G2_Number_Txt.Clear();
            MessageBox.Show($"Se ha agregado el número {number}");
        }

        // Evento para buscar un elemento en la lista
        private void G2_Search_Btn_Click(object sender, EventArgs e)
        {
            int number = G2_Get_Number();
            if (number < 0) return;
            G2_Number_Txt.Clear();
            foreach (int n  in numbers)
            {
                if (n == number)
                {
                    MessageBox.Show($"Se ha encontrado el número {number} en la lista");
                    return;
                }
            }
            MessageBox.Show($"No se ha encontrado el número {number}");
        }

        // Evento para eliminar un numero de toda la lista
        private void G2_Delete_Btn_Click(object sender, EventArgs e)
        {
            int number = G2_Get_Number();
            if (number < 0) return;
            G2_Number_Txt.Clear();
            numbers.RemoveAll(n => n == number); // Eliminación de los elementos que son el número pasado por el formulario
            G2_Set_Numbers_To_ListBox();
            MessageBox.Show($"Se ha eliminado el número {number} de la lista");
        }

        // Ordenamiento ascendente usando el método burbuja
        private void G2_Asc_Sort_Btn_Click(object sender, EventArgs e)
        {
            Boolean cent = true;
            int temporal;
            while (cent)
            {
                cent = false;
                for(int i = 0; i < numbers.Count-1; i++)
                {
                    if (numbers[i] > numbers[i+1])
                    {
                        temporal = numbers[i];
                        numbers[i] = numbers[i+1];
                        numbers[i+1] = temporal;
                        cent = true;
                    }
                }
            }
            G2_Set_Numbers_To_ListBox();
        }

        // Ordenamiento ascendente usando el método burbuja
        private void G2_Desc_Sort_Btn_Click(object sender, EventArgs e)
        {
            Boolean cent = true;
            int temporal;
            while (cent)
            {
                cent = false;
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] < numbers[i + 1])
                    {
                        temporal = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temporal;
                        cent = true;
                    }
                }
            }
            G2_Set_Numbers_To_ListBox();
        }
    }
}
