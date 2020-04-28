using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanQuyen.Model
{
    class nguoiDung
    {
        MyDB mydb = new MyDB();
        public int id { get; set; }
        public string ho_va_ten { get; set; }
        public string username { get; set; }
        public string password_moi { get; set; }
        public string password_cu { get; set; }
        public int loaiNguoiDung_id { get; set; }
        public bool checkUserAndPass()
        {
            SqlCommand command = new SqlCommand("select * from nguoiDung where [username] = @username and [password_moi] = @password_moi", mydb.Connection);
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@password_moi", SqlDbType.NVarChar).Value = password_moi;
            SqlDataAdapter Adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            Adapter.Fill(table);
            mydb.openConnection();
            if (table.Rows.Count == 1)
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
        
        public bool changePassword()
        {
            SqlCommand command = new SqlCommand("update nguoiDung set [password_cu] = [password_moi] ,[password_moi] = @password_moi where [username] = @username", mydb.Connection);
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@password_moi", SqlDbType.NVarChar).Value = password_moi;
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
        public bool checkNewPassword(string newpassword)
        {
            // xem passwoed co trung lap ko
            SqlCommand command = new SqlCommand("select * from nguoiDung where [password_cu] = @newpassword or [password_moi] = @newpassword and [username] = @username ", mydb.Connection);
            command.Parameters.Add("@newpassword", SqlDbType.NVarChar).Value = newpassword;
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            SqlDataAdapter Adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            Adapter.Fill(table);
            mydb.openConnection();
            if (table.Rows.Count == 1)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }
        public bool checkOldPassword(string User,string PassWord)
        {
            SqlCommand command = new SqlCommand("select * from nguoiDung where [username] = @username and [password_moi] = @password_moi", mydb.Connection);
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = User;
            command.Parameters.Add("@password_moi", SqlDbType.NVarChar).Value = PassWord;
            SqlDataAdapter Adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            Adapter.Fill(table);
            mydb.openConnection();
            if (table.Rows.Count == 1)
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
        public DataTable QuyenLoaiNguoiDung(string User)
        {
            SqlCommand command = new SqlCommand("select ND.ho_va_ten,LND.tenLoaiNguoiDung,Q.tenQuyen from nguoiDung ND join loaiNguoiDung LND on ND.id = LND.id join loaiNguoiDung_Quyen LNDQ ON LND.id = LNDQ.loaiNguoiDung_id join quyen Q on LNDQ.quyen_id = Q.id where ND.username = @username", mydb.Connection);
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = User;
            DataTable table = new DataTable();
            SqlDataAdapter Apter = new SqlDataAdapter(command);
            Apter.Fill(table);
            return table;
        }
        public DataTable QuyenNguoiDung(string User)
        {
            SqlCommand command = new SqlCommand("select ND.ho_va_ten,Q.tenQuyen from " +
                                                "nguoiDung ND join nguoiDung_Quyen NDQ on ND.id = NDQ.nguoiDung_id " +
                                                "join quyen Q on NDQ.quyen_id = Q.id " +
                                                "where ND.username = @username", mydb.Connection);
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = User;
            DataTable table = new DataTable();
            SqlDataAdapter Apter = new SqlDataAdapter(command);
            Apter.Fill(table);
            return table;
        }
        public DataTable ShowtableNguoiDung()
        {
            SqlCommand command = new SqlCommand("select * from nguoiDung", mydb.Connection);          
            DataTable table = new DataTable();
            SqlDataAdapter Apter = new SqlDataAdapter(command);
            Apter.Fill(table);
            return table;
        }

        public bool Insert()
        {
            SqlCommand command = new SqlCommand("insert into nguoiDung (ho_va_ten,username,password_moi,loaiNguoiDung_id)" + " values (@ho_va_ten,@username,@password_moi,@loaiNguoiDung_id)", mydb.Connection);
            command.Parameters.Add("@ho_va_ten", SqlDbType.NVarChar).Value = ho_va_ten;
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@password_moi", SqlDbType.NVarChar).Value = password_moi;
            command.Parameters.Add("@loaiNguoiDung_id", SqlDbType.Int).Value = loaiNguoiDung_id;
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
        public bool Update()
        {
            SqlCommand command = new SqlCommand("update nguoiDung set ho_va_ten = @ho_va_ten ,username = @username,password_moi = @password_moi,loaiNguoiDung_id = @loaiNguoiDung_id where id = @id", mydb.Connection);
            command.Parameters.Add("@ho_va_ten", SqlDbType.NVarChar).Value = ho_va_ten;
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@password_moi", SqlDbType.NVarChar).Value = password_moi;
            command.Parameters.Add("@loaiNguoiDung_id", SqlDbType.Int).Value = loaiNguoiDung_id;
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
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
    }
}
