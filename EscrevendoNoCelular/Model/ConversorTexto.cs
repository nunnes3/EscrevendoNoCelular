using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoNoCelular
{
    public class ConversorTexto
    {
        private string recebeMensagem;
        Dictionary<string, string> dicionarioLetras;


        public void preenchendoDicionario()
        {
            dicionarioLetras = new Dictionary<string, string>();

            dicionarioLetras.Add("A", "2");
            dicionarioLetras.Add("B", "2");
            dicionarioLetras.Add("C", "2");
            dicionarioLetras.Add("D", "3");
            dicionarioLetras.Add("E", "3");
            dicionarioLetras.Add("F", "3");
            dicionarioLetras.Add("G", "4");
            dicionarioLetras.Add("H", "4");
            dicionarioLetras.Add("I", "4");
            dicionarioLetras.Add("J", "5");
            dicionarioLetras.Add("K", "5");
            dicionarioLetras.Add("L", "5");
            dicionarioLetras.Add("M", "6");
            dicionarioLetras.Add("N", "6");
            dicionarioLetras.Add("O", "6");
            dicionarioLetras.Add("P", "7");
            dicionarioLetras.Add("Q", "7");
            dicionarioLetras.Add("R", "7");
            dicionarioLetras.Add("S", "7");
            dicionarioLetras.Add("T", "8");
            dicionarioLetras.Add("U", "8");
            dicionarioLetras.Add("V", "8");
            dicionarioLetras.Add("W", "9");
            dicionarioLetras.Add("X", "9");
            dicionarioLetras.Add("Y", "9");
            dicionarioLetras.Add("Z", "9");
            dicionarioLetras.Add(" ", "0");
        }

        public string RetornandoUnderLine( string underline)
        {

            if (underline == "A")
            {
                return underline = dicionarioLetras["A"];
            }
            else if (underline == "B")
            {
                return underline = dicionarioLetras["B"] ;
            }
            else if (underline == "C")
            {
                return underline = dicionarioLetras["C"] ;
            }
            if (underline == "D")
            {
                return underline = dicionarioLetras["D"];
            }
            else if (underline == "E")
            {
                return underline = dicionarioLetras["E"];
            }
            else if (underline == "F")
            {
                return underline = dicionarioLetras["F"];
            }

            if (underline == "G")
            {
                return underline = dicionarioLetras["G"];
            }
            else if (underline == "H")
            {
                return underline = dicionarioLetras["H"];
            }
            else if (underline == "I")
            {
                return underline = dicionarioLetras["I"];
            }
            if (underline == "J")
            {
                return underline = dicionarioLetras["J"];
            }
            else if (underline == "K")
            {
                return underline = dicionarioLetras["K"];
            }
            else if (underline == "L")
            {
                return underline = dicionarioLetras["L"];
            }

            if (underline == "M")
            {
                return underline = dicionarioLetras["M"];
            }
            else if (underline == "N")
            {
                return underline = dicionarioLetras["N"];
            }
            else if (underline == "O")
            {
                return underline = dicionarioLetras["O"];
            }
            if (underline == "P")
            {
                return underline = dicionarioLetras["P"];
            }
            else if (underline == "Q")
            {
                return underline = dicionarioLetras["Q"];
            }
            else if (underline == "R")
            {
                return underline = dicionarioLetras["R"];
            }
            else if (underline == "S")
            {
                return underline = dicionarioLetras["S"];
            }
            if (underline == "T")
            {
                return underline = dicionarioLetras["T"];
            }
            else if (underline == "U")
            {
                return underline = dicionarioLetras["U"];
            }
            else if (underline == "V")
            {
                return underline = dicionarioLetras["V"];
            }

            if (underline == "W")
            {
                return underline = dicionarioLetras["W"];

            }
            else if (underline == "X")
            {
                return underline = dicionarioLetras["X"];
            }
            else if (underline == "Y")
            {
                return underline = dicionarioLetras["Y"];
            }
            else if (underline == "Z")
            {
                return underline = dicionarioLetras["Z"];
            }

            if (underline == " ")
            {
                return underline = dicionarioLetras[" "];
            }
            return underline;
        }

        public string converterMensagem(string mensagem)
        {
            
            int ultimaLetra = mensagem.Length - 2;
            string resultadoConsulta = String.Empty;
            string resultadoFinal = String.Empty;
            string underLine = String.Empty;
            string resultadoConsultaIfem = String.Empty;
            preenchendoDicionario();


            if(mensagem.Length > 255)
            {
                return resultadoFinal = "Limite inválido";
            }


            for (int i = 0; i < mensagem.Length; i++)
            {

                if(i <= mensagem.Length - 1)
                {
                    resultadoConsulta = mensagem.Substring(i, 1);
                }

                if ( i <= ultimaLetra)
                {
                    
                    underLine = mensagem.Substring(i + 1, 1);
                    resultadoConsultaIfem = RetornandoUnderLine(underLine);
                }
                
                
                if(resultadoConsulta == "A" )
                {
                    resultadoFinal += dicionarioLetras["A"];
                    resultadoConsulta =dicionarioLetras["A"];
                }
                else if (resultadoConsulta == "B" )
                {
                    resultadoFinal += dicionarioLetras["B"] + dicionarioLetras["B"] ;
                    resultadoConsulta = dicionarioLetras["A"];
                }
                else if (resultadoConsulta == "C" )
                {
                    resultadoFinal += dicionarioLetras["C"] + dicionarioLetras["C"] + dicionarioLetras["C"];
                    resultadoConsulta = dicionarioLetras["A"];
                }

                if (resultadoConsulta == "D")
                {
                    resultadoFinal += dicionarioLetras["D"];
                    resultadoConsulta = dicionarioLetras["D"];
                }
                else if (resultadoConsulta == "E")
                {
                    resultadoFinal += dicionarioLetras["E"] + dicionarioLetras["E"];
                    resultadoConsulta = dicionarioLetras["E"];
                }
                else if (resultadoConsulta == "F")
                {
                    resultadoFinal += dicionarioLetras["F"] + dicionarioLetras["F"] + dicionarioLetras["F"];
                    resultadoConsulta = dicionarioLetras["F"];
                }

                if (resultadoConsulta == "G")
                {
                    resultadoFinal += dicionarioLetras["G"];
                    resultadoConsulta = dicionarioLetras["G"];
                }
                else if (resultadoConsulta == "H")
                {
                    resultadoFinal += dicionarioLetras["H"] + dicionarioLetras["H"];
                    resultadoConsulta = dicionarioLetras["H"];
                }
                else if (resultadoConsulta == "I")
                {
                    resultadoFinal += dicionarioLetras["I"] + dicionarioLetras["I"] + dicionarioLetras["I"];
                    resultadoConsulta = dicionarioLetras["I"];
                }

                if (resultadoConsulta == "J")
                {
                    resultadoFinal += dicionarioLetras["J"];
                    resultadoConsulta = dicionarioLetras["J"];
                }
                else if (resultadoConsulta == "K")
                {
                    resultadoFinal += dicionarioLetras["K"] + dicionarioLetras["K"];
                    resultadoConsulta = dicionarioLetras["K"];
                }
                else if (resultadoConsulta == "L")
                {
                    resultadoFinal += dicionarioLetras["L"] + dicionarioLetras["L"] + dicionarioLetras["L"];
                    resultadoConsulta = dicionarioLetras["L"];
                }

                if (resultadoConsulta == "M")
                {
                    resultadoFinal += dicionarioLetras["M"];
                    resultadoConsulta = dicionarioLetras["M"];
                }
                else if (resultadoConsulta == "N")
                {
                    resultadoFinal += dicionarioLetras["N"] + dicionarioLetras["N"];
                    resultadoConsulta = dicionarioLetras["N"];
                }
                else if (resultadoConsulta == "O")
                {
                    resultadoFinal += dicionarioLetras["O"] + dicionarioLetras["O"] + dicionarioLetras["O"];
                    resultadoConsulta = dicionarioLetras["O"];
                }

                if (resultadoConsulta == "P")
                {
                    resultadoFinal += dicionarioLetras["P"];
                    resultadoConsulta = dicionarioLetras["P"];
                }
                else if (resultadoConsulta == "Q")
                {
                    resultadoFinal += dicionarioLetras["Q"] + dicionarioLetras["Q"];
                    resultadoConsulta = dicionarioLetras["Q"];
                }
                else if (resultadoConsulta == "R")
                {
                    resultadoFinal += dicionarioLetras["R"] + dicionarioLetras["R"] + dicionarioLetras["R"];
                    resultadoConsulta = dicionarioLetras["R"];
                }
                else if (resultadoConsulta == "S")
                {
                    resultadoFinal += dicionarioLetras["S"] + dicionarioLetras["S"] + dicionarioLetras["S"] + dicionarioLetras["S"] ;
                    resultadoConsulta = dicionarioLetras["S"];
                }
                if (resultadoConsulta == "T")
                {
                    resultadoFinal += dicionarioLetras["T"];
                    resultadoConsulta = dicionarioLetras["T"];
                }
                else if (resultadoConsulta == "U")
                {
                    resultadoFinal += dicionarioLetras["U"] + dicionarioLetras["U"];
                    resultadoConsulta = dicionarioLetras["U"];
                }
                else if (resultadoConsulta == "V")
                {
                    resultadoFinal += dicionarioLetras["V"] + dicionarioLetras["V"] + dicionarioLetras["V"];
                    resultadoConsulta = dicionarioLetras["V"];
                }
                if (resultadoConsulta == "W")
                {
                    resultadoFinal += dicionarioLetras["W"];
                    resultadoConsulta = dicionarioLetras["W"];
                }
                else if (resultadoConsulta == "X")
                {
                    resultadoFinal += dicionarioLetras["X"] + dicionarioLetras["X"];
                    resultadoConsulta = dicionarioLetras["X"];
                }
                else if (resultadoConsulta == "Y")
                {
                    resultadoFinal += dicionarioLetras["Y"] + dicionarioLetras["Y"] + dicionarioLetras["Y"];
                    resultadoConsulta = dicionarioLetras["Y"];
                }
                else if (resultadoConsulta == "Z")
                {
                    resultadoFinal += dicionarioLetras["Z"] + dicionarioLetras["Z"] + dicionarioLetras["Z"] + dicionarioLetras["Z"];
                    resultadoConsulta = dicionarioLetras["Z"];
                }

                if (resultadoConsulta == " ")
                {
                    resultadoFinal += dicionarioLetras[" "];
                    resultadoConsulta = dicionarioLetras[" "];
                }

                if (resultadoConsultaIfem == resultadoConsulta)
                {
                    
                    resultadoFinal += "_";
                }

                resultadoConsultaIfem = String.Empty;
            }

            return resultadoFinal;
        }
    }
}

