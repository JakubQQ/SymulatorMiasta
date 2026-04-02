namespace SymulatorMiasta
{
    partial class Form1
    {
        /// <summary>
        /// dupary
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ProgresZbiorow = new ProgressBar();
            progresPodatki = new ProgressBar();
            progresNegocjacje = new ProgressBar();
            Skryba = new PictureBox();
            wladca = new PictureBox();
            ZbioryButton = new Button();
            PodatkiButton = new Button();
            NegocjujButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ZadowolenieLudu = new ProgressBar();
            label4 = new Label();
            pictureLud = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            Naprawa = new Button();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)Skryba).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wladca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureLud).BeginInit();
            SuspendLayout();
            // 
            // ProgresZbiorow
            // 
            ProgresZbiorow.Location = new Point(12, 399);
            ProgresZbiorow.Name = "ProgresZbiorow";
            ProgresZbiorow.Size = new Size(282, 29);
            ProgresZbiorow.TabIndex = 0;
            // 
            // progresPodatki
            // 
            progresPodatki.Location = new Point(300, 399);
            progresPodatki.Name = "progresPodatki";
            progresPodatki.Size = new Size(282, 29);
            progresPodatki.TabIndex = 1;
            // 
            // progresNegocjacje
            // 
            progresNegocjacje.Location = new Point(588, 399);
            progresNegocjacje.Name = "progresNegocjacje";
            progresNegocjacje.Size = new Size(200, 29);
            progresNegocjacje.TabIndex = 2;
            // 
            // Skryba
            // 
            Skryba.BackgroundImage = Properties.Resources.skryba;
            Skryba.BackgroundImageLayout = ImageLayout.Stretch;
            Skryba.Location = new Point(663, 257);
            Skryba.Name = "Skryba";
            Skryba.Size = new Size(125, 136);
            Skryba.TabIndex = 3;
            Skryba.TabStop = false;
            // 
            // wladca
            // 
            wladca.BackgroundImage = Properties.Resources.wladca;
            wladca.BackgroundImageLayout = ImageLayout.Stretch;
            wladca.Location = new Point(12, 12);
            wladca.Name = "wladca";
            wladca.Size = new Size(213, 391);
            wladca.TabIndex = 4;
            wladca.TabStop = false;
            // 
            // ZbioryButton
            // 
            ZbioryButton.Location = new Point(231, 252);
            ZbioryButton.Name = "ZbioryButton";
            ZbioryButton.Size = new Size(50, 43);
            ZbioryButton.TabIndex = 5;
            ZbioryButton.UseVisualStyleBackColor = true;
            ZbioryButton.Click += ZbioryButton_Click;
            ZbioryButton.MouseLeave += Guizk_MouseLeave;
            ZbioryButton.MouseHover += ZbioryButton_MouseHover;
            // 
            // PodatkiButton
            // 
            PodatkiButton.Location = new Point(231, 301);
            PodatkiButton.Name = "PodatkiButton";
            PodatkiButton.Size = new Size(50, 43);
            PodatkiButton.TabIndex = 6;
            PodatkiButton.UseVisualStyleBackColor = true;
            PodatkiButton.Click += PodatkiButton_Click;
            PodatkiButton.MouseLeave += Guizk_MouseLeave;
            PodatkiButton.MouseHover += PodatkiButton_MouseHover;
            // 
            // NegocjujButton
            // 
            NegocjujButton.Location = new Point(231, 350);
            NegocjujButton.Name = "NegocjujButton";
            NegocjujButton.Size = new Size(50, 43);
            NegocjujButton.TabIndex = 7;
            NegocjujButton.UseVisualStyleBackColor = true;
            NegocjujButton.Click += NegocjujButton_Click;
            NegocjujButton.MouseLeave += Guizk_MouseLeave;
            NegocjujButton.MouseHover += NegocjujButton_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(287, 267);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 312);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 9;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(287, 361);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 10;
            label3.Text = "label3";
            // 
            // ZadowolenieLudu
            // 
            ZadowolenieLudu.Location = new Point(663, 12);
            ZadowolenieLudu.Name = "ZadowolenieLudu";
            ZadowolenieLudu.Size = new Size(125, 29);
            ZadowolenieLudu.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(663, 35);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 12;
            label4.Text = "label4";
            // 
            // pictureLud
            // 
            pictureLud.BackgroundImage = Properties.Resources.lud;
            pictureLud.BackgroundImageLayout = ImageLayout.Stretch;
            pictureLud.Location = new Point(663, 58);
            pictureLud.Name = "pictureLud";
            pictureLud.Size = new Size(125, 108);
            pictureLud.TabIndex = 13;
            pictureLud.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 431);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 14;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(300, 431);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 15;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(588, 431);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 16;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(408, 205);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 17;
            label8.Text = "label8";
            // 
            // Naprawa
            // 
            Naprawa.Location = new Point(540, 257);
            Naprawa.Name = "Naprawa";
            Naprawa.Size = new Size(117, 52);
            Naprawa.TabIndex = 18;
            Naprawa.Text = "button1";
            Naprawa.UseVisualStyleBackColor = true;
            Naprawa.Click += Naprawa_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(540, 205);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 19;
            label9.Text = "label9";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.tlo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(Naprawa);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureLud);
            Controls.Add(label4);
            Controls.Add(ZadowolenieLudu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NegocjujButton);
            Controls.Add(PodatkiButton);
            Controls.Add(ZbioryButton);
            Controls.Add(wladca);
            Controls.Add(Skryba);
            Controls.Add(progresNegocjacje);
            Controls.Add(progresPodatki);
            Controls.Add(ProgresZbiorow);
            Name = "Form1";
            Text = "SymulatorMiasta";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)Skryba).EndInit();
            ((System.ComponentModel.ISupportInitialize)wladca).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureLud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar ProgresZbiorow;
        private ProgressBar progresPodatki;
        private ProgressBar progresNegocjacje;
        private PictureBox Skryba;
        private PictureBox wladca;
        private Button ZbioryButton;
        private Button PodatkiButton;
        private Button NegocjujButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private ProgressBar ZadowolenieLudu;
        private Label label4;
        private PictureBox pictureLud;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button Naprawa;
        private Label label9;
    }
}