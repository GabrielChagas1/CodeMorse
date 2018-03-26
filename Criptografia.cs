using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CódigoMorse
{
    class Criptografia
    {
       public string Criptografar(string texto){

            if (texto == ""){
                MessageBox.Show("Insira algo na caixa de texto!!");
            }

            string[] morse = new string[300];
            texto = texto.ToUpper();
            char[] letra = texto.ToCharArray();


            for (int i = 0; i < letra.Length; i++)//for para varrer a frase letra a letra
            {

                switch (letra[i])//switch para verificar a letra e adicionar dentro do array morse 
                {
                    case 'A':
                        morse[i] = ". - ";
                        break;

                    case 'B':
                        morse[i] = "- . . .";
                        break;

                    case 'C':
                        morse[i] = "- . - .";
                        break;

                    case 'D':
                        morse[i] = "- . .";
                        break;

                    case 'E':
                        morse[i] = ".";
                        break;

                    case 'F':
                        morse[i] = ". . - .";
                        break;

                    case 'G':
                        morse[i] = "- - .";
                        break;

                    case 'H':
                        morse[i] = ". . . .";
                        break;

                    case 'I':
                        morse[i] = ". .";
                        break;

                    case 'J':
                        morse[i] = ". - - -";
                        break;

                    case 'K':
                        morse[i] = "- . -";
                        break;

                    case 'L':
                        morse[i] = ". - . .";
                        break;

                    case 'M':
                        morse[i] = "- -";
                        break;

                    case 'N':
                        morse[i] = "- .";
                        break;

                    case 'O':
                        morse[i] = "- - -";
                        break;

                    case 'P':
                        morse[i] = ". - - .";
                        break;

                    case 'Q':
                        morse[i] = "- - . -";
                        break;

                    case 'R':
                        morse[i] = ". - .";
                        break;

                    case 'S':
                        morse[i] = ". . .";
                        break;

                    case 'T':
                        morse[i] = "-";
                        break;

                    case 'U':
                        morse[i] = ". . -";
                        break;

                    case 'V':
                        morse[i] = ". . . -";
                        break;

                    case 'W':
                        morse[i] = ". - - ";
                        break;

                    case 'X':
                        morse[i] = "- . . - ";
                        break;

                    case 'Y':
                        morse[i] = "- . - -";
                        break;

                    case 'Z':
                        morse[i] = "- - . .";
                        break;
                }
            }

            string frase = String.Join(" ", morse);

            return frase;
        }

        public void CodigoMorse(string frase)
        {

            if(frase == "")
            {
                MessageBox.Show("Insira algo na caixa de texto!!");
            }

            frase = frase.ToUpper();

            char[] letra = frase.ToCharArray();


            for (int i = 0; i < letra.Length; i++)//for para varrer a frase letra a letra
            {

                switch (letra[i])//switch para verificar a letra e reproduzir o barulho na tela
                {
                    case 'A':
                        Console.Beep();
                        Console.Beep(800, 600);
                        break;

                    case 'B':
                        Console.Beep(800, 600);
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        break;

                    case 'C':
                        Console.Beep(800, 600);
                        Console.Beep();
                        Console.Beep(800, 600);
                        Console.Beep();
                        break;

                    case 'D':
                        Console.Beep(800, 600);
                        Console.Beep();
                        Console.Beep();
                        break;

                    case 'E':
                        Console.Beep();
                        break;

                    case 'F':
                        Console.Beep();
                        Console.Beep();
                        Console.Beep(800, 600);
                        Console.Beep();
                        break;

                    case 'G':
                        Console.Beep(800, 600);
                        Console.Beep(800, 600);
                        Console.Beep();
                        break;

                    case 'H':
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        break;

                    case 'I':
                        Console.Beep();
                        Console.Beep();
                        break;

                    case 'J':
                        Console.Beep();
                        Console.Beep(800, 600);
                        Console.Beep(800, 600);
                        Console.Beep(800, 600);
                        break;

                    case 'K':
                        Console.Beep(800, 600);
                        Console.Beep();
                        Console.Beep(800, 600);
                        break;

                    case 'L':
                        Console.Beep();
                        Console.Beep(800, 600);
                        Console.Beep();
                        Console.Beep();
                        break;

                    case 'M':
                        Console.Beep(800, 600);
                        Console.Beep(800, 600);
                        break;

                    case 'N':
                        Console.Beep(800, 600);
                        Console.Beep();
                        break;

                    case 'O':
                        Console.Beep(800, 600);
                        Console.Beep(800, 600);
                        Console.Beep(800, 600);
                        Console.Beep(800, 600);
                        break;

                    case 'P':
                        Console.Beep();
                        Console.Beep(800, 600);
                        Console.Beep(800, 600);
                        Console.Beep();
                        break;

                    case 'Q':
                        Console.Beep(800, 600);
                        Console.Beep(800, 600);
                        Console.Beep();
                        Console.Beep(800, 600);
                        break;

                    case 'R':
                        Console.Beep();
                        Console.Beep(800, 600);
                        Console.Beep();
                        break;

                    case 'S':
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        break;

                    case 'T':
                        Console.Beep(800, 600);
                        break;

                    case 'U':
                        Console.Beep();
                        Console.Beep();
                        Console.Beep(800, 600);
                        break;

                    case 'V':
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep(800, 600);
                        break;

                    case 'W':
                        Console.Beep();
                        Console.Beep(800, 600);
                        Console.Beep(800, 600);
                        break;

                    case 'X':
                        Console.Beep(800, 600);
                        Console.Beep();
                        Console.Beep();
                        Console.Beep(800, 600);
                        break;

                    case 'Y':
                        Console.Beep(800, 600);
                        Console.Beep();
                        Console.Beep(800, 600);
                        Console.Beep(800, 600);
                        break;

                    case 'Z':
                        Console.Beep(800, 600);
                        Console.Beep(800, 600);
                        Console.Beep();
                        Console.Beep();
                        break;


                }


            }

        }

    }
}
