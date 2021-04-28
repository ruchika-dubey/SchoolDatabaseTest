using SchoolDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SchoolDatabase.CRUD_Methods
{
    public class StudentCRUD
    {
        public static bool AddNewStudent(Student student)
        {
            using SqlConnection con = DbConnection.GetConnection();

            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"INSERT INTO StudentModel(ID,Name,Class) 
                            VALUES(@param1,@param2,@param3)";

                    cmd.Parameters.AddWithValue("@param1", student.ID);
                    cmd.Parameters.AddWithValue("@param2", student.Name);
                    cmd.Parameters.AddWithValue("@param3", student.Class);

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
        public static bool DeleteStudent(string ID)
        {
            using SqlConnection con = DbConnection.GetConnection();

            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"DELETE FROM StudentModel WHERE ID = @param1";

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
        public static bool UpdateStudent(Student student)
        {
            using SqlConnection con = DbConnection.GetConnection();

            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"UPDATE StudentModel SET Name = @param2, Class = @param3 WHERE ID = @param1";

                    cmd.Parameters.AddWithValue("@param1", student.ID);
                    cmd.Parameters.AddWithValue("@param2", student.Name);
                    cmd.Parameters.AddWithValue("@param3", student.Class);


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
