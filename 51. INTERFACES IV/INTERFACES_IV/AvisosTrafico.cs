namespace INTERFACES_IV
{
    using System;

    class AvisosTrafico : IAvisos
    {
        // Campos de clase
        // ---------------
        private string remitente;
        private string mensaje;
        private string fecha;

        public AvisosTrafico()
        {
            remitente = "DGT";
            mensaje = "Sancion cometida. Pague antes de tres dias y se beneficiara de una reduccion en la sanciion del 50%";
            fecha = "";
        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;

        }
        public string getFecha() => fecha;
        
        public void mostrarAviso()
        {
            Console.WriteLine("Mensaje {0} ha sido enviado por la {1} el dia {2}", mensaje, remitente, fecha);
        }
    }
}
