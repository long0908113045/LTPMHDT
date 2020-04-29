using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanQuyen.Model
{
    
    class loaiNguoiDung
    {
        MyDB mydb = new MyDB();
        public int id { get; set; }
        public string tenLoaiNguoiDung { get; set; }
        public string moTa { get; set; }
        public bool Insert()
        {
            SqlCommand command = new SqlCommand("insert into loaiNguoiDung (tenLoaiNguoiDung,moTa)" + " values (@tenLoaiNguoiDung,@moTa)", mydb.Connection);
            command.Parameters.Add("@tenLoaiNguoiDung", SqlDbType.NVarChar).Value = tenLoaiNguoiDung;
            command.Parameters.Add("@moTa", SqlDbType.NVarChar).Value = moTa;
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
            SqlCommand command = new SqlCommand("update loaiNguoiDung set tenLoaiNguoiDung=@tenLoaiNguoiDung,moTa=@moTa Where id = @id", mydb.Connection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@tenLoaiNguoiDung", SqlDbType.NVarChar).Value = tenLoaiNguoiDung;
            command.Parameters.Add("@moTa", SqlDbType.NVarChar).Value = moTa;
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
            SqlCommand command = new SqlCommand("delete from loaiNguoiDung Where id = @id", mydb.Connection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        public DataTable ShowtableNguoiDung()
        {
            SqlCommand command = new SqlCommand("select * from loaiNguoiDung", mydb.Connection);
            DataTable table = new DataTable();
            SqlDataAdapter Apter = new SqlDataAdapter(command);
            Apter.Fill(table);
            return table;
        }
    }
    
}
