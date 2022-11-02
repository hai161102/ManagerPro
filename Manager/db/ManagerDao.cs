using Manager.model;
using Manager.model.model;
using System;
using System.Collections.Generic;
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

        public ManagerDao(IDatabaseModel database)

        {
            this.iDatabaseModel = database;
            connection = new SqlConnection("Data Source=HAI;Initial Catalog=Manager_gr_12;Integrated Security=True");
            getNhanVienList();
        }

        public void getNhanVienList()
        {
            List<NhanVien> list = new List<NhanVien>();
            using (connection)
            {
                try
                {
                    string query = "Select * from Manager";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    using (SqlDataReader oReader = cmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            try
                            {
                                
                                ChiNhanh chinhanh = new ChiNhanh();
                                ChucVu chucVu = new ChucVu();
                                Luong luong = new Luong();

                                chinhanh.MaChiNhanh = oReader["stateId"].ToString();
                                chucVu.MaChucVu = oReader["levelId"].ToString();
                                luong.BacLuong = Int32.Parse(oReader["salaryId"].ToString());

                                list.Add(new NhanVien(
                                Int32.Parse(oReader["managerId"].ToString()),
                                oReader["managerName"].ToString(),
                                oReader["managerNumber"].ToString(),
                                DateTime.Parse(oReader["managerDob"].ToString()),
                                oReader["managerSex"].ToString(),
                                oReader["managerHometown"].ToString(),
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

                }
                catch (Exception e)
                {
                    iDatabaseModel.onFailure(e.Message);
                }
                list.ForEach(o =>
                {
                    o.ChiNhanh = getChiNhanh("Select * from StateCompany where stateId = '" + o.ChiNhanh.MaChiNhanh + "'");
                    o.ChucVu = getChucVu("Select * from LevelManager where levelId = '" + o.ChucVu.MaChucVu + "'");
                    o.BacLuong = getLuong("Select * from Salary where salaryId = " + o.BacLuong.BacLuong);
                });

            }
            iDatabaseModel.onSuccess(list);

        }

        private Luong getLuong(string sub3)
        {
            Luong luong = new Luong();

            SqlCommand cmd = new SqlCommand(sub3, connection);
            connection.Open();
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {

                while (oReader.Read())
                {
                    try
                    {
                        luong = new Luong(
                                Int32.Parse(oReader["salaryId"].ToString()),
                                float.Parse(oReader["baseSalary"].ToString()),
                                float.Parse(oReader["indexSalary"].ToString()),
                                float.Parse(oReader["bonusSalary"].ToString())
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
            return luong;
        }

        private ChucVu getChucVu(string sub2)
        {
            ChucVu chuc = new ChucVu();
            SqlCommand cmd = new SqlCommand(sub2, connection);
            connection.Open ();
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {

                while (oReader.Read())
                {
                    try
                    {
                        chuc = new ChucVu(
                                oReader["levelId"].ToString(),
                                oReader["levelName"].ToString()
                                );
                    }
                    catch (Exception e)
                    {
                        iDatabaseModel.onFailure(e.Message);
                    }

                }
                cmd.Dispose();
                connection.Close ();
            }
            return chuc;
        }

        private ChiNhanh getChiNhanh(string sub1)
        {
            ChiNhanh chiNhanh = new ChiNhanh();
            SqlCommand cmd = new SqlCommand(sub1, connection);
            connection.Open();
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {

                while (oReader.Read())
                {
                    try
                    {
                        chiNhanh = new ChiNhanh(
                                oReader["stateId"].ToString(),
                                oReader["stateName"].ToString(),
                                oReader["stateAddress"].ToString(),
                                oReader["stateHotline"].ToString()
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
            return chiNhanh;
        }
    }
}
