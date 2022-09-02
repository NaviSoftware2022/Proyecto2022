﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using MySql.Data.MySqlClient;

namespace JAGSport
{
    class Logica
    {

        static MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root;");
        HomeVIP userV = new HomeVIP();

        public class Usuario
        {
            public string correo { get; set; }
            public string contrasenia { get; set; }

            public Usuario() { }
            public Usuario(string correo, string contrasenia)
            {
                this.correo = correo;
                this.contrasenia = contrasenia;
            }

            public bool autenticacion()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("Select correo, contrasenia from UsuarioNoM where correo = @vcorreo AND contrasenia = @vcontrasenia", datos);
                comando.Parameters.AddWithValue("@vcorreo", correo);
                comando.Parameters.AddWithValue("@vcontrasenia", contrasenia);

                MySqlDataReader lector = comando.ExecuteReader();
                bool a = lector.Read();

                if (a)
                {
                    JAGSport.Home.datosLog = lector["correo"].ToString();
                }
                datos.Close();

                return a;
            }

            public bool autenticacionUser()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("Select correo from UsuarioNoM where correo = @vcorreo", datos);
                comando.Parameters.AddWithValue("@vcorreo", correo);

                MySqlDataReader lector = comando.ExecuteReader();
                bool a = lector.Read();

                if (a)
                {
                    JAGSport.Home.datosLog = lector["correo"].ToString();
                }

                datos.Close();



                return a;
            }

            public bool autenticacionUserNormal()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("Select correo from Usuario where correo = @vcorreo", datos);
                comando.Parameters.AddWithValue("@vcorreo", correo);

                MySqlDataReader lector = comando.ExecuteReader();
                bool a = lector.Read();

                if (a)
                {
                    JAGSport.Home.datosLog = lector["correo"].ToString();
                }

                datos.Close();



                return a;
            }


            public void agregarx()
            {
                datos.Open();
                MySqlCommand comando1 = new MySqlCommand("Insert into Usuario values(@vcorreo, @vcontrasenia)", datos);
                comando1.Parameters.AddWithValue("@vcorreo", correo);
                comando1.Parameters.AddWithValue("@vcontrasenia", contrasenia);
                comando1.ExecuteNonQuery();

                datos.Close();
            }

            public void agregary()
            {
                datos.Open();
                MySqlCommand comando2 = new MySqlCommand("Insert into UsuarioNoM values(@vcorreo, @vcontrasenia)", datos);
                comando2.Parameters.AddWithValue("@vcorreo", correo);
                comando2.Parameters.AddWithValue("@vcontrasenia", contrasenia);

                comando2.ExecuteNonQuery();

                datos.Close();
            }

            public void eliminarx()
            {
                datos.Open();
                MySqlCommand comando1 = new MySqlCommand("Delete from Usuario where correo = @vcorreo", datos);
                comando1.Parameters.AddWithValue("@vcorreo", correo);

                comando1.ExecuteNonQuery();
                datos.Close();

            }

            public void eliminary()
            {
                datos.Open();
                MySqlCommand comando1 = new MySqlCommand("Delete from usuarioNoM where correo = @vcorreo", datos);
                comando1.Parameters.AddWithValue("@vcorreo", correo);

                comando1.ExecuteNonQuery();
                datos.Close();

            }

        }



        public class UsuarioVIP
        {
            public string correo { get; set; }
            public string contrasenia { get; set; }
            public int membrecia { get; set; }

            public UsuarioVIP() { }
            public UsuarioVIP(string correo, string contrasenia, int membrecia)
            {
                this.correo = correo;
                this.contrasenia = contrasenia;
                this.membrecia = membrecia;
            }

            public bool autenticacionUser()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("Select correo from Miembro where correo = @vcorreo", datos);
                comando.Parameters.AddWithValue("@vcorreo", correo);

                MySqlDataReader lector = comando.ExecuteReader();
                bool a = lector.Read();

                if(a) { 
                JAGSport.HomeVIP.datosLog = lector["correo"].ToString();
                }
                datos.Close();

                return a;
            }

            public bool autenticacion()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("Select correo, contrasenia from Miembro where correo = @vcorreo AND contrasenia = @vcontrasenia", datos);
                comando.Parameters.AddWithValue("@vcorreo", correo);
                comando.Parameters.AddWithValue("@vcontrasenia", contrasenia);

                MySqlDataReader lector = comando.ExecuteReader();
                bool a = lector.Read();

                if (a)
                {
                    JAGSport.HomeVIP.datosLog = lector["correo"].ToString();
                }
                datos.Close();

                return a;
            }


            public void agregar()
            {
                datos.Open();
                MySqlCommand comando1 = new MySqlCommand("Insert into Miembro values(@vcorreo, @vcontrasenia, @vmembresia)", datos);
                comando1.Parameters.AddWithValue("@vcorreo", correo);
                comando1.Parameters.AddWithValue("@vcontrasenia", contrasenia);
                comando1.Parameters.AddWithValue("@vmembresia", membrecia);

                comando1.ExecuteNonQuery();
                datos.Close();
            }

            public void eliminar()
            {
                datos.Open();
                MySqlCommand comando1 = new MySqlCommand("Delete from Miembro where correo = @vcorreo", datos);
                comando1.Parameters.AddWithValue("@vcorreo", correo);

                comando1.ExecuteNonQuery();
                datos.Close();

            }

          


        }

        public class UsuarioAdmin
        {
            public string correo { get; set; }
            public string contrasenia { get; set; }
            public string Codigo { get; set; }

            public UsuarioAdmin() { }
            public UsuarioAdmin(string correo, string contrasenia, string codigo)
            {
                this.correo = correo;
                this.contrasenia = contrasenia;
                this.Codigo = codigo;
            }

            public void agregar()
            {
                datos.Open();
                MySqlCommand comando1 = new MySqlCommand("Insert into admin values(@vcorreo, @vcontrasenia, @vcodigo)", datos);
                comando1.Parameters.AddWithValue("@vcorreo", correo);
                comando1.Parameters.AddWithValue("@vcontrasenia", contrasenia);
                comando1.Parameters.AddWithValue("@vcodigo", Codigo);

                comando1.ExecuteNonQuery();
                datos.Close();
            }


            public void eliminar()
            {
                datos.Open();
                MySqlCommand comando1 = new MySqlCommand("Delete from admin where correo = @vcorreo", datos);
                comando1.Parameters.AddWithValue("@vcorreo", correo);

                comando1.ExecuteNonQuery();
                datos.Close();

            }

            public bool autenticacion()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("Select correo, contrasenia from admin where correo = @vcorreo AND contrasenia = @vcontrasenia", datos);
                comando.Parameters.AddWithValue("@vcorreo", correo);
                comando.Parameters.AddWithValue("@vcontrasenia", contrasenia);

                MySqlDataReader lector = comando.ExecuteReader();
                bool a = lector.Read();
                datos.Close();

                return a;
            }
        }




        public class Deporte
        {
            public string nombreDeporte { get; set; }

            public Deporte() { }
            public Deporte(string nombreDeporte)
            {
                this.nombreDeporte = nombreDeporte;
            }


            public bool autenticacionDeporte ()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("Select nombreDeporte from Deporte where nombreDeporte = @vnombre", datos);
                comando.Parameters.AddWithValue("@vnombre", nombreDeporte);

                MySqlDataReader lector = comando.ExecuteReader();
                bool a = lector.Read();

                datos.Close();

                return a;
            }

            public void agregarDeporte ()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("insert into Deporte (nombreDeporte) value (@vdeporte);", datos);
                comando.Parameters.AddWithValue("@vdeporte", nombreDeporte);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public List<string> mostrarDeporte ()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("select idDeporte, nombreDeporte from Deporte", datos);
                MySqlDataReader lector = comando.ExecuteReader();

                List<string> lista = new List<string>();
                while (lector.Read())
                {
                    lista.Add(Convert.ToString(lector["idDeporte"])+" - "+ lector["nombreDeporte"]);
                }
                lista.Sort();
                datos.Close();
                return lista;
            }

            public void eliminarDeporte ()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("delete from Deporte where nombreDeporte = @vnombre", datos);
                comando.Parameters.AddWithValue("@vnombre", nombreDeporte);

                comando.ExecuteNonQuery();
                datos.Close();
            }
        }

        public class Evento
        {
            public string fecha { get; set; }
            public int hora { get; set; }
            public int idDeporte { get; set; }
            public int resultado { get; set; }

            public Evento () { }
            public Evento (string fecha, int hora, int idDeporte, int resultado)
            {
                this.fecha = fecha;
                this.hora = hora;
                this.idDeporte = idDeporte;
                this.resultado = resultado;

            }

            public bool autenticacionEvento ()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("Select hora, fecha from Evento where hora = @vhora AND fecha = @vfecha", datos);
                comando.Parameters.AddWithValue("@vhora", hora);
                comando.Parameters.AddWithValue("@vfecha", fecha);

                MySqlDataReader lector = comando.ExecuteReader();
                bool a = lector.Read();
                datos.Close();

                return a;
            }

            public void agregarEvento ()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("insert into Evento (hora, fecha, resultado) value (@vhora, @vfecha, @vresultado);", datos);
                comando.Parameters.AddWithValue("@vhora", hora);
                comando.Parameters.AddWithValue("@vfecha", fecha);
                comando.Parameters.AddWithValue("@vresultado", resultado);

                comando.ExecuteNonQuery();
                datos.Close();
            }


        }


        public class Equipo
        {
            public string nombreEquipo { get; set; }

            public Equipo () { }
            public Equipo (string nombreEquipo)
            {
                this.nombreEquipo = nombreEquipo;
            }

            public bool autenticacionEquipo (int x)
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("Select nombreEquipo, idDeporte from Equipo where nombreEquipo = @vequipo AND idDeporte = @vdeporte", datos);
                comando.Parameters.AddWithValue("@vequipo", nombreEquipo);
                comando.Parameters.AddWithValue("@vdeporte", x);

                MySqlDataReader lector = comando.ExecuteReader();
                bool a = lector.Read();
                datos.Close();

                return a;
            }

            public void agregarEquipo (int x) 
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("insert into Equipo (idEvento, idDeporte, nombreEquipo) value (@vevento, @vdeporte, @vnombre);", datos);
                comando.Parameters.AddWithValue("@vevento", 1);
                comando.Parameters.AddWithValue("@vdeporte", x);
                comando.Parameters.AddWithValue("@vnombre", nombreEquipo);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public List<string> mostrarEquipo()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("select idEquipo, nombreEquipo, nombreDeporte from Equipo a, Deporte b where a.idDeporte = b.idDeporte", datos);
                MySqlDataReader lector = comando.ExecuteReader();

                List<string> lista = new List<string>();
                while (lector.Read())
                {
                    lista.Add(Convert.ToString(lector["idEquipo"]) + " - " + lector["nombreEquipo"] + " - " + lector["nombreDeporte"]);
                }
                lista.Sort();
                datos.Close();
                return lista;
            }

            public void eliminarEquipo (int x)
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("delete from Equipo where idDeporte = @vdeporte AND nombreEquipo = @vnombre;", datos);
                comando.Parameters.AddWithValue("@vdeporte", x);
                comando.Parameters.AddWithValue("@vnombre", nombreEquipo);

                comando.ExecuteNonQuery();
                datos.Close();
            }
        }

        public class Deportista
        {
            public int edad { get; set; }
            public int nroCamiseta { get; set; }
            public string nombreJugador{ get; set; }

            public Deportista () { }
            public Deportista (int edad, int nroCamiseta, string nombreJugador)
            {
                this.edad = edad;
                this.nroCamiseta = nroCamiseta;
                this.nombreJugador = nombreJugador;
            }
        }

    
    }
}