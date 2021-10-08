
namespace ShutdownTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericManual = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbHours = new System.Windows.Forms.RadioButton();
            this.rbMinutes = new System.Windows.Forms.RadioButton();
            this.buttonSetTime = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button45 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5h = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10h = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCancelProcess = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textAbout = new System.Windows.Forms.RichTextBox();
            this.textSetTime = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericManual)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Blue;
            this.progressBar1.ForeColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(3, 28);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar1.Size = new System.Drawing.Size(274, 23);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manual\r\nMode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numericManual);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbHours);
            this.panel1.Controls.Add(this.rbMinutes);
            this.panel1.Controls.Add(this.buttonSetTime);
            this.panel1.Location = new System.Drawing.Point(12, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 71);
            this.panel1.TabIndex = 4;
            // 
            // numericManual
            // 
            this.numericManual.BackColor = System.Drawing.Color.Gainsboro;
            this.numericManual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericManual.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericManual.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericManual.Location = new System.Drawing.Point(78, 35);
            this.numericManual.Name = "numericManual";
            this.numericManual.Size = new System.Drawing.Size(157, 19);
            this.numericManual.TabIndex = 12;
            this.numericManual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericManual.ValueChanged += new System.EventHandler(this.rbClick);
            this.numericManual.Click += new System.EventHandler(this.rbClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(36, 110);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // rbHours
            // 
            this.rbHours.AutoSize = true;
            this.rbHours.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHours.Location = new System.Drawing.Point(151, 17);
            this.rbHours.Name = "rbHours";
            this.rbHours.Size = new System.Drawing.Size(55, 17);
            this.rbHours.TabIndex = 5;
            this.rbHours.TabStop = true;
            this.rbHours.Text = "Hours";
            this.rbHours.UseVisualStyleBackColor = true;
            this.rbHours.Click += new System.EventHandler(this.rbClick);
            // 
            // rbMinutes
            // 
            this.rbMinutes.AutoSize = true;
            this.rbMinutes.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMinutes.Location = new System.Drawing.Point(78, 17);
            this.rbMinutes.Name = "rbMinutes";
            this.rbMinutes.Size = new System.Drawing.Size(67, 17);
            this.rbMinutes.TabIndex = 5;
            this.rbMinutes.TabStop = true;
            this.rbMinutes.Text = "Minutes";
            this.rbMinutes.UseVisualStyleBackColor = true;
            this.rbMinutes.Click += new System.EventHandler(this.rbClick);
            // 
            // buttonSetTime
            // 
            this.buttonSetTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSetTime.BackColor = System.Drawing.Color.Silver;
            this.buttonSetTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSetTime.Location = new System.Drawing.Point(241, 35);
            this.buttonSetTime.Name = "buttonSetTime";
            this.buttonSetTime.Size = new System.Drawing.Size(35, 20);
            this.buttonSetTime.TabIndex = 0;
            this.buttonSetTime.Text = "Set";
            this.buttonSetTime.UseVisualStyleBackColor = false;
            this.buttonSetTime.Click += new System.EventHandler(this.buttonSetTime_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(78, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 25);
            this.button5.TabIndex = 0;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button10.BackColor = System.Drawing.Color.Silver;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Location = new System.Drawing.Point(119, 22);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(35, 25);
            this.button10.TabIndex = 0;
            this.button10.Text = "10";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button15
            // 
            this.button15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button15.BackColor = System.Drawing.Color.Silver;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.Location = new System.Drawing.Point(160, 22);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(35, 25);
            this.button15.TabIndex = 0;
            this.button15.Text = "15";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button30
            // 
            this.button30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button30.BackColor = System.Drawing.Color.Silver;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button30.Location = new System.Drawing.Point(201, 22);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(35, 25);
            this.button30.TabIndex = 0;
            this.button30.Text = "30";
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minutes:";
            // 
            // button45
            // 
            this.button45.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button45.BackColor = System.Drawing.Color.Silver;
            this.button45.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button45.Location = new System.Drawing.Point(242, 22);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(35, 25);
            this.button45.TabIndex = 0;
            this.button45.Text = "45";
            this.button45.UseVisualStyleBackColor = false;
            this.button45.Click += new System.EventHandler(this.button45_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hours:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(78, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(119, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 25);
            this.button2.TabIndex = 0;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(160, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 25);
            this.button3.TabIndex = 0;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(201, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 25);
            this.button4.TabIndex = 0;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5h
            // 
            this.button5h.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5h.BackColor = System.Drawing.Color.Silver;
            this.button5h.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5h.Location = new System.Drawing.Point(242, 73);
            this.button5h.Name = "button5h";
            this.button5h.Size = new System.Drawing.Size(35, 25);
            this.button5h.TabIndex = 0;
            this.button5h.Text = "5";
            this.button5h.UseVisualStyleBackColor = false;
            this.button5h.Click += new System.EventHandler(this.button5h_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.BackColor = System.Drawing.Color.Silver;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(78, 108);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 25);
            this.button6.TabIndex = 0;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.BackColor = System.Drawing.Color.Silver;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(119, 108);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 25);
            this.button7.TabIndex = 0;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.BackColor = System.Drawing.Color.Silver;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(160, 108);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 25);
            this.button8.TabIndex = 0;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.BackColor = System.Drawing.Color.Silver;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Location = new System.Drawing.Point(201, 108);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(35, 25);
            this.button9.TabIndex = 0;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10h
            // 
            this.button10h.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button10h.BackColor = System.Drawing.Color.Silver;
            this.button10h.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10h.Location = new System.Drawing.Point(242, 108);
            this.button10h.Name = "button10h";
            this.button10h.Size = new System.Drawing.Size(35, 25);
            this.button10h.TabIndex = 0;
            this.button10h.Text = "10";
            this.button10h.UseVisualStyleBackColor = false;
            this.button10h.Click += new System.EventHandler(this.button10h_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.button45, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button30, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.button15, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button5h, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button10, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button10h, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.button9, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.button8, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 116);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(281, 141);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // buttonExecute
            // 
            this.buttonExecute.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExecute.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonExecute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExecute.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExecute.Location = new System.Drawing.Point(78, 11);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(121, 31);
            this.buttonExecute.TabIndex = 7;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = false;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Time Left to Shutdown:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(193, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "0";
            // 
            // buttonCancelProcess
            // 
            this.buttonCancelProcess.BackColor = System.Drawing.Color.DarkRed;
            this.buttonCancelProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelProcess.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelProcess.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCancelProcess.Location = new System.Drawing.Point(78, 48);
            this.buttonCancelProcess.Name = "buttonCancelProcess";
            this.buttonCancelProcess.Size = new System.Drawing.Size(121, 23);
            this.buttonCancelProcess.TabIndex = 9;
            this.buttonCancelProcess.Text = "Cancel Process";
            this.buttonCancelProcess.UseVisualStyleBackColor = false;
            this.buttonCancelProcess.Visible = false;
            this.buttonCancelProcess.Click += new System.EventHandler(this.buttonCancelProcess_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 69);
            this.panel2.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(241, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "secs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(244, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "mins";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.buttonExecute);
            this.panel3.Controls.Add(this.buttonCancelProcess);
            this.panel3.Location = new System.Drawing.Point(12, 353);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 80);
            this.panel3.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ShutdownTimer.Properties.Resources.Untitled_2;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(205, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShutdownTimer.Properties.Resources.hardenedCOTTONcharmLOGO;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(41, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "HardenedCotton © 2021. All Rights Reserved.";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.DarkRed;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(248, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(45, 23);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAbout.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.Location = new System.Drawing.Point(12, 4);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(45, 23);
            this.buttonAbout.TabIndex = 13;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            this.buttonAbout.MouseEnter += new System.EventHandler(this.buttonAbout_MouseEnter);
            this.buttonAbout.MouseLeave += new System.EventHandler(this.buttonAbout_MouseLeave);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitle.Font = new System.Drawing.Font("Consolas", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(54, 1);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(194, 28);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "SHUTDOWN TIMER";
            // 
            // textAbout
            // 
            this.textAbout.BackColor = System.Drawing.Color.Gainsboro;
            this.textAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAbout.DetectUrls = false;
            this.textAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textAbout.Location = new System.Drawing.Point(13, 30);
            this.textAbout.MaxLength = 64;
            this.textAbout.Name = "textAbout";
            this.textAbout.ReadOnly = true;
            this.textAbout.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.textAbout.Size = new System.Drawing.Size(154, 60);
            this.textAbout.TabIndex = 14;
            this.textAbout.Text = "Click this button to acces my Instagram page";
            this.textAbout.Visible = false;
            // 
            // textSetTime
            // 
            this.textSetTime.BackColor = System.Drawing.Color.DarkGray;
            this.textSetTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSetTime.CausesValidation = false;
            this.textSetTime.Cursor = System.Windows.Forms.Cursors.No;
            this.textSetTime.DetectUrls = false;
            this.textSetTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetTime.ForeColor = System.Drawing.Color.DarkRed;
            this.textSetTime.Location = new System.Drawing.Point(90, 353);
            this.textSetTime.MaxLength = 64;
            this.textSetTime.Name = "textSetTime";
            this.textSetTime.ReadOnly = true;
            this.textSetTime.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.textSetTime.ShortcutsEnabled = false;
            this.textSetTime.Size = new System.Drawing.Size(121, 79);
            this.textSetTime.TabIndex = 14;
            this.textSetTime.Text = "Press \"Set\" in order to apply entered value";
            this.textSetTime.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(305, 455);
            this.Controls.Add(this.textSetTime);
            this.Controls.Add(this.textAbout);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Shutdown Timer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericManual)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5h;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button10h;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.RadioButton rbMinutes;
        private System.Windows.Forms.RadioButton rbHours;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCancelProcess;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.NumericUpDown numericManual;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSetTime;
        private System.Windows.Forms.RichTextBox textAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox textSetTime;
    }
}

