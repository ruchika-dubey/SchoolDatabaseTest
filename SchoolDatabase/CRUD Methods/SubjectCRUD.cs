using SchoolDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SchoolDatabase.CRUD_Methods
{
    public class SubjectCRUD
    {
        public static bool AddNewSubject(Subject subject)
        {
            using SqlConnection con = DbConnection.GetConnection();

            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"INSERT INTO SubjectModel(ID,Name,Stream) 
                            VALUES(@param1,@param2,@param3)";

                    cmd.Parameters.AddWithValue("@param1", subject.ID);
                    cmd.Parameters.AddWithValue("@param2", subject.Name);
                    cmd.Parameters.AddWithValue("@param3", subject.Stream);

                    try
                    {
                        con.Open();
                        int res = cmd.ExecuteNonQuery();
                        if (res > 0)
                        {
                            con.Close();
                            return true;
                        }
                        else
                        {
                            con.Close();
                            return false;
                        }

                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.Message);

                        con.Close();
                        return false;
                    }

                }
            }
        }
        public static bool DeleteSubject(string ID)
        {
            using SqlConnection con = DbConnection.GetConnection();

            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"DELETE FROM SubjectModel WHERE ID = @param1";

                    cmd.Parameters.AddWithValue("@param1", ID);


                    try
                    {
                        con.Open();
                        int res = cmd.ExecuteNonQuery();
                        if (res > 0)
                        {
                            con.Close();
                            return true;
                        }
                        else
                        {
                            con.Close();
                            return false;
                        }

                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.Message);

                        con.Close();
                        return false;
                    }

                }
            }
        }
        public static bool UpdateSubject(Subject subject)
        {
            using SqlConnection con = DbConnection.GetConnection();

            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"UPDATE SubjectModel SET Name = @param2, Stream = @param3 WHERE ID = @param1";

                    cmd.Parameters.AddWithValue("@param1", subject.ID);
                    cmd.Parameters.AddWithValue("@param2", subject.Name);
                    cmd.Parameters.AddWithValue("@param3", subject.Stream);


                    try
                    {
                        con.Open();
                        int res = cmd.ExecuteNonQuery();
                        if (res > 0)
                        {
                            con.Close();
                            return true;
                        }
                        else
                        {
                            con.Close();
                            return false;
                        }

                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.Message);

                        con.Close();
                        return false;
                    }

                }
            }
        }
    }
}
