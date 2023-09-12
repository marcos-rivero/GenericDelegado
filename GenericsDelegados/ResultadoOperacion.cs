namespace GenericsDelegados
{
    internal class ResultadoOperacion<T> where T : class, new()
    {
        public bool Exitoso => ListaDeMensaje.Any();
        public List<string> ListaDeMensaje { get; set; }
        public T Contenido { get; set; }
        public ResultadoOperacion()
        {
            ListaDeMensaje = new List<string>();
        }

        public void AgregarMensaje(string mensaje){
            ListaDeMensaje.Add(mensaje);
        }
        public void AsigneExitoso(T contenido) { 
            Contenido = contenido;
        }
    }    
}
