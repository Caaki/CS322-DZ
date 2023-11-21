using CS322_DZ07.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.CodeDom;
using System.Diagnostics;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace CS322_DZ07.repository.impl
{
    internal class UserRepositoryImpl : UserRepository
    {
        private static MySqlConnection con = new MySqlConnection(
            "SERVER=LOCALHOST;DATABASE=cs322_dz07;UID=root;PASSWORD=1234;"
            );


        public User AddUser(User user)
        {
            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO user(id, first_name, last_name, age) " +
                    "VALUES (@id, @firstName, @lastName, @age)", con);

                cmd.Parameters.AddWithValue("@id", user.Id);
                cmd.Parameters.AddWithValue("@firstName", user.FirstName);
                cmd.Parameters.AddWithValue("@lastName", user.LastName);
                cmd.Parameters.AddWithValue("@age", user.Age);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error with connection or query: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return user;
        }

        public bool DeleteById(long id)
        {
            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("DELETE FROM user WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@id", id);

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error with connection or query: " + ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public List<User> FindAll()
        {

            List<User> users = new List<User>();

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM user", con);
                DataSet ds = new DataSet();
                da.Fill(ds);


                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    long id = Convert.ToInt64(r["id"].ToString());
                    string firstName = r["first_name"].ToString();
                    string lastName = r["last_name"].ToString();
                    int age = Convert.ToInt32(r["age"]);
                    User u = new User(id, firstName, lastName, age);
                    users.Add(u);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error with connection");

            }

            return users;
        }

        public void EditById(long id, string fistName, string lastName, int age)
        {

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE user SET " +
                    "first_name=@firstName," +
                    "last_name=@lastName," +
                    "age =@age " +
                    "WHERE id =@id;", con);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@firstName", fistName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@age", age);

                cmd.ExecuteNonQuery();



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }finally { con.Close(); }

                  }
    }
}
