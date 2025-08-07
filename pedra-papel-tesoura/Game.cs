using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedra_papel_tesoura
{
    internal class Game
    {
        public enum Resultado
        {

            Ganhar, Perder, Empatar

        }
        //Vetor (array) para armazenar as immagens -- caminho das imagens
        public static Image[] imagens =

        {
            Image.FromFile("Imagens/Pedra.png"),
            Image.FromFile("Imagens/Papel.png"),
            Image.FromFile("Imagens/Tesoura.png"),
        };

        //Metodo para pegar e colocar as imagens do Jogador e do PC
        public Image ImgPC { get; set; }
        public Image ImgJogador { get; set; }
        public Resultado Jogar(int jogador)
        {
            int pc = JogadaPC();


            ImgJogador = imagens[jogador]; //Salvar na variavel ImgJogador a imagem que o jogador escolheu
            ImgPC = imagens[pc]; 

            if( jogador == pc)
            {
                return Resultado.Empatar;
            }
            //Jogador = Pedra e Pc = Papel ou Jogador = papel e PC = Tesoura -------- PC ganha
            else if((jogador == 0 && pc == 1 ) || (jogador == 1 &&  pc == 2 ) || (jogador == 2 && pc == 0))
            {
                return Resultado.Perder; 
            }
            else
            {
                return Resultado.Ganhar;
            }
        }

        private int JogadaPC()
        {
            int mil = DateTime.Now.Millisecond;

            if(mil < 333)
            {
                return 0;
            } else if (mil >= 333 & mil < 667)
            {
                return 1;
            } else
            {
                return 2;
            }
        }


    }
}























































































































































































































































