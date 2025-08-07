using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pedra_papel_tesoura
{
    public partial class JOKENPO : Form
    {
        public JOKENPO()
        {
            InitializeComponent();
        }

        private void labelIGUAL_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonPEDRA_Click(object sender, EventArgs e)
        {
            Startgame(0);
        }

        private void Startgame(int opcao)
        {
            Game JOGO = new Game ();   
            switch (JOGO.Jogar (opcao))
            {
                case Game.Resultado.Ganhar:
                    pictureRESULTADO.BackgroundImage = Image.FromFile("Imagens/Ganhar.png");
                    goto default;
                case Game.Resultado.Perder:
                    pictureRESULTADO.BackgroundImage = Image.FromFile("Imagens/Perder.png");
                    goto default;
                case Game.Resultado.Empatar:
                    pictureRESULTADO.BackgroundImage = Image.FromFile("Imagens/Empatar.png");
                    goto default;
                default:
                    pictureVOCE.BackgroundImage = JOGO.ImgJogador;
                    picturePC.BackgroundImage = JOGO.ImgPC;

                    break;
            }
        }

        private void buttonPAPEL_Click(object sender, EventArgs e)
        {
            Startgame(1);

        }

        private void buttonTESOURA_Click(object sender, EventArgs e)
        {
            Startgame(2);

        }
    }
}
