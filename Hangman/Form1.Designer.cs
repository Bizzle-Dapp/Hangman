namespace Hangman
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbTheWord = new System.Windows.Forms.TextBox();
            this.btnUseWord = new System.Windows.Forms.Button();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.lblLetter1 = new System.Windows.Forms.Label();
            this.lblLetter2 = new System.Windows.Forms.Label();
            this.lblLetter3 = new System.Windows.Forms.Label();
            this.lblLetter4 = new System.Windows.Forms.Label();
            this.lblLetter5 = new System.Windows.Forms.Label();
            this.lblLetter6 = new System.Windows.Forms.Label();
            this.lblLetter7 = new System.Windows.Forms.Label();
            this.lblLetter8 = new System.Windows.Forms.Label();
            this.lblLetter9 = new System.Windows.Forms.Label();
            this.lblLetter10 = new System.Windows.Forms.Label();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.failBar = new System.Windows.Forms.ProgressBar();
            this.tbGuessedBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the word (MAX 10 CHAR): ";
            // 
            // tbTheWord
            // 
            this.tbTheWord.Location = new System.Drawing.Point(169, 6);
            this.tbTheWord.Name = "tbTheWord";
            this.tbTheWord.Size = new System.Drawing.Size(241, 20);
            this.tbTheWord.TabIndex = 1;
            // 
            // btnUseWord
            // 
            this.btnUseWord.Location = new System.Drawing.Point(428, 4);
            this.btnUseWord.Name = "btnUseWord";
            this.btnUseWord.Size = new System.Drawing.Size(102, 23);
            this.btnUseWord.TabIndex = 2;
            this.btnUseWord.Text = "Use This Word";
            this.btnUseWord.UseVisualStyleBackColor = true;
            this.btnUseWord.Click += new System.EventHandler(this.btnUseWord_Click);
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.Location = new System.Drawing.Point(455, 461);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(105, 42);
            this.btnRestartGame.TabIndex = 3;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = true;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // lblLetter1
            // 
            this.lblLetter1.AutoSize = true;
            this.lblLetter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblLetter1.Location = new System.Drawing.Point(116, 82);
            this.lblLetter1.Name = "lblLetter1";
            this.lblLetter1.Size = new System.Drawing.Size(25, 29);
            this.lblLetter1.TabIndex = 4;
            this.lblLetter1.Text = "?";
            // 
            // lblLetter2
            // 
            this.lblLetter2.AutoSize = true;
            this.lblLetter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblLetter2.Location = new System.Drawing.Point(146, 82);
            this.lblLetter2.Name = "lblLetter2";
            this.lblLetter2.Size = new System.Drawing.Size(25, 29);
            this.lblLetter2.TabIndex = 5;
            this.lblLetter2.Text = "?";
            // 
            // lblLetter3
            // 
            this.lblLetter3.AutoSize = true;
            this.lblLetter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblLetter3.Location = new System.Drawing.Point(177, 82);
            this.lblLetter3.Name = "lblLetter3";
            this.lblLetter3.Size = new System.Drawing.Size(25, 29);
            this.lblLetter3.TabIndex = 6;
            this.lblLetter3.Text = "?";
            // 
            // lblLetter4
            // 
            this.lblLetter4.AutoSize = true;
            this.lblLetter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblLetter4.Location = new System.Drawing.Point(208, 82);
            this.lblLetter4.Name = "lblLetter4";
            this.lblLetter4.Size = new System.Drawing.Size(25, 29);
            this.lblLetter4.TabIndex = 7;
            this.lblLetter4.Text = "?";
            // 
            // lblLetter5
            // 
            this.lblLetter5.AutoSize = true;
            this.lblLetter5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblLetter5.Location = new System.Drawing.Point(239, 82);
            this.lblLetter5.Name = "lblLetter5";
            this.lblLetter5.Size = new System.Drawing.Size(25, 29);
            this.lblLetter5.TabIndex = 8;
            this.lblLetter5.Text = "?";
            // 
            // lblLetter6
            // 
            this.lblLetter6.AutoSize = true;
            this.lblLetter6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblLetter6.Location = new System.Drawing.Point(270, 82);
            this.lblLetter6.Name = "lblLetter6";
            this.lblLetter6.Size = new System.Drawing.Size(25, 29);
            this.lblLetter6.TabIndex = 9;
            this.lblLetter6.Text = "?";
            // 
            // lblLetter7
            // 
            this.lblLetter7.AutoSize = true;
            this.lblLetter7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblLetter7.Location = new System.Drawing.Point(301, 82);
            this.lblLetter7.Name = "lblLetter7";
            this.lblLetter7.Size = new System.Drawing.Size(25, 29);
            this.lblLetter7.TabIndex = 10;
            this.lblLetter7.Text = "?";
            // 
            // lblLetter8
            // 
            this.lblLetter8.AutoSize = true;
            this.lblLetter8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblLetter8.Location = new System.Drawing.Point(332, 82);
            this.lblLetter8.Name = "lblLetter8";
            this.lblLetter8.Size = new System.Drawing.Size(25, 29);
            this.lblLetter8.TabIndex = 11;
            this.lblLetter8.Text = "?";
            // 
            // lblLetter9
            // 
            this.lblLetter9.AutoSize = true;
            this.lblLetter9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblLetter9.Location = new System.Drawing.Point(363, 82);
            this.lblLetter9.Name = "lblLetter9";
            this.lblLetter9.Size = new System.Drawing.Size(25, 29);
            this.lblLetter9.TabIndex = 12;
            this.lblLetter9.Text = "?";
            // 
            // lblLetter10
            // 
            this.lblLetter10.AutoSize = true;
            this.lblLetter10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblLetter10.Location = new System.Drawing.Point(394, 82);
            this.lblLetter10.Name = "lblLetter10";
            this.lblLetter10.Size = new System.Drawing.Size(25, 29);
            this.lblLetter10.TabIndex = 13;
            this.lblLetter10.Text = "?";
            // 
            // btnQ
            // 
            this.btnQ.Location = new System.Drawing.Point(59, 425);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(30, 30);
            this.btnQ.TabIndex = 14;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = true;
            this.btnQ.Click += new System.EventHandler(this.btnQ_Click);
            // 
            // btnW
            // 
            this.btnW.Location = new System.Drawing.Point(95, 425);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(30, 30);
            this.btnW.TabIndex = 15;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
            this.btnW.Click += new System.EventHandler(this.btnW_Click);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(131, 425);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(30, 30);
            this.btnE.TabIndex = 16;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(167, 425);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(30, 30);
            this.btnR.TabIndex = 17;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(203, 425);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(30, 30);
            this.btnT.TabIndex = 18;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnY
            // 
            this.btnY.Location = new System.Drawing.Point(239, 425);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(30, 30);
            this.btnY.TabIndex = 19;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.Click += new System.EventHandler(this.btnY_Click);
            // 
            // btnU
            // 
            this.btnU.Location = new System.Drawing.Point(275, 425);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(30, 30);
            this.btnU.TabIndex = 20;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // btnI
            // 
            this.btnI.Location = new System.Drawing.Point(311, 425);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(30, 30);
            this.btnI.TabIndex = 21;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = true;
            this.btnI.Click += new System.EventHandler(this.btnI_Click);
            // 
            // btnO
            // 
            this.btnO.Location = new System.Drawing.Point(347, 425);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(30, 30);
            this.btnO.TabIndex = 22;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.Click += new System.EventHandler(this.btnO_Click);
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(383, 425);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(30, 30);
            this.btnP.TabIndex = 23;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(75, 461);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(30, 30);
            this.btnA.TabIndex = 24;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(111, 461);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(30, 30);
            this.btnS.TabIndex = 25;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(147, 461);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(30, 30);
            this.btnD.TabIndex = 26;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnF
            // 
            this.btnF.Location = new System.Drawing.Point(183, 461);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(30, 30);
            this.btnF.TabIndex = 27;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // btnG
            // 
            this.btnG.Location = new System.Drawing.Point(219, 461);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(30, 30);
            this.btnG.TabIndex = 28;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // btnH
            // 
            this.btnH.Location = new System.Drawing.Point(255, 461);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(30, 30);
            this.btnH.TabIndex = 29;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = true;
            this.btnH.Click += new System.EventHandler(this.btnH_Click);
            // 
            // btnJ
            // 
            this.btnJ.Location = new System.Drawing.Point(290, 461);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(30, 30);
            this.btnJ.TabIndex = 30;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = true;
            this.btnJ.Click += new System.EventHandler(this.btnJ_Click);
            // 
            // btnK
            // 
            this.btnK.Location = new System.Drawing.Point(326, 461);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(30, 30);
            this.btnK.TabIndex = 31;
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = true;
            this.btnK.Click += new System.EventHandler(this.btnK_Click);
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(362, 461);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(30, 30);
            this.btnL.TabIndex = 32;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnZ
            // 
            this.btnZ.Location = new System.Drawing.Point(111, 497);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(30, 30);
            this.btnZ.TabIndex = 33;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = true;
            this.btnZ.Click += new System.EventHandler(this.btnZ_Click);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(147, 497);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(30, 30);
            this.btnX.TabIndex = 34;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(183, 497);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(30, 30);
            this.btnC.TabIndex = 35;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnV
            // 
            this.btnV.Location = new System.Drawing.Point(219, 497);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(30, 30);
            this.btnV.TabIndex = 36;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = true;
            this.btnV.Click += new System.EventHandler(this.btnV_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(255, 497);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(30, 30);
            this.btnB.TabIndex = 37;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnN
            // 
            this.btnN.Location = new System.Drawing.Point(291, 497);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(30, 30);
            this.btnN.TabIndex = 38;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnM
            // 
            this.btnM.Location = new System.Drawing.Point(327, 497);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(30, 30);
            this.btnM.TabIndex = 39;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // failBar
            // 
            this.failBar.Location = new System.Drawing.Point(43, 207);
            this.failBar.Name = "failBar";
            this.failBar.Size = new System.Drawing.Size(461, 74);
            this.failBar.Step = 15;
            this.failBar.TabIndex = 40;
            this.failBar.Click += new System.EventHandler(this.failBar_Click);
            // 
            // tbGuessedBox
            // 
            this.tbGuessedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbGuessedBox.Location = new System.Drawing.Point(10, 388);
            this.tbGuessedBox.Name = "tbGuessedBox";
            this.tbGuessedBox.Size = new System.Drawing.Size(563, 26);
            this.tbGuessedBox.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.tbGuessedBox);
            this.Controls.Add(this.failBar);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnZ);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.btnJ);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnQ);
            this.Controls.Add(this.lblLetter10);
            this.Controls.Add(this.lblLetter9);
            this.Controls.Add(this.lblLetter8);
            this.Controls.Add(this.lblLetter7);
            this.Controls.Add(this.lblLetter6);
            this.Controls.Add(this.lblLetter5);
            this.Controls.Add(this.lblLetter4);
            this.Controls.Add(this.lblLetter3);
            this.Controls.Add(this.lblLetter2);
            this.Controls.Add(this.lblLetter1);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.btnUseWord);
            this.Controls.Add(this.tbTheWord);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Hangman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTheWord;
        private System.Windows.Forms.Button btnUseWord;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Label lblLetter1;
        private System.Windows.Forms.Label lblLetter2;
        private System.Windows.Forms.Label lblLetter3;
        private System.Windows.Forms.Label lblLetter4;
        private System.Windows.Forms.Label lblLetter5;
        private System.Windows.Forms.Label lblLetter6;
        private System.Windows.Forms.Label lblLetter7;
        private System.Windows.Forms.Label lblLetter8;
        private System.Windows.Forms.Label lblLetter9;
        private System.Windows.Forms.Label lblLetter10;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.ProgressBar failBar;
        private System.Windows.Forms.TextBox tbGuessedBox;
    }
}

