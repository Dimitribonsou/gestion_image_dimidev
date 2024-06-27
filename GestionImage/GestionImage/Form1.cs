using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;//bibliotheque permettant de gerer les images 
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionImage
{
    public partial class Form1 : Form
    {
        OpenFileDialog op = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            op.Title = "Choisissez une Image";
            op.Filter = " Image jpg (*.jpg) |*.jpg|image png (*.png)|*.png";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImage.Image = Image.FromFile(op.FileName);
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(@" Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\GestionImage\GestionImage\Imagedb.mdf;Integrated Security=True"))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(" INSERT INTO [Table] (nom ,image) VALUES(@nom,@image)", cn);
                    using (MemoryStream stream = new MemoryStream())
                    {
                        Image image = Image.FromFile(op.FileName);
                        image.Save(stream, ImageFormat.Jpeg);
                        byte[] imageData = stream.ToArray();
                        cmd.Parameters.AddWithValue("@nom", txtNom.Text);
                        cmd.Parameters.AddWithValue("@image", imageData);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Image bien enregistrer");

                    }



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }
       

        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            AfficheImage af = new AfficheImage();
            af.Show();
            this.Hide();
        }
    }
}
