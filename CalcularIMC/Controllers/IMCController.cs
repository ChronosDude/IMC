using Microsoft.AspNetCore.Mvc;
using CalcularIMC.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

/*  Universidad Tecnologica Metropolitana
    Materia: Aplicaciones Web Orientadas a Servicios
    Maestro: Chuc Uc Joel Ivan
    Actividad 2, Ejercicio 1: IMC
    Alumno: Ac Ku Jimmi Leonel
    Cuatrimestre: 4
    Grupo: A
    Primer Parcial
*/

namespace CalcularIMC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IMCController : ControllerBase
    {
        public string Post (DatosPersona datos)
        {
            string mensajefinal = "";

            double imc = Math.Round((datos.peso / Math.Pow((datos.altura/100), 2)),2,MidpointRounding.ToEven);

            if (imc  < 18.5)
            {
                mensajefinal = " tu peso es menor a lo normal";
            }

            if (imc>=18.5 && imc<=24.9)
            {
               mensajefinal = " tu peso esta bien";
            }

            if (imc >= 25 && imc <= 29.9)
            {
                mensajefinal = " superior a lo normal";
            }

            if (imc > 30)
            {
                mensajefinal = " sobrepeso";
            }

            return "tu IMC es " + imc.ToString() + mensajefinal;
        }
    }
}