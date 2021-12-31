using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Media;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temporizador
{
    public partial class Form1 : Form
    {
        int hours = 0, mins = 0, secs = 0, total = 0;
        bool pausado = false;

        //Funções
        void checkEmptyString()
        {
            if (textBoxHoras.Text.ToString() == string.Empty)
            {
                textBoxHoras.Text = "0";
            }

            if (textBoxMinutos.Text.ToString() == string.Empty)
            {
                textBoxMinutos.Text = "0";
            }

            if (textBoxSegundos.Text.ToString() == string.Empty)
            {
                textBoxSegundos.Text = "0";
            }

            if (comboBoxHoras.SelectedIndex <= 0)
            {
                comboBoxHoras.SelectedIndex = 0;
            }

            if (comboBoxMinutos.SelectedIndex <= 0)
            {
                comboBoxMinutos.SelectedIndex = 0;
            }

            if (comboBoxSegundos.SelectedIndex <= 0)
            {
                comboBoxSegundos.SelectedIndex = 0;
            }
        }

        void checkLabels()
        {
            //Contagem de Segundos
            if (secs < 0) //Esse if faz a checagem se o número mostrado precisa reiniciar ou não
            {
                secs = 59;
                mins--;

                if (mins < 0)
                {
                    mins = 59;
                    hours--;
                }
            }

            if (secs >= 10)//Esse if faz a checagem se o número mostrado precisa de um zero no começo
            {
                segundo.Text = secs.ToString();
            }
            else
            {
                segundo.Text = "0" + secs.ToString();
            }
            //Contagem de Minutos
            if (mins >= 10)
            {
                minuto.Text = mins.ToString();
            }
            else
            {
                minuto.Text = "0" + mins.ToString();
            }
            //Contagem de Horas
            if (hours >= 10)
            {
                hora.Text = hours.ToString();
            }
            else
            {
                hora.Text = "0" + hours.ToString();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        //Carregamento do Formulário
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader arquivo = new StreamReader(@"ringtones.txt");

            while (arquivo.Peek() != -1)
            {
                opcoes.Items.Add(arquivo.ReadLine());
            }
            arquivo.Close();

            opcoes.SelectedItem = "Ruins.mp3";
            player.URL = opcoes.SelectedItem.ToString();
            player.Ctlcontrols.stop();

            for (int i = 0; i < 100; i++)
            {
                comboBoxSegundos.Items.Add(i.ToString());
                comboBoxMinutos.Items.Add(i.ToString());
                comboBoxHoras.Items.Add(i.ToString());
            }

            comboBoxHoras.SelectedIndex = 0;
            comboBoxMinutos.SelectedIndex = 0;
            comboBoxSegundos.SelectedIndex = 0;

            textBoxHoras.Text = "0";
            textBoxMinutos.Text = "0";
            textBoxSegundos.Text = "0";

            textBoxHoras.Enabled = false;
            textBoxMinutos.Enabled = false;
            textBoxSegundos.Enabled = false;
        }

        private void opcoes_MouseClick(object sender, MouseEventArgs e)
        {
            if (opcoes.Items.Count > 0)
            {
                player.URL = opcoes.SelectedItem.ToString();
                player.Ctlcontrols.play();
            }
        }
        private void opcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = opcoes.SelectedItem.ToString();
            player.Ctlcontrols.play();
        }

        //Botões de opção
        private void iniciar_Click(object sender, EventArgs e)
        {
            checkEmptyString();
            //Confere qual das boxes está ativada, e usa os valores do conjunto como parâmetro para a contagem
            if (comboBoxHoras.Enabled == true)
            {
                hours = int.Parse(comboBoxHoras.SelectedItem.ToString());
                mins = int.Parse(comboBoxMinutos.SelectedItem.ToString());
                secs = int.Parse(comboBoxSegundos.SelectedItem.ToString());
            }
            else
            {
                hours = int.Parse(textBoxHoras.Text.ToString());
                mins = int.Parse(textBoxMinutos.Text.ToString());
                secs = int.Parse(textBoxSegundos.Text.ToString());
            }
            //Atribui o valor de total para a contagem correta
            if (hours + mins + secs > 0)
            {
                total = (hours * 3600) + (mins * 60) + secs;
                timerSegundos.Start();
                player.Ctlcontrols.stop();

                iniciar.Text = "Reiniciar";
                iniciar.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            }
            else
            {
                hours = 0; mins = 0; secs = 0; total = 0;
                timerSegundos.Stop();
            }
        }

        private void zerar_Click(object sender, EventArgs e)
        {
            //Zera e para tudo
            hours = 0; mins = 0; secs = 0; total = 0;
            hora.Text = "00"; minuto.Text = "00"; segundo.Text = "00";

            if (comboBoxHoras.Enabled == true)
            {
                comboBoxHoras.SelectedIndex = 0;
                comboBoxMinutos.SelectedIndex = 0;
                comboBoxSegundos.SelectedIndex = 0;
            }
            else
            {
                textBoxHoras.Text = "0";
                textBoxMinutos.Text = "0";
                textBoxSegundos.Text = "0";
            }

            timerSegundos.Stop();
            iniciar.Text = "Iniciar";
            iniciar.Font = new Font("Times New Roman", 22, FontStyle.Bold);
        }

        private void pausar_Click(object sender, EventArgs e)
        {
            int horasPaused;
            int minutosPaused;
            int segundosPaused;
            if (total > 0)
            {
                if (pausado == false)
                {
                    pausado = true;
                    horasPaused = hours;
                    minutosPaused = mins;
                    segundosPaused = secs;

                    if (segundosPaused < 0)
                    {
                        segundosPaused = 0;
                    }
                    timerSegundos.Stop();
                    pausar.Text = "Despausar";
                    pausar.Font = new Font("Times New Roman", 14, FontStyle.Bold);
                }
                else
                {
                    if (total != 0 && total > 0)
                    {
                        pausado = false;
                        timerSegundos.Start();
                        pausar.Text = "Pausar";
                        pausar.Font = new Font("Times New Roman", 22, FontStyle.Bold);
                    }
                }
                player.Ctlcontrols.pause();
            }
        }

        private void timerSegundos_Tick(object sender, EventArgs e)
        {
            checkLabels();
            if (total <= 0)
            {
                secs = 0;
                mins = 0;
                hours = 0;
                timerSegundos.Stop();
                player.Ctlcontrols.stop();
                player.Ctlcontrols.play();
            }
            secs--;
            total--;
            //Aparentente tem um problema de 'refresh' do WMP (como componente do forms), que o impossibilita
            //de reproduzir automaticamente dps de um tempo. Resolvido por colocar um comando para dar esse
            //'refresh' no player.
            if (total % 1800 == 0)
            {
                player.URL = opcoes.SelectedItem.ToString();
                player.Ctlcontrols.stop();
            }
        }

        private void radioButton1ComboBox_Click(object sender, EventArgs e)
        {
            textBoxHoras.Enabled = false;
            textBoxMinutos.Enabled = false;
            textBoxSegundos.Enabled = false;

            comboBoxHoras.Enabled = true;
            comboBoxMinutos.Enabled = true;
            comboBoxSegundos.Enabled = true;

            radioButton1TextBox.TabStop = true;
        }

        private void radioButton1TextBox_Click(object sender, EventArgs e)
        {
            comboBoxHoras.Enabled = false;
            comboBoxMinutos.Enabled = false;
            comboBoxSegundos.Enabled = false;

            textBoxHoras.Enabled = true;
            textBoxMinutos.Enabled = true;
            textBoxSegundos.Enabled = true;

            radioButton1ComboBox.TabStop = true;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Confere se a tecla pressionada é um número ou uma tecla de controle
            if (!(char.IsDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        /*------------------------------------- Fim -----------------------------------------------------*/

        /*                              Anotações sobre o desenvolvimento
         * Data de Início: 28/09/2021
         * Objetivo é:
         *  Criar um temporizador de horas, minutos e segundos que toque uma música quando
         *  o valor atinge zero.
         *  Oferecer ao usuário duas opções de inserção: caixa de texto ou lista(comboBox).
         *  
         *  A ideia é fazer as labels obterem o valor inserido pelo usuário
         *  e mudarem conforme o timer correspondente. (mudei para somente um timer pois usando 3
         *  para um cronômetro funciona, mas não um temporizador - ou relógio de contagem regressiva.)
         *  
         *  O problema que acredito que vai acontecer é o conflito de input do usuário.
         *  (resolvido por colocar radioBtns pra escolher a opção de input)
         *  
         *  Anotações:
         *  - Tentar resolver o máximo possível até terça dia 5/9.
         *  - Tentar oferecer opções de música ao usuário,
         *  mas se conseguir fazer funcionar até terça tá ótimo.
         *  - (1/9) Ainda falta travar o input de caracteres não alfanuméricos,
         *  a funcionalidade do botão de pause e a música.
         *  - OK... Vamos por partes: criei um player de música mas não entendi 100% como funciona.
         *  Coloquei um player nesse projeto mas não configurei nada ainda.
         *  - Mesmo dia, 22:23. Travei inputs, mas ainda permite que o mesmo fique vazio.
         *  Configurei o player, funciona perfeitamente, mas o usuário precisa selecionar uma opção,
         *  se não não toca nada quando o timer atinge zero. O ideal era esses dois itens estarem ok.
         *  - (5/9) Tudo OK!!
         *  
         *  Próximos Objetivos:
         *      - Fazer o programa rodar em segundo plano;
         *      - Colocar as funções CheckLabels(); e CheckEmptyString(); em uma classe, e utilizá-las como métodos(?).
         *      
         *  Últimas modificações feitas em: 31/12/2021  */
    }
}
