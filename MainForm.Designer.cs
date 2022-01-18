namespace MainForm
{
    partial class MyMainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SumPurchase = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.LengthT = new System.Windows.Forms.TextBox();
            this.LengthL = new System.Windows.Forms.Label();
            this.WidthL = new System.Windows.Forms.Label();
            this.WidthT = new System.Windows.Forms.TextBox();
            this.SizeAddWidthT = new System.Windows.Forms.TextBox();
            this.SizeAddWidthL = new System.Windows.Forms.Label();
            this.SizeAddLenghtL = new System.Windows.Forms.Label();
            this.SizeAddLenghtT = new System.Windows.Forms.TextBox();
            this.AllTile = new System.Windows.Forms.TreeView();
            this.InfoTile = new System.Windows.Forms.Label();
            this.computeOne = new System.Windows.Forms.Button();
            this.PriceOneP = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberRequiredBundles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(382, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Печатать чек";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(12, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Положить в корзину";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SumPurchase
            // 
            this.SumPurchase.BackColor = System.Drawing.SystemColors.Info;
            this.SumPurchase.Font = new System.Drawing.Font("Microsoft Tai Le", 20F);
            this.SumPurchase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SumPurchase.Location = new System.Drawing.Point(12, 475);
            this.SumPurchase.Multiline = true;
            this.SumPurchase.Name = "SumPurchase";
            this.SumPurchase.ReadOnly = true;
            this.SumPurchase.Size = new System.Drawing.Size(253, 64);
            this.SumPurchase.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Window;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button3.Location = new System.Drawing.Point(382, 421);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(253, 48);
            this.button3.TabIndex = 4;
            this.button3.Text = "Сбросить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LengthT
            // 
            this.LengthT.Location = new System.Drawing.Point(117, 291);
            this.LengthT.Name = "LengthT";
            this.LengthT.Size = new System.Drawing.Size(144, 22);
            this.LengthT.TabIndex = 5;
            // 
            // LengthL
            // 
            this.LengthL.AutoSize = true;
            this.LengthL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LengthL.Location = new System.Drawing.Point(8, 292);
            this.LengthL.Name = "LengthL";
            this.LengthL.Size = new System.Drawing.Size(53, 20);
            this.LengthL.TabIndex = 6;
            this.LengthL.Text = "label1";
            this.LengthL.Click += new System.EventHandler(this.Lengthl_Click);
            // 
            // WidthL
            // 
            this.WidthL.AutoSize = true;
            this.WidthL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.WidthL.Location = new System.Drawing.Point(4, 339);
            this.WidthL.Name = "WidthL";
            this.WidthL.Size = new System.Drawing.Size(53, 20);
            this.WidthL.TabIndex = 7;
            this.WidthL.Text = "label2";
            // 
            // WidthT
            // 
            this.WidthT.Location = new System.Drawing.Point(117, 339);
            this.WidthT.Name = "WidthT";
            this.WidthT.Size = new System.Drawing.Size(144, 22);
            this.WidthT.TabIndex = 9;
            // 
            // SizeAddWidthT
            // 
            this.SizeAddWidthT.Location = new System.Drawing.Point(505, 335);
            this.SizeAddWidthT.Name = "SizeAddWidthT";
            this.SizeAddWidthT.Size = new System.Drawing.Size(144, 22);
            this.SizeAddWidthT.TabIndex = 13;
            this.SizeAddWidthT.TextChanged += new System.EventHandler(this.SizeAddWidthT_TextChanged);
            // 
            // SizeAddWidthL
            // 
            this.SizeAddWidthL.AutoSize = true;
            this.SizeAddWidthL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SizeAddWidthL.Location = new System.Drawing.Point(325, 341);
            this.SizeAddWidthL.Name = "SizeAddWidthL";
            this.SizeAddWidthL.Size = new System.Drawing.Size(53, 20);
            this.SizeAddWidthL.TabIndex = 12;
            this.SizeAddWidthL.Text = "label2";
            this.SizeAddWidthL.Click += new System.EventHandler(this.SizeAddWidthL_Click);
            // 
            // SizeAddLenghtL
            // 
            this.SizeAddLenghtL.AutoSize = true;
            this.SizeAddLenghtL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SizeAddLenghtL.Location = new System.Drawing.Point(325, 292);
            this.SizeAddLenghtL.Name = "SizeAddLenghtL";
            this.SizeAddLenghtL.Size = new System.Drawing.Size(53, 20);
            this.SizeAddLenghtL.TabIndex = 11;
            this.SizeAddLenghtL.Text = "label1";
            this.SizeAddLenghtL.Click += new System.EventHandler(this.SizeAddLenghtL_Click);
            // 
            // SizeAddLenghtT
            // 
            this.SizeAddLenghtT.Location = new System.Drawing.Point(505, 289);
            this.SizeAddLenghtT.Name = "SizeAddLenghtT";
            this.SizeAddLenghtT.Size = new System.Drawing.Size(144, 22);
            this.SizeAddLenghtT.TabIndex = 10;
            this.SizeAddLenghtT.TextChanged += new System.EventHandler(this.SizeWT_TextChanged);
            // 
            // AllTile
            // 
            this.AllTile.BackColor = System.Drawing.SystemColors.Info;
            this.AllTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AllTile.Indent = 30;
            this.AllTile.ItemHeight = 25;
            this.AllTile.Location = new System.Drawing.Point(709, 12);
            this.AllTile.Name = "AllTile";
            this.AllTile.Size = new System.Drawing.Size(448, 527);
            this.AllTile.TabIndex = 14;
            this.AllTile.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.AllTile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllTile_MouseDown);
            // 
            // InfoTile
            // 
            this.InfoTile.AutoSize = true;
            this.InfoTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.InfoTile.Location = new System.Drawing.Point(7, 29);
            this.InfoTile.Name = "InfoTile";
            this.InfoTile.Size = new System.Drawing.Size(279, 29);
            this.InfoTile.TabIndex = 15;
            this.InfoTile.Text = "Информация о товаре:";
            this.InfoTile.Click += new System.EventHandler(this.label1_Click);
            // 
            // computeOne
            // 
            this.computeOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.computeOne.Location = new System.Drawing.Point(290, 380);
            this.computeOne.Name = "computeOne";
            this.computeOne.Size = new System.Drawing.Size(75, 30);
            this.computeOne.TabIndex = 16;
            this.computeOne.Text = "Ok";
            this.computeOne.UseVisualStyleBackColor = true;
            this.computeOne.Click += new System.EventHandler(this.computeOne_Click);
            // 
            // PriceOneP
            // 
            this.PriceOneP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PriceOneP.Location = new System.Drawing.Point(55, 227);
            this.PriceOneP.Multiline = true;
            this.PriceOneP.Name = "PriceOneP";
            this.PriceOneP.ReadOnly = true;
            this.PriceOneP.Size = new System.Drawing.Size(179, 33);
            this.PriceOneP.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(271, 499);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 27);
            this.button4.TabIndex = 18;
            this.button4.Text = "Х";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(4, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(365, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "label2";
            // 
            // numberRequiredBundles
            // 
            this.numberRequiredBundles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numberRequiredBundles.Location = new System.Drawing.Point(448, 227);
            this.numberRequiredBundles.Multiline = true;
            this.numberRequiredBundles.Name = "numberRequiredBundles";
            this.numberRequiredBundles.ReadOnly = true;
            this.numberRequiredBundles.Size = new System.Drawing.Size(148, 33);
            this.numberRequiredBundles.TabIndex = 21;
            // 
            // MyMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1169, 553);
            this.Controls.Add(this.numberRequiredBundles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.PriceOneP);
            this.Controls.Add(this.computeOne);
            this.Controls.Add(this.InfoTile);
            this.Controls.Add(this.AllTile);
            this.Controls.Add(this.SizeAddWidthT);
            this.Controls.Add(this.SizeAddWidthL);
            this.Controls.Add(this.SizeAddLenghtL);
            this.Controls.Add(this.SizeAddLenghtT);
            this.Controls.Add(this.WidthT);
            this.Controls.Add(this.WidthL);
            this.Controls.Add(this.LengthL);
            this.Controls.Add(this.LengthT);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SumPurchase);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyMainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StroyShop";
            this.Load += new System.EventHandler(this.MyMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox SumPurchase;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox LengthT;
        private System.Windows.Forms.Label LengthL;
        private System.Windows.Forms.Label WidthL;
        private System.Windows.Forms.TextBox WidthT;
        private System.Windows.Forms.TextBox SizeAddWidthT;
        private System.Windows.Forms.Label SizeAddWidthL;
        private System.Windows.Forms.Label SizeAddLenghtL;
        private System.Windows.Forms.TextBox SizeAddLenghtT;
        private System.Windows.Forms.TreeView AllTile;
        private System.Windows.Forms.Label InfoTile;
        private System.Windows.Forms.Button computeOne;
        private System.Windows.Forms.TextBox PriceOneP;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberRequiredBundles;
    }
}

