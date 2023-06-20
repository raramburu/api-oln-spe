using API_OLN_SPE.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace API_OLN_SPE.Data
{
    public class NnaData
    {
        // este metodo se ocupo de prueba.
        public static ClienteModel Getnna(string rut)
        {
            ClienteModel olistarnna = new ClienteModel();
            using (SqlConnection oConexion = new SqlConnection(Conexion.connectionString))
            {
                SqlCommand cmd = new SqlCommand("Get_NinoxRut", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@param_rut", rut);
                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            olistarnna = new ClienteModel()
                            {
                                Nombre = dr["Nombres"].ToString(),
                                ApellidoP = dr["Apellido_Paterno"].ToString(),
                                ApellidoA = dr["Apellido_Materno"].ToString()
                            };
                        }
                        return olistarnna;
                    }
                }
                catch (Exception ex)
                { return olistarnna; }
            }
        }     
        public static List<nnaModel> ListNNA(string rut)
        {           
            List<nnaModel> list = new List<nnaModel>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.connectionString))
            {
                SqlCommand cmd = new SqlCommand("OLN-SPE-API", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("rut", rut);
                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                 
                    using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while(dr.Read())
                        {
                            var nna = new nnaModel()
                            {
                                rut = dr["rut"].ToString(),
                                codnino = dr["codnino"].ToString(),
                                fechaIngreso = Convert.ToDateTime(dr["fechaingreso"].ToString()),
                                fechaEgreso = Convert.ToDateTime(dr["fechaEgreso"].ToString()),
                                codProyecto = Convert.ToInt32(dr["codproyecto"].ToString()),
                                nombreProyecto = dr["NombreProyecto"].ToString(),
                                tipoProyecto = Convert.ToInt32(dr["TipoProyecto"].ToString()),
                                tipo_Proyecto = dr["Tipo_Proyecto"].ToString(),
                                codModeloIntervencion = Convert.ToInt32(dr["codmodeloIntervencion"].ToString()),
                                modelo = dr["Modelo"].ToString(),
                                icodie = Convert.ToInt32(dr["icodie"].ToString()),
                                primerCausalIngreso = dr["1°CausaldeIngreso"].ToString(),
                                causalEgreso = dr["CausaldeEgreso"].ToString(),
                                enteDerivante = dr["EnteDerivante"].ToString()

                            };
                            list.Add(nna);
                        }
                        return list;
                    }
                    
                }
                catch(Exception ex)
                { return list; }
            }

        }
    }
}
