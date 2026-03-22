using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektMagazyn
{
    public class DatabaseConnection
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MagazynDB;Integrated Security=True";
        public void display_table_users(DataGridView dvg_user_list, string query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Brak wyników.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dvg_user_list.DataSource = null;
                    }
                    else
                    {
                        dvg_user_list.DataSource = dt;

                        if (dvg_user_list.Columns["UzytkownikID"] != null)
                        {
                            dvg_user_list.Columns["UzytkownikID"].Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd połączenia z bazą: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void display_matched_users(DataGridView dvg_user_list, string query, string match)
        {
            
        }
    }
}
