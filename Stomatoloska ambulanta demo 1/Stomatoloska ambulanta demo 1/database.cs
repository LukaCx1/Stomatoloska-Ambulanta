using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stomatoloska_ambulanta_demo_1
{
    public class Database
    {

        private static SqlConnection veza = null;

        public static SqlConnection Veza
        {
            get
            {
                if (veza == null)
                {
                    veza = new SqlConnection(@"Data Source=DESKTOP-GB1ETEB\SQLEXPRESS;Initial Catalog=database_name;Integrated Security=True");
                }
                return veza;
            }

        }
        public bool Login(string email, string jmbg)
        {
           
                // otvara se veza sa db
                Veza.Open();

                // komanda za odabir email i jmbg iz db
                using (SqlCommand command = new SqlCommand("SELECT * FROM zaposleni WHERE jmbg = @jmbg AND email = @email", Veza))
                {
                    
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@jmbg", jmbg);

                    
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        
                        if (reader.HasRows)
                        {
                            return true;
                        }
                    }
                }
            

            
            return false;
        }
    }
}