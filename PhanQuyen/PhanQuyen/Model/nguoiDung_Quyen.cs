using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanQuyen.Model
{
    class nguoiDung_Quyen
    {
        MyDB mydb = new MyDB();
        public int nguoiDung_id { get; set; }
        public int quyen_id { get; set; }
        public bool insert()
        {
            SqlCommand command = new SqlCommand("insert into nguoiDung_Quyen (nguoiDung_id,quyen_id)" + " values (@nguoiDung_id,@quyen_id)", mydb.Connection);
            command.Parameters.Add("@nguoiDung_id", SqlDbType.Int).Value = nguoiDung_id;
            command.Parameters.Add("@quyen_id", SqlDbType.Int).Value = quyen_id;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool update()
        {
            SqlCommand command = new SqlCommand("update nguoiDung_Quyen set nguoiDung_id=@nguoiDung_id,quyen_id=@quyen_id Where quyen_id = @quyen_id and nguoiDung_id = @nguoiDung_id ", mydb.Connection);
            command.Parameters.Add("@nguoiDung_id", SqlDbType.Int).Value = nguoiDung_id;
            command.Parameters.Add("@quyen_id", SqlDbType.Int).Value = quyen_id;

            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool delete()
        {
            SqlCommand command = new SqlCommand("delete from nguoiDung_Quyen Where nguoiDung_id = @nguoiDung_id and quyen_id = @quyen_id ", mydb.Connection);
            command.Parameters.Add("@quyen_id", SqlDbType.Int).Value = quyen_id;
            command.Parameters.Add("@nguoiDung_id", SqlDbType.Int).Value = nguoiDung_id;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public DataTable ShowtableNguoiDung_Quyen()
        {
            SqlCommand command = new SqlCommand("select * from NguoiDung_Quyen", mydb.Connection);
            DataTable table = new DataTable();
            SqlDataAdapter Apter = new SqlDataAdapter(command);
            Apter.Fill(table);
            return table;
        }
        
    }
}
