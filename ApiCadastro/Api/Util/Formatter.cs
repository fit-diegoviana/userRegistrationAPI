using System.Text.RegularExpressions;

namespace ApiCadastro.Api.Util;

public class Formatter
{
    public static string RemoveMask(string value)
    {
        return Regex.Replace(value, @"[^\d]", "");
    }
}