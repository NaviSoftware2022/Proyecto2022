using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;

namespace testingg
{
    [TestClass]
    public class UnitTest2
    {
        public static bool test = true;
        static MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root; password=root");

        [TestMethod]
        public void TestMethod1()
        {
            datos.Open();
            MySqlCommand comando = new MySqlCommand("Select correo from Usuario where correo = @vcorreo", datos);
            comando.Parameters.AddWithValue("@vcorreo", "root");

            MySqlDataReader lector = comando.ExecuteReader();
            bool a = lector.Read();
            datos.Close();

            Assert.AreEqual(a, test);
        }

        [TestMethod]
        public void TestMethod2()
        {
            datos.Open();
            MySqlCommand comando = new MySqlCommand("Select correo from UsuarioNoM where correo = @vcorreo", datos);
            comando.Parameters.AddWithValue("@vcorreo", "test1");

            MySqlDataReader lector = comando.ExecuteReader();
            bool a = lector.Read();


            datos.Close();

            Assert.AreEqual(a, test);
        }

        [TestMethod]
        public void TestMethod3()
        {
            datos.Open();
            MySqlCommand comando = new MySqlCommand("Select correo from Miembro where correo = @vcorreo", datos);
            comando.Parameters.AddWithValue("@vcorreo", "test2");

            MySqlDataReader lector = comando.ExecuteReader();
            bool a = lector.Read();


            datos.Close();

            Assert.AreEqual(a, test);
        }

        [TestMethod]
        public void TestMethod4()
        {
            datos.Open();
            MySqlCommand comando = new MySqlCommand("Select correo from admin where correo = @vcorreo", datos);
            comando.Parameters.AddWithValue("@vcorreo", "root");

            MySqlDataReader lector = comando.ExecuteReader();
            bool a = lector.Read();


            datos.Close();

            Assert.AreEqual(a, test);
        }

        [TestMethod]
        public void TestMethod5()
        {
            bool a;
            try
            {
                datos.Open();
                MySqlCommand comando1 = new MySqlCommand("Insert into Usuario values(@vcorreo, @vcontrasenia)", datos);
                comando1.Parameters.AddWithValue("@vcorreo", "root1");
                comando1.Parameters.AddWithValue("@vcontrasenia", "123");
                comando1.ExecuteNonQuery();

                datos.Close();
                a = true;
                
            } catch (Exception)
            {
                a = false;
            }
            Assert.AreEqual(a, test);
        }

        [TestMethod]
        public void TestMethod6()
        {
            bool a;
            try
            {
                datos.Open();
                MySqlCommand comando1 = new MySqlCommand("Delete from Miembro where correo = @vcorreo", datos);
                comando1.Parameters.AddWithValue("@vcorreo", "test2");

                comando1.ExecuteNonQuery();
                datos.Close();
                a = true;

            } catch (Exception)
            {
                a = false;
            }
            Assert.AreEqual(a, test);
        }


        [TestMethod]
        public void TestMethod7()
        {
            bool a;
            try
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("select idDeporte, nombreDeporte from Deporte", datos);
                MySqlDataReader lector = comando.ExecuteReader();

                List<string> lista = new List<string>();
                while (lector.Read())
                {
                    lista.Add(Convert.ToString(lector["nombreDeporte"]));
                }
                lista.Sort();
                datos.Close();
                a = true;

            }
            catch (Exception)
            {
                a = false;
            }
            Assert.AreEqual(a, test);
        }

        [TestMethod]
        public void TestMethod8()
        {
            bool a;
            try
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("delete from Pasa where idEvento = @id;", datos);
                comando.Parameters.AddWithValue("@id", "1");

                comando.ExecuteNonQuery();
                datos.Close();
                a = true;
            } 
            catch (Exception)
            {
                a = false;
            }
            Assert.AreEqual(a, test);
        }

        [TestMethod]
        public void TestMethod9()
        {
            bool a;
            try
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("delete from Pasa where idLugar = @id;", datos);
                comando.Parameters.AddWithValue("@id", "1");

                comando.ExecuteNonQuery();
                datos.Close();
                a = true;
            }
            catch (Exception)
            {
                a = false;
            }
            Assert.AreEqual(a, test);
        }
    }
}
