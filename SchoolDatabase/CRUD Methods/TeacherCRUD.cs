using SchoolDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SchoolDatabase.CRUD_Methods
{
    public class TeacherCRUD
    {
        public static bool AddNewTeacher(Teacher teacher)
        {
            using SqlConnection con = DbConnection.GetConnection();

            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"INSERT INTO TeacherModel(ID,Name,Qualification) 
                            VALUES(@param1,@param2,@param3)";

                    cmd.Parameters.AddWithValue("@param1", teacher.ID);
                    cmd.Parameters.AddWithValue("@param2", teacher.Name);
                    cmd.Parameters.AddWithValue("@param3", teacher.Qualification);

                    try
                    {
                        con.Open();
                        int res= cmd.ExecuteNonQuery();
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
        public static bool DeleteTeacher(string ID)
        {
            using SqlConnection con = DbConnection.GetConnection();

            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"DELETE FROM TeacherModel WHERE ID = @param1";

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
        public static bool UpdateTeacher(Teacher teacher)
        {
            using SqlConnection con = DbConnection.GetConnection();

            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"UPDATE TeacherModel SET Name = @param2, Qualification = @param3 WHERE ID = @param1";

                    cmd.Parameters.AddWithValue("@param1", teacher.ID);
                    cmd.Parameters.AddWithValue("@param2", teacher.Name);
                    cmd.Parameters.AddWithValue("@param3", teacher.Qualification);


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
