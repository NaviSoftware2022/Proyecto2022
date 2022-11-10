using System;
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

        static MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root; password=root");
        HomeVIP userV = new HomeVIP();

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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
                MySqlCommand comando = new MySqlCommand("Select correo from Usuario where correo = @vcorreo", datos);
                comando.Parameters.AddWithValue("@vcorreo", correo);

                MySqlDataReader lector = comando.ExecuteReader();
                bool a = lector.Read();

                if (a)
                {
                    JAGSport.Home.datosLog = lector["correo"].ToString();
                    JAGSport.FormVariable.eventosProximos.correo = lector["correo"].ToString();
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
                    JAGSport.FormVariable.eventosProximos.correo = lector["correo"].ToString();
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
                    JAGSport.FormVariable.eventosProximos.correo = lector["correo"].ToString();
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

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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

                if (a)
                {
                    JAGSport.Home.datosLog = lector["correo"].ToString();
                    JAGSport.FormVariable.eventosProximos.correo = lector["correo"].ToString();
                }
                datos.Close();

                return a;
            }

            public bool autenticacion()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("Select correo from Miembro where correo = @vcorreo", datos);
                comando.Parameters.AddWithValue("@vcorreo", correo);

                MySqlDataReader lector = comando.ExecuteReader();
                bool a = lector.Read();

                if (a)
                {
                    JAGSport.Home.datosLog = lector["correo"].ToString();
                    JAGSport.FormVariable.eventosProximos.correo = lector["correo"].ToString();
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

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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
                MySqlCommand comando = new MySqlCommand("Select correo from admin where correo = @vcorreo", datos);
                comando.Parameters.AddWithValue("@vcorreo", correo);

                MySqlDataReader lector = comando.ExecuteReader();
                bool a = lector.Read();
                datos.Close();

                return a;
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public class Deporte
        {
            public string nombreDeporte { get; set; }

            public Deporte() { }
            public Deporte(string nombreDeporte)
            {
                this.nombreDeporte = nombreDeporte;
            }

            public string ID()
            {
                string a = "vacio";
                datos.Open();
                MySqlCommand comando = new MySqlCommand("Select idDeporte from Deporte where nombreDeporte = @vequipo", datos);
                comando.Parameters.AddWithValue("@vequipo", nombreDeporte);

                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    a = Convert.ToString(lector["idDeporte"]);
                }

                datos.Close();

                return a;
            }

            public bool autenticacionDeporte()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("Select nombreDeporte from Deporte where nombreDeporte = @vnombre", datos);
                comando.Parameters.AddWithValue("@vnombre", nombreDeporte);

                MySqlDataReader lector = comando.ExecuteReader();
                bool a = lector.Read();

                datos.Close();

                return a;
            }

            public bool editarDeporte (string x)
            {
                try
                {
                    datos.Open();
                    MySqlCommand comando = new MySqlCommand("update Deporte set nombreDeporte = @name where idDeporte = @id", datos);
                    comando.Parameters.AddWithValue("@name", nombreDeporte);
                    comando.Parameters.AddWithValue("@id", x);

                    MySqlDataReader lector = comando.ExecuteReader();
                    lector.Read();

                    datos.Close();
                    return true;
                }
                catch (Exception)
                {
                    datos.Close();
                    return false;
                }
            }


            public void agregarDeporte()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("insert into Deporte (nombreDeporte) value (@vdeporte);", datos);
                comando.Parameters.AddWithValue("@vdeporte", nombreDeporte);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public List<string> mostrarDeporte()
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
                return lista;
            }

            public List<string> mostrarEquiposDeporte()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("select distinct nombreEquipo from Equipo where deporteName = @a;", datos);
                comando.Parameters.AddWithValue("@a", nombreDeporte);
                MySqlDataReader lector = comando.ExecuteReader();

                List<string> lista = new List<string>();
                while (lector.Read())
                {
                    lista.Add(Convert.ToString(lector["nombreEquipo"]));
                }
                lista.Sort();
                datos.Close();
                return lista;
            }

            public void eliminarDeporte(string x)
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("delete from Deporte where idDeporte = @id", datos);
                comando.Parameters.AddWithValue("@id", x);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public List<string> idEvento (int x)
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("select distinct idEvento from participa where idDeporte = @a;", datos);
                comando.Parameters.AddWithValue("@a", x);
                MySqlDataReader lector = comando.ExecuteReader();

                List<string> lista = new List<string>();
                while (lector.Read())
                {
                    lista.Add(Convert.ToString(lector["idEvento"]));
                }
                lista.Sort();
                datos.Close();
                return lista;
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public class Evento
        {
            public DateTime fecha { get; set; }
            public DateTime hora { get; set; }
            public string deporte { get; set; }
            public int resultado1 { get; set; }
            public int resultado2 { get; set; }
            public string equipo1 { get; set; }
            public string equipo2 { get; set; }

            public Evento() { }
            public Evento(DateTime fecha, DateTime hora, string deporte, int resultado1, int resultado2, string equipo1, string equipo2)
            {
                this.fecha = fecha;
                this.hora = hora;
                this.deporte = deporte;
                this.resultado1 = resultado1;
                this.resultado2 = resultado2;
                this.equipo1 = equipo1;
                this.equipo2 = equipo2;
            }

            public string ID()
            {
                string a = "vacio";
                datos.Open();
                MySqlCommand comando = new MySqlCommand("Select idEvento from Evento where fecha = @a and hora = @b and equipo1 = @c and equipo2 = @d", datos);
                comando.Parameters.AddWithValue("@a", fecha);
                comando.Parameters.AddWithValue("@b", hora);
                comando.Parameters.AddWithValue("@c", equipo1);
                comando.Parameters.AddWithValue("@d", equipo2);

                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    a = Convert.ToString(lector["idEvento"]);
                }

                datos.Close();

                return a;
            }

            public bool autenticacionEvento()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("Select hora, fecha, equipo1, equipo2 from Evento where hora = @a AND fecha = @b AND equipo1 = @c and equipo2 = @d", datos);
                comando.Parameters.AddWithValue("@a", hora);
                comando.Parameters.AddWithValue("@b", fecha);
                comando.Parameters.AddWithValue("@c", equipo1);
                comando.Parameters.AddWithValue("@d", equipo1);

                MySqlDataReader lector = comando.ExecuteReader();
                bool a = lector.Read();
                datos.Close();

                return a;
            }

            public void agregarEvento()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("insert into Evento (fecha, hora, nombreDeporte, resultado1, resultado2, equipo1, equipo2) value (@a, @b, @c, @d, @e, @f, @g );", datos);
                comando.Parameters.AddWithValue("@a", fecha);
                comando.Parameters.AddWithValue("@b", hora);
                comando.Parameters.AddWithValue("@c", deporte);
                comando.Parameters.AddWithValue("@d", resultado1);
                comando.Parameters.AddWithValue("@e", resultado2);
                comando.Parameters.AddWithValue("@f", equipo1);
                comando.Parameters.AddWithValue("@g", equipo2);


                comando.ExecuteNonQuery();
                datos.Close();
            }


            public void eliminarEvento(int x)
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("delete from Evento where idEvento = @idEvento;", datos);
                comando.Parameters.AddWithValue("@idEvento", x);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public void eliminarEventoy(string x)
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("delete from participo where idEvento = @idEvento;", datos);
                comando.Parameters.AddWithValue("@idEvento", x);

                comando.ExecuteNonQuery();
                datos.Close();
            }


        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public class EventoProximo
        {
            public DateTime fecha { get; set; }
            public DateTime hora { get; set; }
            public string deporte { get; set; }
            public string equipo1 { get; set; }
            public string equipo2 { get; set; }

            public EventoProximo() { }
            public EventoProximo(DateTime fecha, DateTime hora, string deporte, string equipo1, string equipo2)
            {
                this.fecha = fecha;
                this.hora = hora;
                this.deporte = deporte;
                this.equipo1 = equipo1;
                this.equipo2 = equipo2;
            }

            public string ID()
            {
                string a = "vacio";
                datos.Open();
                MySqlCommand comando = new MySqlCommand("Select idEvento from Eventofijado where fecha = @a and hora = @b and equipo1 = @c and equipo2 = @d", datos);
                comando.Parameters.AddWithValue("@a", fecha);
                comando.Parameters.AddWithValue("@b", hora);
                comando.Parameters.AddWithValue("@c", equipo1);
                comando.Parameters.AddWithValue("@d", equipo2);

                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    a = Convert.ToString(lector["idEvento"]);
                }

                datos.Close();

                return a;
            }

            public void agregarEvento()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("insert into Eventofijado (fecha, hora, nombreDeporte, equipo1, equipo2) value (@a, @b, @c, @f, @g );", datos);
                comando.Parameters.AddWithValue("@a", fecha);
                comando.Parameters.AddWithValue("@b", hora);
                comando.Parameters.AddWithValue("@c", deporte);
                comando.Parameters.AddWithValue("@f", equipo1);
                comando.Parameters.AddWithValue("@g", equipo2);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public bool autenticacionEvento()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("Select hora, fecha, equipo1, equipo2 from Eventofijado where hora = @a AND fecha = @b AND equipo1 = @c and equipo2 = @d", datos);
                comando.Parameters.AddWithValue("@a", hora);
                comando.Parameters.AddWithValue("@b", fecha);
                comando.Parameters.AddWithValue("@c", equipo1);
                comando.Parameters.AddWithValue("@d", equipo1);

                MySqlDataReader lector = comando.ExecuteReader();
                bool a = lector.Read();
                datos.Close();

                return a;
            }

            public void eliminarEvento(int x)
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("delete from Eventofijado where idEvento = @idEvento;", datos);
                comando.Parameters.AddWithValue("@idEvento", x);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public void eliminarEventoy(string x)
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("delete from participoFijado where idEvento = @idEvento;", datos);
                comando.Parameters.AddWithValue("@idEvento", x);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public List<DateTime> obtenerFecha ()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("select fecha from eventofijado", datos);
                MySqlDataReader lector = comando.ExecuteReader();

                List<DateTime> lista = new List<DateTime>();
                while (lector.Read())
                {
                    lista.Add(Convert.ToDateTime(lector["fecha"]));
                }
                datos.Close();
                return lista;
            }

            public List<DateTime> obtenerHora()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("select hora from eventofijado", datos);
                MySqlDataReader lector = comando.ExecuteReader();

                List<DateTime> lista = new List<DateTime>();
                while (lector.Read())
                {
                    string a = lector["hora"].ToString();
                    lista.Add(Convert.ToDateTime(a));
                }
                datos.Close();
                return lista;
            }

            public List<string> obtenerID()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("select idEvento from eventofijado", datos);
                MySqlDataReader lector = comando.ExecuteReader();

                List<string> lista = new List<string>();
                while (lector.Read())
                {
                    lista.Add(Convert.ToString(lector["idEvento"]));
                }
                datos.Close();
                return lista;
            }

        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public class Participa
        {
            public int idEquipo { get; set; }
            public int idEvento { get; set; }
            public int idDeporte { get; set; }

            public Participa() { }
            public Participa(int idEquipo, int idEvento, int idDeporte)
            {
                this.idEquipo = idEquipo;
                this.idEvento = idEvento;
                this.idDeporte = idDeporte;
            }

            public void agregarParticipa()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("insert into Participa (idEvento, idDeporte, idEquipo) value (@idEvento, @idDeporte, @idEquipo);", datos);
                comando.Parameters.AddWithValue("@idEvento", idEvento);
                comando.Parameters.AddWithValue("@idEquipo", idEquipo);
                comando.Parameters.AddWithValue("@idDeporte", idDeporte);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public void eliminarParticipa()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("delete from participa where idEvento = @a;", datos);
                comando.Parameters.AddWithValue("@a", idEvento);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public void eliminarParticipaDeporte()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("delete from participa where idDeporte = @a;", datos);
                comando.Parameters.AddWithValue("@a", idDeporte);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public List<string> mostrarEquipos()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("select idEquipo from Participa where idEvento = @id", datos);
                comando.Parameters.AddWithValue("@id", idEvento);
                MySqlDataReader lector = comando.ExecuteReader();

                List<string> lista = new List<string>();
                while (lector.Read())
                {
                    lista.Add(Convert.ToString(lector["idEquipo"]));
                }
                lista.Sort();
                datos.Close();
                return lista;
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public class ParticipaFijado
        {
            public int idEquipo { get; set; }
            public int idEvento { get; set; }
            public int idDeporte { get; set; }

            public ParticipaFijado() { }
            public ParticipaFijado(int idEquipo, int idEvento, int idDeporte)
            {
                this.idEquipo = idEquipo;
                this.idEvento = idEvento;
                this.idDeporte = idDeporte;
            }

            public void agregarParticipa()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("insert into ParticipaFijado (idEvento, idDeporte, idEquipo) value (@idEvento, @idDeporte, @idEquipo);", datos);
                comando.Parameters.AddWithValue("@idEvento", idEvento);
                comando.Parameters.AddWithValue("@idEquipo", idEquipo);
                comando.Parameters.AddWithValue("@idDeporte", idDeporte);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public void eliminarParticipa()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("delete from participaFijado where idEvento = @a;", datos);
                comando.Parameters.AddWithValue("@a", idEvento);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public void eliminarParticipaDeporte()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("delete from participaFijado where idDeporte = @a;", datos);
                comando.Parameters.AddWithValue("@a", idDeporte);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public List<string> mostrarEquipos()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("select idEquipo from ParticipaFijado where idEvento = @id", datos);
                comando.Parameters.AddWithValue("@id", idEvento);
                MySqlDataReader lector = comando.ExecuteReader();

                List<string> lista = new List<string>();
                while (lector.Read())
                {
                    lista.Add(Convert.ToString(lector["idEquipo"]));
                }
                lista.Sort();
                datos.Close();
                return lista;
            }

        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public class Equipo
        {
            public string nombreEquipo { get; set; }
            public string zona { get; set; }

            public Equipo() { }
            public Equipo(string nombreEquipo, string zona)
            {
                this.nombreEquipo = nombreEquipo;
                this.zona = zona;
            }

            public string ID ()
            {
                string a = "vacio";
                datos.Open();
                MySqlCommand comando = new MySqlCommand("Select idEquipo from Equipo where nombreEquipo = @vequipo and zona = @z", datos);
                comando.Parameters.AddWithValue("@vequipo", nombreEquipo);
                comando.Parameters.AddWithValue("@z", zona);

                MySqlDataReader lector = comando.ExecuteReader();
                if(lector.Read())
                {
                    a = Convert.ToString(lector["idEquipo"]);
                }
                
                datos.Close();

                return a;
            }

            public string nombreEquipoObtener (string x)
            {
                string a = "vacio";
                datos.Open();
                MySqlCommand comando = new MySqlCommand("select nombreEquipo from Equipo where deporteName = @a;", datos);
                comando.Parameters.AddWithValue("@a", x);

                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    a = Convert.ToString(lector["nombreEquipo"]);
                }

                datos.Close();

                return a;
            }

            public bool autenticacionEquipo()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("Select nombreEquipo from Equipo where nombreEquipo = @vequipo and zona = @z", datos);
                comando.Parameters.AddWithValue("@vequipo", nombreEquipo);
                comando.Parameters.AddWithValue("@z", zona);

                MySqlDataReader lector = comando.ExecuteReader();
                bool a = lector.Read();
                datos.Close();

                return a;
            }

            public bool autenticacionEquipoID(int x)
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("Select idDeporte from Deporte where idDeporte = @vequipo", datos);
                comando.Parameters.AddWithValue("@vequipo", x);


                MySqlDataReader lector = comando.ExecuteReader();
                bool a = lector.Read();
                datos.Close();

                return a;
            }

            public void agregarEquipo(string x)
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("insert into Equipo (nombreEquipo, zona, deporteName) value (@vnombre, @z, @deporte);", datos);
                comando.Parameters.AddWithValue("@vnombre", nombreEquipo);
                comando.Parameters.AddWithValue("@z", zona);
                comando.Parameters.AddWithValue("@deporte", x);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public List<string> mostrarEquipo()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("select distinct nombreEquipo from Equipo", datos);
                MySqlDataReader lector = comando.ExecuteReader();

                List<string> lista = new List<string>();
                while (lector.Read())
                {
                    lista.Add(Convert.ToString(lector["nombreEquipo"]));
                }
                lista.Sort();
                datos.Close();
                return lista;
            }

            public List<string> mostrarZona(string x)
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("select zona from Equipo where nombreEquipo = @t", datos);
                comando.Parameters.AddWithValue("@t", x);
                MySqlDataReader lector = comando.ExecuteReader();

                List<string> lista = new List<string>();
                while (lector.Read())
                {
                    lista.Add(Convert.ToString(lector["zona"]));
                }
                lista.Sort();
                datos.Close();
                return lista;
            }

            public string mostrarZonaID(string x)
            {
                string a = "";
                datos.Open();
                MySqlCommand comando = new MySqlCommand("select zona from equipo where idEquipo = @a", datos);
                comando.Parameters.AddWithValue("@a", x);

                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    a = Convert.ToString(lector["zona"]);
                }

                datos.Close();
                return a;
            }

            public void eliminarEquipo()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("delete from Equipo where nombreEquipo = @a and zona = @z;", datos);
                comando.Parameters.AddWithValue("@a", nombreEquipo);
                comando.Parameters.AddWithValue("@z", zona);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public void eliminarEquipoID(string x)
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("delete from Equipo where idEquipo = @a;", datos);
                comando.Parameters.AddWithValue("@a", x);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public int verificarEquipo(int x)
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("Select idEquipo from Equipo where nombreEquipo = @n AND idDeporte = @i", datos);
                comando.Parameters.AddWithValue("@n", nombreEquipo);
                comando.Parameters.AddWithValue("@i", x);

                int a = Convert.ToInt32(comando.ExecuteScalar());
                datos.Close();

                return a;
            }         

            public List<string> idEvento(int x)
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("select distinct idEvento from participa where idEquipo = @a;", datos);
                comando.Parameters.AddWithValue("@a", x);
                MySqlDataReader lector = comando.ExecuteReader();

                List<string> lista = new List<string>();
                while (lector.Read())
                {
                    lista.Add(Convert.ToString(lector["idEvento"]));
                }
                lista.Sort();
                datos.Close();
                return lista;
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public class Deportista
        {
            public int edad { get; set; }
            public int nroCamiseta { get; set; }
            public string nombreJugador { get; set; }

            public Deportista() { }
            public Deportista(int edad, int nroCamiseta, string nombreJugador)
            {
                this.edad = edad;
                this.nroCamiseta = nroCamiseta;
                this.nombreJugador = nombreJugador;
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

       

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public class Juega
        {
            public string idEquipo { get; set; }
            public string idDeporte { get; set; }

            public Juega() { }
            public Juega(string idEquipo, string idDeporte)
            {
                this.idEquipo = idEquipo;
                this.idDeporte = idDeporte;
            }

            public void agregarJuega()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("insert into juega value (@id1, @id2);", datos);
                comando.Parameters.AddWithValue("@id1", idEquipo);
                comando.Parameters.AddWithValue("@id2", idDeporte);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public void eliminarJuega()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("delete from juega where idEquipo = @a;", datos);
                comando.Parameters.AddWithValue("@a", idEquipo);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public void eliminarJuegaDeporte()
            {
                datos.Open();

                MySqlCommand comando = new MySqlCommand("delete from juega where idDeporte = @a;", datos);
                comando.Parameters.AddWithValue("@a", idDeporte);

                comando.ExecuteNonQuery();   
                datos.Close();
            }

            public void eliminarEquiposConDeporte(string x)
            {
                datos.Open();

                MySqlCommand comando = new MySqlCommand("delete from equipo where deporteName = @a;", datos);
                comando.Parameters.AddWithValue("@a", x);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public List<string> mostrarEquipos()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("select idEquipo from Juega where idDeporte = @id", datos);
                comando.Parameters.AddWithValue("@id", idDeporte);
                MySqlDataReader lector = comando.ExecuteReader();

                List<string> lista = new List<string>();
                while (lector.Read())
                {
                    lista.Add(Convert.ToString(lector["idEquipo"]));
                }
                lista.Sort();
                datos.Close();
                return lista;
            }


        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public class Jugador
        {
            public string nombre { get; set; }
            public string apellido { get; set; }
            public int edad { get; set; }
            public int nroCamiseta { get; set; }
            public string nacionalidad { get; set; }
            public string equipo { get; set; }
            public DateTime nacimiento { get; set; }

            public Jugador() { }
            public Jugador(string nombre, string apellido, int edad, int nroCamiseta, string nacionalidad, string equipo, DateTime nacimiento)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.edad = edad;
                this.nroCamiseta = nroCamiseta;
                this.nacionalidad = nacionalidad;
                this.equipo = equipo;
                this.nacimiento = nacimiento;
            }

            public int ID()
            {
                int a = 0;
                datos.Open();
                MySqlCommand comando = new MySqlCommand("Select idJugador from Jugador where nombre = @a AND apellido = @b AND nacionalidad = @d", datos);
                comando.Parameters.AddWithValue("@a", nombre);
                comando.Parameters.AddWithValue("@b", apellido);
                comando.Parameters.AddWithValue("@d", nacionalidad);


                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                   
                    a = Convert.ToInt32(lector["idJugador"]);
                }

                datos.Close();

                return a;
            }

            public void AgregarJugador()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("insert into jugador (nombre, apellido, edad, nroCamiseta, nacionalidad, equipo, nacimiento) value (@a, @b, @c, @d, @e, @g, @h);", datos);
                comando.Parameters.AddWithValue("@a", nombre);
                comando.Parameters.AddWithValue("@b", apellido);
                comando.Parameters.AddWithValue("@c", edad);
                comando.Parameters.AddWithValue("@d", nroCamiseta);
                comando.Parameters.AddWithValue("@e", nacionalidad);
                comando.Parameters.AddWithValue("@g", equipo);
                comando.Parameters.AddWithValue("@h", nacimiento);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public void eliminarJugador()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("delete from Jugador where nombre = @a AND apellido = @b AND nacimiento = @c AND nacionalidad = @d;", datos);
                comando.Parameters.AddWithValue("@a", nombre);
                comando.Parameters.AddWithValue("@b", apellido);
                comando.Parameters.AddWithValue("@c", nacimiento);
                comando.Parameters.AddWithValue("@d", nacionalidad);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public void eliminarJugadorID (string x)
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("delete from Jugador where idJugador = @id;", datos);
                comando.Parameters.AddWithValue("@id", x);
  
                comando.ExecuteNonQuery();
                datos.Close();
            }


        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public class Integra
        {
            public int idJugador { get; set; }
            public int idEquipo { get; set; }

            public Integra () { }
            public Integra (int idJugador, int idEquipo)
            {
                this.idJugador = idJugador;
                this.idEquipo = idEquipo;
            }

            public void agregarIntegra ()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("insert into Integra (idJugador, idEquipo) value (@id1, @id2);", datos);
                comando.Parameters.AddWithValue("@id1", idJugador);
                comando.Parameters.AddWithValue("@id2", idEquipo);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public void eliminarIntegra ()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("delete from integra where idJugador = @a;", datos);
                comando.Parameters.AddWithValue("@a", idJugador);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public void eliminarIntegraEquipo (string x)
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("delete from integra where idEquipo = @a;", datos);
                comando.Parameters.AddWithValue("@a", x);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public string mostrarEquipo ()
            {
                string a = "";
                datos.Open();
                MySqlCommand comando = new MySqlCommand("select idEquipo from integra where idJugador = @a", datos);
                comando.Parameters.AddWithValue("@a", idJugador);

                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    a = Convert.ToString(lector["idEquipo"]);
                }

                datos.Close();
                return a;
            }

            public string mostrarJugador ()
            {
                string a = "";
                datos.Open();
                MySqlCommand comando = new MySqlCommand("select idJugador from integra where idEquipo = @a", datos);
                comando.Parameters.AddWithValue("@a", idEquipo);

                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    a = Convert.ToString(lector["idJugador"]);
                }

                datos.Close();
                return a;
            }

            public List<string> mostrarJugadores()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("Select idJugador from integra where idEquipo = @idteam", datos);
                comando.Parameters.AddWithValue("@idteam", idEquipo);
                MySqlDataReader lector = comando.ExecuteReader();

                List<string> list = new List<string>();
                while (lector.Read())
                {
                    list.Add(Convert.ToString(lector["idJugador"]));
                }
                datos.Close();
                return list;
            }

           
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public class Publicidad1
        {


            public string Nombre { get; set; }
            public string Imagen { get; set; }

            public Publicidad1() { }
            public Publicidad1(string Nombre, string Imagen)
            {

                this.Nombre = Nombre;
                this.Imagen = Imagen;
            }



            public void agregarPublicidad1()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("insert into Publicidad1 (Nombre, Imagen) value (@nom, @img);", datos);
                comando.Parameters.AddWithValue("@nom", Nombre);
                comando.Parameters.AddWithValue("@img", Imagen);

                comando.ExecuteNonQuery();
                datos.Close();
            }

            public void eliminarPublicidad1()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("delete from Publicidad1 where Nombre = @nom", datos);
                comando.Parameters.AddWithValue("@nom", this.Nombre);
                comando.Parameters.AddWithValue("@img", this.Imagen);


                comando.ExecuteNonQuery();
                datos.Close();
            }

            public List<string> mostrarPublicidad1()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("Select Imagen from Publicidad", datos);
                MySqlDataReader lector = comando.ExecuteReader();

                List<string> listaPubli = new List<string>();
                while (lector.Read())
                {
                    listaPubli.Add(Convert.ToString(lector["Imagen"]));
                    listaPubli.Sort();
                }
                datos.Close();
                return listaPubli;
            }

        }

        public class suscribe
        {
            public string correo { get; set; }
            public string idEvento { get; set; }

            public suscribe() { }
            public suscribe(string correo, string idEvento)
            {
                this.correo = correo;
                this.idEvento = idEvento;
            }

            public bool autenticacionSub()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("Select correo from suscribe where idEvento = @id and correo = @correo", datos);
                comando.Parameters.AddWithValue("@id", idEvento);
                comando.Parameters.AddWithValue("@correo", correo);

                MySqlDataReader lector = comando.ExecuteReader();
                bool a = lector.Read();

                datos.Close();

                return a;
            }

            public void agregarSub()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("insert into suscribe (correo, idEvento) value (@a, @b)", datos);
                comando.Parameters.AddWithValue("@a", correo);
                comando.Parameters.AddWithValue("@b", idEvento);

                comando.ExecuteNonQuery();

                datos.Close();
            }

            public void eliminarsub()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("delete from suscribe where idEvento = @id", datos);
                comando.Parameters.AddWithValue("@id", idEvento);

                comando.ExecuteNonQuery();

                datos.Close();
            }

            public List<string> mostrarUsuarios()
            {
                datos.Open();
                MySqlCommand comando = new MySqlCommand("Select correo from suscribe where idEvento = @id", datos);
                comando.Parameters.AddWithValue("@id", idEvento);
                MySqlDataReader lector = comando.ExecuteReader();

                List<string> correos = new List<string>();
                while (lector.Read())
                {
                    correos.Add(Convert.ToString(lector["correo"]));
                }
                datos.Close();
                return correos;
            }
        }
    }
}
