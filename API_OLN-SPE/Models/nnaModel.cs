namespace API_OLN_SPE.Models
{
    public class nnaModel
    {
        public string rut { get; set; }
        public string codnino { get; set; }
        public DateTime fechaIngreso { get; set; }
        public DateTime fechaEgreso { get; set; }
        public int codProyecto { get; set; }
        public string nombreProyecto { get; set; }
        public int tipoProyecto { get; set; }
        public string tipo_Proyecto { get; set; }
        public int codModeloIntervencion { get; set; }
        public string modelo { get; set; }
        public int icodie { get; set; }
        public string primerCausalIngreso { get; set; }
        public string causalEgreso { get; set; }
        public string enteDerivante { get; set; }

    }
}


