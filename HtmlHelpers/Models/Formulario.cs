using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HtmlHelpers.Models
{
    public class Formulario
    {
        private String cedula;
        private String nombre;
        private String apellido;
        private int edad;
        private String telefono;
        private String correo;
        private  Gender genero;
        private String estado_civil;
        private bool hobbys;

        [Required(ErrorMessage = "The field is required.")]
        public String Cedula { get; set; }
        [Required(ErrorMessage = "The  field is required.")]
        public String Nombre { get => nombre; set => nombre = value; }
        [Required(ErrorMessage = "The  field is required.")]
        public String Apellido { get => apellido; set => apellido = value; }
        [Range(15,100)]
        public int Edad { get => edad; set => edad = value; }
        public String Telefono { get => telefono; set => telefono = value; }
        [EmailAddress(ErrorMessage = "The  email is required.")]
        public String Correo { get; set; }
        public Gender Genero { get => genero; set => genero = value; }
        [Display(Name ="Estado Civil")]
        public String Estado_Civil { get => estado_civil; set => estado_civil = value; }
        public bool Hobby1 { get ; set; }
        public bool Hobby2 { get ; set; }
        public bool Hobby3 { get ; set; }
        public bool Hobby4 { get ; set; }

    }
    public enum Gender
{
    Hombre,
    Mujer
}
    
   
}


