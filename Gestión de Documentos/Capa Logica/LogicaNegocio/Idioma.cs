﻿namespace Manejo_registros.Capa_Logica.LogicaNegocio
{
    public class Idioma
    {
        protected int idioma_id;
        protected string idioma_nombre;
        protected string idioma_iniciales;
        protected string idioma_estado;

        public Idioma()
        {

        }

        public Idioma(string idioma_nombre, string idioma_iniciales, string idioma_estado)
        {
            this.idioma_id = 0;
            this.idioma_nombre = idioma_nombre;
            this.idioma_iniciales = idioma_iniciales;
            this.idioma_estado = idioma_estado;
        }

        public Idioma(int idioma_id, string idioma_nombre, string idioma_iniciales, string idioma_estado)
        {
            this.idioma_id = idioma_id;
            this.idioma_nombre = idioma_nombre;
            this.idioma_iniciales = idioma_iniciales;
            this.idioma_estado = idioma_estado;
        }

        public int Idioma_id { get => idioma_id; set => idioma_id = value; }
        public string Idioma_nombre { get => idioma_nombre; set => idioma_nombre = value; }
        public string Idioma_iniciales { get => idioma_iniciales; set => idioma_iniciales = value; }
        public string Idioma_estado { get => idioma_estado; set => idioma_estado = value; }
    }
}
