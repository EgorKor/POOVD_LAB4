
namespace POOVD_LAB4
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LoadFileButton = new System.Windows.Forms.Button();
            this.LoadedFileNameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Shift0RadioButton = new System.Windows.Forms.RadioButton();
            this.Shift1RadioButton = new System.Windows.Forms.RadioButton();
            this.Shift2RadioButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LeftControllerLabel = new System.Windows.Forms.Label();
            this.RightControllerLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RightRangeComboBox = new System.Windows.Forms.ComboBox();
            this.MiddleRangeComboBox = new System.Windows.Forms.ComboBox();
            this.LeftRangeComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LeftTrackBar = new System.Windows.Forms.TrackBar();
            this.RightTrackBar = new System.Windows.Forms.TrackBar();
            this.FixTrackBarsCheckBox = new System.Windows.Forms.CheckBox();
            this.ColorPictureBox = new System.Windows.Forms.PictureBox();
            this.DownRowButton = new System.Windows.Forms.Button();
            this.UpRowButton = new System.Windows.Forms.Button();
            this.GistogrammaPictureBox = new System.Windows.Forms.PictureBox();
            this.OverviewPictureBox = new System.Windows.Forms.PictureBox();
            this.ObservedPictureBox = new System.Windows.Forms.PictureBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GistogrammaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverviewPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObservedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 116);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(524, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 61);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Прокрутка";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(47, 23);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "шаг:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LoadFileButton);
            this.groupBox2.Controls.Add(this.LoadedFileNameLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(42, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 75);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "загрузка mbv файла";
            // 
            // LoadFileButton
            // 
            this.LoadFileButton.Location = new System.Drawing.Point(6, 36);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(99, 33);
            this.LoadFileButton.TabIndex = 1;
            this.LoadFileButton.Text = "загрузить";
            this.LoadFileButton.UseVisualStyleBackColor = true;
            this.LoadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // LoadedFileNameLabel
            // 
            this.LoadedFileNameLabel.AutoSize = true;
            this.LoadedFileNameLabel.Location = new System.Drawing.Point(116, 42);
            this.LoadedFileNameLabel.Name = "LoadedFileNameLabel";
            this.LoadedFileNameLabel.Size = new System.Drawing.Size(201, 20);
            this.LoadedFileNameLabel.TabIndex = 2;
            this.LoadedFileNameLabel.Text = "нет загруженных файлов";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Shift0RadioButton);
            this.groupBox1.Controls.Add(this.Shift1RadioButton);
            this.groupBox1.Controls.Add(this.Shift2RadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(371, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 48);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сдвигать коды на";
            // 
            // Shift0RadioButton
            // 
            this.Shift0RadioButton.AutoSize = true;
            this.Shift0RadioButton.Checked = true;
            this.Shift0RadioButton.Location = new System.Drawing.Point(6, 19);
            this.Shift0RadioButton.Name = "Shift0RadioButton";
            this.Shift0RadioButton.Size = new System.Drawing.Size(36, 24);
            this.Shift0RadioButton.TabIndex = 4;
            this.Shift0RadioButton.TabStop = true;
            this.Shift0RadioButton.Text = "0";
            this.Shift0RadioButton.UseVisualStyleBackColor = true;
            this.Shift0RadioButton.CheckedChanged += new System.EventHandler(this.Shift0RadioButton_CheckedChanged);
            // 
            // Shift1RadioButton
            // 
            this.Shift1RadioButton.AutoSize = true;
            this.Shift1RadioButton.Location = new System.Drawing.Point(43, 19);
            this.Shift1RadioButton.Name = "Shift1RadioButton";
            this.Shift1RadioButton.Size = new System.Drawing.Size(36, 24);
            this.Shift1RadioButton.TabIndex = 6;
            this.Shift1RadioButton.Text = "1";
            this.Shift1RadioButton.UseVisualStyleBackColor = true;
            this.Shift1RadioButton.CheckedChanged += new System.EventHandler(this.Shift1RadioButton_CheckedChanged);
            // 
            // Shift2RadioButton
            // 
            this.Shift2RadioButton.AutoSize = true;
            this.Shift2RadioButton.Location = new System.Drawing.Point(84, 19);
            this.Shift2RadioButton.Name = "Shift2RadioButton";
            this.Shift2RadioButton.Size = new System.Drawing.Size(36, 24);
            this.Shift2RadioButton.TabIndex = 5;
            this.Shift2RadioButton.Text = "2";
            this.Shift2RadioButton.UseVisualStyleBackColor = true;
            this.Shift2RadioButton.CheckedChanged += new System.EventHandler(this.Shift2RadioButton_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LeftControllerLabel);
            this.panel2.Controls.Add(this.RightControllerLabel);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.RightRangeComboBox);
            this.panel2.Controls.Add(this.MiddleRangeComboBox);
            this.panel2.Controls.Add(this.LeftRangeComboBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.LeftTrackBar);
            this.panel2.Controls.Add(this.RightTrackBar);
            this.panel2.Controls.Add(this.FixTrackBarsCheckBox);
            this.panel2.Controls.Add(this.ColorPictureBox);
            this.panel2.Controls.Add(this.DownRowButton);
            this.panel2.Controls.Add(this.UpRowButton);
            this.panel2.Controls.Add(this.GistogrammaPictureBox);
            this.panel2.Controls.Add(this.OverviewPictureBox);
            this.panel2.Controls.Add(this.ObservedPictureBox);
            this.panel2.Location = new System.Drawing.Point(1, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1223, 675);
            this.panel2.TabIndex = 1;
            // 
            // LeftControllerLabel
            // 
            this.LeftControllerLabel.AutoSize = true;
            this.LeftControllerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftControllerLabel.Location = new System.Drawing.Point(341, 380);
            this.LeftControllerLabel.Name = "LeftControllerLabel";
            this.LeftControllerLabel.Size = new System.Drawing.Size(18, 20);
            this.LeftControllerLabel.TabIndex = 21;
            this.LeftControllerLabel.Text = "0";
            // 
            // RightControllerLabel
            // 
            this.RightControllerLabel.AutoSize = true;
            this.RightControllerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightControllerLabel.Location = new System.Drawing.Point(341, 329);
            this.RightControllerLabel.Name = "RightControllerLabel";
            this.RightControllerLabel.Size = new System.Drawing.Size(36, 20);
            this.RightControllerLabel.TabIndex = 20;
            this.RightControllerLabel.Text = "255";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(33, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(417, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Гистограмма яркостей визуализируемого фрагмента";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(158, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Закон преобразования";
            // 
            // RightRangeComboBox
            // 
            this.RightRangeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RightRangeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightRangeComboBox.FormattingEnabled = true;
            this.RightRangeComboBox.Items.AddRange(new object[] {
            "Оставить исходными",
            "Заменить на R",
            "Заменить на max"});
            this.RightRangeComboBox.Location = new System.Drawing.Point(133, 602);
            this.RightRangeComboBox.Name = "RightRangeComboBox";
            this.RightRangeComboBox.Size = new System.Drawing.Size(305, 28);
            this.RightRangeComboBox.TabIndex = 17;
            this.RightRangeComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // MiddleRangeComboBox
            // 
            this.MiddleRangeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MiddleRangeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddleRangeComboBox.FormattingEnabled = true;
            this.MiddleRangeComboBox.Items.AddRange(new object[] {
            "Оставить исходными",
            "Линейное масштабирование [0; max]",
            "Линейное масштабирование [L; max]",
            "Линейное масштабирование [0; R]."});
            this.MiddleRangeComboBox.Location = new System.Drawing.Point(133, 566);
            this.MiddleRangeComboBox.Name = "MiddleRangeComboBox";
            this.MiddleRangeComboBox.Size = new System.Drawing.Size(305, 28);
            this.MiddleRangeComboBox.TabIndex = 16;
            this.MiddleRangeComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // LeftRangeComboBox
            // 
            this.LeftRangeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LeftRangeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftRangeComboBox.FormattingEnabled = true;
            this.LeftRangeComboBox.Items.AddRange(new object[] {
            "Оставить исходными",
            "Заменить на 0",
            "Заменить на L"});
            this.LeftRangeComboBox.Location = new System.Drawing.Point(133, 532);
            this.LeftRangeComboBox.Name = "LeftRangeComboBox";
            this.LeftRangeComboBox.Size = new System.Drawing.Size(305, 28);
            this.LeftRangeComboBox.TabIndex = 15;
            this.LeftRangeComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(48, 610);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "(R; 255]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(48, 569);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "[ L ; R ]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(48, 530);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "[ 0 ; L )";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(44, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Диапазон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Левый:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Правый:";
            // 
            // LeftTrackBar
            // 
            this.LeftTrackBar.LargeChange = 1;
            this.LeftTrackBar.Location = new System.Drawing.Point(71, 380);
            this.LeftTrackBar.Maximum = 255;
            this.LeftTrackBar.Name = "LeftTrackBar";
            this.LeftTrackBar.Size = new System.Drawing.Size(256, 45);
            this.LeftTrackBar.TabIndex = 8;
            this.LeftTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.LeftTrackBar.Scroll += new System.EventHandler(this.LeftTrackBar_Scroll);
            // 
            // RightTrackBar
            // 
            this.RightTrackBar.LargeChange = 1;
            this.RightTrackBar.Location = new System.Drawing.Point(71, 329);
            this.RightTrackBar.Maximum = 255;
            this.RightTrackBar.Name = "RightTrackBar";
            this.RightTrackBar.Size = new System.Drawing.Size(256, 45);
            this.RightTrackBar.TabIndex = 7;
            this.RightTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RightTrackBar.Value = 255;
            this.RightTrackBar.Scroll += new System.EventHandler(this.RightTrackBar_Scroll);
            // 
            // FixTrackBarsCheckBox
            // 
            this.FixTrackBarsCheckBox.AutoSize = true;
            this.FixTrackBarsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FixTrackBarsCheckBox.Location = new System.Drawing.Point(48, 422);
            this.FixTrackBarsCheckBox.Name = "FixTrackBarsCheckBox";
            this.FixTrackBarsCheckBox.Size = new System.Drawing.Size(212, 24);
            this.FixTrackBarsCheckBox.TabIndex = 6;
            this.FixTrackBarsCheckBox.Text = "Зафиксировать движки";
            this.FixTrackBarsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ColorPictureBox
            // 
            this.ColorPictureBox.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.ColorPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ColorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorPictureBox.Location = new System.Drawing.Point(71, 292);
            this.ColorPictureBox.Name = "ColorPictureBox";
            this.ColorPictureBox.Size = new System.Drawing.Size(256, 30);
            this.ColorPictureBox.TabIndex = 5;
            this.ColorPictureBox.TabStop = false;
            // 
            // DownRowButton
            // 
            this.DownRowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DownRowButton.Location = new System.Drawing.Point(485, 636);
            this.DownRowButton.Name = "DownRowButton";
            this.DownRowButton.Size = new System.Drawing.Size(100, 32);
            this.DownRowButton.TabIndex = 4;
            this.DownRowButton.Text = "↓";
            this.DownRowButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DownRowButton.UseVisualStyleBackColor = true;
            this.DownRowButton.Click += new System.EventHandler(this.DownRowButton_Click);
            // 
            // UpRowButton
            // 
            this.UpRowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpRowButton.Location = new System.Drawing.Point(485, -1);
            this.UpRowButton.Name = "UpRowButton";
            this.UpRowButton.Size = new System.Drawing.Size(100, 30);
            this.UpRowButton.TabIndex = 3;
            this.UpRowButton.Text = "↑";
            this.UpRowButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UpRowButton.UseVisualStyleBackColor = true;
            this.UpRowButton.Click += new System.EventHandler(this.UpRowButton_Click);
            // 
            // GistogrammaPictureBox
            // 
            this.GistogrammaPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GistogrammaPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GistogrammaPictureBox.Location = new System.Drawing.Point(71, 30);
            this.GistogrammaPictureBox.Name = "GistogrammaPictureBox";
            this.GistogrammaPictureBox.Size = new System.Drawing.Size(256, 256);
            this.GistogrammaPictureBox.TabIndex = 2;
            this.GistogrammaPictureBox.TabStop = false;
            // 
            // OverviewPictureBox
            // 
            this.OverviewPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OverviewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OverviewPictureBox.Location = new System.Drawing.Point(485, 30);
            this.OverviewPictureBox.Name = "OverviewPictureBox";
            this.OverviewPictureBox.Size = new System.Drawing.Size(100, 600);
            this.OverviewPictureBox.TabIndex = 1;
            this.OverviewPictureBox.TabStop = false;
            // 
            // ObservedPictureBox
            // 
            this.ObservedPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ObservedPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ObservedPictureBox.Location = new System.Drawing.Point(593, 30);
            this.ObservedPictureBox.Name = "ObservedPictureBox";
            this.ObservedPictureBox.Size = new System.Drawing.Size(500, 500);
            this.ObservedPictureBox.TabIndex = 0;
            this.ObservedPictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 795);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GistogrammaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverviewPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObservedPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LoadedFileNameLabel;
        private System.Windows.Forms.Button LoadFileButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton Shift1RadioButton;
        private System.Windows.Forms.RadioButton Shift2RadioButton;
        private System.Windows.Forms.RadioButton Shift0RadioButton;
        private System.Windows.Forms.PictureBox GistogrammaPictureBox;
        private System.Windows.Forms.PictureBox OverviewPictureBox;
        private System.Windows.Forms.PictureBox ObservedPictureBox;
        private System.Windows.Forms.Button DownRowButton;
        private System.Windows.Forms.Button UpRowButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ColorPictureBox;
        private System.Windows.Forms.CheckBox FixTrackBarsCheckBox;
        private System.Windows.Forms.TrackBar LeftTrackBar;
        private System.Windows.Forms.TrackBar RightTrackBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RightRangeComboBox;
        private System.Windows.Forms.ComboBox MiddleRangeComboBox;
        private System.Windows.Forms.ComboBox LeftRangeComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LeftControllerLabel;
        private System.Windows.Forms.Label RightControllerLabel;
    }
}

