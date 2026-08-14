namespace SolucionCapas.Datos
{
    public class PersonaDatos
    {
        private List<(string Dni, string Nombre, string Telefono, string Direccion, string Ciudad)> _tablaPersonas = new List<(string, string, string, string, string)>
        {
            ("23269431", "Alberto", "1176879654", "Sarmiento 1710", "Buenos Aires"),
            ("27576691", "Noemi", "1127389264", "Alvarado 697", "Salta")
        };

        public (string Dni, string Nombre, string Telefono, string Direccion, string Ciudad)? BuscarPorDni(string dni)
        {
            var resultado = _tablaPersonas.FirstOrDefault(p => p.Dni == dni);
            if (resultado.Dni == null) return null;
            return resultado;
        }

    }
}
