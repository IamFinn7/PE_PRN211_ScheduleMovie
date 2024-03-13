namespace Q1
{
    partial class RoomManager
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
            lbList = new Label();
            cboRoom = new ComboBox();
            lbSelected = new Label();
            dgvShow = new DataGridView();
            gbAddSchedule = new GroupBox();
            btnAdd = new Button();
            lbEnd = new Label();
            lbStart = new Label();
            cboTimeSlot = new ComboBox();
            lbTime = new Label();
            cboMovie = new ComboBox();
            lbMovie = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvShow).BeginInit();
            gbAddSchedule.SuspendLayout();
            SuspendLayout();
            // 
            // lbList
            // 
            lbList.AutoSize = true;
            lbList.Location = new Point(33, 51);
            lbList.Name = "lbList";
            lbList.Size = new Size(109, 25);
            lbList.TabIndex = 0;
            lbList.Text = "List of room";
            // 
            // cboRoom
            // 
            cboRoom.FormattingEnabled = true;
            cboRoom.Location = new Point(148, 43);
            cboRoom.Name = "cboRoom";
            cboRoom.Size = new Size(241, 33);
            cboRoom.TabIndex = 1;
            cboRoom.TextChanged += cboRoom_TextChanged;
            // 
            // lbSelected
            // 
            lbSelected.AutoSize = true;
            lbSelected.Location = new Point(31, 123);
            lbSelected.Name = "lbSelected";
            lbSelected.Size = new Size(231, 25);
            lbSelected.TabIndex = 2;
            lbSelected.Text = "Schedules of selected room";
            // 
            // dgvShow
            // 
            dgvShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShow.Location = new Point(31, 163);
            dgvShow.Name = "dgvShow";
            dgvShow.RowHeadersWidth = 62;
            dgvShow.RowTemplate.Height = 33;
            dgvShow.Size = new Size(696, 324);
            dgvShow.TabIndex = 3;
            // 
            // gbAddSchedule
            // 
            gbAddSchedule.Controls.Add(dtpEndDate);
            gbAddSchedule.Controls.Add(dtpStartDate);
            gbAddSchedule.Controls.Add(btnAdd);
            gbAddSchedule.Controls.Add(lbEnd);
            gbAddSchedule.Controls.Add(lbStart);
            gbAddSchedule.Controls.Add(cboTimeSlot);
            gbAddSchedule.Controls.Add(lbTime);
            gbAddSchedule.Controls.Add(cboMovie);
            gbAddSchedule.Controls.Add(lbMovie);
            gbAddSchedule.Location = new Point(779, 123);
            gbAddSchedule.Name = "gbAddSchedule";
            gbAddSchedule.Size = new Size(381, 314);
            gbAddSchedule.TabIndex = 4;
            gbAddSchedule.TabStop = false;
            gbAddSchedule.Text = "Add Schedule";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(122, 262);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(187, 34);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add schedule";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbEnd
            // 
            lbEnd.AutoSize = true;
            lbEnd.Location = new Point(14, 200);
            lbEnd.Name = "lbEnd";
            lbEnd.Size = new Size(84, 25);
            lbEnd.TabIndex = 13;
            lbEnd.Text = "End Date";
            // 
            // lbStart
            // 
            lbStart.AutoSize = true;
            lbStart.Location = new Point(14, 149);
            lbStart.Name = "lbStart";
            lbStart.Size = new Size(90, 25);
            lbStart.TabIndex = 11;
            lbStart.Text = "Start Date";
            // 
            // cboTimeSlot
            // 
            cboTimeSlot.FormattingEnabled = true;
            cboTimeSlot.Location = new Point(122, 92);
            cboTimeSlot.Name = "cboTimeSlot";
            cboTimeSlot.Size = new Size(241, 33);
            cboTimeSlot.TabIndex = 8;
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Location = new Point(14, 100);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(81, 25);
            lbTime.TabIndex = 9;
            lbTime.Text = "TimeSlot";
            // 
            // cboMovie
            // 
            cboMovie.FormattingEnabled = true;
            cboMovie.Location = new Point(122, 40);
            cboMovie.Name = "cboMovie";
            cboMovie.Size = new Size(241, 33);
            cboMovie.TabIndex = 6;
            // 
            // lbMovie
            // 
            lbMovie.AutoSize = true;
            lbMovie.Location = new Point(14, 48);
            lbMovie.Name = "lbMovie";
            lbMovie.Size = new Size(61, 25);
            lbMovie.TabIndex = 7;
            lbMovie.Text = "Movie";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(122, 143);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(241, 31);
            dtpStartDate.TabIndex = 15;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(122, 194);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(241, 31);
            dtpEndDate.TabIndex = 16;
            // 
            // RoomManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 552);
            Controls.Add(gbAddSchedule);
            Controls.Add(dgvShow);
            Controls.Add(lbSelected);
            Controls.Add(cboRoom);
            Controls.Add(lbList);
            Name = "RoomManager";
            Text = "RoomManager";
            ((System.ComponentModel.ISupportInitialize)dgvShow).EndInit();
            gbAddSchedule.ResumeLayout(false);
            gbAddSchedule.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbList;
        private ComboBox cboRoom;
        private Label lbSelected;
        private DataGridView dgvShow;
        private GroupBox gbAddSchedule;
        private Button btnAdd;
        private Label lbEnd;
        private Label lbStart;
        private ComboBox cboTimeSlot;
        private Label lbTime;
        private ComboBox cboMovie;
        private Label lbMovie;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
    }
}