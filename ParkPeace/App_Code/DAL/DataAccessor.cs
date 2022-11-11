using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Web;

namespace ParkPeace.App_Code.DAL
{
    public class DataAccessor
    {
        private static OdbcConnection conn = null;
        public static OdbcConnection Conn
        {
            get
            {
                if (conn == null)
                {
                    conn = new OdbcConnection(Config.ConnectionString);
                }
                return conn;
            }
        }
        public static void CreateConnection(string connectionString)
        {
            conn = new OdbcConnection(connectionString);
        }

        private static OdbcCommand cmd = null;
        private static OdbcDataAdapter dataAdapter = null;

        #region Attractions
        public static ClassAttractions SelectAttractions(int id)
        {
            ClassAttractions result = null;
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT * FROM Attractions WHERE IdAttraction=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("IdAttraction", id);
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable); ;
                    dataAdapter.Dispose();
                    if (dataTable.Rows.Count > 0)
                    {
                        result = ClassAttractions.Map(dataTable.Rows[0]);
                    }
                }

                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }
        public static List<ClassAttractions> SelectAttractions()
        {
            List<ClassAttractions> result = new List<ClassAttractions>();
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText =
                        "SELECT * FROM Attractions ORDER BY IdAttraction ASC";
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                int i = 1;// счетчик строк в таблице
                foreach (DataRow row in dataTable.Rows)
                {
                    result.Add(ClassAttractions.Map(row, i));
                    i++;
                }
            }
            return result;
        }
        public static int InsertAttractions(ClassAttractions entity)
        {
            int result = 0;
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "INSERT INTO Attractions (IdPark, IdCategory, NameAttraction, Price) VALUES (?, ?, ?, ?)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("IdPark", entity.IdPark);
                    cmd.Parameters.AddWithValue("IdCategory", entity.IdCategory);
                    cmd.Parameters.AddWithValue("NameAttraction", entity.NameAttraction);
                    cmd.Parameters.AddWithValue("Price", entity.Price);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT @@IDENTITY";
                    object o = cmd.ExecuteScalar();
                    if (o != null)
                    {
                        result = int.Parse(o.ToString());
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }
        public static void UpdateAttractions(ClassAttractions entity)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "UPDATE Attractions SET IdCategory=?, NameAttraction=?, Price=? WHERE IdAttraction=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("IdCategory", entity.IdCategory);
                    cmd.Parameters.AddWithValue("NameAttraction", entity.NameAttraction);
                    cmd.Parameters.AddWithValue("Price", entity.Price);
                    cmd.Parameters.AddWithValue("IdAttraction", entity.IdAttraction);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public static void DeleteAttractions(int id)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "DELETE FROM Attractions WHERE IdAttraction=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("IdAttraction", id);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        #endregion Attractions


        #region Category
        public static ClassCategory SelectCategory(int id)
        {
            ClassCategory result = null;
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT * FROM Category WHERE IdCategory=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("IdCategory", id);
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable); ;
                    dataAdapter.Dispose();
                    if (dataTable.Rows.Count > 0)
                    {
                        result = ClassCategory.Map(dataTable.Rows[0]);
                    }
                }

                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }
        public static List<ClassCategory> SelectCategory()
        {
            List<ClassCategory> result = new List<ClassCategory>();
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText =
                        "SELECT * FROM Category ORDER BY IdCategory ASC";
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                int i = 1;// счетчик строк в таблице
                foreach (DataRow row in dataTable.Rows)
                {
                    result.Add(ClassCategory.Map(row, i));
                    i++;
                }
            }
            return result;
        }
 
        public static int InsertCategory(ClassCategory entity)
        {
            int result = 0;
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "INSERT INTO Category (NameCategory,Description) VALUES (?,?)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("NameCategory", entity.NameCategory);
                    cmd.Parameters.AddWithValue("Description", entity.Description);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT @@IDENTITY";
                    object o = cmd.ExecuteScalar();
                    if (o != null)
                    {
                        result = int.Parse(o.ToString());
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }
        public static void UpdateCategory(ClassCategory entity)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "UPDATE Category SET NameCategory=?,Description=? WHERE IdCategory=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("NameCategory", entity.NameCategory);
                    cmd.Parameters.AddWithValue("Description", entity.Description);
                    cmd.Parameters.AddWithValue("IdCategory", entity.IdCategory);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public static void DeleteCategory(int id)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "DELETE FROM Category WHERE IdCategory=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("IdCategory", id);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        #endregion Category

        #region Park
        public static ClassPark SelectPark(int id)
        {
            ClassPark result = null;
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT * FROM Park WHERE IdPark=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("IdPark", id);
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable); ;
                    dataAdapter.Dispose();
                    if (dataTable.Rows.Count > 0)
                    {
                        result = ClassPark.Map(dataTable.Rows[0]);
                    }
                }

                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }
        public static List<ClassPark> SelectPark()
        {
            List<ClassPark> result = new List<ClassPark>();
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText =
                        "SELECT * FROM Park ORDER BY IdPark ASC";
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                int i = 1;// счетчик строк в таблице
                foreach (DataRow row in dataTable.Rows)
                {
                    result.Add(ClassPark.Map(row, i));
                    i++;
                }
            }
            return result;
        }
        public static int InsertPark(ClassPark entity)
        {
            int result = 0;
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "INSERT INTO Park (NamePark, AddressPark, OpeningTime, ClosingTime) VALUES (?, ?, ?, ?)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("NamePark", entity.NamePark);
                    cmd.Parameters.AddWithValue("AddressPark", entity.AddressPark);
                    cmd.Parameters.AddWithValue("OpeningTime", entity.OpeningTime);
                    cmd.Parameters.AddWithValue("ClosingTime", entity.ClosingTime);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT @@IDENTITY";
                    object o = cmd.ExecuteScalar();
                    if (o != null)
                    {
                        result = int.Parse(o.ToString());
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }
        public static void UpdatePark(ClassPark entity)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "UPDATE Park SET NamePark=?, AddressPark=?, OpeningTime=?, ClosingTime=? WHERE IdPark=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("NamePark", entity.NamePark);
                    cmd.Parameters.AddWithValue("AddressPark", entity.AddressPark);
                    cmd.Parameters.AddWithValue("OpeningTime", entity.OpeningTime);
                    cmd.Parameters.AddWithValue("ClosingTime", entity.ClosingTime);
                    cmd.Parameters.AddWithValue("IdPark", entity.IdPark);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public static void DeletePark(int id)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "DELETE FROM Park WHERE IdPark=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("IdPark", id);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        #endregion IdPark

        #region Post
        public static ClassPost SelectPost(int id)
        {
            ClassPost result = null;
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT * FROM Post WHERE IdPost=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("IdPost", id);
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable); ;
                    dataAdapter.Dispose();
                    if (dataTable.Rows.Count > 0)
                    {
                        result = ClassPost.Map(dataTable.Rows[0]);
                    }
                }

                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }
        public static List<ClassPost> SelectPost()
        {
            List<ClassPost> result = new List<ClassPost>();
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText ="SELECT * FROM Post ORDER BY IdPost ASC";
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                int i = 1;// счетчик строк в таблице
                foreach (DataRow row in dataTable.Rows)
                {
                    result.Add(ClassPost.Map(row, i));
                    i++;
                }
            }
            return result;
        }
        public static int InsertPost(ClassPost entity)
        {
            int result = 0;
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "INSERT INTO Post (NamePost,Salary) VALUES (?,?)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("NamePost", entity.NamePost);
                    cmd.Parameters.AddWithValue("Salary", entity.Salary);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT @@IDENTITY";
                    object o = cmd.ExecuteScalar();
                    if (o != null)
                    {
                        result = int.Parse(o.ToString());
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }
        public static void UpdatePost(ClassPost entity)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "UPDATE Post SET NamePost=?,Salary=? WHERE IdPost=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("NamePost", entity.NamePost);
                    cmd.Parameters.AddWithValue("Salary", entity.Salary);
                    cmd.Parameters.AddWithValue("IdPost", entity.IdPost);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public static void DeletePost(int id)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "DELETE FROM Post WHERE IdPost=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("IdPost", id);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        #endregion Post

        #region Staff
        public static ClassStaff SelectStaff(int id)
        {
            ClassStaff result = null;
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT * FROM Staff WHERE IdStaff=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("IdStaff", id);
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable); ;
                    dataAdapter.Dispose();
                    if (dataTable.Rows.Count > 0)
                    {
                        result = ClassStaff.Map(dataTable.Rows[0]);
                    }
                }

                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }
        public static List<ClassStaff> SelectStaff()
        {
            List<ClassStaff> result = new List<ClassStaff>();
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText =
                        "SELECT * FROM Staff ORDER BY IdStaff ASC";
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                int i = 1;// счетчик строк в таблице
                foreach (DataRow row in dataTable.Rows)
                {
                    result.Add(ClassStaff.Map(row, i));
                    i++;
                }
            }
            return result;
        }
        public static int InsertStaff(ClassStaff entity)
        {
            int result = 0;
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "INSERT INTO [Staff] ([IdPark], [IdPost], [NameStaff], [Number], [Mail], [AddressStaff], [BirthDate] ) VALUES (?, ?, ?, ?, ?, ?, ?)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdPark]", entity.IdPark);
                    cmd.Parameters.AddWithValue("[IdPost]", entity.IdPost);
                    cmd.Parameters.AddWithValue("[NameStaff]", entity.NameStaff);
                    cmd.Parameters.AddWithValue("[Number]", entity.Number);
                    cmd.Parameters.AddWithValue("[Mail]", entity.Mail);
                    cmd.Parameters.AddWithValue("[AddressStaff]", entity.AddressStaff);
                    cmd.Parameters.AddWithValue("[BirthDate]", entity.BirthDate);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT @@IDENTITY";
                    object o = cmd.ExecuteScalar();
                    if (o != null)
                    {
                        result = int.Parse(o.ToString());
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }
        public static void UpdateStaff(ClassStaff entity)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "UPDATE [Staff] SET [IdPost]=?, [NameStaff]=?, [Number]=?, [Mail]=?,[AddressStaff]=?,[BirthDate]=? WHERE [IdStaff]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdPost]", entity.IdPost);
                    cmd.Parameters.AddWithValue("[NameStaff]", entity.NameStaff);
                    cmd.Parameters.AddWithValue("[Number]", entity.Number);
                    cmd.Parameters.AddWithValue("[Mail]", entity.Mail);
                    cmd.Parameters.AddWithValue("[AddressStaff]", entity.AddressStaff);
                    cmd.Parameters.AddWithValue("[BirthDate]", entity.BirthDate);
                    cmd.Parameters.AddWithValue("[IdStaff]", entity.IdStaff);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
            public static void DeleteStaff(int id)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "DELETE FROM Staff WHERE IdStaff=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("IdStaff", id);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        #endregion Staff

        #region Ticket

        public static ClassTicket SelectTicket(int id)
        {
            ClassTicket result = null;
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT * FROM Ticket WHERE IdTicket=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("IdTicket", id);
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable); ;
                    dataAdapter.Dispose();
                    if (dataTable.Rows.Count > 0)
                    {
                        result = ClassTicket.Map(dataTable.Rows[0]);
                    }
                }

                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }
        public static List<ClassTicket> SelectTicket()
        {
            List<ClassTicket> result = new List<ClassTicket>();
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText =
                        "SELECT * FROM Ticket ORDER BY IdTicket ASC";
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                int i = 1;// счетчик строк в таблице
                foreach (DataRow row in dataTable.Rows)
                {
                    result.Add(ClassTicket.Map(row, i));
                    i++;
                }
            }
            return result;
        }

        public static int InsertTicket(ClassTicket entity)
        {
            int result = 0;
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "INSERT INTO Ticket (IdAttraction, PurchaseDate) VALUES (?,?)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("IdAttraction", entity.IdAttraction);
                    cmd.Parameters.AddWithValue("PurchaseDate", entity.PurchaseDate);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT @@IDENTITY";
                    object o = cmd.ExecuteScalar();
                    if (o != null)
                    {
                        result = int.Parse(o.ToString());
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }
        public static void UpdateTicket(ClassTicket entity)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "UPDATE Ticket SET PurchaseDate=?,IdAttraction=? WHERE IdTicket=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("PurchaseDate", entity.PurchaseDate);
                    cmd.Parameters.AddWithValue("IdAttraction", entity.IdAttraction);
                    cmd.Parameters.AddWithValue("IdTicket", entity.IdTicket);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public static void DeleteTicket(int id)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "DELETE FROM Ticket WHERE IdTicket=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("IdTicket", id);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        #endregion Ticket
    }
}