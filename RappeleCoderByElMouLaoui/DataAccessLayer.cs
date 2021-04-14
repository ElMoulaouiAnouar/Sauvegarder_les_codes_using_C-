using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace RappeleCoderByElMouLaoui
{
   public class DataAccessLayer
    {
       SqlConnection conx ;
       public DataAccessLayer()
       {
           conx = new SqlConnection("Server=.;DataBase=RappeleCoder;Integrated Security=true"); 
       }

       public void OpenConx()
       {
           if (conx.State == ConnectionState.Closed)
               conx.Open();
       }

       public void CloseConx()
       {
           if (conx.State == ConnectionState.Open)
               conx.Close();
       }

       public DataTable ReadData(string stored_procedure, SqlParameter[] tabpara)
       {
           SqlCommand cmd = new SqlCommand(stored_procedure, conx);
           cmd.CommandType = CommandType.StoredProcedure;
           if (tabpara != null)
               cmd.Parameters.AddRange(tabpara);
           DataTable d = new DataTable();
           SqlDataAdapter data = new SqlDataAdapter(cmd);
           data.Fill(d);
           return d;
       }

       public void SetData(string stored_procedure, SqlParameter[] tabpara)
       {
           SqlCommand cmd = new SqlCommand(stored_procedure, conx);
           cmd.CommandType = CommandType.StoredProcedure;
           if (tabpara != null)
               cmd.Parameters.AddRange(tabpara);
           OpenConx();
           cmd.ExecuteNonQuery();
           CloseConx();
       }


    }
}
