using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Speech;
using System.Speech.Synthesis;

namespace E_N
{
    public partial class Form1 : Form
    {

        //Form2 frm2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        SpeechSynthesizer reader = new SpeechSynthesizer();

        private void Form1_Load(object sender, EventArgs e)
        {
            
            radioButton1.Checked = true;

            button4.Visible = false;
            button7.Visible = false;
            textBox5.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)     // Encrypt Button
        {

            Random rndGen = new Random();
            int encRan = rndGen.Next(0, 99);


            StreamReader forA = new StreamReader("D:\\Vc#\\A\\A.txt");
            string[] linesA = forA.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesA[encRan];
            forA.Close();

            StreamReader forB = new StreamReader("D:\\Vc#\\A\\B.txt");
            string[] linesB = forB.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesB[encRan];
            forB.Close();

            StreamReader forC = new StreamReader("D:\\Vc#\\A\\C.txt");
            string[] linesC = forC.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesC[encRan];
            forC.Close();

            StreamReader forÇ = new StreamReader("D:\\Vc#\\A\\Ç.txt");
            string[] linesÇ = forÇ.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesÇ[encRan];
            forÇ.Close();

            StreamReader forD = new StreamReader("D:\\Vc#\\A\\D.txt");
            string[] linesD = forD.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesD[encRan];
            forD.Close();

            StreamReader forE = new StreamReader("D:\\Vc#\\A\\E.txt");
            string[] linesE = forE.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesE[encRan];
            forE.Close();

            StreamReader forF = new StreamReader("D:\\Vc#\\A\\F.txt");
            string[] linesF = forF.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesF[encRan];
            forF.Close();

            StreamReader forG = new StreamReader("D:\\Vc#\\A\\G.txt");
            string[] linesG = forG.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesG[encRan];
            forG.Close();

            StreamReader forĞ = new StreamReader("D:\\Vc#\\A\\Ğ.txt");
            string[] linesĞ = forĞ.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesĞ[encRan];
            forĞ.Close();

            StreamReader forH = new StreamReader("D:\\Vc#\\A\\H.txt");
            string[] linesH = forH.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesH[encRan];
            forH.Close();

            StreamReader forI = new StreamReader("D:\\Vc#\\A\\I.txt");
            string[] linesI = forI.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesI[encRan];
            forI.Close();
            

            StreamReader forİ = new StreamReader("D:\\Vc#\\A\\İ.txt");
            string[] linesİ = forİ.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesİ[encRan];
            forİ.Close();

            StreamReader forJ = new StreamReader("D:\\Vc#\\A\\J.txt");
            string[] linesJ = forJ.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesJ[encRan];
            forJ.Close();

            StreamReader forK = new StreamReader("D:\\Vc#\\A\\K.txt");
            string[] linesK = forK.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesK[encRan];
            forK.Close();

            StreamReader forL = new StreamReader("D:\\Vc#\\A\\L.txt");
            string[] linesL = forL.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesL[encRan];
            forL.Close();

            StreamReader forM = new StreamReader("D:\\Vc#\\A\\M.txt");
            string[] linesM = forM.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesM[encRan];
            forM.Close();

            StreamReader forN = new StreamReader("D:\\Vc#\\A\\N.txt");
            string[] linesN = forN.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesN[encRan];
            forN.Close();

            StreamReader forO = new StreamReader("D:\\Vc#\\A\\O.txt");
            string[] linesO = forO.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesO[encRan];
            forO.Close();

            StreamReader forÖ = new StreamReader("D:\\Vc#\\A\\Ö.txt");
            string[] linesÖ = forÖ.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesÖ[encRan];
            forÖ.Close();

            StreamReader forP = new StreamReader("D:\\Vc#\\A\\P.txt");
            string[] linesP = forP.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesP[encRan];
            forP.Close();

            StreamReader forR = new StreamReader("D:\\Vc#\\A\\R.txt");
            string[] linesR = forR.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesR[encRan];
            forR.Close();

            StreamReader forS = new StreamReader("D:\\Vc#\\A\\S.txt");
            string[] linesS = forS.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesS[encRan];
            forS.Close();

            StreamReader forŞ = new StreamReader("D:\\Vc#\\A\\Ş.txt");
            string[] linesŞ = forŞ.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesŞ[encRan];
            forŞ.Close();

            StreamReader forT = new StreamReader("D:\\Vc#\\A\\T.txt");
            string[] linesT = forT.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesT[encRan];
            forT.Close();

            StreamReader forU = new StreamReader("D:\\Vc#\\A\\U.txt");
            string[] linesU = forU.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesU[encRan];
            forU.Close();

            StreamReader forÜ = new StreamReader("D:\\Vc#\\A\\Ü.txt");
            string[] linesÜ = forÜ.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesÜ[encRan];
            forÜ.Close();

            StreamReader forV = new StreamReader("D:\\Vc#\\A\\V.txt");
            string[] linesV = forV.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesV[encRan];
            forV.Close();

            StreamReader forY = new StreamReader("D:\\Vc#\\A\\Y.txt");
            string[] linesY = forY.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesY[encRan];
            forY.Close();

            StreamReader forZ = new StreamReader("D:\\Vc#\\A\\Z.txt");
            string[] linesZ = forZ.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesZ[encRan];
            forZ.Close();

            StreamReader forX = new StreamReader("D:\\Vc#\\A\\X.txt");
            string[] linesX = forX.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesX[encRan];
            forX.Close();

            StreamReader forW = new StreamReader("D:\\Vc#\\A\\W.txt");
            string[] linesW = forW.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesW[encRan];
            forW.Close();

            StreamReader forQ = new StreamReader("D:\\Vc#\\A\\Q.txt");
            string[] linesQ = forQ.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesQ[encRan];
            forQ.Close();

            StreamReader forspace = new StreamReader("D:\\Vc#\\A\\space.txt");
            string[] linesspace = forspace.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesspace[encRan];
            forspace.Close();

            StreamReader foraltçizgi = new StreamReader("D:\\Vc#\\A\\altçizgi.txt");
            string[] linesaltçizgi = foraltçizgi.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesaltçizgi[encRan];
            foraltçizgi.Close();

            StreamReader for0 = new StreamReader("D:\\Vc#\\A\\0.txt");
            string[] lines0 = for0.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = lines0[encRan];
            for0.Close();

            StreamReader for1 = new StreamReader("D:\\Vc#\\A\\1.txt");
            string[] lines1 = for1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = lines1[encRan];
            for1.Close();

            StreamReader for2 = new StreamReader("D:\\Vc#\\A\\2.txt");
            string[] lines2 = for2.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = lines2[encRan];
            for2.Close();

            StreamReader for3 = new StreamReader("D:\\Vc#\\A\\3.txt");
            string[] lines3 = for3.ReadToEnd().Split(new char[] { '\n' });
            //textBox3.Text = lines3[encRan];
            for3.Close();

            StreamReader for4 = new StreamReader("D:\\Vc#\\A\\4.txt");
            string[] lines4 = for4.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = lines4[encRan];
            for4.Close();

            StreamReader for5 = new StreamReader("D:\\Vc#\\A\\5.txt");
            string[] lines5 = for5.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = lines5[encRan];
            for5.Close();

            StreamReader for6 = new StreamReader("D:\\Vc#\\A\\6.txt");
            string[] lines6 = for6.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = lines6[encRan];
            for6.Close();

            StreamReader for7 = new StreamReader("D:\\Vc#\\A\\7.txt");
            string[] lines7 = for7.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = lines7[encRan];
            for7.Close();

            StreamReader for8 = new StreamReader("D:\\Vc#\\A\\8.txt");
            string[] lines8 = for8.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = lines8[encRan];
            for8.Close();

            StreamReader for9 = new StreamReader("D:\\Vc#\\A\\9.txt");
            string[] lines9 = for9.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = lines9[encRan];
            for9.Close();
            
            StreamReader forartı = new StreamReader("D:\\Vc#\\A\\artı.txt");
            string[] linesartı = forartı.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesartı[encRan];
            forartı.Close();

            StreamReader forbölü = new StreamReader("D:\\Vc#\\A\\bölü.txt");
            string[] linesbölü = forbölü.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesbölü[encRan];
            forbölü.Close();

            StreamReader forbuyuktur = new StreamReader("D:\\Vc#\\A\\buyuktur.txt");
            string[] linesbuyuktur = forbuyuktur.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesbuyuktur[encRan];
            forbuyuktur.Close();

            StreamReader forçarpı = new StreamReader("D:\\Vc#\\A\\çarpı.txt");
            string[] linesçarpı = forçarpı.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesçarpı[encRan];
            forçarpı.Close();


            StreamReader foreksi = new StreamReader("D:\\Vc#\\A\\eksi.txt");
            string[] lineseksi = foreksi.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = lineseksi[encRan];
            foreksi.Close();

            StreamReader foret = new StreamReader("D:\\Vc#\\A\\et.txt");
            string[] lineset = foret.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = lineset[encRan];
            foret.Close();

            StreamReader forikinokta = new StreamReader("D:\\Vc#\\A\\ikinokta.txt");
            string[] linesikinokta = forikinokta.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesikinokta[encRan];
            forikinokta.Close();

            StreamReader forkucuktur = new StreamReader("D:\\Vc#\\A\\kucuktur.txt");
            string[] lineskucuktur = forkucuktur.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = lineskucuktur[encRan];
            forkucuktur.Close();

            StreamReader fornokta = new StreamReader("D:\\Vc#\\A\\nokta.txt");
            string[] linesnokta = fornokta.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesnokta[encRan];
            fornokta.Close();

            StreamReader forsemicolon = new StreamReader("D:\\Vc#\\A\\semicolon.txt");
            string[] linessemicolon = forsemicolon.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linessemicolon[encRan];
            forsemicolon.Close();

            StreamReader forsoruişareti = new StreamReader("D:\\Vc#\\A\\soruişareti.txt");
            string[] linessoruişareti = forsoruişareti.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linessoruişareti[encRan];
            forsoruişareti.Close();

            StreamReader forunlem = new StreamReader("D:\\Vc#\\A\\unlem.txt");
            string[] linesunlem = forunlem.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesunlem[encRan];
            forunlem.Close();

            StreamReader forvirgul = new StreamReader("D:\\Vc#\\A\\virgul.txt");
            string[] linesvirgul = forvirgul.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesvirgul[encRan];
            forvirgul.Close();

            StreamReader forparaç = new StreamReader("D:\\Vc#\\A\\paraç.txt");
            string[] linesparaç = forparaç.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesparaç[encRan];
            forparaç.Close();

            StreamReader forparkapat = new StreamReader("D:\\Vc#\\A\\parkapat.txt");
            string[] linesparkapat = forparkapat.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesparkapat[encRan];
            forparkapat.Close();

            StreamReader foryüzde = new StreamReader("D:\\Vc#\\A\\yüzde.txt");
            string[] linesyüzde = foryüzde.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesyüzde[encRan];
            foryüzde.Close();

            StreamReader forand = new StreamReader("D:\\Vc#\\A\\and.txt");
            string[] linesand = forand.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesand[encRan];
            forand.Close();

            StreamReader fordolar = new StreamReader("D:\\Vc#\\A\\dolar.txt");
            string[] linesdolar = fordolar.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesdolar[encRan];
            fordolar.Close();

            StreamReader foreuro = new StreamReader("D:\\Vc#\\A\\euro.txt");
            string[] lineseuro = foreuro.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = lineseuro[encRan];
            foreuro.Close();

            StreamReader foror = new StreamReader("D:\\Vc#\\A\\or.txt");
            string[] linesor = foror.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesor[encRan];
            foror.Close();

            StreamReader forecons = new StreamReader("D:\\Vc#\\A\\econs.txt");
            string[] linesecons = forecons.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesecons[encRan];
            forecons.Close();

            StreamReader fortırnak = new StreamReader("D:\\Vc#\\A\\tırnak.txt");
            string[] linestırnak = fortırnak.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linestırnak[encRan];
            fortırnak.Close();

            StreamReader forkesme = new StreamReader("D:\\Vc#\\A\\kesme.txt");
            string[] lineskesme = forkesme.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = lineskesme[encRan];
            forkesme.Close();

            StreamReader forüstü = new StreamReader("D:\\Vc#\\A\\üstü.txt");
            string[] linesüstü = forüstü.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesüstü[encRan];
            forüstü.Close();

            StreamReader forkümeaç = new StreamReader("D:\\Vc#\\A\\kümeaç.txt");
            string[] lineskümeaç = forkümeaç.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = lineskümeaç[encRan];
            forkümeaç.Close();

            StreamReader forkümekapat = new StreamReader("D:\\Vc#\\A\\kümekapat.txt");
            string[] lineskümekapat = forkümekapat.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = lineskümekapat[encRan];
            forkümekapat.Close();

            StreamReader foreşittir = new StreamReader("D:\\Vc#\\A\\eşittir.txt");
            string[] lineseşittir = foreşittir.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = lineseşittir[encRan];
            foreşittir.Close();

            StreamReader forkpaç = new StreamReader("D:\\Vc#\\A\\kpaç.txt");
            string[] lineskpaç = forkpaç.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = lineskpaç[encRan];
            forkpaç.Close();

            StreamReader forkpkapat = new StreamReader("D:\\Vc#\\A\\kpkapat.txt");
            string[] lineskpkapat = forkpkapat.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = lineskpkapat[encRan];
            forkpkapat.Close();



            // ------------------------------------------------------------- //  CAPITAL LETTERS

            StreamReader forA1 = new StreamReader("D:\\Vc#\\A\\A1.txt");
            string[] linesA1 = forA1.ReadToEnd().Split(new char[] { '\n' });
            textBox5.Text = linesA1[encRan];
            forA1.Close();

            StreamReader forB1 = new StreamReader("D:\\Vc#\\A\\B1.txt");
            string[] linesB1 = forB1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesB1[encRan];
            forB1.Close();

            StreamReader forC1 = new StreamReader("D:\\Vc#\\A\\C1.txt");
            string[] linesC1 = forC1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesC1[encRan];
            forC1.Close();

            StreamReader forÇ1 = new StreamReader("D:\\Vc#\\A\\Ç1.txt");
            string[] linesÇ1 = forÇ1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesÇ1[encRan];
            forÇ1.Close();

            StreamReader forD1 = new StreamReader("D:\\Vc#\\A\\D1.txt");
            string[] linesD1 = forD1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesD1[encRan];
            forD1.Close();

            StreamReader forE1 = new StreamReader("D:\\Vc#\\A\\E1.txt");
            string[] linesE1 = forE1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesE1[encRan];
            forE1.Close();

            StreamReader forF1 = new StreamReader("D:\\Vc#\\A\\F1.txt");
            string[] linesF1 = forF1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesF1[encRan];
            forF1.Close();

            StreamReader forG1 = new StreamReader("D:\\Vc#\\A\\G1.txt");
            string[] linesG1 = forG1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesG1[encRan];
            forG1.Close();

            StreamReader forĞ1 = new StreamReader("D:\\Vc#\\A\\Ğ1.txt");
            string[] linesĞ1 = forĞ1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesĞ1[encRan];
            forĞ1.Close();

            StreamReader forH1 = new StreamReader("D:\\Vc#\\A\\H1.txt");
            string[] linesH1 = forH1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesH1[encRan];
            forH1.Close();

            StreamReader forI1 = new StreamReader("D:\\Vc#\\A\\I1.txt");
            string[] linesI1 = forI1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesI[encRan];
            forI.Close();

            StreamReader forİ1 = new StreamReader("D:\\Vc#\\A\\İ1.txt");
            string[] linesİ1 = forİ1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesİ1[encRan];
            forİ1.Close();

            StreamReader forJ1 = new StreamReader("D:\\Vc#\\A\\J1.txt");
            string[] linesJ1 = forJ1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesJ1[encRan];
            forJ1.Close();

            StreamReader forK1 = new StreamReader("D:\\Vc#\\A\\K1.txt");
            string[] linesK1 = forK1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesK1[encRan];
            forK1.Close();

            StreamReader forL1 = new StreamReader("D:\\Vc#\\A\\L1.txt");
            string[] linesL1 = forL1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesL1[encRan];
            forL1.Close();

            StreamReader forM1 = new StreamReader("D:\\Vc#\\A\\M1.txt");
            string[] linesM1 = forM1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesM[encRan];
            forM1.Close();

            StreamReader forN1 = new StreamReader("D:\\Vc#\\A\\N1.txt");
            string[] linesN1 = forN1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesN1[encRan];
            forN1.Close();

            StreamReader forO1 = new StreamReader("D:\\Vc#\\A\\O1.txt");
            string[] linesO1 = forO1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesO1[encRan];
            forO1.Close();

            StreamReader forÖ1 = new StreamReader("D:\\Vc#\\A\\Ö1.txt");
            string[] linesÖ1 = forÖ1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesÖ[encRan];
            forÖ1.Close();

            StreamReader forP1 = new StreamReader("D:\\Vc#\\A\\P1.txt");
            string[] linesP1 = forP1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesP1[encRan];
            forP1.Close();

            StreamReader forR1 = new StreamReader("D:\\Vc#\\A\\R1.txt");
            string[] linesR1 = forR1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesR1[encRan];
            forR1.Close();

            StreamReader forS1 = new StreamReader("D:\\Vc#\\A\\S1.txt");
            string[] linesS1 = forS1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesS1[encRan];
            forS.Close();

            StreamReader forŞ1 = new StreamReader("D:\\Vc#\\A\\Ş1.txt");
            string[] linesŞ1 = forŞ1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesŞ1[encRan];
            forŞ.Close();

            StreamReader forT1 = new StreamReader("D:\\Vc#\\A\\T1.txt");
            string[] linesT1 = forT1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesT1[encRan];
            forT.Close();

            StreamReader forU1 = new StreamReader("D:\\Vc#\\A\\U1.txt");
            string[] linesU1 = forU1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesU1[encRan];
            forU1.Close();

            StreamReader forÜ1 = new StreamReader("D:\\Vc#\\A\\Ü1.txt");
            string[] linesÜ1 = forÜ1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesÜ1[encRan];
            forÜ1.Close();

            StreamReader forV1 = new StreamReader("D:\\Vc#\\A\\V1.txt");
            string[] linesV1 = forV1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesV1[encRan];
            forV1.Close();

            StreamReader forY1 = new StreamReader("D:\\Vc#\\A\\Y1.txt");
            string[] linesY1 = forY1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesY1[encRan];
            forY1.Close();

            StreamReader forZ1 = new StreamReader("D:\\Vc#\\A\\Z1.txt");
            string[] linesZ1 = forZ1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesZ1[encRan];
            forZ1.Close();

            StreamReader forX1 = new StreamReader("D:\\Vc#\\A\\X1.txt");
            string[] linesX1 = forX1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesX1[encRan];
            forX1.Close();

            StreamReader forW1 = new StreamReader("D:\\Vc#\\A\\W1.txt");
            string[] linesW1 = forW1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesW1[encRan];
            forW1.Close();

            StreamReader forQ1 = new StreamReader("D:\\Vc#\\A\\Q1.txt");
            string[] linesQ1 = forQ1.ReadToEnd().Split(new char[] { '\n' });
            //textBox5.Text = linesQ1[encRan];
            forQ1.Close();






            for (int i = 0; i < textBox1.Text.Length; i++)            {

                alphabet.letters[i] = textBox1.Text.Substring(i, 1);
            }


            for (int i = 0; i < textBox1.Text.Length; i++)
            {

                if (alphabet.letters[i] == "a")
                {
                    alphabet.enc_letters[i] = linesA[encRan];
                }
                if (alphabet.letters[i] == "b")
                {
                    alphabet.enc_letters[i] = linesB[encRan];
                }
                if (alphabet.letters[i] == "c")
                {
                    alphabet.enc_letters[i] = linesC[encRan];
                }
                if (alphabet.letters[i] == "ç")
                {
                    alphabet.enc_letters[i] = linesÇ[encRan];
                }
                if (alphabet.letters[i] == "d")
                {
                    alphabet.enc_letters[i] = linesD[encRan];
                }
                if (alphabet.letters[i] == "e")
                {
                    alphabet.enc_letters[i] = linesE[encRan];
                }
                if (alphabet.letters[i] == "f")
                {
                    alphabet.enc_letters[i] = linesF[encRan];
                }
                if (alphabet.letters[i] == "g")
                {
                    alphabet.enc_letters[i] = linesG[encRan];
                }
                if (alphabet.letters[i] == "ğ")
                {
                    alphabet.enc_letters[i] = linesĞ[encRan];
                }
                if (alphabet.letters[i] == "h")
                {
                    alphabet.enc_letters[i] = linesH[encRan];
                }
                if (alphabet.letters[i] == "ı")
                {
                    alphabet.enc_letters[i] = linesI[encRan];
                }
                if (alphabet.letters[i] == "i")
                {
                    alphabet.enc_letters[i] = linesİ[encRan];
                }
                if (alphabet.letters[i] == "j")
                {
                    alphabet.enc_letters[i] = linesJ[encRan];
                }
                if (alphabet.letters[i] == "k")
                {
                    alphabet.enc_letters[i] = linesK[encRan];
                }
                if (alphabet.letters[i] == "l")
                {
                    alphabet.enc_letters[i] = linesL[encRan];
                }
                if (alphabet.letters[i] == "m")
                {
                    alphabet.enc_letters[i] = linesM[encRan];
                }
                if (alphabet.letters[i] == "n")
                {
                    alphabet.enc_letters[i] = linesN[encRan];
                }
                if (alphabet.letters[i] == "o")
                {
                    alphabet.enc_letters[i] = linesO[encRan];
                }
                if (alphabet.letters[i] == "ö")
                {
                    alphabet.enc_letters[i] = linesÖ[encRan];
                }
                if (alphabet.letters[i] == "p")
                {
                    alphabet.enc_letters[i] = linesP[encRan];
                }
                if (alphabet.letters[i] == "r")
                {
                    alphabet.enc_letters[i] = linesR[encRan];
                }
                if (alphabet.letters[i] == "s")
                {
                    alphabet.enc_letters[i] = linesS[encRan];
                }
                if (alphabet.letters[i] == "ş")
                {
                    alphabet.enc_letters[i] = linesŞ[encRan];
                }
                if (alphabet.letters[i] == "t")
                {
                    alphabet.enc_letters[i] = linesT[encRan];
                }
                if (alphabet.letters[i] == "u")
                {
                    alphabet.enc_letters[i] = linesU[encRan];
                }
                if (alphabet.letters[i] == "ü")
                {
                    alphabet.enc_letters[i] = linesÜ[encRan];
                }
                if (alphabet.letters[i] == "v")
                {
                    alphabet.enc_letters[i] = linesV[encRan];
                }
                if (alphabet.letters[i] == "y")
                {
                    alphabet.enc_letters[i] = linesY[encRan];
                }
                if (alphabet.letters[i] == "z")
                {
                    alphabet.enc_letters[i] = linesZ[encRan];
                }
                if (alphabet.letters[i] == "x")
                {
                    alphabet.enc_letters[i] = linesX[encRan];
                }
                if (alphabet.letters[i] == "w")
                {
                    alphabet.enc_letters[i] = linesW[encRan];
                }
                if (alphabet.letters[i] == "q")
                {
                    alphabet.enc_letters[i] = linesQ[encRan];
                }
                if (alphabet.letters[i] == "0")
                {
                    alphabet.enc_letters[i] = lines0[encRan];
                }
                if (alphabet.letters[i] == "1")
                {
                    alphabet.enc_letters[i] = lines1[encRan];
                }
                if (alphabet.letters[i] == "2")
                {
                    alphabet.enc_letters[i] = lines2[encRan];
                }
                if (alphabet.letters[i] == "3")
                {
                    alphabet.enc_letters[i] = lines3[encRan];
                }
                if (alphabet.letters[i] == "4")
                {
                    alphabet.enc_letters[i] = lines4[encRan];
                }
                if (alphabet.letters[i] == "5")
                {
                    alphabet.enc_letters[i] = lines5[encRan];
                }
                if (alphabet.letters[i] == "6")
                {
                    alphabet.enc_letters[i] = lines6[encRan];
                }
                if (alphabet.letters[i] == "7")
                {
                    alphabet.enc_letters[i] = lines7[encRan];
                }
                if (alphabet.letters[i] == "8")
                {
                    alphabet.enc_letters[i] = lines8[encRan];
                }
                if (alphabet.letters[i] == "9")
                {
                    alphabet.enc_letters[i] = lines9[encRan];
                }
                if (alphabet.letters[i] == " ")
                {
                    alphabet.enc_letters[i] = linesspace[encRan];
                }
                if (alphabet.letters[i] == "_")
                {
                    alphabet.enc_letters[i] = linesaltçizgi[encRan];
                }

                if (alphabet.letters[i] == "+")
                {
                    alphabet.enc_letters[i] = linesartı[encRan];
                }

                if (alphabet.letters[i] == "/")
                {
                    alphabet.enc_letters[i] = linesbölü[encRan];
                }

                if (alphabet.letters[i] == ">")
                {
                    alphabet.enc_letters[i] = linesbuyuktur[encRan];
                }

                if (alphabet.letters[i] == "*")
                {
                    alphabet.enc_letters[i] = linesçarpı[encRan];
                }                                

                if (alphabet.letters[i] == "-")
                {
                    alphabet.enc_letters[i] = lineseksi[encRan];
                }

                if (alphabet.letters[i] == "@")
                {
                    alphabet.enc_letters[i] = lineset[encRan];
                }

                if (alphabet.letters[i] == ":")
                {
                    alphabet.enc_letters[i] = linesikinokta[encRan];
                }

                if (alphabet.letters[i] == "<")
                {
                    alphabet.enc_letters[i] = lineskucuktur[encRan];
                }

                if (alphabet.letters[i] == ".")
                {
                    alphabet.enc_letters[i] = linesnokta[encRan];
                }

                if (alphabet.letters[i] == ";")
                {
                    alphabet.enc_letters[i] = linessemicolon[encRan];
                }

                if (alphabet.letters[i] == "?")
                {
                    alphabet.enc_letters[i] = linessoruişareti[encRan];
                }

                if (alphabet.letters[i] == "!")
                {
                    alphabet.enc_letters[i] = linesunlem[encRan];
                }

                if (alphabet.letters[i] == ",")
                {
                    alphabet.enc_letters[i] = linesvirgul[encRan];
                }

                if (alphabet.letters[i] == "(")
                {
                    alphabet.enc_letters[i] = linesparaç[encRan];
                }

                if (alphabet.letters[i] == ")")
                {
                    alphabet.enc_letters[i] = linesparkapat[encRan];
                }

                if (alphabet.letters[i] == "%")
                {
                    alphabet.enc_letters[i] = linesyüzde[encRan];
                }

                if (alphabet.letters[i] == "&")
                {
                    alphabet.enc_letters[i] = linesand[encRan];
                }

                if (alphabet.letters[i] == "$")
                {
                    alphabet.enc_letters[i] = linesdolar[encRan];
                }

                if (alphabet.letters[i] == "£")
                {
                    alphabet.enc_letters[i] = lineseuro[encRan];
                }

                if (alphabet.letters[i] == "|")
                {
                    alphabet.enc_letters[i] = linesor[encRan];
                }

                if (alphabet.letters[i] == "é")
                {
                    alphabet.enc_letters[i] = linesecons[encRan];
                }

                if (alphabet.letters[i] == "\"")
                {
                    alphabet.enc_letters[i] = linestırnak[encRan];
                }

                if (alphabet.letters[i] == "'")
                {
                    alphabet.enc_letters[i] = lineskesme[encRan];
                }

                if (alphabet.letters[i] == "^")
                {
                    alphabet.enc_letters[i] = linesüstü[encRan];
                }

                if (alphabet.letters[i] == "{")
                {
                    alphabet.enc_letters[i] = lineskümeaç[encRan];
                }

                if (alphabet.letters[i] == "}")
                {
                    alphabet.enc_letters[i] = lineskümekapat[encRan];
                }

                if (alphabet.letters[i] == "=")
                {
                    alphabet.enc_letters[i] = lineseşittir[encRan];
                }
                if (alphabet.letters[i] == "[")
                {
                    alphabet.enc_letters[i] = lineskpaç[encRan];
                }
                if (alphabet.letters[i] == "]")
                {
                    alphabet.enc_letters[i] = lineskpkapat[encRan];
                }


                // ----------------------------------------------//

                if (alphabet.letters[i] == "A")
                {
                    alphabet.enc_letters[i] = linesA1[encRan];
                }
                if (alphabet.letters[i] == "B")
                {
                    alphabet.enc_letters[i] = linesB1[encRan];
                }
                if (alphabet.letters[i] == "C")
                {
                    alphabet.enc_letters[i] = linesC1[encRan];
                }
                if (alphabet.letters[i] == "Ç")
                {
                    alphabet.enc_letters[i] = linesÇ1[encRan];
                }
                if (alphabet.letters[i] == "D")
                {
                    alphabet.enc_letters[i] = linesD1[encRan];
                }
                if (alphabet.letters[i] == "E")
                {
                    alphabet.enc_letters[i] = linesE1[encRan];
                }
                if (alphabet.letters[i] == "F")
                {
                    alphabet.enc_letters[i] = linesF1[encRan];
                }
                if (alphabet.letters[i] == "G")
                {
                    alphabet.enc_letters[i] = linesG1[encRan];
                }
                if (alphabet.letters[i] == "Ğ")
                {
                    alphabet.enc_letters[i] = linesĞ1[encRan];
                }
                if (alphabet.letters[i] == "H")
                {
                    alphabet.enc_letters[i] = linesH1[encRan];
                }
                if (alphabet.letters[i] == "I")
                {
                    alphabet.enc_letters[i] = linesI1[encRan];
                }
                if (alphabet.letters[i] == "İ")
                {
                    alphabet.enc_letters[i] = linesİ1[encRan];
                }
                if (alphabet.letters[i] == "J")
                {
                    alphabet.enc_letters[i] = linesJ1[encRan];
                }
                if (alphabet.letters[i] == "K")
                {
                    alphabet.enc_letters[i] = linesK1[encRan];
                }
                if (alphabet.letters[i] == "L")
                {
                    alphabet.enc_letters[i] = linesL1[encRan];
                }
                if (alphabet.letters[i] == "M")
                {
                    alphabet.enc_letters[i] = linesM1[encRan];
                }
                if (alphabet.letters[i] == "N")
                {
                    alphabet.enc_letters[i] = linesN1[encRan];
                }
                if (alphabet.letters[i] == "O")
                {
                    alphabet.enc_letters[i] = linesO1[encRan];
                }
                if (alphabet.letters[i] == "Ö")
                {
                    alphabet.enc_letters[i] = linesÖ1[encRan];
                }
                if (alphabet.letters[i] == "P")
                {
                    alphabet.enc_letters[i] = linesP1[encRan];
                }
                if (alphabet.letters[i] == "R")
                {
                    alphabet.enc_letters[i] = linesR1[encRan];
                }
                if (alphabet.letters[i] == "S")
                {
                    alphabet.enc_letters[i] = linesS1[encRan];
                }
                if (alphabet.letters[i] == "Ş")
                {
                    alphabet.enc_letters[i] = linesŞ1[encRan];
                }
                if (alphabet.letters[i] == "T")
                {
                    alphabet.enc_letters[i] = linesT1[encRan];
                }
                if (alphabet.letters[i] == "U")
                {
                    alphabet.enc_letters[i] = linesU1[encRan];
                }
                if (alphabet.letters[i] == "Ü")
                {
                    alphabet.enc_letters[i] = linesÜ1[encRan];
                }
                if (alphabet.letters[i] == "V")
                {
                    alphabet.enc_letters[i] = linesV1[encRan];
                }
                if (alphabet.letters[i] == "Y")
                {
                    alphabet.enc_letters[i] = linesY1[encRan];
                }
                if (alphabet.letters[i] == "Z")
                {
                    alphabet.enc_letters[i] = linesZ1[encRan];
                }
                if (alphabet.letters[i] == "X")
                {
                    alphabet.enc_letters[i] = linesX1[encRan];
                }
                if (alphabet.letters[i] == "W")
                {
                    alphabet.enc_letters[i] = linesW1[encRan];
                }
                if (alphabet.letters[i] == "Q")
                {
                    alphabet.enc_letters[i] = linesQ1[encRan];
                }


            }
            textBox4.Clear();

                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    textBox4.AppendText(alphabet.enc_letters[i]);
                }
            }
        

        private void button2_Click(object sender, EventArgs e)         // Decryption Button
        {


           
            //alphabet.dec_letters[0] = textBox3.Text.Substring(0, 8);  

            textBox2.Clear();
            

            for (int i = 0; i < textBox3.Text.Length /9; i++)
            {
                alphabet.dec_letters[i] = textBox3.Text.Substring(i * 9, 8);                
            }
            
            for (int i = 0; i < 99; i++)
            {
            
                StreamReader forA = new StreamReader("D:\\Vc#\\A\\A.txt");
                string[] linesA = forA.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forB = new StreamReader("D:\\Vc#\\A\\B.txt");
                string[] linesB = forB.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forC = new StreamReader("D:\\Vc#\\A\\C.txt");
                string[] linesC = forC.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forÇ = new StreamReader("D:\\Vc#\\A\\Ç.txt");
                string[] linesÇ = forÇ.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forD = new StreamReader("D:\\Vc#\\A\\D.txt");
                string[] linesD = forD.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forE = new StreamReader("D:\\Vc#\\A\\E.txt");
                string[] linesE = forE.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forF = new StreamReader("D:\\Vc#\\A\\F.txt");
                string[] linesF = forF.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forG = new StreamReader("D:\\Vc#\\A\\G.txt");
                string[] linesG = forG.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forĞ = new StreamReader("D:\\Vc#\\A\\Ğ.txt");
                string[] linesĞ = forĞ.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forH = new StreamReader("D:\\Vc#\\A\\H.txt");
                string[] linesH = forH.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forI = new StreamReader("D:\\Vc#\\A\\I.txt");
                string[] linesI = forI.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forİ = new StreamReader("D:\\Vc#\\A\\İ.txt");
                string[] linesİ = forİ.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forJ = new StreamReader("D:\\Vc#\\A\\J.txt");
                string[] linesJ = forJ.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forK = new StreamReader("D:\\Vc#\\A\\K.txt");
                string[] linesK = forK.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forL = new StreamReader("D:\\Vc#\\A\\L.txt");
                string[] linesL = forL.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forM = new StreamReader("D:\\Vc#\\A\\M.txt");
                string[] linesM = forM.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forN = new StreamReader("D:\\Vc#\\A\\N.txt");
                string[] linesN = forN.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forO = new StreamReader("D:\\Vc#\\A\\O.txt");
                string[] linesO = forO.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forÖ = new StreamReader("D:\\Vc#\\A\\Ö.txt");
                string[] linesÖ = forÖ.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forP = new StreamReader("D:\\Vc#\\A\\P.txt");
                string[] linesP = forP.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forR = new StreamReader("D:\\Vc#\\A\\R.txt");
                string[] linesR = forR.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forS = new StreamReader("D:\\Vc#\\A\\S.txt");
                string[] linesS = forS.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forŞ = new StreamReader("D:\\Vc#\\A\\Ş.txt");
                string[] linesŞ = forŞ.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forT = new StreamReader("D:\\Vc#\\A\\T.txt");
                string[] linesT = forT.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forU = new StreamReader("D:\\Vc#\\A\\U.txt");
                string[] linesU = forU.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forÜ = new StreamReader("D:\\Vc#\\A\\Ü.txt");
                string[] linesÜ = forÜ.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forV = new StreamReader("D:\\Vc#\\A\\V.txt");
                string[] linesV = forV.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forY = new StreamReader("D:\\Vc#\\A\\Y.txt");
                string[] linesY = forY.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forZ = new StreamReader("D:\\Vc#\\A\\Z.txt");
                string[] linesZ = forZ.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forX = new StreamReader("D:\\Vc#\\A\\X.txt");
                string[] linesX = forX.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forW = new StreamReader("D:\\Vc#\\A\\W.txt");
                string[] linesW = forW.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forQ = new StreamReader("D:\\Vc#\\A\\Q.txt");
                string[] linesQ = forQ.ReadToEnd().Split(new char[] { '\n' });

                StreamReader for0 = new StreamReader("D:\\Vc#\\A\\0.txt");
                string[] lines0 = for0.ReadToEnd().Split(new char[] { '\n' });

                StreamReader for1 = new StreamReader("D:\\Vc#\\A\\1.txt");
                string[] lines1 = for1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader for2 = new StreamReader("D:\\Vc#\\A\\2.txt");
                string[] lines2 = for2.ReadToEnd().Split(new char[] { '\n' });

                StreamReader for3 = new StreamReader("D:\\Vc#\\A\\3.txt");
                string[] lines3 = for3.ReadToEnd().Split(new char[] { '\n' });

                StreamReader for4 = new StreamReader("D:\\Vc#\\A\\4.txt");
                string[] lines4 = for4.ReadToEnd().Split(new char[] { '\n' });

                StreamReader for5 = new StreamReader("D:\\Vc#\\A\\5.txt");
                string[] lines5 = for5.ReadToEnd().Split(new char[] { '\n' });

                StreamReader for6 = new StreamReader("D:\\Vc#\\A\\6.txt");
                string[] lines6 = for6.ReadToEnd().Split(new char[] { '\n' });

                StreamReader for7 = new StreamReader("D:\\Vc#\\A\\7.txt");
                string[] lines7 = for7.ReadToEnd().Split(new char[] { '\n' });

                StreamReader for8 = new StreamReader("D:\\Vc#\\A\\8.txt");
                string[] lines8 = for8.ReadToEnd().Split(new char[] { '\n' });

                StreamReader for9 = new StreamReader("D:\\Vc#\\A\\9.txt");
                string[] lines9 = for9.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forspace = new StreamReader("D:\\Vc#\\A\\space.txt");
                string[] linesspace = forspace.ReadToEnd().Split(new char[] { '\n' });

                StreamReader foraltçizgi = new StreamReader("D:\\Vc#\\A\\altçizgi.txt");
                string[] linesaltçizgi = foraltçizgi.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forartı = new StreamReader("D:\\Vc#\\A\\artı.txt");
                string[] linesartı = forartı.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forbölü = new StreamReader("D:\\Vc#\\A\\bölü.txt");
                string[] linesbölü = forbölü.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forbuyuktur = new StreamReader("D:\\Vc#\\A\\buyuktur.txt");
                string[] linesbuyuktur = forbuyuktur.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forçarpı = new StreamReader("D:\\Vc#\\A\\çarpı.txt");
                string[] linesçarpı = forçarpı.ReadToEnd().Split(new char[] { '\n' });

                StreamReader foreksi = new StreamReader("D:\\Vc#\\A\\eksi.txt");
                string[] lineseksi = foreksi.ReadToEnd().Split(new char[] { '\n' });

                StreamReader foret = new StreamReader("D:\\Vc#\\A\\et.txt");
                string[] lineset = foret.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forikinokta = new StreamReader("D:\\Vc#\\A\\ikinokta.txt");
                string[] linesikinokta = forikinokta.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forkucuktur = new StreamReader("D:\\Vc#\\A\\kucuktur.txt");
                string[] lineskucuktur = forkucuktur.ReadToEnd().Split(new char[] { '\n' });

                StreamReader fornokta = new StreamReader("D:\\Vc#\\A\\nokta.txt");
                string[] linesnokta = fornokta.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forsemicolon = new StreamReader("D:\\Vc#\\A\\semicolon.txt");
                string[] linessemicolon = forsemicolon.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forsoruişareti = new StreamReader("D:\\Vc#\\A\\soruişareti.txt");
                string[] linessoruişareti = forsoruişareti.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forunlem = new StreamReader("D:\\Vc#\\A\\unlem.txt");
                string[] linesunlem = forunlem.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forvirgul = new StreamReader("D:\\Vc#\\A\\virgul.txt");
                string[] linesvirgul = forvirgul.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forparaç = new StreamReader("D:\\Vc#\\A\\paraç.txt");
                string[] linesparaç = forparaç.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forparkapat = new StreamReader("D:\\Vc#\\A\\parkapat.txt");
                string[] linesparkapat = forparkapat.ReadToEnd().Split(new char[] { '\n' });

                StreamReader foryüzde = new StreamReader("D:\\Vc#\\A\\yüzde.txt");
                string[] linesyüzde = foryüzde.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forand = new StreamReader("D:\\Vc#\\A\\and.txt");
                string[] linesand = forand.ReadToEnd().Split(new char[] { '\n' });

                StreamReader fordolar = new StreamReader("D:\\Vc#\\A\\dolar.txt");
                string[] linesdolar = fordolar.ReadToEnd().Split(new char[] { '\n' });

                StreamReader foreuro = new StreamReader("D:\\Vc#\\A\\euro.txt");
                string[] lineseuro = foreuro.ReadToEnd().Split(new char[] { '\n' });

                StreamReader foror = new StreamReader("D:\\Vc#\\A\\or.txt");
                string[] linesor = foror.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forecons = new StreamReader("D:\\Vc#\\A\\econs.txt");
                string[] linesecons = forecons.ReadToEnd().Split(new char[] { '\n' });

                StreamReader fortırnak = new StreamReader("D:\\Vc#\\A\\tırnak.txt");
                string[] linestırnak = fortırnak.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forkesme = new StreamReader("D:\\Vc#\\A\\kesme.txt");
                string[] lineskesme = forkesme.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forüstü = new StreamReader("D:\\Vc#\\A\\üstü.txt");
                string[] linesüstü = forüstü.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forkümeaç = new StreamReader("D:\\Vc#\\A\\kümeaç.txt");
                string[] lineskümeaç = forkümeaç.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forkümekapat = new StreamReader("D:\\Vc#\\A\\kümekapat.txt");
                string[] lineskümekapat = forkümekapat.ReadToEnd().Split(new char[] { '\n' });

                StreamReader foreşittir = new StreamReader("D:\\Vc#\\A\\eşittir.txt");
                string[] lineseşittir = foreşittir.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forkpaç = new StreamReader("D:\\Vc#\\A\\kpaç.txt");
                string[] lineskpaç = forkpaç.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forkpkapat = new StreamReader("D:\\Vc#\\A\\kpkapat.txt");
                string[] lineskpkapat = forkpkapat.ReadToEnd().Split(new char[] { '\n' });

                // ----------------------------------------------------------//

                StreamReader forA1 = new StreamReader("D:\\Vc#\\A\\A1.txt");
                string[] linesA1 = forA1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forB1 = new StreamReader("D:\\Vc#\\A\\B1.txt");
                string[] linesB1 = forB1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forC1 = new StreamReader("D:\\Vc#\\A\\C1.txt");
                string[] linesC1 = forC1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forÇ1 = new StreamReader("D:\\Vc#\\A\\Ç1.txt");
                string[] linesÇ1 = forÇ1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forD1 = new StreamReader("D:\\Vc#\\A\\D1.txt");
                string[] linesD1 = forD1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forE1 = new StreamReader("D:\\Vc#\\A\\E1.txt");
                string[] linesE1 = forE1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forF1 = new StreamReader("D:\\Vc#\\A\\F1.txt");
                string[] linesF1 = forF1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forG1 = new StreamReader("D:\\Vc#\\A\\G1.txt");
                string[] linesG1 = forG1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forĞ1 = new StreamReader("D:\\Vc#\\A\\Ğ1.txt");
                string[] linesĞ1 = forĞ1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forH1 = new StreamReader("D:\\Vc#\\A\\H1.txt");
                string[] linesH1 = forH1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forI1 = new StreamReader("D:\\Vc#\\A\\I1.txt");
                string[] linesI1 = forI1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forİ1 = new StreamReader("D:\\Vc#\\A\\İ1.txt");
                string[] linesİ1 = forİ1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forJ1 = new StreamReader("D:\\Vc#\\A\\J1.txt");
                string[] linesJ1 = forJ1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forK1 = new StreamReader("D:\\Vc#\\A\\K1.txt");
                string[] linesK1 = forK1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forL1 = new StreamReader("D:\\Vc#\\A\\L1.txt");
                string[] linesL1 = forL1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forM1 = new StreamReader("D:\\Vc#\\A\\M1.txt");
                string[] linesM1 = forM1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forN1 = new StreamReader("D:\\Vc#\\A\\N1.txt");
                string[] linesN1 = forN1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forO1 = new StreamReader("D:\\Vc#\\A\\O1.txt");
                string[] linesO1 = forO1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forÖ1 = new StreamReader("D:\\Vc#\\A\\Ö1.txt");
                string[] linesÖ1 = forÖ1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forP1 = new StreamReader("D:\\Vc#\\A\\P1.txt");
                string[] linesP1 = forP1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forR1 = new StreamReader("D:\\Vc#\\A\\R1.txt");
                string[] linesR1 = forR1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forS1 = new StreamReader("D:\\Vc#\\A\\S1.txt");
                string[] linesS1 = forS1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forŞ1 = new StreamReader("D:\\Vc#\\A\\Ş1.txt");
                string[] linesŞ1 = forŞ1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forT1 = new StreamReader("D:\\Vc#\\A\\T1.txt");
                string[] linesT1 = forT1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forU1 = new StreamReader("D:\\Vc#\\A\\U1.txt");
                string[] linesU1 = forU1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forÜ1 = new StreamReader("D:\\Vc#\\A\\Ü1.txt");
                string[] linesÜ1 = forÜ1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forV1 = new StreamReader("D:\\Vc#\\A\\V1.txt");
                string[] linesV1 = forV1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forY1 = new StreamReader("D:\\Vc#\\A\\Y1.txt");
                string[] linesY1 = forY1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forZ1 = new StreamReader("D:\\Vc#\\A\\Z1.txt");
                string[] linesZ1 = forZ1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forX1 = new StreamReader("D:\\Vc#\\A\\X1.txt");
                string[] linesX1 = forX1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forW1 = new StreamReader("D:\\Vc#\\A\\W1.txt");
                string[] linesW1 = forW1.ReadToEnd().Split(new char[] { '\n' });

                StreamReader forQ1 = new StreamReader("D:\\Vc#\\A\\Q1.txt");
                string[] linesQ1 = forQ1.ReadToEnd().Split(new char[] { '\n' });

              

                for (int j = 0; j < textBox3.Text.Length /9; j++)                             
                {
                    if (linesA[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("a");
                    }
                    if (linesB[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("b");
                    }
                    if (linesC[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("c");
                    }
                    if (linesÇ[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("ç");
                    }
                    if (linesD[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("d");
                    }
                    if (linesE[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("e");
                    }
                    if (linesF[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("f");
                    }
                    if (linesG[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("g");
                    }
                    if (linesĞ[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("ğ");
                    }
                    if (linesH[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("h");
                    }
                    if (linesI[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("ı");
                    }
                    if (linesİ[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("i");
                    }
                    if (linesJ[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("j");
                    }
                    if (linesK[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("k");
                    }
                    if (linesL[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("l");
                    }
                    if (linesM[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("m");
                    }
                    if (linesN[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("n");
                    }
                    if (linesO[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("o");
                    }
                    if (linesÖ[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("ö");
                    }
                    if (linesP[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("p");
                    }
                    if (linesR[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("r");
                    }
                    if (linesS[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("s");
                    }
                    if (linesŞ[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("ş");
                    }
                    if (linesT[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("t");
                    }
                    if (linesU[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("u");
                    }
                    if (linesÜ[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("ü");
                    }
                    if (linesV[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("v");
                    }
                    if (linesY[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("y");
                    }
                    if (linesZ[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("z");
                    }
                    if (linesX[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("x");
                    }
                    if (linesW[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("w");
                    }
                    if (linesQ[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("q");
                    }
                    if (lines0[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("0");
                    }
                    if (lines1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("1");
                    }
                    if (lines2[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("2");
                    }
                    if (lines3[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("3");
                    }
                    if (lines4[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("4");
                    }
                    if (lines5[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("5");
                    }
                    if (lines6[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("6");
                    }
                    if (lines7[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("7");
                    }
                    if (lines8[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("8");
                    }
                    if (lines9[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("9");
                    }
                    if (linesspace[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText(" ");
                    }
                    if (linesaltçizgi[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("_");
                    }
                    if (linesartı[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("+");
                    }
                    if (linesbölü[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("/");
                    }
                    if (linesbuyuktur[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText(">");
                    }
                    if (linesçarpı[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("*");
                    }
                    if (lineseksi[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("-");
                    }
                    if (lineset[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("@");
                    }
                    if (linesikinokta[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText(":");
                    }
                    if (lineskucuktur[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("<");
                    }
                    if (linesnokta[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText(".");
                    }
                    if (linessemicolon[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText(";");
                    }
                    if (linessoruişareti[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("?");
                    }
                    if (linesunlem[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("!");
                    }
                    if (linesvirgul[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText(",");
                    }
                    if (linesparaç[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("(");
                    }
                    if (linesparkapat[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText(")");
                    }
                    if (linesyüzde[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("%");
                    }
                    if (linesand[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("&");
                    }
                    if (linesdolar[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("$");
                    }
                    if (lineseuro[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("£");
                    }
                    if (linesor[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("|");
                    }
                    if (linesecons[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("é");
                    }
                    if (linestırnak[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("\"");
                    }
                    if (lineskesme[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("'");
                    }
                    if (linesüstü[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("^");
                    }
                    if (lineskümeaç[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("{");
                    }
                    if (lineskümekapat[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("}");
                    }
                    if (lineseşittir[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("=");
                    }
                    if (lineskpaç[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("[");
                    }
                    if (lineskpkapat[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("]");
                    }


                    // --------------------------------------------//

                    if (linesA1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("A");
                    }
                    if (linesB1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("B");
                    }
                    if (linesC1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("C");
                    }
                    if (linesÇ1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("Ç");
                    }
                    if (linesD1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("D");
                    }
                    if (linesE1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("E");
                    }
                    if (linesF1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("F");
                    }
                    if (linesG1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("G");
                    }
                    if (linesĞ1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("Ğ");
                    }
                    if (linesH1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("H");
                    }
                    if (linesI1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("I");
                    }
                    if (linesİ1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("İ");
                    }
                    if (linesJ1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("J");
                    }
                    if (linesK1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("K");
                    }
                    if (linesL1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("L");
                    }
                    if (linesM1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("M");
                    }
                    if (linesN1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("N");
                    }
                    if (linesO1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("O");
                    }
                    if (linesÖ1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("Ö");
                    }
                    if (linesP1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("P");
                    }
                    if (linesR1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("R");
                    }
                    if (linesS1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("S");
                    }
                    if (linesŞ1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("Ş");
                    }
                    if (linesT1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("T");
                    }
                    if (linesU1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("U");
                    }
                    if (linesÜ1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("Ü");
                    }
                    if (linesV1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("V");
                    }
                    if (linesY1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("Y");
                    }
                    if (linesZ1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("Z");
                    }
                    if (linesX1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("X");
                    }
                    if (linesW1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("W");
                    }
                    if (linesQ1[i].Contains(alphabet.dec_letters[j]))
                    {
                        textBox2.AppendText("Q");
                    }
                }

               
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox4.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void button4_Click(object sender, EventArgs e)  // GENERATE 100 Random into File
        {  
            Random rnd = new Random();            
        }

        public static class alphabet
        {
            public static string a, b, c, ç, d, e, f, g, ğ, h, ı, i, j, k, l, m, n, o, ö, p, r, s, ş, t, u, ü, v, y, z, space;
            public static int ct = 0;
            public static int cts = 0;
            public static int lgt = 1000;
            public static string[] letters = new string[lgt];
            public static string[] enc_letters = new string[lgt];
            public static string[] dec_letters = new string[lgt];
        }

        public static class generate
        {
            public static string[] lets = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "v", "y", "z", "x", "q", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "V", "Y", "Z", "X", "Q", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ".", "<", ">", "|", "!", "'", "^", "$", "+", "#", "%", "&", "/", "{", "(", "[", ")", "]", "=", "}", "?", "*", "-", "_", "£", "," };
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox4.Visible = true;
            button1.Visible  = true;
            button7.Visible = false;
            button6.Visible = true;
            textBox2.Visible = false;
            textBox3.Visible = false;
            button2.Visible  = false;
            button8.Visible = true;

            pictureBox4.Visible = false;
            pictureBox3.Visible = true;

            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox4.Visible = false;
            button1.Visible  = false;
            button7.Visible = true;
            button6.Visible = false;
            button8.Visible = true;

            textBox2.Visible = true;
            textBox3.Visible = true;
            button2.Visible  = true;

            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            pictureBox4.Visible = true;
            pictureBox3.Visible = false;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox4.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
                reader.SpeakAsync(textBox1.Text);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
                reader.SpeakAsync(textBox2.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.SelectAll();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Enabled == true)
            {
                textBox4.Focus();
                textBox4.SelectAll();
            }
            if (radioButton2.Enabled == true)
            {
                textBox2.Focus();
                textBox2.SelectAll();
            }   
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Focus();
            textBox3.SelectAll();
        }
                
    }
}

