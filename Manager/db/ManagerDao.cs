using Manager.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.db
{
    public class ManagerDao
    {
        private SqlConnection connection;

        public ManagerDao()
        {
            connection = new SqlConnection("Data Source=25.35.217.109;Initial Catalog=Nhom_12;Persist Security Info=True;User ID=sa;Password=tutuvuong1");
        }

        public List<NhanVien> getNhanVienList()
        {
            List<NhanVien> list = new List<NhanVien>();
            using (connection)
            {
                try
                {
                    string query = "Select * from NhanVien";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    using (SqlDataReader oReader = cmd.ExecuteReader())
                    {

                        while (oReader.Read())
                        {
                            try
                            {
                                list.Add(new NhanVien(
                                Int32.Parse(oReader["MaNhanVien"].ToString()),
                                oReader["MaChiNhanh"].ToString(),
                                oReader["HoTen"].ToString(),
                                oReader["SoDienThoai"].ToString(),
                                oReader["MaChucVu"].ToString(),
                                DateTime.Parse(oReader["NgaySinh"].ToString()),
                                oReader["GioiTinh"].ToString(),
                                oReader["QueQuan"].ToString(),
                                float.Parse(oReader["BacLuong"].ToString())
                                ));
                            }
                            catch (Exception)
                            {

                            }

                        }

                        connection.Close();
                    }

                }
                catch (Exception)
                {

                }
                
            }

            return list;
        }
    }
}
