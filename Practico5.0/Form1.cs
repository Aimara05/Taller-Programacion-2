using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico5._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:";
            openFileDialog1.Filter = "Archivos Imagenes|*.jpg;*.png|Todos los archivos|*.*";
            openFileDialog1.ShowDialog();

            if (!string.IsNullOrWhiteSpace(openFileDialog1.FileName))
            {
                pictureBox2.ImageLocation = openFileDialog1.FileName;

                //funciones para ajustar el tamaño de la imagen en el picturebox.
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

                TFoto.Text = Path.GetFileName(openFileDialog1.FileName);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {

                string input = textBox1.Text;
                string formatoNombre = char.ToUpper(input[0]) + input.Substring(1).ToLower();
                textBox1.Text = formatoNombre;


                // coloca el cursor al final del texto.
                textBox1.SelectionStart = formatoNombre.Length;
                textBox1.SelectionLength = 0;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty (textBox2.Text))
            {
                string input = textBox2.Text;
                string formatoApellido = char.ToUpper(input[0]) + input.Substring(1).ToLower();
                textBox2.Text = formatoApellido;


                // colocar el cursor al final del texto.
                textBox2.SelectionStart = formatoApellido.Length;
                textBox2.SelectionLength = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Validación de los radio buttons
            if (!RBMujer.Checked && !RBHombre.Checked)
            {
                MessageBox.Show("Debe seleccionar un género", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si no se ha seleccionado un género
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(TFoto.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si algún campo está vacío
            }

            // se agrega una nueva fila
            int n = dataGridView1.Rows.Add();

                // se coloca la información
                dataGridView1.Rows[n].Cells[0].Value = textBox2.Text;
                dataGridView1.Rows[n].Cells[1].Value = textBox1.Text;
                dataGridView1.Rows[n].Cells[2].Value = dateTimePicker1.Text;

                if (RBMujer.Checked)
                {
                    dataGridView1.Rows[n].Cells[3].Value = "Mujer";
                }
                else
                {
                    dataGridView1.Rows[n].Cells[3].Value = "Hombre";
                }

                //creacion y asignacion del boton eliminar.

                DataGridViewButtonCell deleteButtonCell = new DataGridViewButtonCell();
                deleteButtonCell.Value = "Eliminar";
                dataGridView1.Rows[n].Cells[4] = deleteButtonCell;

                dataGridView1.Rows[n].Cells[5].Value = textBox3.Text;

                // Redimensionar la imagen a una versión en miniatura
                if (pictureBox2.Image != null)
                {
                    int thumbnailWidth = 80; // Ancho de la miniatura
                    int thumbnailHeight = 80; // Altura de la miniatura

                    // Crear una versión en miniatura de la imagen
                    Image thumbnail = pictureBox2.Image.GetThumbnailImage(thumbnailWidth, thumbnailHeight, null, IntPtr.Zero);

                    // Crear una instancia de DataGridViewImageCell
                    DataGridViewImageCell imageCell = new DataGridViewImageCell();

                    // Asignar la imagen en miniatura a la celda de imagen
                    imageCell.Value = thumbnail;

                    // Asignar la celda de imagen a la celda correspondiente en la fila
                    dataGridView1.Rows[n].Cells[6] = imageCell;
                }

                dataGridView1.Rows[n].Cells[7].Value = TFoto.Text;

                //codigo para cambiar el color en caso de que el saldo sea menor a 50, punto 8 del practico 5.
                decimal saldo;
                if (decimal.TryParse(textBox3.Text, out saldo))
                {
                    if (saldo < 50)
                    {
                        dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.Red;
                    }
                }

                //limpiamos los textbox
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                dateTimePicker1.ResetText();
                TFoto.Clear();

                string rutaImagen = "C:\\Users\\Usuario\\source\\repos\\Practico5.0\\Resources\\456212.png";
                pictureBox2.Image = Image.FromFile(rutaImagen);

                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoResizeRows();


            



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4 && e.RowIndex >= 0) 
            {
                if(MessageBox.Show("¿Estás seguro que deseas eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.RowIndex >= 0 && (e.ColumnIndex == 0 || e.ColumnIndex == 1)) 
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

       

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }

}
