using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMA_3
{
    public partial class Alimentos : Form
    {
        int x = 0;
        public Alimentos()
        {
            InitializeComponent();
        }

        private void bananaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.banana;
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
            label1.Text = "Rica em vitaminas do complexo B e C, a fruta mais brasileira de todas contém triptofano, elemento que aumenta os níveis de serotonina, controlando o desejo por doces. As bananas, que muitos acreditam ter muitas calorias, oferecem um número bem razoável: uma unidade grande fornece apenas 120 calorias.";
            //label1.Text = "Rica em vitaminas do complexo B e C, a fruta mais brasileira \nde todas contém triptofano, elemento que aumenta os níveis de serotonina,\n controlando o desejo por doces.\n As bananas, que muitos acreditam ter muitas calorias, \noferecem um número bem razoável: uma unidade fornece apenas 120 calorias.";
        }

        private void maçaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.maca;
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
            label1.Text = "Auxilia a manter os níveis de colesterol estáveis, pois contem pectina, que dificulta a absorção das gorduras e também da glicose. Como também tem uma grande quantidade de potássio, ela elimina o sódio e o excesso de água retida no corpo. Além disso, a maçã é rica em vitaminas B1, B2 e niacina, além de sais minerais, como fósforo e ferro.";
        }

        private void melanciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.melancia;
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
            label1.Text = "Super hidratante, por ser composta por mais de 80% de água, a melancia é uma das frutas que mais contém vitaminas do complexo A e B, além de promover uma verdadeira limpeza tanto no intestino, como no estômago.";
        }

        private void abacateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.abacate;
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
            label1.Text = "A gordura monoinsaturada presente nessa fruta é responsável por elevar o colesterol bom no organismo. Além disso, o abacate auxilia a saciar a fome e estimula a cicatrização. Por ser rico em vitamina E, é bom para pessoas com doenças cardiovasculares e reforça também o sistema imunológico.";
        }

        private void uvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.uva;
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
            label1.Text = "O seu bagaço reduz o risco de doenças cardiovasculares por ação do resveratrol. A uva também contém flavonoides, que são antioxidantes e combatem o mau colesterol.";
        }

        private void pêraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pera;
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
            label1.Text = "A fruta é rica em vitamina A, C, vitaminas do complexo B, fibras e água. Ela também é um poderoso diurético, combate os gases estomacais e intestinais e contém apenas 98 kcal.";
        }

        private void laranjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.laranja;
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
            label1.Text = "Muito famosa por seu alto teor de vitamina C que fortalece o sistema imunológico, a laranja também é rica em muitos outros compostos anticancerígenos.";
        }

        private void morangoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.morango;
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
            label1.Text = "Rico em antioxidantes, o morango ainda é amigo do coração, por conter também antocianinas. Além disso, possui poucas calorias (cerca de 4kcal por unidade) e retarda o envelhecimento.";
        }

        private void melãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.melao;
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
            label1.Text = "Ajuda a estabilizar a pressão arterial, e possui níveis elevados de vitamina C, vitamina A, vitamina B6-, potássio, niacina, fibra dietética, e ácido fólico.";
        }

        private void abacaxiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.abacaxi;
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
            label1.Text = "Rico em bromelinas, o abacaxi auxilia na digestão, especialmente de proteínas, além de conter um poderoso efeito cicatrizante. Também contem poucas calorias e muita água em sua composição.";
        }

        private void agriãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.agriao;
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
            label1.Text = "Essa hortaliça tão comum em nossa mesa, possui muitos nutrientes importantes, como ferro, vitaminas e outros minerais e, seu consumo garante a manutenção da saúde de órgãos e do sangue! Rico em vitaminas C, B3 e B6, também em manganês, betacaroteno, fibras e zinco.";
        }

        private void couveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.couve;
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
            label1.Text = "Esses pequenos vegetais verdes são especialmente importantes para a mulher grávida, porque eles estão cobertos de ácido fólico, um tipo de vitamina B que previne defeitos do tubo neural. Couve também é repletas de vitaminas C e K, bem como potássio, fibras e ômega-3 (os ácidos graxos).";
        }

        private void beterrabaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.beterraba;
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
            label1.Text = "A beterraba é um alimento bem pouco calórico: 40 calorias para cada 100 gramas. Contém na beterraba antioxidantes( carotenoides, flavonoides), minerais (zinco, magnésio, fósforo, potássio e ferro) e vitaminas (A, complexo B, e vitamina C).Tem ação anti-inflamatória, revitalizante, diurética, digestiva, tônica, desintoxicante natural e purificadora do sangue.";
        }

        private void espinafreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.espinafre;
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
            label1.Text = "Este tipo de vegetal é uma excelente fonte de vitamina com quase todos os nutrientes que você precisa. Os cientistas acreditam que uma dieta rica em espinafre pode ser capaz de impedir vários tipos de doença, desde uma doença cardíaca ao cancro do cólon, artrite e osteoporose.";
        }

        private void alfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.alface;
            label1.Text = "A alface é uma planta herbácea rica em nutrientes e clorofila. Tem a função de alcalinizar e desintoxicar principalmente o fígado. Esta hortaliça constitui uma importante fonte de vitaminas (A, C e niacina) e sais minerais (sais de enxofre, fósforo, ferro, cálcio e silício).";
        }

        private void salsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.salsa;
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
            label1.Text = "A salsa é uma planta aromática cujas propriedades podem nos trazer muitos benefícios. Entre eles o de purificar os órgãos vitais, tratar e controlar a hipertensão, além de ser um poderoso antioxidante. É muito rica em vitamina C, fortalece o sistema imunológico ao aumentar as defesas.";
        }

        private void pimentãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pimentao;
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
            label1.Text = "Se você prefere vermelho, laranja ou amarelo, pimentão são repletos com dezenas de nutrientes benéficos para o coração, como ácido fólico e licopeno. Apresenta um bom valor nutricional, sendo rico em sais minerais e vitaminas. Possui boas quantidades de vitaminas A, C e do complexo B.";
        }

        private void cenouraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.cenoura;
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
            label1.Text = "As cenouras estão entre os vegetais mais benéficos e carregados com nutrientes para a pele, olhos e cabelos. Elas também são a mais rica fonte vegetal de alguns antioxidantes importantes, como a vitamina A. E porque eles são ricos em vitamina C, cenoura proteger o sistema cardiovascular de danos.";
        }

        private void brócolisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.brocolis;
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
            label1.Text = "Poucos alimentos tem um alto potencial de combate a doenças como o brócolis. Este vegetal possui antioxidantes que ajudam a reduzir o risco de câncer de pulmão, estômago e reto. E porque o brócolis é rico em beta-caroteno, vitamina C e ácido fólico, também é bom para impulsionar a sua imunidade a resfriados e gripes.";
        }

        private void abóboraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.abobora;
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
            label1.Text = "Uma boa fonte de nutrientes anti-inflamatórios como vitamina C e beta-caroteno, a abóbora, especialmente abobrinha, podem ajudar a tratar dezenas de distúrbios, incluindo osteoartrite, asma e artrite reumatoide. A abóbora é também é rica em potássio, magnésio e fibras.";
        }

        private void vitaminaAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.a;
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
            label1.Text = "Presente nos alimentos amarelo-alaranjados, nas folhas verdes escuras e sob a forma de retinol em alimentos de origem animal. Alguns exemplos são cenoura, manga, moranga, mamão, espinafre, brócolis, rúcula, agrião, gema do ovo, leite, fígado, entre outros. Ela possui papel fundamental no crescimento ósseo, desenvolvimento e manutenção do tecido epitelial, aumenta a imunidade, importante para combater os radicais livres (ação antioxidante) e prevenção do envelhecimento celular. ";
        }

        private void vitaminaBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.b;
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
            label1.Text = "Referidas como vitaminas do Complexo B, as oito vitaminas B (B1, B2, B3, B5, B6, B7, B9, B12) desempenham um papel importante em manter nosso corpo funcionando como máquinas bem lubrificadas. Estes nutrientes essenciais ajudam a converter os alimentos em combustível, o que nos permite ficar energizados durante todo o dia. Embora muitas das seguintes vitaminas trabalhem em conjunto, cada uma tem seus próprios benefícios específicos, desde promover a pele e cabelo saudáveis até impedir a perda da memória ou enxaquecas.";
        }

        private void vitaminaCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.c;
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
            label1.Text = "Presente especialmente nas frutas cítricas, como kiwi, melão, laranja, goiaba, acerola, manga, morango, tomate, couve, agrião, tangerina. É muito importante para o crescimento e desenvolvimento, ajuda no processo de cicatrização, estimula o sistema imunológico (ajudando a prevenir resfriados), estimula a síntese de colágeno, mantendo a elasticidade e a integridade da pele, importante para ossos, dentes, músculos e tendões. A vitamina C também estimula a absorção do ferro no intestino. Os indivíduos que não ingerem vitamina C suficiente, desenvolvem uma condição chamada escorbuto, que causa fadiga, sangramento e má cicatrização.";
        }

        private void vitaminaDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.d;
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
            label1.Text = "Presente em peixes gordurosos, como sardinhas, cavala, atum, ovos, alimentos fortificados como margarina e alguns cereais matinais. Ela é muito importante para o crescimento e manutenção dos ossos, porque controla a absorção de cálcio e fósforo, que são essenciais ao metabolismo do osso. A vitamina D pode ser produzida em sua pele através dos raios ultravioletas da luz solar. Grandes doses podem levar a altos níveis de cálcio, especialmente em crianças, o que pode resultar em má formação do osso, apesar disto ser extremamente raro. Não existem recomendações referentes à dieta para adultos que levam uma vida normal envolvendo exposição ao sol.";
        }
        private void vitaminaEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.e;
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
            label1.Text = "Presente no gérmem de trigo, óleo de gérmem de trigo, óleo de soja, arroz, algodão, milho e girassol, gema de ovo, nozes, vegetais folhosos e legumes. É um importante antioxidante, atua na prevenção do envelhecimento precoce das células, estimula o sistema imunológico, reduz o risco de cataratas, protetor contra doenças cardiovasculares, previne o câncer e doenças da pele. Sua deficiência em humanos é rara, ocorrendo apenas em bebês prematuros e em indivíduos com síndrome de má-absorção.";
        }

        private void vitaminaKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.k;
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
            label1.Text = "Presente na alface, couve, couve-flor, espinafre, repolho, leite, os vegetais de folhas verde-escuro são as melhores fontes desta vitamina. A vitamina K está envolvida na coagulação do sangue e sua deficiência acarreta ferimentos e sangramento excessivo. Sua deficiência causa tendências à hemorragias e dificuldade de cicatrização, porém ela é rara, exceto em recém-nascidos e indivíduos que têm alguma doença afetando a absorção de vitaminas ou o metabolismo, como pacientes com doença hepática crônica.";
        }
    }
}
