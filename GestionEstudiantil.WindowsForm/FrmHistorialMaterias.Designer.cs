namespace GestionEstudiantil.WindowsForm
{
    partial class FrmHistorialMaterias
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
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            ColMateria = new DataGridViewTextBoxColumn();
            ColFechaCursada = new DataGridViewTextBoxColumn();
            ColEstadoMateria = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button3);
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 595;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColMateria, ColFechaCursada, ColEstadoMateria });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(595, 450);
            dataGridView1.TabIndex = 0;
            // 
            // ColMateria
            // 
            ColMateria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColMateria.HeaderText = "Materia";
            ColMateria.Name = "ColMateria";
            ColMateria.ReadOnly = true;
            // 
            // ColFechaCursada
            // 
            ColFechaCursada.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColFechaCursada.HeaderText = "Año";
            ColFechaCursada.Name = "ColFechaCursada";
            ColFechaCursada.ReadOnly = true;
            // 
            // ColEstadoMateria
            // 
            ColEstadoMateria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColEstadoMateria.HeaderText = "Estado";
            ColEstadoMateria.Name = "ColEstadoMateria";
            ColEstadoMateria.ReadOnly = true;
            // 
            // button3
            // 
            button3.Location = new Point(52, 129);
            button3.Name = "button3";
            button3.Size = new Size(106, 35);
            button3.TabIndex = 5;
            button3.Text = "Eliminar Registro";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(52, 71);
            button2.Name = "button2";
            button2.Size = new Size(106, 35);
            button2.TabIndex = 4;
            button2.Text = "Editar Registro";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(52, 12);
            button1.Name = "button1";
            button1.Size = new Size(106, 35);
            button1.TabIndex = 3;
            button1.Text = "Nuevo Registro";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmHistorialMaterias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "FrmHistorialMaterias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HistorialFinalesAprobados";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridViewTextBoxColumn ColMateria;
        private DataGridViewTextBoxColumn ColFechaCursada;
        private DataGridViewTextBoxColumn ColEstadoMateria;
    }
}