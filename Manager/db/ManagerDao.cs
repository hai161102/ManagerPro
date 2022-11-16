using Manager.model;
using Manager.model.instance;
using Manager.model.model;
using Manager.model.model.account;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager.db
{
    public class ManagerDao
    {
        private SqlConnection connection;
        private IDatabaseModel iDatabaseModel;
        private ILoginModel iLoginModel;
        private string DATE_FORMAT = "yyyy-MM-dd";

        public void setIDatabaseModel(IDatabaseModel databaseModel)
        {
            this.iDatabaseModel = databaseModel;
        }

        public void setILoginModel(ILoginModel loginModel)
        {
            this.iLoginModel = loginModel;
        }
        public ManagerDao()

        {
        }

        private SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(Program.CONNECTION_STRING);
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            return connection;
        }

        public void insertData(object data)
        {
            if (data == null) return;
            if (data.GetType() == typeof(NhanVien))
            {
                insertManager((NhanVien)data);
            }
        }

        private void insertManager(NhanVien nhanvien)
        {
            try
            {
                connection = GetConnection();
                string query = "insert into NhanVien values (" 
                    + "'" + nhanvien.ChiNhanh.MaChiNhanh
                    + "', N'" + nhanvien.HoTen
                    + "', '" + nhanvien.SoDienThoai
                    + "', '" + nhanvien.ChucVu.MaChucVu
                    + "', '" + nhanvien.NgaySinh.ToString(DATE_FORMAT)
                    + "', N'" + nhanvien.GioiTinh
                    + "', N'" + nhanvien.QueQuan
                    + "', " + nhanvien.BacLuong.BacLuong
                    + ")";
                SqlCommand command = new SqlCommand(query, connection);
                if (command.ExecuteNonQuery() < 0)
                {
                    connection.Close();
                    iDatabaseModel.onFailure("Some error!");
                    return;
                }
                
            }
            catch (Exception e)
            {

                iDatabaseModel.onFailure(e.Message);
            }
            iDatabaseModel.onSuccess(getNhanVien(nhanvien), "insert_success");

        }

        public void createAccount(UserAccount userAccount)
        {
            try
            {
                connection = GetConnection();
                string query = $"insert into AccountManager values ('{userAccount.getUserName()}', '{userAccount.getPassword()}', '{userAccount.getPermission()}', {userAccount.getNhanVien().Id})";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                if (sqlCommand.ExecuteNonQuery() < 0)
                {
                    iDatabaseModel.onFailure("Add Account Failed!");
                }
                else
                {
                    iDatabaseModel.onSuccess(null, "add_account_done");
                }
                connection.Close();
            }
            catch (Exception e)
            {
                iDatabaseModel.onFailure(e.Message);
            }
        }

        public void updateData(object newData)
        {
            NhanVien newManager = (NhanVien)newData;
            try
            {
                connection = GetConnection();
                string query =
                    $"update NhanVien set MaChiNhanh = '{newManager.ChiNhanh.MaChiNhanh}', HoTen = '{newManager.HoTen}', SoDienThoai = '{newManager.SoDienThoai}', MaChucVu = '{newManager.ChucVu.MaChucVu}', NgaySinh = '{newManager.NgaySinh.ToString(DATE_FORMAT)}', GioiTinh = '{newManager.GioiTinh}', QueQuan = '{newManager.QueQuan}', BacLuong = {newManager.BacLuong.BacLuong} where MaNhanVien = {newManager.Id}";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                if (sqlCommand.ExecuteNonQuery() < 0)
                {
                    iDatabaseModel.onFailure("Please check information agian!");
                }
                else
                {
                    iDatabaseModel.onSuccess(newManager);
                }
                connection.Close();   
            }
            catch (Exception e)
            {
                iDatabaseModel.onFailure(e.Message);
            }
        }

        public void deleteData(object data)
        {
            NhanVien nhanVien = (NhanVien)data;
            try
            {
                deleteDataFromTable("ChamCong", "MaNhanVien", nhanVien.Id);
                deleteDataFromTable("AccountManager", "managerId", nhanVien.Id);
                connection = GetConnection();
                string query = $"delete from NhanVien where MaNhanVien = {nhanVien.Id}";
               

                SqlCommand sqlCommand = new SqlCommand(query, connection);
                if (sqlCommand.ExecuteNonQuery() < 0)
                {
                    iDatabaseModel.onFailure($"Error! Cannot delete this {data.GetType().Name}");
                }
                else
                {
                    getNhanVienList();
                }
                connection.Close();


            }
            catch (Exception e)
            {

                iDatabaseModel.onFailure(e.Message);
            }
        }

        private void deleteDataFromTable(string tbName, string fiel, object data)
        {
            try
            {
                string query = $"delete from {tbName} where {fiel} = ";
                if (data.GetType() != typeof(string))
                {
                    query += data;
                }
                else
                {
                    query += $"N'{data}'";
                }
                connection = GetConnection();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                if (sqlCommand.ExecuteNonQuery() < 0)
                {
                    iDatabaseModel.onFailure($"Error! Cannot delete this {data.GetType().Name}");
                }
                connection.Close();


            }
            catch (Exception e)
            {

                iDatabaseModel.onFailure(e.Message);
            }
        }
        
        public void getListChiNhanh()
        {
            List<ChiNhanh> chiNhanhs = new List<ChiNhanh>();
            try
            {
                connection = GetConnection();
                string query = "select * from ChiNhanh";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    chiNhanhs.Add(new ChiNhanh(
                            reader["MaChiNhanh"].ToString(),
                            reader["TenChiNhanh"].ToString(),
                            reader["DiaChi"].ToString(),
                            reader["Hoiline"].ToString()
                        ));
                }
                connection.Close();
                iDatabaseModel.onSuccess(chiNhanhs, "all_chi_nhanh");
            }
            catch (Exception e)
            {
                iDatabaseModel.onFailure(e.Message);
            }
        }
        public void getListChucVu()
        {
            List<ChucVu> chucVus = new List<ChucVu>();
            try
            {
                connection = GetConnection();
                string query = "select * from ChucVu";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    chucVus.Add(new ChucVu(
                            reader["MaChucVu"].ToString(),
                            reader["TenChucVu"].ToString()
                        ));
                }
                connection.Close();
                iDatabaseModel.onSuccess(chucVus, "all_chuc_vu");

            }
            catch (Exception e)
            {
                iDatabaseModel.onFailure(e.Message);
            }
        }

        public void getListLuong()
        {
            List<Luong> luongs = new List<Luong>();
            try
            {
                connection = GetConnection();
                string query = "select * from Luong";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    luongs.Add(new Luong(
                            Int32.Parse(reader["BacLuong"].ToString()),
                            float.Parse(reader["LuongCoBan"].ToString()),
                            float.Parse(reader["Hesoluong"].ToString()),
                            float.Parse(reader["PhuCap"].ToString())
                        ));
                }
                connection.Close();

                iDatabaseModel.onSuccess(luongs, "all_luong");
            }
            catch (Exception e)
            {

                iDatabaseModel.onFailure(e.Message);
            }
        }
        public void getNhanVienList()
        {
            List<NhanVien> list = new List<NhanVien>();
            try
            {
                connection = GetConnection();
                string query = "Select * from NhanVien";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader oReader = cmd.ExecuteReader();
                while (oReader.Read())
                {
                    try
                    {

                        ChiNhanh chinhanh = new ChiNhanh();
                        ChucVu chucVu = new ChucVu();
                        Luong luong = new Luong();

                        chinhanh.MaChiNhanh = oReader["MaChiNhanh"].ToString();
                        chucVu.MaChucVu = oReader["MaChucVu"].ToString();
                        luong.BacLuong = Int32.Parse(oReader["BacLuong"].ToString());

                        list.Add(new NhanVien(
                        Int32.Parse(oReader["MaNhanVien"].ToString()),
                        oReader["HoTen"].ToString(),
                        oReader["SoDienThoai"].ToString(),
                        DateTime.Parse(oReader["NgaySinh"].ToString()),
                        oReader["GioiTinh"].ToString(),
                        oReader["QueQuan"].ToString(),
                        chinhanh,
                        chucVu,
                        luong)
                        );

                    }
                    catch (Exception e)
                    {
                        iDatabaseModel.onFailure(e.Message);
                    }

                }
                cmd.Dispose();

                connection.Close();

            }
            catch (Exception e)
            {
                iDatabaseModel.onFailure(e.Message);
            }
            list.ForEach(o =>
            {
                o.ChiNhanh = getChiNhanh("Select * from ChiNhanh where MaChiNhanh = '" + o.ChiNhanh.MaChiNhanh + "'");
                o.ChucVu = getChucVu("Select * from ChucVu where MaChucVu = '" + o.ChucVu.MaChucVu + "'");
                o.BacLuong = getLuong("Select * from Luong where BacLuong = " + o.BacLuong.BacLuong);
            });
            iDatabaseModel.onSuccess(list);

        }

        public void changePassword(object acc, string newPass)
        {
            UserAccount user = acc as UserAccount;
            if (user != null)
            {
                try
                {
                    connection = GetConnection();
                    string query = "update AccountManager set passwordManager = '" + newPass + "' where usernameManager = '" + user.getUserName() + "';";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    if (cmd.ExecuteNonQuery() < 0)
                    {
                        iDatabaseModel.onFailure("Some error!");
                    }
                    else
                    {
                        string updateSuccess = "updateSuccess";
                        iDatabaseModel.onSuccess(updateSuccess);
                    }
                }
                catch (Exception e)
                {

                    iDatabaseModel.onFailure(e.Message);
                }
                
            }
        }
        public void getManagerInformation(int id)
        {
            NhanVien nhanVien = new NhanVien();
            try
            {
                connection = GetConnection();
                string query = "Select * from NhanVien where MaNhanVien = " + id;
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader oReader = cmd.ExecuteReader();
                while (oReader.Read())
                {
                    try
                    {

                        ChiNhanh chinhanh = new ChiNhanh();
                        ChucVu chucVu = new ChucVu();
                        Luong luong = new Luong();

                        chinhanh.MaChiNhanh = oReader["MaChiNhanh"].ToString();
                        chucVu.MaChucVu = oReader["MaChucVu"].ToString();
                        luong.BacLuong = Int32.Parse(oReader["BacLuong"].ToString());

                        nhanVien =new NhanVien(
                        Int32.Parse(oReader["MaNhanVien"].ToString()),
                        oReader["HoTen"].ToString(),
                        oReader["SoDienThoai"].ToString(),
                        DateTime.Parse(oReader["NgaySinh"].ToString()),
                        oReader["GioiTinh"].ToString(),
                        oReader["QueQuan"].ToString(),
                        chinhanh,
                        chucVu,
                        luong);

                    }
                    catch (Exception e)
                    {
                        iDatabaseModel.onFailure(e.Message);
                    }

                }
                cmd.Dispose();

                connection.Close();
            }
            catch (Exception e)
            {
                iDatabaseModel.onFailure(e.Message);
            }
            nhanVien.ChiNhanh = getChiNhanh("Select * from ChiNhanh where MaChiNhanh = '" + nhanVien.ChiNhanh.MaChiNhanh + "'");
            nhanVien.ChucVu = getChucVu("Select * from ChucVu where MaChucVu = '" + nhanVien.ChucVu.MaChucVu + "'");
            nhanVien.BacLuong = getLuong("Select * from Luong where BacLuong = " + nhanVien.BacLuong.BacLuong);

            iDatabaseModel.onSuccess(nhanVien);
        }

        public void getManagerInformation(NhanVien nhan)
        {
            NhanVien nhanVien = new NhanVien();
            try
            {
                connection = GetConnection();
                string query = $"Select * from NhanVien where MaChiNhanh = '{nhan.ChiNhanh.MaChiNhanh}' and HoTen = N'{nhan.HoTen}' and CONVERT(VARCHAR, SoDienThoai) = '{nhan.SoDienThoai}' and MaChucVu = '{nhan.ChucVu.MaChucVu}' and NgaySinh = '{nhan.NgaySinh.ToString(DATE_FORMAT)}' and GioiTinh = N'{nhan.GioiTinh}' and QueQuan = N'{nhan.QueQuan}' and BacLuong = {nhan.BacLuong.BacLuong}";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader oReader = cmd.ExecuteReader();
                while (oReader.Read())
                {
                    try
                    {

                        ChiNhanh chinhanh = new ChiNhanh();
                        ChucVu chucVu = new ChucVu();
                        Luong luong = new Luong();

                        chinhanh.MaChiNhanh = oReader["MaChiNhanh"].ToString();
                        chucVu.MaChucVu = oReader["MaChucVu"].ToString();
                        luong.BacLuong = Int32.Parse(oReader["BacLuong"].ToString());

                        nhanVien = new NhanVien(
                        Int32.Parse(oReader["MaNhanVien"].ToString()),
                        oReader["HoTen"].ToString(),
                        oReader["SoDienThoai"].ToString(),
                        DateTime.Parse(oReader["NgaySinh"].ToString()),
                        oReader["GioiTinh"].ToString(),
                        oReader["QueQuan"].ToString(),
                        chinhanh,
                        chucVu,
                        luong);

                    }
                    catch (Exception e)
                    {
                        iDatabaseModel.onFailure(e.Message);
                    }

                }
                cmd.Dispose();

                connection.Close();
            }
            catch (Exception e)
            {
                iDatabaseModel.onFailure(e.Message);
            }
            nhanVien.ChiNhanh = getChiNhanh("Select * from ChiNhanh where MaChiNhanh = '" + nhanVien.ChiNhanh.MaChiNhanh + "'");
            nhanVien.ChucVu = getChucVu("Select * from ChucVu where MaChucVu = '" + nhanVien.ChucVu.MaChucVu + "'");
            nhanVien.BacLuong = getLuong("Select * from Luong where BacLuong = " + nhanVien.BacLuong.BacLuong);

            iDatabaseModel.onSuccess(nhanVien);
        }

        public NhanVien getNhanVien(int id)
        {
            NhanVien nhanVien = new NhanVien();
            try
            {
                connection = GetConnection();
                string query = "Select * from NhanVien where MaNhanVien = " + id;
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader oReader = cmd.ExecuteReader();
                while (oReader.Read())
                {
                    try
                    {

                        ChiNhanh chinhanh = new ChiNhanh();
                        ChucVu chucVu = new ChucVu();
                        Luong luong = new Luong();

                        chinhanh.MaChiNhanh = oReader["MaChiNhanh"].ToString();
                        chucVu.MaChucVu = oReader["MaChucVu"].ToString();
                        luong.BacLuong = Int32.Parse(oReader["BacLuong"].ToString());

                        nhanVien = new NhanVien(
                        Int32.Parse(oReader["MaNhanVien"].ToString()),
                        oReader["HoTen"].ToString(),
                        oReader["SoDienThoai"].ToString(),
                        DateTime.Parse(oReader["NgaySinh"].ToString()),
                        oReader["GioiTinh"].ToString(),
                        oReader["QueQuan"].ToString(),
                        chinhanh,
                        chucVu,
                        luong);

                    }
                    catch (Exception e)
                    {
                    }

                }
                cmd.Dispose();

                connection.Close();
            }
            catch (Exception e)
            {
            }
            nhanVien.ChiNhanh = getChiNhanh("Select * from ChiNhanh where MaChiNhanh = '" + nhanVien.ChiNhanh.MaChiNhanh + "'");
            nhanVien.ChucVu = getChucVu("Select * from ChucVu where MaChucVu = '" + nhanVien.ChucVu.MaChucVu + "'");
            nhanVien.BacLuong = getLuong("Select * from Luong where BacLuong = " + nhanVien.BacLuong.BacLuong);

            return nhanVien;
        }
        public NhanVien getNhanVien(NhanVien nhan)
        {
            NhanVien nhanVien = new NhanVien();
            try
            {
                connection = GetConnection();
                string query = $"Select * from NhanVien where " +
                    $"MaChiNhanh = '{nhan.ChiNhanh.MaChiNhanh}'" +
                    $" and HoTen = N'{nhan.HoTen}'" +
                    $" and CONVERT(VARCHAR, SoDienThoai) = '{nhan.SoDienThoai}'" +
                    $" and MaChucVu = '{nhan.ChucVu.MaChucVu}'" +
                    $" and NgaySinh = '{nhan.NgaySinh.ToString(DATE_FORMAT)}'" +
                    $" and GioiTinh = N'{nhan.GioiTinh}'" +
                    $" and QueQuan = N'{nhan.QueQuan}'" +
                    $" and BacLuong = {nhan.BacLuong.BacLuong};";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader oReader = cmd.ExecuteReader();
                while (oReader.Read())
                {
                    try
                    {

                        ChiNhanh chinhanh = new ChiNhanh();
                        ChucVu chucVu = new ChucVu();
                        Luong luong = new Luong();

                        chinhanh.MaChiNhanh = oReader["MaChiNhanh"].ToString();
                        chucVu.MaChucVu = oReader["MaChucVu"].ToString();
                        luong.BacLuong = Int32.Parse(oReader["BacLuong"].ToString());

                        nhanVien = new NhanVien(
                        Int32.Parse(oReader["MaNhanVien"].ToString()),
                        oReader["HoTen"].ToString(),
                        oReader["SoDienThoai"].ToString(),
                        DateTime.Parse(oReader["NgaySinh"].ToString()),
                        oReader["GioiTinh"].ToString(),
                        oReader["QueQuan"].ToString(),
                        chinhanh,
                        chucVu,
                        luong);

                    }
                    catch (Exception e)
                    {
                        iDatabaseModel.onFailure(e.Message);
                    }

                }
                cmd.Dispose();

                connection.Close();
            }
            catch (Exception e)
            {
                iDatabaseModel.onFailure(e.Message);
            }
            nhanVien.ChiNhanh = getChiNhanh("Select * from ChiNhanh where MaChiNhanh = '" + nhanVien.ChiNhanh.MaChiNhanh + "'");
            nhanVien.ChucVu = getChucVu("Select * from ChucVu where MaChucVu = '" + nhanVien.ChucVu.MaChucVu + "'");
            nhanVien.BacLuong = getLuong("Select * from Luong where BacLuong = " + nhanVien.BacLuong.BacLuong);

            return nhanVien;
        }

        public void login(object obj)
        {

            AccountManager account = obj as AccountManager;
            if (account != null)
            {
                UserAccount userAccount = new UserAccount();
                try
                {
                    connection = GetConnection();
                    string query = "Select * from AccountManager where usernameManager = '" + account.getUserName() + "' and passwordManager = '"
                        + account.getPassword() + "'";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader oReader = cmd.ExecuteReader();
                    while (oReader.Read())
                    {
                        try
                        {
                            NhanVien nhanVien = new NhanVien();
                            nhanVien.Id = Int32.Parse(oReader["managerId"].ToString());
                            userAccount = new UserAccount(
                                    oReader["usernameManager"].ToString(),
                                    oReader["passwordManager"].ToString(),
                                    oReader["permission"].ToString(),
                                    nhanVien
                                );

                        }
                        catch (Exception e)
                        {
                            iLoginModel.onLoginFailure(e.Message);
                        }
                    }
                    cmd.Dispose();
                    connection.Close();
                    iLoginModel.onLoginSuccess(userAccount);

                }
                catch (Exception e)
                {
                    iLoginModel.onLoginFailure(e.Message);
                }
            }
        }

        private Luong getLuong(string sub3)
        {
            Luong luong = new Luong();

            connection = GetConnection();
            SqlCommand cmd = new SqlCommand(sub3, connection);
            SqlDataReader oReader = cmd.ExecuteReader();
                while (oReader.Read())
            {
                try
                {
                    luong = new Luong(
                            Int32.Parse(oReader["BacLuong"].ToString()),
                            float.Parse(oReader["LuongCoBan"].ToString()),
                            float.Parse(oReader["Hesoluong"].ToString()),
                            float.Parse(oReader["PhuCap"].ToString())
                        );
                }
                catch (Exception e)
                {
                    iDatabaseModel.onFailure(e.Message);
                }

            }
            cmd.Dispose();
            connection.Close();

            return luong;
        }

        private ChucVu getChucVu(string sub2)
        {
            ChucVu chuc = new ChucVu();
            connection = GetConnection();
            SqlCommand cmd = new SqlCommand(sub2, connection);
            SqlDataReader oReader = cmd.ExecuteReader();
            while (oReader.Read())
            {
                try
                {
                    chuc = new ChucVu(
                            oReader["MaChucVu"].ToString(),
                            oReader["TenChucVu"].ToString()
                            );
                }
                catch (Exception e)
                {
                    iDatabaseModel.onFailure(e.Message);
                }

            }
            cmd.Dispose();
            connection.Close();
            return chuc;
        }

        private ChiNhanh getChiNhanh(string sub1)
        {
            ChiNhanh chiNhanh = new ChiNhanh();
            connection = GetConnection();
            SqlCommand cmd = new SqlCommand(sub1, connection);
            SqlDataReader oReader = cmd.ExecuteReader();
            while (oReader.Read())
            {
                try
                {
                    chiNhanh = new ChiNhanh(
                            oReader["MaChiNhanh"].ToString(),
                            oReader["TenChiNhanh"].ToString(),
                            oReader["DiaChi"].ToString(),
                            oReader["Hoiline"].ToString()
                        );
                }
                catch (Exception e)
                {
                    iDatabaseModel.onFailure(e.Message);
                }

            }
            cmd.Dispose();
            connection.Close();
            return chiNhanh;
        }
    }
}
