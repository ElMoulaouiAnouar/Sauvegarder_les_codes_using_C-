using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RappeleCoderByElMouLaoui
{
   public class Cls_Code
    {
       //methode read data
        public DataTable getCode(int id, string nom)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("id", SqlDbType.Int);
            para[0].Value = id;
            para[1] = new SqlParameter("nom_code", SqlDbType.VarChar, 50);
            para[1].Value = nom;
            return new DataAccessLayer().ReadData("getcode", para);
        }

       //methode set linfromation to database
        public void SetCode(int id, string nom, string code)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("id", SqlDbType.Int);
            para[0].Value = id;
            para[1] = new SqlParameter("nom_code", SqlDbType.VarChar, 50);
            para[1].Value = nom;
            para[2] = new SqlParameter("@txt_code", SqlDbType.VarChar);
            para[2].Value = code;
            DataAccessLayer d = new DataAccessLayer();
            d.SetData("setcode", para);
        }

       //methode charge combobox name code from database
        public DataTable chargecomboboxNameCode(int id)
        {
            SqlParameter[] p=new SqlParameter[1];
             p[0]= new SqlParameter("id", SqlDbType.Int);
             p[0].Value = id;
             return new DataAccessLayer().ReadData("getNomCode", p);
        }

       //method add longage
        public void AddLongage(string nom)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("nomLongage", SqlDbType.VarChar, 50);
            p[0].Value = nom;
           DataAccessLayer d= new DataAccessLayer();
            d.SetData("addlongage", p);
        }

       //remove langage
        public void Remove(string nom)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("nom", SqlDbType.VarChar, 50);
            p[0].Value = nom;
            new DataAccessLayer().SetData("removelongage", p);
        }
        public void Remove(int id,string nom)
        {
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("id", SqlDbType.Int);
            p[0].Value = id;
            p[1] = new SqlParameter("nom", SqlDbType.VarChar, 50);
            p[1].Value = nom;
            new DataAccessLayer().SetData("removecode", p);
        }
    }
}
