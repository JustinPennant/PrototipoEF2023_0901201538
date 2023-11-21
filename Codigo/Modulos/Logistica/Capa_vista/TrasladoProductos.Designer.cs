
namespace Vista_PrototipoMenu
{
    partial class TrasladoProductos
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_traslaProd = new System.Windows.Forms.DataGridView();
            this.navegador1 = new NavegadorVista.Navegador();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_codigo_nomina = new System.Windows.Forms.TextBox();
            this.txt_fecha_inicial_nomina = new System.Windows.Forms.TextBox();
            this.txt_fecha_final_nomina = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_traslaProd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_traslaProd);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(31, 434);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(1005, 353);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tabla Demostrativa";
            // 
            // dgv_traslaProd
            // 
            this.dgv_traslaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_traslaProd.Location = new System.Drawing.Point(32, 30);
            this.dgv_traslaProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_traslaProd.Name = "dgv_traslaProd";
            this.dgv_traslaProd.RowHeadersWidth = 51;
            this.dgv_traslaProd.RowTemplate.Height = 24;
            this.dgv_traslaProd.Size = new System.Drawing.Size(951, 304);
            this.dgv_traslaProd.TabIndex = 0;
            this.dgv_traslaProd.Tag = "nominae";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(151, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(765, 187);
            this.navegador1.TabIndex = 23;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Código Nomina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Fecha Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Fecha Final";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_codigo_nomina
            // 
            this.txt_codigo_nomina.Location = new System.Drawing.Point(518, 270);
            this.txt_codigo_nomina.Name = "txt_codigo_nomina";
            this.txt_codigo_nomina.Size = new System.Drawing.Size(187, 22);
            this.txt_codigo_nomina.TabIndex = 27;
            // 
            // txt_fecha_inicial_nomina
            // 
            this.txt_fecha_inicial_nomina.Location = new System.Drawing.Point(518, 300);
            this.txt_fecha_inicial_nomina.Name = "txt_fecha_inicial_nomina";
            this.txt_fecha_inicial_nomina.Size = new System.Drawing.Size(187, 22);
            this.txt_fecha_inicial_nomina.TabIndex = 28;
            // 
            // txt_fecha_final_nomina
            // 
            this.txt_fecha_final_nomina.Location = new System.Drawing.Point(518, 333);
            this.txt_fecha_final_nomina.Name = "txt_fecha_final_nomina";
            this.txt_fecha_final_nomina.Size = new System.Drawing.Size(187, 22);
            this.txt_fecha_final_nomina.TabIndex = 29;
            // 
            // TrasladoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1064, 800);
            this.Controls.Add(this.txt_fecha_final_nomina);
            this.Controls.Add(this.txt_fecha_inicial_nomina);
            this.Controls.Add(this.txt_codigo_nomina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.groupBox4);
            this.Name = "TrasladoProductos";
            this.Text = "Nominas Examen Final";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_traslaProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_traslaProd;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_codigo_nomina;
        private System.Windows.Forms.TextBox txt_fecha_inicial_nomina;
        private System.Windows.Forms.TextBox txt_fecha_final_nomina;
    }
}