﻿namespace Ucu.Poo.TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat(string date)
    {
        DateTime dateValue;
        if (string.IsNullOrWhiteSpace(date))
        {
            return "Formato incorrecto";
        } 
        
        else if(date.Length != 10)
        {
            return "Formato incorrecto";
        } 
        else 
        {
            return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
        }
         /* {     
            if (DateTime.TryParse(date, out dateValue))          
                return dateValue.ToString("yyyy-MM-dd");    
            else
                return "  Unable to parse ";
        } */
    }
}
