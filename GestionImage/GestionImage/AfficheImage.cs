using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data;
using System.IO;//bibliotheque contenant le memoryystream
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionImage
{
    public partial class AfficheImage : Form
    {
        public AfficheImage()
        {
            InitializeComponent();
        }

        private void AfficheImage_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\GestionImage\GestionImage\Imagedb.mdf;Integrated Security=True"))
            {
                cn.Open();
                using (SqlCommand command = new SqlCommand("SELECT *  FROM [Table] ORDER BY Id DESC", cn))
                {
                    // DataTable dt = new DataTable();
                    //SqlDataAdapter da = new SqlDataAdapter(command);
                    //da.Fill(dt);
                    //dataGridView1.DataSource = dt;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            byte[] imageData = (byte[])reader["image"];
                            dgvInfoImage.Rows.Add(reader.GetValue(0), reader.GetValue(1), imageData);
                        }
                        if (reader.Read())
                        {
                            byte[] imageData = (byte[])reader["image"];
                            //dgvInfoImage.Rows.Add(reader.GetValue(0), reader.GetValue(1), imageData);
                            using (MemoryStream stream = new MemoryStream(imageData))
                            {
                                Image image = Image.FromStream(stream);
                                pictureBox1.Image = image;
                                txtAfficheNom.Text = reader["nom"].ToString();
                            }
                        }
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Csharp avance\Multicouche TI-PAM2\GestionImage\GestionImage\Imagedb.mdf;Integrated Security=True"))
            {
                cn.Open();
                using (SqlCommand command = new SqlCommand("SELECT TOP 1 nom,image FROM [Table] ORDER BY Id DESC", cn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            byte[] imageData = (byte[])reader["image"];
                            using (MemoryStream stream = new MemoryStream(imageData))
                            {
                                Image image = Image.FromStream(stream);
                                pictureBox1.Image = image;
                                txtAfficheNom.Text = reader["nom"].ToString();
                            }
                        }
                    }

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAfficheNom.Text=dgvInfoImage.CurrentRow.Cells[1].Value.ToString();
            byte[] imageData = (byte[])dgvInfoImage.CurrentRow.Cells[2].Value;
            using (MemoryStream stream = new MemoryStream(imageData))
            {
                Image image = Image.FromStream(stream);
                pictureBox1.Image = image;

                //txtAfficheNom.Text = reader["nom"].ToString();
            }
            //pictureBox1.Image = (Image)dataGridView1.CurrentRow.Cells[2].Value;

        }
    }
}
