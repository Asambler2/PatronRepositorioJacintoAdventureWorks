namespace AdventureWorks.ViewModel
{
    public class ClaseResumen
    {
        public int Id { get; set; }
        public string NombreColor { get; set; }
        public List<ClaseHija> hijas { get; set; }
    }

    public class ClaseHija
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}
