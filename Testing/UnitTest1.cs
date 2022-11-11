using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;

namespace Testing
{
    [TestClass]
    public class UnitTest1
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
    }
}
