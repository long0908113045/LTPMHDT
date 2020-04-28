using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanQuyen.Model
{
    class loaiNguoiDung_Quyen
    {
        MyDB mydb = new MyDB();
        public int loaiNguoiDung_id { get; set; }
        public int quyen_id { get; set; }
        public bool insert()
        {
            SqlCommand command = new SqlCommand("insert into loaiNguoiDung_Quyen (loaiNguoiDung_id,quyen_id)" + " values (@loaiNguoiDung_id,@quyen_id)", mydb.Connection);
            command.Parameters.Add("@loaiNguoiDung_id", SqlDbType.Int).Value = loaiNguoiDung_id;
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
        public DataTable ShowtableLoaiNguoiDung_Quyen()
        {
            SqlCommand command = new SqlCommand("select * from loaiNguoiDung_Quyen", mydb.Connection);
            DataTable table = new DataTable();
            SqlDataAdapter Apter = new SqlDataAdapter(command);
            Apter.Fill(table);
            return table;
        }
    }
}
