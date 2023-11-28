using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Andmebaas
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=HP-CZC2349HTC;Initial Catalog=Tooded;Integrated Security=True");

        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;
        public Form1()
        {
            InitializeComponent();
            NaitaAndmed();
            NaitaKategooria();
        }
        public void NaitaKategooria()
        {
            connect.Open();
            adapter_kategooria = new SqlDataAdapter("SELECT Kategooria_nimetus FROM Kategooria", connect);
            DataTable dt_kat = new DataTable();
            adapter_kategooria.Fill(dt_kat);
            foreach (DataRow item in dt_kat.Rows)
            {
                Kat_Box.Items.Add(item["Kategooria_nimetus"]);
            }
            connect.Close();
        }
        private void LisaKategooriaButton_Click(object sender, EventArgs e)
        {
            bool on = false;
            foreach (var item in Kat_Box.Items)
            {
                if (item.ToString()==Kat_Box.Text)
                {
                    on = true;
                }
            }
            if (on==false)
            command = new SqlCommand("INSERT INTO Kategooria (Kategooria_nimetus) VALUES (@kat)", connect);
            connect.Open();
            command.Parameters.AddWithValue("@kat", Kat_Box.Text);
            command.ExecuteNonQuery();
            connect.Close();
            Kat_Box.Items.Clear();
            NaitaKategooria();  
        }
        int Id = 0;
        private void LisaToodeButton_Click(object sender, EventArgs e)
        {
            int maxId = GetMaxToodeId();

            SetIdentitySeed(maxId + 0);

            if (Toode_txt.Text.Trim() != string.Empty && Kogus_txt.Text.Trim() != string.Empty && Hind_txt.Text.Trim() != string.Empty && Kat_Box.SelectedItem != null)
            {
                connect.Open();

                command = new SqlCommand("SELECT Id FROM Kategooria WHERE Kategooria_nimetus=@kat", connect);
                command.Parameters.AddWithValue("@kat", Kat_Box.Text);
                Id = Convert.ToInt32(command.ExecuteScalar());

                command = new SqlCommand("INSERT INTO Toode(Toodenimetus, Kogus, Hind, Pilt, Kategooria) VALUES(@toode, @kogus, @hind, @pilt, @kat)", connect);
                command.Parameters.AddWithValue("@toode", Toode_txt.Text);
                command.Parameters.AddWithValue("@kogus", Kogus_txt.Text);
                command.Parameters.AddWithValue("@hind", Hind_txt.Text);
                command.Parameters.AddWithValue("@pilt", Toode_txt.Text + ".jpg");
                command.Parameters.AddWithValue("@kat", Id);
                command.ExecuteNonQuery();

                connect.Close();
                NaitaAndmed();
            }
        }

        private int GetMaxToodeId()
        {
            int maxId = 0;
            using (SqlCommand getMaxIdCommand = new SqlCommand("SELECT MAX(Id) FROM Toode", connect))
            {
                connect.Open();
                object result = getMaxIdCommand.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    maxId = Convert.ToInt32(result);
                }
                connect.Close();
            }
            return maxId;
        }

        private void SetIdentitySeed(int seedValue)
        {
            connect.Open();
            using (SqlCommand setIdentitySeedCommand = new SqlCommand($"DBCC CHECKIDENT ('Toode', RESEED, {seedValue})", connect))
            {
                setIdentitySeedCommand.ExecuteNonQuery();
            }
            connect.Close();
        }

        private void KutsutaToodeButton_Click(object sender, EventArgs e)
        {
            
        }

        private void KutsutaKategooriaButton_Click(object sender, EventArgs e)
        {
            if (Kat_Box.SelectedItem != null)
            {
                connect.Open();
                command = new SqlCommand("DELETE FROM Kategooria WHERE Kategooria_nimetus = @kat", connect);
                command.Parameters.AddWithValue("@kat", Kat_Box.SelectedItem.ToString());
                command.ExecuteNonQuery();
                connect.Close();
                NaitaAndmed();
            }
        }

        public void NaitaAndmed()
        {
            connect.Open();

            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT Toode.Id,Toode.Toodenimetus,Toode.Kogus,Toode.Hind,Toode.Pilt,Kategooria.Kategooria_nimetus FROM Toode INNER JOIN Kategooria on Toode.Kategooria=Kategooria.Id", connect);
            adapter_toode.Fill(dt_toode);
            dataGridView1.DataSource = dt_toode;
            connect.Close();
        }
    }
}   
