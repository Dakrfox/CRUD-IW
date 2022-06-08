namespace CRUD_IW
{
    partial class Form1
    {
        /// <summary>
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_names = new System.Windows.Forms.TextBox();
            this.txt_Lnames = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.view_tb = new System.Windows.Forms.DataGridView();
            this.txt_cc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.check_masculino = new System.Windows.Forms.RadioButton();
            this.check_femenino = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.check_intersexual = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.view_tb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO CLIENTE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRES";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_names
            // 
            this.txt_names.Location = new System.Drawing.Point(219, 98);
            this.txt_names.Name = "txt_names";
            this.txt_names.Size = new System.Drawing.Size(677, 23);
            this.txt_names.TabIndex = 2;
            this.txt_names.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_Lnames
            // 
            this.txt_Lnames.Location = new System.Drawing.Point(219, 137);
            this.txt_Lnames.Name = "txt_Lnames";
            this.txt_Lnames.Size = new System.Drawing.Size(677, 23);
            this.txt_Lnames.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "APELLIDOS";
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(219, 181);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(79, 23);
            this.txt_age.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "EDAD";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "DIRECCION";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(573, 184);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(323, 23);
            this.txt_address.TabIndex = 8;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(62, 327);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(125, 23);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "AGREGAR";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "CONSULTAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(324, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "ACTUALIZAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(455, 327);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "ELIMINAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(691, 298);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "MAYORES DE 20";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(691, 327);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(205, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "CATEGORIZAR POR SEXO";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // view_tb
            // 
            this.view_tb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_tb.Location = new System.Drawing.Point(12, 388);
            this.view_tb.Name = "view_tb";
            this.view_tb.RowTemplate.Height = 25;
            this.view_tb.Size = new System.Drawing.Size(884, 447);
            this.view_tb.TabIndex = 15;
            // 
            // txt_cc
            // 
            this.txt_cc.Location = new System.Drawing.Point(219, 58);
            this.txt_cc.Name = "txt_cc";
            this.txt_cc.Size = new System.Drawing.Size(677, 23);
            this.txt_cc.TabIndex = 17;
            this.txt_cc.TextChanged += new System.EventHandler(this.txt_cc_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "# ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // check_masculino
            // 
            this.check_masculino.AutoSize = true;
            this.check_masculino.Location = new System.Drawing.Point(219, 235);
            this.check_masculino.Name = "check_masculino";
            this.check_masculino.Size = new System.Drawing.Size(93, 19);
            this.check_masculino.TabIndex = 18;
            this.check_masculino.TabStop = true;
            this.check_masculino.Text = "MASCULINO";
            this.check_masculino.UseVisualStyleBackColor = true;
            this.check_masculino.CheckedChanged += new System.EventHandler(this.check_masculino_CheckedChanged);
            // 
            // check_femenino
            // 
            this.check_femenino.AutoSize = true;
            this.check_femenino.Location = new System.Drawing.Point(355, 235);
            this.check_femenino.Name = "check_femenino";
            this.check_femenino.Size = new System.Drawing.Size(84, 19);
            this.check_femenino.TabIndex = 19;
            this.check_femenino.TabStop = true;
            this.check_femenino.Text = "FEMENINO";
            this.check_femenino.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "SEXO";
            // 
            // check_intersexual
            // 
            this.check_intersexual.AutoSize = true;
            this.check_intersexual.Location = new System.Drawing.Point(477, 237);
            this.check_intersexual.Name = "check_intersexual";
            this.check_intersexual.Size = new System.Drawing.Size(97, 19);
            this.check_intersexual.TabIndex = 21;
            this.check_intersexual.TabStop = true;
            this.check_intersexual.Text = "INTERSEXUAL";
            this.check_intersexual.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 847);
            this.Controls.Add(this.check_intersexual);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.check_femenino);
            this.Controls.Add(this.check_masculino);
            this.Controls.Add(this.txt_cc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.view_tb);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Lnames);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_names);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_tb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_names;
        private TextBox txt_Lnames;
        private Label label3;
        private TextBox txt_age;
        private Label label4;
        private Label label5;
        private TextBox txt_address;
        private Button btn_add;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private DataGridView view_tb;
        private TextBox txt_cc;
        private Label label6;
        private RadioButton check_masculino;
        private RadioButton check_femenino;
        private Label label7;
        private RadioButton check_intersexual;
    }
}