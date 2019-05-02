namespace GUI_WFA
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
            this.components = new System.ComponentModel.Container();
            this.deg1Out = new System.Windows.Forms.Label();
            this.deg2Out = new System.Windows.Forms.Label();
            this.m1Lbl = new System.Windows.Forms.Label();
            this.m2Lbl = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.ports = new System.Windows.Forms.Label();
            this.cnctBtn = new System.Windows.Forms.Button();
            this.portList = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.set1 = new System.Windows.Forms.Button();
            this.set2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deg1Out
            // 
            this.deg1Out.AutoSize = true;
            this.deg1Out.Dock = System.Windows.Forms.DockStyle.Top;
            this.deg1Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deg1Out.Location = new System.Drawing.Point(4, 81);
            this.deg1Out.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deg1Out.Name = "deg1Out";
            this.deg1Out.Size = new System.Drawing.Size(168, 29);
            this.deg1Out.TabIndex = 0;
            this.deg1Out.Text = "text";
            this.deg1Out.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // deg2Out
            // 
            this.deg2Out.AutoSize = true;
            this.deg2Out.Dock = System.Windows.Forms.DockStyle.Top;
            this.deg2Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deg2Out.Location = new System.Drawing.Point(356, 81);
            this.deg2Out.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deg2Out.Name = "deg2Out";
            this.deg2Out.Size = new System.Drawing.Size(169, 29);
            this.deg2Out.TabIndex = 0;
            this.deg2Out.Text = "text";
            this.deg2Out.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // m1Lbl
            // 
            this.m1Lbl.AutoSize = true;
            this.m1Lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1Lbl.Location = new System.Drawing.Point(4, 0);
            this.m1Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m1Lbl.Name = "m1Lbl";
            this.m1Lbl.Size = new System.Drawing.Size(168, 35);
            this.m1Lbl.TabIndex = 0;
            this.m1Lbl.Text = "Motor 1";
            this.m1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m2Lbl
            // 
            this.m2Lbl.AutoSize = true;
            this.m2Lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m2Lbl.Location = new System.Drawing.Point(356, 0);
            this.m2Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2Lbl.Name = "m2Lbl";
            this.m2Lbl.Size = new System.Drawing.Size(169, 35);
            this.m2Lbl.TabIndex = 0;
            this.m2Lbl.Text = "Motor 2";
            this.m2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(4, 38);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(168, 36);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyUp);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(356, 38);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(169, 36);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown2_KeyUp);
            // 
            // ports
            // 
            this.ports.AutoSize = true;
            this.ports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ports.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ports.Location = new System.Drawing.Point(4, 186);
            this.ports.Margin = new System.Windows.Forms.Padding(4, 0, 4, 7);
            this.ports.Name = "ports";
            this.ports.Size = new System.Drawing.Size(168, 65);
            this.ports.TabIndex = 0;
            this.ports.Text = "Port";
            this.ports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cnctBtn
            // 
            this.cnctBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cnctBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnctBtn.Location = new System.Drawing.Point(356, 189);
            this.cnctBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 1);
            this.cnctBtn.Name = "cnctBtn";
            this.cnctBtn.Size = new System.Drawing.Size(169, 68);
            this.cnctBtn.TabIndex = 3;
            this.cnctBtn.Text = "Connect";
            this.cnctBtn.UseVisualStyleBackColor = true;
            this.cnctBtn.Click += new System.EventHandler(this.cnctBtn_Click);
            // 
            // portList
            // 
            this.portList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portList.FormattingEnabled = true;
            this.portList.Location = new System.Drawing.Point(180, 206);
            this.portList.Margin = new System.Windows.Forms.Padding(4, 20, 4, 3);
            this.portList.Name = "portList";
            this.portList.Size = new System.Drawing.Size(168, 37);
            this.portList.TabIndex = 4;
            this.portList.DropDown += new System.EventHandler(this.portList_DropDown);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // set1
            // 
            this.set1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set1.Location = new System.Drawing.Point(4, 119);
            this.set1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.set1.Name = "set1";
            this.set1.Size = new System.Drawing.Size(168, 64);
            this.set1.TabIndex = 5;
            this.set1.Text = "Set motor 1";
            this.set1.UseVisualStyleBackColor = true;
            this.set1.Click += new System.EventHandler(this.set1_Click);
            // 
            // set2
            // 
            this.set2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set2.Location = new System.Drawing.Point(356, 119);
            this.set2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.set2.Name = "set2";
            this.set2.Size = new System.Drawing.Size(169, 64);
            this.set2.TabIndex = 6;
            this.set2.Text = "Set motor 2";
            this.set2.UseVisualStyleBackColor = true;
            this.set2.Click += new System.EventHandler(this.set2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.deg2Out, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cnctBtn, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.deg1Out, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.portList, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.set1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.set2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.m1Lbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ports, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.m2Lbl, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown2, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 13);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(529, 258);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 283);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(2747, 1030);
            this.MinimumSize = new System.Drawing.Size(580, 330);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "2 DoF tilt stage";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label deg1Out;
        private System.Windows.Forms.Label deg2Out;
        private System.Windows.Forms.Label m1Lbl;
        private System.Windows.Forms.Label m2Lbl;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label ports;
        private System.Windows.Forms.Button cnctBtn;
        private System.Windows.Forms.ComboBox portList;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button set1;
        private System.Windows.Forms.Button set2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

